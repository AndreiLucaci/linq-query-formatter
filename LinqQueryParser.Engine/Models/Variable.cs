using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LinqQueryParser.Engine.Models
{
	public class Variable
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string Value { get; set; }
		public string Rawvalue { get; set; }
		public string Size { get; set; }
		public string RawType { get; set; }

		public string GetDeclareValue() => Size != "-1" ? $"DECLARE {Name} {Type}({Size})" : $"DECLARE {Name} {Type}";
		public string GetSetValue() => Types.NumberTypes.Contains(Type.Trim()) ? GetNumberSetValue() : GetStringSetValue();

		public string GetSizeValue()
		{
			var match = Regex.Match(Size, "= (-?\\d+)");

			return match.Groups.Count >= 2 ? match.Groups[1].Value : Size;
		}

		private string GetNumberSetValue() => $"SET {Name} = {Value}";
		private string GetStringSetValue() => $"SET {Name} = '{Value}'";
	}
}
