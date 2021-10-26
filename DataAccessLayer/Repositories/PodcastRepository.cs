using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nya_projektet_Grupp_18_C_Projekt.Models;
using DataAccessLayer;

namespace DataAccessLayer.Repositories
{
    public class PodcastRepository : IRepository<Podcast>
    {
        SerializerForXml dataManager;
        List<Podcast> podcastList;

        public PodcastRepository()
        {
            dataManager = new SerializerForXml();
            podcastList = new List<Podcast>();
            podcastList = GetAll();
        }

        public void Create(Podcast entity)
        {
            podcastList.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            podcastList.RemoveAt(index);
            SaveChanges();
        }

        public void SaveChanges()
        {
            dataManager.Serialize(podcastList);
        }

        public void Update(int index, Podcast entity)
        {
            if (index >= 0)
            {
                podcastList[index] = entity;
                SaveChanges();
            }
        }

        public List<Podcast> GetAll()
        {
            List<Podcast> podcastListDeserialized = new List<Podcast>();
            try
            {
                podcastListDeserialized = dataManager.Deserialize();
            }
            catch (Exception)
            {

            }
            return podcastListDeserialized;
        }
    }
}
