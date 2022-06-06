namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка свободных билетов на событие.
    /// </summary>
    public class GetAvailableTicketsListRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса списка свободных билетов на событие.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="eventId">Идентификатор события.</param>
        /// <param name="sectorId">Идентификатор сектора. Необязательный параметр.</param>
        /// <param name="addGroups">Флаг, указывающий, что в ответ необходимо добавить билеты из групп. Необязательный параметр.</param>
        public GetAvailableTicketsListRequest(string auth, int cityId, int eventId, int? sectorId = null, bool? addGroups = null)
        {
            Auth = auth;
            CityId = cityId;
            EventId = eventId;
            SectorId = sectorId;
            AddGroups = addGroups;
        }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Идентификатор события.
        /// </summary>
        public int EventId { get; set; }

        /// <summary>
        /// Идентификатор сектора. Необязательный параметр.
        /// </summary>
        public int? SectorId { get; set; }

        /// <summary>
        /// Флаг, указывающий, что в ответ необходимо добавить билеты из групп. Необязательный параметр.
        /// </summary>
        public bool? AddGroups { get; set; }
    }
}