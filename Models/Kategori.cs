using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nya_projektet_Grupp_18_C_Projekt.Models
{
    public class Kategori
    {
        string namn;
        int antalPodcasts;


        public Kategori(string namn)
        {
            antalPodcasts = 0;
            Namn = namn;
        }

        public string Namn { get; set; }
        public int AntalPodcasts { get; set; }
    }
}
