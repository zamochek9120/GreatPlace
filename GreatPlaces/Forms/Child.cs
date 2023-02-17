using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GreatPlaces
{
    public partial class Child : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZAMOCHEK\SQLEXPRESS;Initial Catalog=Great_Places;Integrated Security=True");
        public Child()
        {
            InitializeComponent();
        }

        private void Child_Load(object sender, EventArgs e)
        {   conn.Open();           

            SqlDataAdapter adapter1 = new SqlDataAdapter(
           "SELECT * FROM Place "
                , conn);
            DataSet dataSet1 = new DataSet();
            adapter1.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
           conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void зимаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(
            "SELECT T1.place_id,Place.place_name, AVG(T2.travel_rating) " +
          " FROM Travel T1,Travel T2, Place " +
          "WHERE T1.place_id = Place.place_id AND T2.place_id=t1.place_id" +
          " Group by T1.place_id ,Place.place_name " +
          "HAVING (SELECT AVG(T2.travel_rating) From travel T2 WHERE " +
          " MONTH(T2.travel_date) IN (1,2,12)  AND T2.place_id=t1.place_id)" +
          ">= (Select AVG(travel_rating) From travel WHERE   MONTH(travel_date) IN (1,2,12))"
          , conn);
            DataSet dataSet1 = new DataSet();
            adapter.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
            conn.Close();

        }

        private void веснаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(
            "SELECT T1.place_id,Place.place_name, AVG(T2.travel_rating) " +
          " FROM Travel T1,Travel T2, Place " +
          "WHERE T1.place_id = Place.place_id AND T2.place_id=t1.place_id" +
          " Group by T1.place_id ,Place.place_name " +
          "HAVING (SELECT AVG(T2.travel_rating) From travel T2 WHERE " +
          " MONTH(T2.travel_date) IN (3,4,5)  AND T2.place_id=t1.place_id)" +
          ">= (Select AVG(travel_rating) From travel WHERE   MONTH(travel_date) IN (3,4,5))"
          , conn);
            DataSet dataSet1 = new DataSet();
            adapter.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
            conn.Close();
        }

        private void літоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(
            "SELECT T1.place_id,Place.place_name, AVG(T2.travel_rating) " +
          " FROM Travel T1,Travel T2, Place " +
          "WHERE T1.place_id = Place.place_id AND T2.place_id=t1.place_id" +
          " Group by T1.place_id ,Place.place_name " +
          "HAVING (SELECT AVG(T2.travel_rating) From travel T2 WHERE " +
          " MONTH(T2.travel_date) IN (6,7,8)  AND T2.place_id=t1.place_id)" +
          ">= (Select AVG(travel_rating) From travel WHERE   MONTH(travel_date) IN (6,7,8))"
          , conn);
            DataSet dataSet1 = new DataSet();
            adapter.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
            conn.Close();
        }

        private void осіньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(
            "SELECT T1.place_id,Place.place_name, AVG(T2.travel_rating) " +
          " FROM Travel T1,Travel T2, Place " +
          "WHERE T1.place_id = Place.place_id AND T2.place_id=t1.place_id" +
          " Group by T1.place_id ,Place.place_name " +
          "HAVING (SELECT AVG(T2.travel_rating) From travel T2 WHERE " +
          " MONTH(T2.travel_date) IN (9,10,11)  AND T2.place_id=t1.place_id)" +
          ">= (Select AVG(travel_rating) From travel WHERE   MONTH(travel_date) IN (9,10,11))"
          , conn);
            DataSet dataSet1 = new DataSet();
            adapter.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
            conn.Close();
        }

        private void запит1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlDataAdapter adapter1 = new SqlDataAdapter(
           "select Place.place_id, place_name, " +
           "count(tourist_id) AS tourist_count" +
           " from Travel, Place WHERE Place.place_id = Travel.place_id " +

           "group by Place.place_id, place_name " +
           " having count(tourist_id) >=" +
           " all(select count(tourist_id) from Travel group by (place_id)) "
                , conn);
            ;

            DataSet dataSet1 = new DataSet();
            adapter1.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
            conn.Close();
        }

        private void запит2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(
            "select tourist_id, count(distinct place_id) as place_count from Travel" +
            "  group by(tourist_id) " +
            "having count(distinct place_id) >= all(select count(distinct place_id) from Travel" +
            " group by (tourist_id)) "
          , conn);

            DataSet dataSet1 = new DataSet();
            adapter.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
            conn.Close();
        }

        private void запит3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlDataAdapter adapter1 = new SqlDataAdapter(
           "SELECT T1.place_id,Place.place_name, AVG(T2.travel_rating) AS child_rating" +
           " FROM Travel T1,Travel T2, Place " +
           "WHERE T1.place_id=Place.place_id AND T2.place_id=t1.place_id" +
           " Group by T1.place_id ,Place.place_name " +
           "HAVING (SELECT AVG(T2.travel_rating) From travel T2, tourist" +
           " WHERE tourist.tourist_id=T2.tourist_id AND birth_year>=2010" +
           "  AND T2.place_id=t1.place_id)" +
           ">= (Select AVG(travel_rating) From travel, tourist WHERE tourist.tourist_id=travel.tourist_id AND birth_year>=2010) "
                , conn);
            DataSet dataSet1 = new DataSet();
            adapter1.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
            conn.Close();
        }
    }
}
