namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса информации о событии.
    /// </summary>
    public class GetEventDetailsRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса информации о событии.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="eventId">Идентификатор события.</param>
        /// <param name="isOrganizerNeeded">Флаг, указывающий, что в ответ нужно добавить список данных организатора. Необязательный параметр.</param>
        /// <param name="isHtmlNeeded">Флаг, указывающий, что описание события должно вернуться с HTML-разметкой. Необязательный параметр.</param>
        /// <param name="isDiscountNeeded">Флаг, указывающий, что в ответ нужно добавить список скидок. Необязательный параметр.</param>
        public GetEventDetailsRequest(string auth, int cityId, int eventId, bool? isOrganizerNeeded = null, bool? isHtmlNeeded = null, bool? isDiscountNeeded = null)
        { 
            Auth = auth;
            CityId = cityId;
            EventId = eventId;
            IsOrganizerNeeded = isOrganizerNeeded;
            IsHtmlNeeded = isHtmlNeeded;
            IsDiscountNeeded = isDiscountNeeded;
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
        /// Флаг, указывающий, что в ответ нужно добавить список данных организатора. Необязательный параметр.
        /// </summary>
        public bool? IsOrganizerNeeded { get; set; }

        /// <summary>
        /// Флаг, указывающий, что описание события должно вернуться с HTML-разметкой. Необязательный параметр.
        /// </summary>
        public bool? IsHtmlNeeded { get; set; }

        /// <summary>
        /// Флаг, указывающий, что в ответ нужно добавить список скидок. Необязательный параметр.
        /// </summary>
        public bool? IsDiscountNeeded { get; set; }
    }
}