namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Информация о месте проведения с доступными для продажи событиями.
    /// </summary>
    public class VenueDetails
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
        /// Описание места проведения.
        /// </summary>
        [JsonProperty(PropertyName = "descr")]
        public string Description { get; set; }

        /// <summary>
        /// Ссылка на изображение.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string ImageLink { get; set; }

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
        /// Координаты места проведения.
        /// </summary>
        [JsonProperty(PropertyName = "coord")]
        public string Coordinates { get; set; }

        /// <summary>
        /// Идентификаторы рекомендуемых мест проведения.
        /// </summary>
        [JsonProperty(PropertyName = "similar")]
        public string[] RecommendedPlacesIds { get; set; }

        /// <summary>
        /// Список версий зала.
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public List<HallVersion> HallVersions { get; set; }
    }
}