namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Базовый класс для всех запросов.
    /// </summary>
    public class RequestBase
    {
        /// <summary>
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </summary>
        public string Auth { get; set; }

        /// <summary>
        /// Генерация идентификатора доступа к API Яндекс Билеты.<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string GetAuth(DateTimeOffset sendDateTimeOffset, string login, string password)
        {
            var unixTimestamp = sendDateTimeOffset.Ticks / 10000000L - 62135596800L;
            var identifier = $"{password.GetMd5()}{unixTimestamp}".GetSha1();
            return $"{login}:{identifier}:{unixTimestamp}";
        }
    }
}