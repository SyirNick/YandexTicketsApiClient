namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Тип схемы сектора. Возможные значения:<br><br></br></br>
    /// Place - место в зале;<br></br>
    /// Text - текстовая метка.
    /// </summary>
    public enum SectorSchemeType
    {
        /// <summary>
        /// Тип схемы сектора: место в зале.
        /// </summary>
        Place,

        /// <summary>
        /// Тип схемы сектора: текстовая метка.
        /// </summary>
        Text
    }
}