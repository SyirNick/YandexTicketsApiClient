namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения вариантов доставки.
    /// </summary>
    public class GetCartDeliveriesListResponse : ResponseBase
    {
        /// <summary>
        /// Список вариантов доставки.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<CartDelivery> CartDeliveries { get; set; }
    }
}