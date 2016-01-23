using System;
using System.Drawing;
namespace GoGame
{
	public class Stone
	{
		private Color color;
		public Stone(Color c)
		{
			color =c;
		}

		public void Draw( int x, int y, Board board)
		{
			Graphics g=board.Grap ;
			int w =board.Width/20;
			int x0,y0,r;
			x0= x*w-w/2;
			y0= y*w-w/2;
			r=w/2+w/2;
			
			Brush b = new SolidBrush(color);
			g.FillEllipse(b,x0,y0,r,r);
						
		}

	}
}
