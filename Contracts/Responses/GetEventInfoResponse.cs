namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения информации о событии.
    /// </summary>
    public class GetEventDetailsResponse : ResponseBase
    {
        /// <summary>
        /// Информация о событии.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public EventDetails EventDetails { get; set; }
    }
}