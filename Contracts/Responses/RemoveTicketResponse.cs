namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса аннулирования билета в заказе.
    /// </summary>
    public class RemoveTicketResponse : ResponseBase
    {
        /// <summary>
        /// Результат выполнения запроса. Возможные значения:<br></br><br></br>
        /// True - запрос выполнен;<br></br>
        /// False - произошла ошибка.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public bool IsStatusUpdated { get; set; }
    }
}