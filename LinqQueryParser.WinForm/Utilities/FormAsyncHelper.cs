using System;
using System.Windows.Forms;

namespace LinqQueryParser.WinForm.Utilities
{
	public static  class FormAsyncHelper
	{
		public static void SetText(this RichTextBox owner, string text)
		{
			owner.Invoke(new Action(() =>
			{
				owner.Text = text;
			}));
		}
	}
}
