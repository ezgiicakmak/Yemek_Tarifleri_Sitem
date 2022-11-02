using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Tarifleri_Sitem
{
    public partial class Kullanıcı : System.Web.UI.MasterPage
    {
        sqlsinif bgl=new sqlsinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand command=new SqlCommand("Select * From");
        }
    }
}