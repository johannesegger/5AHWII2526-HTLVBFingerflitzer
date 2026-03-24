internal class HTLVBTimeProvider : TimeProvider
{
    public override TimeZoneInfo LocalTimeZone =>
        TimeZoneInfo.FindSystemTimeZoneById("Europe/Vienna");
}