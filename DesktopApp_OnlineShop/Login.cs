using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp_OnlineShop
{
	public static class Login
	{
		public static bool logged;
		// login и password в Config

		public static void try_login()
		{
			try
			{
				//logging in
				logged = true;
			}

			catch (Exception er)
			{
				//обработка
			}


		}

	}
}
