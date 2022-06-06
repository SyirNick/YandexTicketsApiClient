namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Тип мест. Возможные значения:<br><br></br></br>
    /// Unnumbered - ненумерованные;<br></br>
    /// Numbered - нумерованные.
    /// </summary>
    public enum SeatType
    {
        /// <summary>
        /// Тип мест: ненумерованные.
        /// </summary>
        Unnumbered,

        /// <summary>
        /// Тип мест: нумерованные.
        /// </summary>
        Numbered
    }
}