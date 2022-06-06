namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Базовый класс, содержащий поля, которые есть во всех ответах.
    /// </summary>
    public class ResponseBase
    {
        /// <summary>
        /// Статус выполнения запроса. Возможные значения:<br></br><br></br>
        /// Status.Done — запрос выполнен;<br></br>
        /// Status.Error — произошла ошибка.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ResponseStatus? Status { get; set; } = ResponseStatus.Error;
    }
}