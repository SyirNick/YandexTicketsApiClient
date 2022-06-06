namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class Order
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
        /// Количество билетов в заказе.
        /// </summary>
        [JsonProperty(PropertyName = "tickets_count")]
        public int TicketsCount { get; set; }

        /// <summary>
        /// Сумма заказа.
        /// </summary>
        [JsonProperty(PropertyName = "tickets_sum")]
        public int TicketsSum { get; set; }

        /// <summary>
        /// Сумма сервисного сбора.
        /// </summary>
        [JsonProperty(PropertyName = "tickets_fee")]
        public int TicketsFee { get; set; }
    }
}