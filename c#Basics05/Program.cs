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
            //Book book3 = new Book();
            //book3.Title = "atomic habbit";
            //Console.WriteLine($"the title is: = {book3.Title}");    
            #endregion
            #region question 4
            //Book book4 = new Book();
            //book4.BookGenre = Genre.Science;
            //Console.WriteLine($"the genre is: = {book4.BookGenre}");
            #endregion
            #region question 5
            //Console.WriteLine($"Fiction value: {(int)Genre.Fiction}");
            //Console.WriteLine($"NonFiction value: {(int)Genre.NonFiction}");
            //Console.WriteLine($"Science value: {(int)Genre.Science}");
            #endregion
            #region question 6
            //int genrenumber = 1;
            //genre mygenre = (genre)genrenumber;
            //console.writeline($"the genre for number {genrenumber} is: {mygenre}");
            #endregion
            #region question 7
            //Genre genre = Genre.Fiction;
            //string genreString = genre.ToString();
            //Console.WriteLine($"The string value is: {genreString}");
            #endregion
            #region question 8
            string genreText = "Science";
            Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine($"Parsed Genre: {parsedGenre}"); 
            #endregion

            









        }
    }
}
