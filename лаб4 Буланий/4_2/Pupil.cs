namespace Lab4_2;

/// <summary>
///     This class is used to create a new instance of a student
/// </summary>
internal class Pupil
{
    /// <summary>
    ///     <see cref="Pupil" /> constructor.
    /// </summary>
    /// <param name="name">
    ///     <see cref="Pupil" /> name.
    /// </param>
    /// <param name="averageMark">
    ///     <see cref="Pupil" /> average mark.
    /// </param>
    public Pupil(string name, decimal averageMark)
    {
        Name = name;
        AverageMark = averageMark;
    }

    /// <summary>
    ///     Parameterless constructor
    /// </summary>
    public Pupil()
    {
    }

    /// <summary>
    ///     Gets or sets the name of the pupil.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     Gets or sets the average mark of the pupil.
    /// </summary>
    public decimal AverageMark { get; set; }

    public virtual void Study()
    {
        Console.WriteLine("I'm studying");
        Console.WriteLine(ToString());
    }

    public virtual void Read()
    {
        Console.WriteLine("I'm reading");
    }

    public virtual void Write()
    {
        Console.WriteLine("I'm writing");
    }

    public virtual void Relax()
    {
        Console.WriteLine("I'm relaxing");
    }

    /// <inheritdoc />
    public override string ToString() => $"Name: {Name}, AverageMark: {AverageMark}";
}