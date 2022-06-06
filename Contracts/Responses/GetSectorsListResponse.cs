namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка секторов для версии зала.
    /// </summary>
    public class GetSectorsListResponse : ResponseBase
    {
        /// <summary>
        /// Список секторов для версии зала.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<Sector> Sectors { get; set; }
    }
}