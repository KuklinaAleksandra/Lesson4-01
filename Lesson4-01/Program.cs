using System;

namespace Lesson4_01
{
    using System;

    namespace Lesson4_1
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine(GetFullName("Александр", "Сергеевич", "Пушкин"));
                Console.WriteLine(GetFullName("Лев", "Николаевич", "Толстой"));
                Console.WriteLine(GetFullName("Антон", "Павлович", "Чехов"));

                Console.WriteLine();
            }

            static string GetFullName(string firstName, string patronymic, string lastName)
            {


                return $"{lastName} {firstName} {patronymic}";
            }

        }
    }

}
