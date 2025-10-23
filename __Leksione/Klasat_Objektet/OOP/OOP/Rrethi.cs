namespace OOP
{
    public class Rrethi
    {
        public double Rrezja { get; set; }
        //public double Siperfaqja { get; set; }

        public double Siperfaqja
        {
            get
            {
                return Math.PI * Rrezja * Rrezja; //formula e sip vetem per lexim
            }
        }
    }
}
