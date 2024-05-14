using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class SongControl : UserControl
    {
        public SongControl()
        {
            InitializeComponent();

        }

        private void SongControl_Enter(object sender, EventArgs e)
        {
            TextBoxControl(true);
        }

        private List<Song> _songs = new List<Song>();
        private Song _currentSong;
        private string _actionFlag;

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
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if ((TitleTextBox.Text.Length >0)&&(AuthorTextBox.Text.Length >0)&&(DurationTextBox.Text.Length > 0)&&(GenreComboBox.Text.Length > 0)) 
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
            }
            else
            {
                MessageBox.Show("Не оставляйте строчки пустыми");
            }


        }

        private void SongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedIndex != -1 ) 
            { 
                UpdateInfo(_songs[SongsListBox.SelectedIndex]);
                SaveButton.Enabled = false;
            }
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

        private Song InitializeSong()
        {
            return new Song(TitleTextBox.Text, Convert.ToInt32(DurationTextBox.Text), AuthorTextBox.Text, GenreComboBox.Text);
        }

        private void UpdateInfo(Song song)
        {
            AuthorTextBox.Text = song.Author;
            TitleTextBox.Text = song.Title;
            GenreComboBox.Items.Clear();
            GenreComboBox.Items.Add(song.Genre);
            GenreComboBox.SelectedIndex = 0;
            DurationTextBox.Text = Convert.ToString(song.Duration);
        }

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

        private void TextBoxClear()
        {
            AuthorTextBox.Clear();
            TitleTextBox.Clear();
            GenreComboBox.Items.Clear();
            DurationTextBox.Clear();
            GenreComboBox.Text = null;
        }

        private void TextBoxColorClear()
        {
            AuthorTextBox.BackColor = Color.White;
            TitleTextBox.BackColor = Color.White;
            GenreComboBox.BackColor = Color.White;
            DurationTextBox.BackColor = Color.White;
        }

        private void SortSong()
        {
            _songs = _songs.OrderBy(s => s.Author).ThenBy(s => s.Title).ToList();

            SongsListBox.Items.Clear();
            foreach (Song song in _songs)
            {
                SongsListBox.Items.Add(song);
            }
        }
}
}
