using System.Collections.ObjectModel;

namespace Note
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Note> notes = new ObservableCollection<Note>();

        public MainPage()
        {
            InitializeComponent();
            cviewNotes.ItemsSource = notes;
        }

        private void AddNote(object sender, EventArgs e)
        {
            string title = entTitle.Text;
            string content = entContent.Text;
            Note note = new Note(title, content);
            notes.Add(note);
        }
    }

    public class Note
    {
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public bool IsImportant { get; set; } = false;

        public Note(string title, string content, bool isImportant = false)
        {
            this.Title = title;
            this.Content = content;
            this.IsImportant = isImportant;
        }
    }
}
