using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnbarUchotu.Models
{
    public class Mal
    {
        public int Id { get; set; }
        public string MalAdi { get; set; }
        public string Qablasma { get; set; }
        public int Miqdar { get; set; }
        public int BirEdedinQiymeti { get; set; }
        public int YekunQiymet { get; set; }
        public DateTime Istehsal { get; set; }
        public DateTime SonIstifade { get; set; }
    }
}
