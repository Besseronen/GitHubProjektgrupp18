using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using Nya_projektet_Grupp_18_C_Projekt.Models;
using DataAccessLayer.Exceptions;

namespace DataAccessLayer
{
    internal class SerializerForXml
    {
        public void Serialize(List<Podcast> podcastLista)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream outFile = new FileStream("Podcast.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, podcastLista);
                }
            }
            catch (Exception e)
            {
                throw new SerializerException("Podcast.xml", "Couldn't serialize the file");
            }
        }

        public List<Podcast> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream inFile = new FileStream("Podcast.xml", FileMode.Open, FileAccess.Read))
                {
                    return (List<Podcast>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception e)
            {
                throw new SerializerException("Podcast.xml", "Couldn't deserialize the file");
            }
        }
    }
}
