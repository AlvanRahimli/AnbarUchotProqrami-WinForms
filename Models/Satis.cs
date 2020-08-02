using System;
using System.Collections.Generic;

namespace AnbarUchotu.Models
{
    public class Satis
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int CemiQiymet { get; set; }
        public DateTime SatisTarixi { get; set; }
        public Musteri Musteri { get; set; }
        public List<SatilmisMal> Mallar { get; set; }
    }
}
