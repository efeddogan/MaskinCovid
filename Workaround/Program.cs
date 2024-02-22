using Business.Concrete;
using Entities.Concrete;
using System.IO.Pipes;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas = new Vatandas();
            
        

            Console.WriteLine(20000 * 412);

            SelamVer(isim: "Engin");
            SelamVer(isim: "Efe" );
            SelamVer();

            int sonuc = Topla(9, 2);

           
            string[] ogrenciler = new string[3];
            ogrenciler[0] = " Efe ";
            ogrenciler[1] = "ARda ";
            ogrenciler[2] = "Hasan ";

            ogrenciler = new string[4];
            ogrenciler[3] = " Burak ";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara ", " İstanbul ", "İzmir" };
            string[] sehirler2 = new[] { "Bursa ", " Diyarbakır ", "Mardin" };

            sehirler2 = sehirler1;
            sehirler1[0] = "adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Efe";
            person1.LastName = "doğan";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentitiy = 60481202058;

            Person person2 = new Person();

            person2.FirstName = "Hakan";

            foreach (string s in sehirler1) {  Console.WriteLine(s); }

            List<string> yeniSehirler1 = new List<string> { "Aydın", "Mugla", "Manisa" };
            yeniSehirler1.Add(item: "bolu");
            foreach(string sehir in yeniSehirler1) { Console.WriteLine(sehir); }



            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();

        }

        static int Topla(int sayı1, int sayı2)
        {
            int sonuc = sayı2 + sayı1;
            Console.WriteLine("Toplam: "+ sonuc);
            return sonuc;


        }

        static void SelamVer( string isim = "noname")
        {
            Console.WriteLine(" Merhaba " + isim );
        }

        private static void Degiskenler() { }
        
            public string ad = "Efe";
            public string Soyad = "Dogan";
            public int dogumyılı = 2000;
            public  long tcNo = 12345678910;
        
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string DogumYılı { get; set; }
        public string TcNo { get; set; }
    }

}
