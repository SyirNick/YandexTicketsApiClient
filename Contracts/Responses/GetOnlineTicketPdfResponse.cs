namespace YandexTicketsApiWrapper.Contracts
{
    /// <summary>
    /// Результат выполнения запроса получения PDF-файла с электронным билетом или массива PDF-файлов для нескольких билетов в строке Base64.<br><br></br></br>
    /// Важно - документации мало: <a href="https://yandex.ru/dev/afisha/tickets/doc/ref/operations/order_eticket.html">https://yandex.ru/dev/afisha/tickets/doc/ref/operations/order_eticket.html</a>, надо тестировать и проверять.
    /// </summary>
    public class GetOnlineTIcketPdfResponse
    {
        /// <summary>
        /// PDF-файл с электронным билетом или массив PDF-файлов для нескольких билетов в строке Base64.<br><br></br></br>
        /// Важно - документации мало: <a href="https://yandex.ru/dev/afisha/tickets/doc/ref/operations/order_eticket.html">https://yandex.ru/dev/afisha/tickets/doc/ref/operations/order_eticket.html</a>, надо тестировать и проверять.
        /// </summary>
        public string Pdf { get; set; }
    }
}