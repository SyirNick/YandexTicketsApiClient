namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения информации о заказе.
    /// </summary>
    public class GetOrderInfoResponse : ResponseBase
    {
        /// <summary>
        /// Информация о заказе.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public OrderInfo OrderInfo { get; set; }
    }
}