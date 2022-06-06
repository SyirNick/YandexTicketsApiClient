namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка заказов.
    /// </summary>
    public class GetOrdersListResponse : ResponseBase
    {
        /// <summary>
        /// Список заказов.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<Order> Orders { get; set; }
    }
}