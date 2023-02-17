using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatPlaces.Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void placeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.travelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.great_PlacesDataSet3);

        }

        private void travelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.travelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.great_PlacesDataSet3);

        }

        private void travelBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.travelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.great_PlacesDataSet3);

        }

        private void travelBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.travelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.great_PlacesDataSet3);

        }

        private void фо_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Travel". При необходимости она может быть перемещена или удалена.
            this.travelTableAdapter.Fill(this.great_PlacesDataSet3.Travel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", 
                "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
 {
                travelBindingSource.EndEdit();
                travelTableAdapter.Update(great_PlacesDataSet3);
                travelTableAdapter.Update(great_PlacesDataSet3);
            }
        }
    }
}
