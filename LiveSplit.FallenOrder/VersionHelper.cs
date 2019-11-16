using System;
using System.Reflection;

namespace LiveSplit.FallenOrder
{
	public static class VersionHelper
	{
		public static Version GetVersion()
		{
			Version version = Assembly.GetExecutingAssembly().GetName().Version;

			return Version.Parse($"{version.Major}.{version.Minor}.{version.Build}");
		}
	}
}
