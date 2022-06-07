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

        /// <summary>
        /// Создаёт новый сид для запросов работы с заказом билетов и операциями с заказами.
        /// </summary>
        public static string CreateSessionId() =>
            $"{Guid.NewGuid()}{DateTimeOffset.Now:yyyy-mm-ddTHH:mm:ss:fff}".GetSha1();
    }
}