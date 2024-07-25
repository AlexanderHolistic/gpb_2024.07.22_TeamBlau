using MaterialSkin.Controls;
using NotizY.Objects;

namespace NotizY
{
    public partial class Form1 : MaterialForm
    {
        bool saved = false;
        Note activeNote;
        NoteFile file = new NoteFile("user_notes.csv");
        List<Note> notes = new List<Note>();

        public Form1()
        {
            InitializeComponent();
            file.loadNotes(notes);
            activeNote = notes.Count > 0 ? notes[0] : new Note();
            updateTextBoxes();
            updateListBox();
        }

        private void updateTextBoxes()
        {
            ueberschriftTextBox.Text = activeNote.title;
            inhaltTextBox.Text = activeNote.content;
        }

        private void ueberschriftTextBox_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            activeNote.title = ueberschriftTextBox.Text;
            saveCurrentNote();
            updateTextBoxes();
        }

        private void inhaltTextBox_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            activeNote.content = inhaltTextBox.Text;
            saveCurrentNote();
            updateTextBoxes();
        }

        private void saveCurrentNote()
        {
            notes.Remove(activeNote);
            notes.Add(activeNote);
            if (file.saveNotes(notes))
            {
                saved = true;
            }
            updateListBox();
        }

        private void speicherButton_Click(object sender, EventArgs e)
        {
            saveCurrentNote();
            updateTextBoxes();
        }


        private void updateListBox()
        {
            listBox1.Items.Clear();
            foreach (Note note in notes)
            {
                listBox1.Items.Add(note);
            }
        }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            activeNote = (Note)listBox1.Items[listBox1.SelectedIndex];
            updateTextBoxes();
        }

        private void btn_hinzufuegen_Click(object sender, EventArgs e)
        {
            activeNote = new Note();
            updateTextBoxes();
        }
    }
}
