
namespace SeleniumDemo.Framework.Utilities
{
	public static class Tools
	{
		private static readonly JsonHelper _jsonHelper = new JsonHelper();

		public static JsonHelper Json
		{
			get { return _jsonHelper; }
		}
    }
}