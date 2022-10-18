namespace Lab4_2;

internal class GoodPupil : Pupil
{
    /// <inheritdoc />
    public GoodPupil(string name, decimal averageMark) : base(name, averageMark)
    {
    }

    /// <inheritdoc />
    public GoodPupil()
    {
    }

    #region Overrides of Pupil

    /// <inheritdoc />
    public override void Study()
    {
        base.Study();
        Console.WriteLine("GoodPupil Study");
    }

    #endregion

    public override void Read()
    {
        Console.WriteLine("I'm reading good");
    }

    public override void Write()
    {
        Console.WriteLine("I'm writing good");
    }

    public override void Relax()
    {
        Console.WriteLine("I'm relaxing good");
    }
}