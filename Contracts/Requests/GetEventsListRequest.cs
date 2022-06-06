namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка событий.
    /// </summary>
    public class GetEventsListRequest : RequestBase, IContainDateTimeZone
    {
        /// <summary>
        /// Конструктор класса запроса списка событий.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="limit">Максимальное количество возвращаемых объектов. Необязательный параметр.</param>
        /// <param name="offset">Количество пропускаемых в ответе объектов, начиная с первого. Необязательный параметр.</param>
        /// <param name="venueId">Идентификатор места проведения. Необязательный параметр.</param>
        /// <param name="genreId">Идентификатор жанра. Необязательный параметр.</param>
        /// <param name="activityId">Идентификатор мероприятия. Необязательный параметр.</param>
        /// <param name="search">Название события. Необязательный параметр.</param>
        /// <param name="startDateTime">Дата с точностью до дня, начиная с которой (включительно) события возвращаются в ответе. Необязательный параметр.</param>
        /// <param name="endDateTime">Дата с точностью до дня, до которой (включительно) события возвращаются в ответе. Необязательный параметр.</param>
        /// <param name="updatedAfterDateTime">
        /// Дата обновления. Необязательный параметр.<br></br>
        /// При наличии даты и часового пояса в запросе, ответ будет содержать только объекты, измененные после этой даты.
        /// </param>
        /// <param name="updatedAfterTimeZone">
        /// Часовой пояс. Необязательный параметр.<br></br>
        /// При наличии даты и часового пояса в запросе, ответ будет содержать только объекты, измененные после этой даты.
        /// </param>
        public GetEventsListRequest(string auth, int cityId, int? limit = null, int? offset = null, int? venueId = null, int? genreId = null, int? activityId = null, string search = null,
            DateTime? startDateTime = null, DateTime? endDateTime = null, DateTime? updatedAfterDateTime = null, TimeZoneInfo? updatedAfterTimeZone = null)
        { 
            Auth = auth;
            CityId = cityId;
            Limit = limit;
            Offset = offset;
            VenueId = venueId;
            GenreId = genreId;
            ActivityId = activityId;
            Search = search;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
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
        /// Идентификатор места проведения. Необязательный параметр.
        /// </summary>
        public int? VenueId { get; set; }

        /// <summary>
        /// Идентификатор жанра. Необязательный параметр.
        /// </summary>
        public int? GenreId { get; set; }

        /// <summary>
        /// Идентификатор мероприятия. Необязательный параметр.
        /// </summary>
        public int? ActivityId { get; set; }

        /// <summary>
        /// Название события. Необязательный параметр.
        /// </summary>
        public string Search { get; set; }

        /// <summary>
        /// Дата с точностью до дня, начиная с которой (включительно) события возвращаются в ответе. Необязательный параметр.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Дата с точностью до дня, до которой (включительно) события возвращаются в ответе. Необязательный параметр.
        /// </summary>
        public DateTime? EndDateTime { get; set; }

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