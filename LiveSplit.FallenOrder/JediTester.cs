using System.Threading;

namespace LiveSplit.FallenOrder
{
	public static class JediTester
	{
		private const int Tick = 10;

		public static void Main(string[] args)
		{
			var component = new JediComponent();

			while (true)
			{
				component.Refresh();

				Thread.Sleep((int)(1000f / Tick));
			}
		}
	}
}
