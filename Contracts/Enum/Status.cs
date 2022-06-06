namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Статус ответа. Возможные значения:<br></br><br></br>
    /// Done - запрос выполнен;<br></br>
    /// Error - произошла ошибка.
    /// </summary>
    public enum ResponseStatus
    {
        /// <summary>
        /// Статус ответа: запрос выполнен.
        /// </summary>
        Done,

        /// <summary>
        /// Статус ответа: произошла ошибка.
        /// </summary>
        Error
    }
}