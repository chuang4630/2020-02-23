using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTitle.Api.Models;
using MongoDB.Driver;
using MongoDB.Bson;


namespace WebTitle.Api.Services
{
    public class MediaTitleService
    {
        private readonly IMongoCollection<Title> _titles;

        public MediaTitleService(IMediaTitlesDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _titles = database.GetCollection<Title>(settings.MediaTitlesCollectionName);
        }

        public List<Title> Get() =>
            _titles.Find(_ => true).ToList();






        public Title Get(string id) =>
            _titles.Find<Title>(media => media.Id == id).FirstOrDefault();

        public Title GetByTitleId(long id) =>
            _titles.Find<Title>(media => media.TitleId == id).FirstOrDefault();

        public Title GetByName(string name) =>
            _titles.Find<Title>(media => media.TitleName.ToLower().Contains(name.ToLower())).FirstOrDefault();

            


        public List<Title> GetTitlesByName(string name)
        {
            List<Title> titles = new List<Title>();
            string s = name.ToLower();

            foreach(Title title in _titles.Find(_ => true).ToList())
            {
                if (title.TitleName.ToLower().Contains(s))
                {
                    titles.Add(title);
                    continue;
                }
                
                foreach(OtherName other in title.OtherNames)
                {
                    if (other.TitleName.ToLower().Contains(s))
                    {
                        titles.Add(title);
                        break;
                    }
                }
            }
            return titles;
        }
            



        public Title Create(Title title)
        {
            _titles.InsertOne(title);
            return title;
        }

        public void Update(int id, Title titleIn) =>
            _titles.ReplaceOne(media => media.TitleId == id, titleIn);

        public void Remove(Title titleIn) =>
             _titles.DeleteOne(media => media.TitleId == titleIn.TitleId);

        public void Remove(int id) =>
             _titles.DeleteOne(media => media.TitleId == id);


    }
}
