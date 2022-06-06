namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Статус заказа. Возможные значения:<br><br></br></br>
    /// Canceled - аннулирован;<br></br>
    /// Sold - продан;<br></br>
    /// Booked - бронь;<br></br>
    /// Delivery - доставка.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Статус заказа: аннулирован.
        /// </summary>
        Canceled,

        /// <summary>
        /// Статус заказа: продан.
        /// </summary>
        Sold,

        /// <summary>
        /// Статус заказа: бронь.
        /// </summary>
        Booked,

        /// <summary>
        /// Статус заказа: доставка.
        /// </summary>
        Delivery
    }
}