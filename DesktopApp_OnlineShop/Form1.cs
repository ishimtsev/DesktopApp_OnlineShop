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
		private string token;
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

			dataGridView1.ColumnCount = 5;
			dataGridView1.Columns[0].Name = "ID";
			dataGridView1.Columns[1].Name = "Название";
			dataGridView1.Columns[2].Name = "Категория";
			dataGridView1.Columns[3].Name = "Особенности";
			dataGridView1.Columns[4].Name = "Описание";

			dataGridView3.ColumnCount = 5;
			dataGridView3.Columns[0].Name = "ID";
			dataGridView3.Columns[1].Name = "Имя";
			dataGridView3.Columns[2].Name = "Email";
			dataGridView3.Columns[3].Name = "Статус верифицирования";
			dataGridView3.Columns[4].Name = "Номер телефона";


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
							if (user.Token != null)
							{
								Outside.SelectedTab = mainTab;
								this.Text += " - " + user.Username;
								token = user.Token;
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
				loginBox.Enabled = true;
				passBox.Enabled = true;
				return;
			}
			loginBox.Enabled = true;
			passBox.Enabled = true;
		}


		private async void LoadProducts()
		{
			try
			{
				using (var httpClient = new HttpClient())
				{
					using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://shop.sceri.net/api/shop/games/list"))
					{
						request.Headers.TryAddWithoutValidation("accept", "*/*");
						//request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token);

						var response = await httpClient.SendAsync(request);
                        var responseContent = await response.Content.ReadAsStringAsync();


                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            //Десериализация полученного json при помощи заранее созданного класса
                            var games = JsonConvert.DeserializeObject<Games>(responseContent);
                            if (games.Success == true)
                            {
								for (int i = 0; i < games.GamesGames.Length; i++) dataGridView1.Rows.Add(games.GamesGames[i].Id, games.GamesGames[i].Title, games.GamesGames[i].Categories, games.GamesGames[i].Features, games.GamesGames[i].Description);
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
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}



		private async void LoadOrders()
		{
			try
			{
				using (var httpClient = new HttpClient())
				{
					using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://shop.sceri.net/api/shop/orders/list"))
					{
						request.Headers.TryAddWithoutValidation("accept", "*/*");
						request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token);

						var response = await httpClient.SendAsync(request);
						var responseContent = await response.Content.ReadAsStringAsync();


						if (response.StatusCode == HttpStatusCode.OK)
						{
							//Десериализация полученного json при помощи заранее созданного класса
							var games = JsonConvert.DeserializeObject<Games>(responseContent);
							if (games.Success == true)
							{
								for (int i = 0; i < games.GamesGames.Length; i++) dataGridView1.Rows.Add(games.GamesGames[i].Id, games.GamesGames[i].Title, games.GamesGames[i].Categories, games.GamesGames[i].Features, games.GamesGames[i].Description);
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
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private async void LoadUsers()
		{
			try
			{
				using (var httpClient = new HttpClient())
				{
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://shop.sceri.net/api/shop/user/find"))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "*/*");
                        request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token);

						var response = await httpClient.SendAsync(request);
                        var responseContent = await response.Content.ReadAsStringAsync();


                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            //Десериализация полученного json при помощи заранее созданного класса
                            var users = JsonConvert.DeserializeObject<Users>(responseContent);
                            if (users.Success == true)
                            {
                                for (int i = 0; i < users.Payload.Length; i++) dataGridView3.Rows.Add(users.Payload[i].Id, users.Payload[i].Username, users.Payload[i].Email, users.Payload[i].Verified, users.Payload[i].PhoneNumber);
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
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private async void AddOrder()
		{
			try
			{
				using (var httpClient = new HttpClient())
				{
					using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://shop.sceri.net/api/shop/order/create"))
					{
						request.Headers.TryAddWithoutValidation("accept", "*/*");
						request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token);
						request.Content = new StringContent("{ \"games\": \"[" + passBox.Text + "]\", \"userId\": \"" + passBox.Text + "\"}"); 
						request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

						var response = await httpClient.SendAsync(request);
						var responseContent = await response.Content.ReadAsStringAsync();


						if (response.StatusCode != HttpStatusCode.OK)
						{
							throw new Exception();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
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

        private void Inside_TabIndexChanged(object sender, EventArgs e)
        {
			if (Inside.SelectedTab == lookTab) LoadProducts();
			if (Inside.SelectedTab == tabPage1) LoadUsers();
			if (Inside.SelectedTab == lookOrderTab) LoadOrders();
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

	public partial class Users
	{
		[JsonProperty("payload")]
		public Payload[] Payload { get; set; }

		[JsonProperty("success")]
		public bool Success { get; set; }
	}

	public partial class Payload
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("username")]
		public string Username { get; set; }

		[JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
		public string Email { get; set; }

		[JsonProperty("verified")]
		public bool Verified { get; set; }

		[JsonProperty("phoneNumber", NullValueHandling = NullValueHandling.Ignore)]
		public string PhoneNumber { get; set; }
        //public object Werified { get; internal set; }
    }

	public partial class Games
	{
		[JsonProperty("success")]
		public bool Success { get; set; }

		[JsonProperty("games")]
		public Game[] GamesGames { get; set; }
	}

	public partial class Game
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("features")]
		public string Features { get; set; }

		[JsonProperty("categories")]
		public long[] Categories { get; set; }
	}
}