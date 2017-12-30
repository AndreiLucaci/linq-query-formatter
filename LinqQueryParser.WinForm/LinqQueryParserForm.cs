using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqQueryParser.Engine;
using LinqQueryParser.Engine.Constants;
using LinqQueryParser.WinForm.Utilities;

namespace LinqQueryParser.WinForm
{
	public partial class LinqQueryParserForm : Form
	{
		public LinqQueryParserForm()
		{
			InitializeComponent();

			top_query_rich_text_box.Text = ExampleConstants.EXAMPLE_PRECOMPILED_QUERY;
		}

		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void copy_top_Click(object sender, EventArgs e)
		{
			var query = top_query_rich_text_box.Text;

			Clipboard.SetText(query);
		}

		private void copy_bottom_query_Click(object sender, EventArgs e)
		{
			var query = bottom_query_rich_text_box.Text;

			Clipboard.SetText(query);
		}

		private void parse_query_Click(object sender, EventArgs e)
		{
			var compiledQuery = top_query_rich_text_box.Text;

			Task.Run(() =>
			{
				var engine = new QueryEngineParser();
				var engineResult = engine.ParseQuery(compiledQuery);
				bottom_query_rich_text_box.SetText(engineResult.ParsedQuery);

				Task.Run(() =>
				{
					variables_grid.Invoke(new Action(() =>
					{
						variables_grid.Rows.Clear();
						variables_grid.Rows.AddRange(
							engineResult.Variables.Select(i =>
							{
								var row = new DataGridViewRow();
								row.CreateCells(variables_grid, i.Name, i.Type, i.Size, i.Value);
								return row;
							}).ToArray());
					}));
				});

			});

		}
	}
}
