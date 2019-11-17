namespace LiveSplit.FallenOrder.UI
{
	partial class JediSplitCollectionControl
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
			this.addButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.splitsPanel = new System.Windows.Forms.Panel();
			this.splitTypeLabel = new LiveSplit.FallenOrder.UI.JediLabel();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Image = global::LiveSplit.FallenOrder.Properties.Resources.Add;
			this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addButton.Location = new System.Drawing.Point(4, 4);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(71, 24);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "Add split";
			this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Image = global::LiveSplit.FallenOrder.Properties.Resources.Delete;
			this.clearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clearButton.Location = new System.Drawing.Point(85, 4);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(82, 24);
			this.clearButton.TabIndex = 1;
			this.clearButton.Text = "Clear splits";
			this.clearButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// splitsPanel
			// 
			this.splitsPanel.Location = new System.Drawing.Point(3, 49);
			this.splitsPanel.Name = "splitsPanel";
			this.splitsPanel.Size = new System.Drawing.Size(454, 205);
			this.splitsPanel.TabIndex = 2;
			// 
			// splitTypeLabel
			// 
			this.splitTypeLabel.Location = new System.Drawing.Point(5, 33);
			this.splitTypeLabel.Name = "splitTypeLabel";
			this.splitTypeLabel.Size = new System.Drawing.Size(87, 13);
			this.splitTypeLabel.TabIndex = 3;
			this.splitTypeLabel.Text = "Split type";
			// 
			// JediSplitCollectionControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitTypeLabel);
			this.Controls.Add(this.splitsPanel);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.addButton);
			this.Name = "JediSplitCollectionControl";
			this.Size = new System.Drawing.Size(561, 288);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Panel splitsPanel;
		private JediLabel splitTypeLabel;
	}
}
