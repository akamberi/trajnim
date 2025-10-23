namespace OOP
{
    public class Student
    {
        //properties
        public string Emer { get; set; } //lexim/shkrim
        public int Mosha { get; set; }

        public string Mbiemer { get; set; }

        //konstruktor pa parametra
        public Student()
        {
            Emer = "Gerti";
            Mbiemer = "Uruci";
            Mosha = 20;
        }

        //konstruktor me parametra
        public Student(string emer, int mosha)
        {
            Emer = emer;
            Mosha = mosha;
        }

        public Student(string emer, int mosha, string mbiemer)
        {
            Emer = emer;
            Mosha = mosha;
            Mbiemer = mbiemer;
        }
    }
}
