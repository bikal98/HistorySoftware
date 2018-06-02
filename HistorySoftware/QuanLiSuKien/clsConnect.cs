using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HistorySoftware.QuanLiSuKien
{
    public class clsConnect
    {
        SqlConnection con;
        string connect = @"Data Source=LAPTOP-8NMH6R3U\SQL;Initial Catalog=HistorySoftware;Integrated Security=True";
        DataTable dt;

        public SqlConnection OpenConnect()
        {
            con = new SqlConnection(connect);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        public SqlConnection CloseConnect()
        {
            con = new SqlConnection(connect);
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
        //Load du lieu

        public DataTable LoadData()
        {
            dt = new DataTable();
            OpenConnect();
            SqlCommand cmd = new SqlCommand("tbl_Event_LoadDL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }
        //Ham tim Kiem
        public DataTable TimKiem(string ChuoiTimKiem)
        {
            OpenConnect();
            dt = new DataTable();
            SqlCommand cmd = new SqlCommand("tbl_Event_TimKiemEVENT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("TenSuKien", SqlDbType.NVarChar)).Value = ChuoiTimKiem;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }
        
    }
}
