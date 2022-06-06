namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка городов.
    /// </summary>
    public class GetCitiesListResponse : ResponseBase
    {
        /// <summary>
        /// Список городов.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<City> Cities { get; set; }
    }
}