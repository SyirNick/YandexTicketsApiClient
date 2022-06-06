namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса применения промокода к предварительно забронированному билету.
    /// </summary>
    public class CheckPromoResponse : ResponseBase
    {
        /// <summary>
        /// Сумма скидки с промокодом, применённая к предварительно забронированному билету.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public PromoAppliedDiscount Discount { get; set; }
    }
}