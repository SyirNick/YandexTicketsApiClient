namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Предварительно забронированный билет.
    /// </summary>
    public class BookedTicket
    {
        /// <summary>
        /// Идентификатор билета.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Цена билета.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public int Price { get; set; }

        /// <summary>
        /// Сервисный сбор.
        /// </summary>
        [JsonProperty(PropertyName = "fee")]
        public int Fee { get; set; }

        /// <summary>
        /// Тип мест. Возможные значения:<br><br></br></br>
        /// Unnumbered - ненумерованные;<br></br>
        /// Numbered - нумерованные.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public SeatType SeatType { get; set; }

        /// <summary>
        /// Название сектора.
        /// </summary>
        [JsonProperty(PropertyName = "sector")]
        public string Sector { get; set; }

        /// <summary>
        /// Идентификатор сектора.
        /// </summary>
        [JsonProperty(PropertyName = "sector_id")]
        public int SectorId { get; set; }

        /// <summary>
        /// Номер ряда.
        /// </summary>
        [JsonProperty(PropertyName = "row")]
        public string Row { get; set; }

        /// <summary>
        /// Номер места.
        /// </summary>
        [JsonProperty(PropertyName = "place")]
        public string Place { get; set; }

        /// <summary>
        /// Штрихкод (для заказов в статусе "продан" или "доставка").
        /// </summary>
        [JsonProperty(PropertyName = "barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Идентификатор места.
        /// </summary>
        [JsonProperty(PropertyName = "place_id")]
        public int PlaceId { get; set; }

        /// <summary>
        /// Идентификатор события.
        /// </summary>
        [JsonProperty(PropertyName = "event_id")]
        public int EventId { get; set; }
    }
}