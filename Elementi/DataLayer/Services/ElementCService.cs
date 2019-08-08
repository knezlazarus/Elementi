using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementi.DataLayer.Models;

namespace Elementi.DataLayer.Services
{
    public class ElementCService
    {
        private ElementiContext _context;

        public ElementCService(ElementiContext ctx)
        {
            _context = ctx;
        }

        public void KreirajElementC(ElementC element)
        {
            _context.ElementiC.Add(element);
            _context.SaveChanges();
        }

        public ElementC PribaviElementC (int id)
        {
            return _context.ElementiC.FirstOrDefault(el => el.ElementCId == id);
        }
    }
}
