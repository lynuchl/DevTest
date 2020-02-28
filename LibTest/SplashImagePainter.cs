using DevExpress.Utils.Drawing;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTest
{
    class SplashImagePainter : ICustomImagePainter
    {

        public SplashImagePainter Painter { private set; get; }

        public ViewInfo ViewInfo { get; private set; }

        public void Draw(GraphicsCache cache, Rectangle bounds)
        {
            throw new NotImplementedException();
        }
    }

    class ViewInfo
    {
        public string Title{ get; set; }
        public string Stage { get; set; }
        public ViewInfo()
        {
            this.Title = "";
            this.Stage = "";
        }
    }
}
