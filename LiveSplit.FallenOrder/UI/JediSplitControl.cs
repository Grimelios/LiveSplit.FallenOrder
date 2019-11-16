using System;
using System.Windows.Forms;
using LiveSplit.FallenOrder.Data;

namespace LiveSplit.FallenOrder.UI
{
	public partial class JediSplitControl : UserControl
	{
		private static readonly string[] splitTypes = Enum.GetNames(typeof(SplitTypes));

		public JediSplitControl()
		{
			InitializeComponent();

			var dropdown = new JediDropdown(this);
			dropdown.Items.AddRange(splitTypes);

			Controls.Add(dropdown);
		}

		public Split ExtractSplit()
		{
			return null;
		}
	}
}
