namespace ValidationAttributes.Attributes;

public class MyRangeAttribute : MyValidationAttribute
{
    private readonly int minValue;
    private readonly int maxValue;
    public MyRangeAttribute(int minValue, int maxValue)
    {
        this.minValue = minValue;
        this.maxValue = maxValue;
    }

    public override bool IsValid(object obj)
        => obj is int num && this.minValue <= num && num <= this.maxValue;
}

