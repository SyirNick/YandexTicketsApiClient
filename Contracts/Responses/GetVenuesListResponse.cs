namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка мест проведения с доступными для продажи событиями.
    /// </summary>
    public class GetVenuesListResponse : ResponseBase
    {
        /// <summary>
        /// Список мест проведения с доступными для продажи событиями.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<Venue> Venues { get; set; }
    }
}