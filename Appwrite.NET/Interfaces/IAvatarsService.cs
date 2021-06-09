using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Interfaces
{
	public interface IAvatarsService
	{
		string GetBrowser(string code, int? width = 100, int? height = 100, int? quality = 100);
		string GetCreditCard(string code, int? width = 100, int? height = 100, int? quality = 100);
		string GetFavicon(string url);
		string GetFlag(string code, int? width = 100, int? height = 100, int? quality = 100);
		string GetImage(string url, int? width = 400, int? height = 400);
		string GetInitials(string name = "", int? width = 500, int? height = 500, string color = "", string background = "");
		string GetQR(string text, int? size = 400, int? margin = 1, bool? download = false);
	}
}
