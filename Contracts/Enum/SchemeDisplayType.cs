namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Тип отображения схемы. Возможные значения:<br></br><br></br>
    /// Common - общая схема;<br></br>
    /// Sectors - список секторов.
    /// </summary>
    public enum SchemeDisplayType
    {
        /// <summary>
        /// Тип отображения схемы: общая схема.
        /// </summary>
        Common,

        /// <summary>
        /// Тип отображения схемы: список секторов.
        /// </summary>
        Sectors
    }
}