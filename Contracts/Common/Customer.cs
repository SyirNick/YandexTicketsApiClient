namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Данные покупателя.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Идентификатор покупателя.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Имя покупателя.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Телефон покупателя.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Электропочта покупателя.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
    }
}