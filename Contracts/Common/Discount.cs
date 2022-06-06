namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Скидка.
    /// </summary>
    public class Discount
    {
        /// <summary>
        /// Дата начала скидки.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public string Start { get; set; }

        /// <summary>
        /// Дата окончания скидки.
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public string End { get; set; }

        /// <summary>
        /// Процент скидки на билет.
        /// </summary>
        [JsonProperty(PropertyName = "discount_percent")]
        public int DiscountPercent { get; set; }

        /// <summary>
        /// Сумма скидки на билет.
        /// </summary>
        [JsonProperty(PropertyName = "discount_sum")]
        public int DiscountSum { get; set; }
    }
}