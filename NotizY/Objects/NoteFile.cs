using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotizY.Objects
{
    internal class NoteFile
    {
        string path; 
        public NoteFile(string path) {
            this.path = path;
        }

        public void loadNotes(List<Note> noteList)
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.CreateText(path).Close();
                }
                noteList.Clear();
                using(StreamReader sr = new StreamReader(path))
                {
                    while(!sr.EndOfStream)
                    {
                        Note note = new Note(sr.ReadLine());
                        noteList.Add(note);
                    }
                }
            }catch (Exception ex) {  MessageBox.Show("Error. Could not Load Notes\n" + ex.Message); }
        }

        public bool saveNotes(List<Note> noteList)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path))
                {
                    foreach(Note note in noteList)
                    {
                        sw.WriteLine(note.toCsv());
                    }
                }
                return true;
            }catch (Exception ex) { MessageBox.Show("Error. Could not Save Notes\n" + ex.Message); }
            return false;
        }
    }
}
