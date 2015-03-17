using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterProjectConnect4
{
	class Speelveld
	{
		#region state
		private int speelVeldMarginLeft = 10;
		private int speelVeldMarginRight = 40;
		private int variabelAantalKolommen;
		private int variabelAantalRijen;
		private int lineLenghtKolommen;
		private int lineLenghtRijen;
		#endregion state

		#region properties
		private int SpeelVeldMarginLeft
		{
			get
			{
				return speelVeldMarginLeft;
			}
		}
		private int SpeelVeldMarginRight
		{
			get
			{
				return speelVeldMarginRight;
			}
		}
		private int VariabelAantalKolommen
		{
			get
			{
				return variabelAantalKolommen;
			}
			set
			{
				variabelAantalKolommen = value;
			}
		}
		private int VariabelAantalRijen
		{
			get
			{
				return variabelAantalRijen;
			}
			set
			{
				variabelAantalRijen = value;
			}
		}
		private int LineLenghtKolommen
		{
			get
			{
				return lineLenghtKolommen;
			}
			set
			{
				lineLenghtKolommen = value;
			}
		}
		private int LineLenghtRijen
		{
			get
			{
				return lineLenghtRijen;
			}
			set
			{
				lineLenghtRijen = value;
			}
		}
		#endregion properties

		#region constructors

		public Speelveld(Graphics graphics, int rijen, int kolommen)
		{

			VariabelAantalKolommen = rijen;
			VariabelAantalRijen = kolommen;
			LineLenghtKolommen = VariabelAantalRijen * 75;
			LineLenghtRijen = VariabelAantalKolommen * 75;

			graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 255)),
				SpeelVeldMarginLeft,
				SpeelVeldMarginRight,
				LineLenghtRijen,
				LineLenghtKolommen);

			for (int rij = 0; rij <= variabelAantalRijen; rij++)
			{
				Pen horLinePen = new Pen(Color.White, 3);
				int horLineLocation = SpeelVeldMarginRight + rij * 75;
				graphics.DrawLine(
					horLinePen,
					new Point(SpeelVeldMarginLeft, horLineLocation),
					new Point(SpeelVeldMarginLeft + LineLenghtRijen, horLineLocation));

				for (int kolom = 0; kolom <= variabelAantalKolommen; kolom++)
				{
					Pen verLinePen = new Pen(Color.White, 3);
					int verLineLocation = SpeelVeldMarginLeft + 75 * kolom;
					graphics.DrawLine(
					  verLinePen,
					  new Point(verLineLocation, SpeelVeldMarginRight),
					  new Point(verLineLocation, SpeelVeldMarginRight + LineLenghtKolommen));
				}
			}
		}
		#endregion constructors
	}
}