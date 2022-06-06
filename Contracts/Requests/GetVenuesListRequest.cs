namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка мест проведения с доступными для продажи событиями.
    /// </summary>
    public class GetVenuesListRequest : RequestBase, IContainDateTimeZone
    {
        /// <summary>
        /// Конструктор класса запроса списка мест проведения с доступными для продажи событиями.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="limit">Максимальное количество возвращаемых объектов. Необязательный параметр.</param>
        /// <param name="offset">Количество пропускаемых в ответе объектов, начиная с первого. Необязательный параметр.</param>
        /// <param name="updatedAfterDateTime">
        /// Дата обновления. Необязательный параметр.<br></br>
        /// При наличии даты и часового пояса в запросе, ответ будет содержать только объекты, измененные после этой даты.
        /// </param>
        /// <param name="updatedAfterTimeZone">
        /// Часовой пояс. Необязательный параметр.<br></br>
        /// При наличии даты и часового пояса в запросе, ответ будет содержать только объекты, измененные после этой даты.
        /// </param>
        public GetVenuesListRequest(string auth, int cityId, int? limit = null, int? offset = null, DateTime? updatedAfterDateTime = null, TimeZoneInfo? updatedAfterTimeZone = null)
        { 
            Auth = auth;
            CityId = cityId;
            Limit = limit;
            Offset = offset;
            UpdatedAfterDateTime = updatedAfterDateTime;
            UpdatedAfterTimeZone = updatedAfterTimeZone;
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

        /// <summary>
        /// Дата обновления. Необязательный параметр.<br></br>
        /// При наличии даты и часового пояса в запросе, ответ будет содержать только объекты, измененные после этой даты.
        /// </summary>
        public DateTime? UpdatedAfterDateTime { get; set; }

        /// <summary>
        /// Часовой пояс. Необязательный параметр.<br></br>
        /// При наличии даты и часового пояса в запросе, ответ будет содержать только объекты, измененные после этой даты.
        /// </summary>
        public TimeZoneInfo? UpdatedAfterTimeZone { get; set; }
    }
}