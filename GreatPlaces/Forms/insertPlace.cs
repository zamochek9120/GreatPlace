using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatPlaces
{
    public partial class insertPlace : Form
    {
        string a;
        
        public insertPlace()
        {
          
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            placeTableAdapter.Insert(
                Convert.ToInt32(placeTableAdapter.ScalarQuery()) + 1,
                comboBox1.Text, Convert.ToInt32(textBox2.Text), 
                Convert.ToInt32(textBox3.Text), textBox1.Text);
            this.placeTableAdapter.Fill(this.great_PlacesDataSet3.Place);
        }

        private void insertPlace_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.great_PlacesDataSet3.Place);

        }
    }
}
