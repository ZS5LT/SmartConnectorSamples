﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Ews.RestExtensions.Client.Proxy.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Represents the information needed when manually generating an
    /// AlarmEvent for an Alarm.
    /// </summary>
    public partial class AlarmEventStateChangeInfo
    {
        /// <summary>
        /// Initializes a new instance of the AlarmEventStateChangeInfo class.
        /// </summary>
        public AlarmEventStateChangeInfo() { }

        /// <summary>
        /// Initializes a new instance of the AlarmEventStateChangeInfo class.
        /// </summary>
        public AlarmEventStateChangeInfo(string newState = default(string), string newAcknowledgeable = default(string), string message = default(string), string type = default(string), int? priority = default(int?))
        {
            NewState = newState;
            NewAcknowledgeable = newAcknowledgeable;
            Message = message;
            Type = type;
            Priority = priority;
        }

        /// <summary>
        /// The new State value for the AlarmEvent. Possible values include:
        /// 'Normal', 'Active', 'Acknowledged', 'Reset', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "NewState")]
        public string NewState { get; set; }

        /// <summary>
        /// The new Acknowledgeable value for the AlarmEvent. Possible values
        /// include: 'No', 'Yes', 'Required'
        /// </summary>
        [JsonProperty(PropertyName = "NewAcknowledgeable")]
        public string NewAcknowledgeable { get; set; }

        /// <summary>
        /// The Message to be given with the generated AlarmEvent.
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// The Type of to be given with the generated AlarmEvent.
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// The Priority to be given to the genreated AlarmEvent.
        /// </summary>
        [JsonProperty(PropertyName = "Priority")]
        public int? Priority { get; set; }

    }
}
