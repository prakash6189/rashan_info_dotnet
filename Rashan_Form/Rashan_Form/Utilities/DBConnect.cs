using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace ConnectCsharpToMysql
{
    public static class DBConnect
    {
        public static MySqlConnection connection;
        private static string server;
        private static string database;
        private static string uid;
        private static string password;
        private static int port;

        //Initialize values
        public static void Initialize()
        {
            server = "103.69.33.229";
            database = "productiondb";
            port = 3306;
            uid = "prakash";
            password = "loser00mysql";
            string connectionString;
            connectionString = "Server=" + server + ";" + "Port=" + port + ";" + "Database=" + database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";SslMode=none;";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
        public static bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Close connection
        public static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public static bool Insert(string insertQuery)
        {
            bool insertFlag = false;
            //string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (OpenConnection())
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

                try
                {
                    //Execute command
                    insertFlag = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (MySqlException msex)
                {
                    insertFlag = false;

                }
                finally
                {
                    //close connection
                    CloseConnection();
                }


            }
            return insertFlag;

        }

        //Update statement
        public static bool Update(string updateQuery)
        {

            bool updateFlag = false;
            //Open connection
            if (OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = updateQuery;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                try
                {
                    //Execute command
                    updateFlag = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (MySqlException msex)
                {
                    updateFlag = false;
                }
                finally
                {
                    CloseConnection();
                }

                //close connection

            }
            return updateFlag;
        }

        //Delete statement
        public static void Delete(string deleteQuery)
        {
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Select statement
        /// <summary>
        /// This function executes select query and returns single column based on column parameter which can be either string(i.e,for column name ) or int (i.e, for column index)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="selectQuery"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static List<object> SelectSingleColumn<T>(string selectQuery, T column)
        {
            //string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<object> list = new List<object>();
            MySqlDataReader dataReader = null;

            //Open connection
            if (OpenConnection())
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                    //Create a data reader and Execute the command
                    dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    if (column.GetType() == typeof(int))
                    {
                        int temp = Convert.ToInt32(column);
                        while (dataReader.Read())
                        {
                            list.Add(dataReader[temp]);
                        }
                    }
                    else if (column.GetType() == typeof(string))
                    {
                        String temp = Convert.ToString(column);
                        while (dataReader.Read())
                        {
                            list.Add(dataReader[temp]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //close Data Reader
                    if (dataReader != null)
                        dataReader.Close();

                    //close Connection
                    CloseConnection();
                }


                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public static List<object> SelectSingleColumnProgram<T>(string selectQuery, T column)
        {
            //string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<object> list = new List<object>();
            MySqlDataReader dataReader = null;

            //Open connection
            if (OpenConnection())
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                    //Create a data reader and Execute the command
                    dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    if (column.GetType() == typeof(int))
                    {
                        int temp = Convert.ToInt32(column);
                        while (dataReader.Read())
                        {
                            list.Add(dataReader[temp]);
                        }
                    }
                    else if (column.GetType() == typeof(string))
                    {
                        String temp = Convert.ToString(column);
                        while (dataReader.Read())
                        {
                            list.Add(dataReader[temp]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //close Data Reader
                    if (dataReader != null)
                        dataReader.Close();

                    //close Connection
                    CloseConnection();
                }


                //return list to be displayed
                return list;
            }
            else
            {
                return null;
            }
        }

        //Count statement
        public static int Count(string countQuery)
        {
            //string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (OpenConnection())
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(countQuery, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public static void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!" + ex.Message);
            }
        }

        //Restore
        public static void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!" + ex.Message);
            }
        }
    }
}
