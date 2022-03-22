using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArabaÖTVKDV.OTVV
{
    public class OTV : IDisposable
    {
        public int fiyat;
        public int sonuc;
        public string islemtipi;
        public string islemtipii;
        

        public OTV(string radio ,int fiyat,string islemtipi, string islemtipii)
        {
            switch (radio)
            {
                case "Otomobil":
                    if (islemtipi == "1600 cm kadar") 
                    {
                        sonuc = fiyat * 45 / 100; 
                    }
                    else if (islemtipi == "1601 cm ile 2000 cm arası")
                    {
                        sonuc = fiyat * 50 / 100;
                    }
                    else if (islemtipi == "2001 cm üzeri")
                    {
                        sonuc = fiyat * 80 / 100;
                    } 

                    break;
                case "Otobüs": 
                    if (islemtipi == "1600 cm kadar")
                    {
                        sonuc = fiyat * 45 / 100;
                    }
                    else if (islemtipi == "1601 cm ile 2000 cm arası")
                    {
                        sonuc = fiyat * 50 / 100;
                    }
                    else if (islemtipi == "2001 cm üzeri")
                    {
                        sonuc = fiyat * 80 / 100;
                    }
                    
                    break;
                case "Motorsiklet": 
                    if (islemtipii == "250 geçmeyen")
                    {
                        sonuc = fiyat * 8 / 100;
                    }
                    else if (islemtipii == "250 geçen")
                    {
                        sonuc = fiyat * 37 / 100;
                    }

                   
                    break;
                default:
                    break;
            }
            

        }

        public void Dispose()
        {
           // throw new NotImplementedException();
        }
    }
}
