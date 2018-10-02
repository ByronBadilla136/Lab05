using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class StudentC
    {
        Person person;

        public StudentC(Person person)
        {
            this.person = person;
        }
        public string FormatIdAndName(string name, int id) {

            return person.FormatIdAndName(name, id);

        }
    }
}
