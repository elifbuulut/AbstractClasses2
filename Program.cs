using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses2
{
    //              ABSTRACT CLASS NEDİR 
    /*Abstract Class, ortak özellikli olan Class’lara base class olma rolünü üstlenir. Mesela bir class’ınız var ve bu class da pek çok ortak yön 
     * olarak özellikleriniz var. Aynı özellikleride içinde tutan başka bir classs’ınız daha var. Tekrardan 
     * aynı özellerini yazmak yerine base (yani abstract) class tanımlayıp buradan türetilmiş sınıflara kodumuzun daha efektif olmasını sağlıyoruz.
     * Aynı özellikleri başka sınıflara da base alarak oluşturmak istediğimiz için bu class’lara abstract class adını veriyoruz. 
     * Bu nedenle abstract class’dan nesne türetilmez. Abstract class’lar abstract anahtar kelimesini kullanılarak oluşturulur.Abstract class’lar
     * private, protected, private internal ile tanımlanamazlar. Abstract methodlar tanımlanabilir ama static methodlar tanımlanamazlar. 
     *Abstract Class’larda kullanılan diğer önemli nokta ise Abstract Methodlardır. Bu methodlar sadece abstract class’lar içinde tanımlanır 
     *ve override edilmek zorundadır. Abstract methodlar private tanımlanamazlar.
     *Abstract aslında bir yandan da virtual demektir, virtualda override zorunluğu yok iken abstract için bu zorunluluk vardır, aralarındaki
     *fark budur.

     */
    internal class Program
{
    static void Main(string[] args)
    {
        Kisi1 kisi1 = new Kisi1()
        {
            adSoyad = "Hilal Bulut",
            tc = "1111151111",
            telefon = "722255566",
            adres = "Istanbul"
        };
        kisi1.Bilgiler();
        Kisi2 kisi2 = new Kisi2()
        {
            adSoyad = "Elif Bulut",
            tc = "1111111111",
            telefon="222255566",
            email="1bltelf@blt.com"
        };
        kisi2.Bilgiler();
        Console.ReadLine();
    }
}

abstract class Kisiler
{
    private string _adSoyad, _tc, _telefon;
    public string adSoyad
    {
        get
        { return _adSoyad; }

        set
        { _adSoyad = value; }
    }
    public string tc
    {
        get
        { return _tc; }
        set
        { _tc = value; }
    }

    public string telefon
    {
        get
        { return _telefon; }
        set
        { _telefon = value; }


    }

    abstract public void Bilgiler();

}

class Kisi1 : Kisiler
{
    public string adres; // buna has ozellik 
    public override void Bilgiler()
    {
        Console.WriteLine($"1.kişinin bilgileri:\n{adSoyad}\n{tc}\n{telefon}\n{adres}\n");
    }
}

class Kisi2 : Kisiler // base class Kisiler
{
    public string email;
    public override void Bilgiler()
    {
        Console.WriteLine($"2.kişinin bilgileri:\n{adSoyad}\n{tc}\n{telefon}\n {email}");


    }
}
}
