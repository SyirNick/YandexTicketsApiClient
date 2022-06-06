namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Тип зала. Возможные значения:<br><br></br></br>
    /// HallSchemeVersion - версия схемы зала;<br></br>
    /// SeparateHall - отдельный зал (малая сцена).
    /// </summary>
    public enum HallType
    {
        /// <summary>
        /// Тип зала: версия схемы зала.
        /// </summary>
        HallSchemeVersion,

        /// <summary>
        /// Тип зала: отдельный зал (малая сцена).
        /// </summary>
        SeparateHall
    }
}