namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса бронирования билета.
    /// </summary>
    public class BookTicketResponse : ResponseBase
    {
        /// <summary>
        /// Результат выполнения запроса. Возможные значения:<br></br><br></br>
        /// True - запрос выполнен;<br></br>
        /// False - произошла ошибка.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public bool IsBooked { get; set; }
    }
}