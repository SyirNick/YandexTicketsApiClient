namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса схемы сектора.
    /// </summary>
    public class GetSectorMapsListRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса схемы сектора.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="sectorId">Идентификатор сектора.</param>
        public GetSectorMapsListRequest(string auth, int sectorId)
        {
            Auth = auth;
            SectorId = sectorId;
        }

        /// <summary>
        /// Идентификатор сектора.
        /// </summary>
        public int SectorId { get; set; }
    }
}