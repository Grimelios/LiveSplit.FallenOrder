namespace LiveSplit.FallenOrder.UI
{
	partial class JediMasterControl
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
			this.jediSplitCollectionControl1 = new LiveSplit.FallenOrder.UI.JediSplitCollectionControl();
			this.jediSettingsControl1 = new LiveSplit.FallenOrder.UI.JediSettingsControl();
			this.SuspendLayout();
			// 
			// jediSplitCollectionControl1
			// 
			this.jediSplitCollectionControl1.Location = new System.Drawing.Point(4, 72);
			this.jediSplitCollectionControl1.Name = "jediSplitCollectionControl1";
			this.jediSplitCollectionControl1.Size = new System.Drawing.Size(431, 251);
			this.jediSplitCollectionControl1.TabIndex = 0;
			// 
			// jediSettingsControl1
			// 
			this.jediSettingsControl1.Location = new System.Drawing.Point(4, 4);
			this.jediSettingsControl1.Name = "jediSettingsControl1";
			this.jediSettingsControl1.Size = new System.Drawing.Size(299, 62);
			this.jediSettingsControl1.TabIndex = 1;
			// 
			// JediMasterControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.jediSettingsControl1);
			this.Controls.Add(this.jediSplitCollectionControl1);
			this.Name = "JediMasterControl";
			this.Size = new System.Drawing.Size(518, 388);
			this.ResumeLayout(false);

		}

		#endregion

		private JediSplitCollectionControl jediSplitCollectionControl1;
		private JediSettingsControl jediSettingsControl1;
	}
}
