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
    public partial class RectanglesControl : UserControl
    {
        Rectangle _curretRentagles = new Rectangle();
        Rectangle[] _Rectangles = new Rectangle[5];
        Random rnd = new Random();

        public RectanglesControl()
        {
            InitializeComponent();


        }



        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _curretRentagles = _Rectangles[RectanglesLB.SelectedIndex];

            LenghtTextBox.Text = _curretRentagles.Height.ToString();
            WidthTextBox.Text = _curretRentagles.Width.ToString();
            ColorTextBox.Text = _curretRentagles.Color;
            CenterXTextBox.Text = _curretRentagles.Center.X.ToString();
            CenterYTextBox.Text = _curretRentagles.Center.Y.ToString();
            IDTextBox.Text = _curretRentagles.id.ToString();

        }

        private void LenghtTB_TextChanged(object sender, EventArgs e)
        {

            try
            {
                _curretRentagles.Height = Convert.ToInt32(LenghtTextBox.Text);
                LenghtTextBox.BackColor = Color.White;
            }
            catch
            {
                LenghtTextBox.BackColor = Color.LightPink;
            }
        }

        private void WidhtTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Width = Convert.ToInt32(WidthTextBox.Text);
                WidthTextBox.BackColor = Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = Color.LightPink;
            }
        }

        private void ColorTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Color = ColorTextBox.Text;
                ColorTextBox.BackColor = Color.White;
            }
            catch
            {
                ColorTextBox.BackColor = Color.LightPink;
            }
        }

        private int FindRectangleWithMaxWidth(Rectangle[] array)
        {
            double maxWidth = array[0].Width;
            int maxWideIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Width > maxWidth)
                {
                    maxWidth = array[i].Width;
                    maxWideIndex = i;
                }
            }
            return maxWideIndex;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesLB.SelectedIndex = FindRectangleWithMaxWidth(_Rectangles);
        }

        private void RectanglesControl_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < _Rectangles.Length; i++)
            {
                _Rectangles[i] = new Rectangle(rnd.Next(1, 10), rnd.Next(1, 10), "Red", rnd.Next(1, 10), rnd.Next(1, 10));
            }

            RectanglesLB.SelectedIndex = 0;
        }
    }
}
