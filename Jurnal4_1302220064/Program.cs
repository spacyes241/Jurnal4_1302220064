// See https://aka.ms/new-console-template for more information
public class KodeBuah
{
    public enum Buah {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Duria, Anggur,Melon,Semangka,
}


    public String getKodeBuah(Buah input)
    {
       

    String[] KodeBuah = { "A00", "B00", "C00", "D00", "F00", "H00", "I00", "J00","K00","L00","M00","N00","O00"};
            return KodeBuah[(int)input];
    }
}

public class main
{
    static void Main(string[] args)
    {
        KodeBuah Test = new KodeBuah();
        Console.WriteLine("Nama Buah : " + KodeBuah.Buah.Apel);
        Console.WriteLine("Kode Buah : " + "A00");
    }
}


