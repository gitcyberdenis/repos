namespace Lab4_2;

internal class ClassRoom
{
    public ClassRoom(params Pupil[] pupils) => Pupils = pupils;

    public IEnumerable<Pupil> Pupils { get; }

    public void Study()
    {
        foreach (Pupil pupil in Pupils)
        {
            pupil.Study();
        }
    }

    public void Read()
    {
        foreach (Pupil pupil in Pupils)
        {
            pupil.Read();
        }
    }

    public void Write()
    {
        foreach (Pupil pupil in Pupils)
        {
            pupil.Write();
        }
    }

    public void Relax()
    {
        foreach (Pupil pupil in Pupils)
        {
            pupil.Relax();
        }
    }
}