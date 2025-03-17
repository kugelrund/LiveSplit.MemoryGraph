using System;
using System.Globalization;

namespace LiveSplit.MemoryGraph
{
	public static class Utils
	{
		public static float CultureSafeFloatParse(string vstr, float def = 1)
		{
			//Because C# just uses system's culture which is very problematic for us
			if (vstr != null)
			{
				float value = 0;
				if (!float.TryParse(vstr, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out value) &&
					!float.TryParse(vstr, NumberStyles.Any, CultureInfo.GetCultureInfo("de-DE"), out value))
				{
					return def;
				}

				return value;
			}
			else
				return def;
		}

		public static bool TryParseEnglishCultureEnforced(string str, out float value)
		{
			value = 0;

			if (!string.IsNullOrEmpty(str))
			{
				str = str.Replace(',', '.');
				return float.TryParse(str, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out value);
			}
			else
				return false;
		}

		public static bool TryParseHex(string str, out int integer)
		{
			integer = 0;
			if (string.IsNullOrEmpty(str))
			{
				return false;
			}
			else
			{
				if (str.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase))
				{
					str = str.Substring(2);
				}

				return int.TryParse(str, NumberStyles.HexNumber, null, out integer);
			}
		}
	}
}
