using System;
using System.Collections.Generic;
using System.Linq;
using Elementi.DataLayer.Models;

namespace Elementi.DataLayer.Services
{
    public class PretragaService
    {
        private ElementiContext _context;
        public PretragaService(ElementiContext ctx)
        {
            _context = ctx;
        }

        public void KreirajElementP(Pretraga pretraga)
        {
            _context.Pretrage.Add(pretraga);
            _context.SaveChanges();
        }

        public Pretraga PribaviPretragu(int id)
        {
            return _context.Pretrage.FirstOrDefault(el => el.PretragaId == id);
        }

        public Pretraga PribaviPretraguPoVremenu(DateTime vreme)
        {
            return _context.Pretrage.FirstOrDefault(el => el.VremePretrage == vreme);
        }

        public List<ElementP> SviElementiPPretragePoVremenu(DateTime vremePretrage)
        {
            return _context.Pretrage.Where(el => el.VremePretrage == vremePretrage).SelectMany(el => el.PronadjeniElementi).ToList();
        }
    }
}
