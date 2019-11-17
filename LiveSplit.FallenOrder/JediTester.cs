using System.Threading;
using LiveSplit.FallenOrder.UI;

namespace LiveSplit.FallenOrder
{
	public static class JediTester
	{
		private const int Tick = 10;
		private const bool UseForm = true;

		public static void Main(string[] args)
		{
			if (UseForm)
			{
				new JediForm().ShowDialog();

				return;
			}

			var component = new JediComponent();

			while (true)
			{
				component.Refresh();

				Thread.Sleep((int)(1000f / Tick));
			}
		}
	}
}
