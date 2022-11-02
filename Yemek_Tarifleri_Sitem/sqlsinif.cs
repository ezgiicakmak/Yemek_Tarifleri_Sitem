using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Yemek_Tarifleri_Sitem
{
    public class sqlsinif
    {
        public SqlConnection baglanti
            { get; set; }
       
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-K19J3SQ\EZGI;Initial Catalog=Dbo_yemektarifi;Integrated Security=True");
       // baglan.Open();
           // return baglan;
       
    }
}