﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProgr
{
	class Bus : Vehicle
	{
		protected readonly int busWidth = 95;
		protected readonly int busHeight = 35;

		public Bus(int Maxspeed, int Weight, Color MainColor) {
			maxSpeed = Maxspeed;
			weight = Weight;
			mainColor = MainColor;
		}

		protected Bus(int Maxspeed, int Weight, Color MainColor, int BusWidth, int BusHeight) {
			maxSpeed = Maxspeed;
			weight = Weight;
			mainColor = MainColor;
			this.busWidth = BusWidth;
			this.busHeight = BusHeight;
		}

		public override void MoveTransport(Direction direction)
		{
			float step = maxSpeed * 100 / weight;
			switch (direction)
			{
				case (Direction.Up):
					if (y_koor - busHeight - step > 0)
					{
						y_koor -= step;
					}
					break;
				case (Direction.Down):
					if (y_koor + busHeight + step < heightScreen)
					{
						y_koor += step;
					}
					break;
				case (Direction.Left):
					if (x_koor - busWidth - step > 0)
					{
						x_koor -= step;
					}
					break;
				case (Direction.Right):
					if (x_koor + busWidth + step < widthScreen)
					{
						x_koor += step;
					}
					break;
			}
		}

		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			Brush brRed = new SolidBrush(mainColor);
			Brush brBlue = new SolidBrush(Color.LightBlue);
			Brush brGrey = new SolidBrush(Color.DarkGray);

			g.FillRectangle(brRed, x_koor - 100, y_koor - 30, 200, 70);  //корпус первый этаж
			g.DrawRectangle(pen, x_koor - 100, y_koor - 30, 200, 70);

			g.FillRectangle(brGrey, x_koor, y_koor - 20, 16, 45);
			g.DrawRectangle(pen, x_koor, y_koor - 20, 16, 45);
			g.FillRectangle(brGrey, x_koor + 16, y_koor - 20, 16, 45);
			g.DrawRectangle(pen, x_koor + 16, y_koor -20, 16, 45);
			g.FillRectangle(brGrey, x_koor + 68, y_koor - 20, 16, 45);
			g.DrawRectangle(pen, x_koor + 68, y_koor - 20, 16, 45);

			g.FillRectangle(brBlue, x_koor - 60, y_koor - 20, 25, 25);  //окна первый этаж
			g.DrawRectangle(pen, x_koor - 60, y_koor - 20, 25, 25);
			g.FillRectangle(brBlue, x_koor - 30, y_koor - 20, 25, 25);
			g.DrawRectangle(pen, x_koor - 30, y_koor - 20, 25, 25);
			g.FillRectangle(brBlue, x_koor + 38, y_koor -20, 25, 25);
			g.DrawRectangle(pen, x_koor + 38, y_koor - 20, 25, 25);
			g.FillRectangle(brBlue, x_koor + 90, y_koor - 20, 10, 25);
			g.DrawRectangle(pen, x_koor + 90, y_koor - 20, 10, 25);

			g.FillEllipse(brGrey, x_koor - 60, y_koor + 20, 35, 35);   //колеса
			g.DrawEllipse(pen, x_koor - 60, y_koor + 20, 35, 35);
			g.FillEllipse(brGrey, x_koor + 35, y_koor + 20, 35, 35);
			g.DrawEllipse(pen, x_koor + 35, y_koor + 20, 35, 35);
		}
	}
}
