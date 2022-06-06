namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка жанров.
    /// </summary>
    public class GetGenresListResponse : ResponseBase
    {
        /// <summary>
        /// Список жанров.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<Genre> Genres { get; set; }
    }
}