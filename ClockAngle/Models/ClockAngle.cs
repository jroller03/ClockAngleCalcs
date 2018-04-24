namespace ClockAngle
{
  public class ClockAngle
  {
    public float CalculateClockAngle(float hours, float minutes)
    {
      float Difference;
      float MinutesAngle = minutes * 6;
      float HoursAngle = hours * 30 + ((minutes/60)*30);

      if (MinutesAngle>HoursAngle){
        Difference=MinutesAngle-HoursAngle;
      } else{
        Difference=HoursAngle-MinutesAngle;
      }

      if (Difference>180)
      {
        return 360-Difference;
      } else{
        return Difference;
      }
    }
  }
}
