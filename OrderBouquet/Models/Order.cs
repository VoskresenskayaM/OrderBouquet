using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderBouquet.Models
{
    public class Order : BaseEntity
    
       
    {
        public virtual Bouquet Bouquet { get; set; }
        public virtual User User { get; set; }
        //букет id? 
        public int BouquetId { get; set; }
        public int UserId { get; set; }

        public DateTime time { get; set; }
        public int Phone { get; set; }
        public string Adress { get; set; }
    }
}
