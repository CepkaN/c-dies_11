using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace c_dies_11
{
    public class Student
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
    }
    public struct Poezd
    {
        public int Numero { get; set; }
        public string Otprav { get; set; }
        public string Naznac { get; set; }
        public TimeOnly VrOtp;
        public TimeOnly VrPrib;
        public Poezd(int numero, string otprav, string naznac, int vrOtp1, int vrOtp2, int vrPrib1, int vrPrib2)
        {
            Numero = numero;
            Otprav = otprav;
            Naznac = naznac;
            VrOtp = new TimeOnly(vrOtp1,vrOtp2);
            VrPrib = new TimeOnly(vrPrib1,vrPrib2);
        }
        public void Info()
        {
            Console.WriteLine(" Номер поезда : " + Numero +
                "\n Место отправления : " + Otprav +
                "\n Место прибытия : " + Naznac +
                "\n Время отправления : " + VrOtp +
                "\n Время прибытия : " + VrPrib + "\n");
        }
        public void RealPrib()
        {
            Console.WriteLine(" Укажите, в котором часу прибыл поезд : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Укажите, скольео минут : ");
            int b=Convert.ToInt32(Console.ReadLine());
            if (VrPrib.Hour == a && VrPrib.Minute == b) { Console.WriteLine(" Поезд прибыл вовремя."); }
            if (VrPrib.Hour > a ) { Console.WriteLine($" Поезд прибыл раньше на {(VrPrib.Hour - a) * 60 + (VrPrib.Minute - b)} минут. ");return; }
            if (VrPrib.Hour < a) { Console.WriteLine($" Поезд прибыл раньше на {(a - VrPrib.Hour) * 60 + (VrPrib.Minute - b)} минут. "); return; }
            if (VrPrib.Hour == a && VrPrib.Minute > b) { Console.WriteLine($" Поезд прибыл раньше на { (VrPrib.Minute - b)} минут. "); return; }
            if (VrPrib.Hour == a && VrPrib.Minute < b) { Console.WriteLine($" Поезд прибыл позже на {(b - VrPrib.Minute)} минут. "); return; }


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ   -  для всего

            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

            // создаем новый список для результатов
            var selectedPeople = from p in people // передаем каждый элемент из people в переменную p
                                 where p.ToUpper().StartsWith("T") //фильтрация по критерию
                                 orderby p  // упорядочиваем по возрастанию
                                 select p; // выбираем объект в создаваемую коллекцию

            foreach (string person in selectedPeople)
                Console.WriteLine(person);
            Console.WriteLine();

            List<Student> students = new List<Student> {
            new Student{Name="Olga",Age=32,GPA=4.6},
            new Student{Name="Boris",Age=43,GPA=6.7},
            new Student{Name="Ivan",Age=23,GPA=5.5},
            new Student{Name="Alex",Age=16,GPA=8.7},
            new Student{Name="Marina",Age=56,GPA=3.1},

            };
            var selectedStudents = students.Where(s => s.GPA > 4.5 && s.Age < 25).Select(s => s.Name);

            foreach(var student in selectedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            //List<Poezd>poezds= new List<Poezd>();
            //Poezd poezd1 = new Poezd(111, "BRRR", "VRRR", 12, 40, 14, 50);
            //Poezd poezd2= new Poezd(65, "BRRR", "AAAAA", 12, 10, 15, 30);
            //Poezd poezd3 = new Poezd(45, "AAAAA", "NNNN", 12, 50, 13, 15);
            //Poezd poezd4 = new Poezd(123, "NNNN", "WWWWW", 15, 20, 17, 10);
            //Poezd poezd5 = new Poezd(7, "QQQ", "NNNN", 11, 20, 15, 30);

            //poezds.Add(poezd1);
            //poezds.Add(poezd2);
            //poezds.Add(poezd3);
            //poezds.Add(poezd4);
            //poezds.Add(poezd5);
            //int a = 0;
            //Console.WriteLine(" Вы хотите добавить поезд ? (нажмите 1) ");
            //while ((a=Convert.ToInt32(Console.ReadLine())) == 1)
            //{
            //    Console.WriteLine(" Введите номер : ");
            //    int numero= Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" Введите место оправления : ");
            //    string? otprav=Convert.ToString(Console.ReadLine());
            //    Console.WriteLine(" Введите место прибытия : ");
            //    string ?naznac = Convert.ToString(Console.ReadLine());
            //    Console.WriteLine(" Введите час отправления : ");
            //    int vrOtp1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" Введите минуты отправления : ");
            //    int vrOtp2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" Введите час прибытия : ");
            //    int vrPrib1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" Введите минуты прибытия : ");
            //    int vrPrib2 = Convert.ToInt32(Console.ReadLine()); ;
            //    Poezd poezd6 = new Poezd(numero,  otprav,  naznac,  vrOtp1,  vrOtp2,  vrPrib1,  vrPrib2);
            //    poezds.Add(poezd6);
            //    Console.WriteLine(" Вы хотите добавить поезд ? (нажмите 1) ");
            //}
            ////foreach (var f in poezds)
            ////{
            ////    f.Info();
            ////}
            //var selectedPoezd = from t in poezds
            //                     orderby t.Naznac
            //                    select t;
            //foreach (var t in selectedPoezd)
            //{
            //    t.Info();
            //}
            //Console.WriteLine(" Вы хотите найти поезд ? (нажмите 1)");
            //while ((a = Convert.ToInt32(Console.ReadLine())) == 1)
            //{
            //    Console.WriteLine(" Введите номер поезда : ");
            //    int v = Convert.ToInt32(Console.ReadLine());
            //    Poezd prem = selectedPoezd.FirstOrDefault(t => t.Numero == v);
            //    prem.Info();
            //    Console.WriteLine(" Вы хотите удалить поезд ? (нажмите 1)");
            //    if ((a = Convert.ToInt32(Console.ReadLine())) == 1) {
            //    foreach (var r in selectedPoezd)
            //    {
            //        if (r.Numero == prem.Numero)
            //        {
            //            poezds.Remove(prem);
            //            Console.WriteLine(" Поезд удалён.");
            //            break;
            //        }
            //    }
            //    selectedPoezd = from x in poezds
            //                    orderby x.Naznac
            //                    select x; }
            //    Console.WriteLine(" Вы хотите найти поезд ? (нажмите 1)");
            //}
            //foreach (var f in selectedPoezd)
            //{
            //    f.Info();
            //}

            string XmlString = "C:\\Users\\Ж - 6\\Documents\\Чеп\\c dies_11\\books.xml";
            XDocument doc = XDocument.Load(XmlString);

            var persons = from pe in doc.Descendants("book")
                          select new
                          {
                              title = Convert.ToString(pe.Element("title")?.Value),
                              author = Convert.ToString(pe.Element("author")?.Value),
                              year = Convert.ToString(pe.Element("year")?.Value),
                              genre = Convert.ToString(pe.Element("genre")?.Value)

                          };
            int a = 0;
           
            var selectedBooks = from s in persons
                                orderby s.title
                                select s;
          
            foreach (var df in selectedBooks)
            {
                ++a;
                Console.WriteLine(a);
                Console.WriteLine(" Название " + df.title);
                //Console.WriteLine(selectedBooks.author);
                //Console.WriteLine(selectedBooks.year);
                //Console.WriteLine(selectedBooks.genre);
                Console.WriteLine();

            }
            persons = selectedBooks;
            var selectedBooks1 = persons.Where(s => (Convert.ToInt32(s.year)) < 1900).Select(s=>s);

            Console.WriteLine("До 1900");
            foreach(var dd in selectedBooks1)
            {
                Console.WriteLine(dd.title);
            }

            //var listOfbook = bookList.OrderBy(t => t.Title);
            SortedSet<string> genres = new SortedSet<string>();

            foreach (var book in selectedBooks)
            {
                genres.Add(book.genre);
            }
            Console.WriteLine("Количество книг по жанрам:");
            foreach (string genre in genres)
            {
                Console.WriteLine("Количество книг в жанре " + genre + " равно " +
                    (from i in selectedBooks where i.genre == genre select i).Count());
            }
            var oldAuthors = from b in selectedBooks1 where (Convert.ToInt32(b.year)) < 1900 select b;
            Console.WriteLine("Список авторов с годом издания книг до 1900:");
            foreach (var author in oldAuthors)
            {
                Console.WriteLine(author.author);
            }
            var twoBooksAuthors = from b in selectedBooks1 group b by b.author into res where res.Count() >= 2 select res;
            Console.WriteLine("Список авторов у которых не менее 2-х книг:");
            foreach (var author in twoBooksAuthors)
            {
                Console.WriteLine(author.First().author);
            }
            var longTitle = from b in selectedBooks1 where b.title.Contains(" ") select b;
            Console.WriteLine("Количество книг с названиями, состоящими более чем из одного слова:" + longTitle.Count() + ", список этих книг:");
            foreach (var author in longTitle)
            {
                Console.WriteLine(author.title);
            }
            var newAuthors = from b in selectedBooks1 where ((Convert.ToInt32(b.year)) > 1940 && (Convert.ToInt32(b.year)) < 2000) select b;
            Console.WriteLine("Список авторов с годом издания книг между 1940 и 2000 годами:");
            foreach (var author in newAuthors)
            {
                Console.WriteLine(author);
            }
        }
    }
}