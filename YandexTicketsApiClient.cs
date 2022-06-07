global using RestSharp;
global using Newtonsoft.Json;
global using YandexTicketsApiWrapper.Contracts;

namespace YandexTicketsApiWrapper
{
    /// <summary>
    /// Обёртка для API Яндекс Билетов с ленивым синглтоном. Инициализация:<br></br>
    /// <c>YandexTicketsApiClient client = YandexTicketsApiClient.Instance;</c><br></br><br></br>
    /// Для смены хоста измените свойство BaseUrl на желаемое.<br></br>
    /// Список методов и их описание доступно здесь: <a href="https://github.com/SyirNick/YandexTicketsApiClient">https://github.com/SyirNick/YandexTicketsApiClient</a>
    /// </summary>
    public sealed class YandexTicketsApiClient
    {
        private static readonly Lazy<YandexTicketsApiClient> lazy =
            new Lazy<YandexTicketsApiClient>(() => new YandexTicketsApiClient());

        /// <summary>
        /// Для инициализации клиента используйте Instance:<br></br>
        /// <c>YandexTicketsApiClient client = YandexTicketsApiClient.Instance;</c>
        /// </summary>
        public static YandexTicketsApiClient Instance { get { return lazy.Value; } }

        private YandexTicketsApiClient()
        {
        }

        private RestRequest GetRestPostRequest() => new RestRequest(string.Empty, Method.Post);

        /// <summary>
        /// Хост для всех запросов к API. Измените это свойство, если необходимо, например, использовать тестовое окружение.<br></br>
        /// По умолчанию, хост равен <a href="https://api.tickets.yandex.net/api/agent">https://api.tickets.yandex.net/api/agent</a>.<br><br></br></br>
        /// Источник: <a href="https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html">https://yandex.ru/dev/afisha/tickets/doc/concepts/access.html</a>.
        /// </summary>
        public static Uri BaseUrl { get; set; } = new Uri("https://api.tickets.yandex.net/api/agent/");

        #region Информационные запросы

        /// <summary>
        /// Возвращает список мероприятий.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка мероприятий.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetActivitiesListResponse, содержащий статус ответа и список мероприятий, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>

        public async Task<GetActivitiesListResponse> GetActivitiesListAsync(GetActivitiesListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "activity.list", false)
                .AddQueryParameter("city_id", request.CityId, false)
                .AddOptionalParameter("limit", request.Limit)
                .AddOptionalParameter("offset", request.Offset)
            .ProceedAsync<GetActivitiesListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список городов.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка городов.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetCitiesListResponse, содержащий статус ответа и список городов, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetCitiesListResponse> GetCitiesListAsync(GetCitiesListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "city.list")
                .AddOptionalParameter("updated_after", request.GetDateTimeZone())
            .ProceedAsync<GetCitiesListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает информацию о событии.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса информации о событии.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetEventDetailsResponse, содержащий статус ответа и информацию о событии, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetEventDetailsResponse> GetEventDetailsAsync(GetEventDetailsRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "event.detail")
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("event_id", request.EventId)
                .AddOptionalParameter("organizer", request.IsOrganizerNeeded)
                .AddOptionalParameter("html", request.IsHtmlNeeded)
                .AddOptionalParameter("discount", request.IsDiscountNeeded)
            .ProceedAsync<GetEventDetailsResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список событий.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка событий.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetEventsListResponse, содержащий статус ответа и список событий, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetEventsListResponse> GetEventsListAsync(GetEventsListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "event.list")
                .AddQueryParameter("city_id", request.CityId)
                .AddOptionalParameter("limit", request.Limit)
                .AddOptionalParameter("offset", request.Offset)
                .AddOptionalParameter("venue_id", request.VenueId)
                .AddOptionalParameter("genre_id", request.GenreId)
                .AddOptionalParameter("activity_id", request.ActivityId)
                .AddOptionalParameter("search", request.Search)
                .AddOptionalParameter("start_date", request.StartDateTime.GetDay())
                .AddOptionalParameter("end_date", request.EndDateTime.GetDay())
                .AddOptionalParameter("updated_after", request.GetDateTimeZone())
            .ProceedAsync<GetEventsListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список секторов с билетами на событие.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка секторов с билетами на событие.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetSectorsWithTicketsListResponse, содержащий статус ответа и список секторов с билетами на событие, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetSectorsWithTicketsListResponse> GetSectorsWithTicketsListAsync(GetSectorsWithTicketsListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "event.sector.list")
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("event_id", request.EventId)
                .AddOptionalParameter("show_all", request.ShowAll)
            .ProceedAsync<GetSectorsWithTicketsListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список жанров.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка жанров.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetGenresListResponse, содержащий статус ответа и список жанров, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetGenresListResponse> GetGenresListAsync(GetGenresListRequest request) => await
            GetRestPostRequest()
                .AddQueryParameter("action", "genre.list")
                .AddQueryParameter("auth", request.Auth)
                .AddQueryParameter("city_id", request.CityId)
            .ProceedAsync<GetGenresListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает информацию о заказе.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса информации о заказе.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetOrderInfoResponse, содержащий статус ответа и информацию о заказе, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetOrderInfoResponse> GetOrderInfoAsync(GetOrderInfoRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "order.info")
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("id", request.OrderId)
            .ProceedAsync<GetOrderInfoResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список заказов.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка заказов.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetOrdersListResponse, содержащий статус ответа и список заказов, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetOrdersListResponse> GetOrdersListAsync(GetOrdersListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "order.list")
                .AddQueryParameter("city_id", request.CityId)
                .AddOptionalParameter("status", (int?)request.OrderStatus)
                .AddOptionalParameter("start_date", request.StartDateTime.GetDay())
                .AddOptionalParameter("end_date", request.EndDateTime.GetDay())
                .AddOptionalParameter("customer_id", request.CustomerId)
                .AddOptionalParameter("email", request.Email)
                .AddOptionalParameter("phone", request.Phone)
            .ProceedAsync<GetOrdersListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список проданных билетов.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка проданных билетов.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetSoldTicketsListResponse, содержащий статус ответа и список проданных билетов, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetSoldTicketsListResponse> GetSoldTicketsListAsync(GetSoldTicketsListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "order.ticket.list")
                .AddQueryParameter("city_id", request.CityId)
                .AddOptionalParameter("event_id", request.EventId)
                .AddOptionalParameter("start_date", request.StartDateTime.GetDay())
                .AddOptionalParameter("end_date", request.EndDateTime.GetDay())
            .ProceedAsync<GetSoldTicketsListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список групп мест в секторе.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка групп мест в секторе.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetSectorGroupsListResponse, содержащий статус ответа и список групп мест в секторе, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetSectorGroupsListResponse> GetSectorGroupsListAsync(GetSectorGroupsListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "sector.groups")
                .AddQueryParameter("sector_id", request.SectorId)
                .AddOptionalParameter("city_id", request.CityId)
            .ProceedAsync<GetSectorGroupsListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список секторов для версии зала.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка секторов для версии зала.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetSectorsListResponse, содержащий статус ответа и список секторов для версии зала, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetSectorsListResponse> GetSectorsListAsync(GetSectorsListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "sector.list")
                .AddQueryParameter("version_id", request.VersionId)
            .ProceedAsync<GetSectorsListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список схем секторов.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка схем секторов.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetSectorMapResponse, содержащий статус ответа и список схем секторов, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetSectorMapsListResponse> GetSectorMapAsync(GetSectorMapRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "sector.map")
                .AddQueryParameter("sector_id", request.SectorId)
            .ProceedAsync<GetSectorMapsListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список свободных билетов на событие.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка свободных билетов на событие.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetAvailableTicketsListResponse, содержащий статус ответа и список свободных билетов на событие, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetAvailableTicketsListResponse> GetAvailableTicketsListAsync(GetAvailableTicketsListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "ticket.list")
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("event_id", request.EventId)
                .AddOptionalParameter("sector_id", request.SectorId)
                .AddOptionalParameter("add_groups", request.AddGroups)
            .ProceedAsync<GetAvailableTicketsListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает информацию о месте проведения с доступными для продажи событиями.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса информации о месте проведения с доступными для продажи событиями.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetVenueDetailsResponse, содержащий статус ответа и информацию о месте проведения с доступными для продажи событиями, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetVenueDetailsResponse> GetVenueDetailsAsync(GetVenueDetailsRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "venue.detail")
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("venue_id", request.VenueId)
            .ProceedAsync<GetVenueDetailsResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список мест проведения с доступными для продажи событиями.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка мест проведения с доступными для продажи событиями.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetVenuesListResponse, содержащий статус ответа и список мест проведения с доступными для продажи событиями, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetVenuesListResponse> GetVenuesListAsync(GetVenuesListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "venue.list")
                .AddQueryParameter("city_id", request.CityId)
                .AddOptionalParameter("limit", request.Limit)
                .AddOptionalParameter("offset", request.Offset)
                .AddOptionalParameter("updated_after", request.GetDateTimeZone())
            .ProceedAsync<GetVenuesListResponse>(BaseUrl);

        #endregion

        #region Заказ билетов

        /// <summary>
        /// Предварительно бронирует билет.<br></br>
        /// Билет находится в корзине 15 минут, после чего бронь снимается.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса бронирования билета.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт BookTicketResponse, содержащий статус ответа и результат запроса бронирования билета.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<BookTicketResponse> BookTicketAsync(BookTicketRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "cart.add")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("id", request.TicketId)
            .ProceedAsync<BookTicketResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список вариантов доставки. 
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка вариантов доставки.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetCartDeliveriesListResponse, содержащий статус ответа и список вариантов доставки, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetCartDeliveriesListResponse> GetCartDeliveriesListAsync(GetCartDeliveriesListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "cart.deliveries")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
            .ProceedAsync<GetCartDeliveriesListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список предварительно забронированных билетов.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка предварительно забронированных билетов.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetBookedTicketsListResponse, содержащий статус ответа и список предварительно забронированных билетов, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetBookedTicketsListResponse> GetBookedTicketsListAsync(GetBookedTicketsListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "cart.detail")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
            .ProceedAsync<GetBookedTicketsListResponse>(BaseUrl);

        /// <summary>
        /// Возвращает список способов оплаты.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса списка способов оплаты.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetPaymentMethodsListResponse, содержащий статус ответа и список способов оплаты, если запрос выполнен успешно.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetPaymentMethodsListResponse> GetPaymentMethodsListAsync(GetPaymentMethodsListRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "cart.payments")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
            .ProceedAsync<GetPaymentMethodsListResponse>(BaseUrl);

        /// <summary>
        /// Снимает предварительную бронь билета.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для запроса снятия предварительной брони билета.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт CancelBookingResponse, содержащий статус ответа и результат запроса снятия предварительной брони билета.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<CancelBookingResponse> CancelBookingAsync(CancelBookingRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "cart.remove")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("id", request.TicketId)
            .ProceedAsync<CancelBookingResponse>(BaseUrl);

        /// <summary>
        /// Создаёт заказ, возвращает идентификатор созданного заказа.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для создания заказа.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт CreateOrderResponse, содержащий статус ответа и объект, содержащий идентификатор созданного заказа.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "order.create")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("name", request.Name)
                .AddQueryParameter("phone", request.Phone)
                .AddOptionalParameter("email", request.Email)
                .AddOptionalParameter("address", request.Address)
                .AddOptionalParameter("customer_id", request.CustomerId)
                .AddOptionalParameter("utm_source", request.UtmSource)
                .AddOptionalParameter("promocode", request.Promocode)
                .AddOptionalParameter("amount", request.Amount)
                .AddOptionalParameter("lang", request.GetLanguage())
                .AddOptionalParameter("payment_id", request.PaymentId)
                .AddOptionalParameter("delivery_id", request.DeliveryId)
                .AddOptionalParameter("delivery_day", request.DeliveryDateTime.GetDay())
            .ProceedAsync<CreateOrderResponse>(BaseUrl);

        /// <summary>
        /// Возвращает сумму скидки, если переданный в запросе промокод можно применить к предварительно забронированному билету.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для проверки применимости промокода к предварительно забронированному билету.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт CheckPromoResponse, содержащий статус ответа и сумму скидки с промокодом, если переданный в запросе промокод можно применить к предварительно забронированному билету.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<CheckPromoResponse> CheckPromoAsync(CheckPromoRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "order.create")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("code", request.Promocode)
            .ProceedAsync<CheckPromoResponse>(BaseUrl);

        #endregion

        #region Операции с заказами

        /// <summary>
        /// Изменяет статус заказа на "аннулирован".
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для изменения статуса заказа на "аннулирован".</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт SetOrderCanceledResponse, содержащий статус ответа и информацию об успешности изменения заказа.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<SetOrderCanceledResponse> SetOrderCanceledAsync(SetOrderCanceledRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "order.cancel")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("id", request.OrderId)
            .ProceedAsync<SetOrderCanceledResponse>(BaseUrl);

        /// <summary>
        /// Изменяет статус заказа на "доставка".
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для изменения статуса заказа на "доставка".</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт SetOrderDeliveringResponse, содержащий статус ответа и информацию об успешности изменения заказа.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<SetOrderDeliveringResponse> SetOrderDeliveringAsync(SetOrderDeliveringRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "order.delivery")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("id", request.OrderId)
            .ProceedAsync<SetOrderDeliveringResponse>(BaseUrl);

        /// <summary>
        /// Отправляет электронный билет покупателю.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для отправки электронного билета покупателю.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт SendOnlineTicketResponse, содержащий статус ответа и информацию об успешности отправки билета.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<SendOnlineTicketResponse> SendOnlineTicketAsync(SendOnlineTicketRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "order.eticket.send")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("id", request.OrderId)
                .AddQueryParameter("currency", request.Currency)
            .ProceedAsync<SendOnlineTicketResponse>(BaseUrl);

        /// <summary>
        /// Возвращает HTML-форму с кнопкой перехода на страницу оплаты.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для получения HTML-формы с кнопкой перехода на страницу оплаты.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт GetPaymentHtmlResponse, содержащий статус ответа и код HTML-формы с кнопкой перехода на страницу оплаты.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<GetPaymentHtmlResponse> GetPaymentHtmlAsync(GetPaymentHtmlRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "order.payment")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("id", request.OrderId)
            .ProceedAsync<GetPaymentHtmlResponse>(BaseUrl);

        /// <summary>
        /// Изменяет статус заказа на "продан".
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для изменения статуса заказа на "продан".</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт SetOrderSoldResponse, содержащий статус ответа и информацию об успешности изменения заказа.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<SetOrderSoldResponse> SetOrderSoldAsync(SetOrderSoldRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "order.sold")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("id", request.OrderId)
            .ProceedAsync<SetOrderSoldResponse>(BaseUrl);

        /// <summary>
        /// Аннулирует билет в заказе.
        /// </summary>
        /// <param name="request">Объект, содержащий в себе информацию, необходимую для аннулирования билета в заказе.</param>
        /// <returns>
        /// При наличии ответа от API Яндекс Билеты, вернёт RemoveTicketResponse, содержащий статус ответа и информацию об успешности изменения заказа.<br></br>
        /// При внутренней ошибке клиента выкинет YandexTicketsException.
        /// </returns>
        public async Task<RemoveTicketResponse> RemoveTicketAsync(RemoveTicketRequest request) => await
            request.GetBaseRequest()
                .AddQueryParameter("action", "order.cancel")
                .AddQueryParameter("uid", request.SessionId)
                .AddQueryParameter("city_id", request.CityId)
                .AddQueryParameter("id", request.OrderId)
            .ProceedAsync<RemoveTicketResponse>(BaseUrl);

        #endregion
    }
}