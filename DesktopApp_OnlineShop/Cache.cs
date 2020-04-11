using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp_OnlineShop
{
	public static class Cache
	{
		public static State state;
	}

	public enum State
	{
		Login,
		Register,
		Home,
		Cart,
		Profile,
		Caption
	}
}
