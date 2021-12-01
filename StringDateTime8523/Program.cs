using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            string subSentence3 = sentence.Substring(23, 9);   // .Substring metotudunun burdaki kullanımı sentence.Substring(23,19)
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
            
            Console.WriteLine(simdi.ToShortDateString());
            Console.WriteLine(simdi.ToLongDateString());
            Console.WriteLine(simdi.ToShortTimeString());
            Console.WriteLine(simdi.ToLongTimeString());

            Console.WriteLine(simdi.ToShortDateString()+" "+simdi.ToLongTimeString());
            Console.WriteLine(simdi.Month+"/"+simdi.Day+"/"+simdi.Year+" "+simdi.Hour+":"+simdi.Minute+":"+simdi.Second+":"+simdi.Minute+":"+simdi.Millisecond);

            DateTime tarih = new DateTime(2020, 11, 28, 19, 17, 0); // 28.11.2020 19:17:00 yazdırır.
            Console.WriteLine(tarih);

            Console.ReadLine();
     
        }
    }
}
