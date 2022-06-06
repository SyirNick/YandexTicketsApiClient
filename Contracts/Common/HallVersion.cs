namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Версия зала.
    /// </summary>
    public class HallVersion
    {
        /// <summary>
        /// Идентификатор версии.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Название версии.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Тип зала. Возможные значения:<br><br></br></br>
        /// HallSchemeVersion - версия схемы зала;<br></br>
        /// SeparateHall - отдельный зал (малая сцена).
        /// </summary>
        public HallType HallType { get; set; }

        /// <summary>
        /// Ссылка на схему зала в формате SVG.
        /// </summary>
        [JsonProperty(PropertyName = "svg")]
        public string SvgLink { get; set; }

        /// <summary>
        /// Ссылка на изображение схемы зала.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string ImageLink { get; set; }

        /// <summary>
        /// Тип отображения схемы зала. Возможные значения:<br><br></br></br>
        /// SingleScheme - секторы отображаются на одной схеме;<br></br>
        /// SectorList - отображается список секторов.
        /// </summary>
        public HallSchemeDisplayType HallSchemeDisplayType { get; set; }
    }
}