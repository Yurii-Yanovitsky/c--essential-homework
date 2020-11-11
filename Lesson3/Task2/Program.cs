using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pupil> pupils = new List<Pupil>()
            {
                new ExcelentPupil("Excelent Erick"),
                new GoodPupil("Good John"),
                new BadPupil("Bad Vasya"),
                new GoodPupil("Good Kolya")
            };

            ClassRoom classRoom = new ClassRoom(pupils);
            classRoom.ShowInfo();

            Console.ReadKey();
        }
    }
}
