using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Nya_projektet_Grupp_18_C_Projekt.Models
{
    [XmlInclude(typeof(Podcast))]
    public abstract class Feed
    {
        public string Url { get; set; }
        public string Namn { get; set; }
        public List<Avsnitt> PodcastAvsnitt { get; set; }
        public string UppdateringsIntervall { get; set; }
        public string Kategori { get; set; }
        public Feed(string url)
        {
            Url = url;
        }



        public virtual void a()
        {

        }
    }
}
