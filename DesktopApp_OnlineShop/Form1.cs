using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace DesktopApp_OnlineShop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

            //Это всё можно в самом табе прописать, но чтобы в конструкторе по нему можно было перемещаться, оставлю чтобы применялось при запуске
            Outside.ItemSize = new Size(0, 1);
            Outside.SizeMode = TabSizeMode.Fixed;
            foreach (TabPage tab in Outside.TabPages)
            {
                tab.Text = "";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("SENDED_STRING");
            WebResponse response = request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            //Десериализация полученного json при помощи заранее созданного класса
            //КЛАСС requests = JsonConvert.DeserializeObject<КЛАСС>(readStream.ReadToEnd());

            //Некая проверка соединения и полученого токена

            response.Close();

            Outside.SelectedTab = mainTab;

        }

        private void GoodsGridView()
        {
            WebRequest request = WebRequest.Create("SENDED_STRING");
            WebResponse response = request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            //Десериализация полученного json при помощи заранее созданного класса
            //КЛАСС requests = JsonConvert.DeserializeObject<КЛАСС>(readStream.ReadToEnd());

            //Запихивание товаров в DataGrid

            response.Close();
        }

        private void OrdersGridView()
        {
            WebRequest request = WebRequest.Create("SENDED_STRING");
            WebResponse response = request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            //Десериализация полученного json при помощи заранее созданного класса
            //КЛАСС requests = JsonConvert.DeserializeObject<КЛАСС>(readStream.ReadToEnd());

            //Запихивание товаров в DataGrid

            response.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //У тебя, вроде, был годный модуль для поиска. Вставь его сюда, пожалуйста. Если не можешь - скажи. Вставлю простенький.
        }

        private void searchButtonOrders_Click(object sender, EventArgs e)
        {
            //Сюда тоже
        }

        private void addImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    Path.Text = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void putProduct_Click(object sender, EventArgs e)
        {
            //Формирование отправляемой строки


            WebRequest request = WebRequest.Create("SENDED_STRING");
            WebResponse response = request.GetResponse();
            response.Close();
        }

        private void changeTSMI_Click(object sender, EventArgs e)
        {
            Inside.SelectedTab = addTab;

            addImage.Text = "Изменить картинку товара";
            nameBox.Text = "";
            descriptionBox.Text = "";
            priceBox.Text = "";
            stashBox.Text = "";
            pictureBox1.
        }

        private void deleteTSMI_Click(object sender, EventArgs e)
        {
            //формирование строки удаления 
            WebRequest request = WebRequest.Create("SENDED_STRING");
            WebResponse response = request.GetResponse();
            response.Close();
        }


    }
}