using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BackToSchool
{
    class Class : School, ICommentable
    {
        public string textIdentifier { get; set; }
        protected List<string> comments = new List<string>();

        public Class(string inputClassId)
        {
            this.textIdentifier = inputClassId;
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}
