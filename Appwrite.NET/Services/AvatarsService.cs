using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Services
{
	public class AvatarsService: IAvatarService
	{
		private AppwriteClient _appwrite;
		private const string basePath = "/avatars";

		public AvatarsService(AppwriteClient appwrite)
		{
			_appwrite = appwrite;
		}

		public string GetBrowser(string code, int? width = 100, int? height = 100, int? quality = 100) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "width", width },
				{ "height", height },
				{ "quality", quality },
			};

			return $"{_appwrite.GetEndpoint()}{basePath}/browsers/{code}?{parameters.ToQueryString()}";
		}
		public string GetCreditCard(string code, int? width = 100, int? height = 100, int? quality = 100) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "width", width },
				{ "height", height },
				{ "quality", quality },
			};

			return $"{_appwrite.GetEndpoint()}{basePath}/credit-cards/{code}?{parameters.ToQueryString()}";
		}
		public string GetFavicon(string url) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "url", url },
			};

			return $"{_appwrite.GetEndpoint()}{basePath}/favicon?{parameters.ToQueryString()}";
		}
		public string GetFlag(string code, int? width = 100, int? height = 100, int? quality = 100) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "width", width },
				{ "height", height },
				{ "quality", quality },
			};

			return $"{_appwrite.GetEndpoint()}{basePath}/flags/{code}?{parameters.ToQueryString()}";
		}
		public string GetImage(string url, int? width = 400, int? height = 400) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "url", url },
				{ "width", width },
				{ "height", height },
			};

			return $"{_appwrite.GetEndpoint()}{basePath}?{parameters.ToQueryString()}";
		}
		public string GetInitials(string name = "", int? width = 500, int? height = 500, string color = "", string background = "") {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "name", name },
				{ "width", width },
				{ "height", height },
				{ "color", color },
				{ "background", background },
			};

			return $"{_appwrite.GetEndpoint()}{basePath}/initials?{parameters.ToQueryString()}";
		}
		public string GetQR(string text, int? size = 400, int? margin = 1, bool? download = false) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "text", text },
				{ "size", size },
				{ "margin", margin },
				{ "download", download },
			};

			return $"{_appwrite.GetEndpoint()}{basePath}/qr?{parameters.ToQueryString()}";
		}
	}
}
