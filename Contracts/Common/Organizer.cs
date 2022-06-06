namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Организатор.
    /// </summary>
    public class Organizer
    {
        /// <summary>
        /// Идентификатор организатора.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Юридическое название организации.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Юридический адрес организации.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// ИНН организации.
        /// </summary>
        [JsonProperty(PropertyName = "inn")]
        public string Inn { get; set; }
    }
}