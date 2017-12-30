using System.Collections.Generic;

namespace LinqQueryParser.Engine.Models
{
	public static class Types
	{
		public static readonly List<string> NumberTypes = new List<string>
		{
			"tinyint",
			"smallint",
			"int",
			"bigint",
			"decimal",
			"numberic",
			"smallmoney",
			"money",
			"float",
			"real"
		};
	}
}