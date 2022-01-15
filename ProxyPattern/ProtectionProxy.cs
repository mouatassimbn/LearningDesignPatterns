using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class ProtectionProxy : Subject
    {
        private Subject _subject;
        private string[] _registeredUsers;
        private string _currentUser;

        public ProtectionProxy(string currentUser)
        {
            this._registeredUsers = new string[] { "Admin", "Yoshi", "Nino" };
            this._currentUser = currentUser;
        }

        public override void DoSomeWork()
        {
            Console.WriteLine($"{this._currentUser} wants to access into system.");
            if (this._registeredUsers.Contains(this._currentUser))
            {
                Console.WriteLine($"Welcome, {this._currentUser}");
                if (this._subject == null)
                {
                    this._subject = new ConcreteSubject();
                }

                this._subject.DoSomeWork();
            }
            else
            {
                Console.WriteLine($"Sorry {this._currentUser}, you do not have access into the system.");
            }
        }
    }
}
