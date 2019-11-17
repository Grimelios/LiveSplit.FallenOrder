using System;
using System.Drawing;
using System.Windows.Forms;

namespace LiveSplit.FallenOrder.UI
{
	public class JediDropdown : ComboBox
	{
		private const int DisabledLightness = 240;

		private static readonly Color DefaultColor = Color.White;
		private static readonly Color DisabledColor = Color.FromArgb(255, DisabledLightness, DisabledLightness, DisabledLightness);
		private static readonly Color HighlightColor = Color.DeepSkyBlue;
		private static readonly Color UnfinishedColor = Color.PaleVioletRed;

		private JediSplitControl parent;

		private int previousIndex;

		// This constructor is necessary in order to add the split type dropdown (which is added via the editor rather
		// than through code).
		public JediDropdown()
		{
		}

		public JediDropdown(JediSplitControl parent)
		{
			this.parent = parent;

			DropDownStyle = ComboBoxStyle.DropDownList;
			DrawMode = DrawMode.OwnerDrawFixed;
			previousIndex = -1;

			// When a dropdown is created, it's unfinished by default (because no value is selected).
			BackColor = UnfinishedColor;
			ForeColor = SystemColors.ControlText;
		}

		public string Prompt { get; set; }

		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			const int SeparatorPadding = 2;
			const int UnfinishedTextColor = 80;

			string value;

			var g = e.Graphics;
			var textColor = Color.Black;
			var bounds = e.Bounds;
			var offsetX = -1;
			
			if (e.Index == -1)
			{
				value = Prompt;

				// Grey text is hard to read on a red background.
				textColor = !Enabled
					? SystemColors.ButtonShadow
					: Color.FromArgb(255, UnfinishedTextColor, UnfinishedTextColor, UnfinishedTextColor);
			}
			else
			{
				value = Items[e.Index].ToString();

				if (value.Length == 0)
				{
					g.FillRectangle(new SolidBrush(Color.White), bounds);

					return;
				}

				bool isCategoryLine = value[0] == '-';

				Color fillColor;

				if ((e.State & DrawItemState.Selected) > 0)
				{
					// Category lines (starting with a dash) are filled white (same as the background color) in order
					// to emphasize that they're not selectable.
					fillColor = isCategoryLine ? Color.White : HighlightColor;
				}
				else
				{
					fillColor = Color.White;
				}

				g.FillRectangle(new SolidBrush(fillColor), bounds);

				if (isCategoryLine)
				{
					textColor = SystemColors.ButtonShadow;

					// This trims dashes from both sides.
					value = value.Substring(2, value.Length - 4);
					offsetX = (bounds.Width - (int)g.MeasureString(value, Font).Width) / 2;

					int bottom = bounds.Bottom - 1;

					g.DrawLine(SystemPens.ButtonShadow, bounds.Left + SeparatorPadding, bottom, bounds.Right -
						SeparatorPadding - 1, bottom);
				}
			}

			// See http://blog.stevex.net/rendering-text-using-the-net-framework/. The offsets help the text line up a
			// little better.
			TextRenderer.DrawText(g, value, Font, new Point(bounds.X + offsetX, bounds.Y + 1), textColor);
		}

		protected override void OnEnabledChanged(EventArgs e)
		{
			BackColor = Enabled ? UnfinishedColor : DisabledColor;

			base.OnEnabledChanged(e);
		}

		protected override void OnSelectedIndexChanged(EventArgs e)
		{
			if (SelectedIndex == previousIndex)
			{
				return;
			}

			if (SelectedIndex == -1)
			{
				previousIndex = -1;

				return;
			}

			string value = Items[SelectedIndex].ToString();

			// A dash as the first character indicates a category label rather than a selectable value.
			if (value.Length == 0 || value[0] == '-')
			{
				SelectedIndex = previousIndex;

				return;
			}

			base.OnSelectedIndexChanged(e);

			previousIndex = SelectedIndex;
			
			if (SelectedIndex >= 0)
			{
				//parent?.RefreshFinished();
				BackColor = DefaultColor;
			}
		}

		public void RefreshPrompt(string prompt, bool isEnabled = false)
		{
			Prompt = prompt;
			Enabled = isEnabled;
			SelectedIndex = -1;

			if (isEnabled)
			{
				//parent?.RefreshFinished(false);
				BackColor = UnfinishedColor;
			}

			// Clearing items also invalidates the control.
			Items.Clear();
		}
	}
}
