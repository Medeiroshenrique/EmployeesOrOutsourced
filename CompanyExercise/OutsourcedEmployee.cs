namespace CompanyExercise;

public class OutsourcedEmployee : Employee
{
    private double additionalCharge
    {
        get { return additionalCharge;}
        set { additionalCharge = 1.1; }
    }

    public override double payment()
    {
        base.payment();
        return payment() + (payment() * additionalCharge);
    }
}