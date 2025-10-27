
class Rreth:IForma
{
    public double Rreze {  get; set; }

    public Rreth (double rreze) 
    {
        Rreze= rreze;
    }

    public double LlogaritPerimetrin()
    {
        return 2 * Math.PI * Rreze;
    }

    public double LlogaritSiperfaqen()
    {
        return Math.PI * Rreze * Rreze;
    }
}

