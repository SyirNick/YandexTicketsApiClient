namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Информация о заказе.<br><br></br></br>
    /// </summary>
    public class EventDetails
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
        /// Тип отображения схемы. Возможные значения:<br></br><br></br>
        /// Common - общая схема;<br></br>
        /// Sectors - список секторов.
        /// </summary>
        [JsonProperty(PropertyName = "version_show")]
        public SchemeDisplayType SchemeDisplayType { get; set; }

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
        /// Адрес места проведения.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Дата события.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

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
        /// Описание события.
        /// </summary>
        [JsonProperty(PropertyName = "descr")]
        public string Description { get; set; }

        /// <summary>
        /// Статус события. Возможные значения:<br></br><br></br>
        /// Closed - закрыто;<br></br>
        /// InSale - в продаже.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public EventStatus Status { get; set; }

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
        /// Заголовок страницы.
        /// </summary>
        [JsonProperty(PropertyName = "meta_title")]
        public string MetaTitle { get; set; }

        /// <summary>
        /// Описание страницы.
        /// </summary>
        [JsonProperty(PropertyName = "meta_descr")]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Ключевые слова.
        /// </summary>
        [JsonProperty(PropertyName = "meta_kw")]
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Количество часов до события, когда прекращается продажа билетов.
        /// </summary>
        [JsonProperty(PropertyName = "close_to")]
        public int CloseTo { get; set; }

        /// <summary>
        /// Данные об организаторе. Возвращается, если organizer == true в запросе.
        /// </summary>
        [JsonProperty(PropertyName = "organizer")]
        public Organizer Organizer { get; set; }

        /// <summary>
        /// Список скидок. Возвращается, если discounts == true в запросе.
        /// </summary>
        [JsonProperty(PropertyName = "discounts")]
        public List<Discount> Discounts { get; set; }
    }
}