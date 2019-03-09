using System;
using System.Collections.Generic;

namespace ISPLibrary
{
    public class DVD : IBorrowableDVD
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public int CheckoutDurationInDays { get; set; } = 14;
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime List<string> Actors { get; set; }
        public int RunTimeInMinutes { get; set; }

        public void CheckOut(string borrower) {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }
        public void CheckIn()
        {
            Borrower = "";
        }
        
        public DateTime GetDueDate() {
            return BorrowDate.AddDays(CheckoutDurationInDays);
        }
    }
}
