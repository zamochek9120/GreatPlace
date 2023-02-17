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
    public partial class Edit : Form
    {
        
        public Edit()
        {
           
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Form1.travel_id.ToString() + 'd' + Form1.travel_prize);
            textBox1.Text = Form1.travel_prize;
            textBox2.Text = Form1.travel_rating.ToString();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.great_PlacesDataSet3.Place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Travel". При необходимости она может быть перемещена или удалена.
            this.travelTableAdapter.Fill(this.great_PlacesDataSet3.Travel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Tourist". При необходимости она может быть перемещена или удалена.
            this.touristTableAdapter.Fill(this.great_PlacesDataSet3.Tourist);
            

            //travelTableAdapter.UpdateQuery(textBox1.Text);
            //DateTime dateTime = monthCalendar1.SelectionStart;
            //travelTableAdapter.UpdateQuery()
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            int b = comboBox2.SelectedIndex + 1;
            travelTableAdapter.UpdateQuery(b, a,Convert.ToInt32(textBox1.Text), Convert.ToDouble(textBox2.Text),
                Form1.travel_id);
            this.Validate();
            this.touristBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.great_PlacesDataSet3);
            this.travelTableAdapter.Fill(this.great_PlacesDataSet3.Travel);
     
        }
    }
}

