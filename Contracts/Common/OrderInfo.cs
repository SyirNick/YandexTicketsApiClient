namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Информация о заказе.
    /// </summary>
    public class OrderInfo
    {
        /// <summary>
        /// Идентификатор заказа.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Статус заказа. Возможные значения:<br><br></br></br>
        /// Canceled - аннулирован;<br></br>
        /// Sold - продан;<br></br>
        /// Booked - бронь;<br></br>
        /// Delivery - доставка.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Данные покупателя.
        /// </summary>
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }

        /// <summary>
        /// Список билетов в заказе.
        /// </summary>
        [JsonProperty(PropertyName = "tickets")]
        public List<Ticket> Tickets { get; set; }

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        [JsonProperty(PropertyName = "order_date")]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Дата аннулирования заказа.
        /// </summary>
        [JsonProperty(PropertyName = "annulate_date")]
        public DateTime AnnulateDate { get; set; }

        /// <summary>
        /// UTM-метка заказа.
        /// </summary>
        [JsonProperty(PropertyName = "utm_source")]
        public string UtmSource { get; set; }

        /// <summary>
        /// Идентификатор способа оплаты.
        /// </summary>
        [JsonProperty(PropertyName = "payment_id")]
        public int PaymentId { get; set; }

        /// <summary>
        /// Идентификатор варианта доставки.
        /// </summary>
        [JsonProperty(PropertyName = "delivery_id")]
        public int DeliveryTypeId { get; set; }

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }
    }
}