using System;
using System.Windows.Forms;
using LiveSplit.FallenOrder.Data;

namespace LiveSplit.FallenOrder.UI
{
	public partial class JediSplitCollectionControl : UserControl
	{
		public JediSplitCollectionControl()
		{
			InitializeComponent();

			var types = Enum.GetNames(typeof(SplitTypes));
			var items = splitTypeDropdown.Items;

			items.Add("- Test -");

			// The final type is Unassigned, which isn't selectable.
			for (int i = 0; i < types.Length - 1; i++)
			{
				items.Add(types[i]);
			}


			splitTypeDropdown.Invalidate();
		}

		private void addButton_Click(object sender, System.EventArgs e)
		{
			AddSplit();
		}

		private void clearButton_Click(object sender, System.EventArgs e)
		{
			ClearSplits();
		}

		private void AddSplit()
		{
		}

		public void ClearSplits()
		{
			/*
			splitsPanel.Controls.Clear();

			unfinishedCount = 0;
			unfinishedSplitsLabel.Visible = false;

			UpdateSplitCount();
			*/
		}

		public Split[] ExtractSplits()
		{
			var controls = splitsPanel.Controls;

			if (controls.Count == 0)
			{
				return null;
			}

			var splits = new Split[controls.Count];

			for (int i = 0; i < controls.Count; i++)
			{
				splits[i] = ((JediSplitControl)controls[i]).ExtractSplit();
			}

			return splits;
		}
	}
}
