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
                XTB.BackColor = AppColors.Default;
            }
            catch
            {
                XTB.BackColor = AppColors.Invalid;
            }
        }

        private void YTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Center.Y = Convert.ToUInt16(YTB.Text);
                YTB.BackColor = AppColors.Default;
            }
            catch
            {
                YTB.BackColor = AppColors.Invalid;
            }
        }

        private void HeightTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Height = Convert.ToInt32(HeightTB.Text);
                HeightTB.BackColor = AppColors.Default;
            }
            catch
            {
                HeightTB.BackColor = AppColors.Invalid;
            }
        }

        private void WidthTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Width = Convert.ToInt32(WidthTB.Text);
                WidthTB.BackColor = AppColors.Default;
            }
            catch
            {
                WidthTB.BackColor = AppColors.Invalid;
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

        /// <summary>
        /// Очищает цвета текстовых полей.
        /// </summary>
        private void ColorClear()
        {
            WidthTB.BackColor = AppColors.Default;
            HeightTB.BackColor = AppColors.Default;
            XTB.BackColor = AppColors.Default;
            YTB.BackColor = AppColors.Default;
        }

        /// <summary>
        /// Создаёт и добавляет панель, соответствующую прямоугольнику.
        /// </summary>
        /// <param name="rect">Прямогульник, для которого нужно создать панель. <see cref="Rectangle"/></param>
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

        /// <summary>
        /// Обновляет информацию в текстовых полях по соответствующему прямоугольнику.
        /// </summary>
        /// <param name="rectangle">Прямоугольник, данные которого необходимо внести.<see cref="Rectangle"></see> </param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            IDTB.Text = rectangle.id.ToString();
            XTB.Text = rectangle.Center.X.ToString();
            YTB.Text = rectangle.Center.Y.ToString();
            WidthTB.Text = rectangle.Width.ToString();
            HeightTB.Text = rectangle.Height.ToString();

        }

        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IDTB.Clear();
            XTB.Clear();
            YTB.Clear();
            WidthTB.Clear();
            HeightTB.Clear();
        }

        /// <summary>
        /// Проверяет все прямоугольники на пересечения. При пересечении перекрашивает их в красный.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = AppColors.Success;
                RectanglePanel.Controls[i].BackColor = AppColors.Success;

            }
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if ((i != j) && CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.Danger;
                        _rectanglePanels[j].BackColor = AppColors.Danger;
                        RectanglePanel.Controls[i].BackColor = AppColors.Danger;
                        RectanglePanel.Controls[j].BackColor = AppColors.Danger;
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

