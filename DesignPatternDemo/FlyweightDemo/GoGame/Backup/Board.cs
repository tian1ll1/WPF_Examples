using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace GoGame
{
	public class Board
	{
		private int _width;

		//���������ϵ�����
		private ArrayList stones;

		public int Width
		{
			get
			{return _width;}
			set
			{_width=value;}
		}

		private Graphics g;

		public Board(Graphics g)
		{
			this.g=g;
			stones= new ArrayList();
		}

		//�������
		public void Clear()
		{
			stones.Clear();
			Draw();
		}

		public Graphics Grap
		{
			get
			{return g;}
		}

		public void AddStone(int x, int y)
		{
			int l = x*23+y;

			//�жϸ�λ���Ƿ��Ѿ�������
			foreach (int l1 in stones)
				if (l==l1) return;

			stones.Add(l);

			//������
			Stone s = StoneFactory.Instance().GetStone(stones.Count);
			s.Draw(x,y,this);
		}

		//��������¼��������
		public void AddStone(MouseEventArgs e)
		{
			int w = _width/20;
			int x = (e.X+w/2) / w;
			int y = (e.Y+w/2) / w;
			if (x<1||x>19||y<1||y>19) return;
			AddStone(x,y);
		}

		//�������̺�����
		public void Draw()
		{
			int w = _width/20;
			Brush b = new SolidBrush(Color.SandyBrown);

			g.FillRectangle(b,0,0,_width,_width);
			Pen p = new Pen(Color.Black);

			for(int i=1; i<=19;i++)
			{
				g.DrawLine(p,i*w,w,i*w,19*w);
				g.DrawLine(p,w,i*w,19*w,i*w);
				
			}

			for(int i=4;i<=16;i=i+6)
				for(int j=4;j<=16;j=j+6)
					g.DrawRectangle(p,i*w-1,j*w-1,2,2);

			DrawStones();
            
		}

		//��������
		private void DrawStones()
		{
			for(int i=0;i<stones.Count;i++)
			{
				int l= (int)stones[i];
				int x,y;
				x = Math.DivRem(l,23,out y);
				Stone s = StoneFactory.Instance().GetStone(i+1);
				s.Draw(x,y,this);
			}
		}


	}
}
