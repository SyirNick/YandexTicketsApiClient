namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса проверки применимости промокода к предварительно забронированному билету.
    /// </summary>
    public class CheckPromoRequest : TicketOrderRequestBase
    {
        /// <summary>
        /// Конструктор класса запроса проверки применимости промокода к предварительно забронированному билету.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="sessionId">Идентификатор сессии, постоянный для всей сессии (не менее 20 символов).</param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="promocode">Промокод.</param>
        public CheckPromoRequest(string auth, string sessionId, int cityId, string promocode)
        { 
            Auth = auth;
            SessionId = sessionId;
            CityId = cityId;
            Promocode = promocode;
        }

        /// <summary>
        /// Промокод.
        /// </summary>
        public string Promocode { get; set; }
    }
}