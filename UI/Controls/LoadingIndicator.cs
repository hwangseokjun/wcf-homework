using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Controls
{
    public class LoadingIndicator : Control
    {
        private Thread _loadingThread;
        private int _startAngle = 0;
        private int _sweepAngle = 60;
        private Color _indicatorColor = Color.FromArgb(0, 120, 215);
        private int _indicatorThickness = 4;
        private int _animationSpeed = 8;
        private BorderStyle _borderStyle = BorderStyle.None;

        public BorderStyle BorderStyle
        {
            get => _borderStyle;
            set
            {
                if (_borderStyle != value)
                {
                    _borderStyle = value;
                    UpdateStyles();
                }
            }
        }

        public LoadingIndicator()
        {
            Size = new Size(50, 50);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                switch (_borderStyle)
                {
                    case BorderStyle.FixedSingle:
                        cp.ExStyle |= 0x00000001; // WS_BORDER
                        break;

                    case BorderStyle.Fixed3D:
                        cp.ExStyle |= 0x00000200; // WS_EX_CLIENTEDGE
                        break;
                }
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen basePen = new Pen(Color.LightGray, _indicatorThickness))
            using (Pen pen = new Pen(_indicatorColor, _indicatorThickness))
            {
                g.DrawEllipse(basePen, _indicatorThickness / 2, _indicatorThickness / 2, Width - _indicatorThickness, Height - _indicatorThickness);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawArc(pen, _indicatorThickness / 2, _indicatorThickness / 2, Width - _indicatorThickness, Height - _indicatorThickness, _startAngle, _sweepAngle);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            StartLoadingIndicator();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            StopLoadingIndicator();
            base.OnHandleDestroyed(e);
        }

        private void StartLoadingIndicator()
        {
            _loadingThread = new Thread(new ThreadStart(AnimateLoadingIndicator));
            _loadingThread.Start();
        }

        private void StopLoadingIndicator()
        {
            if (_loadingThread != null && _loadingThread.IsAlive) 
            {
                _loadingThread.Abort();
            }
        }

        private void AnimateLoadingIndicator()
        {
            while (true)
            {
                _startAngle = (_startAngle + _animationSpeed) % 360;

                Invoke(new Action(() =>
                {
                    Refresh();
                }));

                Thread.Sleep(50);
            }
        }
    }
}
