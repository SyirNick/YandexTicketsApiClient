namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка проданных билетов.
    /// </summary>
    public class GetSoldTicketsListResponse : ResponseBase
    {
        /// <summary>
        /// Список проданных билетов.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<SoldTicket> SoldTickets { get; set; }
    }
}