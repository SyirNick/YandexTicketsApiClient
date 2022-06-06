namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Свободный билет на событие.
    /// </summary>
    public class AvailableTicket
    {
        /// <summary>
        /// Идентификатор билета.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Цена.
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
        public int Row { get; set; }

        /// <summary>
        /// Номер места.
        /// </summary>
        [JsonProperty(PropertyName = "place")]
        public string Place { get; set; }

        /// <summary>
        /// Идентификатор места.
        /// </summary>
        [JsonProperty(PropertyName = "place_id")]
        public int PlaceId { get; set; }

        /// <summary>
        /// Скидка от номинальной стоимости билета.
        /// </summary>
        [JsonProperty(PropertyName = "discount_price")]
        public int DiscountPrice { get; set; }

        /// <summary>
        /// Процент скидки от номинальной стоимости билета. Возвращается, если скидка была задана процентом, а не суммой.
        /// </summary>
        [JsonProperty(PropertyName = "discount_percent")]
        public int DiscountPercent { get; set; }
    }
}