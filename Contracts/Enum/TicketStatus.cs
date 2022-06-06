namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Статус билета. Возможные значения:<br><br></br></br>
    /// Canceled - аннулирован;<br></br>
    /// Active - активен.<br></br>
    /// </summary>
    public enum TicketStatus
    {
        /// <summary>
        /// Статус билета: аннулирован.
        /// </summary>
        Canceled,

        /// <summary>
        /// Статус билета: активен.
        /// </summary>
        Active
    }
}