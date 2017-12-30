namespace LinqQueryParser.WinForm
{
	partial class LinqQueryParserForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.top_query_rich_text_box = new System.Windows.Forms.RichTextBox();
			this.bottom_query_rich_text_box = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.top_panel = new System.Windows.Forms.Panel();
			this.bottom_panel = new System.Windows.Forms.Panel();
			this.actions_panel = new System.Windows.Forms.Panel();
			this.button_flow_panel = new System.Windows.Forms.FlowLayoutPanel();
			this.parse_query = new System.Windows.Forms.Button();
			this.copy_top = new System.Windows.Forms.Button();
			this.copy_bottom_query = new System.Windows.Forms.Button();
			this.variables_panel = new System.Windows.Forms.Panel();
			this.variables_grid = new System.Windows.Forms.DataGridView();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			this.top_panel.SuspendLayout();
			this.bottom_panel.SuspendLayout();
			this.actions_panel.SuspendLayout();
			this.button_flow_panel.SuspendLayout();
			this.variables_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.variables_grid)).BeginInit();
			this.SuspendLayout();
			// 
			// top_query_rich_text_box
			// 
			this.top_query_rich_text_box.Dock = System.Windows.Forms.DockStyle.Top;
			this.top_query_rich_text_box.Location = new System.Drawing.Point(0, 0);
			this.top_query_rich_text_box.Name = "top_query_rich_text_box";
			this.top_query_rich_text_box.Size = new System.Drawing.Size(830, 243);
			this.top_query_rich_text_box.TabIndex = 0;
			this.top_query_rich_text_box.Text = "";
			// 
			// bottom_query_rich_text_box
			// 
			this.bottom_query_rich_text_box.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bottom_query_rich_text_box.Location = new System.Drawing.Point(0, 0);
			this.bottom_query_rich_text_box.Name = "bottom_query_rich_text_box";
			this.bottom_query_rich_text_box.Size = new System.Drawing.Size(383, 189);
			this.bottom_query_rich_text_box.TabIndex = 1;
			this.bottom_query_rich_text_box.Text = "";
			this.bottom_query_rich_text_box.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(854, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// top_panel
			// 
			this.top_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.top_panel.Controls.Add(this.bottom_panel);
			this.top_panel.Controls.Add(this.top_query_rich_text_box);
			this.top_panel.Location = new System.Drawing.Point(12, 27);
			this.top_panel.Name = "top_panel";
			this.top_panel.Size = new System.Drawing.Size(830, 432);
			this.top_panel.TabIndex = 3;
			// 
			// bottom_panel
			// 
			this.bottom_panel.Controls.Add(this.bottom_query_rich_text_box);
			this.bottom_panel.Controls.Add(this.actions_panel);
			this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bottom_panel.Location = new System.Drawing.Point(0, 243);
			this.bottom_panel.Name = "bottom_panel";
			this.bottom_panel.Size = new System.Drawing.Size(830, 189);
			this.bottom_panel.TabIndex = 2;
			// 
			// actions_panel
			// 
			this.actions_panel.Controls.Add(this.variables_panel);
			this.actions_panel.Controls.Add(this.button_flow_panel);
			this.actions_panel.Dock = System.Windows.Forms.DockStyle.Right;
			this.actions_panel.Location = new System.Drawing.Point(383, 0);
			this.actions_panel.Name = "actions_panel";
			this.actions_panel.Size = new System.Drawing.Size(447, 189);
			this.actions_panel.TabIndex = 2;
			// 
			// button_flow_panel
			// 
			this.button_flow_panel.Controls.Add(this.parse_query);
			this.button_flow_panel.Controls.Add(this.copy_top);
			this.button_flow_panel.Controls.Add(this.copy_bottom_query);
			this.button_flow_panel.Dock = System.Windows.Forms.DockStyle.Left;
			this.button_flow_panel.Location = new System.Drawing.Point(0, 0);
			this.button_flow_panel.Name = "button_flow_panel";
			this.button_flow_panel.Size = new System.Drawing.Size(111, 189);
			this.button_flow_panel.TabIndex = 0;
			// 
			// parse_query
			// 
			this.parse_query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.parse_query.AutoSize = true;
			this.parse_query.Location = new System.Drawing.Point(3, 3);
			this.parse_query.Name = "parse_query";
			this.parse_query.Size = new System.Drawing.Size(108, 32);
			this.parse_query.TabIndex = 2;
			this.parse_query.Text = "Parse Query";
			this.parse_query.UseVisualStyleBackColor = true;
			this.parse_query.Click += new System.EventHandler(this.parse_query_Click);
			// 
			// copy_top
			// 
			this.copy_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.copy_top.AutoSize = true;
			this.copy_top.Location = new System.Drawing.Point(3, 41);
			this.copy_top.Name = "copy_top";
			this.copy_top.Size = new System.Drawing.Size(108, 32);
			this.copy_top.TabIndex = 0;
			this.copy_top.Text = "Copy top query";
			this.copy_top.UseVisualStyleBackColor = true;
			this.copy_top.Click += new System.EventHandler(this.copy_top_Click);
			// 
			// copy_bottom_query
			// 
			this.copy_bottom_query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.copy_bottom_query.AutoSize = true;
			this.copy_bottom_query.Location = new System.Drawing.Point(3, 79);
			this.copy_bottom_query.Name = "copy_bottom_query";
			this.copy_bottom_query.Size = new System.Drawing.Size(108, 32);
			this.copy_bottom_query.TabIndex = 1;
			this.copy_bottom_query.Text = "Copy bottom query";
			this.copy_bottom_query.UseVisualStyleBackColor = true;
			this.copy_bottom_query.Click += new System.EventHandler(this.copy_bottom_query_Click);
			// 
			// variables_panel
			// 
			this.variables_panel.Controls.Add(this.variables_grid);
			this.variables_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.variables_panel.Location = new System.Drawing.Point(111, 0);
			this.variables_panel.Name = "variables_panel";
			this.variables_panel.Size = new System.Drawing.Size(336, 189);
			this.variables_panel.TabIndex = 1;
			// 
			// variables_grid
			// 
			this.variables_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.variables_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.TypeColumn,
            this.SizeColumn,
            this.ValueColumn});
			this.variables_grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.variables_grid.Location = new System.Drawing.Point(0, 0);
			this.variables_grid.Name = "variables_grid";
			this.variables_grid.Size = new System.Drawing.Size(336, 189);
			this.variables_grid.TabIndex = 0;
			// 
			// NameColumn
			// 
			this.NameColumn.HeaderText = "Name";
			this.NameColumn.Name = "NameColumn";
			// 
			// TypeColumn
			// 
			this.TypeColumn.HeaderText = "Type";
			this.TypeColumn.Name = "TypeColumn";
			// 
			// SizeColumn
			// 
			this.SizeColumn.HeaderText = "Size";
			this.SizeColumn.Name = "SizeColumn";
			// 
			// ValueColumn
			// 
			this.ValueColumn.HeaderText = "Value";
			this.ValueColumn.Name = "ValueColumn";
			// 
			// LinqQueryParserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 471);
			this.Controls.Add(this.top_panel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "LinqQueryParserForm";
			this.Text = "Linq Query Parser";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.top_panel.ResumeLayout(false);
			this.bottom_panel.ResumeLayout(false);
			this.actions_panel.ResumeLayout(false);
			this.button_flow_panel.ResumeLayout(false);
			this.button_flow_panel.PerformLayout();
			this.variables_panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.variables_grid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox top_query_rich_text_box;
		private System.Windows.Forms.RichTextBox bottom_query_rich_text_box;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Panel top_panel;
		private System.Windows.Forms.Panel bottom_panel;
		private System.Windows.Forms.Panel actions_panel;
		private System.Windows.Forms.FlowLayoutPanel button_flow_panel;
		private System.Windows.Forms.Button copy_top;
		private System.Windows.Forms.Button copy_bottom_query;
		private System.Windows.Forms.Button parse_query;
		private System.Windows.Forms.Panel variables_panel;
		private System.Windows.Forms.DataGridView variables_grid;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
	}
}

