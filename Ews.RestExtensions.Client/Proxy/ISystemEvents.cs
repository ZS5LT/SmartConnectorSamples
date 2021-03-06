﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Ews.RestExtensions.Client.Proxy
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// SystemEvents operations.
    /// </summary>
    public partial interface ISystemEvents
    {
        /// <summary>
        /// Returns all SystemEvent which fit the filter criteria supplied.
        /// All filter parameters are optional. SystemEvent will be ordered
        /// and paged as requested.
        /// </summary>
        /// <param name='priorityFrom'>
        /// Return only SystemEvent with a Priority greater or equal to the
        /// value supplied.
        /// </param>
        /// <param name='priorityTo'>
        /// Return only SystemEvent with a Priority less or equal to the value
        /// supplied.
        /// </param>
        /// <param name='type'>
        /// Return only SystemEvent with this Type value.
        /// </param>
        /// <param name='occurredOnOrAfter'>
        /// Return only SystemEvent with OccurredOn which is on or after this
        /// value.
        /// </param>
        /// <param name='occurredBefore'>
        /// Return only SystemEvent with OccurredOn which is before this value.
        /// </param>
        /// <param name='orderBy'>
        /// SystemEvent will be returned in this order.  OccurredOnAscending
        /// by default. Possible values include: 'OccurredOnAscending',
        /// 'OccurredOnDescending'
        /// </param>
        /// <param name='take'>
        /// Number of SystemEvent that should be returned.  200 by default.
        /// </param>
        /// <param name='skip'>
        /// Number of SystemEvent that should be skipped before items are
        /// returned.  0 by default.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<SystemEventModel>>> RetrieveWithHttpMessagesAsync(int? priorityFrom = default(int?), int? priorityTo = default(int?), string type = default(string), DateTime? occurredOnOrAfter = default(DateTime?), DateTime? occurredBefore = default(DateTime?), string orderBy = default(string), int? take = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the SystemEvent with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the SystemEvent requested.  Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SystemEventModel>> RetrieveByIdWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Message property for the SystemEvent with the Id
        /// provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the SystemEvent whose Message property is to be returned.
        /// Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveMessageWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the OccurredOn property for the SystemEvent with the Id
        /// provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the SystemEvent whose OccurredOn property is to be returned.
        /// Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<DateTime?>> RetrieveOccurredOnWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Priority property for the SystemEvent with the Id
        /// provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the SystemEvent whose Priority property is to be returned.
        /// Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<int?>> RetrievePriorityWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the SourceId property for the AlarmEvent with the Id
        /// provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the SystemEvent whose SourceId property is to be returned.
        /// Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveSourceIdWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the SourceName property for the SystemEvent with the Id
        /// provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the SystemEvent whose SourceName property is to be returned.
        /// Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveSourceNameWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Type property for the SystemEvent with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the SystemEvent whose Type property is to be returned.  Must
        /// be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveTypeWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
