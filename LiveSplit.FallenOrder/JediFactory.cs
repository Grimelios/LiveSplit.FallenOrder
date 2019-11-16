using System;
using LiveSplit.Model;
using LiveSplit.UI.Components;

namespace LiveSplit.FallenOrder
{
	public class JediFactory : IComponentFactory
	{
		public string ComponentName => JediComponent.Name;
		public string Description => $"Configurable autosplitter for {ComponentName}.";
		public string UpdateName => ComponentName;
		public string UpdateURL => "https://raw.githubusercontent.com/Grimelios/LiveSplit.FallenOrder/master/";
		public string XMLURL => UpdateURL + "Components/Updates.xml";

		public Version Version => VersionHelper.GetVersion();
	
		public ComponentCategory Category => ComponentCategory.Control;

		public IComponent Create(LiveSplitState state)
		{
			return new JediComponent();
		}
	}
}
