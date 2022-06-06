namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Тип доставки. Возможные значения:<br><br></br></br>
    /// SelfRedemption - самовыкуп;<br></br>
    /// Delivery - доставка;<br></br>
    /// OnlineTicket - электронный билет;<br></br>
    /// SalesOffice - касса продаж.
    /// </summary>
    public enum DeliveryType
    {
        /// <summary>
        /// Тип доставки: самовыкуп.
        /// </summary>
        SelfRedemption,

        /// <summary>
        /// Тип доставки: доставка.
        /// </summary>
        Delivery,

        /// <summary>
        /// Тип доставки: электронный билет.
        /// </summary>
        OnlineTicket,

        /// <summary>
        /// Тип доставки: касса продаж.
        /// </summary>
        SalesOffice
    }
}