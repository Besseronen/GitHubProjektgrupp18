using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nya_projektet_Grupp_18_C_Projekt.Models
{
       public class Podcast : Feed
        {
            public Podcast(Kategori kategori, int uppdateringsIntervall) :
                base(kategori, uppdateringsIntervall)
            {

            }

        }
}
