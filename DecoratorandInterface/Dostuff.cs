using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorandInterface
{
    public class DoStuff : LibraryInterface
    {
        public LibraryItem ArchiveItem(LibraryItem item, string archive)
        {
            if (item.GetType() == typeof(Archiveable))
            {
                ((Archiveable)item).ArchiveItem(archive);
            }
            return item;
        }
        public LibraryItem BorrowItem(LibraryItem item, string name)
        {           
            if (item.GetType() == typeof (Borrowable))
            {
                ((Borrowable)item).BorrowItem(name);
            }
            return item;
        }

        public LibraryItem CreateBook(string author, string title, int numCopies)
        {
            return new Book(author, title, numCopies);
        }

        public LibraryItem CreateVideo(string director, string title, int numCopies, int playTime)
        {
            return new Video(director, title, numCopies, playTime);
        }

        public void Display(LibraryItem item)
        {
            item.Display();
        }

        public LibraryItem MakeArchievable(LibraryItem item)
        {
            return new Archiveable(item);
        }

        public LibraryItem MakeBorrowable(LibraryItem item)
        {
            return new Borrowable(item);
        }

        public void ReturnItem(LibraryItem item, string name)
        {
            throw new NotImplementedException();
        }
    }
}
