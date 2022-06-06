namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка событий.
    /// </summary>
    public class GetEventsListResponse : ResponseBase
    {
        /// <summary>
        /// Список событий.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<Event> Events { get; set; }
    }
}