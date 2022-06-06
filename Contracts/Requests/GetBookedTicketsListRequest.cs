namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка предварительно забронированных билетов.
    /// </summary>
    public class GetBookedTicketsListRequest : TicketOrderRequestBase
    {
        /// <summary>
        /// Конструктор класса запроса списка предварительно забронированных билетов.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="sessionId">Идентификатор сессии, постоянный для всей сессии (не менее 20 символов).</param>
        /// <param name="cityId">Идентификатор города.</param>
        public GetBookedTicketsListRequest(string auth, string sessionId, int cityId)
        {
            Auth = auth;
            SessionId = sessionId;
            CityId = cityId;
        }
    }
}