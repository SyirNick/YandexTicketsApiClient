namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка групп мест в секторе.
    /// </summary>
    public class GetSectorGroupsListRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса списка групп мест в секторе.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="sectorId">Идентификатор сектора.</param>
        /// <param name="cityId">Идентификатор города. Необязательный параметр.</param>
        public GetSectorGroupsListRequest(string auth, int sectorId, int? cityId = null)
        {
            Auth = auth;
            SectorId = sectorId;
            CityId = cityId;
        }

        /// <summary>
        /// Идентификатор сектора.
        /// </summary>
        public int SectorId { get; set; }

        /// <summary>
        /// Идентификатор города. Необязательный параметр.
        /// </summary>
        public int? CityId { get; set; }
    }
}