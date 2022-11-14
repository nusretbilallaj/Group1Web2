namespace Group1Web2.Models
{
    public class Profesori
    {
        public Profesori(string emri,string mbiemri)
        {
            Emri=emri;
            Mbiemri=mbiemri;
        }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

    }
}
