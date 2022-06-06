namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Созданный заказ.
    /// </summary>
    public class CreatedOrder
    {
        /// <summary>
        /// Идентификатор созданного заказа.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
    }
}