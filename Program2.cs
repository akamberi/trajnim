int numer, count = 0;
double shuma = 0;
        do
        {
            Console.Write("Shkruaj një numër : ");//kur shenojm -1 programi ndalet
            numer = int.Parse(Console.ReadLine());

            if (numer != -1)
            {
                shuma += numer;
                count++;
            }

        } while (numer != -1);

        if (count > 0)
            Console.WriteLine("Mesatarja është: " + (shuma / count));
        else
            Console.WriteLine("Nuk u fut asnjë numër për llogaritje.");
    
