using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreatPlaces.Forms;
using System.Data.SqlClient;

namespace GreatPlaces
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZAMOCHEK\SQLEXPRESS;Initial Catalog=Great_Places;Integrated Security=True");
        public static int place_id;
        public static int travel_id;
        public static string travel_prize;
        public static double travel_rating;

        static int x = 0;

        Controller controller = new Controller();
        public Form1()
        {
            
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Tourist". При необходимости она может быть перемещена или удалена.

            this.touristTableAdapter.Fill(this.great_PlacesDataSet3.Tourist);
         
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.great_PlacesDataSet3.Place);
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Travel". При необходимости она может быть перемещена или удалена.
            this.travelTableAdapter.Fill(this.great_PlacesDataSet3.Travel);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet2.Place". При необходимости она может быть перемещена или удалена.
            bindingNavigator1.BindingSource = placeBindingSource;
            dataGridView1.DataSource = placeBindingSource;
            label1.Text = "Place";
            dataGridView1.AutoGenerateColumns = true;
      
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void touristToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = touristBindingSource;
            dataGridView1.DataSource = touristBindingSource;
            label1.Text = "Tourist";
            label2.Text = "Пошук туриста";
            label3.Text = "Прізвище";
            textBox2.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label5.Text = "По батькові";
            comboBox1.Visible = false;
            //label6.Visible = false;
            //label7.Visible = false;
            //numericUpDown1.Visible = false;
            //numericUpDown2.Visible = false;
        }

        private void placeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = placeBindingSource;
            dataGridView1.DataSource = placeBindingSource;
            label1.Text = "Place";
            label2.Text = "Пошук місця";
            label3.Text = "Назва";
            textBox2.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = true;
            //label6.Visible = false;
            //label7.Visible = false;
            //numericUpDown1.Visible = false;
            //numericUpDown2.Visible = false;

        }

        private void travelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = travelBindingSource;
            dataGridView1.DataSource = travelBindingSource;
            label1.Text = "Travel";
            label2.Text = "Пошук подорожі";
            label3.Text = "Прізвище туриста";
            textBox2.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label5.Text = "Місце подорожі";
            comboBox1.Visible = false;
            //label6.Visible = true;
            //label7.Visible = true;
            //numericUpDown1.Visible = true;
            //numericUpDown2.Visible = true;
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            conn.Open();

            SqlDataAdapter adapter1 = new SqlDataAdapter(
           "SELECT * FROM region "
                , conn);
            DataSet dataSet1 = new DataSet();
            adapter1.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
            conn.Close();
            label1.Text = "Region";
            label2.Text = "Пошук області";
            label3.Text = "назва області";
            textBox2.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            //label6.Visible = false;
            //label7.Visible = false;
            //numericUpDown1.Visible =false;
            //numericUpDown2.Visible = false;
        }

        private void travelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2 = new Form4();
            form2.ShowDialog();
            placeTableAdapter.Fill(great_PlacesDataSet3.Place);
            touristTableAdapter.Fill(great_PlacesDataSet3.Tourist);
            travelTableAdapter.Fill(great_PlacesDataSet3.Travel);

        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void touristToolStripMenuItem1_Click(object sender, EventArgs e)
        { if (label1.Text == "Travel")
            {
                travel_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                travel_prize = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                travel_rating = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value);
                Edit form5 = new Edit();
                form5.ShowDialog();
                this.travelTableAdapter.Fill(this.great_PlacesDataSet3.Travel);
            }
            else
            {
                MessageBox.Show("Оберіть таблицю Подорож і елемент який хочете редагувати!");
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Tourist")
            {
                touristTableAdapter.DeleteQuery(
                    Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                this.touristTableAdapter.Fill(this.great_PlacesDataSet3.Tourist);
            }
            if (label1.Text == "Travel")
            {
                travelTableAdapter.DeleteQuery(
                    Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                this.travelTableAdapter.Fill(this.great_PlacesDataSet3.Travel);
            }
            if (label1.Text == "Place")
            {
                placeTableAdapter.DeleteQuery(
                    Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                this.placeTableAdapter.Fill(this.great_PlacesDataSet3.Place);
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Tourist")
            {
                this.touristBindingSource.EndEdit();
                insertTourist insertTourist = new insertTourist();
                insertTourist.ShowDialog();
                this.touristBindingSource.EndEdit();
                dataGridView1.DataSource = touristBindingSource;
                this.touristTableAdapter.Fill(this.great_PlacesDataSet3.Tourist);


            }
            if (label1.Text == "Travel")
            {
                insertTravel travel = new insertTravel();
                travel.Show();

            }
            if (label1.Text == "Place")
            {
                insertPlace place = new insertPlace();
                place.ShowDialog();
                this.placeTableAdapter.Fill(this.great_PlacesDataSet3.Place);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            touristTableAdapter.Update(great_PlacesDataSet3);
            travelTableAdapter.Update(great_PlacesDataSet3);
            regionTableAdapter.Update(great_PlacesDataSet3);
            placeTableAdapter.Update(great_PlacesDataSet3);
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "Tourist")
            {

                this.Validate();
                this.touristBindingSource.EndEdit();
                this.touristTableAdapter.Fill(this.great_PlacesDataSet3.Tourist);


            }
            if (label1.Text == "Travel")
            {
                this.travelTableAdapter.Fill(this.great_PlacesDataSet3.Travel);

            }
            if (label1.Text == "Place")
            {

                // this.placeTableAdapter.Fill(this.great_PlacesDataSet3.Place);
            }
            if (label1.Text == "Region")
            {

                this.regionTableAdapter.Fill(this.great_PlacesDataSet3.Region);
            }
        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            touristTableAdapter.Update(great_PlacesDataSet3);
            travelTableAdapter.Update(great_PlacesDataSet3);
            regionTableAdapter.Update(great_PlacesDataSet3);
            placeTableAdapter.Update(great_PlacesDataSet3);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                touristTableAdapter.Update(great_PlacesDataSet3);
                travelTableAdapter.Update(great_PlacesDataSet3);
                regionTableAdapter.Update(great_PlacesDataSet3);
                placeTableAdapter.Update(great_PlacesDataSet3);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form6 form2 = new Form6();
            form2.ShowDialog(this);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            child.Show();
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            Map map = new Map();
            map.Show();
       
     
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "Tourist")
            {

                conn.Open();

                SqlDataAdapter adapter1 = new SqlDataAdapter(
               $"SELECT * FROM tourist WHERE tourist_surname LIKE'%{textBox1.Text}%' AND " +
               $"tourist_name LIKE'%{textBox2.Text}%' AND " +
               $"tourist_middle_name LIKE'%{textBox3.Text}%'"
                    , conn);
                DataSet dataSet1 = new DataSet();
                adapter1.Fill(dataSet1);
                dataGridView1.DataSource = dataSet1.Tables[0];
                conn.Close();


            }
            if (label1.Text == "Travel")
            {

                //DataSet dataSet2 = controller.SelectTravel(textBox1.Text,
                //    textBox2.Text, textBox3.Text,
                //    Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)
                //    , conn);

                //dataGridView1.DataSource = dataSet2.Tables[0];


            }
            if (label1.Text == "Place")
            {
                if (x == 0) {
                    
                    DataSet dataSet2 = controller.ComboPlace(
                   2, textBox1.Text, conn);

                    dataGridView1.DataSource = dataSet2.Tables[0];
                }
                else
                {
                    DataSet dataSet2 = controller.ComboPlace(
                   comboBox1.SelectedIndex, textBox1.Text, conn);

                    dataGridView1.DataSource = dataSet2.Tables[0];
                }
               
            }
            if (label1.Text == "Region")
            {

                conn.Open();

                SqlDataAdapter adapter1 = new SqlDataAdapter(
               $"SELECT * FROM Region WHERE region_name LIKE'%{textBox1.Text}%'"
                    , conn);
                DataSet dataSet1 = new DataSet();
                adapter1.Fill(dataSet1);
                dataGridView1.DataSource = dataSet1.Tables[0];
                conn.Close();
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "Travel")
            {

                //DataSet dataSet2 = controller.SelectTravel(textBox1.Text,
                //    textBox2.Text, textBox3.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), conn);

                //dataGridView1.DataSource = dataSet2.Tables[0];


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           

                //DataSet dataSet2 = controller.SelectTravel(textBox1.Text,
                //    textBox2.Text, textBox3.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), conn);

                //dataGridView1.DataSource = dataSet2.Tables[0];


           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            x++;
            DataSet dataSet2 = controller.ComboPlace(
                comboBox1.SelectedIndex,textBox1.Text,conn);

            dataGridView1.DataSource = dataSet2.Tables[0];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //DataSet dataSet2 = controller.SelectTravel(textBox1.Text,
            //       textBox2.Text, textBox3.Text,
            //       Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)
            //       , conn);

            //dataGridView1.DataSource = dataSet2.Tables[0];
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void пошукToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (label1.Text == "Travel")
        {
         
            Filtr filtr = new Filtr();
            filtr.ShowDialog();
            dataGridView1.DataSource = Filtr.DataSet.Tables[0];
            }
        }

        private void фільтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search search = new search();
            search.ShowDialog();
           dataGridView1.DataSource = search.DataSet.Tables[0];
        }


        private void змінитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Travel")
            {
                travel_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                travel_prize = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                travel_rating = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value);
                Edit form5 = new Edit();
                form5.ShowDialog();
                this.travelTableAdapter.Fill(this.great_PlacesDataSet3.Travel);
            }
            else
            {
                MessageBox.Show("Оберіть таблицю Подорож і елемент який хочете редагувати!");
            }

        }
    }
    }

