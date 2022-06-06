namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Схема сектора.
    /// </summary>
    public class SectorMap
    {
        /// <summary>
        /// Идентификатор схемы.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Координата X.
        /// </summary>
        [JsonProperty(PropertyName = "x")]
        public int X { get; set; }

        /// <summary>
        /// Координата Y.
        /// </summary>
        [JsonProperty(PropertyName = "y")]
        public int Y { get; set; }

        /// <summary>
        /// Тип схемы сектора. Возможные значения:<br><br></br></br>
        /// Place - место в зале;<br></br>
        /// Text - текстовая метка.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public SectorSchemeType Type { get; set; }

        /// <summary>
        /// Номер ряда. Возвращается, если SectorScheme.Type == SectorSchemeType.Place.
        /// </summary>
        [JsonProperty(PropertyName = "row_num")]
        public string RowNumber { get; set; }

        /// <summary>
        /// Название ряда. Возвращается, если SectorScheme.Type == SectorSchemeType.Place.
        /// </summary>
        [JsonProperty(PropertyName = "row_name")]
        public string RowName { get; set; }

        /// <summary>
        /// Номер места. Возвращается, если SectorScheme.Type == SectorSchemeType.Place.
        /// </summary>
        [JsonProperty(PropertyName = "place_num")]
        public string PlaceNum { get; set; }

        /// <summary>
        /// Название места. Возвращается, если SectorScheme.Type == SectorSchemeType.Place.
        /// </summary>
        [JsonProperty(PropertyName = "place_name")]
        public string PlaceName { get; set; }

        /// <summary>
        /// Текст. Возвращается, если SectorScheme.Type == SectorSchemeType.Place.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Размер текста. Возвращается, если SectorScheme.Type == SectorSchemeType.Place.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }
    }
}