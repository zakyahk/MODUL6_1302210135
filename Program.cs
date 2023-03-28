using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL6_1302210135
{

    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title) {
            Random random = new Random();
            id = random.Next(10000, 99999);
            this.title = title;
            playCount= 0;
        }

        public int IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public int getPlayCount()
        {
            return this.playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }



    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string nama)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.Username = nama;
            uploadedVideos = new List<SayaTubeVideo>();
        }

         public int GetTotalVideoPlayCount()
        {
            return this.uploadedVideos.Count;
        }

        public void AddVideo(SayaTubeUser video)
        {
            
        }

        public void PrintAllVideoPlaycount()
        {

        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + Username);
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video: " + (i + 1) + "judul: " + uploadedVideos[i]);
            }
        }
    }

    class program
    {
        public static void Main(string[] args)
        {
            SayaTubeVideo v1 = new SayaTubeVideo("Bismillah");
            SayaTubeVideo v2 = new SayaTubeVideo("Masih Puasa");
            SayaTubeVideo v3 = new SayaTubeVideo("Bentar Lagi Buka");
            SayaTubeVideo v4 = new SayaTubeVideo("Harus Sabar");
            SayaTubeVideo v5 = new SayaTubeVideo("Nanti Dapat Makan Gratis");
            SayaTubeVideo v6 = new SayaTubeVideo("Harus Sabar");
            SayaTubeVideo v7 = new SayaTubeVideo("Nanti Makan Enak");
            SayaTubeVideo v8 = new SayaTubeVideo("Sabar Bro");
            SayaTubeVideo v9 = new SayaTubeVideo("Nanti Juga Buka");
            SayaTubeVideo v10 = new SayaTubeVideo("Harus Kuat Imannya");
            v1.IncreasePlayCount();
            v2.IncreasePlayCount();
            v3.IncreasePlayCount();
            v4.IncreasePlayCount();
            v5.IncreasePlayCount();
            v6.IncreasePlayCount();
            v7.IncreasePlayCount();
            v8.IncreasePlayCount();
            v9.IncreasePlayCount();
            v10.IncreasePlayCount();
            v1.PrintVideoDetails();
            v2.PrintVideoDetails();
            v3.PrintVideoDetails();
            v4.PrintVideoDetails();
            v5.PrintVideoDetails();
            v6.PrintVideoDetails();
            v7.PrintVideoDetails();
            v8.PrintVideoDetails();
            v9.PrintVideoDetails();
            v10.PrintVideoDetails();

            SayaTubeVideo user = new SayaTubeUser("Zakkiya");
            user.AddVideo(v1);
            user.AddVideo(v2);
            user.AddVideo(v3);
            user.AddVideo(v4);
            user.AddVideo(v5);
            user.AddVideo(v6);
            user.AddVideo(v7);
            user.AddVideo(v8);
            user.AddVideo(v9);
            user.AddVideo(v10);
            user.PrintAllVideoPlayCount();
            Console.WriteLine();
        }
    }
}
