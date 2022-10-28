using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCRUDOP
{
   
        public class CRUD
        {
            SqlConnection sqlConnection;
            string connectionstring = @"Data Source=.;Initial Catalog=MOBACK;Integrated Security=True";

            public void Createuser(string emp_name ,double  emp_MoNo, string emp_Mail )
            {
                try
                {
                    sqlConnection = new SqlConnection(connectionstring);
                    sqlConnection.Open();
                    Console.WriteLine("Connection established");
                //craete crud
                string insertQuery = "EXEC InsertData" + emp_name + emp_MoNo + emp_Mail;
                    SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("data inserted into the table");
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            public void Readdata(string dept_name, int emp_id, string emp_name)
            {
                try
                {
                    sqlConnection.Open();
                    string displayquery = "select * from Display" + dept_name + emp_id + emp_name;
                    SqlCommand displayCommand = new SqlCommand(displayquery, sqlConnection);
                    SqlDataReader dataReader = displayCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Console.WriteLine("Employee.emp_id" + dataReader.GetValue(0).ToString());
                        Console.WriteLine("Deperment.dept_name" + dataReader.GetValue(1).ToString());
                        Console.WriteLine("Employee.emp_name " + dataReader.GetValue(2).ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            public void updatedata(string emp_name,string emp_Mail)
            {
                try
                {
                    sqlConnection.Open();

                    string updatequery = "EXEC updtdemployee"+emp_Mail+ emp_name;
                    SqlCommand updatecommand = new SqlCommand(updatequery, sqlConnection);
                    updatecommand.ExecuteNonQuery();
                    Console.WriteLine("Data update sucessfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

            public void DeleteDept(double Emp_No)
            {
                try
                {
                    sqlConnection.Open();
                    string deletequery = "Exec SP_DeleteEmploye"+ Emp_No;
                    SqlCommand deletecommand = new SqlCommand(deletequery, sqlConnection);
                    deletecommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        public void InsertDEperment(string DeptName)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionstring);
                sqlConnection.Open();
                Console.WriteLine("Connection established");
                //craete crud
                string insertQuery = "EXEC InsertDept" + DeptName;
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("data inserted into the table");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                sqlConnection.Close();
            }
        }
       
        }
    }
