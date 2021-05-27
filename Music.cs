using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace dbMusic
{
    class Music
    {
        [BsonId]
        public Object Id { get; set; }


        [BsonElement("executor")]
        [BsonIgnoreIfNull]
        public String Executor { get; set; }


        [BsonElement("album")]
        [BsonIgnoreIfNull]
       
        public string Album { get; set; }


        [BsonElement("country")]
        [BsonIgnoreIfNull]
       
        public string Country { get; set; }


        [BsonElement("date")]
        [BsonIgnoreIfNull]
        public string Date { get; set; }

       
        [BsonElement("lenght")]
        [BsonIgnoreIfNull]
        public string Lenght { get; set; }

        


        [BsonElement("song")]
        [BsonIgnoreIfNull]
        public string Song { get; set; }

        [BsonElement("style")]
        [BsonIgnoreIfNull]
        public string Style { get; set; }

    

        public Music(string id, string executor, string album, string country, string date, string lenght, string song, string style)
        {

            Id = id;
            Executor = executor;
            Album = album;
            Country = country;
            Date = date;
            Lenght = lenght;
            Song = song;
            Style = style;
        }



    }
}
