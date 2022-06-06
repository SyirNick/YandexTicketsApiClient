namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Версия зала.
    /// </summary>
    public class HallVersionShort
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
        [JsonProperty(PropertyName = "type")]
        public HallType HallType { get; set; }
    }
}