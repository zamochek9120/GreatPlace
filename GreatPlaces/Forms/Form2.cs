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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           // this.regionTableAdapter.Fill(this.great_PlacesDataSet3.Region);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Travel". При необходимости она может быть перемещена или удалена.
         //   this.travelTableAdapter.Fill(this.great_PlacesDataSet3.Travel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Place". При необходимости она может быть перемещена или удалена.
           // this.placeTableAdapter.Fill(this.great_PlacesDataSet3.Place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Tourist". При необходимости она может быть перемещена или удалена.
          //  this.touristTableAdapter.Fill(this.great_PlacesDataSet3.Tourist);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet2.Place". При необходимости она может быть перемещена или удалена.
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Travel". При необходимости она может быть перемещена или удалена.
            this.travelTableAdapter.Fill(this.great_PlacesDataSet3.Travel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.great_PlacesDataSet3.Place);
            placeTableAdapter.Fill(great_PlacesDataSet3.Place);
            // touristTableAdapter.Fill(great_PlacesDataSet3.Tourist);
            //travelTableAdapter.Fill(great_PlacesDataSet3.Travel);
            placeTableAdapter.Fill(great_PlacesDataSet3.Place);
            //touristTableAdapter.Fill(great_PlacesDataSet3.Tourist);
            travelTableAdapter.Fill(great_PlacesDataSet3.Travel);
        }
    }
}
