using System.Data;
using System.Text.Json;


namespace Music
{
    public partial class SongControl : UserControl
    {
        public SongControl()
        {
            InitializeComponent();

            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                if (path != null && !Directory.Exists(Path.GetDirectoryName(path) ?? ""))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path) ?? "");
                }
            }
            else if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }

            if (IsDataFileExist())
            {
                _songs.AddRange(GetSavedSongArray());
                SongsListBox.Items.AddRange(GetSavedSongArray());
                SaveButton.Enabled = false;
            }

        }


        /// <summary>
        /// Список песен.
        /// </summary>
        private List<Song> _songs = new List<Song>();
        /// <summary>
        /// Переменная, хранящая данные о нажатой кнопке.
        /// </summary>
        private string _actionFlag;
        /// <summary>
        /// Переменная, хранащая путь к папке appdata.
        /// </summary>
        private static string _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        /// <summary>
        /// Переменная, хранящая путь к папке с сохранением.
        /// </summary>
        private string path = Path.Combine(_appDataPath, "AppSongs/songSave.json");


        private void SongsListBox_Enter(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            _actionFlag = "add";
            TextBoxControl(false);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _actionFlag = "edit";
            TextBoxControl(false);
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            int index = SongsListBox.SelectedIndex;
            _songs.RemoveAt(index);
            SongsListBox.Items.RemoveAt(index);
            TextBoxClear();
            SongSave();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if ((TitleTextBox.Text.Length > 0) && (AuthorTextBox.Text.Length > 0) && (DurationTextBox.Text.Length > 0) && (GenreComboBox.Text.Length > 0))
            {
                if (_actionFlag == "add")
                {
                    try
                    {

                        Song song = InitializeSong();
                        _songs.Add(song);
                        SongsListBox.Items.Add(song);

                    }
                    catch
                    {
                    }

                }
                else if (_actionFlag == "edit")
                {
                    try
                    {
                        _songs[SongsListBox.SelectedIndex] = InitializeSong();
                        SongsListBox.Items[SongsListBox.SelectedIndex] = InitializeSong();
                    }
                    catch
                    {
                    }
                }

                TextBoxClear();
                TextBoxControl(true);
                TextBoxColorClear();
                SortSong();
                SongSave();
            }
            else
            {
                MessageBox.Show("Не оставляйте строчки пустыми");
            }



        }

        private void SongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateInfo(_songs[SongsListBox.SelectedIndex]);
                SaveButton.Enabled = false;
            }
            catch { }
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AuthorTextBox.BackColor = Color.White;
                SaveButton.Enabled = true;
                Validator.AssertOnLenghtValue(AuthorTextBox.Text, 50);

            }
            catch
            {
                AuthorTextBox.BackColor = Color.Red;
                SaveButton.Enabled = false;
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TitleTextBox.BackColor = Color.White;
                SaveButton.Enabled = true;
                Validator.AssertOnLenghtValue(TitleTextBox.Text, 50);
            }
            catch
            {
                TitleTextBox.BackColor = Color.Red;
                SaveButton.Enabled = false;
            }

        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationTextBox.BackColor = Color.White;
                SaveButton.Enabled = true;
                Validator.AssertValueInRange(Convert.ToInt32(DurationTextBox.Text), 0, 7200);
            }
            catch
            {
                if (DurationTextBox.Text.Length > 0)
                {
                    DurationTextBox.BackColor = Color.Red;
                    SaveButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса Song, заполняя данными из текстовых полей.
        /// </summary>
        /// <returns>Экземпляр класса Song. <see cref="Song"/> </returns>
        private Song InitializeSong()
        {
            return new Song(TitleTextBox.Text, Convert.ToInt32(DurationTextBox.Text), AuthorTextBox.Text, GenreComboBox.Text);
        }

        /// <summary>
        /// Заносит данные о песни в текстовые поля.
        /// </summary>
        /// <param name="song">Песня, данные которые нужно занести.</param>
        private void UpdateInfo(Song song)
        {
            AuthorTextBox.Text = song.Author;
            TitleTextBox.Text = song.Title;
            GenreComboBox.Items.Clear();
            GenreComboBox.Items.Add(song.Genre);
            GenreComboBox.SelectedIndex = 0;
            DurationTextBox.Text = Convert.ToString(song.Duration);
        }

        /// <summary>
        /// Блокирует тектовые поля.
        /// </summary>
        /// <param name="flag">Если True, то поля блокируется, если False, то включаются.</param>
        private void TextBoxControl(bool flag)
        {
            AuthorTextBox.ReadOnly = flag;
            TitleTextBox.ReadOnly = flag;
            DurationTextBox.ReadOnly = flag;
            if (flag)
            {
                GenreComboBox.Items.Clear();
            }
            else
            {
                GenreComboBox.Items.AddRange((Enum.GetNames(typeof(Genre))));
            }
            SaveButton.Enabled = !(flag);
        }

        /// <summary>
        /// Очищает тектовые поля.
        /// </summary>
        private void TextBoxClear()
        {
            AuthorTextBox.Clear();
            TitleTextBox.Clear();
            GenreComboBox.Items.Clear();
            DurationTextBox.Clear();
            GenreComboBox.Text = null;
        }

        /// <summary>
        /// Сбрасывает цвет текстовых полей.
        /// </summary>
        private void TextBoxColorClear()
        {
            AuthorTextBox.BackColor = Color.White;
            TitleTextBox.BackColor = Color.White;
            GenreComboBox.BackColor = Color.White;
            DurationTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Созтирует массив песен и перерезаполняет ListBox.
        /// </summary>
        private void SortSong()
        {
            _songs = _songs.OrderBy(s => s.Author).ThenBy(s => s.Title).ToList();

            SongsListBox.Items.Clear();
            foreach (Song song in _songs)
            {
                SongsListBox.Items.Add(song);
            }
        }

        /// <summary>
        /// Сериализует массив песен.
        /// </summary>
        /// <returns>Строка, для записи в файл.</returns>
        private string SerializeeSong()
        {
            string temp = string.Empty;
            foreach (var song in _songs)
            {
                temp += JsonSerializer.Serialize(song) + "\n";
            }

            return temp;
        }

        /// <summary>
        /// Сохраняет строку в файл.
        /// </summary>
        private void SongSave()
        {

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(SerializeeSong());
            }
        }

        /// <summary>
        /// Считывает данные из файла в стрроку. 
        /// </summary>
        /// <returns>Строка, сожержащая данные о песнях.</returns>
        private string GetJsonSongs()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Преобразует строку в массив песен.
        /// </summary>
        /// <returns>Массив песен.</returns>
        private Song[] GetSavedSongArray()
        {

            var output = new List<Song>();
            foreach (var jsonSong in GetJsonSongs().Split(new char[] { '\n' }))
            {
                if (jsonSong != "")
                {
                    output.Add(JsonSerializer.Deserialize<Song>(jsonSong));
                }
            }

            return output.ToArray();
        }

        /// <summary>
        /// Проверяет наличие папки с фалом.
        /// </summary>
        /// <returns>Если True, то папка есть, если False, то папки нету.</returns>
        private bool IsDataFileExist()
        {
            return new FileInfo(path).Exists;
        }
    }
}