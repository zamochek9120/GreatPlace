using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.Windows.Forms;
// Библиотеки для карты
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
namespace GreatPlaces
{
  public  class Controller
    {

      
        public DataSet SelectTravel(string a, string b,string c,int d,int e, int f, int g , SqlConnection conn)
        {   conn.Open();
            SqlDataAdapter adapter1 = new SqlDataAdapter(
              "SELECT travel_id, Tourist_surname, place_name, travel_price, travel_rating  FROM tRavel, Tourist,Place WHERE " +
              "Tourist.tourist_id = Travel.tourist_id AND " +
              " Place.place_id=travel.place_id   And  " +
                 " Travel.tourist_id IN" +
                 " (select tourist_id FROM Tourist WHERE tourist_surname " +
              $" LIKE N'%{a}%' AND tourist_name LIKE N'%{b}%' ) And  " +
                 " Travel.place_id IN" +
                 " (select place_id FROM Place WHERE place_name " +
              $" LIKE N'%{c}%'  AND travel_price> {d} AND travel_price<{e}) " +
              $"AND travel_rating>{f}   " +
              $"AND travel_rating<{g}", conn);


            DataSet dataSet1 = new DataSet();
            adapter1.Fill(dataSet1);         
            conn.Close();
            return dataSet1;

        }
        public DataSet ComboPlace(int a,string b, SqlConnection conn)
        {
            if (a == 0)
            {
                conn.Open();
                SqlDataAdapter adapter1 = new SqlDataAdapter(
                 $"SELECT * FROM Place WHERE Place_type='штучне' AND " +
                 $" place_name " +
              $" LIKE N'{b}%'" , conn);
                DataSet dataSet1 = new DataSet();
                adapter1.Fill(dataSet1);             
                conn.Close();
                return dataSet1;
            }
            if (a == 1)
            {
                conn.Open();
                SqlDataAdapter adapter1 = new SqlDataAdapter(
                  $"SELECT * FROM Place WHERE Place_type='природнє' AND " +
                 $" place_name " +
              $" LIKE N'{b}%'"
                       , conn);
                DataSet dataSet1 = new DataSet();
                adapter1.Fill(dataSet1);
                conn.Close();
                return dataSet1;
            }
            if (a == 2)
            {
                conn.Open();
                SqlDataAdapter adapter1 = new SqlDataAdapter(
                  $"SELECT * FROM Place WHERE " +
                 $" place_name " +
              $" LIKE N'{b}%'"
                       , conn);
                DataSet dataSet1 = new DataSet();
                adapter1.Fill(dataSet1);
                conn.Close();
                return dataSet1;
            }
            else
            {
                return null;
            }
        }
    }
}
