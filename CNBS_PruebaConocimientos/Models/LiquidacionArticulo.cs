using System;

namespace CNBS_PruebaConocimientos.Models // Asegúrate de que el namespace es correcto
{
    public class LiquidacionArticulo
    {
        public string Iliq { get; set; }
        public int Nart { get; set; }
        public string Clqatax { get; set; }
        public string Clqatyp { get; set; }
        public decimal Mlqabas { get; set; }
        public decimal Qlqacoefic { get; set; }
        public decimal Mlqa { get; set; }
    }
}
