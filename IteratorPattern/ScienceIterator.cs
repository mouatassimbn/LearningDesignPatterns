using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ScienceIterator : IIterator
    {
        private LinkedList<string> _subjects;
        private int _position;

        public ScienceIterator(LinkedList<string> subjects)
        {
            this._subjects = subjects;
            this._position = 0;
        }

        public string CurrentItem => this._subjects.ElementAt(this._position);

        public void First()
        {
            this._position = 0;
        }

        public bool IsCollectionEnds()
        {
            return (this._position < this._subjects.Count()) ? false : true;
        }

        public string Next()
        {
            return this._subjects.ElementAt(this._position++);
        }
    }
}
