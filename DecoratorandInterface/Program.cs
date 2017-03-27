using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorandInterface
{
    class Program
    {
        static void Main()
        {
            /*
            
            Archiveable archiveableVideo = new Archiveable(borrowvideo);
            archiveableVideo.ArchiveItem("Old Archive");
            archiveableVideo.ArchiveItem("Ancient Archive");
            
            archiveableVideo.Display();           
            */
            Program p = new Program();
            p.run();
            Console.ReadKey();
        }
        public void run()
        {
            DoStuff ds = new DoStuff();
            LibraryItem book = ds.CreateBook("Worley", "Inside ASP.NET", 10);
            ds.Display(book);
            LibraryItem video = ds.CreateVideo("Spielberg", "Jaws", 23, 92);
            ds.Display(video);
            Console.WriteLine("\nMaking video borrowable:");
            video = ds.MakeBorrowable(video);
            video = ds.BorrowItem(video, "Customer #1");
            video = ds.BorrowItem(video, "Customer #2");
            ds.Display(video);


        }
    }
}
