namespace Lab4_2;

internal static class Program
{
    private static void Main(string[] args)
    {
        Pupil[] pupils =
        {
            new GoodPupil("Вася", 5),
            new BadPupil("Петя", 3),
            new ExcelentPupil("Коля", 4)
        };

        ClassRoom classRoom = new(pupils);
        classRoom.Study();
        classRoom.Read();
        classRoom.Write();
        classRoom.Relax();
    }
}