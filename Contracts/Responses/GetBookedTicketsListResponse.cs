namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка предварительно забронированных билетов.
    /// </summary>
    public class GetBookedTicketsListResponse : ResponseBase
    {
        /// <summary>
        /// Список предварительно забронированных билетов.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<BookedTicket> BookedTickets { get; set; }
    }
}