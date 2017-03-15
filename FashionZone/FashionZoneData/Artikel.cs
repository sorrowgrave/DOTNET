namespace FashionZoneData
{
    public class Artikel
    {
        public int Id { get; set; }
        public string Artikelnr { get; set; }
        public string Merk { get; set; }
        public string Artikelnaam { get; set; }
        public string Categorie { get; set; }
        public string Datum { get; set; }
        public string Kleur { get; set; }
        public decimal AKprijs { get; set; }
        public decimal VKprijs { get; set; }
        public byte Aantal { get; set; }
        public string Bonnr { get; set; }
        public decimal TotAKprijs { get; set; }
        public decimal TotVKprijs { get; set; }
        public bool Afgerond { get; set; }


    }
}
