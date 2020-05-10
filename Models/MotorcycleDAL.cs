using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace MotoInventory.Models
{
    public class MotorcycleDAL
    {
        //string connectionString = "Data Source=DESKTOP-SOORD4P;Initial Catalog=\"Evergreen Safety\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string connectionString = "Data Source=LAPTOP-3R0QQVMN;Initial Catalog=\"Evergreen Safety\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Get All
        public IEnumerable<MotorcycleInfo> GetAllMotorcycle()
        {
            List<MotorcycleInfo> motorcycleList = new List<MotorcycleInfo>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetAllMotorcycle", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MotorcycleInfo motorcycle = new MotorcycleInfo();
                    motorcycle.VINNumber = dr["VINNumber"].ToString();
                    motorcycle.ESCNumber = dr["ESCNumber"].ToString();
                    motorcycle.Owner = dr["Owner"].ToString();
                    motorcycle.Year = (int)dr["Year"];
                    motorcycle.Make = dr["Make"].ToString();
                    motorcycle.Model = dr["Model"].ToString();
                    motorcycle.TurnInDate = dr["TurnInDate"].ToString();
                    motorcycle.DateAcquired = dr["DateAcquired"].ToString();
                    motorcycle.EngineCC = dr["EngineCC"].ToString();
                    motorcycle.SiteID = dr["SiteID"].ToString();
                    motorcycle.SiteLocation = dr["SiteLocation"].ToString();
                    motorcycle.PurchasePrice = dr["PurchasePrice"].ToString();
                    motorcycle.CurrentValue = dr["CurrentValue"].ToString();

                    motorcycleList.Add(motorcycle);
                }
                con.Close();
            }
            return motorcycleList;
        }

        public void AddMotorcycle(MotorcycleInfo motorcycle)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_InsertMotorcycle", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VINNumber", motorcycle.VINNumber);
                cmd.Parameters.AddWithValue("@ESCNumber", motorcycle.ESCNumber);
                cmd.Parameters.AddWithValue("@Owner", motorcycle.Owner);
                cmd.Parameters.AddWithValue("@Year", motorcycle.Year);
                cmd.Parameters.AddWithValue("@Make", motorcycle.Make);
                cmd.Parameters.AddWithValue("@Model", motorcycle.Model);
                cmd.Parameters.AddWithValue("@TurnInDate", motorcycle.TurnInDate);
                cmd.Parameters.AddWithValue("@DateAcquired", motorcycle.DateAcquired);
                cmd.Parameters.AddWithValue("@EngineCC", motorcycle.EngineCC);
                cmd.Parameters.AddWithValue("@SiteID", motorcycle.SiteID);
                cmd.Parameters.AddWithValue("@SiteLocation", motorcycle.SiteLocation);
                cmd.Parameters.AddWithValue("@PurchasePrice", motorcycle.PurchasePrice);
                cmd.Parameters.AddWithValue("@CurrentValue", motorcycle.CurrentValue);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // See video here to implement other CRUD funcitons in the DAL
        // https://www.youtube.com/watch?v=oz7Xn-Cjba0&t=456s
    }
}
