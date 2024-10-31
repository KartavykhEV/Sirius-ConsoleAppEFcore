using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEFcore
{
    internal class Program
    {

        static string[] genders = new[] { "male", "female" }; 


        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                //foreach (var gender in genders)
                //    if (!context.genders.Any(i => i.Name == gender))
                //    {
                //        context.genders.Add(new ConsoleAppEFcore.gender { Name = gender });
                //        context.SaveChanges();
                //    }

                //var p = new person()
                //{
                //    FName = "Иван",
                //    LName = "Антонов",
                //    BDay = new DateTime(2006, 1, 1)
                //};

                //context.persons.Add(p);
                //context.SaveChanges();
                context.persons.First().genderId = 1;
                context.SaveChanges();

                var pList = context.persons.ToArray();


                var item = context.persons.FirstOrDefault(i => i.Id == 1);
                item.BDay = new DateTime(1988, 1, 1);
                context.SaveChanges();  
                Console.WriteLine(item);

            }
            Console.ReadLine();

        }
    }
}
