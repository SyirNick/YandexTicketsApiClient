namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса отправки электронного билета покупателю.
    /// </summary>
    public class SendOnlineTicketResponse : ResponseBase
    {
        /// <summary>
        /// Результат выполнения запроса. Возможные значения:<br></br><br></br>
        /// True - запрос выполнен;<br></br>
        /// False - произошла ошибка.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public bool IsSuccess { get; set; }
    }
}