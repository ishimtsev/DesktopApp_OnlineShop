using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp_OnlineShop
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			Login.try_login();
			//Cache.state = new State();
			//Cache.state = State.Login;
			DataBase.connect();
			//FSM.Start();
		}

		public void InitializeTabs()
		{
			foreach (TabPage tab in tabControl1.TabPages)
			{

			}
		}
	}
}
