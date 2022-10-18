namespace Lab4_2;

internal class BadPupil : Pupil
{
    /// <inheritdoc />
    public BadPupil(string name, decimal averageMark) : base(name, averageMark)
    {
    }

    /// <inheritdoc />
    public BadPupil()
    {
    }

    #region Overrides of Pupil

    /// <inheritdoc />
    public override void Study()
    {
        base.Study();
        Console.WriteLine("BadPupil Study");
    }

    #endregion

    public override void Read()
    {
        Console.WriteLine("I'm reading bad");
    }

    public override void Write()
    {
        Console.WriteLine("I'm writing bad");
    }

    public override void Relax()
    {
        Console.WriteLine("I'm relaxing bad");
    }
}