namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса информации о месте проведения с доступными для продажи событиями.
    /// </summary>
    public class GetVenueDetailsRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса информации о месте проведения с доступными для продажи событиями.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="venueId">Идентификатор места проведения.</param>
        public GetVenueDetailsRequest(string auth, int cityId, int venueId)
        { 
            Auth = auth;
            CityId = cityId;
            VenueId = venueId;
        }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Идентификатор места проведения.
        /// </summary>
        public int VenueId { get; set; }
    }
}