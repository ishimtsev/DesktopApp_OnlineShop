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
            this.Outside = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.Inside = new System.Windows.Forms.TabControl();
            this.Statistics = new System.Windows.Forms.TabPage();
            this.lookTab = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Outside.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.Inside.SuspendLayout();
            this.lookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.loginTab.Location = new System.Drawing.Point(4, 29);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(1885, 1015);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "loginTab";
            this.loginTab.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1853, 902);
            this.dataGridView1.TabIndex = 0;
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.textBox4);
            this.addTab.Controls.Add(this.label4);
            this.addTab.Controls.Add(this.button2);
            this.addTab.Controls.Add(this.textBox3);
            this.addTab.Controls.Add(this.textBox2);
            this.addTab.Controls.Add(this.textBox1);
            this.addTab.Controls.Add(this.label3);
            this.addTab.Controls.Add(this.label2);
            this.addTab.Controls.Add(this.pictureBox1);
            this.addTab.Controls.Add(this.label1);
            this.addTab.Controls.Add(this.Path);
            this.addTab.Controls.Add(this.button1);
            this.addTab.Location = new System.Drawing.Point(4, 29);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(1863, 969);
            this.addTab.TabIndex = 2;
            this.addTab.Text = "Добавление товаров";
            this.addTab.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить картинку товара";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(489, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(489, 156);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 140);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(489, 348);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 26);
            this.textBox3.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "Принять";
            this.button2.UseVisualStyleBackColor = true;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(489, 427);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 26);
            this.textBox4.TabIndex = 11;
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
            this.mainTab.ResumeLayout(false);
            this.Inside.ResumeLayout(false);
            this.lookTab.ResumeLayout(false);
            this.lookTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

