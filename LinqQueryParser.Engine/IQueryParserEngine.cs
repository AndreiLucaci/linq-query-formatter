using LinqQueryParser.Engine.Models;

namespace LinqQueryParser.Engine
{
	public interface IQueryParserEngine
	{
		EngineResult ParseQuery(string query);
	}
}