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
    /// Values operations.
    /// </summary>
    public partial interface IValues
    {
        /// <summary>
        /// Creates a new Value and returns it.
        /// </summary>
        /// <param name='newItem'>
        /// Definition of how the Value will be created.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> CreateWithHttpMessagesAsync(NewValueModel newItem, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns all Value which fit the filter criteria supplied. All
        /// filter parameters are optional. Value will be ordered and paged
        /// as requested.
        /// </summary>
        /// <param name='name'>
        /// Return only Value whose name contains this value.
        /// </param>
        /// <param name='type'>
        /// Return only Value with this Type value. Possible values include:
        /// 'DateTime', 'Boolean', 'String', 'Double', 'Long', 'Integer',
        /// 'Duration'
        /// </param>
        /// <param name='orderBy'>
        /// Value will be returned in this order.  NameAscending by default.
        /// Possible values include: 'NameAscending', 'NameDescending'
        /// </param>
        /// <param name='take'>
        /// Number of Value that should be returned.  200 by default.
        /// </param>
        /// <param name='skip'>
        /// Number of Value that should be skipped before items are returned.
        /// 0 by default.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<ValueModel>>> RetrieveWithHttpMessagesAsync(string name = default(string), string type = default(string), string orderBy = default(string), int? take = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Value with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value requested.  Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> RetrieveByIdWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Description property for the Value with the Id
        /// provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Description property is to be returned.
        /// Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> RetrieveDescriptionWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the Description property for the Value with the Id
        /// provided to the new value supplied.  Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Description property is to be modified.
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
        Task<HttpOperationResponse<ValueModel>> UpdateDescriptionWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Forceable property for the Value with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Forceable property is to be returned.  Must
        /// be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveForceableWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the Forceable property for the Value with the Id provided
        /// to the new value supplied.  Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Forceable property is to be modified.  Must
        /// be double URL encoded.
        /// </param>
        /// <param name='newValue'>
        /// New Forceable value.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> UpdateForceableWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Name property for the Value with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Name property is to be returned.  Must be
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
        /// Modifies the Name property for the Value with the Id provided to
        /// the new value supplied.  Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Name property is to be modified.  Must be
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
        Task<HttpOperationResponse<ValueModel>> UpdateNameWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the parent Container for the Value with the Id supplied.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose parent Container is to be returned.  Must be
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
        /// Returns the ParentId property for the Container with the Id
        /// provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose ParentId property is to be returned.  Must
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
        /// Modifies the ParentId property for the Value with the Id provided
        /// to the new value supplied.  Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose ParentId property is to be modified.  Must
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
        Task<HttpOperationResponse<ValueModel>> UpdateParentIdWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the State property for the Value with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the State whose Type property is to be returned.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveStateWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the State property for the Value with the Id provided to
        /// the new value supplied.  Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the State whose Type property is to be modified.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='newValue'>
        /// New State value.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> UpdateStateWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Type property for the Value with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Type property is to be returned.  Must be
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
        /// Modifies the Type property for the Value with the Id provided to
        /// the new value supplied.  Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Type property is to be modified.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='newValue'>
        /// New Type value.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> UpdateTypeWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Unit property for the Value with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Unit property is to be returned.  Must be
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
        /// Modifies the Unit property for the Value with the Id provided to
        /// the new value supplied.  Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Unit property is to be modified.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='newValue'>
        /// New Unit value.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> UpdateUnitWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Value property for the Value with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Value property is to be returned.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveValueWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the Value property for the Value with the Id provided to
        /// the new value supplied.  Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Value property is to be modified.  Must be
        /// double URL encoded.
        /// </param>
        /// <param name='newValue'>
        /// New Value value.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> UpdateValueWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the Writeable property for the Value with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Writeable property is to be returned.  Must
        /// be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RetrieveWriteableWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the Writeable property for the Value with the Id provided
        /// to the new value supplied.  Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Writeable property is to be modified.  Must
        /// be double URL encoded.
        /// </param>
        /// <param name='newValue'>
        /// New Writeable value.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> UpdateWriteableWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the Value with the Id provided to the values supplied.
        /// Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value to be modified.  Must be double URL encoded.
        /// </param>
        /// <param name='updatedItem'>
        /// Values to update the Value with.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> UpdateWithHttpMessagesAsync(string id, UpdateValueModel updatedItem, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Modifies the Id property for the Value with the Id provided to the
        /// new value supplied.  Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value whose Id property is to be modified.  Must be
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
        Task<HttpOperationResponse<ValueModel>> UpdateIdWithHttpMessagesAsync(string id, string newValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Forces the Value with the Id provided.
        /// After this action the Value will have a State of Forced and a
        /// Value equal to the forcedValue parameter.  Returns the modified
        /// Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value to be forced.  Must be double URL encoded.
        /// </param>
        /// <param name='forcedValue'>
        /// Value which the Value will be forced to.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> ForceWithHttpMessagesAsync(string id, string forcedValue, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Unforces the Value with the Id provided.
        /// After this action the Value will have a State and Value which
        /// depends on configured Data Provider.  Returns the modified Value.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value to update.  Requires double URL encoding.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ValueModel>> UnforceWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the Value with the Id provided.
        /// </summary>
        /// <param name='id'>
        /// Id of the Value to be deleted.  Must be double URL encoded.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
