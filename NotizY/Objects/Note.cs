using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace NotizY.Objects
{
    internal class Note
    {
        public string content;
        public string title;
        public bool favourit;
        public string group;

        public Note(string title, string content, bool? favourit, string? group) {
            this.title = title;
            this.content = content;
            this.favourit = favourit != null ? (bool)favourit : false;
            this.group = group != null ? group : string.Empty;
        }

        public Note(string csvString)
        {
            string[] objects = csvString.Split(';');
            this.title = objects[0];
            this.content = objects[1];
            this.favourit = Convert.ToBoolean(objects[2]);
            this.group = objects[3];
        }

        public Note()
        {
            this.title = string.Empty;
            this.content = string.Empty;
            this.favourit = false;
            this.group = string.Empty;

        }

        public override string ToString()
        {
            return title;
        }

        public string toCsv()
        {
            return string.Format("{0};{1};{2};{3}", title, content, favourit, group);
        }
    }
}
