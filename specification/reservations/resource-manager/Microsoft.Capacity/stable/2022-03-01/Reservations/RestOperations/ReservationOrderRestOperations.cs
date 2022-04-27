// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.Azure.Management.Reservations.Models;

namespace Microsoft.Azure.Management.Reservations
{
    internal partial class ReservationOrderRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ReservationOrderRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ReservationOrderRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCalculateRequest(PurchaseRequest body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Capacity/calculatePrice", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Calculate price for placing a `ReservationOrder`. </summary>
        /// <param name="body"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async Task<Response<CalculatePriceResponse>> CalculateAsync(PurchaseRequest body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using var message = CreateCalculateRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CalculatePriceResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CalculatePriceResponse.DeserializeCalculatePriceResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Calculate price for placing a `ReservationOrder`. </summary>
        /// <param name="body"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public Response<CalculatePriceResponse> Calculate(PurchaseRequest body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using var message = CreateCalculateRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CalculatePriceResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CalculatePriceResponse.DeserializeCalculatePriceResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Capacity/reservationOrders", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List of all the `ReservationOrder`s that the user has access to in the current tenant. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ReservationOrderList>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationOrderList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationOrderList.DeserializeReservationOrderList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List of all the `ReservationOrder`s that the user has access to in the current tenant. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ReservationOrderList> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationOrderList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationOrderList.DeserializeReservationOrderList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePurchaseRequest(string reservationOrderId, PurchaseRequest body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Capacity/reservationOrders/", false);
            uri.AppendPath(reservationOrderId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Purchase `ReservationOrder` and create resource under the specified URI. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="body"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="body"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> PurchaseAsync(string reservationOrderId, PurchaseRequest body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNull(body, nameof(body));

            using var message = CreatePurchaseRequest(reservationOrderId, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Purchase `ReservationOrder` and create resource under the specified URI. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="body"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="body"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Purchase(string reservationOrderId, PurchaseRequest body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNull(body, nameof(body));

            using var message = CreatePurchaseRequest(reservationOrderId, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string reservationOrderId, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Capacity/reservationOrders/", false);
            uri.AppendPath(reservationOrderId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the details of the `ReservationOrder`. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReservationOrderResponseData>> GetAsync(string reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var message = CreateGetRequest(reservationOrderId, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationOrderResponseData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationOrderResponseData.DeserializeReservationOrderResponseData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ReservationOrderResponseData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the details of the `ReservationOrder`. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReservationOrderResponseData> Get(string reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var message = CreateGetRequest(reservationOrderId, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationOrderResponseData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationOrderResponseData.DeserializeReservationOrderResponseData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ReservationOrderResponseData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateChangeDirectoryRequest(string reservationOrderId, ChangeDirectoryContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Capacity/reservationOrders/", false);
            uri.AppendPath(reservationOrderId, true);
            uri.AppendPath("/changeDirectory", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Change directory (tenant) of `ReservationOrder` and all `Reservation` under it to specified tenant id. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="content"> Information needed to change directory of reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ChangeDirectoryResponse>> ChangeDirectoryAsync(string reservationOrderId, ChangeDirectoryContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateChangeDirectoryRequest(reservationOrderId, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChangeDirectoryResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ChangeDirectoryResponse.DeserializeChangeDirectoryResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Change directory (tenant) of `ReservationOrder` and all `Reservation` under it to specified tenant id. </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="content"> Information needed to change directory of reservation order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ChangeDirectoryResponse> ChangeDirectory(string reservationOrderId, ChangeDirectoryContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateChangeDirectoryRequest(reservationOrderId, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChangeDirectoryResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ChangeDirectoryResponse.DeserializeChangeDirectoryResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List of all the `ReservationOrder`s that the user has access to in the current tenant. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<ReservationOrderList>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationOrderList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationOrderList.DeserializeReservationOrderList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List of all the `ReservationOrder`s that the user has access to in the current tenant. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<ReservationOrderList> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationOrderList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationOrderList.DeserializeReservationOrderList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
