namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка мероприятий.
    /// </summary>
    public class GetActivitiesListRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса списка мероприятий.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="limit">Максимальное количество возвращаемых объектов. Необязательный параметр.</param>
        /// <param name="offset">Количество пропускаемых в ответе объектов, начиная с первого. Необязательный параметр.</param>
        public GetActivitiesListRequest(string auth, int cityId, int? limit = null, int? offset = null)
        {
            Auth = auth;
            CityId = cityId;
            Limit = limit;
            Offset = offset;
        }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Максимальное количество возвращаемых объектов. Необязательный параметр.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Количество пропускаемых в ответе объектов, начиная с первого. Необязательный параметр.
        /// </summary>
        public int? Offset { get; set; }
    }
}