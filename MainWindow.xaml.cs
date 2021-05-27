using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Console;

namespace dbMusic
{




        public partial class MainWindow : Window
        {

        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("local");
        static IMongoCollection<Music> collection = db.GetCollection<Music>("musicColection");


        public void ReadAllDocument()
        {
            List<Music> list = collection.AsQueryable().ToList<Music>();
            dgMusic.ItemsSource = list;
            Music music = (Music)dgMusic.Items.GetItemAt(0);
            id_tb.Text = music.Id.ToString();
            executor_tb.Text = music.Executor;
            album_tb.Text = music.Album;
            song_tb.Text = music.Song;
            lenght_tb.Text = music.Lenght;
            date_tb.Text = music.Date;
            style_tb.Text = music.Style;
            country_tb.Text = music.Country;


        }

            public MainWindow()
            {
                InitializeComponent();
                ReadAllDocument();
            }

        private void dgMusic_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Music music = (Music)dgMusic.SelectedItem;
            id_tb.Text = music.Id.ToString();
            executor_tb.Text = music.Executor;
            album_tb.Text = music.Album;
            song_tb.Text = music.Song;
            lenght_tb.Text = music.Lenght;
            date_tb.Text = music.Date;
            style_tb.Text = music.Style;
            country_tb.Text = music.Country;
        }



        private void add_Click(object sender, RoutedEventArgs e)
        {                           
            Music music = new Music(id_tb.Text, executor_tb.Text, album_tb.Text, country_tb.Text, date_tb.Text, lenght_tb.Text, song_tb.Text, style_tb.Text);
            collection.InsertOne(music);
            ReadAllDocument();
        }




        private void update_Click(object sender, RoutedEventArgs e)
        {
            var updateDef = Builders<Music>.Update
                .Set("id", id_tb)
                .Set("executor", executor_tb)
                .Set("album", album_tb)
                .Set("country", country_tb)
                .Set("date", date_tb)
                .Set("lenght", lenght_tb)
                .Set("song", song_tb)
                .Set("style", style_tb);

            //collection.UpdateOne(music => music.Id == ObjectId.Parse(id_tb.Text), updateDef);
            //ReadAllDocument();
        }


        private void delete_Click(object sender, RoutedEventArgs e)
        {
            //collection.DeleteOne(music => music.Id == ObjectId.Parse(id_tb.Text));
            //ReadAllDocument();
        }



    }
   
}
