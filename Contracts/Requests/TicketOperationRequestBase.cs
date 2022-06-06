namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Базовый класс для запросов из раздела "операции с заказами".
    /// </summary>
    public class TicketOperationRequestBase : TicketOrderRequestBase
    {
        /// <summary>
        /// Идентификатор заказа.
        /// </summary>
        public int OrderId { get; set; }
    }
}