namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса отправки электронного билета покупателю.
    /// </summary>
    public class SendOnlineTicketRequest : TicketOperationRequestBase
    {
        /// <summary>
        /// Конструктор класса запроса отправки электронного билета покупателю.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="sessionId">Идентификатор сессии, постоянный для всей сессии (не менее 20 символов).</param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="orderId">Идентификатор заказа.</param>
        /// <param name="currency">Валюта, отображаемая в шаблоне билета.</param>
        public SendOnlineTicketRequest(string auth, string sessionId, int cityId, int orderId, string currency)
        {
            Auth = auth;
            SessionId = sessionId;
            CityId = cityId;
            OrderId = orderId;
            Currency = currency;
        }

        /// <summary>
        /// Валюта, отображаемая в шаблоне билета.
        /// </summary>
        public string Currency { get; set; }
    }
}