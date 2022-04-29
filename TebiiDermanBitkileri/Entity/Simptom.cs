using System.Collections.Generic;
using TebiiDermanBitkileri.Entity.Helpers;

namespace TebiiDermanBitkileri.Entity
{
    public class Simptom
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<XestelikSimptom> XestelikSimptom { get; set; }
    }
}
