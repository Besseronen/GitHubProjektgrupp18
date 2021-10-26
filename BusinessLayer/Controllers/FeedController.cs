using System;
using System.Collections.Generic;
using System.Text;
using Nya_projektet_Grupp_18_C_Projekt.Models;
using DataAccessLayer.Repositories;


namespace BusinessLayer.Controllers
{
    public class FeedController
    {
        IRepository<Podcast> podcastRepository;
        

        public FeedController()
        {
            podcastRepository = new PodcastRepository();
        }

        public void CreatePodcast(string url, string uppdateringsIntervall, string kategori)
        {
            Podcast nyPodd = null;
            nyPodd = new Podcast;
            podcastRepository.Create(nyPodd);
        }

    }
}

