using System.Collections.Generic;
using TebiiDermanBitkileri.Entity.Helpers;

namespace TebiiDermanBitkileri.Entity
{
    public class Bitki
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Sekil { get; set; }
        public BitkiNovu BitkiNovu { get; set; }
        public int BitkiNovuId { get; set; }
        public List<BitkiVitamin> BitkiVitamin { get; set; }
        public List<BitkiXestelik> BitkiXestelik { get; set; }
    }
}
