using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LaHuyHoang
{
    internal class STUDENT
    {

        MY_DB mydb = new MY_DB();

        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {

            //command
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)" +
         "VALUES (@id,@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.VarChar).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getStudent(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool editStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname = @fn, lname = @ln, bdate = @bdt, " +
                                                          "gender = @gdr, phone = @phn, address = @adrs, picture = @pic WHERE id = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.VarChar).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            } // Return true if at least one row is affected (updated)

        }


        public bool deleteStudent(int id)
        {

            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id = @id", mydb.getConnection);
                
            command.Parameters.AddWithValue("@id", id);

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            } // Return true if exactly one row is deleted
        }
            
        

    }
}
