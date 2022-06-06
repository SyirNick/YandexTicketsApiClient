namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка способов оплаты.
    /// </summary>
    public class GetPaymentMethodsListResponse : ResponseBase
    {
        /// <summary>
        /// Список способо оплаты.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<PaymentMethod> PaymentMethods { get; set; }
    }
}