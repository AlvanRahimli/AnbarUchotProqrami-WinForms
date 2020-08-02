using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AnbarUchotu.Models
{
    public class SatilmisMal
    {
        public int Id { get; set; }
        public int MalId { get; set; }
        public string MalAdi { get; set; }
        public int SatisId { get; set; }
        public int SatilanMiqdar { get; set; }

        [NotMapped]
        public int YekunQiymet
        {
            get
            {
                return Mal.SatisQiymeti * SatilanMiqdar;
            }
        }
        //[NotMapped]
        //public int YekunSatisQiymeti
        //{
        //    get
        //    {
        //        return Mal.SatisQiymeti * SatilanMiqdar;
        //    }
        //}
        public Satis Satis { get; set; }
        public Mal Mal { get; set; }
    }
}
