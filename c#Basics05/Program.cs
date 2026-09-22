using System.ComponentModel;

namespace c_Basics05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            //Book p = new Book();
            //'Book.password' is inaccessible due to its protection level ظهر هذا الخطأ بسبب ان المتغير password معرف ك private داخل الكلاس Book و لا يمكن الوصول اليه من خارج الكلاس.

            //Console.WriteLine($"the password is: = {p.password}");
            #endregion
            #region question 2
            //Book book = new Book();
            //Console.WriteLine($"copies in stock: = {book.CopiesInstock}");
            ////تمت الطباعه لان scope المتغير CopiesInstock معرف ك internal داخل الكلاس Book و يمكن الوصول اليه من نفس المشروع.

            #endregion
            #region question 3
            Book book3 = new Book();
            book3.Title = "atomic habbit";
            Console.WriteLine($"the title is: = {book3.Title}");    
            #endregion


        }
    }
}
