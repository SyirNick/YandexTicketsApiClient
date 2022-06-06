namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Проданный билет.
    /// </summary>
    public class SoldTicket
    {
        /// <summary>
        /// Идентификатор билета.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор заказа.
        /// </summary>
        [JsonProperty(PropertyName = "order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// Штрихкод билета.
        /// </summary>
        [JsonProperty(PropertyName = "barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Идентификатор события.
        /// </summary>
        [JsonProperty(PropertyName = "event_id")]
        public int EventId { get; set; }

        /// <summary>
        /// Дата продажи.
        /// </summary>
        [JsonProperty(PropertyName = "sale_date")]
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// Стоимость билета.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public int Price { get; set; }

        /// <summary>
        /// Идентификатор места.
        /// </summary>
        [JsonProperty(PropertyName = "place_id")]
        public int PlaceId { get; set; }
    }
}