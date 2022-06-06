namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Статус события. Возможные значения:<br></br><br></br>
    /// Closed - закрыто;<br></br>
    /// InSale - в продаже.
    /// </summary>
    public enum EventStatus
    {
        /// <summary>
        /// Статус события: закрыто.
        /// </summary>
        Closed,

        /// <summary>
        /// Статус события: в продаже.
        /// </summary>
        InSale
    }
}