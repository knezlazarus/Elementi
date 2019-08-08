using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elementi.DataLayer.Models
{
    public class Pretraga
    {
        public int PretragaId { get; set; }
        public DateTime VremePretrage { get; set; }
        public ICollection<ElementP> PronadjeniElementi { get; set; }
        public Pretraga()
        {
            PronadjeniElementi = new HashSet<ElementP>();
        }
    }
}
