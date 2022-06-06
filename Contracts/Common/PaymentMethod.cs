namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Способ оплаты.
    /// </summary>
    public class PaymentMethod
    {
        /// <summary>
        /// Идентификатор билета.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Цена билета.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Price { get; set; }

        /// <summary>
        /// Отмечен как вариант по умолчанию. Возможные варианты:<br><br></br></br>
        /// True - да;<br></br>
        /// False - нет.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Применяется при покупке электронного билета. Возможные варианты:<br><br></br></br>
        /// True - да;<br></br>
        /// False - нет.
        /// </summary>
        [JsonProperty(PropertyName = "eticket")]
        public bool IsOnline { get; set; }
    }
}