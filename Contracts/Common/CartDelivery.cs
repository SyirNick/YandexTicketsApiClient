namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Вариант доставки.
    /// </summary>
    public class CartDelivery
    {
        /// <summary>
        /// Идентификатор варианта доставки.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Название варианта доставки.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Стоимость доставки.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public int Price { get; set; }

        /// <summary>
        /// Тип доставки. Возможные значения:<br><br></br></br>
        /// SelfRedemption - самовыкуп;<br></br>
        /// Delivery - доставка;<br></br>
        /// OnlineTicket - электронный билет;<br></br>
        /// SalesOffice - касса продаж.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public DeliveryType DeliveryType { get; set; }

        /// <summary>
        /// Отмечен как вариант по умолчанию. Возможные варианты:<br><br></br></br>
        /// True - да;<br></br>
        /// False - нет.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Минимальный сервисный сбор при данном варианте доставки.
        /// </summary>
        [JsonProperty(PropertyName = "commission")]
        public int Comission { get; set; }

        /// <summary>
        /// Массив дней возможной доставки. Возвращается, если DeliveryVariant.Type == DeliveryType.Delivery.
        /// </summary>
        [JsonProperty(PropertyName = "days")]
        public List<DateTime> AvailableDeliveryDays { get; set; }
    }
}