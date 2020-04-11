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
            this.addTab = new System.Windows.Forms.TabPage();
            this.Outside.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.Inside.SuspendLayout();
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
            this.lookTab.Location = new System.Drawing.Point(4, 29);
            this.lookTab.Name = "lookTab";
            this.lookTab.Padding = new System.Windows.Forms.Padding(3);
            this.lookTab.Size = new System.Drawing.Size(1863, 969);
            this.lookTab.TabIndex = 1;
            this.lookTab.Text = "Просмотр товаров";
            this.lookTab.UseVisualStyleBackColor = true;
            // 
            // addTab
            // 
            this.addTab.Location = new System.Drawing.Point(4, 29);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(1863, 969);
            this.addTab.TabIndex = 2;
            this.addTab.Text = "Добавление товаров";
            this.addTab.UseVisualStyleBackColor = true;
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
    }
}

