using System;

namespace SeriesRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            int count_id = 0;
            SerieRepository repository = new SerieRepository();

            Console.Clear();
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Select an option:");

                Console.WriteLine("1- List series");
                Console.WriteLine("2- Insert new series");
                Console.WriteLine("3- Update series");
                Console.WriteLine("4- Delete series");
                Console.WriteLine("5- View series");
                Console.WriteLine("C- Clear screen");
                Console.WriteLine("0- Exit");
                Console.WriteLine();

                string UserOption = Console.ReadLine().ToUpper();

                if(UserOption == "1")
                {
                    Console.Clear();
                    var list = repository.List();
                    if(list.Count == 0)
                        Console.WriteLine("The list is empty");
                    else
                    {
                        foreach(Serie i in list) {
                            int aux = 0;
                            if(i.returnDeleted() == false)
                            {
                                aux++;
                                Console.WriteLine($"id: {i.returnId()} | Title: {i.returnTitle()}");
                            }
                            if(aux == 0)
                                Console.WriteLine("The list is empty");
                        }
                    }
                    //TODO
                }
                else if(UserOption == "2")
                {
                    Console.WriteLine("Genre: ");
                    Console.WriteLine("Select a genre:");

                    foreach(int i in Enum.GetValues(typeof(Genre)))
                        Console.WriteLine($"{i}- {Enum.GetName(typeof(Genre), i)}");
                    Console.WriteLine();

                    Genre genre = (Genre) Enum.Parse(typeof(Genre), Console.ReadLine());
                    Console.WriteLine();

                    Console.Write("Write the title: ");
                    string title = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Write the description: ");
                    string description = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Write the year: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Serie serie = new Serie(count_id, genre, title, description, year);
                    repository.Insert(serie);
                    Console.Clear();
                    Console.WriteLine("Series sucessfully added!");
                    count_id++;
                }
                else if(UserOption == "3")
                {
                    Console.Write("Insert the id you want to update: ");
                    int id = int.Parse(Console.ReadLine());


                    Console.WriteLine("Genre: ");
                    Console.WriteLine("Select a genre:");

                    foreach(int i in Enum.GetValues(typeof(Genre)))
                        Console.WriteLine($"{i}- {Enum.GetName(typeof(Genre), i)}");

                    Genre genre = (Genre) Enum.Parse(typeof(Genre), Console.ReadLine());
                    Console.WriteLine();

                    Console.Write("Write the title: ");
                    string title = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Write the description: ");
                    string description = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Write the year: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Serie edit_obj = new Serie(id, genre, title, description, year);
                    repository.Update(id, edit_obj);
                }
                else if(UserOption == "4")
                {
                    Console.Write("Insert the id you want to delete: ");
                    int id = int.Parse(Console.ReadLine());
                    repository.Delete(id);
                    Console.Clear();
                    Console.WriteLine("Series successfully deleted!");
                }
                else if(UserOption == "5")
                {
                    Console.Write("Insert the id to view series details: ");
                    int id = int.Parse(Console.ReadLine());
                    var obj = repository.ReturnsById(id);
                    Console.Clear();
                    Console.Write(obj);
                }
                else if(UserOption == "C")
                {
                    Console.Clear();
                }
                else if(UserOption == "0")
                {
                    break;
                }
            }
        }
    }
}
