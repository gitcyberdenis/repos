namespace Lab4_2;

internal class ExcelentPupil : Pupil
{
    /// <inheritdoc />
    public ExcelentPupil(string name, decimal averageMark) : base(name, averageMark)
    {
    }

    /// <inheritdoc />
    public ExcelentPupil()
    {
    }

    #region Overrides of Pupil

    /// <inheritdoc />
    public override void Study()
    {
        base.Study();
        Console.WriteLine("Excellent study");
    }

    #endregion

    public override void Read()
    {
        Console.WriteLine("I'm reading very well");
    }

    public override void Write()
    {
        Console.WriteLine("I'm writing very well");
    }

    public override void Relax()
    {
        Console.WriteLine("I'm relaxing very well");
    }
}