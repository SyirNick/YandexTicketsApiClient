namespace YandexTicketsApiWrapper.Contracts
{
    public class GetPaymentHtmlResponse : ResponseBase
    {
        /// <summary>
        /// HTML-код формы с кнопкой перехода на страницу оплаты.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string HtmlFormCode { get; set; }
    }
}