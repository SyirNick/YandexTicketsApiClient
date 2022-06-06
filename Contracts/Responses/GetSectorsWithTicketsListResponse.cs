namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка секторов с билетами на событие.
    /// </summary>
    public class GetSectorsWithTicketsListResponse : ResponseBase
    {
        /// <summary>
        /// Список секторов с билетами на событие.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<SectorWithTickets> SectorsWithTickets { get; set; }
    }
}