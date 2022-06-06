namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Сектор для версии зала.
    /// </summary>
    public class Sector
    {
        /// <summary>
        /// Идентификатор сектора.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Название сектора.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Тип мест. Возможные значения:<br><br></br></br>
        /// Unnumbered - ненумерованные;<br></br>
        /// Numbered - нумерованные.
        /// </summary>
        public SeatType SeatType { get; set; }
    }
}