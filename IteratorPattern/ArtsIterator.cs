using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ArtsIterator : IIterator
    {
        private string[] _subjects;
        private int _position;

        public ArtsIterator(string[] subjects)
        {
            this._subjects = subjects;
            this._position = 0;
        }

        public string CurrentItem => this._subjects[_position];

        public void First()
        {
            this._position = 0;
        }

        public bool IsCollectionEnds()
        {
            return (this._position >= this._subjects.Length) ? true : false;
        }

        public string Next()
        {
            return this._subjects[this._position++];
        }
    }
}
