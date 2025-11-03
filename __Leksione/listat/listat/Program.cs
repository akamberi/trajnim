//krijo nje klase Libri me fushat titulli, autori , viti
//Krijo nje list me libra
//me nje metode afisho() afishoni te gjithe librat qe jane publikuar pas vitit 2015
List<Libri> librat = new List<Libri>
{
    new Libri
    {
        Autori="Naim", Viti= 2016, Titulli="testi1"
    },new Libri
    {
        Autori="Lasgushi", Viti= 2008, Titulli="testi2"
    },new Libri
    {
        Autori="Kadare", Viti= 2025, Titulli="testi3"
    },
};
Libri.Afisho(librat);


