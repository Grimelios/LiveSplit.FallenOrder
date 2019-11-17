namespace LiveSplit.FallenOrder.UI
{
	partial class JediForm
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
			this.jediMasterControl1 = new LiveSplit.FallenOrder.UI.JediMasterControl();
			this.SuspendLayout();
			// 
			// jediMasterControl1
			// 
			this.jediMasterControl1.Location = new System.Drawing.Point(13, 13);
			this.jediMasterControl1.Name = "jediMasterControl1";
			this.jediMasterControl1.Size = new System.Drawing.Size(422, 260);
			this.jediMasterControl1.TabIndex = 0;
			// 
			// JediForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.jediMasterControl1);
			this.Name = "JediForm";
			this.Text = "JediForm";
			this.ResumeLayout(false);

		}

		#endregion

		private JediMasterControl jediMasterControl1;
	}
}