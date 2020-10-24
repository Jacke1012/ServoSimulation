

public class MotorPair
{
    public MotorModule[] motorPair;

    public MotorPair(MotorModule[] motorPair)
    {
        this.motorPair = motorPair;
    }

    public void Turn(int angle)
    {
        for (int i = 0; i < motorPair.Length ; i++)
        {
            motorPair[i].SetSpeed(angle);
        }
    }
}