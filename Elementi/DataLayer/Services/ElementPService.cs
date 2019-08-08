using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementi.DataLayer.Models;

namespace Elementi.DataLayer.Services
{
    public class ElementPService
    {
        private ElementiContext _context;

        public ElementPService(ElementiContext ctx)
        {
            _context = ctx;
        }

        public void KreirajElementP(ElementP element)
        {
            _context.ElementiP.Add(element);
            _context.SaveChanges();
        }

        public ElementP PribaviElementP(int id)
        {
            ElementP element = _context.ElementiP.FirstOrDefault(el => el.ElementPId == id);
            Console.WriteLine(element.ToString());

            return element; 
        }

        public ElementP PribaviElementPPoIdKodu (string identifikacioniKod)
        {
            ElementP pronadjeniElement = _context.ElementiP.FirstOrDefault(el => el.IdentifikacioniKod == identifikacioniKod);

            return pronadjeniElement;
        }     

        public List<ElementP> VratiSvePSaSumomCVecomOd (int p)
        {
            return _context.ElementiP.Where(el => el.Elementi.Sum(elC => elC.Vrednost) > p).ToList();
        }
    }
}
