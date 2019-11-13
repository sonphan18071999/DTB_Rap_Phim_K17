﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyRapPhim_Final.DBLayer
{
    class DBMain
    {
       
        string cnstr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyRapPhim;Integrated Security=True";
        //Data Source=DESKTOP-D993A84\SQLEXPRESS;Initial Catalog=PM_Ban_Hang;Integrated Security=True
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        SqlCommand comm = null;
        public DBMain()
        {
            conn = new SqlConnection(cnstr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds); return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }


    }
}
