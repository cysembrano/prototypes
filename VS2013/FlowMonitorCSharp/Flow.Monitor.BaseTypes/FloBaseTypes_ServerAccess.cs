using RemObjects.SDK;

namespace Namespace
{
	public class ServerAccess
	{
		private static ServerAccess _instance;

		public static ServerAccess Instance
		{
			get
			{
				if (ServerAccess._instance == null)
					ServerAccess._instance = new ServerAccess();
				return ServerAccess._instance;
			}
		}

		private System.String _serverUrl;

		public System.String ServerUrl
		{
			get
			{
				return this._serverUrl;
			}
		}

		public ServerAccess()
		{
			this._serverUrl = "http://yourserver.example.com:8099/bin";
		}
	}

}
