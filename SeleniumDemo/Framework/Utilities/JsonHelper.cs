using Newtonsoft.Json;

namespace SeleniumDemo.Framework.Utilities
{
	public class JsonHelper
	{
		public void PopulateJson(string value, object target)
		{
			JsonConvert.PopulateObject(value, target);
		}
	}
}