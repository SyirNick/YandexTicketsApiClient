namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка городов.
    /// </summary>
    public class GetCitiesListRequest : RequestBase, IContainDateTimeZone
    {
        /// <summary>
        /// Конструктор класса запроса списка городов.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="updatedAfterDateTime">
        /// Дата обновления. Необязательный параметр.<br></br>
        /// При наличии даты и часового пояса в запросе, ответ будет содержать только объекты, измененные после этой даты.
        /// </param>
        /// <param name="updatedAfterTimeZone">
        /// Часовой пояс. Необязательный параметр.<br></br>
        /// При наличии даты и часового пояса в запросе, ответ будет содержать только объекты, измененные после этой даты.
        /// </param>
        public GetCitiesListRequest(string auth, DateTime? updatedAfterDateTime = null, TimeZoneInfo? updatedAfterTimeZone = null)
        {
            Auth = auth;
            UpdatedAfterDateTime = updatedAfterDateTime;
            UpdatedAfterTimeZone = updatedAfterTimeZone;
        }

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