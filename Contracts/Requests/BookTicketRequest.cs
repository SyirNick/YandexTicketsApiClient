namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса предварительной брони билета.
    /// </summary>
    public class BookTicketRequest : TicketOrderRequestBase
    {
        /// <summary>
        /// Конструктор класса запроса предварительной брони билета.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="sessionId">Идентификатор сессии, постоянный для всей сессии (не менее 20 символов).</param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="ticketId">Идентификатор билета.</param>
        public BookTicketRequest(string auth, string sessionId, int cityId, int ticketId)
        { 
            Auth = auth;
            SessionId = sessionId;
            CityId = cityId;
            TicketId = ticketId;
        }

        /// <summary>
        /// Идентификатор билета.
        /// </summary>
        public int TicketId { get; set; }
    }
}