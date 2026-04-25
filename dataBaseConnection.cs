using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp2
{
    class DatabaseConnection
    {
        private static readonly string connectionString =
            "server=seproject-ramalahamir-2382.h.aivencloud.com;port=25561;database=defaultdb;user=avnadmin;password=AVNS_25BoVJPB3omhbsZlxLC;";
        public MySqlConnection connection;

        // Constructor initializes connection
        public DatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        // Open connection
        public void Connect()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    System.Diagnostics.Debug.WriteLine("Connected to MySQL database!");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Connection failed: " + ex.ToString());
            }
        }

        public void Disconnect()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Close connection
        public void Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                System.Diagnostics.Debug.WriteLine("Connection closed.");
            }
        }

        // Get connection object for queries
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        // Function for getting product details from DB
        public DataTable GetProductDetailsFromDB(string productName)
        {
            string query = "SELECT prod_name, price, prod_description FROM Product WHERE prod_name = @ProductName";
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching product details: " + ex.ToString());
            }

            return dt;
        }

        // Function to get the available stock for a product
        public int GetProductStock(string productName)
        {
            string query = "SELECT Quantity_inStock FROM Product WHERE prod_name = @ProductName";
            MySqlCommand cmd = new MySqlCommand(query, GetConnection());
            cmd.Parameters.AddWithValue("@ProductName", productName);

            try
            {
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching product stock: " + ex.ToString());
            }

            return 0;  // Return 0 if product doesn't exist or any error occurs
        }

        // Function to update the product stock
        public bool UpdateProductStock(string productName, decimal quantity)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string updateQuery = "UPDATE Product SET Quantity_inStock = Quantity_inStock - @Quantity WHERE prod_name = @ProductName";
            MySqlCommand updateCmd = new MySqlCommand(updateQuery, GetConnection());
            updateCmd.Parameters.AddWithValue("@Quantity", quantity);
            updateCmd.Parameters.AddWithValue("@ProductName", productName);

            try
            {
                int rowsAffected = updateCmd.ExecuteNonQuery();
                return rowsAffected > 0;  // Returns true if rows were affected (success)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product stock: " + ex.ToString());
                return false;
            }
        }

        public DataTable GetAllProducts()
        {
            string query = "SELECT prod_ID, prod_name, price FROM Product"; // make sure this matches your actual table and column names
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching all products: " + ex.Message);
            }

            return dt;
        }

        public DataTable SearchProducts(string searchQuery)
        {
            // Query to search for products where the product name starts with the search input (case-insensitive)
            string query = "SELECT prod_ID, prod_name, price FROM Product WHERE LOWER(prod_name) LIKE LOWER(@SearchQuery)";

            // Add '%' wildcard at the end of the search term to match any product starting with the input
            searchQuery = searchQuery + "%";

            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchQuery", searchQuery);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for products:\n" + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;  // Return the search result table
        }


        //Funtions to verify user credentials for login

        public bool CheckIfUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM User WHERE username = @Username";
            MySqlCommand cmd = new MySqlCommand(query, GetConnection());
            cmd.Parameters.AddWithValue("@Username", username);

            try
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; // If count > 0, username exists
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username: " + ex.ToString());
                return false;
            }
        }


        public bool CheckIfEmailMatches(string username, string email)
        {
            string query = "SELECT email FROM User WHERE username = @Username";
            MySqlCommand cmd = new MySqlCommand(query, GetConnection());
            cmd.Parameters.AddWithValue("@Username", username);

            try
            {
                //If ExecuteScalar() returns null, it prevents a crash by not calling .ToString() and instead just returns null.
                string storedEmail = cmd.ExecuteScalar()?.ToString();
                return storedEmail == email; // Check if emails match
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking email: " + ex.ToString());
                return false;
            }
        }

        public bool CheckIfPasswordMatches(string username, string password)
        {
            string query = "SELECT password FROM User WHERE username = @Username";
            MySqlCommand cmd = new MySqlCommand(query, GetConnection());
            cmd.Parameters.AddWithValue("@Username", username);

            try
            {
                //If ExecuteScalar() returns null, it prevents a crash by not calling .ToString() and instead just returns null
                string storedPassword = cmd.ExecuteScalar()?.ToString();
                // Check if password matches
                return storedPassword == password; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking password: " + ex.ToString());
                return false;
            }
        }

        public int GetUserIDByUsername(string username)
        {
            string query = "SELECT userID FROM User WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetInt32(0);
            }
            return -1; // not found
        }

        //Funtions to register a user into db
        public bool RegisterUser(string username, string email, string password)
        {
            try
            {
                string query = "INSERT INTO User (username, email, password) VALUES (@Username, @Email, @Password)";
                MySqlCommand cmd = new MySqlCommand(query, GetConnection());
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password); 

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration: " + ex.Message);
                return false;
            }
        }

        public bool StoreCheckoutInfo(int userId, string name, string email, string address, string phone, string paymentMethod, out string message)
        {
            message = "";
            try
            {
                Connect();

                // 1. Always insert a new order
                MySqlCommand orderInsert = new MySqlCommand("INSERT INTO Orders (userID) VALUES (@userId); SELECT LAST_INSERT_ID();", connection);
                orderInsert.Parameters.AddWithValue("@userId", userId);
                int newOrderId = Convert.ToInt32(orderInsert.ExecuteScalar());

                // 2. Check if checkout info already exists
                MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM checkOutInfo WHERE userID = @userId", connection);
                checkCmd.Parameters.AddWithValue("@userId", userId);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count == 0)
                {
                    // 3. Only insert checkout info if not already present
                    MySqlCommand insertCmd = new MySqlCommand("INSERT INTO checkOutInfo (userID, orderID, name, email, address, phone, paymentMethod) VALUES (@userId, @orderId, @name, @email, @address, @phone, @paymentMethod)", connection);
                    insertCmd.Parameters.AddWithValue("@userId", userId);
                    insertCmd.Parameters.AddWithValue("@orderId", newOrderId);
                    insertCmd.Parameters.AddWithValue("@name", name);
                    insertCmd.Parameters.AddWithValue("@email", email);
                    insertCmd.Parameters.AddWithValue("@address", address);
                    insertCmd.Parameters.AddWithValue("@phone", phone);
                    insertCmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);

                    insertCmd.ExecuteNonQuery();
                    message = "Order placed and checkout info saved successfully!";
                }
                else
                {
                    message = "Order placed successfully! Checkout info already exists.";
                }

                return true;
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message;
                return false;
            }
            finally
            {
                Close();
            }
        }

    }
}
