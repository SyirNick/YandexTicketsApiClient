namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка секторов с билетами на событие.
    /// </summary>
    public class GetSectorsWithTicketsListRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса списка секторов с билетами на событие.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="eventId">Идентификатор события.</param>
        /// <param name="showAll">Флаг, указывающий, что в ответ нужно добавить секторы, в которых закончились билеты. Необязательный параметр.</param>
        public GetSectorsWithTicketsListRequest(string auth, int cityId, int eventId, bool? showAll = null)
        { 
            Auth = auth;
            CityId = cityId;
            EventId = eventId;
            ShowAll = showAll;
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
        /// Флаг, указывающий, что в ответ нужно добавить секторы, в которых закончились билеты. Необязательный параметр.
        /// </summary>
        public bool? ShowAll { get; set; }
    }
}