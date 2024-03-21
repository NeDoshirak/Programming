namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _Rectangles = new Rectangle[5];
        private Rectangle _curretRentagles;
        private List<Rectangle> _rentagles = new List<Rectangle>();
        private int index = 0;

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

            for (int i = 0; i < _Rectangles.Length; i++)
            {
                _Rectangles[i] = new Rectangle(rnd.Next(1, 10), rnd.Next(1, 10), "Red", rnd.Next(1, 10), rnd.Next(1, 10));
            }


            RectanglesLB.SelectedIndex = 0;

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie();
                _movies[i].Title = "Название фильма";
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
                WeekdayResultLable.Text = "Введённое значение не является текстом";

            }
            else
            {
                if (Enum.TryParse(typeof(Weekday), inputText, out var ParsedWeekday))
                {
                    WeekdayResultLable.Text = $"Текст является днём недели ({inputText} = {Convert.ToInt64(ParsedWeekday) + 1})";

                }
                else
                {
                    WeekdayResultLable.Text = "Такого дня недели нету :(";

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
                        SeasonResultLable.Text = "Ура! Солнце!";
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
                        SeasonResultLable.Text = "Брррр! Холодно!";
                        SeasonResultLable.Visible = true;
                        break;
                    }

            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _curretRentagles = _Rectangles[RectanglesLB.SelectedIndex];

            LenghtTextBox.Text = _curretRentagles.Length.ToString();
            WidthTextBox.Text = _curretRentagles.Wide.ToString();
            ColorTextBox.Text = _curretRentagles.Color;
            CenterXTextBox.Text = _curretRentagles.Center.X.ToString();
            CenterYTextBox.Text = _curretRentagles.Center.Y.ToString();
            IDTextBox.Text = _curretRentagles.id.ToString();

        }

        private void LenghtTB_TextChanged(object sender, EventArgs e)
        {

            try
            {
                _curretRentagles.Length = Convert.ToDouble(LenghtTextBox.Text);
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
                _curretRentagles.Wide = Convert.ToDouble(WidthTextBox.Text);
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
            double maxWidth = array[0].Wide;
            int maxWideIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Wide > maxWidth)
                {
                    maxWidth = array[i].Wide;
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
            _rentagles.Add(new Rectangle(rnd.Next(1, 10), rnd.Next(1, 10), "Green", rnd.Next(1, 10), rnd.Next(1, 10)));
            RectanglesListBox.Items.Add($"{_rentagles[_rentagles.Count - 1].id}: X: {_rentagles[_rentagles.Count - 1].Center.X} Y:{_rentagles[_rentagles.Count - 1].Center.Y} W: {_rentagles[_rentagles.Count - 1].Wide} L: {_rentagles[_rentagles.Count - 1].Length}");
            RectanglesListBox.SelectedIndex = _rentagles.Count - 1;
            index++;

        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles = _rentagles[RectanglesListBox.SelectedIndex];
                RectanglesListBox.Items.RemoveAt(RectanglesListBox.SelectedIndex);
                _rentagles.Remove(_curretRentagles);
            }
            catch { }
            ColorClear();
        }

        private void RectanglesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles = _rentagles[RectanglesListBox.SelectedIndex];

                IDTB.Text = _curretRentagles.id.ToString();
                XTB.Text = _curretRentagles.Center.X.ToString();
                YTB.Text = _curretRentagles.Center.Y.ToString();
                LengthTB.Text = _curretRentagles.Length.ToString();
                WidthTB.Text = _curretRentagles.Wide.ToString();
            }
            catch
            {
                IDTB.Clear();
                XTB.Clear();
                YTB.Clear();
                LengthTB.Clear();
                WidthTB.Clear();
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

        private void LengthTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Length = Convert.ToDouble(LengthTB.Text);
                LengthTB.BackColor = Color.White;
            }
            catch
            {
                LengthTB.BackColor = Color.Red;
            }
        }

        private void WidthTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Wide = Convert.ToDouble(WidthTB.Text);
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
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = ($"{_rentagles[RectanglesListBox.SelectedIndex].id}: X: {_rentagles[RectanglesListBox.SelectedIndex].Center.X} Y:{_rentagles[RectanglesListBox.SelectedIndex].Center.Y} W: {_rentagles[RectanglesListBox.SelectedIndex].Wide} L: {_rentagles[RectanglesListBox.SelectedIndex].Length}");
            }
            catch { }
        }

        private void YTB_Leave(object sender, EventArgs e)
        {
            try
            {
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = ($"{_rentagles[RectanglesListBox.SelectedIndex].id}: X: {_rentagles[RectanglesListBox.SelectedIndex].Center.X} Y:{_rentagles[RectanglesListBox.SelectedIndex].Center.Y} W: {_rentagles[RectanglesListBox.SelectedIndex].Wide} L: {_rentagles[RectanglesListBox.SelectedIndex].Length}");
            }
            catch { }
        }

        private void LengthTB_Leave(object sender, EventArgs e)
        {
            try
            {
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = ($"{_rentagles[RectanglesListBox.SelectedIndex].id}: X: {_rentagles[RectanglesListBox.SelectedIndex].Center.X} Y:{_rentagles[RectanglesListBox.SelectedIndex].Center.Y} W: {_rentagles[RectanglesListBox.SelectedIndex].Wide} L: {_rentagles[RectanglesListBox.SelectedIndex].Length}");
            }
            catch { }
        }

        private void WidthTB_Leave(object sender, EventArgs e)
        {
            try
            {
                RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = ($"{_rentagles[RectanglesListBox.SelectedIndex].id}: X: {_rentagles[RectanglesListBox.SelectedIndex].Center.X} Y:{_rentagles[RectanglesListBox.SelectedIndex].Center.Y} W: {_rentagles[RectanglesListBox.SelectedIndex].Wide} L: {_rentagles[RectanglesListBox.SelectedIndex].Length}");
            }
            catch { }

        }

        private void ColorClear()
        {
            WidthTB.BackColor = Color.White;
            LengthTB.BackColor = Color.White;
            XTB.BackColor = Color.White;
            YTB.BackColor = Color.White;
        }
    }

}
