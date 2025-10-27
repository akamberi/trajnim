namespace oop_ushtrimet
{
    public class punonjes
    {
        public string Emri { get; set; }
        public string Pozicion { get; set; }
        public decimal Paga { get; set; }
        public punonjes(string emri, string pozicion, decimal paga)
        {
            Emri = emri;
            Pozicion = pozicion;
            Paga = paga;
        }
        public void ShfaqInfo()
        {
            Console.WriteLine($"Emri: {Emri}, Pozicioni: {Pozicion}, Paga: {Paga}");
        }
    }
}
