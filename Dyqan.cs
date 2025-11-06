using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Dyqan
    {
        public List<Produkt> Produktet { get; set; } = new List<Produkt>();
        public void ShtoProdukt(Produkt produkt)
        {
            Produktet.Add(produkt);
        }
        public void FshiProdukt(string emri)
        {
            var produkt = Produktet.FirstOrDefault(p => p.emri == emri);
            if (produkt != null)
            {
                Produktet.Remove(produkt);
            }
        }
        public int TotaliProdukteve()
        {
            return Produktet.Sum(p => p.sasi);
        }
    }
}
