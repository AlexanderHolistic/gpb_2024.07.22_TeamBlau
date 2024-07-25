using MaterialSkin.Controls;
using NotizY.Objects;

namespace NotizY
{
    public partial class Form1 : Form
    {
        bool saved = false;
        Note activeNote;
        NoteFile file = new NoteFile("user_notes.csv");
        List<Note> notes = new List<Note>();
        public Form1()
        {
            InitializeComponent();
            file.loadNotes(notes);
            activeNote = notes.Count > 0 ? notes[0] : new Note("", "", false, string.Empty);
            updateTextBoxes();
        }

        private void updateTextBoxes()
        {
            ueberschriftTextBox.Text = activeNote.title;
            inhaltTextBox.Text = activeNote.content;
        }

        private void ueberschriftTextBox_TextChanged(object sender, EventArgs e)
        {
            if (saved)
            {
                saved = false;
            }
            activeNote.title = ueberschriftTextBox.Text;
        }

        private void inhaltTextBox_TextChanged(object sender, EventArgs e)
        {
            if (saved)
            {
                saved = false;
            }
            activeNote.content = inhaltTextBox.Text;
        }

        private void speicherButton_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                notes.Remove(activeNote);
                notes.Add(activeNote);
                if (file.saveNotes(notes))
                {
                    saved = true;
                }
            }
            updateTextBoxes();
        }
    }
}
