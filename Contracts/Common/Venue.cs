namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Место проведения с доступными для продажи событиями.
    /// </summary>
    public class Venue
    {
        /// <summary>
        /// Идентификатор места проведения.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Название места проведения.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Адрес места проведения.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        [JsonProperty(PropertyName = "city_id")]
        public int CityId { get; set; }

        /// <summary>
        /// Список версий зала.
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public List<HallVersionShort> HallVersions { get; set; }
    }
}