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
using System.Net.Http;
using System.Net.Http.Headers;

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
            Outside.SelectedTab = loginTab;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
			loginBox.Enabled = false;
			passBox.Enabled = false;
			try
			{
				using (var httpClient = new HttpClient())
				{
					using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://shop.sceri.net/api/auth/signin"))
					{
						request.Headers.TryAddWithoutValidation("accept", "*/*");

						request.Content = new StringContent("{ \"password\": \"" + passBox.Text + "\", \"response\": \"string\", \"username\": \"" + loginBox.Text + "\"}"); request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

						var response = await httpClient.SendAsync(request);
						var responseContent = await response.Content.ReadAsStringAsync();

						if (response.StatusCode == HttpStatusCode.OK)
						{
							//Десериализация полученного json при помощи заранее созданного класса
							var user = JsonConvert.DeserializeObject<User>(responseContent);
							var token = user.Token;
							label5.Text = user.Token;
							if (token != null)
							{
								Outside.SelectedTab = mainTab;
								this.Text += " - " + user.Username;

							}
							else
							{
								throw new Exception();
							}
						}
						else
						{
							throw new Exception();
						}
					}
				}
				Outside.SelectedTab = mainTab;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Неверный логин или пароль.");
			}

			loginBox.Enabled = true;
			passBox.Enabled = true;
		}

		private async void Send_request()
		{
			try
			{
				using (var httpClient = new HttpClient())
				{
					using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://shop.sceri.net/api/auth/signin"))
					{
						request.Headers.TryAddWithoutValidation("accept", "*/*");

						request.Content = new StringContent("{ \"password\": \"" + passBox.Text + "\", \"response\": \"string\", \"username\": \"" + loginBox.Text + "\"}"); request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

						var response = await httpClient.SendAsync(request);
						var responseContent = await response.Content.ReadAsStringAsync();

						if (response.StatusCode == HttpStatusCode.OK)
						{
							//Десериализация полученного json при помощи заранее созданного класса
							var user = JsonConvert.DeserializeObject<User>(responseContent);
							var token = user.Token;
							label5.Text = user.Token;
							if (token != null)
							{
								Outside.SelectedTab = mainTab;
							}
							else
							{
								throw new Exception("Неверный логин или пароль.");
							}
						}
						else
						{
							throw new Exception("Неверный логин или пароль.");
						}







					}
				}


				Outside.SelectedTab = mainTab;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void GoodsGridView()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://shop.sceri.net/api/auth/signin"))
                {
                }
            }
            //Десериализация полученного json при помощи заранее созданного класса
            //КЛАСС requests = JsonConvert.DeserializeObject<КЛАСС>(readStream.ReadToEnd());

            //Запихивание товаров в DataGrid
        }

        private void OrdersGridView()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://shop.sceri.net/api/auth/signin"))
                {
                }
            }
            //Десериализация полученного json при помощи заранее созданного класса
            //КЛАСС requests = JsonConvert.DeserializeObject<КЛАСС>(readStream.ReadToEnd());

            //Запихивание товаров в DataGrid
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


            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://shop.sceri.net/api/auth/signin"))
                {
                }
            }
        }

        private void changeTSMI_Click(object sender, EventArgs e)
        {
            Inside.SelectedTab = addTab;

            addImage.Text = "Изменить картинку товара";
            nameBox.Text = "";
            descriptionBox.Text = "";
            priceBox.Text = "";
            stashBox.Text = "";
           //pictureBox1.
        }

        private void deleteTSMI_Click(object sender, EventArgs e)
        {
            //формирование строки удаления 
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://shop.sceri.net/api/auth/signin"))
                {
                }
            }
        }


    }
	public partial class User
	{
		[JsonProperty("success")]
		public bool Success { get; set; }

		[JsonProperty("username")]
		public string Username { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("token")]
		public string Token { get; set; }
	}
}