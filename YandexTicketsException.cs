namespace YandexTicketsApiWrapper
{
    /// <summary>
    /// Внутренняя ошибка клиента API Яндекс Билеты.
    /// </summary>
    public class YandexTicketsException : Exception
    {
        public YandexTicketsException()
        {
        }

        public YandexTicketsException(string message)
            : base(message)
        {
        }

        public YandexTicketsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
