namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Жанр.
    /// </summary>
    public class Genre
    {
        /// <summary>
        /// Идентификатор жанра.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Название жанра.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор родительского жанра (0 - для родителя).
        /// </summary>
        [JsonProperty(PropertyName = "parent_id")]
        public int ParentId { get; set; }
    }
}