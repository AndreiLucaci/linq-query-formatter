using System.Collections.Generic;
using System.Security.Policy;

namespace LinqQueryParser.Engine.Models
{
	public class EngineResult
	{
		public IEnumerable<Variable> Variables { get; set; }
		public string ParsedQuery { get; set; }
	}
}
