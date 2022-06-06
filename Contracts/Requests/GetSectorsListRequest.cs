namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка секторов для версии зала.
    /// </summary>
    public class GetSectorsListRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса списка секторов для версии зала.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="versionId"></param>
        public GetSectorsListRequest(string auth, int versionId)
        {
            Auth = auth;
            VersionId = versionId;
        }

        /// <summary>
        /// Идентификатор версии зала.
        /// </summary>
        public int VersionId { get; set; }
    }
}