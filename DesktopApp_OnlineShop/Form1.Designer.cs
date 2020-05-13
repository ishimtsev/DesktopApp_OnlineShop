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
            this.Outside = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.Inside = new System.Windows.Forms.TabControl();
            this.Statistics = new System.Windows.Forms.TabPage();
            this.lookTab = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTSMI = new System.Windows.Forms.ToolStripMenuItem();
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
            this.addOrderTab = new System.Windows.Forms.TabPage();
            this.searchButtonOrders = new System.Windows.Forms.Button();
            this.searchBoxOrders = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Outside.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.Inside.SuspendLayout();
            this.lookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.addTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.lookOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Outside
            // 
            this.Outside.Controls.Add(this.loginTab);
            this.Outside.Controls.Add(this.mainTab);
            this.Outside.Location = new System.Drawing.Point(1, -2);
            this.Outside.Name = "Outside";
            this.Outside.SelectedIndex = 0;
            this.Outside.Size = new System.Drawing.Size(1893, 1048);
            this.Outside.TabIndex = 0;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.loginButton);
            this.loginTab.Controls.Add(this.passBox);
            this.loginTab.Controls.Add(this.loginBox);
            this.loginTab.Controls.Add(this.Password);
            this.loginTab.Controls.Add(this.Login);
            this.loginTab.Location = new System.Drawing.Point(4, 29);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(1885, 1015);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "loginTab";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(866, 387);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(117, 40);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(872, 331);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 26);
            this.passBox.TabIndex = 3;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(872, 228);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 26);
            this.loginBox.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(859, 280);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(124, 37);
            this.Password.TabIndex = 1;
            this.Password.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(874, 179);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(98, 37);
            this.Login.TabIndex = 0;
            this.Login.Text = "Логин";
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.Inside);
            this.mainTab.Location = new System.Drawing.Point(4, 29);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(1885, 1015);
            this.mainTab.TabIndex = 1;
            this.mainTab.Text = "mainTab";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // Inside
            // 
            this.Inside.Controls.Add(this.Statistics);
            this.Inside.Controls.Add(this.lookTab);
            this.Inside.Controls.Add(this.addTab);
            this.Inside.Controls.Add(this.lookOrderTab);
            this.Inside.Controls.Add(this.addOrderTab);
            this.Inside.Location = new System.Drawing.Point(8, 7);
            this.Inside.Name = "Inside";
            this.Inside.SelectedIndex = 0;
            this.Inside.Size = new System.Drawing.Size(1871, 1002);
            this.Inside.TabIndex = 0;
            // 
            // Statistics
            // 
            this.Statistics.Location = new System.Drawing.Point(4, 29);
            this.Statistics.Name = "Statistics";
            this.Statistics.Padding = new System.Windows.Forms.Padding(3);
            this.Statistics.Size = new System.Drawing.Size(1863, 969);
            this.Statistics.TabIndex = 0;
            this.Statistics.Text = "Статистика";
            this.Statistics.UseVisualStyleBackColor = true;
            // 
            // lookTab
            // 
            this.lookTab.Controls.Add(this.Search);
            this.lookTab.Controls.Add(this.searchBox);
            this.lookTab.Controls.Add(this.dataGridView1);
            this.lookTab.Location = new System.Drawing.Point(4, 29);
            this.lookTab.Name = "lookTab";
            this.lookTab.Padding = new System.Windows.Forms.Padding(3);
            this.lookTab.Size = new System.Drawing.Size(1863, 969);
            this.lookTab.TabIndex = 1;
            this.lookTab.Text = "Просмотр товаров";
            this.lookTab.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(291, 18);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 26);
            this.Search.TabIndex = 2;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(7, 18);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(278, 26);
            this.searchBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1853, 902);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTSMI,
            this.deleteTSMI});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 64);
            // 
            // changeTSMI
            // 
            this.changeTSMI.Name = "changeTSMI";
            this.changeTSMI.Size = new System.Drawing.Size(163, 30);
            this.changeTSMI.Text = "Изменить";
            this.changeTSMI.Click += new System.EventHandler(this.changeTSMI_Click);
            // 
            // deleteTSMI
            // 
            this.deleteTSMI.Name = "deleteTSMI";
            this.deleteTSMI.Size = new System.Drawing.Size(163, 30);
            this.deleteTSMI.Text = "Удалить";
            this.deleteTSMI.Click += new System.EventHandler(this.deleteTSMI_Click);
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
            this.addTab.Location = new System.Drawing.Point(4, 29);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(1863, 969);
            this.addTab.TabIndex = 2;
            this.addTab.Text = "Добавление/Изменение товаров";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // stashBox
            // 
            this.stashBox.Location = new System.Drawing.Point(489, 427);
            this.stashBox.Name = "stashBox";
            this.stashBox.Size = new System.Drawing.Size(113, 26);
            this.stashBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Количество на складе";
            // 
            // putProduct
            // 
            this.putProduct.Location = new System.Drawing.Point(137, 395);
            this.putProduct.Name = "putProduct";
            this.putProduct.Size = new System.Drawing.Size(187, 58);
            this.putProduct.TabIndex = 9;
            this.putProduct.Text = "Принять";
            this.putProduct.UseVisualStyleBackColor = true;
            this.putProduct.Click += new System.EventHandler(this.putProduct_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(489, 348);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(113, 26);
            this.priceBox.TabIndex = 8;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(489, 156);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(318, 140);
            this.descriptionBox.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(489, 70);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(318, 26);
            this.nameBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 249);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // Path
            // 
            this.Path.AutoSize = true;
            this.Path.Location = new System.Drawing.Point(37, 354);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(46, 20);
            this.Path.TabIndex = 1;
            this.Path.Text = "Путь";
            // 
            // addImage
            // 
            this.addImage.Location = new System.Drawing.Point(41, 312);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(268, 30);
            this.addImage.TabIndex = 0;
            this.addImage.Text = "Добавить картинку товара";
            this.addImage.UseVisualStyleBackColor = true;
            this.addImage.Click += new System.EventHandler(this.addImage_Click);
            // 
            // lookOrderTab
            // 
            this.lookOrderTab.Controls.Add(this.searchButtonOrders);
            this.lookOrderTab.Controls.Add(this.searchBoxOrders);
            this.lookOrderTab.Controls.Add(this.dataGridView2);
            this.lookOrderTab.Location = new System.Drawing.Point(4, 29);
            this.lookOrderTab.Name = "lookOrderTab";
            this.lookOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.lookOrderTab.Size = new System.Drawing.Size(1863, 969);
            this.lookOrderTab.TabIndex = 3;
            this.lookOrderTab.Text = "Просмотр заказов";
            this.lookOrderTab.UseVisualStyleBackColor = true;
            // 
            // addOrderTab
            // 
            this.addOrderTab.Location = new System.Drawing.Point(4, 29);
            this.addOrderTab.Name = "addOrderTab";
            this.addOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.addOrderTab.Size = new System.Drawing.Size(1863, 969);
            this.addOrderTab.TabIndex = 4;
            this.addOrderTab.Text = "Добавление/Изменение заказов";
            this.addOrderTab.UseVisualStyleBackColor = true;
            // 
            // searchButtonOrders
            // 
            this.searchButtonOrders.Location = new System.Drawing.Point(292, 12);
            this.searchButtonOrders.Name = "searchButtonOrders";
            this.searchButtonOrders.Size = new System.Drawing.Size(75, 26);
            this.searchButtonOrders.TabIndex = 5;
            this.searchButtonOrders.Text = "Поиск";
            this.searchButtonOrders.UseVisualStyleBackColor = true;
            this.searchButtonOrders.Click += new System.EventHandler(this.searchButtonOrders_Click);
            // 
            // searchBoxOrders
            // 
            this.searchBoxOrders.Location = new System.Drawing.Point(8, 12);
            this.searchBoxOrders.Name = "searchBoxOrders";
            this.searchBoxOrders.Size = new System.Drawing.Size(278, 26);
            this.searchBoxOrders.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView2.Location = new System.Drawing.Point(5, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1853, 902);
            this.dataGridView2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.Outside);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Outside.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.mainTab.ResumeLayout(false);
            this.Inside.ResumeLayout(false);
            this.lookTab.ResumeLayout(false);
            this.lookTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.lookOrderTab.ResumeLayout(false);
            this.lookOrderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage addOrderTab;
    }
}

