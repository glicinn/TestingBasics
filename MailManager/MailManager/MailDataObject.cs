using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailStub
{
    internal class MailDataObject
    {
        public List<string> GetEmails()
        {
            SqlConnection connection = new SqlConnection(@"Data Source = HOME-PC\SQLMATVEY; Initial Catalog = Email; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("select [Email_Employee] from dbo.[Employee];", connection);
            DataTable table = new DataTable();
            List<string> list = new List<string>();
            try
            {
                connection.Open();
                table.Load(cmd.ExecuteReader());
                foreach (DataRow row in table.Rows)
                {
                    list.Add((string)row[0]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Не найдено");
            }
            finally
            {
                connection.Close();
            }
            return list;
        }
    }
}
