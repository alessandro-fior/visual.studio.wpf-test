using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Models
{
 
    public interface IPersoneService
    {
        IList<Persona> Persone { get; }
    }


    class PersoneService : IPersoneService
    {
        private List<Persona> _persone = null;

        public PersoneService()
        {
            _persone = new List<Persona>();

            _persone.Add(new Persona() { Nome = "Mario", Cognome = "Rossi" });
            _persone.Add(new Persona() { Nome = "Giovanni", Cognome = "Bianchi" });
            _persone.Add(new Persona() { Nome = "Renato", Cognome = "Brambilla" });
            _persone.Add(new Persona() { Nome = "Carlo", Cognome = "Verdi" });
        }

        //public IList<Persona> Persone
        //{
        //    get { return _persone; }
        //}

        //forma abbreviata del precedente ...
        public IList<Persona> Persone => _persone;

    }
}
