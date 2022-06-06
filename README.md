# YandexTicketsApiClient

Open-source обёртка для API Яндекс Билетов. Описание апи: https://yandex.ru/dev/afisha/tickets/doc/concepts/index.html

# Инициализация клиента

Клиент использует ленивый синглтон, поэтому инициализация возможна следующим образом:

_YandexTicketsApiClient client = YandexTicketsApiClient.Instance;_

# Методы API

**Информационные запросы**

GetActivitiesListAsync - возвращает список мероприятий;

GetCitiesListAsync - возвращает список городов;

GetEventDetailsAsync - возвращает информацию о событии;

GetEventsListAsync - возвращает список событий;

GetSectorsWithTicketsListAsync - возвращает список секторов с билетами на событие;

GetGenresListAsync - возвращает список жанров;

GetOrderInfoAsync - возвращает информацию о заказе;

GetOrdersListAsync - возвращает список заказов;

GetSoldTicketsListAsync - возвращает список проданных билетов;

GetSectorGroupsListAsync - возвращает список групп мест в секторе;

GetSectorsListAsync - возвращает список секторов для версии зала;

GetSectorMapAsync - возвращает схему сектора;

GetAvailableTicketsListAsync - возвращает список свободных билетов на событие;

GetVenueDetailsAsync - возвращает информацию о месте проведения с доступными для продажи событиями;

GetVenuesListAsync - возвращает список мест проведения с доступными для продажи событиями;

**Заказ билетов**

BookTicketAsync - предварительно бронирует билет. Билет находится в корзине 15 минут, после чего бронь снимается;

GetCartDeliveriesListAsync - возвращает список вариантов доставки;

GetBookedTicketsListAsync - возвращает список предварительно забронированных билетов;

GetPaymentMethodsListAsync - возвращает список способов оплаты;

CancelBookingAsync - снимает предварительную бронь билета;

CreateOrderAsync - создаёт заказ, возвращает идентификатор созданного заказа;

CheckPromoAsync - возвращает сумму скидки, если переданный в запросе промокод можно применить к предварительно забронированному билету;

**Операции с заказами**

SetOrderCanceledAsync - изменяет статус заказа на "аннулирован";

SetOrderDeliveringAsync - изменяет статус заказа на "доставка";

SendOnlineTicketAsync - отправляет электронный билет покупателю;

GetPaymentHtmlAsync - возвращает HTML-форму с кнопкой перехода на страницу оплаты;

SetOrderSoldAsync - изменяет статус заказа на "продан";

RemoveTicketAsync - аннулирует билет в заказе;
