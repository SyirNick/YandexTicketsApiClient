namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка жанров.
    /// </summary>
    public class GetGenresListRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса списка жанров.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="cityId">Идентификатор города.</param>
        public GetGenresListRequest(string auth, int cityId)
        { 
            Auth = auth;
            CityId = cityId;
        }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        public int CityId { get; set; }
    }
}