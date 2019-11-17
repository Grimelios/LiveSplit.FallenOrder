﻿using System.Drawing;
using System.Windows.Forms;

namespace LiveSplit.FallenOrder.UI
{
	public class JediLabel : Label
	{
		public JediLabel()
		{
			AutoSize = false;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			const int TextPadding = 2;

			var bounds = e.ClipRectangle;
			var midWidth = bounds.Width / 2;
			var midHeight = bounds.Height / 2;
			var halfWidth = e.Graphics.MeasureString(Text, Font).Width / 2;
			var topLeft = new PointF(0, midHeight);
			var topRight = new PointF(bounds.Right - 1, midHeight);
			var bottomLeft = new PointF(0, bounds.Bottom);
			var bottomRight = new PointF(bounds.Right - 1, bounds.Bottom);
			var textLeft = new PointF(midWidth - halfWidth - TextPadding, midHeight);
			var textRight = new PointF(midWidth + halfWidth + TextPadding, midHeight);
			var textPosition = new PointF(midWidth - halfWidth, 0);

			Pen pen = SystemPens.ButtonShadow;

			e.Graphics.DrawLine(pen, topLeft, bottomLeft);
			e.Graphics.DrawLine(pen, topLeft, textLeft);
			e.Graphics.DrawLine(pen, topRight, textRight);
			e.Graphics.DrawLine(pen, topRight, bottomRight);
			e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), textPosition);
		}
	}
}
