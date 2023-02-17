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
    public partial class Filtr : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZAMOCHEK\SQLEXPRESS;Initial Catalog=Great_Places;Integrated Security=True");
        public static int max_Rat = 5;
        public static int min_Rat =0 ;
        public static int max_Pr = 1000 ;
        public static int min_Pr= 0;
        public static int count = 1;
        public static DataSet DataSet;
        Controller controller = new Controller();
        public Filtr()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                count=1;
            }
            else
            {
               
                    count = 0;
                
            }

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                min_Rat =Convert.ToInt32( numericUpDown1.Value);
                max_Rat =Convert.ToInt32( numericUpDown2.Value);
                min_Pr = Convert.ToInt32( numericUpDown4.Value);
                max_Pr = Convert.ToInt32( numericUpDown3.Value);

               DataSet = controller.SelectTravel(search.travelist,
                   search.travelistFirst,
                   search.travel_place,
                min_Rat,
                max_Rat,
               min_Pr,
              max_Pr, conn);
            this.Close();
            }
            else
            {
                DataSet = controller.SelectTravel(search.travelist,
                  search.travelistFirst,
                  search.travel_place,
               0,
               5,
              0,
             1000,conn);
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Value = numericUpDown3.Value;
        }
    }
}
