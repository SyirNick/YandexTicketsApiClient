namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса отмены предварительной брони билета.
    /// </summary>
    public class CancelBookingResponse : ResponseBase
    {
        /// <summary>
        /// Результат выполнения запроса. Возможные значения:<br></br><br></br>
        /// True - запрос выполнен;<br></br>
        /// False - произошла ошибка.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public bool IsCanceled { get; set; }
    }
}