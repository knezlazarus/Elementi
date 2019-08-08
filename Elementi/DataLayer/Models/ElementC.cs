using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elementi.DataLayer.Models
{
    public class ElementC
    {
        public int ElementCId { get; set; }
        public char Grupa { get; set; }
        public int Vrednost { get; set; }
        public ElementP ElementP { get; set; }
    }
}
