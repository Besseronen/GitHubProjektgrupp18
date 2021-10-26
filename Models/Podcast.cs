using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nya_projektet_Grupp_18_C_Projekt.Models
{
       public class Podcast : Feed
        {
            public Podcast(string url, string uppdateringsIntervall, string kategori) :
                base(kategori, uppdateringsIntervall)
            {
                
            }

        }
}
