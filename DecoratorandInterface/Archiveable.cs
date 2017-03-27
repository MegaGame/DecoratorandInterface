using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorandInterface
{
    public class Archiveable : Decorator
    {
        protected List<string> archives = new List<string>();
        // Constructor
        public Archiveable(LibraryItem libraryItem) : base(libraryItem)
        {

        }
        public void ArchiveItem(string archiveName)
        {
            archives.Add(archiveName);
            libraryItem.NumCopies--;
        }
        public void ReturnItem(string archiveName)
        {
            archives.Remove(archiveName);
            libraryItem.NumCopies++;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" Number of copies archived: " + archives.Count);
            foreach (string archive in archives)
            {
                Console.WriteLine(" archive: " + archive);
            }
        }
    }
}
