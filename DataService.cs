using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApplication1
{
    

    public class DataService
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        public DataTable GetUserLISt()
        {
            da = new SqlDataAdapter("GetUserLISt", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void InsertNewUser(PropertyService P)
        {
            cmd = new SqlCommand("InsertNewUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fname", P.FirstName);
            cmd.Parameters.AddWithValue("@Lname", P.LastName);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteUser(int UserID)
        {
            cmd = new SqlCommand("DeleteUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UID", UserID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateUser(PropertyService P)
        {
            cmd = new SqlCommand("UpdateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UID", P.UserID);
            cmd.Parameters.AddWithValue("@Fname", P.FirstName);
            cmd.Parameters.AddWithValue("@Lname", P.LastName);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}