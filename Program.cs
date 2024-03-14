using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EF_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model1Container connection = new Model1Container();
            //connection.autorsSet.Add(new autors() { age = 10, autorName = "Oleg", autorSurname = "Nagornyi" });
            //connection.SaveChanges();
            //connection.languagesSet.Add(new languages() { languageName = "UA", countryesId = 1 });
            //connection.countryesSet.Add(new countryes() { country = "Ukraine" });
            //connection.Library.Add(new books() { bookName = "Warriors", autorsId = 1, page_count = 101, languagesId = 1 });
            //connection.SaveChanges();



            // EXCERSISE 1
            //var query = connection.Library.Where(p => p.page_count > 100);
            //Console.OutputEncoding = Encoding.UTF8;
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Book :: {item.bookName,10} {item.page_count,10} Autor name {item.autors.autorName,10} Autor Surname {item.autors.autorSurname,10}");
            //}



            // EXCERSISE 2
            //var query = connection.Library.Where(b => b.bookName.StartsWith("A") || b.bookName.StartsWith("a"));
            //Console.OutputEncoding = Encoding.UTF8;
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Book :: {item.bookName,10} {item.page_count,10} Autor name {item.autors.autorName,10} Autor Surname {item.autors.autorSurname,10}");
            //}



            // EXCERSISE 3
            //foreach (var item in connection.Library.Include(nameof(books.autors)).Where(s => s.autors.autorName == "William" && s.autors.autorSurname == "Shakespeare")) 
            //{
            //    Console.WriteLine($"Book :: {item.bookName,10} {item.page_count,10} Autor name {item.autors.autorName,10} Autor Surname {item.autors.autorSurname,10}");
            //}



            // EXCERSISE 4
            //foreach (var item in connection.Library.Include(nameof(books.languages)).Where(s => s.languages.languageName == "UA"))
            //{
            //    Console.WriteLine($"Book :: {item.bookName,10} {item.page_count,10} Autor name {item.autors.autorName,10} Autor Surname {item.autors.autorSurname,10}");
            //}



            // EXCERSISE 5
            //var query = connection.Library.Where(b => b.bookName.Length < 10);
            //Console.OutputEncoding = Encoding.UTF8;
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Book :: {item.bookName,10} {item.page_count,10} Autor name {item.autors.autorName,10} Autor Surname {item.autors.autorSurname,10}");
            //}




            // EXCERSISE 6
            //var bookWithMaxPages = connection.Library.Include(b => b.languages).Where(b => b.languages.languageName == "UA").OrderByDescending(b => b.page_count).FirstOrDefault();
            //Console.WriteLine($"Book :: {bookWithMaxPages.bookName,10} {bookWithMaxPages.page_count,10} Autor name {bookWithMaxPages.autors.autorName,10} Autor Surname {bookWithMaxPages.autors.autorSurname,10}");



            // EXCERSISE 7
            //var authorWithFewestBooks = connection.autorsSet.GroupBy(a => a.Id).Select(g => new
            //                                                                                {
            //                                                                                    AuthorId = g.Key,
            //                                                                                    BookCount = g.Count() 
            //                                                                                }).OrderBy(a => a.BookCount) .FirstOrDefault();
            //var author = connection.autorsSet.FirstOrDefault(a => a.Id == authorWithFewestBooks.AuthorId);
            //Console.WriteLine($"Autor name {author.autorName,10} Autor Surname {author.autorSurname,10}");



            // Exersise 8
            //var authorsNotAmerican = connection.autorsSet.Where(a => !a.books.Any(b => b.languages.languageName == "USA")).OrderBy(a => a.autorName).Select(a => new
            //                                            {
            //                                                AuthorName = a.autorName,
            //                                                BookTitles = a.books.Select(b => b.bookName)
            //                                            }).ToList();
            //foreach (var author in authorsNotAmerican)
            //{
            //    Console.WriteLine($"Author: {author.AuthorName}");
            //    Console.WriteLine("Books:");
            //    foreach (var title in author.BookTitles)
            //    {
            //        Console.WriteLine($"- {title}");
            //    }
            //    Console.WriteLine();
            //}




            // EXCERSISE 9
            //var authorWithFewestBooks = connection.languagesSet.GroupBy(a => a.Id).Select(g => new
            //{
            //    languagesId = g.Key,
            //    countBooks = g.Count()
            //}).OrderBy(a => a.countBooks).FirstOrDefault();
            //var answer = connection.languagesSet.FirstOrDefault(a => a.Id == authorWithFewestBooks.languagesId);
            //Console.WriteLine($"Country is {answer.countryes.country}");



            // EXCERSISE 10
            var autor = connection.autorsSet.Select(a => new
            {
                autorNamr = a.autorName,
                uniqLanguage = a.books.Select(b => b.languages.languageName).Distinct().Count()
            }).OrderBy(c => c.uniqLanguage).ToList();
            foreach (var author in autor)
            {
                Console.WriteLine($"Author: {author.autorNamr}");
                Console.WriteLine($"Number of unique languages: {author.uniqLanguage}:");
                Console.WriteLine();
            }
        }
    }
}
