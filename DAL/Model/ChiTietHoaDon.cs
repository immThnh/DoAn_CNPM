namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Linq;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int IDMonAn { get; set; }

        public int IDHoaDon { get; set; }

        public int SoLuong { get; set; }

        public double TongTien { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual MonAn MonAn { get; set; }

        public string CustomDisplay
        {
            get
            {
                return MonAn.Ten + " - Số lượng: " + SoLuong;
            }
        }

    }
}
