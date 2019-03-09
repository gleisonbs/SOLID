using System;

namespace ISPLibrary
{
    public interface IBorrowable
    {
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckoutDurationInDays { get; set; }

        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
