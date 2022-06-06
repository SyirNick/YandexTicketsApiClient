namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса изменения статуса заказа на "аннулирован".
    /// </summary>
    public class SetOrderCanceledRequest : TicketOperationRequestBase
    {
        /// <summary>
        /// Конструктор класса запроса изменения статуса заказа на "аннулирован".
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="sessionId">Идентификатор сессии, постоянный для всей сессии (не менее 20 символов).</param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="orderId">Идентификатор заказа.</param>
        public SetOrderCanceledRequest(string auth, string sessionId, int cityId, int orderId)
        { 
            Auth = auth;
            SessionId = sessionId;
            CityId = cityId;
            OrderId = orderId;
        }
    }
}