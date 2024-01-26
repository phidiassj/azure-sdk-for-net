// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing the NetworkCloudBareMetalMachineKeySet data model.
    /// BareMetalMachineKeySet represents the bare metal machine key set.
    /// </summary>
    public partial class NetworkCloudBareMetalMachineKeySetData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudBareMetalMachineKeySetData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="azureGroupId"> The object ID of Azure Active Directory group that all users in the list must be in for access to be granted. Users that are not in the group will not have access. </param>
        /// <param name="expireOn"> The date and time after which the users in this key set will be removed from the bare metal machines. </param>
        /// <param name="jumpHostsAllowed"> The list of IP addresses of jump hosts with management network access from which a login will be allowed for the users. </param>
        /// <param name="privilegeLevel"> The access level allowed for the users in this key set. </param>
        /// <param name="userList"> The unique list of permitted users. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/>, <paramref name="azureGroupId"/>, <paramref name="jumpHostsAllowed"/> or <paramref name="userList"/> is null. </exception>
        public NetworkCloudBareMetalMachineKeySetData(AzureLocation location, ExtendedLocation extendedLocation, string azureGroupId, DateTimeOffset expireOn, IEnumerable<IPAddress> jumpHostsAllowed, BareMetalMachineKeySetPrivilegeLevel privilegeLevel, IEnumerable<KeySetUser> userList) : base(location)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));
            Argument.AssertNotNull(azureGroupId, nameof(azureGroupId));
            Argument.AssertNotNull(jumpHostsAllowed, nameof(jumpHostsAllowed));
            Argument.AssertNotNull(userList, nameof(userList));

            ExtendedLocation = extendedLocation;
            AzureGroupId = azureGroupId;
            ExpireOn = expireOn;
            JumpHostsAllowed = jumpHostsAllowed.ToList();
            PrivilegeLevel = privilegeLevel;
            UserList = userList.ToList();
            UserListStatus = new ChangeTrackingList<KeySetUserStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudBareMetalMachineKeySetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="azureGroupId"> The object ID of Azure Active Directory group that all users in the list must be in for access to be granted. Users that are not in the group will not have access. </param>
        /// <param name="detailedStatus"> The more detailed status of the key set. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the current detailed status. </param>
        /// <param name="expireOn"> The date and time after which the users in this key set will be removed from the bare metal machines. </param>
        /// <param name="jumpHostsAllowed"> The list of IP addresses of jump hosts with management network access from which a login will be allowed for the users. </param>
        /// <param name="lastValidatedOn"> The last time this key set was validated. </param>
        /// <param name="osGroupName"> The name of the group that users will be assigned to on the operating system of the machines. </param>
        /// <param name="privilegeLevel"> The access level allowed for the users in this key set. </param>
        /// <param name="provisioningState"> The provisioning state of the bare metal machine key set. </param>
        /// <param name="userList"> The unique list of permitted users. </param>
        /// <param name="userListStatus"> The status evaluation of each user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudBareMetalMachineKeySetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, string azureGroupId, BareMetalMachineKeySetDetailedStatus? detailedStatus, string detailedStatusMessage, DateTimeOffset expireOn, IList<IPAddress> jumpHostsAllowed, DateTimeOffset? lastValidatedOn, string osGroupName, BareMetalMachineKeySetPrivilegeLevel privilegeLevel, BareMetalMachineKeySetProvisioningState? provisioningState, IList<KeySetUser> userList, IReadOnlyList<KeySetUserStatus> userListStatus, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            AzureGroupId = azureGroupId;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            ExpireOn = expireOn;
            JumpHostsAllowed = jumpHostsAllowed;
            LastValidatedOn = lastValidatedOn;
            OSGroupName = osGroupName;
            PrivilegeLevel = privilegeLevel;
            ProvisioningState = provisioningState;
            UserList = userList;
            UserListStatus = userListStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudBareMetalMachineKeySetData"/> for deserialization. </summary>
        internal NetworkCloudBareMetalMachineKeySetData()
        {
        }

        /// <summary> The extended location of the cluster associated with the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The object ID of Azure Active Directory group that all users in the list must be in for access to be granted. Users that are not in the group will not have access. </summary>
        public string AzureGroupId { get; set; }
        /// <summary> The more detailed status of the key set. </summary>
        public BareMetalMachineKeySetDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the current detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> The date and time after which the users in this key set will be removed from the bare metal machines. </summary>
        public DateTimeOffset ExpireOn { get; set; }
        /// <summary> The list of IP addresses of jump hosts with management network access from which a login will be allowed for the users. </summary>
        public IList<IPAddress> JumpHostsAllowed { get; }
        /// <summary> The last time this key set was validated. </summary>
        public DateTimeOffset? LastValidatedOn { get; }
        /// <summary> The name of the group that users will be assigned to on the operating system of the machines. </summary>
        public string OSGroupName { get; set; }
        /// <summary> The access level allowed for the users in this key set. </summary>
        public BareMetalMachineKeySetPrivilegeLevel PrivilegeLevel { get; set; }
        /// <summary> The provisioning state of the bare metal machine key set. </summary>
        public BareMetalMachineKeySetProvisioningState? ProvisioningState { get; }
        /// <summary> The unique list of permitted users. </summary>
        public IList<KeySetUser> UserList { get; }
        /// <summary> The status evaluation of each user. </summary>
        public IReadOnlyList<KeySetUserStatus> UserListStatus { get; }
    }
}
