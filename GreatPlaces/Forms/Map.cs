using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.Internals;
using GMap.NET.ObjectModel;
using GMap.NET.Projections;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;
using System.Xml;
using System.Net;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GreatPlaces;



namespace GreatPlaces
{
    public partial class Map : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZAMOCHEK\SQLEXPRESS;Initial Catalog=Great_Places;Integrated Security=True");
        string myAPI = "";
        GMapOverlay OverlayForAddress = new GMapOverlay("Address");
        DataTable dtRouter;
        GMapOverlay overlaymarshrut1 = new GMapOverlay("overlaymarshrut");
        List<string> x = new List<string>();
        int count = 0;

        List<int> id = new List<int>();
       static List<double> px = new List<double>();
        List<double> py = new List<double>();
        public Map()
        {
            StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\API.txt");
            myAPI = sr.ReadLine();
            InitializeComponent();

            //

            
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void Map_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "great_PlacesDataSet3.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.great_PlacesDataSet3.Place);

            GMapProvider.WebProxy = WebRequest.GetSystemWebProxy();
            GMapProvider.WebProxy.Credentials = CredentialCache.DefaultCredentials;

            // инициализируем новую таблицу для хранения данных о маршруте
            dtRouter = new DataTable();

            // Добавляем в таблицу колонки
            dtRouter.Columns.Add("Шаг");
            dtRouter.Columns.Add("Нач. точка (latitude)");
            dtRouter.Columns.Add("Нач. точка (longitude)");
            dtRouter.Columns.Add("Кон. точка (latitude)");
            dtRouter.Columns.Add("Кон. точка (longitude)");
            dtRouter.Columns.Add("Время пути");
            dtRouter.Columns.Add("Расстояние");
            dtRouter.Columns.Add("Описание маршрута");



            // Добавляем способы перемещения
            comboBox1.Items.Add("Автомобильные маршруты");
            comboBox1.Items.Add("Пешеходные маршруты");
            comboBox1.Items.Add("Велосипедные маршруты");
            comboBox1.Items.Add("Маршруты общественного транспорта");

            // Выставляем по умолчанию способ перемещения автомобильные маршруты по улично-дорожной сети
            comboBox1.SelectedIndex = 0;

          
        }


        private void gMapControl1_Load_1(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 
            gMapControl.MinZoom = 2; //минимальный зум
            gMapControl.MaxZoom = 16; //максимальный зум
            gMapControl.Zoom = 4; // какой используется зум при открытии
            gMapControl.Position = new GMap.NET.PointLatLng(49.01, 31.28);// точка в центре карты при открытии (центр России)
            gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
            gMapControl.CanDragMap = true; // перетаскивание карты мышью
            gMapControl.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl.ShowTileGridLines = false; //показывать или скрывать тайлы
            gMapControl.Position = new GMap.NET.PointLatLng(55.75393, 37.620795);

            conn.Open();
            SqlCommand command = new SqlCommand(
                "Select max(place_id) from Place", conn);
            for (int i = 1; i <= Convert.ToInt32(command.ExecuteScalar());
                i++)
            {
                SqlCommand x = new SqlCommand($"Select Place_x from Place WHERE place_id={i}", conn);
                SqlCommand y = new SqlCommand($"Select Place_y from Place WHERE place_id={i}", conn);
                GMarkerGoogle markerG = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(x.ExecuteScalar()), Convert.ToDouble(y.ExecuteScalar())), GMarkerGoogleType.green);
                markerG.ToolTip = new GMapRoundedToolTip(markerG);
                markerG.ToolTipMode = MarkerTooltipMode.Always;

                // Формируем подсказку для маркера
                SqlCommand n = new SqlCommand(
                    $"Select Place_name from Place WHERE place_id={i}", conn);
                object k = n.ExecuteScalar();
                markerG.ToolTipText = k.ToString();



                overlaymarshrut1.Markers.Add(markerG);


            }
            gMapControl.Overlays.Add(overlaymarshrut1);
            conn.Close();
        }





        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            overlaymarshrut1.Markers.Clear();

            gMapControl.Overlays.Add(overlaymarshrut1);
            conn.Open();

           // x.Add(textBox2.Text);
            //for (int i = 0; i < id.Count - 1; i++)
            //{
            //    MessageBox.Show(id[i].ToString());
               
            //}
            string c = "";
            for (int i = 0; i < x.Count; i++)
            {
                c += x[i].ToString();

            }
            MessageBox.Show(c + "  спочатку");
            List<string> x1 = new List<string>();
            for (int i = 0; i < px.Count - 2; i++)
            {
                double o = (px[i] - px[i+1]) * (px[i] - px[i + 1]) 
                    + (py[i] - py[i + 1]) * (py[i] - py[i + 1]);
                int y = 0;
            //    MessageBox.Show(o.ToString()+"   "+i);
                for (int j = i+1; j < py.Count - 1; j++)
                {
                    double r = (px[i] - px[j ]) * (px[i] - px[j ]) +
                        (py[i] - py[j ]) * (py[i] - py[j]);
                    // MessageBox.Show(r.ToString() + "   "+j);
                    if (r < o)
                    {
                        o = r;
                        y = j;
                      //  MessageBox.Show("Test");
                    }

                    if(j == py.Count - 2 && y >0)
                    {
                        double v = px[i + 1];
                        double n = py[i + 1];
                         px[i+1]=px[j];
                        py[i+1] = py[j];
                        px[j] =v;
                        py[j] = n;
                      //  MessageBox.Show("Testgrrg");
                        string m = x[i + 1];
                        x[i+1]= x[j];
                        x[j]= m;
                    }
                }
            }
            // MessageBox.Show(c);
            c = "";
            for (int i = 0; i < x.Count ; i++)
            {
                c += x[i].ToString();

            }
            MessageBox.Show(c+ "  потім");
            conn.Close();
            for (int i = 0; i < x.Count - 1; i++)
            {
                Path(x[i], x[i + 1]);
               // MessageBox.Show(x[i]+ "Test"+ x[i + 1]);
            }
            x.Clear();
        }
        public void Path(string a, string b)
        //, string text1, string text2
        {
            // Очищаем таблицу перед загрузкой данных
            dtRouter.Rows.Clear();

            //Создаем список способов перемещения
            List<string> mode = new List<string>();

            // Автомобильные маршруты по улично-дорожной сети
            mode.Add("driving");
            // Пешеходные маршруты по прогулочным дорожкам и тротуарам
            mode.Add("walking");
            // Велосипедные маршруты по велосипедным дорожкам и предпочитаемым улицам
            mode.Add("bicycling");
            // Маршруты общественного транспорта
            mode.Add("transit");

            string zapros = "https://maps.googleapis.com/maps/api/directions/xml?origin={0},&destination={1}&sensor=false&language=ru&mode={2}&key=" + myAPI;

            string url = string.Format(zapros, Uri.EscapeDataString(a), Uri.EscapeDataString(b), Uri.EscapeDataString(mode[0]));


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();



            // Парсинг данных


            XmlDocument xmldoc = new XmlDocument();

            xmldoc.LoadXml(responsereader);

            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {
                XmlNodeList nodes = xmldoc.SelectNodes("//leg//step");

                // Формируем строку для добавления в таблицу
                object[] dr;
                for (int i = 0; i < nodes.Count; i++)
                {
                    // Указываем что массив будет состоять из восьми значений
                    dr = new object[8];

                    // Номер шага
                    dr[0] = i;

                    // Получение координат начала отрезка
                    dr[1] = xmldoc.SelectNodes("//start_location").Item(i).SelectNodes("lat").Item(0).InnerText.ToString();
                    dr[2] = xmldoc.SelectNodes("//start_location").Item(i).SelectNodes("lng").Item(0).InnerText.ToString();

                    // Получение координат конца отрезка
                    dr[3] = xmldoc.SelectNodes("//end_location").Item(i).SelectNodes("lat").Item(0).InnerText.ToString();
                    dr[4] = xmldoc.SelectNodes("//end_location").Item(i).SelectNodes("lng").Item(0).InnerText.ToString();

                    // Получение времени необходимого для прохождения этого отрезка
                    dr[5] = xmldoc.SelectNodes("//duration").Item(i).SelectNodes("text").Item(0).InnerText.ToString();

                    // Получение расстояния, охватываемое этим отрезком
                    dr[6] = xmldoc.SelectNodes("//distance").Item(i).SelectNodes("text").Item(0).InnerText.ToString();

                    // Получение инструкций для этого шага, представленные в виде текстовой строки HTML
                    dr[7] = HtmlToPlainText(xmldoc.SelectNodes("//html_instructions").Item(i).InnerText.ToString());

                    // Добавление шага в таблицу
                    dtRouter.Rows.Add(dr);
                }



                // Вывод данных


                // Выводим в текстовое поле адрес начала пути


                //text1 = xmldoc.SelectNodes("//leg//start_address").Item(0).InnerText.ToString();

                // Выводим в текстовое поле адрес конца пути
                //  text2 = xmldoc.SelectNodes("//leg//end_address").Item(0).InnerText.ToString();

                // Выводим в текстовое поле время в пути

                // Получение координат начала пути
                double latStart = XmlConvert.ToDouble(xmldoc.GetElementsByTagName("start_location")[nodes.Count].ChildNodes[0].InnerText);
                double lngStart = XmlConvert.ToDouble(xmldoc.GetElementsByTagName("start_location")[nodes.Count].ChildNodes[1].InnerText);

                // Получение координат конечной точки
                double latEnd = XmlConvert.ToDouble(xmldoc.GetElementsByTagName("end_location")[nodes.Count].ChildNodes[0].InnerText);
                double lngEnd = XmlConvert.ToDouble(xmldoc.GetElementsByTagName("end_location")[nodes.Count].ChildNodes[1].InnerText);







                // Маркеры и их подписи


                // Устанавливаем позицию карты на начало пути
                gMapControl.Position = new PointLatLng(latStart, lngStart);
                gMapControl.Overlays.Add(overlaymarshrut1);



                GMarkerGoogle markerG = new GMarkerGoogle(new PointLatLng(latStart, lngStart), GMarkerGoogleType.green);
                markerG.ToolTip = new GMapRoundedToolTip(markerG);
                markerG.ToolTipMode = MarkerTooltipMode.Always;

                // Формируем подсказку для маркера
                string[] wordsG = a.Split(',');
                string dataMarkerG = string.Empty;
                foreach (string word in wordsG)
                {
                    dataMarkerG += word + ";\n";
                }
                markerG.ToolTipText = dataMarkerG;



                GMarkerGoogle markerR = new GMarkerGoogle(new PointLatLng(latEnd, lngEnd), GMarkerGoogleType.red);
                markerR.ToolTip = new GMapRoundedToolTip(markerG);
                markerR.ToolTipMode = MarkerTooltipMode.Always;

                // Формируем подсказку для маркера
                string[] wordsR = "dad".Split(',');
                //text2.Split(',');
                string dataMarkerR = string.Empty;
                foreach (string word in wordsR)
                {
                    dataMarkerR += word + ";\n";
                }
                markerR.ToolTipText = dataMarkerR;



                overlaymarshrut1.Markers.Add(markerG);
                overlaymarshrut1.Markers.Add(markerR);





                // Маршрут


                // Создаем список контрольных точек для прокладки маршрута
                List<PointLatLng> list = new List<PointLatLng>();

                // Проходимся по определенным столбцам для получения координат контрольных точек маршрута и занесением их в список координат
                for (int i = 0; i < dtRouter.Rows.Count; i++)
                {
                    double dbStartLat = double.Parse(dtRouter.Rows[i].ItemArray[1].ToString(), System.Globalization.CultureInfo.InvariantCulture);
                    double dbStartLng = double.Parse(dtRouter.Rows[i].ItemArray[2].ToString(), System.Globalization.CultureInfo.InvariantCulture);

                    list.Add(new PointLatLng(dbStartLat, dbStartLng));

                    double dbEndLat = double.Parse(dtRouter.Rows[i].ItemArray[3].ToString(), System.Globalization.CultureInfo.InvariantCulture);
                    double dbEndLng = double.Parse(dtRouter.Rows[i].ItemArray[4].ToString(), System.Globalization.CultureInfo.InvariantCulture);

                    list.Add(new PointLatLng(dbEndLat, dbEndLng));
                }

                // Очищаем все маршруты


                // Создаем маршрут на основе списка контрольных точек
                GMapRoute r = new GMapRoute(list, "Route");

                // Указываем, что данный маршрут должен отображаться
                r.IsVisible = true;

                // Устанавливаем цвет маршрута
                r.Stroke.Color = Color.DarkGreen;

                // Добавляем маршрут
                overlaymarshrut1.Routes.Add(r);

                // Добавляем в компонент, список маркеров и маршрутов
                gMapControl.Overlays.Add(overlaymarshrut1);
            }
        }
        public string HtmlToPlainText(string html)
        {
            html = html.Replace("</b>", "");
            return html.Replace("<b>", "");
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string zapros = "https://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=true_or_false&language=ru&key=" + myAPI;

            // Запрос к API
            string url = string.Format(zapros, Uri.EscapeDataString(textBox1.Text));

            // Выполняем запрос
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            // Получаем ответ от интернет-ресурса
            WebResponse response = request.GetResponse();

            // Чтение данных из интернет-ресурса
            Stream dataStream = response.GetResponseStream();

            // Чтение
            StreamReader sreader = new StreamReader(dataStream);

            // Считывает поток от текущего положения до конца         
            string responsereader = sreader.ReadToEnd();

            // Закрываем поток ответа
            response.Close();



            // Блок парсинга данных

            XmlDocument xmldoc = new XmlDocument();

            xmldoc.LoadXml(responsereader);

            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {
                // Получение широты и долготы
                XmlNodeList nodes = xmldoc.SelectNodes("//location");

                // Широта и долгота
                double latitude = 0.0;
                double longitude = 0.0;

                // Получаем широту и долготу
                foreach (XmlNode node in nodes)
                {
                    latitude = XmlConvert.ToDouble(node.SelectSingleNode("lat").InnerText.ToString());
                    longitude = XmlConvert.ToDouble(node.SelectSingleNode("lng").InnerText.ToString());
                }
                x.Add(textBox1.Text);
                label2.Text = label2.Text + textBox1.Text + " ";
                px.Add(latitude);
                py.Add(longitude);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string zapros = "https://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=true_or_false&language=ru&key=" + myAPI;

            // Запрос к API
            string url = string.Format(zapros, Uri.EscapeDataString(textBox2.Text));

            // Выполняем запрос
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            // Получаем ответ от интернет-ресурса
            WebResponse response = request.GetResponse();

            // Чтение данных из интернет-ресурса
            Stream dataStream = response.GetResponseStream();

            // Чтение
            StreamReader sreader = new StreamReader(dataStream);

            // Считывает поток от текущего положения до конца         
            string responsereader = sreader.ReadToEnd();

            // Закрываем поток ответа
            response.Close();



            // Блок парсинга данных

            XmlDocument xmldoc = new XmlDocument();

            xmldoc.LoadXml(responsereader);

            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {
                // Получение широты и долготы
                XmlNodeList nodes = xmldoc.SelectNodes("//location");

                // Широта и долгота
                double latitude = 0.0;
                double longitude = 0.0;

                // Получаем широту и долготу
                foreach (XmlNode node in nodes)
                {
                    latitude = XmlConvert.ToDouble(node.SelectSingleNode("lat").InnerText.ToString());
                    longitude = XmlConvert.ToDouble(node.SelectSingleNode("lng").InnerText.ToString());
                }
                x.Add(textBox2.Text);
                label2.Text = label2.Text + textBox2.Text + " ";

                px.Add(latitude);
                py.Add(longitude);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int place_id = Convert.ToInt32(comboBox2.SelectedIndex + 1);
            conn.Open();
            //MessageBox.Show(place_id.ToString());
            SqlCommand cmd = new SqlCommand($"select place_x from place where " +
                   $"place_id='{place_id}'", conn);
            SqlCommand cmdy = new SqlCommand($"select place_y from place where " +
               $"place_id= '{place_id}' ", conn);
            double x1 = Convert.ToDouble(cmd.ExecuteScalar());
            double y1 = Convert.ToDouble(cmd.ExecuteScalar());
            //MessageBox.Show(x1.ToString());
            px.Add(Convert.ToDouble(cmd.ExecuteScalar()));
            py.Add(y1);
            //MessageBox.Show(px[0].ToString());
            id.Add(Convert.ToInt32(comboBox2.SelectedIndex + 1));
            SqlCommand command = new SqlCommand(
                $"Select Place_name from Place WHERE place_id={place_id}", conn);
            x.Add(command.ExecuteScalar().ToString());
            label2.Text = label2.Text + command.ExecuteScalar().ToString() + " ";
            conn.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 1)
            {
                comboBox4.Visible = true;
                label3.Text = "Номер туру";
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button1.Visible = false;
            }
            else
            {
                comboBox4.Visible = false;
                label3.Text = "Пункт відправлення";
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            overlaymarshrut1.Markers.Clear();


        
        gMapControl.Overlays.Add(overlaymarshrut1);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select first_stop from tour where " +
                  $"tour_id='{comboBox4.SelectedIndex+1}'", conn);
            SqlCommand cmdy = new SqlCommand($"select last_stop from tour where " +
               $"tour_id='{comboBox4.SelectedIndex+1}' ", conn);
            string x1 = Convert.ToString(cmd.ExecuteScalar());
            string y1 = Convert.ToString(cmdy.ExecuteScalar());
            x.Add(x1);
          //  MessageBox.Show(x1+y1);
            SqlCommand cmdc = new SqlCommand(
                $"select Count(place_id) from tourplace" +
                $" where " +
                  $"tour_id='{comboBox4.SelectedIndex + 1}'", conn);
            int count = Convert.ToInt32(cmdc.ExecuteScalar());
         //   MessageBox.Show(count.ToString());
            for(int i = 1; i <= count; i++)
            {
                SqlCommand cmdn = new SqlCommand(
                    $"select place_name from place" +
                $" where " +
                  $"place_id= (select place_id from tourplace" +
                  $" where position ='{i}')", conn);
                string countn = Convert.ToString(cmdn.ExecuteScalar());
                x.Add(countn);
            }
            x.Add(y1);
            var c = "";
            for (int i = 0; i < x.Count; i++)
            {
                c += x[i].ToString();

            }
          //  MessageBox.Show(c + "  потім");
            for (int i = 0; i < x.Count - 1; i++)
            {
               Path(x[i], x[i + 1]);
                // MessageBox.Show(x[i]+ "Test"+ x[i + 1]);
            }
          //  x.Clear();
            conn.Close();
        }

        private void прибратиМаркериToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            if (count == 0)
            {
                overlaymarshrut1.Markers.Clear();
                прибратиМаркериToolStripMenuItem.Text = "Відобразити маркери";
                gMapControl.Overlays.Add(overlaymarshrut1);
                count = 1;

            }
            else
            {
                conn.Open();
                SqlCommand command = new SqlCommand(
               "Select max(place_id) from Place", conn);
                for (int i = 1; i <= Convert.ToInt32(command.ExecuteScalar());
                    i++)
                {
                    SqlCommand x = new SqlCommand($"Select Place_x from Place WHERE place_id={i}", conn);
                    SqlCommand y = new SqlCommand($"Select Place_y from Place WHERE place_id={i}", conn);
                    GMarkerGoogle markerG = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(x.ExecuteScalar()), Convert.ToDouble(y.ExecuteScalar())), GMarkerGoogleType.green);
                    markerG.ToolTip = new GMapRoundedToolTip(markerG);
                    markerG.ToolTipMode = MarkerTooltipMode.Always;

                    // Формируем подсказку для маркера
                    SqlCommand n = new SqlCommand(
                        $"Select Place_name from Place WHERE place_id={i}", conn);
                    object k = n.ExecuteScalar();
                    markerG.ToolTipText = k.ToString();



                    overlaymarshrut1.Markers.Add(markerG);
                   
                }
                gMapControl.Overlays.Add(overlaymarshrut1);
                прибратиМаркериToolStripMenuItem.Text = "Прибрати маркери";
                conn.Close();
                count = 0;
            }

        }
    }
}
