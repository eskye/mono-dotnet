using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Mono.Net.Sdk.Helpers
{
    /// <summary>
    /// Provides methods for parsing and manipulating query strings.
    /// </summary>
    public static class QueryHelpers
    {
        /// <summary>
        /// Append the given query key and value to the URI.
        /// </summary>
        /// <param name="uri">The base URI.</param>
        /// <param name="name">The name of the query key.</param>
        /// <param name="value">The query value.</param>
        /// <returns>The combined result.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="uri"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
        public static string AddQueryString(string uri, string name, string value)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return AddQueryString(
                uri, new[] { new KeyValuePair<string, string>(name, value) });
        }

        /// <summary>
        /// Append the given query keys and values to the uri.
        /// </summary>
        /// <param name="uri">The base uri.</param>
        /// <param name="queryString">A collection of name value query pairs to append.</param>
        /// <returns>The combined result.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="uri"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="queryString"/> is <c>null</c>.</exception>
        public static string AddQueryString(string uri, IDictionary<string, string> queryString)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            if (queryString == null)
            {
                throw new ArgumentNullException(nameof(queryString));
            }

            return AddQueryString(uri, (IEnumerable<KeyValuePair<string, string>>)queryString);
        }

        private static string AddQueryString(
            string uri,
            IEnumerable<KeyValuePair<string, string>> queryString)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            if (queryString == null)
            {
                throw new ArgumentNullException(nameof(queryString));
            }

            var anchorIndex = uri.IndexOf('#');
            var uriToBeAppended = uri;
            var anchorText = "";
            // If there is an anchor, then the query string must be inserted before its first occurrence.
            if (anchorIndex != -1)
            {
                anchorText = uri.Substring(anchorIndex);
                uriToBeAppended = uri.Substring(0, anchorIndex);
            }

            var queryIndex = uriToBeAppended.IndexOf('?');
            var hasQuery = queryIndex != -1;

            var sb = new StringBuilder();
            sb.Append(uriToBeAppended);
            foreach (var parameter in queryString)
            {
                if (parameter.Value == null)
                {
                    continue;
                }

                sb.Append(hasQuery ? '&' : '?');
                sb.Append(WebUtility.UrlEncode(parameter.Key));
                sb.Append('=');
                sb.Append(WebUtility.UrlEncode(parameter.Value));
                hasQuery = true;
            }

            sb.Append(anchorText);
            return sb.ToString();
        }
    }
}