using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExample
{
    public class Persona
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DisplayName
        {
            get
            {
                return $"{Name}, {LastName}";
            }
        }

    }

    public class PersonaList : List<Persona>
    {
        public string Cabecera { get; set; }

        public List<Persona> Personas => this;

        public PersonaList(string Cabecera)
        {
            Cabecera = Cabecera;
        }

        public PersonaList()
        {
        }
    }
}
