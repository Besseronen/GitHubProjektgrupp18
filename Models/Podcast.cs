using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nya_projektet_Grupp_18_C_Projekt.Models
{
    public class Podcast : Feed
    {
        public int Avsnitt { get; set; }
        public string Namn { get; set; }
        public string UppdateringsIntervall { get; set; }
        public string Kategori { get; set; }
        public List<Avsnitt> PodcastAvsnitt { get; set; }
        public Podcast(string url, int Avsnitt, string namn, string uppdateringsIntervall, string kategori, List<Avsnitt> PodcastAvsnitt) :
            base(url)
        {
            Namn = namn;
            UppdateringsIntervall = uppdateringsIntervall;
            Kategori = kategori;
            
        }

     }
}
