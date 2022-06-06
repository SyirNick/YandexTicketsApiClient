namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса изменения статуса заказа на "аннулирован".
    /// </summary>
    public class SetOrderCanceledResponse : ResponseBase
    {
        /// <summary>
        /// Результат выполнения запроса. Возможные значения:<br></br><br></br>
        /// True - запрос выполнен;<br></br>
        /// False - произошла ошибка.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public bool IsStatusUpdated { get; set; }
    }
}