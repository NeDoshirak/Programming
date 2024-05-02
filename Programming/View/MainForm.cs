using System.Drawing;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _Rectangles = new Rectangle[5];
        private Rectangle _curretRentagles;
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private List<Panel> _rectanglePanels = new List<Panel>();
        List<Rectangle> _intersecting = new List<Rectangle>();

        private Movie[] _movies = new Movie[5];
        private Movie _curretMovie;

        Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.SelectedIndex = 0;


            var seasonsValue = Enum.GetValues(typeof(Seasons));
            object[] SeasonValues = Enum.GetValues(typeof(Seasons)).Cast<object>().ToArray();
            SeasonsComboBox.Items.AddRange(SeasonValues);


            SeasonsComboBox.SelectedIndex = 0;



        }

        private void ClassesTabPage_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < _Rectangles.Length; i++)
            {
                _Rectangles[i] = new Rectangle(rnd.Next(1, 10), rnd.Next(1, 10), "Red", rnd.Next(1, 10), rnd.Next(1, 10));
            }


            RectanglesLB.SelectedIndex = 0;

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie();
                _movies[i].Title = "�������� ������";
                _movies[i].Year = rnd.Next(1900, 2024);
                _movies[i].Rating = rnd.Next(1, 10);
            }
            MoviesListBox.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curValue = Convert.ToString(EnumsListBox.SelectedItem);
            var enumValues = Enum.GetValues(typeof(Colors));

            ValuesListBox.Items.Clear();

            switch (curValue)
            {
                case "Weekday":
                    {
                        enumValues = Enum.GetValues(typeof(Weekday));
                        break;
                    }
                case "Colors":
                    {
                        enumValues = Enum.GetValues(typeof(Colors));
                        break;
                    }
                case "Manufacturers":
                    {
                        enumValues = Enum.GetValues(typeof(Manufacturers));
                        break;
                    }
                case "Genre":
                    {
                        enumValues = Enum.GetValues(typeof(Genre));
                        break;
                    }
                case "Seasons":
                    {
                        enumValues = Enum.GetValues(typeof(Seasons));
                        break;
                    }
                case "StudyForm":
                    {
                        enumValues = Enum.GetValues(typeof(StudyForm));
                        break;
                    }
            }

            object[] temp = enumValues.Cast<object>().ToArray();
            ValuesListBox.Items.AddRange(temp);

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntEnumsIndex.Text = Convert.ToString(ValuesListBox.SelectedIndex);

        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var inputText = ParsingListBox.Text;

            if (int.TryParse(inputText, out var result))
            {
                WeekdayResultLable.Text = "�������� �������� �� �������� �������";

            }
            else
            {
                if (Enum.TryParse(typeof(Weekday), inputText, out var ParsedWeekday))
                {
                    WeekdayResultLable.Text = $"����� �������� ���� ������ ({inputText} = {Convert.ToInt64(ParsedWeekday) + 1})";

                }
                else
                {
                    WeekdayResultLable.Text = "������ ��� ������ ���� :(";

                }
            }

            WeekdayResultLable.Visible = true;

        }

        private void SeasonResulrButton_Click(object sender, EventArgs e)
        {
            var curValue = Convert.ToString(SeasonsComboBox.SelectedItem);
            switch (curValue)
            {
                case "Summer":
                    {
                        SeasonResultLable.Text = "���! ������!";
                        SeasonResultLable.Visible = true;
                        break;
                    }
                case "Autumn":
                    {
                        BackColor = Color.Orange;
                        break;
                    }
                case "Spring":
                    {
                        BackColor = Color.Green;
                        break;
                    }
                case "Winter":
                    {
                        SeasonResultLable.Text = "�����! �������!";
                        SeasonResultLable.Visible = true;
                        break;
                    }

            }
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

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _curretMovie = _movies[MoviesListBox.SelectedIndex];

            TittleTB.Text = _curretMovie.Title;
            YearTB.Text = _curretMovie.Year.ToString();
            RatingTB.Text = _curretMovie.Rating.ToString();

        }

        private void TittleTB_TextChanged(object sender, EventArgs e)
        {
            _curretMovie.Title = TittleTB.Text;
        }

        private void YearTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretMovie.Year = Convert.ToInt32(YearTB.Text);
                YearTB.BackColor = Color.White;
            }
            catch
            {
                YearTB.BackColor = Color.LightPink;
            }

        }

        private void RatingTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretMovie.Rating = Convert.ToInt32(RatingTB.Text);
                RatingTB.BackColor = Color.White;
            }
            catch
            {
                RatingTB.BackColor = Color.LightPink;
            }
        }

        private int FindMovieleWithRating(Movie[] array)
        {
            int maxRating = array[0].Rating;
            int maxRatingIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Rating > maxRating)
                {
                    maxRating = array[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void FindMovButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieleWithRating(_movies);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize();
            _rectangles.Add(rectangle);
            RectanglesListBox.Items.Add(rectangle);
            RectanglesListBox.SelectedIndex = _rectangles.Count - 1;
            Addpanel(rectangle);
            FindCollisions(rectangle);

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

        private void FindCollisions(Rectangle rect)
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                if ((rect != _rectangles[i])&&(CollisionManager.IsCollision(rect, _rectangles[i])))
                {
                    _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 0);
                    RectanglePanel.Controls[i].BackColor = Color.FromArgb(127, 255, 127, 0);
                    _rectanglePanels[_rectangles.IndexOf(rect)].BackColor = Color.FromArgb(127, 255, 127, 0);
                    RectanglePanel.Controls[_rectangles.IndexOf(rect)].BackColor = Color.FromArgb(127, 255, 127, 0);
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
            FindCollisions(rectangle);
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
