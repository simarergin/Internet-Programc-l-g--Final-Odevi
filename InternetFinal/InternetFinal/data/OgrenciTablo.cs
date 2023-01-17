using System;
using System.Collections.Generic;

namespace InternetFinal.data
{
    public partial class OgrenciTablo
    {
        public OgrenciTablo()
        {
            OgrenciDersTablos = new HashSet<OgrenciDersTablo>();
        }

        public int Id { get; set; }
        public string AdSoyad { get; set; } = null!;
        public int KayitTarih { get; set; }
        public int OgrenciNo { get; set; }
        public DateTime? Dtarih { get; set; }
        public string Bolum { get; set; } = null!;

        public virtual ICollection<OgrenciDersTablo> OgrenciDersTablos { get; set; }
    }
}
