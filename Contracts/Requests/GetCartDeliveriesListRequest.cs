namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка вариантов доставки.
    /// </summary>
    public class GetCartDeliveriesListRequest : TicketOrderRequestBase
    {
        /// <summary>
        /// Конструктор класса запроса списка вариантов доставки.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="sessionId">Идентификатор сессии, постоянный для всей сессии (не менее 20 символов).</param>
        /// <param name="cityId">Идентификатор города.</param>
        public GetCartDeliveriesListRequest(string auth, string sessionId, int cityId)
        { 
            Auth = auth;
            SessionId = sessionId;
            CityId = cityId;
        }
    }
}