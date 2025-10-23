namespace OOP
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    Makina makina = new Makina(); //krijojme objektin 
        //    makina.ngjyra = "e kuqe";
        //    makina.shpejtesia = 200;
        //    Console.WriteLine(makina.ngjyra); //afishojme fushen ngjyra nga objekti
        //    Console.WriteLine(makina.shpejtesia); //afishojme fushen shpejtesia nga objekti
        //}

        //get/ set property value
        //static void Main(string[] args)
        //{
        //    Student student = new Student(); //krijojme objektin per klasen student
        //    student.Emer = "Kristi"; //set i vendosim nje vlere
        //    Console.WriteLine(student.Emer); //afishojme
        //}


        //static void Main(string[] args)
        //{
        //    Rrethi rrethi = new Rrethi();
        //    rrethi.Rrezja = 5; //i japim vleren rrezes
        //    //rrethi.Siperfaqja = Math.PI * rrethi.Rrezja * rrethi.Rrezja;
        //    Console.WriteLine($"Rrethi me rreze {rrethi.Rrezja} ka siperfaqe {rrethi.Siperfaqja}");
        //}

        //konstruktor pa parametra
        //static void Main(string[] args)
        //{
        //    Student student = new Student();
        //    Console.WriteLine($"Studenti me emer {student.Emer} eshte {student.Mosha} vjec!");
        //}

        //konstruktor me parametra
        //static void Main(string[] args)
        //{
        //    Student s = new Student();
        //    Console.WriteLine($"Studenti me emer {s.Emer} eshte {s.Mosha} vjec!");

        //    Student s1 = new Student("gerti", 20);
        //    Console.WriteLine($"Studenti me emer {s1.Emer} eshte {s1.Mosha} vjec!");

        //    Student s2 = new Student("gerti", 20, "Uruci");
        //    Console.WriteLine($"Studenti me emer {s2.Emer} {s2.Mbiemer} eshte {s2.Mosha} vjec!");
        //}

        //static void Main(string[] args)
        //{
        //    Libri libri = new Libri();
        //    Console.WriteLine($"Libri me titull {libri.Titulli} dhe autor {libri.Autori}");


        //    Libri libri1 = new Libri("Kujtimet e mia", "Arben Xhafa");
        //    Console.WriteLine($"Libri me titull {libri1.Titulli} dhe autor {libri1.Autori}");
        //}

        static void Main(string[] args)
        { 
            Banka banka = new Banka();
            banka.Emer = "BKT";
            double shuma = 1000;
            banka.VendosBalancen(shuma);
            Console.WriteLine(banka.LexoBalancen());
            Console.WriteLine(banka.LexoEmerinDheBalancen());
        }
    }
}
