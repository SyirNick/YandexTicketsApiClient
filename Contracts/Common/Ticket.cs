namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Билет.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Идентификатор билета.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор события.
        /// </summary>
        [JsonProperty(PropertyName = "event_id")]
        public int EventId { get; set; }

        /// <summary>
        /// Статус билета. Возможные значения:<br><br></br></br>
        /// Canceled - аннулирован;<br></br>
        /// Active - активен.<br></br>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public TicketStatus Status { get; set; }

        /// <summary>
        /// Цена билета.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public int Price { get; set; }

        /// <summary>
        /// Цена билета без скидки.
        /// </summary>
        [JsonProperty(PropertyName = "original_price")]
        public int OriginalPrice { get; set; }

        /// <summary>
        /// Сервисный сбор.
        /// </summary>
        [JsonProperty(PropertyName = "fee")]
        public int Fee { get; set; }

        /// <summary>
        /// Сервисный сбор без скидки.
        /// </summary>
        [JsonProperty(PropertyName = "original_fee")]
        public int OriginalFee { get; set; }

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
        /// Идентификатор места.
        /// </summary>
        [JsonProperty(PropertyName = "place_id")]
        public int PlaceId { get; set; }

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
        /// Штрихкод (для заказов в статусе 1 — продан или 3 — доставка).
        /// </summary>
        [JsonProperty(PropertyName = "barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Данные организатора для печати на билете.
        /// </summary>
        [JsonProperty(PropertyName = "organizer")]
        public Organizer Organizer { get; set; }
    }
}