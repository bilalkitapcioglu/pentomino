using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


namespace PentominosSharp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmPentominos : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		public int iCols;
		public int iRows;


		cPiece[]	piece = new cPiece[12];
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MainMenu PentominosMenu;
		private System.Windows.Forms.MenuItem mnuNew;
		private System.Windows.Forms.MenuItem mnuBoardType;
		private System.Windows.Forms.MenuItem mnu6x10;
		private System.Windows.Forms.MenuItem mnu4x15;
		private System.Windows.Forms.MenuItem mnu5x12;
		private System.Windows.Forms.MenuItem mnu3x20;
		public System.Windows.Forms.StatusBar stBar;
		private System.Windows.Forms.Timer TimerElapsed;
		private cPiece draggedpiece;

		public frmPentominos()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			draggedpiece = null;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			dtStart = new DateTime();

			iCols = 10;
			iRows = 6;

			InitForm();


		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.PentominosMenu = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuNew = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.mnuBoardType = new System.Windows.Forms.MenuItem();
			this.mnu6x10 = new System.Windows.Forms.MenuItem();
			this.mnu5x12 = new System.Windows.Forms.MenuItem();
			this.mnu4x15 = new System.Windows.Forms.MenuItem();
			this.mnu3x20 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.stBar = new System.Windows.Forms.StatusBar();
			this.TimerElapsed = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// PentominosMenu
			// 
			this.PentominosMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuItem1,
																						   this.menuItem2});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuNew,
																					  this.menuItem4,
																					  this.mnuBoardType});
			this.menuItem1.Text = "Game";
			// 
			// mnuNew
			// 
			this.mnuNew.Index = 0;
			this.mnuNew.Text = "New...";
			this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "-";
			// 
			// mnuBoardType
			// 
			this.mnuBoardType.Index = 2;
			this.mnuBoardType.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.mnu6x10,
																						 this.mnu5x12,
																						 this.mnu4x15,
																						 this.mnu3x20});
			this.mnuBoardType.Text = "Board Type";
			// 
			// mnu6x10
			// 
			this.mnu6x10.Index = 0;
			this.mnu6x10.Text = "6x10 (2339 possible solutions)";
			this.mnu6x10.Click += new System.EventHandler(this.mnu6x10_Click);
			// 
			// mnu5x12
			// 
			this.mnu5x12.Index = 1;
			this.mnu5x12.Text = "5x12  (1010 possible solutions)";
			this.mnu5x12.Click += new System.EventHandler(this.mnu5x12_Click);
			// 
			// mnu4x15
			// 
			this.mnu4x15.Index = 2;
			this.mnu4x15.Text = "4x15 (368 possible solutions)";
			this.mnu4x15.Click += new System.EventHandler(this.mnu4x15_Click);
			// 
			// mnu3x20
			// 
			this.mnu3x20.Index = 3;
			this.mnu3x20.Text = "3x20 (2 possible solutions)";
			this.mnu3x20.Click += new System.EventHandler(this.mnu3x20_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "About";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// stBar
			// 
			this.stBar.Location = new System.Drawing.Point(0, 387);
			this.stBar.Name = "stBar";
			this.stBar.ShowPanels = true;
			this.stBar.Size = new System.Drawing.Size(512, 22);
			this.stBar.SizingGrip = false;
			this.stBar.TabIndex = 0;
			// 
			// TimerElapsed
			// 
			this.TimerElapsed.Enabled = true;
			this.TimerElapsed.Interval = 1000;
			this.TimerElapsed.Tick += new System.EventHandler(this.TimerElapsed_Tick);
			// 
			// frmPentominos
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 409);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.stBar});
			this.Menu = this.PentominosMenu;
			this.Name = "frmPentominos";
			this.Text = "Pentominos";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPentominos_MouseDown);
			this.Load += new System.EventHandler(this.frmPentominos_Load);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPentominos_MouseMove);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmPentominos());
		}

		private void frmPentominos_Load(object sender, System.EventArgs e)
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.Opaque, true); 
		}

		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			


			Graphics		grPaint = e.Graphics;

			grPaint.Flush(System.Drawing.Drawing2D.FlushIntention.Sync);

			SolidBrush		brushWhite = new SolidBrush(Color.White);
			Pen				blackpen = new Pen(Color.Black,2);

			// Clear the screen
			grPaint.FillRectangle(brushWhite, e.ClipRectangle);

			// Draw the grid
			grPaint.DrawString("Left-Click on a piece do drag or drop it", new Font("Arial",12), new SolidBrush(Color.Black),20,10);
			grPaint.DrawString("Right-Click to rotate and flip it (some pieces doesn?t flip)", new Font("Arial",12), new SolidBrush(Color.Black),20,30);

			for(int i=0;i<iCols;i++)
			{
				for(int j=0;j<iRows;j++)
				{
					grPaint.DrawRectangle(blackpen, 100 + (i*20), 60 + (j*20),20,20);
				}
			}
			
			for(int i=0;i<12;i++)
			{
				piece[i].Draw(grPaint);
			}
			brushWhite.Dispose();
			blackpen.Dispose();

		}

		protected override void OnDoubleClick(System.EventArgs e)
		{
		
		}

		private void frmPentominos_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right && draggedpiece != null)
			{
				draggedpiece.RotatePiece();
				Invalidate(new Rectangle(draggedpiece.GetX()-2,draggedpiece.GetY()-2, 120,120)   );
			}
			
			if(e.Button == MouseButtons.Left && draggedpiece != null)
			{
				if(draggedpiece != null)
				{
					draggedpiece = null;

					int iCount = 0;

					// Check if the user has finished the game
					
					for(int iPosX=100;iPosX<100+(iCols * 20);iPosX+=20)
					{
						for(int iPosY=60;iPosY<60+(iRows * 20);iPosY+=20)
						{
							for(int i=0;i<12;i++)
							{
								if(piece[i].Hitted(iPosX, iPosY))
								{
									iCount++;
									break;
								}
							}
						}
					}

					if(iCount >= 60)
					{
						MessageBox.Show("Congratulations ! You?ve finished !", "Pentominos", MessageBoxButtons.OK, MessageBoxIcon.Information);
						TimerElapsed.Enabled = false;
					}
					return;
				}	
			}

			if(e.Button == MouseButtons.Left && draggedpiece == null)
			{


				int iPosX = e.X / 20;
				int iPosY = e.Y / 20;

				iPosX *= 20;
				iPosY *= 20;

				for(int i=0;i<12;i++)
				{
					if(piece[i].Hitted(iPosX, iPosY))
					{
						draggedpiece = piece[i];
						break;
					}
				}
			}		
		}

		private void frmPentominos_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(draggedpiece != null)
			{



				Cursor.Current  = curHandPick;
				int iPosX = e.X / 20;
				int iPosY = e.Y / 20;

				iPosX *= 20;
				iPosY *= 20;

				if(iPosX != draggedpiece.GetX() || iPosY != draggedpiece.GetY())
				{
					Rectangle	rect = new Rectangle(draggedpiece.GetX()-2, draggedpiece.GetY()-2, draggedpiece.GetWidth()+4,draggedpiece.GetHeight()+4);
					draggedpiece.SetPos(iPosX, iPosY);
					Region	rgn = new Region(rect);
					rect = new Rectangle(iPosX-2,iPosY-2, draggedpiece.GetWidth()+4,draggedpiece.GetHeight()+4);
					rgn.Union(rect);
					Invalidate(rgn, false);
				}
				
				
			}		
			else
			{
				int iPosX = e.X / 20;
				int iPosY = e.Y / 20;

				iPosX *= 20;
				iPosY *= 20;

				for(int i=0;i<12;i++)
				{
					if(piece[i].Hitted(iPosX, iPosY))
					{

						Cursor.Current  = curHand;
						break;
					}
				}
			}
		}

		public void InitForm()
		{
			System.Reflection.Assembly asm = GetType().Assembly;
			System.IO.Stream stm = asm.GetManifestResourceStream("PentominosSharp.Hand.cur");
			curHand = new Cursor(stm);			
			
			stm = asm.GetManifestResourceStream("PentominosSharp.Handpc.cur");
			curHandPick = new Cursor(stm);


			stBar.Panels.Clear();

			StatusBarPanel	pane1 = new StatusBarPanel();
			StatusBarPanel	pane2 = new StatusBarPanel();

			pane1.AutoSize = StatusBarPanelAutoSize.Spring;
			pane1.Text = "6x10 board - 2339 possible solutions";
			pane2.Width = 120;
			pane2.Text = "Elapse Time: 00:00:00";

			stBar.Panels.Add(pane1);
			stBar.Panels.Add(pane2);

			for(int i=0;i<12;i++)
			{
				piece[i] = new cPiece();
				piece[i].CreatePiece(i+1);
				piece[i].SetPos(20 + ( (i%6) *80), i>=6 ? 280 : 200);
			}		

			dtStart = DateTime.Now;
			TimerElapsed.Enabled = true;
		}

		private void mnu6x10_Click(object sender, System.EventArgs e)
		{
			iCols = 10;
			iRows = 6;
			InitForm();
			Invalidate(false);
		}

		private void mnu5x12_Click(object sender, System.EventArgs e)
		{
			iCols = 12;
			iRows = 5;
			InitForm();
			Invalidate(false);		
		}

		private void mnu4x15_Click(object sender, System.EventArgs e)
		{
			iCols = 15;
			iRows = 4;
			InitForm();
			Invalidate(false);		
		}

		private void mnu3x20_Click(object sender, System.EventArgs e)
		{
			iCols = 20;
			iRows = 3;
			InitForm();
			Invalidate(false);		
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			frmAbout oForm = new frmAbout();

			oForm.ShowDialog();
		}

		private void TimerElapsed_Tick(object sender, System.EventArgs e)
		{
            TimeSpan tmElapsed = new TimeSpan();
			
			tmElapsed = DateTime.Now - dtStart;
			String	sTime = String.Format("Elapse Time: {0:00}:{1:00}:{2:00}", tmElapsed.TotalHours, tmElapsed.Minutes, tmElapsed.Seconds);
            
			stBar.Panels[1].Text = sTime;

		}

		public DateTime dtStart;

		private void mnuNew_Click(object sender, System.EventArgs e)
		{
			InitForm();
			Invalidate(false);	
		}

		private Cursor curHand;
		private Cursor curHandPick;
		

	}
}
