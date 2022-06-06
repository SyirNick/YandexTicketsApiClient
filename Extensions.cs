namespace YandexTicketsApiWrapper
{
    /// <summary>
    /// Методы расширения для внутреннего пользования.
    /// </summary>
    internal static class Extensions
    {
        /// <summary>
        /// Обёртка для выполнения всех запросов RestClient-ом.
        /// </summary>
        internal async static Task<T> ProceedAsync<T>(this RestRequest request, Uri baseUrl)
        {
            var response = await new RestClient(baseUrl).ExecuteAsync(request);

            if (response == null)
                throw new YandexTicketsException("Получен null вместо ответа от сервера.");

            if (!response.IsSuccessful)
            {
                throw new YandexTicketsException($"Внутренняя ошибка клиента. Ответ от сервера: \"{response.Content}\", код ответа: \"{response.StatusCode}\".");
            }

            var t = JsonConvert.DeserializeObject<T>(response.Content ?? string.Empty);

            if (t == null)
                throw new YandexTicketsException($"Ошибка десериализации. Ответ от сервера: \"{response.Content}\", тип: \"{typeof(T).FullName}\".");

            return t;
        }

        /// <summary>
        /// Если опциональный параметр не null, добавляет его в запрос.
        /// </summary>
        internal static RestRequest AddOptionalParameter(this RestRequest request, string parameterName, object parameterValue)
        { 
            if(parameterValue != null)
                request.AddParameter(parameterName, parameterValue.ToString());

            return request;
        }

        /// <summary>
        /// Конвертирует DateTime + TimeZone в формат yyyy-MM-ddTHH:mm:ss±hh.
        /// </summary>
        internal static string GetDateTimeZone(this IContainDateTimeZone dtTz)
        {
            if (dtTz.UpdatedAfterDateTime == null || dtTz.UpdatedAfterTimeZone == null)
                return null;

            var offset = dtTz.UpdatedAfterTimeZone.BaseUtcOffset;
            string sign = offset < TimeSpan.Zero ? "-" : "+";
            return $"{dtTz.UpdatedAfterDateTime:yyyy-MM-ddTHH:mm:ss}{sign}{offset:hh}";
        }

        /// <summary>
        /// Получает день из DateTime или возвращает null.
        /// </summary>
        internal static string GetDay(this DateTime? dt) =>
            dt == null || !dt.HasValue ? null : dt.Value.ToString("yyyy-MM-dd");

        internal static RestRequest GetBaseRequest(this RequestBase request) =>
            new RestRequest(string.Empty, Method.Post)
                .AddParameter("auth", request.Auth);

        internal static string GetLanguage(this CreateOrderRequest request) =>
            request.Language == null || !request.Language.HasValue ? null : request.Language.Value.ToString().ToLower();


        /// <summary>
        /// Получить hex массива байтов.
        /// </summary>
        internal static string GetHex(this byte[] bytes)
        {
            var sb = new System.Text.StringBuilder();
            foreach (byte b in bytes)
                sb.AppendFormat("{0:x2}", b);
            return sb.ToString();
        }

        /// <summary>
        /// Получить MD5 хэш.
        /// </summary>
        internal static string GetMd5(this string s)
        {
            var md5 = System.Security.Cryptography.MD5.Create();
            var bytes = System.Text.Encoding.ASCII.GetBytes(s);
            return md5.ComputeHash(bytes).GetHex();
        }

        /// <summary>
        /// Получить SHA-1 хэш.
        /// </summary>
        internal static string GetSha1(this string s)
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var bytes = System.Text.Encoding.ASCII.GetBytes(s);
            return sha1.ComputeHash(bytes).GetHex();
        }
    }
}