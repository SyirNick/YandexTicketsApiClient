namespace YandexTicketsApiWrapper.Contracts
{
    public interface IContainDateTimeZone
    {
        public DateTime? UpdatedAfterDateTime { get; set; }
        public TimeZoneInfo? UpdatedAfterTimeZone { get; set; }
    }
}