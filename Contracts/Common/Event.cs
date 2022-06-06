namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Событие.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Идентификатор мероприятия.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Название мероприятия.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор места проведения.
        /// </summary>
        [JsonProperty(PropertyName = "venue_id")]
        public int VenueId { get; set; }

        /// <summary>
        /// Идентификатор версии зала.
        /// </summary>
        [JsonProperty(PropertyName = "version_id")]
        public int VersionId { get; set; }

        /// <summary>
        /// Название места проведения.
        /// </summary>
        [JsonProperty(PropertyName = "venue")]
        public string Venue { get; set; }

        /// <summary>
        /// Название версии зала.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Идентификатор события.
        /// </summary>
        [JsonProperty(PropertyName = "activity_id")]
        public int ActivityId { get; set; }

        /// <summary>
        /// Код виджета.
        /// </summary>
        [JsonProperty(PropertyName = "widget")]
        public string Widget { get; set; }

        /// <summary>
        /// Минимальная стоимость билета.
        /// </summary>
        [JsonProperty(PropertyName = "min_price")]
        public int MinPrice { get; set; }

        /// <summary>
        /// Максимальная стоимость билета.
        /// </summary>
        [JsonProperty(PropertyName = "max_price")]
        public int MaxPrice { get; set; }

        /// <summary>
        /// Рекомендованный возраст.
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        public string Age { get; set; }

        /// <summary>
        /// Ссылка на изображение.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string ImageLink { get; set; }

        /// <summary>
        /// Ссылка на изображение для списков.
        /// </summary>
        [JsonProperty(PropertyName = "image_list")]
        public string ImageListLink { get; set; }

        /// <summary>
        /// Ссылка на постер.
        /// </summary>
        [JsonProperty(PropertyName = "image_poster")]
        public string ImagePosterLink { get; set; }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        [JsonProperty(PropertyName = "city_id")]
        public int CityId { get; set; }
    }
}