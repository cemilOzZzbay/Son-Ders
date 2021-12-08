using System;
using System.Globalization;

namespace StringDateTime8523
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] isimKarakterler = new char[3]
            {
                'C','A','N'
            };
            foreach (char c in isimKarakterler)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            string isimString = "CAN";
            Console.WriteLine(isimString);

            string city1 = "Ankara";
            Console.WriteLine(city1[0]);    // Ankara nın ilk harfini "A" yazacak.

            foreach (char c in city1)
            {
                Console.WriteLine(c);       // Ankarayı döngü kullanarak alt alta yazdırır.       
            }

            string city2 = "İstanbul";
            string result1 = city1 + city2; //concatenate: İki ayrı string değeri aralıksız birbirine bağlar "Ankaraİstanbul"
            Console.WriteLine(result1);
            string result2 = city1 + " " + city2; // Ankara ve İstanbulu arada boşluk olacak şekilde yazdırır "Ankara İstanbul"
            Console.WriteLine(result2);

            string result3 = string.Format("{0} {1}", city1, city2); // Ankara ve İstanbulu arada boşluk olacak şekilde yazdırır "Ankara İstanbul"
            Console.WriteLine(result3);

            string sentence = "My name is Çağıl Alsaç";
            int lenght = sentence.Length;   // .Length özelliği kullanılarak toplam karakter sayısı yazdırılır "22" yazar.
            Console.WriteLine(lenght);

            sentence = sentence.Replace("Çağıl", "Leo"); //.Replace metodu ile My name is Çağıl Alsaç cümlesini Leo Alsaç olacak şekilde değiştirir.
            Console.WriteLine(sentence);

            if (sentence.EndsWith("ç"))                          //.EndsWith metodu ile sentence değişkenin 
                Console.WriteLine("Sentence ends with ç");       // içindeki cümlenin son harfinin "ç" olup olmadığı
            else                                                 // if else koşulu kullanılarak yazdırılır.
                Console.WriteLine("Sentence doesn't end with ç");

            if (sentence.StartsWith("Your name"))                        // .StartsWith metodu ile sentence değişkini 
                Console.WriteLine("Sentence starts with \"Your name\"");       // içindeki cümlenin "Your name" şeklinde başlayıp
            else                                                         // başlamadığı if else koşulu kullanılarak yazdırılır
                Console.WriteLine("Sentence doesn't start with \"Your name\"");

            // My name is Leo Alsaç                 
            int indexOfIs = sentence.IndexOf("is"); //.IndexOf metodu sentence değişkeni içindeki "My name is Leo Alcaç"
            Console.WriteLine(indexOfIs);           //cümlesinin index numaralarını {0}sıfırıncı index numarası ile "is"
                                                    //kısmına gelincede {8}sekizinci index numarası olar "i" hafini baz alır
                                                    //ve 8 yazdırır.

            int indexOfX = sentence.IndexOf("X"); // Burdaki .IndexOf metodu kullanımında ise tanımlanan sentence değişkeni
            Console.WriteLine(indexOfX);          // içindeki cümlenin indexleri "x" karakterine göre kontrol edilir  
                                                  // "My name is Leo Alsaç" cümlesinde "x" karakteri olmadığı için -1 yazdırır.

            int indexOfSpace = sentence.IndexOf(" "); //Burdaki IndexOf metodu kullanımında ise tanımlanan sentence değişkeni
            Console.WriteLine(indexOfSpace);          //içindeki cümlenin index leri " " ilk boşluk karakterine göre kontrol eder
                                                      //"My name is Leo Alsaç" cümlesinde ilk boşluk {2}index e karşık gelir 2 yazdırır.

            int LastIndexOfSonGirilenKarakter = sentence.LastIndexOf("e"); //.LastIndexOf metodu kullanımında belirtilen son karakterin
            Console.WriteLine(LastIndexOfSonGirilenKarakter);              // index numarası yazdırılır.Burda sentence değişkenindeki
                                                                           // "My name is Leo Alsaç" cümlesinde son "e" karakterinin            
                                                                           // index {12}dir ve 12 yazdırır.

            //"Hello! My name is Leo Alsaç" 
            sentence = "Hello!" + sentence;          // Burdaki kullanımda sentence değişkenindeki sabit değer "My name is Leo Alsaç" dır.
            Console.WriteLine(sentence);             // Sadece "My name is Leo Alsaç" değerinin başına geçici olarak "Hello!" ifadesi yazdırır.

            sentence = sentence.Insert(0, "Hello!"); // .Insert metodu ile sentence değişkenindeki "My name is Leo Alsaç" 
            Console.WriteLine(sentence);             // cümlesinin başına "Hello!" kelimesini sabit olarak ekleyip değişkenin 
                                                     // içindeki değeri günceller.Yukardaki örnekten farkı Insert metoduyla sabit değişim yapabilmemizdir.


            //"Hello!Hello!My name is Leo Alsaç"              // .Substring metotudunun burdaki kullanımı sentence.Substring(0,12)
            string subSentence1 = sentence.Substring(0, 12);   // parametreleri {0}. index ten başlayıp 12i karakterlik eleman sayısını yazdırır.
            Console.WriteLine(subSentence1);                  // Ama eleman sayısı 0 dan değil 1 den başlar ve "Hello!Hello!" yazdırı.

            string subSentence2 = sentence.Substring(12);     // .Substring metotudunun burdaki kullanımı sentence.Substring(12) tek 
            Console.WriteLine(subSentence2);                  // parametre kullanılarak {12}. index ten başlar ve sentence değişkenindeki 
                                                              // değerin hepsini yazdırır. yani "My name is Leo Alcaç" yazdırır.

            string subSentence3 = sentence.Substring(23, 9);   // .Substring metotudunun burdaki kullanımı sentence.Substring(23,9)
            Console.WriteLine(subSentence3);                  // kullanılarak {23}. index ten başlayıp 9 eleman sayılık "Leo Alsaç" ifadesini yazdırı


            //"Hello!Hello!My name is Leo Alsaç"
            Console.WriteLine("Lower: " + sentence.ToLower()); // .ToLower metodu değişkendeki değerin tüm harfleri geçici olarak KÜÇÜK yazdırır "Lower: hello!hello!my name is leo alsaç"
            Console.WriteLine("Upper: " + sentence.ToUpper()); // .ToUpper metodu değişkendeki değerin tüm harfleri geçici olarak BÜYÜK yazdırır "Upper: HELLO!HELLO!MY NAME İS LEO ALSAÇ"

            Console.WriteLine(sentence.Replace(' ', '_'));               //.Replace metodu ile sentence değişkeni içindeki değerin
            Console.WriteLine(sentence.Replace("!", "*"));               // karakterlerini ve karakter dizilerini yani kelimeleri geçici
            Console.WriteLine(sentence.Replace("Hello!", "Merhaba!"));  // olarak değitirip yazdırabiliriz.Fakat kelime değişikliği yapacaksak
                                                                        // değişiklik yapılacak kelimeler ""çift tırnak içinde yazılır sadece karakter değişikliği
                                                                        // yapılacaksa '',"" tek veya çift tırnak kullanılabilir.


            //"Hello!Hello!My name is Leo Alsaç"    // .Remove metodu ile sentence değişkeni içindeki "Hello!"
            sentence = sentence.Remove(0, 6);       // kelimesinden 1 tanesi kalıcı olarak siler ama(0,6) şeklinde belirttiğimiz için 
            Console.WriteLine(sentence);            // ilk sırada index sayısı belirtip ikinci sıradada karakter sayısını 
                                                    // belirttiğimiz için sadece "Hello!" kelimesini sildi eğer ki sadece index numarasını belirleyip  
                                                    // karakter numarasını belirtmeseydik {0}. indexten başlayıp tüm cümleyi silerdi.



            //"Hello!My name is Leo Alsaç"
            string[] words = sentence.Split(' '); // .Split metodu string tipinde tanımlanmış sentence değişkenindeki
            foreach (string word in words)        // "Hello!My name is Leo Alsaç"cümlesindeki foreach döngüsü kullanarak
            {                                     // kelime kelime ayırmamızı sağlar ve yazdırır.
                Console.WriteLine(word);
            }
            Console.WriteLine(words[3]);

            string test1 = "test1";
            string test2 = "test2";
            if (test1 == test2)
            {
                Console.WriteLine("test1 ile test2 eşittir");
            }
            else
            {
                Console.WriteLine("test1 ile test2 eşit değildir");
            }

            if (test1.Equals(test2))                                // .Equals metodu değişkenler içindeki değerlerin
            {                                                       // eşit olup olmadığını kotrol edip yazdırır.
                Console.WriteLine("test1 ile test2 eşittir");       // Örnekte test1 ve test 2 içindeki değerlerin eşit
            }                                                       // olup olmama koşullarını if koşulu ile kontrol ettik
            else                                                    //ve "test1 ile test2 eşit değildir"şeklinde yazdırdık.
            {
                Console.WriteLine("test1 ile test2 eşit değildir");
            }
            
            string adSoyad = "    Çağıl Alsaç    ";                    // .Trim .TrimStart ve .TrimEnd metodları kullanıcının
            Console.WriteLine("\"" + adSoyad + "\"");                  // fazladan girmiş olduğu boşluk karakterlerini silmeye 
            Console.WriteLine("\"" + adSoyad.Trim() + "\"");           // yardımcı olur. Trim metodunun 3 farklı metodu vardır.
            Console.WriteLine("\"" + adSoyad.TrimStart() + "\"");      // .Trim kullanıcının girdiği boşluk karakterini sağdan ve soldan siler.
            Console.WriteLine("\"" + adSoyad.TrimEnd() + "\"");        // .TrimStart kullanıcının girdiği boşluk karakterlerinin başta olanlarını siler.
                                                                       // .TrimEnd kullanıcının girdiği boşluk karakterlerinin sonda olanlarını siler.                   
            
            Console.WriteLine(adSoyad.Contains("ğ") ? "ğ var" : "ğ yok"); //.Contains metodu değişkenler içinde metinsel bir ifadeyi
                                                                          // kelimeyi sorgulamak için kullanılır genellikle boolean 
                                                                          // değer döndüren(true,false) metodtur.
            string metin = "İyi akşamlar";
            bool sonuc1 = metin.Contains("akşamlar");   // .Contains metodu ile True yazdırır  
            Console.WriteLine(sonuc1);                  // metin değişkeninde "akşamlar" kelimesini içerir.
            
            bool sonuc2 = metin.Contains("Akşamlar");   // .Contains metodu ile False yazdırır 
            Console.WriteLine(sonuc2);                  // Çünkü büyük küçük harf duyarlılığından.

            // escape sequences
            string name = "Çağıl";
            string escapedName = "\"Çağıl\"";
            Console.WriteLine(escapedName);

            string surname = "Alsaç";
            escapedName = name + "\n" + surname;
            Console.WriteLine(escapedName);
            
            escapedName=name+"\t" + surname;
            Console.WriteLine(escapedName);

            string path1 = "D:\\yzl8523\\Console";
            Console.WriteLine(path1);
            path1 = @"D:\yzl8523\Console";
            Console.WriteLine(path1);


            
            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi);
            DateTime simdiUTC = DateTime.UtcNow;
            Console.WriteLine(simdiUTC);
            
            Console.WriteLine(simdi.ToShortDateString());
            Console.WriteLine(simdi.ToLongDateString());
            Console.WriteLine(simdi.ToShortTimeString());
            Console.WriteLine(simdi.ToLongTimeString());

            Console.WriteLine(simdi.ToShortDateString()+" "+simdi.ToLongTimeString());
            Console.WriteLine(simdi.Month+"/"+simdi.Day+"/"+simdi.Year+" "+simdi.Hour+":"+simdi.Minute+":"+simdi.Second+":"+simdi.Minute+":"+simdi.Millisecond);

            DateTime tarih = new DateTime(2020, 11, 28, 19, 17, 0); // (Yıl,Ay,Gün,Saat-Saat,Dakika,Saniye)28.11.2020 19:17:00 yazdırır.
            Console.WriteLine(tarih);


            tarih = DateTime.Parse("04.12.2021", new CultureInfo("en")); //en (12.04.2021)
            Console.WriteLine(tarih);
            tarih = DateTime.Parse("04/13/2021 16:01:25", new CultureInfo("en")); // (4/13/2021 4:01:25 PM)
            string tarihText = tarih.ToString(new CultureInfo("en"));
            Console.WriteLine(tarihText);
            tarihText = tarih.ToString("yyyy-MM-dd HH:mm:ss"); // (2021-04-13 16:01:25)
            Console.WriteLine(tarihText);

            simdi = DateTime.Now;
            Console.WriteLine("Yarın:"+simdi.AddDays(1));
            Console.WriteLine("1 hafta öncesi:"+simdi.AddDays(-7));
            Console.WriteLine("6 ay sonrası:"+simdi.AddMonths(6).ToShortDateString());
            Console.WriteLine("2 sene sonrası:"+simdi.AddYears(2).ToLongDateString());
            Console.WriteLine("12 saat sonrası:"+simdi.AddHours(12));
            Console.WriteLine("Yarım saat öncesi:"+simdi.AddMinutes(-30));

            var tarih1 = DateTime.Parse("01.10.2020");
            var tarih2 = DateTime.Parse("20.10.2020");
            if (tarih2.CompareTo(tarih1) > 0)
                Console.WriteLine("tarih2 > tarih1");
            else if (tarih2.CompareTo(tarih1) < 0)
                Console.WriteLine("tarih2 < tarih1");
            else if(tarih2.CompareTo(tarih1) == 0)
                Console.WriteLine("tarih2 = tarih");
            
            var harf1 = "A";
            var harf2 = "B";
            var kelime1 = "insan";
            var kelime2 = "insan";
            var buyuk = "insaN";
            var kucuk = "insan";
            Console.WriteLine(string.Compare(harf1,harf2));        // string.Compare metodu karakterleri sayısal değerlerine göre karşılaştırır (A>B)= -1
            Console.WriteLine(string.Compare(harf2,harf1));        // string.Compare metodu karakterleri sayısal değerlerine göre karşılaştırır (B>A)= 1 
            Console.WriteLine(string.Compare(kelime1,kelime2));    // string.Compare metodu karakterleri sayısal değerlerine göre karşılaştırır (insan=insan)=0
            Console.WriteLine(string.Compare(buyuk,kucuk,true));   // Büyük harf küçük harften sayısal değer olarak büyüktür ama 3. parametre olarak true belirtirsek
                                                                   // büyük küçük harf ayrımı yapmaz 0 yazdırır
            Console.WriteLine(string.Compare(buyuk,0,kucuk,0,5));  // buyuk içindeki değeri küçük içindeki değer ile 0.indexten başlar kontrol eder 5. harf buyuk 
                                                                   // olduğundan 1 yazdırır

            if (tarih > tarih1)
                Console.WriteLine("tarih2 > tarih1");
            else if(tarih2 < tarih1)
                Console.WriteLine("tarih2 < tarih1");
            else if(tarih2 == tarih1)
                Console.WriteLine("tarih2 = tarih1");

            Console.WriteLine(simdi.Date);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(simdi.DayOfWeek+" "+(int)simdi.DayOfWeek);
            Console.WriteLine(simdi.DayOfYear);
            Console.WriteLine(simdi.Ticks);


            Console.WriteLine("PI:"+Math.PI);       // .PI metodu net pi sayısını(PI:3,14159265358979) kullanarak işlem yaptırır
            int sayi1 = 10;
            int sayi2 = 20;
            Console.WriteLine("Sonuç:"+(sayi1-sayi2)+", Mutlak Değer:"+Math.Abs(sayi1-sayi2)); //.Abs metodu girilen sayının mutlak değerini aldırır
            
            double sayi = 2.9;
            Console.WriteLine((int)sayi);           // Aşağı yuvarlar (2)
            
            Console.WriteLine(Math.Floor(sayi));    //.Floor metodu taban değere yuvarlar (2)
            Console.WriteLine(Math.Ceiling(sayi));  //.Ceiling metodu tavan değere yuvarlar (3)
            
            Console.WriteLine(Math.Pow(2,4));       // .Pow metodu girilen sayının  kuvvetini hesaplatır Math.Pow(2,4)=16
            Console.WriteLine(Math.Pow(sayi1,2));   // .Math.Pow(sayi1,2)=100 sayi1 in 2.kuvvetini alır 
            
            Console.WriteLine(Math.Min(1,2)+"-"+Math.Max(1.1,2.2)); // .Min ve .Max metotları girilen sayının tam sayı veya ondalıklı sayı
                                                                    // olup olmadığı farketmeksizin sayının min veya max değerini verir

            double sayi3 = 12.34501;
            double sayi4 = 98.76500;
            Console.WriteLine(Math.Round(sayi3));       // NOT: Her rakam kendinden sonra gelen rakama göre şekillenir
            Console.WriteLine(Math.Round(sayi4));       // gelen rakam 5 e eşit veya 5 ten büyükse kendisini bi üst rakama yuvarlar
            Console.WriteLine(Math.Round(sayi3, 1));
            Console.WriteLine(Math.Round(sayi4, 1));
            Console.WriteLine(Math.Round(sayi3, 2));
            Console.WriteLine(Math.Round(sayi4, 2));
            
            Console.WriteLine(Math.Sqrt(64));         // .Sqrt metodu girilen sayının karekökünü alır (8) yazdırır
            Console.WriteLine(Math.Sqrt(63));         // (7,93725393319377) yazdırır
            //8^(1/3)=2
            Console.WriteLine(Math.Pow(8,1.0/3.0));

            Console.ReadLine();

            
        }
    }
}
