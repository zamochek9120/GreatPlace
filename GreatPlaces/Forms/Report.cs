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
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace GreatPlaces
{
    public partial class Report : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZAMOCHEK\SQLEXPRESS;Initial Catalog=Great_Places;Integrated Security=True");
        DataSet MyDataSet = new DataSet();

        //Имя каталога открываемого файла БД
        string catName = "";
        //Непосредственное имя самого файла БД
        string fileName = "";
        public Report()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void placeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlDataAdapter adapter1 = new SqlDataAdapter(
           "select Place.Place_name, Place.place_type,Region_name, " +
           "count(Travel_id) as visit_count, AVG(travel_rating) as AVG_rating ," +
           "Max(Year(travel_date))-Min(YEAR(travel_date)) as travel_period " +
           "from Travel, Place,Region,placeRegion" +
           " Where Travel.place_id = Place.place_id " +
           "AND Place.place_x = PlaceRegion.place_x AND " +
           "PlaceRegion.region_id = region.region_id" +
           " AND Place.place_y = PlaceRegion.place_y " +
           "group by Place.place_id, Place.Place_name ,Place.place_type," +
           "Region.Region_name " +
               " UNION select Place_name, place_type,Region_name, " +
               " '0','0','0'" +
               " FROM PLACE, Region, PlaceRegion " +
              " WHERE place_id not in (select Place_id from travel)  " +
               "AND Place.place_x = PlaceRegion.place_x AND " +
           "PlaceRegion.region_id = region.region_id" +
           " AND Place.place_y = PlaceRegion.place_y "
           , conn);


            DataSet dataSet1 = new DataSet();
            adapter1.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
            conn.Close();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlDataAdapter adapter1 = new SqlDataAdapter(
           "SELECT Tourist.Tourist_surname," +
           "Tourist.Tourist_name,Tourist.Tourist_middle_name, COUNT(T4.TRAVEL_ID) as travel_count, " +
           "  T1.Travel_date as first_travel, " +
           " P1.place_name as first_place, " +
           " T3.Travel_date as last_travel," +
           "P3.PLACE_NAME as last_place " +
           " FROM TRAVEL t1, TRAVEL  T3 , TRAVEL  T4, TOURIST, PLACE P1, PLACE P3 " +
           "WHERE T1.TOURIST_ID= TOURIST.TOURIST_ID AND " +
           " P1.PLACE_ID = T1.PLACE_Id AND " +
           " P3.PLACE_ID = T3.PLACE_Id AND " +
           "T4.TOURIST_ID= T1.TOURIST_ID AND  " +
           "T1.Travel_date = (Select MIN(travel_date) FROM TRAVEL T2 WHERE " +
           " T2.Tourist_id=t1.Tourist_id) AND " +
           "T3.Travel_date = (Select MAx(travel_date) FROM TRAVEL T2 WHERE " +
           " T2.Tourist_id=t1.Tourist_id)  " +
           "                                       " +
           "GROUP BY Tourist.Tourist_surname," +
           "Tourist.Tourist_name,Tourist.Tourist_middle_name, " +
           "  T1.Travel_date , " +
           " P1.place_name , " +
           " T3.Travel_date ," +
           "P3.PLACE_NAME  ", conn);
            //AND TRAVEl.Place_id = Place.place_id AVG(travel_rating)
            //  Where Place.place_x = PlaceRegion.place_x AND PlaceRegion.region_id = region.region_id
            //
            DataSet dataSet1 = new DataSet();
            adapter1.Fill(dataSet1);
            dataGridView1.DataSource = dataSet1.Tables[0];
            conn.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
                if (dataGridView1.Rows.Count !=0)
{
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "PDF (*.pdf)|*.pdf";
                    save.FileName = "Result.pdf";
                    bool ErrorMessage = false;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                    BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                    if (File.Exists(save.FileName))
                        {
                            try
                            {
                                File.Delete(save.FileName);
                            }
                            catch (Exception ex)
                            {
                                ErrorMessage = true;
                                MessageBox.Show("Unable to wride data in disk" + ex.Message);
                            }
                        }
                        if (!ErrorMessage)
                        {
                            try
                            {
                                PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;

                                foreach (DataGridViewColumn col in dataGridView1.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(pCell);
                                }
                                foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                                {
                           
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    try
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase(dcell.Value.ToString(), font));
                                        pTable.AddCell(pCell);                                       
                                    }
                                    catch { }
                                }
                                }
                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                                {
                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                    PdfWriter.GetInstance(document, fileStream);
                                    document.Open();
                                    document.Add(pTable);
                                    document.Close();
                                    fileStream.Close();
                                }
                                MessageBox.Show("Data Export Successfully", "info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error while exporting Data" + ex.Message);
                            }
                        }
                    }
                
                else
                {
                    MessageBox.Show("No Record Found", "Info");
                }
            }
        }
    }
}

