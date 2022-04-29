using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TebiiDermanBitkileri.DB;
using TebiiDermanBitkileri.Entity;

namespace TebiiDermanBitkileri.Models
{
    public class EntityViewModel
    {
        public ApplicationDBContext context;
        public IEnumerable<Bitki> Bitkiler { get; set; }
        public IEnumerable<BitkiNovu> BitkiNovleri { get; set; }

        public EntityViewModel(ApplicationDBContext context)
        {
            this.context = context;
            this.Bitkiler = context.Bitkiler;
            this.BitkiNovleri = context.BitkiNovleri;
        }
    }
}