namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка схем секторов.
    /// </summary>
    public class GetSectorMapsListResponse : ResponseBase
    {
        /// <summary>
        /// Список схем секторов.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<SectorMap> SectorMapsList { get; set; }
    }
}