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
    public partial class insertTourist : Form
    {
        public insertTourist()
        {
            
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet2.Place". При необходимости она может быть перемещена или удалена.
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) {
                touristTableAdapter.Insert(
                    Convert.ToInt32(touristTableAdapter.ScalarQuery()) + 1,
                    textBox1.Text, textBox5.Text, textBox2.Text,
                    Convert.ToInt32(textBox4.Text), "Ч");
                this.Validate();
                this.touristBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.great_PlacesDataSet3);
                this.touristTableAdapter.Fill(this.great_PlacesDataSet3.Tourist);
            }
            else
            {
                touristTableAdapter.Insert(
                    Convert.ToInt32(touristTableAdapter.ScalarQuery()) + 1,
                    textBox1.Text, textBox5.Text, textBox2.Text,
                    Convert.ToInt32(textBox4.Text), "Ж");
                this.Validate();
                this.touristBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.great_PlacesDataSet3);
                this.touristTableAdapter.Fill(this.great_PlacesDataSet3.Tourist);
            }
            
          
        }

        private void touristBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.touristBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.great_PlacesDataSet3);

        }

        private void insertTourist_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Tourist". При необходимости она может быть перемещена или удалена.
            this.touristTableAdapter.Fill(this.great_PlacesDataSet3.Tourist);

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            this.Close();
            
        }
    }
}
