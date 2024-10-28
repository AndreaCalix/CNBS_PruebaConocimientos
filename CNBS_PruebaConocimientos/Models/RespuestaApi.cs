public class RespuestaApi
{
    public List<Articulo> ART { get; set; }
    public DDT DDT { get; set; }
    public Liquidacion LIQ { get; set; }
    public List<LiquidacionArticulo> LQA { get; set; }
}

public class Articulo
{
    public string Iddt { get; set; }
    public int Nart { get; set; }
    public string Carttyp { get; set; }
    public string Codbenef { get; set; }
    public string Cartetamrc { get; set; }
    public string Iespnce { get; set; }
    public string Cartdesc { get; set; }
    public string Cartpayori { get; set; }
    public string Cartpayacq { get; set; }
    public string Cartpayprc { get; set; }
    public string Iddtapu { get; set; }
    public int? Nartapu { get; set; }
    public decimal Qartbul { get; set; }
    public decimal Martunitar { get; set; }
    public string Cartuntdcl { get; set; }
    public int Qartuntdcl { get; set; }
    public string Cartuntest { get; set; }
    public decimal Qartuntest { get; set; }
    public decimal Qartkgrbrt { get; set; }
    public decimal Qartkgrnet { get; set; }
    public decimal Martfob { get; set; }
    public decimal Martfobdol { get; set; }
    public string Martfle { get; set; }
    public string Martass { get; set; }
    public string Martemma { get; set; }
    public decimal Martfrai { get; set; }
    public string Martajuinc { get; set; }
    public string Martajuded { get; set; }
    public decimal Martbasimp { get; set; }
}

public class DDT
{
    public string Iddtextr { get; set; }
    public int Cddtver { get; set; }
    public string Iddtext { get; set; }
    public string Iddt { get; set; }
    public string Iext { get; set; }
    public string Cddteta { get; set; }
    public DateTime Dddtoficia { get; set; }
    public DateTime? Dddtrectifa { get; set; }
    public string Cddtcirvis { get; set; }
    public decimal Qddttaxchg { get; set; }
    public string Ista { get; set; }
    public string Cddtbur { get; set; }
    public string Cddtburdst { get; set; }
    public string Cddtdep { get; set; }
    public string Cddtentrep { get; set; }
    public string Cddtage { get; set; }
    public string Nddtimmioe { get; set; }
    public string Lddtnomioe { get; set; }
    public string Cddtagr { get; set; }
    public string Lddtagr { get; set; }
    public string Cddtpayori { get; set; }
    public string Cddtpaidst { get; set; }
    public string Lddtnomfod { get; set; }
    public string Cddtincote { get; set; }
    public string Cddtdevfob { get; set; }
    public string Cddtdevfle { get; set; }
    public string Cddtdevass { get; set; }
    public string Cddttransp { get; set; }
    public string Cddtmdetrn { get; set; }
    public string Cddtpaytrn { get; set; }
    public int Nddtart { get; set; }
    public int Nddtdelai { get; set; }
    public DateTime Dddtbae { get; set; }
    public DateTime? Dddtsalida { get; set; }
    public DateTime? Dddtcancel { get; set; }
    public DateTime? Dddtechean { get; set; }
    public string Cddtobs { get; set; }
}

public class Liquidacion
{
    public string Iliq { get; set; }
    public string Cliqdop { get; set; }
    public string Cliqeta { get; set; }
    public decimal Mliq { get; set; }
    public decimal Mliqgar { get; set; }
    public string? Dlippay { get; set; }
    public string Clipnomope { get; set; }
}

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
