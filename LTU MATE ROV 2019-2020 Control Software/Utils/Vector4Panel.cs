using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public class Vector4Panel : GroupBox {

		protected override bool DoubleBuffered {
			get => true;
			set => base.DoubleBuffered = true;
		}

		private Vector4 vector;
		public Vector4 Vector {
			get => vector;
			set {
				if (value != vector) Invalidate();
				vector = value;
			}
		}
		public float X {
			get => Vector.X;
			set {
				if (value != vector.X) Invalidate();
				vector.X = value;
			}
		}
		public float Y {
			get => Vector.Y;
			set {
				if (value != vector.Y) Invalidate();
				vector.Y = value;
			}
		}
		public float Z {
			get => Vector.Z;
			set {
				if (value != vector.Z) Invalidate();
				vector.Z = value;
			}
		}
		public float W {
			get => Vector.W;
			set {
				if (value != vector.W) Invalidate();
				vector.W = value;
			}
		}

		public override Size MinimumSize {
			get => new Size(100, 74);
			set {
				value.Width = 100;
				value.Height = 74;
				base.MinimumSize = value;
			}
		}

		public override Size MaximumSize {
			get => new Size(100, 74);
			set {
				value.Width = 100;
				value.Height = 74;
				base.MaximumSize = value;
			}
		}

		public Vector4Panel() : base() {
			Text = "Vector4";
		}

		protected override void OnPaint(PaintEventArgs e) {
			Brush brush = new SolidBrush(base.ForeColor);
			float height = e.Graphics.MeasureString(base.Text, base.Font).Height;
			float heightX = e.Graphics.MeasureString("X:", base.Font).Height;
			float heightY = e.Graphics.MeasureString("Y:", base.Font).Height;
			float heightZ = e.Graphics.MeasureString("Z:", base.Font).Height;
			e.Graphics.DrawString("X:", base.Font, brush, new PointF(4, height));
			e.Graphics.DrawString("Y:", base.Font, brush, new PointF(4, height + heightX));
			e.Graphics.DrawString("Z:", base.Font, brush, new PointF(4, height + heightX + heightY));
			e.Graphics.DrawString("W:", base.Font, brush, new PointF(4, height + heightX + heightY + heightZ));

			string strX = getString(X);
			string strY = getString(Y);
			string strZ = getString(Z);
			string strW = getString(W);
			float widthX = e.Graphics.MeasureString(strX, base.Font).Width;
			float widthY = e.Graphics.MeasureString(strY, base.Font).Width;
			float widthZ = e.Graphics.MeasureString(strZ, base.Font).Width;
			float widthW = e.Graphics.MeasureString(strW, base.Font).Width;

			e.Graphics.DrawString(strX, base.Font, brush, new PointF(100 - widthX, height));
			e.Graphics.DrawString(strY, base.Font, brush, new PointF(100 - widthY, height + heightX));
			e.Graphics.DrawString(strZ, base.Font, brush, new PointF(100 - widthZ, height + heightX + heightY));
			e.Graphics.DrawString(strW, base.Font, brush, new PointF(100 - widthW, height + heightX + heightY + heightZ));
			base.OnPaint(e);
		}

		private string getString(float value) {
			char negative = ' ';
			if (value < 0f) {
				negative = '-';
				value = -value;
			}

			string str = value.ToString("#,###,##0.0000");
			if (str.Length <= 14) {
				return (negative + str);//.PadLeft(15, ' ');
			} else {
				return negative + value.ToString("0.00000000e+00");
			}
		}

	}
}
