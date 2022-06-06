namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Группа мест в секторе.
    /// </summary>
    public class SectorGroup
    {
        /// <summary>
        /// Название группы.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public int Name { get; set; }

        /// <summary>
        /// Массив идентификаторов мест на схеме.
        /// </summary>
        [JsonProperty(PropertyName = "places")]
        public int[] Places { get; set; }
    }
}