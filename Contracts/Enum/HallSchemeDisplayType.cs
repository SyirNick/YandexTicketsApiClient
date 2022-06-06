namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Тип отображения схемы зала. Возможные значения:<br><br></br></br>
    /// SingleScheme - секторы отображаются на одной схеме;<br></br>
    /// SectorList - отображается список секторов.
    /// </summary>
    public enum HallSchemeDisplayType
    {
        /// <summary>
        /// Тип отображения схемы зала: секторы отображаются на одной схеме.
        /// </summary>
        SingleScheme,

        /// <summary>
        /// Тип отображения схемы зала: отображается список секторов.
        /// </summary>
        SectorList
    }
}