namespace CompanyExercise;

public class Employee
{
    private string Name { get;  set; }
    private int Hours { get; set; }
    private double ValuePerHour { get; set; }

    public string name
    {
        get { return Name; }
        set { Name = value; }
    }

    public int hours
    {
        get { return Hours; }
        set { Hours = value; }
    }

    public double valuePerHour
    {
        get { return ValuePerHour; }
        set { ValuePerHour = value; }
    }
    
    public virtual double payment()
    {
        return Hours * ValuePerHour;
    }
}