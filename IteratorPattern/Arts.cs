using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Arts : IEnumerable
    {
        private string[] _subjects;

        public Arts()
        {
            this._subjects = new[] { "English", "History", "Geography", "Psychology" };
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
