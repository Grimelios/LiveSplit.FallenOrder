namespace LiveSplit.FallenOrder.UI
{
	partial class JediSplitControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitTypeDropdown = new LiveSplit.FallenOrder.UI.JediDropdown();
			this.SuspendLayout();
			// 
			// splitTypeDropdown
			// 
			this.splitTypeDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.splitTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.splitTypeDropdown.FormattingEnabled = true;
			this.splitTypeDropdown.Location = new System.Drawing.Point(3, 3);
			this.splitTypeDropdown.Name = "splitTypeDropdown";
			this.splitTypeDropdown.Prompt = null;
			this.splitTypeDropdown.Size = new System.Drawing.Size(88, 21);
			this.splitTypeDropdown.TabIndex = 5;
			// 
			// JediSplitControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitTypeDropdown);
			this.Name = "JediSplitControl";
			this.Size = new System.Drawing.Size(532, 152);
			this.ResumeLayout(false);

		}

		#endregion

		private JediDropdown splitTypeDropdown;
	}
}
