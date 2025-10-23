using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Banka
    {
        public int BankId { get; set; }

        public string Emer { get; set; }

        private double Balanca { get; set; }

        protected string SecretKey { get; set; }

        internal string ApiKey { get; set; }

        protected internal string URL { get; set; }

        private protected string Secret { get; set; }

        public void VendosBalancen(double shuma)
        {
            if(shuma > 0)
            {
                Balanca = shuma;
            }
        }

        public double LexoBalancen()
        {
            return Balanca;
        }

        public string LexoEmerinDheBalancen()
        {
            var msg = $"Banka me emer {Emer} ka balance {Balanca}";
            return msg;
        }
    }
}
