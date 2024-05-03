using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private Rectangle _curretRentagles;
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private List<Panel> _rectanglePanels = new List<Panel>();
        List<Rectangle> _intersecting = new List<Rectangle>();


        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize();
            _rectangles.Add(rectangle);
            RectanglesListBox.Items.Add(rectangle);
            RectanglesListBox.SelectedIndex = _rectangles.Count - 1;
            Addpanel(rectangle);
            FindCollisions();

        }

        private void DelButton_Click(object sender, EventArgs e)
        {

        }

        private void RectanglesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles = _rectangles[RectanglesListBox.SelectedIndex];

                UpdateRectangleInfo(_curretRentagles);
            }
            catch
            {
                ClearRectangleInfo();
            }
        }

        private void XTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Center.X = Convert.ToUInt16(XTB.Text);
                XTB.BackColor = Color.White;
            }
            catch
            {
                XTB.BackColor = Color.Red;
            }
        }

        private void YTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Center.Y = Convert.ToUInt16(YTB.Text);
                YTB.BackColor = Color.White;
            }
            catch
            {
                YTB.BackColor = Color.Red;
            }
        }

        private void HeightTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Height = Convert.ToInt32(HeightTB.Text);
                HeightTB.BackColor = Color.White;
            }
            catch
            {
                HeightTB.BackColor = Color.Red;
            }
        }

        private void WidthTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Width = Convert.ToInt32(WidthTB.Text);
                WidthTB.BackColor = Color.White;
            }
            catch
            {
                WidthTB.BackColor = Color.Red;
            }
        }

        private void XTB_Leave(object sender, EventArgs e)
        {
            try
            {
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = _curretRentagles;
                _rectanglePanels[RectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_curretRentagles.Center.X) - _curretRentagles.Width / 2, Convert.ToInt32(_curretRentagles.Center.Y) - _curretRentagles.Height / 2);
                RectanglePanel.Controls[RectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_curretRentagles.Center.X) - _curretRentagles.Width / 2, Convert.ToInt32(_curretRentagles.Center.Y) - _curretRentagles.Height / 2);
                FindCollisions();
            }
            catch { }
        }

        private void YTB_Leave(object sender, EventArgs e)
        {
            try
            {
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = _curretRentagles;
                _rectanglePanels[RectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_curretRentagles.Center.X) - _curretRentagles.Width / 2, Convert.ToInt32(_curretRentagles.Center.Y) - _curretRentagles.Height / 2);
                RectanglePanel.Controls[RectanglesListBox.SelectedIndex].Location = new Point(Convert.ToInt32(_curretRentagles.Center.X) - _curretRentagles.Width / 2, Convert.ToInt32(_curretRentagles.Center.Y) - _curretRentagles.Height / 2);
                FindCollisions();
            }

            catch { }
        }

        private void HeightTB_Leave(object sender, EventArgs e)
        {
            try
            {
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = _curretRentagles;
                _rectanglePanels[RectanglesListBox.SelectedIndex].Height = _curretRentagles.Height;
                RectanglePanel.Controls[RectanglesListBox.SelectedIndex].Height = _curretRentagles.Height;
                FindCollisions();
            }
            catch { }
        }

        private void WidthTB_Leave(object sender, EventArgs e)
        {
            try
            {
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = _curretRentagles;
                _rectanglePanels[RectanglesListBox.SelectedIndex].Width = _curretRentagles.Width;
                RectanglePanel.Controls[RectanglesListBox.SelectedIndex].Width = _curretRentagles.Width;
                FindCollisions();
            }
            catch { }

        }

        private void ColorClear()
        {
            WidthTB.BackColor = Color.White;
            HeightTB.BackColor = Color.White;
            XTB.BackColor = Color.White;
            YTB.BackColor = Color.White;
        }

        private void Addpanel(Rectangle rect)
        {
            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(127, 127, 255, 0);
            panel.Height = rect.Height;
            panel.Width = rect.Width;
            panel.Location = new Point(Convert.ToInt32(rect.Center.X) - rect.Width / 2, Convert.ToInt32(rect.Center.Y) - rect.Height / 2);
            _rectanglePanels.Add(panel);
            RectanglePanel.Controls.Add(panel);

        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            IDTB.Text = rectangle.id.ToString();
            XTB.Text = rectangle.Center.X.ToString();
            YTB.Text = rectangle.Center.Y.ToString();
            WidthTB.Text = rectangle.Width.ToString();
            HeightTB.Text = rectangle.Height.ToString();

        }

        private void ClearRectangleInfo()
        {
            IDTB.Clear();
            XTB.Clear();
            YTB.Clear();
            WidthTB.Clear();
            HeightTB.Clear();
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 0);
                RectanglePanel.Controls[i].BackColor = Color.FromArgb(127, 127, 255, 0);

            }
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if ((i != j) && CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 0);
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 0);
                        RectanglePanel.Controls[i].BackColor = Color.FromArgb(127, 255, 127, 0);
                        RectanglePanel.Controls[j].BackColor = Color.FromArgb(127, 255, 127, 0);
                    }
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize();
            _rectangles.Add(rectangle);
            RectanglesListBox.Items.Add(rectangle);
            RectanglesListBox.SelectedIndex = _rectangles.Count - 1;
            Addpanel(rectangle);
            FindCollisions();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void RectangleTabPage_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = RectanglesListBox.SelectedIndex;
                Rectangle rectangle = _rectangles[selectedIndex];
                _curretRentagles = _rectangles[selectedIndex];
                RectanglesListBox.Items.RemoveAt(selectedIndex);
                _rectangles.Remove(_curretRentagles);
                RectanglePanel.Controls.RemoveAt(selectedIndex);
                _rectanglePanels.RemoveAt(selectedIndex);
                FindCollisions();

            }
            catch { }
            ColorClear();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
        }
    }
}

