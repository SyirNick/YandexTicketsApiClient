namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Язык покупателя. Возможные значения:<br></br><br></br>
    /// Ru - русский (по умолчанию);<br></br>
    /// En - английский;<br></br>
    /// Ee - эстонский.
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// Язык покупателя: русский (по умолчанию).
        /// </summary>
        Ru,

        /// <summary>
        /// Язык покупателя: английский.
        /// </summary>
        En,

        /// <summary>
        /// Язык покупателя: эстонский.
        /// </summary>
        Ee
    }
}