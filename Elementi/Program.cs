using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Elementi.DataLayer;
using Elementi.DataLayer.Models;
using Elementi.DataLayer.Services;

namespace Elementi
{
    class Program
    {
        List<ElementP> elementi = new List<ElementP>();
        public static ElementPService _elementPService;
        public static ElementCService _elementCService;
        public static PretragaService _pretragaService;

        static void Main(string[] args)
        {
            try
            {
                var ctx = new ElementiContext();

                _elementPService = new ElementPService(ctx);
                _pretragaService = new PretragaService(ctx);
                _elementCService = new ElementCService(ctx);

                Random rnd = new Random();

                int n = 0;
                int k = 0;
                int p = 0;

                int brojPretraga = 0;

                Console.WriteLine("Unesite zeljeni broj elemenata tipa ElementP.");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Unesite zeljeni broj elemenata tipa ElementC.");
                k = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string idenTifikacioniKod = String.Format("elementp_{0}", i);
                    ElementP elP = new ElementP() { IdentifikacioniKod = idenTifikacioniKod, RedniBroj = i };          

                    for (int j = 0; j < k; j++)
                    {
                        char grupa = (char)rnd.Next(97, 122);
                        int vrednost = rnd.Next(1, 9);

                        ElementC elC = new ElementC() { Grupa = grupa, Vrednost = vrednost };
                        elP.Elementi.Add(elC);
                    }

                    _elementPService.KreirajElementP(elP);
                }

                Console.WriteLine("Unesite zeljeni broj pretraga: ");
                brojPretraga = Convert.ToInt32(Console.ReadLine());

                for (int i=0; i< brojPretraga; i++)
                {
                    Console.WriteLine("Unesite zeljeni prag za koji će se vršiti pretraga Elemenata P  po sumi njihovih članova ElementC");
                    p = Convert.ToInt32(Console.ReadLine());

                    List<DataLayer.Models.ElementP> elementiP = _elementPService.VratiSvePSaSumomCVecomOd(p);

                    Pretraga pret = new Pretraga() { VremePretrage = DateTime.Now };
                    foreach (var el in elementiP)
                    {
                        pret.PronadjeniElementi.Add(el);
                    }

                    _pretragaService.KreirajElementP(pret);
                }
                                                          
                ctx.Dispose();
            } 
            catch (Exception e)
            {

            }
        }
    }
}
