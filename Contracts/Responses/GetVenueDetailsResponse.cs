namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения информации о месте проведения с доступными для продажи событиями.
    /// </summary>
    public class GetVenueDetailsResponse : ResponseBase
    {
        /// <summary>
        /// Информация о месте проведения с доступными для продажи событиями.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public VenueDetails VenueDetails { get; set; }
    }
}