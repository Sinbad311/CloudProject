using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controls;  
using System.Data.Odbc;           
using System.Data;



namespace FootballWeatherWS
{
    public partial class GoogleMap : System.Web.UI.Page
    {
        protected string GMap1_Click(object s, GAjaxServerEventArgs e)
        {
            return null;
        }
    }
    public void loadgrid()
{
string connectionString = "DSN=PostgreSQL30";
OdbcConnection connection = new OdbcConnection(connectionString);
connection.Open();

string con = "select * from Stadiums";
OdbcCommand com = new OdbcCommand(con, connection);
OdbcDataAdapter da = new OdbcDataAdapter(com);
DataTable dt = new DataTable();
da.Fill(dt);

GridView1.DataSource = dt;
GridView1.DataBind();
connection.Close();
}
}