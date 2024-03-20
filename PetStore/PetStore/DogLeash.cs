using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore 
{
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public int LengthOutches { get; set;} //:D IntelliCode reccomeded I add this property after I added LengthInches
        public string Material { get; set; }
    }
}
