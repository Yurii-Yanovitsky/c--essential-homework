namespace Task2
{
    public static class MelodyParser
    {
        public static Note[] ParseMelody(string melody)
        {
            Note[] noteArray = new Note[melody.Length];

            for (int i = 0; i < melody.Length; i++)
            {
                char note = melody[i];
                switch (note)
                {
                    case '0':
                        noteArray[i] = Note.CreatDo(2, 500);
                        break;
                    case '1':
                        noteArray[i] = Note.CreatRe(2, 500);
                        break;
                    case '2':
                        noteArray[i] = Note.CreatMi(2, 500);
                        break;
                    case '3':
                        noteArray[i] = Note.CreatFa(2, 500);
                        break;
                    case '4':
                        noteArray[i] = Note.CreatSol(2, 500);
                        break;
                    case '5':
                        noteArray[i] = Note.CreatLya(2, 500);
                        break;
                    case '6':
                        noteArray[i] = Note.CreatSi(2, 500);
                        break;
                    case '7':
                        noteArray[i] = Note.CreatRe(2, 500);
                        break;
                    case '8':
                        noteArray[i] = Note.CreatMi(2, 500);
                        break;
                    case '9':
                        noteArray[i] = Note.CreatFa(2, 500);
                        break;
                    default: noteArray[i] = new Note(true);
                        break;
                }
            }
            return noteArray;
        }
    }
}
