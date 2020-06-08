namespace DesktopApp_OnlineShop
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.Outside = new System.Windows.Forms.TabControl();
			this.loginTab = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.loginButton = new System.Windows.Forms.Button();
			this.passBox = new System.Windows.Forms.TextBox();
			this.loginBox = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.Label();
			this.Login = new System.Windows.Forms.Label();
			this.mainTab = new System.Windows.Forms.TabPage();
			this.Inside = new System.Windows.Forms.TabControl();
			this.Statistics = new System.Windows.Forms.TabPage();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lookTab = new System.Windows.Forms.TabPage();
			this.Search = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.productsDataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.changeTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.usersDataGridView3 = new System.Windows.Forms.DataGridView();
			this.addTab = new System.Windows.Forms.TabPage();
			this.stashBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.putProduct = new System.Windows.Forms.Button();
			this.priceBox = new System.Windows.Forms.TextBox();
			this.descriptionBox = new System.Windows.Forms.TextBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Path = new System.Windows.Forms.Label();
			this.addImage = new System.Windows.Forms.Button();
			this.lookOrderTab = new System.Windows.Forms.TabPage();
			this.searchButtonOrders = new System.Windows.Forms.Button();
			this.searchBoxOrders = new System.Windows.Forms.TextBox();
			this.ordersDataGridView2 = new System.Windows.Forms.DataGridView();
			this.addOrderTab = new System.Windows.Forms.TabPage();
			this.Outside.SuspendLayout();
			this.loginTab.SuspendLayout();
			this.mainTab.SuspendLayout();
			this.Inside.SuspendLayout();
			this.Statistics.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.lookTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productsDataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usersDataGridView3)).BeginInit();
			this.addTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.lookOrderTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// Outside
			// 
			this.Outside.Controls.Add(this.loginTab);
			this.Outside.Controls.Add(this.mainTab);
			this.Outside.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Outside.Location = new System.Drawing.Point(0, 0);
			this.Outside.Margin = new System.Windows.Forms.Padding(2);
			this.Outside.Name = "Outside";
			this.Outside.SelectedIndex = 0;
			this.Outside.Size = new System.Drawing.Size(962, 681);
			this.Outside.TabIndex = 0;
			// 
			// loginTab
			// 
			this.loginTab.Controls.Add(this.label5);
			this.loginTab.Controls.Add(this.loginButton);
			this.loginTab.Controls.Add(this.passBox);
			this.loginTab.Controls.Add(this.loginBox);
			this.loginTab.Controls.Add(this.Password);
			this.loginTab.Controls.Add(this.Login);
			this.loginTab.Location = new System.Drawing.Point(4, 22);
			this.loginTab.Margin = new System.Windows.Forms.Padding(2);
			this.loginTab.Name = "loginTab";
			this.loginTab.Padding = new System.Windows.Forms.Padding(2);
			this.loginTab.Size = new System.Drawing.Size(954, 655);
			this.loginTab.TabIndex = 0;
			this.loginTab.Text = "loginTab";
			this.loginTab.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(458, 407);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 13);
			this.label5.TabIndex = 5;
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(418, 280);
			this.loginButton.Margin = new System.Windows.Forms.Padding(2);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(78, 26);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Вход";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// passBox
			// 
			this.passBox.Location = new System.Drawing.Point(422, 243);
			this.passBox.Margin = new System.Windows.Forms.Padding(2);
			this.passBox.Name = "passBox";
			this.passBox.Size = new System.Drawing.Size(68, 20);
			this.passBox.TabIndex = 3;
			this.passBox.Text = "test";
			this.passBox.UseSystemPasswordChar = true;
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(422, 176);
			this.loginBox.Margin = new System.Windows.Forms.Padding(2);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(68, 20);
			this.loginBox.TabIndex = 2;
			this.loginBox.Text = "testuser";
			// 
			// Password
			// 
			this.Password.AutoSize = true;
			this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Password.Location = new System.Drawing.Point(412, 210);
			this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(89, 26);
			this.Password.TabIndex = 1;
			this.Password.Text = "Пароль";
			// 
			// Login
			// 
			this.Login.AutoSize = true;
			this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Login.Location = new System.Drawing.Point(422, 144);
			this.Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(72, 26);
			this.Login.TabIndex = 0;
			this.Login.Text = "Логин";
			// 
			// mainTab
			// 
			this.mainTab.Controls.Add(this.Inside);
			this.mainTab.Location = new System.Drawing.Point(4, 22);
			this.mainTab.Margin = new System.Windows.Forms.Padding(2);
			this.mainTab.Name = "mainTab";
			this.mainTab.Padding = new System.Windows.Forms.Padding(2);
			this.mainTab.Size = new System.Drawing.Size(954, 655);
			this.mainTab.TabIndex = 1;
			this.mainTab.Text = "mainTab";
			this.mainTab.UseVisualStyleBackColor = true;
			// 
			// Inside
			// 
			this.Inside.Controls.Add(this.Statistics);
			this.Inside.Controls.Add(this.lookTab);
			this.Inside.Controls.Add(this.tabPage1);
			this.Inside.Controls.Add(this.addTab);
			this.Inside.Controls.Add(this.lookOrderTab);
			this.Inside.Controls.Add(this.addOrderTab);
			this.Inside.Location = new System.Drawing.Point(6, 5);
			this.Inside.Margin = new System.Windows.Forms.Padding(2);
			this.Inside.Name = "Inside";
			this.Inside.SelectedIndex = 0;
			this.Inside.Size = new System.Drawing.Size(952, 651);
			this.Inside.TabIndex = 0;
			this.Inside.SelectedIndexChanged += new System.EventHandler(this.Inside_TabIndexChanged);
			this.Inside.TabIndexChanged += new System.EventHandler(this.Inside_TabIndexChanged);
			// 
			// Statistics
			// 
			this.Statistics.Controls.Add(this.chart2);
			this.Statistics.Controls.Add(this.chart1);
			this.Statistics.Location = new System.Drawing.Point(4, 22);
			this.Statistics.Margin = new System.Windows.Forms.Padding(2);
			this.Statistics.Name = "Statistics";
			this.Statistics.Padding = new System.Windows.Forms.Padding(2);
			this.Statistics.Size = new System.Drawing.Size(944, 625);
			this.Statistics.TabIndex = 0;
			this.Statistics.Text = "Статистика";
			this.Statistics.UseVisualStyleBackColor = true;
			// 
			// chart2
			// 
			chartArea3.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chart2.Legends.Add(legend3);
			this.chart2.Location = new System.Drawing.Point(519, 69);
			this.chart2.Name = "chart2";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			this.chart2.Series.Add(series3);
			this.chart2.Size = new System.Drawing.Size(300, 300);
			this.chart2.TabIndex = 1;
			this.chart2.Text = "chart2";
			// 
			// chart1
			// 
			chartArea4.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea4);
			legend4.Name = "Legend1";
			this.chart1.Legends.Add(legend4);
			this.chart1.Location = new System.Drawing.Point(84, 69);
			this.chart1.Name = "chart1";
			series4.ChartArea = "ChartArea1";
			series4.Legend = "Legend1";
			series4.Name = "Series1";
			this.chart1.Series.Add(series4);
			this.chart1.Size = new System.Drawing.Size(300, 300);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// lookTab
			// 
			this.lookTab.Controls.Add(this.Search);
			this.lookTab.Controls.Add(this.searchBox);
			this.lookTab.Controls.Add(this.productsDataGridView1);
			this.lookTab.Location = new System.Drawing.Point(4, 22);
			this.lookTab.Margin = new System.Windows.Forms.Padding(2);
			this.lookTab.Name = "lookTab";
			this.lookTab.Padding = new System.Windows.Forms.Padding(2);
			this.lookTab.Size = new System.Drawing.Size(944, 625);
			this.lookTab.TabIndex = 1;
			this.lookTab.Text = "Просмотр товаров";
			this.lookTab.UseVisualStyleBackColor = true;
			// 
			// Search
			// 
			this.Search.Location = new System.Drawing.Point(192, 6);
			this.Search.Margin = new System.Windows.Forms.Padding(2);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(50, 25);
			this.Search.TabIndex = 2;
			this.Search.Text = "Поиск";
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(4, 11);
			this.searchBox.Margin = new System.Windows.Forms.Padding(2);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(186, 20);
			this.searchBox.TabIndex = 1;
			// 
			// productsDataGridView1
			// 
			this.productsDataGridView1.AllowUserToAddRows = false;
			this.productsDataGridView1.AllowUserToDeleteRows = false;
			this.productsDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.productsDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.productsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productsDataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.productsDataGridView1.Location = new System.Drawing.Point(4, 40);
			this.productsDataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.productsDataGridView1.Name = "productsDataGridView1";
			this.productsDataGridView1.ReadOnly = true;
			this.productsDataGridView1.RowHeadersWidth = 82;
			this.productsDataGridView1.RowTemplate.Height = 28;
			this.productsDataGridView1.Size = new System.Drawing.Size(936, 582);
			this.productsDataGridView1.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTSMI,
            this.deleteTSMI});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
			// 
			// changeTSMI
			// 
			this.changeTSMI.Name = "changeTSMI";
			this.changeTSMI.Size = new System.Drawing.Size(128, 22);
			this.changeTSMI.Text = "Изменить";
			this.changeTSMI.Click += new System.EventHandler(this.changeTSMI_Click);
			// 
			// deleteTSMI
			// 
			this.deleteTSMI.Name = "deleteTSMI";
			this.deleteTSMI.Size = new System.Drawing.Size(128, 22);
			this.deleteTSMI.Text = "Удалить";
			this.deleteTSMI.Click += new System.EventHandler(this.deleteTSMI_Click);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.usersDataGridView3);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(944, 625);
			this.tabPage1.TabIndex = 5;
			this.tabPage1.Text = "Пользователи";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(192, 6);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 25);
			this.button1.TabIndex = 2;
			this.button1.Text = "Поиск";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(4, 11);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(186, 20);
			this.textBox1.TabIndex = 1;
			// 
			// usersDataGridView3
			// 
			this.usersDataGridView3.AllowUserToAddRows = false;
			this.usersDataGridView3.AllowUserToDeleteRows = false;
			this.usersDataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.usersDataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.usersDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.usersDataGridView3.ContextMenuStrip = this.contextMenuStrip1;
			this.usersDataGridView3.Location = new System.Drawing.Point(4, 40);
			this.usersDataGridView3.Margin = new System.Windows.Forms.Padding(2);
			this.usersDataGridView3.Name = "usersDataGridView3";
			this.usersDataGridView3.ReadOnly = true;
			this.usersDataGridView3.RowHeadersWidth = 82;
			this.usersDataGridView3.RowTemplate.Height = 28;
			this.usersDataGridView3.Size = new System.Drawing.Size(936, 582);
			this.usersDataGridView3.TabIndex = 0;
			// 
			// addTab
			// 
			this.addTab.Controls.Add(this.stashBox);
			this.addTab.Controls.Add(this.label4);
			this.addTab.Controls.Add(this.putProduct);
			this.addTab.Controls.Add(this.priceBox);
			this.addTab.Controls.Add(this.descriptionBox);
			this.addTab.Controls.Add(this.nameBox);
			this.addTab.Controls.Add(this.label3);
			this.addTab.Controls.Add(this.label2);
			this.addTab.Controls.Add(this.pictureBox1);
			this.addTab.Controls.Add(this.label1);
			this.addTab.Controls.Add(this.Path);
			this.addTab.Controls.Add(this.addImage);
			this.addTab.Location = new System.Drawing.Point(4, 22);
			this.addTab.Margin = new System.Windows.Forms.Padding(2);
			this.addTab.Name = "addTab";
			this.addTab.Padding = new System.Windows.Forms.Padding(2);
			this.addTab.Size = new System.Drawing.Size(944, 625);
			this.addTab.TabIndex = 2;
			this.addTab.Text = "Добавление/Изменение товаров";
			this.addTab.UseVisualStyleBackColor = true;
			// 
			// stashBox
			// 
			this.stashBox.Location = new System.Drawing.Point(441, 327);
			this.stashBox.Margin = new System.Windows.Forms.Padding(2);
			this.stashBox.Name = "stashBox";
			this.stashBox.Size = new System.Drawing.Size(76, 20);
			this.stashBox.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(439, 312);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Количество на складе";
			// 
			// putProduct
			// 
			this.putProduct.Location = new System.Drawing.Point(207, 272);
			this.putProduct.Margin = new System.Windows.Forms.Padding(2);
			this.putProduct.Name = "putProduct";
			this.putProduct.Size = new System.Drawing.Size(124, 37);
			this.putProduct.TabIndex = 9;
			this.putProduct.Text = "Принять";
			this.putProduct.UseVisualStyleBackColor = true;
			this.putProduct.Click += new System.EventHandler(this.putProduct_Click);
			// 
			// priceBox
			// 
			this.priceBox.Location = new System.Drawing.Point(441, 288);
			this.priceBox.Margin = new System.Windows.Forms.Padding(2);
			this.priceBox.Name = "priceBox";
			this.priceBox.Size = new System.Drawing.Size(76, 20);
			this.priceBox.TabIndex = 8;
			// 
			// descriptionBox
			// 
			this.descriptionBox.Location = new System.Drawing.Point(441, 116);
			this.descriptionBox.Margin = new System.Windows.Forms.Padding(2);
			this.descriptionBox.Multiline = true;
			this.descriptionBox.Name = "descriptionBox";
			this.descriptionBox.Size = new System.Drawing.Size(364, 124);
			this.descriptionBox.TabIndex = 7;
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(441, 61);
			this.nameBox.Margin = new System.Windows.Forms.Padding(2);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(364, 20);
			this.nameBox.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(439, 101);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Описание";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(439, 272);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Цена";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(143, 47);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(276, 162);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(439, 47);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Название";
			// 
			// Path
			// 
			this.Path.AutoSize = true;
			this.Path.Location = new System.Drawing.Point(139, 245);
			this.Path.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Path.Name = "Path";
			this.Path.Size = new System.Drawing.Size(31, 13);
			this.Path.TabIndex = 1;
			this.Path.Text = "Путь";
			// 
			// addImage
			// 
			this.addImage.Location = new System.Drawing.Point(143, 218);
			this.addImage.Margin = new System.Windows.Forms.Padding(2);
			this.addImage.Name = "addImage";
			this.addImage.Size = new System.Drawing.Size(178, 20);
			this.addImage.TabIndex = 0;
			this.addImage.Text = "Добавить картинку товара";
			this.addImage.UseVisualStyleBackColor = true;
			this.addImage.Click += new System.EventHandler(this.addImage_Click);
			// 
			// lookOrderTab
			// 
			this.lookOrderTab.Controls.Add(this.searchButtonOrders);
			this.lookOrderTab.Controls.Add(this.searchBoxOrders);
			this.lookOrderTab.Controls.Add(this.ordersDataGridView2);
			this.lookOrderTab.Location = new System.Drawing.Point(4, 22);
			this.lookOrderTab.Margin = new System.Windows.Forms.Padding(2);
			this.lookOrderTab.Name = "lookOrderTab";
			this.lookOrderTab.Padding = new System.Windows.Forms.Padding(2);
			this.lookOrderTab.Size = new System.Drawing.Size(944, 625);
			this.lookOrderTab.TabIndex = 3;
			this.lookOrderTab.Text = "Просмотр заказов";
			this.lookOrderTab.UseVisualStyleBackColor = true;
			// 
			// searchButtonOrders
			// 
			this.searchButtonOrders.Location = new System.Drawing.Point(194, 4);
			this.searchButtonOrders.Margin = new System.Windows.Forms.Padding(2);
			this.searchButtonOrders.Name = "searchButtonOrders";
			this.searchButtonOrders.Size = new System.Drawing.Size(50, 24);
			this.searchButtonOrders.TabIndex = 5;
			this.searchButtonOrders.Text = "Поиск";
			this.searchButtonOrders.UseVisualStyleBackColor = true;
			this.searchButtonOrders.Click += new System.EventHandler(this.searchButtonOrders_Click);
			// 
			// searchBoxOrders
			// 
			this.searchBoxOrders.Location = new System.Drawing.Point(6, 8);
			this.searchBoxOrders.Margin = new System.Windows.Forms.Padding(2);
			this.searchBoxOrders.Name = "searchBoxOrders";
			this.searchBoxOrders.Size = new System.Drawing.Size(186, 20);
			this.searchBoxOrders.TabIndex = 4;
			// 
			// ordersDataGridView2
			// 
			this.ordersDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ordersDataGridView2.ContextMenuStrip = this.contextMenuStrip1;
			this.ordersDataGridView2.Location = new System.Drawing.Point(4, 36);
			this.ordersDataGridView2.Margin = new System.Windows.Forms.Padding(2);
			this.ordersDataGridView2.Name = "ordersDataGridView2";
			this.ordersDataGridView2.RowHeadersWidth = 82;
			this.ordersDataGridView2.RowTemplate.Height = 28;
			this.ordersDataGridView2.Size = new System.Drawing.Size(938, 587);
			this.ordersDataGridView2.TabIndex = 3;
			// 
			// addOrderTab
			// 
			this.addOrderTab.Location = new System.Drawing.Point(4, 22);
			this.addOrderTab.Margin = new System.Windows.Forms.Padding(2);
			this.addOrderTab.Name = "addOrderTab";
			this.addOrderTab.Padding = new System.Windows.Forms.Padding(2);
			this.addOrderTab.Size = new System.Drawing.Size(944, 625);
			this.addOrderTab.TabIndex = 4;
			this.addOrderTab.Text = "Добавление/Изменение заказов";
			this.addOrderTab.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(962, 681);
			this.Controls.Add(this.Outside);
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "Form1";
			this.Text = "Админка";
			this.Outside.ResumeLayout(false);
			this.loginTab.ResumeLayout(false);
			this.loginTab.PerformLayout();
			this.mainTab.ResumeLayout(false);
			this.Inside.ResumeLayout(false);
			this.Statistics.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.lookTab.ResumeLayout(false);
			this.lookTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.productsDataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.usersDataGridView3)).EndInit();
			this.addTab.ResumeLayout(false);
			this.addTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.lookOrderTab.ResumeLayout(false);
			this.lookOrderTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TabControl Outside;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabControl Inside;
        private System.Windows.Forms.TabPage Statistics;
        private System.Windows.Forms.TabPage lookTab;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.DataGridView productsDataGridView1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.TextBox stashBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button putProduct;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeTSMI;
        private System.Windows.Forms.ToolStripMenuItem deleteTSMI;
        private System.Windows.Forms.TabPage lookOrderTab;
        private System.Windows.Forms.Button searchButtonOrders;
        private System.Windows.Forms.TextBox searchBoxOrders;
        private System.Windows.Forms.DataGridView ordersDataGridView2;
        private System.Windows.Forms.TabPage addOrderTab;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView usersDataGridView3;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
	}
}