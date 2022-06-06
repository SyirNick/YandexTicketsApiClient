namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка проданных билетов.
    /// </summary>
    public class GetSoldTicketsListRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса списка проданных билетов.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="eventId">Идентификатор события. Необязательный параметр.</param>
        /// <param name="startDateTime">Дата с точностью до дня, начиная с которой (включительно) события возвращаются в ответе. Необязательный параметр.</param>
        /// <param name="endDateTime">Дата с точностью до дня, до которой (включительно) события возвращаются в ответе. Необязательный параметр.</param>
        public GetSoldTicketsListRequest(string auth, int cityId, int? eventId = null, DateTime? startDateTime = null, DateTime? endDateTime = null)
        { 
            Auth = auth;
            CityId = cityId;
            EventId = eventId;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Идентификатор события. Необязательный параметр.
        /// </summary>
        public int? EventId { get; set; }

        /// <summary>
        /// Дата с точностью до дня, начиная с которой (включительно) события возвращаются в ответе. Необязательный параметр.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Дата с точностью до дня, до которой (включительно) события возвращаются в ответе. Необязательный параметр.
        /// </summary>
        public DateTime? EndDateTime { get; set; }
    }
}