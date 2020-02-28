using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class FmMain : Form
    {
        const int nRows = 4;
        const int nCols = 4;
        Size sizeTile;
        TileControl[,] tileControls = new TileControl[nRows,nCols];
        Random random = new Random();
        Point ptBlank;
        int iTimerCountDown;

        public FmMain()
        {

            InitializeComponent();
            this.Text = "PuzzleGame";
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Graphics graphics = CreateGraphics();
            sizeTile = new Size((int)(2 * graphics.DpiX / 3), (int)(2 * graphics.DpiY / 3));
            ClientSize = new Size(nRows * sizeTile.Width, nCols * sizeTile.Height);
            graphics.Dispose();

            for (int iRow = 0; iRow < nRows; iRow++)
            {
                for (int iCol = 0; iCol < nCols; iCol++)
                {
                    int iNum = iRow * nCols + iCol + 1;
                    if (iNum==nCols*nRows)
                    {
                        continue;
                    }
                    TileControl tileControl = new TileControl(iNum);
                    tileControl.Parent = this;
                    tileControl.Location = new Point(iCol * sizeTile.Width, iRow * sizeTile.Height);
                    tileControl.Size = sizeTile;
                    tileControls[iRow, iCol] = tileControl;
                }


            }
            ptBlank = new Point(nCols - 1, nRows - 1);
            Randomise();
        }
        protected void Randomise()
        {
            Random random = new Random();
            iTimerCountDown = 32 * nCols * nRows;
            Timer timer = new Timer();
            timer.Tick += new EventHandler(TimerOnTick);
            timer.Interval = 1;
            timer.Enabled = true;
        }

        private void TimerOnTick(object sender,EventArgs eventArgs)
        {
            int x = ptBlank.X;
            int y = ptBlank.Y;

            switch (random.Next(4))
            {
                case 0:x++;break;
                    case 1:x--;break;
                case 2:y++;break;
                    case 3:y--;break;

                default:
                    break;
            }
            if (x>=0&&x<nCols&&y>=0&&y<nRows)
            {
                MoveTile(x, y);
            }
            if (--iTimerCountDown==0)
            {
                ((Timer)sender).Stop();
                ((Timer)sender).Tick -= new EventHandler(TimerOnTick);
            }
        }

        //protected override void OnMouseClick(MouseEventArgs e)
        //{
        //    base.OnMouseClick(e);

        //}
        protected override void OnMouseDown(MouseEventArgs e)
        {
            //base.OnMouseDown(e);
            int x = e.X / sizeTile.Width;
            int y = e.Y / sizeTile.Height;
            if (x==ptBlank.X)
            {
                if (y<ptBlank.Y)
                {
                    for (int y2= ptBlank.Y-1; y2 >=y; y2--)
                    {
                        MoveTile(x, y2);
                    }

                }
                else if (y>ptBlank.Y)
                {
                    for (int y2 =ptBlank.Y+1; y2 <= y; y2++)
                    {
                        MoveTile(x, y2);
                    }
                }
            }
            else if (y==ptBlank.Y)
                {
                    if (x<ptBlank.X)
                    {
                        for (int x2 = ptBlank.X-1; x2 >=x; x2--)
                        {
                            MoveTile(x2, y);
                        }
                    }
                    else if (x>ptBlank.X)
                    {
                        for (int x2 = ptBlank.X+1; x2 <=x; x2++)
                        {
                            MoveTile(x2, y);
                        }
                    }
              
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode==Keys.Left&&ptBlank.X<nCols-1)
            {
                MoveTile(ptBlank.X + 1, ptBlank.Y);
            }
            else if(e.KeyCode==Keys.Right&&ptBlank.X>0)
            {
                MoveTile(ptBlank.X - 1, ptBlank.Y);
            }
            else if (e.KeyCode==Keys.Up&&ptBlank.Y<nRows-1)
            {
                MoveTile(ptBlank.X, ptBlank.Y + 1);
            }
            else if (e.KeyCode==Keys.Down&&ptBlank.Y>0)
            {
                MoveTile(ptBlank.X, ptBlank.Y - 1);
            }
            e.Handled = true;
            
        }
        void MoveTile(int x,int y)
        {
            tileControls[y, x].Location = new Point(ptBlank.X * sizeTile.Width, ptBlank.Y * sizeTile.Height);
            tileControls[ptBlank.Y, ptBlank.X] = tileControls[y, x];
            tileControls[y, x] = null;
            ptBlank = new Point(x, y);
        }
    }
}
