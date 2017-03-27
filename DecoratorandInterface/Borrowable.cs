using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorandInterface
{
    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        // Constructor
        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {

        }
        public void BorrowItem(string name)
        {
            borrowers.Add(name);
        }
        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" Number of copies availble: " + (libraryItem.NumCopies - borrowers.Count));
            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
            Console.WriteLine();

        }

    }
}
