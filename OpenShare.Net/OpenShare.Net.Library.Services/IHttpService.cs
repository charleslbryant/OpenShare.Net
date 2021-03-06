﻿using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OpenShare.Net.Library.Services
{
    public interface IHttpService
    {
        Task<HttpResponseMessage> LoginAsync(string url, Dictionary<string, string> content, CancellationToken cancellationToken = default(CancellationToken));
        Task<HttpResponseMessage> LoginJsonAsync(string url, Dictionary<string, string> content, CancellationToken cancellationToken = default(CancellationToken));
        Task<string> RequestAsync(HttpMethod httpMethod, string url, Dictionary<string, string> content, bool skipStatusCheck = false, CancellationToken cancellationToken = default(CancellationToken));
        Task<string> RequestJsonAsync(HttpMethod httpMethod, string url, Dictionary<string, string> content, bool skipStatusCheck = false, CancellationToken cancellationToken = default(CancellationToken));
        Task<byte[]> RequestBytesAsync(HttpMethod httpMethod, string url, Dictionary<string, string> content, bool skipStatusCheck = false, CancellationToken cancellationToken = default(CancellationToken));
        Task<byte[]> RequestBytesJsonAsync(HttpMethod httpMethod, string url, Dictionary<string, string> content, bool skipStatusCheck = false, CancellationToken cancellationToken = default(CancellationToken));
        Task RequestStreamAsync(HttpMethod httpMethod, string url, Dictionary<string, string> content, Stream stream, bool skipStatusCheck = false, CancellationToken cancellationToken = default(CancellationToken));
        Task RequestStreamJsonAsync(HttpMethod httpMethod, string url, Dictionary<string, string> content, Stream stream, bool skipStatusCheck = false, CancellationToken cancellationToken = default(CancellationToken));
    }
}
