namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения списка групп мест в секторе.
    /// </summary>
    public class GetSectorGroupsListResponse : ResponseBase
    {
        /// <summary>
        /// Список групп мест в секторе.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<SectorGroup> SectorGroups { get; set; }
    }
}