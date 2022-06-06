namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Класс запроса списка заказов.
    /// </summary>
    public class GetOrdersListRequest : RequestBase
    {
        /// <summary>
        /// Конструктор класса запроса списка заказов.
        /// </summary>
        /// <param name="auth">
        /// Идентификатор внешней системы. Можно сгенерировать статическим методом RequestBase.GetAuth(string, string).<br></br>
        /// Подробнее о его формировании: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </param>
        /// <param name="cityId">Идентификатор города.</param>
        /// <param name="orderStatus">
        /// Статус заказа. Необязательный параметр. Возможные значения:<br><br></br></br>
        /// Canceled - аннулирован;<br></br>
        /// Sold - продан;<br></br>
        /// Booked - бронь;<br></br>
        /// Delivery - доставка.
        /// </param>
        /// <param name="startDateTime">Дата с точностью до дня, начиная с которой (включительно) события возвращаются в ответе. Необязательный параметр.</param>
        /// <param name="endDateTime">Дата с точностью до дня, до которой (включительно) события возвращаются в ответе. Необязательный параметр.</param>
        /// <param name="customerId">Идентификатор покупателя. Необязательный параметр.</param>
        /// <param name="email">Электронная почта покупателя. Необязательный параметр.</param>
        /// <param name="phone">Номер телефона покупателя. Необязательный параметр.</param>
        public GetOrdersListRequest(string auth, int cityId, OrderStatus? orderStatus = null, DateTime? startDateTime = null,
            DateTime? endDateTime = null, int? customerId = null, string email = null, string phone = null)
        { 
            Auth = auth;
            CityId = cityId;
            OrderStatus = orderStatus;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            CustomerId = customerId;
            Email = email;
            Phone = phone;
        }

        /// <summary>
        /// Идентификатор города.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Статус заказа. Необязательный параметр. Возможные значения:<br><br></br></br>
        /// Canceled - аннулирован;<br></br>
        /// Sold - продан;<br></br>
        /// Booked - бронь;<br></br>
        /// Delivery - доставка.
        /// </summary>
        public OrderStatus? OrderStatus { get; set; }

        /// <summary>
        /// Дата с точностью до дня, начиная с которой (включительно) события возвращаются в ответе. Необязательный параметр.
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Дата с точностью до дня, до которой (включительно) события возвращаются в ответе. Необязательный параметр.
        /// </summary>
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Идентификатор покупателя. Необязательный параметр.
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// Электронная почта покупателя. Необязательный параметр.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Номер телефона покупателя. Необязательный параметр.
        /// </summary>
        public string Phone { get; set; }
    }
}