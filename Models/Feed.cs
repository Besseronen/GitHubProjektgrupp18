using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Nya_projektet_Grupp_18_C_Projekt.Models
{
    [XmlInclude(typeof(Podcast))]
    public class Feed
    {
        public Feed(Kategori kategori, int uppdateringsIntervall)
        {
            UppdateringsIntervall = uppdateringsIntervall;
        }

        public string Namn { get; set; }
        public int UppdateringsIntervall { get; set; }
        public int AntalAvsnitt { get; set; }
        public string Kategori { get; set; }

        public virtual void a()
        {

        }
    }
}
