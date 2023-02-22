// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V13.Resources
{
    /// <summary>Resource name for the <c>HotelReconciliation</c> resource.</summary>
    public sealed partial class HotelReconciliationName : gax::IResourceName, sys::IEquatable<HotelReconciliationName>
    {
        /// <summary>The possible contents of <see cref="HotelReconciliationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/hotelReconciliations/{commission_id}</c>.
            /// </summary>
            CustomerCommission = 1,
        }

        private static gax::PathTemplate s_customerCommission = new gax::PathTemplate("customers/{customer_id}/hotelReconciliations/{commission_id}");

        /// <summary>Creates a <see cref="HotelReconciliationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HotelReconciliationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HotelReconciliationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HotelReconciliationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HotelReconciliationName"/> with the pattern
        /// <c>customers/{customer_id}/hotelReconciliations/{commission_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commissionId">The <c>Commission</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="HotelReconciliationName"/> constructed from the provided ids.
        /// </returns>
        public static HotelReconciliationName FromCustomerCommission(string customerId, string commissionId) =>
            new HotelReconciliationName(ResourceNameType.CustomerCommission, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), commissionId: gax::GaxPreconditions.CheckNotNullOrEmpty(commissionId, nameof(commissionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HotelReconciliationName"/> with pattern
        /// <c>customers/{customer_id}/hotelReconciliations/{commission_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commissionId">The <c>Commission</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HotelReconciliationName"/> with pattern
        /// <c>customers/{customer_id}/hotelReconciliations/{commission_id}</c>.
        /// </returns>
        public static string Format(string customerId, string commissionId) =>
            FormatCustomerCommission(customerId, commissionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HotelReconciliationName"/> with pattern
        /// <c>customers/{customer_id}/hotelReconciliations/{commission_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commissionId">The <c>Commission</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HotelReconciliationName"/> with pattern
        /// <c>customers/{customer_id}/hotelReconciliations/{commission_id}</c>.
        /// </returns>
        public static string FormatCustomerCommission(string customerId, string commissionId) =>
            s_customerCommission.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(commissionId, nameof(commissionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HotelReconciliationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/hotelReconciliations/{commission_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="hotelReconciliationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HotelReconciliationName"/> if successful.</returns>
        public static HotelReconciliationName Parse(string hotelReconciliationName) => Parse(hotelReconciliationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HotelReconciliationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/hotelReconciliations/{commission_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hotelReconciliationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HotelReconciliationName"/> if successful.</returns>
        public static HotelReconciliationName Parse(string hotelReconciliationName, bool allowUnparsed) =>
            TryParse(hotelReconciliationName, allowUnparsed, out HotelReconciliationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HotelReconciliationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/hotelReconciliations/{commission_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="hotelReconciliationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HotelReconciliationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hotelReconciliationName, out HotelReconciliationName result) =>
            TryParse(hotelReconciliationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HotelReconciliationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/hotelReconciliations/{commission_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hotelReconciliationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HotelReconciliationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hotelReconciliationName, bool allowUnparsed, out HotelReconciliationName result)
        {
            gax::GaxPreconditions.CheckNotNull(hotelReconciliationName, nameof(hotelReconciliationName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCommission.TryParseName(hotelReconciliationName, out resourceName))
            {
                result = FromCustomerCommission(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(hotelReconciliationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HotelReconciliationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string commissionId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CommissionId = commissionId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HotelReconciliationName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/hotelReconciliations/{commission_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commissionId">The <c>Commission</c> ID. Must not be <c>null</c> or empty.</param>
        public HotelReconciliationName(string customerId, string commissionId) : this(ResourceNameType.CustomerCommission, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), commissionId: gax::GaxPreconditions.CheckNotNullOrEmpty(commissionId, nameof(commissionId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Commission</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CommissionId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCommission: return s_customerCommission.Expand(CustomerId, CommissionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HotelReconciliationName);

        /// <inheritdoc/>
        public bool Equals(HotelReconciliationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(HotelReconciliationName a, HotelReconciliationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(HotelReconciliationName a, HotelReconciliationName b) => !(a == b);
    }

    public partial class HotelReconciliation
    {
        /// <summary>
        /// <see cref="HotelReconciliationName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal HotelReconciliationName ResourceNameAsHotelReconciliationName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : HotelReconciliationName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="Campaign"/> resource name property.
        /// </summary>
        internal CampaignName CampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(Campaign) ? null : CampaignName.Parse(Campaign, allowUnparsed: true);
            set => Campaign = value?.ToString() ?? "";
        }
    }
}
