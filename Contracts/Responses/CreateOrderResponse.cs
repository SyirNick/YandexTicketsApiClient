namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса создания заказа.
    /// </summary>
    public class CreateOrderResponse : ResponseBase
    {
        /// <summary>
        /// Созданный заказ.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public CreatedOrder CreatedOrder { get; set; }
    }
}