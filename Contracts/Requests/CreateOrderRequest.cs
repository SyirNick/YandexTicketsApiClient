namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса создания заказа.
    /// </summary>
    public class CreateOrderRequest : TicketOrderRequestBase
    {
        /// <summary>
        /// Конструктор класса запроса создания заказа.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="sessionId">Идентификатор сессии, постоянный для всей сессии (не менее 20 символов).</param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="name">Имя покупателя.</param>
        /// <param name="phone">Номер телефона покупателя.</param>
        /// <param name="email">Электронный адрес покупателя. Необязательный параметр.</param>
        /// <param name="address">Адрес доставки заказа. Необязательный параметр.</param>
        /// <param name="customerId">Идентификатор покупателя. Необязательный параметр.</param>
        /// <param name="utmSource">UTM-метка. Необязательный параметр.</param>
        /// <param name="promocode">Промокод. Необязательный параметр.</param>
        /// <param name="amount">Сумма номинальной стоимости билетов. Необязательный параметр.</param>
        /// <param name="language">
        /// Язык покупателя. Необязательный параметр. Возможные значения:<br></br><br></br>
        /// Ru - русский (по умолчанию);<br></br>
        /// En - английский;<br></br>
        /// Ee - эстонский.
        /// </param>
        /// <param name="paymentId">Идентификатор способа оплаты. Необязательный параметр.</param>
        /// <param name="deliveryId">Идентификатор варианта доставки. Необязательный параметр.</param>
        /// <param name="deliveryDateTime">Дата доставки. Необязательный параметр.</param>
        public CreateOrderRequest(string auth, string sessionId, int cityId, string name, string phone, string email = null, string address = null, int? customerId = null,
            string utmSource = null, string promocode = null, int? amount = null, Language? language = null, int? paymentId = null, int? deliveryId = null, DateTime? deliveryDateTime = null)
        { 
            Auth = auth;
            SessionId = sessionId;
            CityId = cityId;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            CustomerId = customerId;
            UtmSource = utmSource;
            Promocode = promocode;
            Amount = amount;
            Language = language;
            PaymentId = paymentId;
            DeliveryId = deliveryId;
            DeliveryDateTime = deliveryDateTime;
        }

        /// <summary>
        /// Имя покупателя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Номер телефона покупателя.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Электронный адрес покупателя. Необязательный параметр.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Адрес доставки заказа. Необязательный параметр.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Идентификатор покупателя. Необязательный параметр.
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// UTM-метка. Необязательный параметр.
        /// </summary>
        public string UtmSource { get; set; }

        /// <summary>
        /// Промокод. Необязательный параметр.
        /// </summary>
        public string Promocode { get; set; }

        /// <summary>
        /// Сумма номинальной стоимости билетов. Необязательный параметр.
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// Язык покупателя. Необязательный параметр. Возможные значения:<br></br><br></br>
        /// Ru - русский (по умолчанию);<br></br>
        /// En - английский;<br></br>
        /// Ee - эстонский.
        /// </summary>
        public Language? Language { get; set; }

        /// <summary>
        /// Идентификатор способа оплаты. Необязательный параметр.
        /// </summary>
        public int? PaymentId { get; set; }

        /// <summary>
        /// Идентификатор варианта доставки. Необязательный параметр.
        /// </summary>
        public int? DeliveryId { get; set; }

        /// <summary>
        /// Дата доставки. Необязательный параметр.
        /// </summary>
        public DateTime? DeliveryDateTime { get; set; }
    }
}