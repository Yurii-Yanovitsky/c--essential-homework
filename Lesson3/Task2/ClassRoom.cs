using System;
using System.Collections.Generic;

namespace Task2
{
    public class ClassRoom
    {
        private List<Pupil> _pupils;

        public ClassRoom(List<Pupil> pupils)
        {
            _pupils = pupils;
        }

        public void ShowInfo()
        {
            foreach (Pupil pupil in _pupils)
            {
                Console.WriteLine(pupil.Name);
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }
}
