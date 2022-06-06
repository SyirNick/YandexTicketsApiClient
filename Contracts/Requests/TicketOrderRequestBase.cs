namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Базовый класс для запросов ветки "заказ билетов".
    /// </summary>
    public class TicketOrderRequestBase : RequestBase
    {
        /// <summary>
        /// Идентификатор сессии, постоянный для всей сессии (не менее 20 символов).
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        public int CityId { get; set; }
    }
}