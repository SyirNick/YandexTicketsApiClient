namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса информации о заказе.
    /// </summary>
    public class GetOrderInfoRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса информации о заказе.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="orderId">Идентификатор заказа.</param>
        public GetOrderInfoRequest(string auth, int cityId, int orderId)
        {
            Auth = auth;
            CityId = cityId;
            OrderId = orderId;
        }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Идентификатор заказа.
        /// </summary>
        public int OrderId { get; set; }
    }
}