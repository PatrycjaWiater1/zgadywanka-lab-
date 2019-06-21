using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGry
{
    public partial class Gra
    {
        private readonly List<Ruch> historia;
        public IReadOnlyList<Ruch> Historia => historia;
      
        // inner class - klasa wewnętrzna

        public class Ruch
        {
            //public readonly int propozycja; // 
            //public readonly Odpowiedz odpowiedz;
            //public readonly DateTime kiedy;
            //IList<int> propozycja = new List<int>();
            //IList<Odpowiedz> odpowiedz = new List<Odpowiedz>();
            //IList<DateTime> kiedy = new List<DateTime>();

            IList<Tuple<int,Odpowiedz,DateTime>> historia = new List<Tuple<int, Odpowiedz, DateTime>>();

            //public Ruch(int prop, Odpowiedz odp)
            //{
            //    propozycja.Add(prop);
            //    odpowiedz.Add(odp);
            //    kiedy.Add(DateTime.Now);
            //}

            public void DodajPozycje(int prop, Odpowiedz odp)
            {
                //propozycja.Add(prop);
                //odpowiedz.Add(odp);
                //kiedy.Add(DateTime.Now);
                historia.Add(new Tuple<int, Odpowiedz, DateTime>(prop, odp, DateTime.Now));
            }

            public List<Tuple<int, Odpowiedz, DateTime>> GetPropozycje()
            {
                List<Tuple<int, Odpowiedz, DateTime>> lista;
                lista = historia.Select(x => x).ToList();
                return lista;
            }

            //public override string ToString()
            //{
            //    return $"({propozycja}, {odpowiedz}, {kiedy})";
            //}
        }
    }
}
