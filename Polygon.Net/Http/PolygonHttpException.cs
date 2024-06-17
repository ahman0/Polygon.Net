using System;

namespace Polygon.Net
{
    public class PolygonHttpException : Exception
    {
        public PolygonHttpException(string message, int statusCode)
        : base(message)
        {
            StatusCode = statusCode;
        }

        public int StatusCode { get; }
    }
}
