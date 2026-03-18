using NUnit.Framework;
using LibraryManagementLib;
using System.Linq;

namespace LibraryManagementTests
{
    public class LibraryTests
    {
        private Library _library;

        [SetUp]
        public void Setup()
        {
            _library = new Library();
        }

        [Test]
        public void AddBook_ShouldAddBookToLibrary() 
        {
            var book = new Book { Title = "C# Basics", Author = "John Doe", ISBN = "12345" };
            _library.AddBook(book);
            Assert.AreEqual(1, _library.Books.Count);
        }

        [Test]
        public void RegisterBorrower_ShouldRegisterSuccessfully() 
        {
            var borrower = new Borrower { Name = "Alice", LibraryCardNumber = "L001" };
            _library.RegisterBorrower(borrower);
            Assert.AreEqual(1, _library.Borrowers.Count);
        }

        [Test]
        public void BorrowBook_ShouldMarkAsBorrowedAndAssignToBorrower() 
        {
            var book = new Book { Title = "C# Basics", Author = "John Doe", ISBN = "12345" };
            var borrower = new Borrower { Name = "Alice", LibraryCardNumber = "L001" };

            _library.AddBook(book);
            _library.RegisterBorrower(borrower);
            _library.BorrowBook("12345", "L001");

            Assert.IsTrue(book.IsBorrowed);
            Assert.AreEqual(1, borrower.BorrowedBooks.Count);
        }

        [Test]
        public void ReturnBook_ShouldMarkAsAvailableAndRemoveFromBorrower() 
        {
            var book = new Book { Title = "C# Basics", Author = "John Doe", ISBN = "12345" };
            var borrower = new Borrower { Name = "Alice", LibraryCardNumber = "L001" };

            _library.AddBook(book);
            _library.RegisterBorrower(borrower);
            _library.BorrowBook("12345", "L001");

           
            _library.ReturnBook("12345", "L001");

            Assert.IsFalse(book.IsBorrowed);
            Assert.AreEqual(0, borrower.BorrowedBooks.Count);
        }
    }
}