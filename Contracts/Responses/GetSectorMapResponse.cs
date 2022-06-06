namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения схемы сектора.
    /// </summary>
    public class GetSectorMapResponse : ResponseBase
    {
        /// <summary>
        /// Схема сектора.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public SectorMap SectorMap { get; set; }
    }
}