namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Сектор с билетами.
    /// </summary>
    public class SectorWithTickets
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
        [JsonProperty(PropertyName = "type")]
        public SeatType SeatType { get; set; }

        /// <summary>
        /// Минимальная номинальная стоимость билетов.
        /// </summary>
        [JsonProperty(PropertyName = "min_price")]
        public int MinPrice { get; set; }

        /// <summary>
        /// Максимальная номинальная стоимость билетов.
        /// </summary>
        [JsonProperty(PropertyName = "max_price")]
        public int MaxPrice { get; set; }

        /// <summary>
        /// Минимальная стоимость билетов с сервисным сбором.
        /// </summary>
        [JsonProperty(PropertyName = "min_full_price")]
        public int MinFullPrice { get; set; }

        /// <summary>
        /// Максимальная стоимость билетов с сервисным сбором.
        /// </summary>
        [JsonProperty(PropertyName = "max_full_price")]
        public int MaxFullPrice { get; set; }

        /// <summary>
        /// Количество доступных билетов.
        /// </summary>
        [JsonProperty(PropertyName = "tickets")]
        public int TicketsAvailable { get; set; }
    }
}