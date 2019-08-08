using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elementi.DataLayer.Models
{
    public class ElementP
    {
        public int ElementPId { get; set; }        
        public int RedniBroj { get; set; }
        public string IdentifikacioniKod { get; set; }
        public ICollection<ElementC> Elementi { get; set; }
        public ICollection<Pretraga> Pretrage { get; set; }
        public ElementP()
        {
            Elementi = new HashSet<ElementC>();
            Pretrage = new HashSet<Pretraga>();
        }

        public override string ToString()
        {
            return String.Format("ElementP ima Id: {0}, redniBroj: {1}, IdentifikacioniKod: {2}.", ElementPId, RedniBroj, IdentifikacioniKod);
        }
    }
}
