using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_4.DTO
{
    class BookDTO
    {
        private int bookID;
        private string bookName;
        private float bookPrice;
        public BookDTO()
        {

        }

        public BookDTO(int bookID, string bookName, float bookPrice)
        {
            this.bookID = bookID;
            this.bookName = bookName;
            this.bookPrice = bookPrice;
        }

        public int BookID { get => bookID; set => bookID = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public float BookPrice { get => bookPrice; set => bookPrice = value; }
    }
}
