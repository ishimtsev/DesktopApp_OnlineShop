using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp_OnlineShop
{
	public static class FSM
	{

		public static void Start()
		{
			switch (Cache.state)
			{
				case State.Login:
					Console.WriteLine("Вы нажали букву Y");
					break;
				case State.Register:
					Console.WriteLine("Вы нажали букву N");
					break;
				case State.Home:
					Console.WriteLine("Вы нажали букву Y");
					break;
				case State.Cart:
					Console.WriteLine("Вы нажали букву N");
					break;
				case State.Profile:
					Console.WriteLine("Вы нажали букву Y");
					break;
				case State.Caption:
					Console.WriteLine("Вы нажали букву N");
					break;
			}
		}

		public static void Start()
	}
}
