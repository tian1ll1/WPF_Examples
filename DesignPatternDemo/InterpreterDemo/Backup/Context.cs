
using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace InterpreterSample
{
	/// <summary>
	/// Context ��������˵�λ�ã�
	/// LocationX ������
	/// LocationY ������
	/// Angle ��N����ĽǶȡ�
	/// </summary>
	public class Context
	{
		public int LocationX,LocationY;
		public int Angle;
		public Graphics grap;

		//��ʼ�������˵�λ��
		public Context(int x,int y, int a,Graphics g)
		{
			LocationX=x;
			LocationY=y;
			Angle=a;
			grap =g;
		}

		public void DrawLocation()
		{
			Pen p=GetPen(Color.Blue);
			double a =FAngle(Angle);
			double x1 = LocationX + 20 * Math.Cos(a);
			double y1 = LocationY + 20 * Math.Sin(a);
			grap.DrawLine(p,LocationX,LocationY,(int)x1,(int)y1);

		}

		private Pen GetPen( Color c)
		{
			Pen p = new Pen(c);
			GraphicsPath f= new GraphicsPath();
			GraphicsPath s= new GraphicsPath();
			s.AddLine(0, 0, -10, -15);
			s.AddLine(0, 0, 10, -15);
			p.CustomEndCap = new CustomLineCap(f, s);
			p.DashStyle = DashStyle.Dash;
			return p;
		}
	
		private double FAngle(int a)
		{
			double da = (double)a;
			return da * Math.PI/180.0;
		}
	}
}
