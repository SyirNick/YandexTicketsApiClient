namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Мероприятие.
    /// </summary>
    public class Activity
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
        /// Массив идентификаторов жанров.
        /// </summary>
        [JsonProperty(PropertyName = "genres_id")]
        public int[] GenresId { get; set; }

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
        /// Описание мероприятия.
        /// </summary>
        [JsonProperty(PropertyName = "descr")]
        public string Description { get; set; }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        [JsonProperty(PropertyName = "city_id")]
        public int CityId { get; set; }
    }
}