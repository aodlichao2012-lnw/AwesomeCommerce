using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entite
{
    public class Product
    {
        public Product(int id ) {
        
            Id = id;    
        }

        public int Id { get; private set; }
    }
    public enum Cartegory {

        [EnumMember(Value ="00")]
        none = 0,
        [EnumMember(Value = "01")]
        normal,
        [EnumMember(Value = "02")]
        hard
    }
}
