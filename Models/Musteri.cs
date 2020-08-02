using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Windows.Forms;

namespace AnbarUchotu.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rayon { get; set; }
        public DateTime SonSatis { get; set; }
        public string Elaqe { get; set; }
        public int Borc { get; set; }
        public int SatisSayi { get; set; }
        public List<Satis> Satislar { get; set; }

        [NotMapped]
        public DateTime SonSatisTarixi
        {
            get
            {
                if (Satislar != null && Satislar.Count > 0)
                {
                    return Satislar.OrderByDescending(s => s.SatisTarixi).ToList()[0].SatisTarixi;
                }
                return DateTimePicker.MinimumDateTime;
            }
        }
    }
}
