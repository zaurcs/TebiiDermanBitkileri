namespace TebiiDermanBitkileri.Entity.Helpers
{
    public class XestelikSimptom
    {
        public int XestelikId { get; set; }
        public Xestelik Xestelik { get; set; }
        public int SimptomId { get; set; }
        public Simptom Simptom { get; set; }
    }
}
