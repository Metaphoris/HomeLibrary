using System;
using DomainModel;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLiteratureBooks();
            PrintReferences();

            Console.ReadLine();
        }

        public static void PrintLiteratureBooks()
        {
            using (var context = new ApplicationContext())
            {
                foreach(LiteratureBook bb in context.LiteratureBook
                    .Include(b => b.Author)
                    .Include(b => b.CoverType)
                    .Include(b => b.PageSize)
                    .Include(b => b.Country)
                    .Include(b => b.Publisher)
                    .Include(b => b.Age)
                    .Include(b => b.Literature)
                        .ThenInclude(bc => ((SingleLiterature)bc).Genre)
                    .Include(b => b.Literature)
                        .ThenInclude(bc => ((SingleLiterature)bc).Form)
                    .Include(b => b.Literature)
                        .ThenInclude(bc => ((PartSingleLiterature)bc).NextBook)
                    .Include(b => b.Literature)
                        .ThenInclude(bc => ((PartSingleLiterature)bc).PrevBook)
                    .Include(b => b.Literature)
                        .ThenInclude(bc => ((CollectionLiterature)bc).Collection))
                {
                    Console.WriteLine(bb);
                }
            }
        }

        public static void PrintReferences()
        {
            using (var ac = new ApplicationContext())
            {
                #region General
                Console.WriteLine("Авторы:");
                foreach (var a in ac.Author)
                    Console.WriteLine(a);
                Console.WriteLine();

                Console.WriteLine("Страны:");
                foreach (var c in ac.Country)
                    Console.WriteLine(c);
                Console.WriteLine();

                Console.WriteLine("Тип обложки:");
                foreach (var c in ac.CoverType)
                    Console.WriteLine(c);
                Console.WriteLine();

                Console.WriteLine("Языки:");
                foreach (var l in ac.Language)
                    Console.WriteLine(l);
                Console.WriteLine();

                Console.WriteLine("Размеры страницы:");
                foreach (var p in ac.PageSize)
                    Console.WriteLine(p);
                Console.WriteLine();

                Console.WriteLine("Издательства:");
                foreach (var p in ac.Publisher)
                    Console.WriteLine(p);
                Console.WriteLine();
                #endregion

                #region Belletristic
                Console.WriteLine("Возрасты:");
                foreach (var a in ac.Age)
                    Console.WriteLine(a);
                Console.WriteLine();

                Console.WriteLine("Форма художественного произведения:");
                foreach (var f in ac.Form)
                    Console.WriteLine(f);
                Console.WriteLine();

                Console.WriteLine("Жанры:");
                foreach (var g in ac.Genre)
                    Console.WriteLine(g);
                Console.WriteLine();
                #endregion

                #region Educational
                Console.WriteLine("Области:");
                foreach (var d in ac.Discipline)
                    Console.WriteLine(d);
                Console.WriteLine();
                #endregion
            };
        }
    }
}