using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Iota.NetCore.RestClient
{
    public class GenericWebClient : IGenericWebClient
    {
        /// <summary>
        /// Gets or sets the hostname
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets the port
        /// </summary>
        public int Port { get; set; }

        public GenericWebClient(string hostName, int port)
        {
            if (string.IsNullOrWhiteSpace(hostName))
                throw new ArgumentNullException(nameof(hostName));

            this.Hostname = hostName;
            this.Port = port;
        }


        /// <summary>
        /// Requests the specified request.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public TResponse Request<TRequest, TResponse>(TRequest request) where TResponse : new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Requests the specified request asynchronously
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="request">The request.</param>
        public Task<TResponse> RequestAsync<TRequest, TResponse>(TRequest request) where TResponse : new()
        {
            throw new NotImplementedException();
        }
    }
}
