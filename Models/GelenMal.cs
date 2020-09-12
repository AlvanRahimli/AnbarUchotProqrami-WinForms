using System;
using System.Collections.Generic;
using System.Text;

namespace AnbarUchotu.Models
{
    public class GelenMal
    {
        public int Id { get; set; }
        public int MalId { get; set; }
        public DateTime Date { get; set; }
        public int GelenSay { get; set; }

        public Mal Mal { get; set; }
    }
}
