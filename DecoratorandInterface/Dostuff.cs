using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorandInterface
{
    public class DoStuff : LibraryInterface
    {
        public void ArchiveItem(LibraryItem item, string archive)
        {
           
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
            throw new NotImplementedException();
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
