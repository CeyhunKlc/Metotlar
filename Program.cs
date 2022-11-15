using System;

namespace metotlar
{
    class program
    {
        static void Main(string[]args)
        {
            // erişim_belirteci geri_donuctipi metot_adi(parametreListesi/arguman)
            //{ 
                ////komutlar;
                //return;
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc= Topla( a,b);
            Console.WriteLine(sonuc);

            metotlar ornek = new metotlar();
            ornek.ekranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);


            
            ornek.ekranaYazdir(Convert.ToString(sonuc2));
            ornek.ekranaYazdir(Convert.ToString(a+b));
        }

         static int Topla ( int deger1, int deger2)
         { 
            return(deger1+deger2);
         }

    }  


    class metotlar
    { 
         public void ekranaYazdir(string veri)
         { 
            Console.WriteLine(veri);
         }

        public int ArttirVeTopla( ref int deger1, ref int deger2)
        { 
            deger1+=1;
            deger2+=1;
            return deger1+ deger2;
        }
                   
        
    }

}   