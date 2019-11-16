using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.FallenOrder.Data;
using LiveSplit.FallenOrder.Memory;
using LiveSplit.FallenOrder.UI;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;

namespace LiveSplit.FallenOrder
{
	public class JediComponent : IComponent
	{
		internal static string Name => "Star Wars Jedi: Fallen Order Autosplitter";

		private TimerModel timer;
		private JediMemory memory;
		private JediSettings settings;
		private JediMasterControl control;
		private SplitCollection splitCollection;

		public JediComponent()
		{
			memory = new JediMemory();
			settings = new JediSettings();
			control = new JediMasterControl();
			splitCollection = new SplitCollection();
		}

		public string ComponentName => Name;

		public float HorizontalWidth => 0;
		public float MinimumHeight => 0;
		public float VerticalHeight => 0;
		public float MinimumWidth => 0;
		public float PaddingTop => 0;
		public float PaddingBottom => 0;
		public float PaddingLeft => 0;
		public float PaddingRight => 0;

		public IDictionary<string, Action> ContextMenuControls => null;

		public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
		{
		}

		public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
		{
		}

		public Control GetSettingsControl(LayoutMode mode)
		{
			return control;
		}

		public XmlNode GetSettings(XmlDocument document)
		{
			return null;
		}

		public void SetSettings(XmlNode settings)
		{
		}

		public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
		{
			if (timer == null)
			{
				timer = new TimerModel();
				timer.CurrentState = state;

				state.OnStart += (sender, args) => { splitCollection.OnStart(); };
				state.OnSplit += (sender, args) => { splitCollection.OnSplit(); };
				state.OnUndoSplit += (sender, args) => { splitCollection.OnUndoSplit(); };
				state.OnSkipSplit += (sender, args) => { splitCollection.OnSkipSplit(); };
				state.OnReset += (sender, value) => { splitCollection.OnReset(); };
			}

			Refresh(state.CurrentPhase);
		}

		private bool Hook()
		{
			bool previouslyHooked = memory.IsHooked;

			// TODO: Handle any necessary on-hook behavior.
			if (memory.Hook() && !previouslyHooked)
			{
			}

			return memory.IsHooked;
		}

		public void Refresh(TimerPhase? nullablePhase = null)
		{
			if (!Hook())
			{
				return;
			}
			
			// This will only be true while testing through the console program.
			if (nullablePhase == null)
			{
				return;
			}

			var phase = nullablePhase.Value;

			// If the timer has already ended, there's nothing else to do.
			if (phase == TimerPhase.Ended)
			{
				return;
			}

			// TODO: Finish autostart logic.
			if (phase == TimerPhase.NotRunning && settings.IsAutostartEnabled)
			{
				return;
			}
		}

		public void Dispose()
		{
		}
	}
}
