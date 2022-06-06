namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Сумма скидки с промокодом, применённая к предварительно забронированному билету.
    /// </summary>
    public class PromoAppliedDiscount
    {
        /// <summary>
        /// Сумма скидки.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public int DiscountSum { get; set; }

        /// <summary>
        /// Сервисный сбор.
        /// </summary>
        [JsonProperty(PropertyName = "fee")]
        public int Fee { get; set; }
    }
}