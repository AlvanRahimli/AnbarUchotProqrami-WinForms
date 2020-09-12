using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnbarUchotu.Models
{
    public class Mal
    {
        public int Id { get; set; }
        public string MalAdi { get; set; }
        public string Qablasma { get; set; }
        public int AnbardakiMiqdar { get; set; }
        public int AlisQiymeti { get; set; }
        public int SatisQiymeti { get; set; }
        [NotMapped]
        public int YekunQiymet
        {
            get
            {
                return AlisQiymeti * AnbardakiMiqdar;
            }
        }
        public DateTime Istehsal { get; set; }
        public DateTime SonIstifade { get; set; }
        public List<SatilmisMal> SatilmisMallar { get; set; }
        public List<GelenMal> GelenMallar { get; set; }
    }
}
