namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка мероприятий.
    /// </summary>
    public class GetActivitiesListResponse : ResponseBase
    {
        /// <summary>
        /// Список мероприятий.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<Activity> Activities { get; set; }
    }
}