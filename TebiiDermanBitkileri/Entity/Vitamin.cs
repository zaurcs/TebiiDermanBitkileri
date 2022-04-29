using System.Collections.Generic;
using TebiiDermanBitkileri.Entity.Helpers;

namespace TebiiDermanBitkileri.Entity
{
    public class Vitamin
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<BitkiVitamin> BitkiVitamin { get; set; }
    }
}
