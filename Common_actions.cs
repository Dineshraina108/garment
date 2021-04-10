using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;
using System.IO.Ports;
namespace LOGIN_MODEL
{
    
    class Common_actions
    {
        public OracleConnection con= new OracleConnection("Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false");
        public OracleDataAdapter oda;
        public string query;
        public void dbcon()
        {
            con.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false";
            con.Open();
        }
        public void dbclose()
        {
            con.Close ();
        }
        public DataTable sel()
        {
            DataTable dt = new DataTable();
            query = "SELECT * FROM GARUREG";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt ;
        }
        public DataTable priv(string uname)
        {
            DataTable dt = new DataTable();
            query = "SELECT PRIVILAGE FROM GARUREG WHERE USERNAME= '" + uname +"'";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public DataTable uservalid(string uname,string pass)
        {
            DataTable dt = new DataTable();
            query = "SELECT * FROM GARUREG WHERE USERNAME = '" + uname + "' AND PASS = '"+ pass + "'";
            try
            {
                con.Open();
                oda = new OracleDataAdapter(query, con);
                oda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public void userinsert(int uid, string name, string usname, string pass, string repass, string dob, string gen, string mobno, string email, string address, string role)
        {
            int result = 0;          
            query = "INSERT INTO GARUREG VALUES("+ uid + ",'"+ name+  "','" + usname + "','" + pass + "','" + repass + "',to_date('" + dob + "','dd/mm/yyyy'),'" + gen + "','" + mobno + "','" + email + "','" + address +"','" + role + "')";
          try
              {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
          catch (Exception e)
              {
                Console.WriteLine(e.ToString());
                //MessageBox.Show(e.ToString());
               }
               con.Close();
            if (result >0)
                Console.WriteLine("User added");
            else
                Console.WriteLine("User not added");
            
        }
        public void userupdate(int uid, string name, string usname, string pass, string repass, string dob, string gen, string mobno, string email, string address, string role)
        {
            int result = 0;
            query = "UPDATE GARUREG SET UNAME ='" + name + "',USERNAME ='" + usname + "',PASS ='" + pass + "',REPASS ='" + repass + "',DOB = to_date('" + dob + "','dd/mm/yyyy'),GENDER ='" + gen + "',MOBILENO ='" + mobno + "',EMAILID ='" + email + "',ADDRESS ='" + address + "',PRIVILAGE ='" + role + "' WHERE USID =" + uid +"";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("VALUES UPDATED");
            else
                Console.WriteLine("VALUES NOT UPDATED");
        }
        public void passupdate( string usname, string pass, string repass)
        {
            int result = 0;
            query = "UPDATE GARUREG SET PASS ='" + pass + "',REPASS ='" + repass + "'WHERE USERNAME ='" + usname + "'";
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            con.Close();
            if (result > 0)
                Console.WriteLine("VALUES UPDATED");
            else
                Console.WriteLine("VALUES NOT UPDATED");
        }
        /*public void sendsms(string msgtext,string uname)
        {
           
        }*/
        public void RunOracleTransaction()
        {
            con.Open();
                OracleCommand command = con.CreateCommand();
                OracleTransaction transaction;
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                command.Transaction = transaction;
                try
                {
                    transaction.Commit();
                    Console.WriteLine("VALUE UPDATED IN DATABASE");
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("VALUE TEMPORARYLY UPDATED IN DATABASE");
                }
            
        }

    }
}
