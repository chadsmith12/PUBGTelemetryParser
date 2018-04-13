using System.Net;

namespace PUBGTelemetryParser
{
    /// <summary>
    /// Defines the base ApiResponse.
    /// </summary>
    /// <typeparam name="TData">The type of data that you expecting to get back in the response.</typeparam>
    public class ApiResponse<TData>
    {
        /// <summary>
        /// If this was a success or not.
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// The data gotten back from the api request.
        /// </summary>
        public TData Data { get; set; }
        /// <summary>
        /// The status code if there was an error.
        /// </summary>
        public HttpStatusCode ErrorCode { get; set; }
        /// <summary>
        /// The error message if there was an error.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
