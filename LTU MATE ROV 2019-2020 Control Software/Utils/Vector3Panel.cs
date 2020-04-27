using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public class Vector3Panel : GroupBox {

		private Vector3 vector;
		public Vector3 Vector {
			get => vector;
			set {
				vector = value;
				Invalidate();
			}
		}
		public float X {
			get => Vector.X;
			set {
				vector.X = value;
				Invalidate();
			}
		}
		public float Y {
			get => Vector.Y;
			set {
				vector.Y = value;
				Invalidate();
			}
		}
		public float Z {
			get => Vector.Z;
			set {
				vector.Z = value;
				Invalidate();
			}
		}

		public override Size MinimumSize {
			get => new Size(100, 60);
			set {
				value.Width = 100;
				value.Height = 60;
				base.MinimumSize = value;
			}
		}

		public override Size MaximumSize {
			get => new Size(100, 60);
			set {
				value.Width = 100;
				value.Height = 60;
				base.MaximumSize = value;
			}
		}

		public Vector3Panel() : base() {
			Text = "Vector3";
		}

		protected override void OnPaint(PaintEventArgs e) {
			Brush brush = new SolidBrush(base.ForeColor);
			float height = e.Graphics.MeasureString(base.Text, base.Font).Height;
			float heightX = e.Graphics.MeasureString("X:", base.Font).Height;
			float heightY = e.Graphics.MeasureString("Y:", base.Font).Height;
			e.Graphics.DrawString("X:", base.Font, brush, new PointF(4, height));
			e.Graphics.DrawString("Y:", base.Font, brush, new PointF(4, height + heightX));
			e.Graphics.DrawString("Z:", base.Font, brush, new PointF(4, height + heightX + heightY));

			string strX = getString(X);
			string strY = getString(Y);
			string strZ = getString(Z);
			float widthX = e.Graphics.MeasureString(strX, base.Font).Width;
			float widthY = e.Graphics.MeasureString(strY, base.Font).Width;
			float widthZ = e.Graphics.MeasureString(strZ, base.Font).Width;
			
			e.Graphics.DrawString(strX, base.Font, brush, new PointF(100 - widthX, height));
			e.Graphics.DrawString(strY, base.Font, brush, new PointF(100 - widthY, height + heightX));
			e.Graphics.DrawString(strZ, base.Font, brush, new PointF(100 - widthZ, height + heightX + heightY));
			base.OnPaint(e);
		}

		private string getString(float value) {
			char negative = ' ';
			if(value < 0f) {
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
