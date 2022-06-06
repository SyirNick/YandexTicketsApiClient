namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Город.
    /// </summary>
    public class City
    {
        /// <summary>
        /// Идентификатор города.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Название города.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}