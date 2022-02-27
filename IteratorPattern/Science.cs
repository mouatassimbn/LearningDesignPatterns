using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Science : IEnumerable
    {
        private LinkedList<string> _subjects;

        public Science()
        {
            this._subjects = new LinkedList<string>();
            this._subjects.AddFirst("Mathematics");
            this._subjects.AddFirst("Computer Science");
            this._subjects.AddFirst("Physics");
            this._subjects.AddFirst("Electronics");
        }

        public IEnumerator GetEnumerator()
        {
            foreach (string subject in this._subjects)
            {
                yield return subject;
            }
        }
    }
}
