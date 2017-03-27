using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorandInterface
{
    public interface LibraryInterface
    {
        LibraryItem CreateBook(string author, string title, int numCopies);
        LibraryItem CreateVideo(string director, string title, int numCopies, int playTime);
        LibraryItem MakeBorrowable(LibraryItem item);
        LibraryItem MakeArchievable(LibraryItem item);
        LibraryItem BorrowItem(LibraryItem item, string name);
        void ReturnItem(LibraryItem item, string name);
        LibraryItem ArchiveItem(LibraryItem item, string archive);
        void Display(LibraryItem item);

    }
}
