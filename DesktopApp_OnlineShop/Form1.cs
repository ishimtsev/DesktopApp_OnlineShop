﻿using System;
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

			productsDataGridView1.ColumnCount = 5;
			productsDataGridView1.Columns[0].Name = "ID";
			productsDataGridView1.Columns[1].Name = "Название";
			productsDataGridView1.Columns[2].Name = "Категория";
			productsDataGridView1.Columns[3].Name = "Особенности";
			productsDataGridView1.Columns[4].Name = "Описание";

			usersDataGridView3.ContextMenuStrip = contextMenuStrip1;
			productsDataGridView1.ContextMenuStrip = contextMenuStrip3;

			usersDataGridView3.ColumnCount = 5;
			usersDataGridView3.Columns[0].Name = "ID";
			usersDataGridView3.Columns[1].Name = "Имя";
			usersDataGridView3.Columns[2].Name = "Email";
			usersDataGridView3.Columns[3].Name = "Статус верифицирования";
			usersDataGridView3.Columns[4].Name = "Номер телефона";

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
								productsDataGridView1.Rows.Clear();
								productsDataGridView1.Refresh();
								for (int i = 0; i < games.GamesGames.Length; i++)
									if (productsSearchBox.Text != "")
									{
										StringComparison comp = StringComparison.CurrentCultureIgnoreCase;
										string search_str = productsSearchBox.Text;
										if (games.GamesGames[i].Title.Contains(search_str) || games.GamesGames[i].Features.Contains(search_str) || games.GamesGames[i].Description.Contains(search_str))
											productsDataGridView1.Rows.Add(games.GamesGames[i].Id, games.GamesGames[i].Title, games.GamesGames[i].Categories, games.GamesGames[i].Features, games.GamesGames[i].Description);
										else
										{
											bool isSearched = false;
											for (int j = 0; j < games.GamesGames[i].Categories.Length; j++)
												if (games.GamesGames[i].Categories[j].Contains(search_str))
												{
													isSearched = true;
													break;
												}

											if (isSearched)
											{
												string categories = "";
												for (int k = 0; k < games.GamesGames[i].Categories.Length; k++)
												{
													categories += games.GamesGames[i].Categories[k] + " ";
												}
												productsDataGridView1.Rows.Add(games.GamesGames[i].Id, games.GamesGames[i].Title, categories, games.GamesGames[i].Features, games.GamesGames[i].Description);
											}
										}
									}
									else //полный список, без поиска
									{
										string categories = "";
										for (int k = 0; k < games.GamesGames[i].Categories.Length; k++)
										{
											categories += games.GamesGames[i].Categories[k] + " ";
										}
										productsDataGridView1.Rows.Add(games.GamesGames[i].Id, games.GamesGames[i].Title, categories, games.GamesGames[i].Features, games.GamesGames[i].Description);

									}
								
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
					using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://shop.sceri.net/api/shop/order/my"))
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
								productsDataGridView1.Rows.Clear();
								productsDataGridView1.Refresh();
								for (int i = 0; i < games.GamesGames.Length; i++)
									productsDataGridView1.Rows.Add(games.GamesGames[i].Id, games.GamesGames[i].Title, games.GamesGames[i].Categories, games.GamesGames[i].Features, games.GamesGames[i].Description);
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
								usersDataGridView3.Rows.Clear();
								usersDataGridView3.Refresh();
								for (int i = 0; i < users.Payload.Length; i++)
									usersDataGridView3.Rows.Add(users.Payload[i].Id, users.Payload[i].Username, users.Payload[i].Email, users.Payload[i].Verified, users.Payload[i].PhoneNumber);
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
			LoadProducts();
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


        private async void деактивироватьУчётнуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://shop.sceri.net/api/shop/user/" + usersDataGridView3.Rows[usersDataGridView3.CurrentCell.RowIndex].Cells[0].Value.ToString() + "/update"))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "*/*");
						request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token);

						request.Content = new StringContent("{ \"verified\": false}");
                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                        var response = await httpClient.SendAsync(request);
                        var responseContent = await response.Content.ReadAsStringAsync();


                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            throw new Exception();
                        }
                    }
                }
				LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void отобразитьЗаказыКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			try
			{
				using (var httpClient = new HttpClient())
				{
					//using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://shop.sceri.net/api/shop/order/" + dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[0].Value.ToString() + "/list"))
					//{
					//	request.Headers.TryAddWithoutValidation("accept", "*/*");
					//	request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token);

					//	var response = await httpClient.SendAsync(request);
					//	var responseContent = await response.Content.ReadAsStringAsync();


					//	if (response.StatusCode == HttpStatusCode.OK)
					//	{
					//		//Десериализация полученного json при помощи заранее созданного класса
					//		var games = JsonConvert.DeserializeObject<Games>(responseContent);
					//		if (games.Success == true)
					//		{
					//			for (int i = 0; i < games.GamesGames.Length; i++) dataGridView1.Rows.Add(games.GamesGames[i].Id, games.GamesGames[i].Title, games.GamesGames[i].Categories, games.GamesGames[i].Features, games.GamesGames[i].Description);
					//		}
					//		else
					//		{
					//			throw new Exception();
					//		}
					//	}
					//	else
					//	{
					//		throw new Exception();
					//	}
					//}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}



        private void удалитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
			//nameBox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
			//textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
			//descriptionBox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
			//priceBox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
			Inside.SelectedTab = addOrderTab;
		}

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			nameBox.Text = productsDataGridView1.Rows[productsDataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
			textBox2.Text = productsDataGridView1.Rows[productsDataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
			descriptionBox.Text = productsDataGridView1.Rows[productsDataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
			priceBox.Text = productsDataGridView1.Rows[productsDataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
			Inside.SelectedTab = addTab;
        }

        private async void принятToolStripMenuItem_Click(object sender, EventArgs e)
        {
			try
			{
				using (var httpClient = new HttpClient())
				{
					using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://shop.sceri.net/api/shop/order/" + ordersDataGridView2.Rows[ordersDataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString() + "/update"))
					{
						request.Headers.TryAddWithoutValidation("accept", "*/*");
						request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token);

						request.Content = new StringContent("{ \"status\": \"CREATED\" }");
						request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

						var response = await httpClient.SendAsync(request);
						if (response.StatusCode != HttpStatusCode.OK)
						{
							throw new Exception();
						}
					}
				}
				LoadOrders();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private async void вОбработкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			try
			{
				using (var httpClient = new HttpClient())
				{
					using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://shop.sceri.net/api/shop/order/" + ordersDataGridView2.Rows[ordersDataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString() + "/update"))
					{
						request.Headers.TryAddWithoutValidation("accept", "*/*");
						request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token);

						request.Content = new StringContent("{ \"status\": \"HANDLER\" }");
						request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

						var response = await httpClient.SendAsync(request);
						if (response.StatusCode != HttpStatusCode.OK)
						{
							throw new Exception();
						}
					}
				}
				LoadOrders();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private async void отправленToolStripMenuItem_Click(object sender, EventArgs e)
        {
			try
			{
				using (var httpClient = new HttpClient())
				{
					using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://shop.sceri.net/api/shop/order/" + ordersDataGridView2.Rows[ordersDataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString() + "/update"))
					{
						request.Headers.TryAddWithoutValidation("accept", "*/*");
						request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token);

						request.Content = new StringContent("{ \"status\": \"SEND\" }");
						request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

						var response = await httpClient.SendAsync(request);
						if (response.StatusCode != HttpStatusCode.OK)
						{
							throw new Exception();
						}
					}
				}
				LoadOrders();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private async void закрытToolStripMenuItem_Click(object sender, EventArgs e)
        {
			try
			{
				using (var httpClient = new HttpClient())
				{
					using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://shop.sceri.net/api/shop/order/" + ordersDataGridView2.Rows[ordersDataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString() + "/update"))
					{
						request.Headers.TryAddWithoutValidation("accept", "*/*");
						request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + token);

						request.Content = new StringContent("{ \"status\": \"FINISHED\" }");
						request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

						var response = await httpClient.SendAsync(request);
						if (response.StatusCode != HttpStatusCode.OK)
						{
							throw new Exception();
						}
					}
				}
				LoadOrders();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
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
		public string[] Categories { get; set; }
	}
}