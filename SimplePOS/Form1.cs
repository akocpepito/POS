using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePOS
{
    public partial class frmMain : Form
    {
        public class MyColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.Gray;
                }
            }

            public override Color MenuStripGradientBegin
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.Gray;
                }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.Gray;
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }
        }  // Don't mind me
        
        public frmMain()
        {
            InitializeComponent();
            mainMenuStrip.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mainMenuStrip.BackColor = Color.FromArgb(64, 64, 64);
            mainMenuStrip.ForeColor = Color.White;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserView f = new frmUserView();
            f.Show();
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPosition fp = new frmPosition();
            fp.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemView f = new frmItemView();
            f.Show();
        }
    }
}
