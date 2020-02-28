using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class KeyExamine : Form
    {

        int xEvent, xChar, xCode, xModes, xData, xShift, xCtrl, xAlt, xRight;

        public KeyExamine()
        {
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;

            xEvent = 0;

            xChar = xEvent + 5 * Font.Height;
            xCode = xChar + 5 * Font.Height;
            xModes = xCode + 8 * Font.Height;
            xData = xModes + 8 * Font.Height;
            xShift = xData + 8 * Font.Height;
            xCtrl = xShift + 5 * Font.Height;
            xAlt = xCtrl + 5 * Font.Height;
            xRight = xAlt + 5 * Font.Height;

            ClientSize = new Size(xRight, Font.Height * (iNumLines + 1));
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimizeBox = false;
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs keyEventArgs)
        {
            keyEvents[iInsertIndex].eventType = EventType.KeyDown;
            keyEvents[iInsertIndex].eventArgs = keyEventArgs;
            Onkey();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //base.OnKeyPress(e);
            keyEvents[iInsertIndex].eventType = EventType.KeyPress;
            keyEvents[iInsertIndex].eventArgs = e;
            Onkey();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            //base.OnKeyUp(e);
            keyEvents[iInsertIndex].eventType = EventType.KeyUp;
            keyEvents[iInsertIndex].eventArgs = e;
            Onkey();
        }

        private void Onkey()
        {
            if (iNumValid<iNumLines)
            {
                Graphics graphics = CreateGraphics();
                DisplayKeyInfo(graphics,iInsertIndex,iInsertIndex);
                graphics.Dispose();
            }
            else
            {
                ScrollLines();
            }

            iInsertIndex = (iInsertIndex + 1) & iNumLines;
            iNumValid = Math.Min(iNumValid + 1, iNumLines);
        }

        //protected override void 

            protected virtual void ScrollLines()
        {
            Rectangle rectangle = new Rectangle(0, Font.Height, ClientSize.Width, ClientSize.Height - Font.Height);
            Invalidate(rectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics graphics = e.Graphics;

            BoldUnderLine(graphics, "Event",xEvent,0);
            BoldUnderLine(graphics, "KeyChar",xChar,0);
            BoldUnderLine(graphics, "KeyCode",xCode,0);
            BoldUnderLine(graphics, "Modifiers",xModes,0);
            BoldUnderLine(graphics, "KeyData",xData,0);
            BoldUnderLine(graphics, "Shift",xShift,0);
            BoldUnderLine(graphics, "Control",xCtrl,0);
            BoldUnderLine(graphics, "Alt",xAlt,0);

            if (iNumValid<iNumLines)
            {
                for (int i = 0; i < iNumValid; i++)
                {
                    DisplayKeyInfo(graphics, i, i);
                }
            }
            else
            {
                for (int i = 0; i < iNumLines; i++)
                {
                    DisplayKeyInfo(graphics, i, (iInsertIndex + i) % iNumLines);
                }
            }


        }
        void BoldUnderLine(Graphics graphics,string s,int x,int y)
        {
            Brush brush = new SolidBrush(ForeColor);
            graphics.DrawString(s, Font, brush, x, y);
            graphics.DrawString(s, Font, brush, x+1, y);

            SizeF sizeF = graphics.MeasureString(s, Font);
            graphics.DrawLine(new Pen(ForeColor), x, y + sizeF.Height, x + sizeF.Width, y + sizeF.Height);

        }

        private void DisplayKeyInfo(Graphics graphics,int y, int i)
        {
            Brush brush = new SolidBrush(ForeColor);

            y = (1 + y) * Font.Height;
            graphics.DrawString(keyEvents[i].eventType.ToString(), Font, brush, xEvent, y);
            if (keyEvents[i].eventType==EventType.KeyPress)
            {
                KeyPressEventArgs keyPressEventArgs = (KeyPressEventArgs)keyEvents[i].eventArgs;
                //string str=string.Format("\202D {0}")
                graphics.DrawString(keyPressEventArgs.KeyChar.ToString(), Font, brush, xChar, y);
            }
            else
            {
                KeyEventArgs keyEventArgs = (KeyEventArgs)keyEvents[i].eventArgs;

                graphics.DrawString(keyEventArgs.KeyCode.ToString(), Font, brush, xCode, y);
                graphics.DrawString(keyEventArgs.Modifiers.ToString(), Font, brush, xModes, y);
                graphics.DrawString(keyEventArgs.KeyData.ToString(), Font, brush, xData, y);
                graphics.DrawString(keyEventArgs.Shift.ToString(), Font, brush, xShift, y);
                graphics.DrawString(keyEventArgs.Control.ToString(), Font, brush, xCtrl, y);
                graphics.DrawString(keyEventArgs.Alt.ToString(), Font, brush, xAlt, y);

            }
        }

        enum EventType{
            None,KeyDown,KeyUp,KeyPress
        }

        struct KeyEvent
        {
            public EventType eventType;

            public EventArgs eventArgs;
        }

        const int iNumLines = 25;
        int iNumValid = 0;
        int iInsertIndex = 0;

        KeyEvent[] keyEvents = new KeyEvent[iNumLines];





    }
}
