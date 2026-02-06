class Lasagna
{
    private const float PreparationMinutesPerLayer = 2.0f;

    public float ExpectedMinutesInOven()
    {
        return 40.0f;
    }

    public float RemainingMinutesInOven(float currentMinutesInOven)
    {
        return ExpectedMinutesInOven() - currentMinutesInOven;
    }

    public float PreparationTimeInMinutes(int layers)
    {
        return layers*PreparationMinutesPerLayer;
    }

    public float ElapsedTimeInMinutes(int layers, float currentMinutesInOven)
    {
        return PreparationTimeInMinutes(layers) + currentMinutesInOven;
    }
}
