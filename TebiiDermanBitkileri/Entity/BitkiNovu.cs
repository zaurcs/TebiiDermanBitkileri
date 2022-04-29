using System.Collections.Generic;

namespace TebiiDermanBitkileri.Entity
{
    public class BitkiNovu
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Bitki> Bitkiler { get; set; }
    }
}
