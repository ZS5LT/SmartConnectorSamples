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
    /// Trends operations.
    /// </summary>
    public partial interface ITrends
    {
        /// <summary>
        /// Creates a new Trend and returns it.
        /// </summary>
        /// <param name='newItem'>
        /// Definition of how the Trend will be created.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TrendModel>> CreateWithHttpMessagesAsync(NewTrendModel newItem, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns all Trend which fit the filter criteria supplied. All
        /// filter parameters are optional. Trend will be ordered and paged
        /// as requested.
        /// </summary>
        /// <param name='name'>
        /// Return only Trend whose name contains this value.
        /// </param>
        /// <param name='orderBy'>
        /// Trend will be returned in this order.  NameAscending by default.
        /// Possible values include: 'NameAscending', 'NameDescending'
        /// </param>
        /// <param name='take'>
        /// Number of Trend that should be returned.  200 by default.
        /// </param>
        /// <param name='skip'>
        /// Number of Trend that should be skipped before items are returned.
        /// 0 by default.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<TrendModel>>> RetrieveWithHttpMessagesAsync(string name = default(string), string orderBy = default(string), int? take = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Trend with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend requested.  Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TrendModel>> RetrieveByIdWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Description property for the Trend with the Id
        /// provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose Description property is to be returned.
        /// Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveDescriptionWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the Description property for the Trend with the Id
        /// provided to the new value supplied.  Returns the modified Trend.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose Description property is to be modified.
        /// Must be double URL encoded.
        /// </param>
        /// <param name='newValue'>
        /// New Description value.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TrendModel>> UpdateDescriptionWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Name property for the Trend with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose Name property is to be returned.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveNameWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the Name property for the Trend with the Id provided to
        /// the new value supplied.  Returns the modified Trend.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose Name property is to be modified.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='newValue'>
        /// New Name value.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TrendModel>> UpdateNameWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the parent Container for the Trend with the Id supplied.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose parent Container is to be returned.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ContainerModel>> RetrieveParentWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the ParentId property for the Trend with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose ParentId property is to be returned.  Must
        /// be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveParentIdWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the ParentId property for the Trend with the Id provided
        /// to the new value supplied.  Returns the modified Trend.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose ParentId property is to be modified.  Must
        /// be double URL encoded.
        /// </param>
        /// <param name='newValue'>
        /// New ParentId value.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TrendModel>> UpdateParentIdWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Type property for the Trend with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose Type property is to be returned.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveTypeWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Unit property for the Trend with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose Unit property is to be returned.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveUnitWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Value for the Trend with the supplied Id.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose Parent is to be returned.  Requires double
        /// URL encoding.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> RetrieveValueWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the ValueId property for the Trend with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose ValueId property is to be returned.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveValueIdWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the Trend with the Id provided to the values supplied.
        /// Returns the modified Trend.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend to be modified.  Must be double URL encoded.
        /// </param>
        /// <param name='updatedItem'>
        /// Item to be updated.  All modfied properties will be changed.
        /// Requires double URL encoding.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TrendModel>> UpdateWithHttpMessagesAsync(string id, UpdateTrendModel updatedItem, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the Id property for the Trend with the Id provided to the
        /// new value supplied.  Returns the modified Trend.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend whose Id property is to be modified.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='newValue'>
        /// New Id value.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> UpdateIdWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the Trend with the Id provided.  All TrendSample
        /// associated with the Trend will also be deleted.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend to be deleted.  Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a range of TrendSample associated with the Trend with the
        /// Id provided.
        /// Open ended ranges are supported.  If sampleDateRange is not
        /// included all TrendSample will be deleted for the Trend.
        /// </summary>
        /// <param name='id'>
        /// Id of the Trend for which TrendSample are to be deleted.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='sampleDateRange'>
        /// Only TrendSample with a SampleDate in this range will be deleted.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PurgeTrendSamplesWithHttpMessagesAsync(string id, DateRange sampleDateRange, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}