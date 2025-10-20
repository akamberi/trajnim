/*
1. lexo gjatesin e vektorit
2. deklarimin e vektorit
3. mbushim me te dhena
   per i = 0deri ne n
    lexo vektori v[i]

n = 7;
[7,3,3,1,3,4,5]

3.*nrMaxP = 0; nrMax = -1;
4. per i = 0 deri n
   fillo
        nrP = 0;
        per j = 0 deri n 
        fillo
            nqs V[i] == V[j]
                nrP++;
        fund
        nqs nrP > nrMaxP
        fillo
            nrMaxP = nrP;
            nrMax = V[i];
        fund
    fund
5. Afisho nrMax, nrMaxP
 */

int LexoNumer(string msg)
{
    Console.Write(msg);
    if(!int.TryParse(Console.ReadLine(), out int nr))
    {
        return LexoNumer(msg);
    }
    return nr;
}
int[] KrijoVektor(int n)
{
    int[] vektor = new int[n];
    for (int i = 0; i < n; i++)
    {
        vektor[i] = LexoNumer($"Jep elementin e {i + 1}: ");
    }
    return vektor;
}

int GjejNrPerseritje(int[] A, int nr)
{
    int nrP = 0;
    for(int i = 0; i < A.Length; i++)
    {
        if (A[i] == nr)
        {
            nrP++;
        }
    }
    return nrP;
}

//int n = LexoNumer("Jep gjatesine e vektorit: ");
//var V = KrijoVektor(n);

//int nrMaxP = 0, nrMax = -1;
//for (int i = 0; i < n; i++)
//{
//    int nrP = GjejNrPerseritje(V, V[i]);
//    if (nrP > nrMaxP)
//    {
//        nrMaxP = nrP;
//        nrMax = V[i];
//    }
//}
//Console.WriteLine($"numri qe perseritet me shpesh eshte: {nrMax} me {nrMaxP} perseritje");


//per cdo element te nje vektori qe merret nga perdoruesi shkruaj sa here perseritet.
int gjatesia = LexoNumer("jep gjatesin e vektorit: ");
var vektori = KrijoVektor(gjatesia);
List<int> nrProcesuar = new List<int>();    

foreach(var nr in vektori)
{
    if (nrProcesuar.Contains(nr))
        continue;
    nrProcesuar.Add(nr);
    int nrP = GjejNrPerseritje(vektori, nr);
    Console.WriteLine($"numri {nr} perseritet {nrP} here");
}