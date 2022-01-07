using System;
using System.IO;
using SeleniumDemo.Framework.Utilities;

namespace SeleniumDemo.Framework
{
	public class Settings
	{
		public Settings()
		{
			const string settingsName = "settings.json";
			string defaultSettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, settingsName);
			string result = String.Empty;

			if (File.Exists(defaultSettingsPath))
			{
				result = File.ReadAllText(defaultSettingsPath);
			}
			Tools.Json.PopulateJson(result, this);
		}

		public string Host { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}