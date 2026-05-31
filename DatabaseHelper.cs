using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    /// <summary>
    /// Database Helper Class for SQL Server Operations
    /// Handles all database connections and queries
    /// </summary>
    public static class DatabaseHelper
    {
        // Connection String - Fixed format
        private static readonly string connectionString = 
            @"Data Source=QASIM\SQLEXPRESS;Initial Catalog=SchoolManagementSystem;Integrated Security=True;TrustServerCertificate=True;";

        /// <summary>
        /// Get a new SQL Connection
        /// </summary>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// Test database connection
        /// </summary>
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", 
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Execute a query that returns data (SELECT)
        /// </summary>
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        conn.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Query execution failed: {ex.Message}", 
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        /// <summary>
        /// Execute a non-query command (INSERT, UPDATE, DELETE)
        /// Returns the number of rows affected
        /// </summary>
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Command execution failed: {ex.Message}", 
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowsAffected;
        }

        /// <summary>
        /// Execute a scalar query (returns single value)
        /// </summary>
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        result = cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Scalar query failed: {ex.Message}", 
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        /// <summary>
        /// Validate User Login
        /// </summary>
        public static bool ValidateLogin(string username, string password, string userType, out int userId, out int referenceId)
        {
            userId = 0;
            referenceId = 0;

            try
            {
                string query = @"SELECT UserID, ReferenceID 
                                FROM [User] 
                                WHERE Username = @Username 
                                AND Password = @Password 
                                AND UserType = @UserType 
                                AND IsActive = 1";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password),
                    new SqlParameter("@UserType", userType)
                };

                DataTable dt = ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    userId = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    referenceId = dt.Rows[0]["ReferenceID"] != DBNull.Value 
                        ? Convert.ToInt32(dt.Rows[0]["ReferenceID"]) 
                        : 0;

                    // Update last login
                    UpdateLastLogin(userId);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login validation failed: {ex.Message}", 
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        /// <summary>
        /// Update last login timestamp
        /// </summary>
        private static void UpdateLastLogin(int userId)
        {
            try
            {
                string query = "UPDATE [User] SET LastLogin = GETDATE() WHERE UserID = @UserID";
                SqlParameter[] parameters = { new SqlParameter("@UserID", userId) };
                ExecuteNonQuery(query, parameters);
            }
            catch
            {
                // Silently fail - not critical
            }
        }

        /// <summary>
        /// Get user full name by reference ID and type
        /// </summary>
        public static string GetUserFullName(int referenceId, string userType)
        {
            try
            {
                string query = "";
                switch (userType)
                {
                    case "Administrator":
                        query = "SELECT FullName FROM Administrator WHERE AdminID = @ID";
                        break;
                    case "Principal":
                        query = "SELECT FullName FROM Principal WHERE PrincipalID = @ID";
                        break;
                    case "Teacher":
                        query = "SELECT Name FROM Teacher WHERE TeacherID = @ID";
                        break;
                    default:
                        return "Unknown User";
                }

                SqlParameter[] parameters = { new SqlParameter("@ID", referenceId) };
                object result = ExecuteScalar(query, parameters);
                return result?.ToString() ?? "Unknown User";
            }
            catch
            {
                return "Unknown User";
            }
        }
    }
}
