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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void travelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.travelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.great_PlacesDataSet3);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Tourist". При необходимости она может быть перемещена или удалена.
            this.touristTableAdapter.Fill(this.great_PlacesDataSet3.Tourist);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Travel". При необходимости она может быть перемещена или удалена.
            this.travelTableAdapter.Fill(this.great_PlacesDataSet3.Travel);
            travelDataGridView.AutoGenerateColumns = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?",
               "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                touristBindingSource.EndEdit();
                touristTableAdapter.Update(great_PlacesDataSet3);
                touristTableAdapter.Update(great_PlacesDataSet3);
            }
        }
    }
}
