namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса аннулирования билета в заказе.
    /// </summary>
    public class RemoveTicketRequest : TicketOperationRequestBase
    {
        /// <summary>
        /// Конструктор класса запроса аннулирования билета в заказе.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="sessionId">Идентификатор сессии, постоянный для всей сессии (не менее 20 символов).</param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="orderId">Идентификатор заказа.</param>
        public RemoveTicketRequest(string auth, string sessionId, int cityId, int orderId)
        {
            Auth = auth;
            SessionId = sessionId;
            CityId = cityId;
            OrderId = orderId;
        }
    }
}