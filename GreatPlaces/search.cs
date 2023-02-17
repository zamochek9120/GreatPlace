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
    public partial class search : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZAMOCHEK\SQLEXPRESS;Initial Catalog=Great_Places;Integrated Security=True");
        public static string travelist = "";
        public static string travelistFirst= "";
        public static string travel_place="";
        public static DataSet DataSet;

        Controller controller = new Controller();
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Filtr.count == 1) {
          
                
            DataSet = controller.SelectTravel(
                travelist, travelistFirst, travel_place,
                Filtr.min_Rat,
                 Filtr.max_Rat,
                Filtr.min_Pr,
               Filtr.max_Pr, conn);
          
            this.Close();
        }
            else
            {
            
                DataSet = controller.SelectTravel(
               travelist, travelistFirst, travel_place,
               0,
                10,
               0,
              1000, conn);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            travelist = textBox1.Text;
            travel_place = textBox2.Text;
            travelistFirst = textBox3.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            travelist = textBox1.Text;
            travel_place = textBox2.Text;
            travelistFirst = textBox3.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            travelist = textBox1.Text;
            travel_place = textBox2.Text;
            travelistFirst = textBox3.Text;
        }
    }
}
