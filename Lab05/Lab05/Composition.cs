using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class StudentC
    {
        Person person = new Person();
        public string FormatIdAndName(string name, int id) {

            return person.FormatIdAndName(name, id);

        }
    }
}
