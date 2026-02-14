using System;

namespace BookStoreApplication
{
    public class BookUtility
    {
        private Book _book;

        public BookUtility(Book book)
        {
            // TODO: Assign book object
            this._book = book;
        }

        public void GetBookDetails()
        {
            // TODO:
            // Print format:
            // Details: <BookId> <Title> <Price> <Stock>
             Console.WriteLine($"Details: {_book.Id} {_book.Title} {_book.Price} {_book.Stock}");

        }

        public void UpdateBookPrice(int newPrice)
        {
            // TODO:
            // Validate new price
            _book.Price= newPrice;


            // Update price
            // Print: Updated Price: <newPrice>
            Console.WriteLine("updated Price:" + _book.Price);


        }

        public void UpdateBookStock(int newStock)
        {
            // TODO:
            // Validate new stock
            _book.Stock= newStock;
            // Update stock
            // Print: Updated Stock: <newStock>
            Console.WriteLine("newstock:"+_book.Stock);


        }
    }
}
