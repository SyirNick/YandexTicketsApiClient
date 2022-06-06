namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка свободных билетов на событие.
    /// </summary>
    public class GetAvailableTicketsListResponse : ResponseBase
    {
        /// <summary>
        /// Свободные билеты на событие.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<AvailableTicket> AvailableTickets { get; set; }
    }
}