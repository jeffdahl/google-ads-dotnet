// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/errors/offline_user_data_job_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/errors/offline_user_data_job_error.proto</summary>
  public static partial class OfflineUserDataJobErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/errors/offline_user_data_job_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OfflineUserDataJobErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZXJyb3JzL29mZmxpbmVfdXNl",
            "cl9kYXRhX2pvYl9lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djEyLmVycm9ycyLOCgobT2ZmbGluZVVzZXJEYXRhSm9iRXJyb3JFbnVtIq4K",
            "ChdPZmZsaW5lVXNlckRhdGFKb2JFcnJvchIPCgtVTlNQRUNJRklFRBAAEgsK",
            "B1VOS05PV04QARIYChRJTlZBTElEX1VTRVJfTElTVF9JRBADEhoKFklOVkFM",
            "SURfVVNFUl9MSVNUX1RZUEUQBBIgChxOT1RfT05fQUxMT1dMSVNUX0ZPUl9V",
            "U0VSX0lEECESIAocSU5DT01QQVRJQkxFX1VQTE9BRF9LRVlfVFlQRRAGEhsK",
            "F01JU1NJTkdfVVNFUl9JREVOVElGSUVSEAcSHAoYSU5WQUxJRF9NT0JJTEVf",
            "SURfRk9STUFUEAgSHQoZVE9PX01BTllfVVNFUl9JREVOVElGSUVSUxAJEisK",
            "J05PVF9PTl9BTExPV0xJU1RfRk9SX1NUT1JFX1NBTEVTX0RJUkVDVBAfEiwK",
            "KE5PVF9PTl9BTExPV0xJU1RfRk9SX1VOSUZJRURfU1RPUkVfU0FMRVMQIBIW",
            "ChJJTlZBTElEX1BBUlRORVJfSUQQCxIUChBJTlZBTElEX0VOQ09ESU5HEAwS",
            "GAoUSU5WQUxJRF9DT1VOVFJZX0NPREUQDRIgChxJTkNPTVBBVElCTEVfVVNF",
            "Ul9JREVOVElGSUVSEA4SGwoXRlVUVVJFX1RSQU5TQUNUSU9OX1RJTUUQDxId",
            "ChlJTlZBTElEX0NPTlZFUlNJT05fQUNUSU9OEBASGwoXTU9CSUxFX0lEX05P",
            "VF9TVVBQT1JURUQQERIbChdJTlZBTElEX09QRVJBVElPTl9PUkRFUhASEhkK",
            "FUNPTkZMSUNUSU5HX09QRVJBVElPThATEiUKIUVYVEVSTkFMX1VQREFURV9J",
            "RF9BTFJFQURZX0VYSVNUUxAVEhcKE0pPQl9BTFJFQURZX1NUQVJURUQQFhIY",
            "ChRSRU1PVkVfTk9UX1NVUFBPUlRFRBAXEhwKGFJFTU9WRV9BTExfTk9UX1NV",
            "UFBPUlRFRBAYEhkKFUlOVkFMSURfU0hBMjU2X0ZPUk1BVBAZEhcKE0NVU1RP",
            "TV9LRVlfRElTQUJMRUQQGhIdChlDVVNUT01fS0VZX05PVF9QUkVERUZJTkVE",
            "EBsSFgoSQ1VTVE9NX0tFWV9OT1RfU0VUEB0SLQopQ1VTVE9NRVJfTk9UX0FD",
            "Q0VQVEVEX0NVU1RPTUVSX0RBVEFfVEVSTVMQHhI6CjZBVFRSSUJVVEVTX05P",
            "VF9BUFBMSUNBQkxFX0ZPUl9DVVNUT01FUl9NQVRDSF9VU0VSX0xJU1QQIhIm",
            "CiJMSUZFVElNRV9WQUxVRV9CVUNLRVRfTk9UX0lOX1JBTkdFECMSLworSU5D",
            "T01QQVRJQkxFX1VTRVJfSURFTlRJRklFUl9GT1JfQVRUUklCVVRFUxAkEhsK",
            "F0ZVVFVSRV9USU1FX05PVF9BTExPV0VEECUSMQotTEFTVF9QVVJDSEFTRV9U",
            "SU1FX0xFU1NfVEhBTl9BQ1FVSVNJVElPTl9USU1FECYSIwofQ1VTVE9NRVJf",
            "SURFTlRJRklFUl9OT1RfQUxMT1dFRBAnEhMKD0lOVkFMSURfSVRFTV9JRBAo",
            "EjcKM0ZJUlNUX1BVUkNIQVNFX1RJTUVfR1JFQVRFUl9USEFOX0xBU1RfUFVS",
            "Q0hBU0VfVElNRRAqEhsKF0lOVkFMSURfTElGRUNZQ0xFX1NUQUdFECsSFwoT",
            "SU5WQUxJRF9FVkVOVF9WQUxVRRAsEisKJ0VWRU5UX0FUVFJJQlVURV9BTExf",
            "RklFTERTX0FSRV9SRVFVSVJFRBAtQvwBCiNjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjEyLmVycm9yc0IcT2ZmbGluZVVzZXJEYXRhSm9iRXJyb3JQcm90",
            "b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjEyL2Vycm9ycztlcnJvcnOiAgNHQUGqAh9Hb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WMTIuRXJyb3JzygIfR29vZ2xlXEFkc1xHb29nbGVB",
            "ZHNcVjEyXEVycm9yc+oCI0dvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMjo6",
            "RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Errors.OfflineUserDataJobErrorEnum), global::Google.Ads.GoogleAds.V12.Errors.OfflineUserDataJobErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Errors.OfflineUserDataJobErrorEnum.Types.OfflineUserDataJobError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible offline user data job errors.
  /// </summary>
  public sealed partial class OfflineUserDataJobErrorEnum : pb::IMessage<OfflineUserDataJobErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OfflineUserDataJobErrorEnum> _parser = new pb::MessageParser<OfflineUserDataJobErrorEnum>(() => new OfflineUserDataJobErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OfflineUserDataJobErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Errors.OfflineUserDataJobErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobErrorEnum(OfflineUserDataJobErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobErrorEnum Clone() {
      return new OfflineUserDataJobErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OfflineUserDataJobErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OfflineUserDataJobErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OfflineUserDataJobErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the OfflineUserDataJobErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible request errors.
      /// </summary>
      public enum OfflineUserDataJobError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The user list ID provided for the job is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_LIST_ID")] InvalidUserListId = 3,
        /// <summary>
        /// Type of the user list is not applicable for the job.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_LIST_TYPE")] InvalidUserListType = 4,
        /// <summary>
        /// Customer is not allowisted for using user ID in upload data.
        /// </summary>
        [pbr::OriginalName("NOT_ON_ALLOWLIST_FOR_USER_ID")] NotOnAllowlistForUserId = 33,
        /// <summary>
        /// Upload data is not compatible with the upload key type of the associated
        /// user list.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_UPLOAD_KEY_TYPE")] IncompatibleUploadKeyType = 6,
        /// <summary>
        /// The user identifier is missing valid data.
        /// </summary>
        [pbr::OriginalName("MISSING_USER_IDENTIFIER")] MissingUserIdentifier = 7,
        /// <summary>
        /// The mobile ID is malformed.
        /// </summary>
        [pbr::OriginalName("INVALID_MOBILE_ID_FORMAT")] InvalidMobileIdFormat = 8,
        /// <summary>
        /// Maximum number of user identifiers allowed per request is 100,000 and per
        /// operation is 20.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_USER_IDENTIFIERS")] TooManyUserIdentifiers = 9,
        /// <summary>
        /// Customer is not on the allow-list for store sales direct data.
        /// </summary>
        [pbr::OriginalName("NOT_ON_ALLOWLIST_FOR_STORE_SALES_DIRECT")] NotOnAllowlistForStoreSalesDirect = 31,
        /// <summary>
        /// Customer is not on the allow-list for unified store sales data.
        /// </summary>
        [pbr::OriginalName("NOT_ON_ALLOWLIST_FOR_UNIFIED_STORE_SALES")] NotOnAllowlistForUnifiedStoreSales = 32,
        /// <summary>
        /// The partner ID in store sales direct metadata is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_PARTNER_ID")] InvalidPartnerId = 11,
        /// <summary>
        /// The data in user identifier should not be encoded.
        /// </summary>
        [pbr::OriginalName("INVALID_ENCODING")] InvalidEncoding = 12,
        /// <summary>
        /// The country code is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_COUNTRY_CODE")] InvalidCountryCode = 13,
        /// <summary>
        /// Incompatible user identifier when using third_party_user_id for store
        /// sales direct first party data or not using third_party_user_id for store
        /// sales third party data.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_USER_IDENTIFIER")] IncompatibleUserIdentifier = 14,
        /// <summary>
        /// A transaction time in the future is not allowed.
        /// </summary>
        [pbr::OriginalName("FUTURE_TRANSACTION_TIME")] FutureTransactionTime = 15,
        /// <summary>
        /// The conversion_action specified in transaction_attributes is used to
        /// report conversions to a conversion action configured in Google Ads. This
        /// error indicates there is no such conversion action in the account.
        /// </summary>
        [pbr::OriginalName("INVALID_CONVERSION_ACTION")] InvalidConversionAction = 16,
        /// <summary>
        /// Mobile ID is not supported for store sales direct data.
        /// </summary>
        [pbr::OriginalName("MOBILE_ID_NOT_SUPPORTED")] MobileIdNotSupported = 17,
        /// <summary>
        /// When a remove-all operation is provided, it has to be the first operation
        /// of the operation list.
        /// </summary>
        [pbr::OriginalName("INVALID_OPERATION_ORDER")] InvalidOperationOrder = 18,
        /// <summary>
        /// Mixing creation and removal of offline data in the same job is not
        /// allowed.
        /// </summary>
        [pbr::OriginalName("CONFLICTING_OPERATION")] ConflictingOperation = 19,
        /// <summary>
        /// The external update ID already exists.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_UPDATE_ID_ALREADY_EXISTS")] ExternalUpdateIdAlreadyExists = 21,
        /// <summary>
        /// Once the upload job is started, new operations cannot be added.
        /// </summary>
        [pbr::OriginalName("JOB_ALREADY_STARTED")] JobAlreadyStarted = 22,
        /// <summary>
        /// Remove operation is not allowed for store sales direct updates.
        /// </summary>
        [pbr::OriginalName("REMOVE_NOT_SUPPORTED")] RemoveNotSupported = 23,
        /// <summary>
        /// Remove-all is not supported for certain offline user data job types.
        /// </summary>
        [pbr::OriginalName("REMOVE_ALL_NOT_SUPPORTED")] RemoveAllNotSupported = 24,
        /// <summary>
        /// The SHA256 encoded value is malformed.
        /// </summary>
        [pbr::OriginalName("INVALID_SHA256_FORMAT")] InvalidSha256Format = 25,
        /// <summary>
        /// The custom key specified is not enabled for the unified store sales
        /// upload.
        /// </summary>
        [pbr::OriginalName("CUSTOM_KEY_DISABLED")] CustomKeyDisabled = 26,
        /// <summary>
        /// The custom key specified is not predefined through the Google Ads UI.
        /// </summary>
        [pbr::OriginalName("CUSTOM_KEY_NOT_PREDEFINED")] CustomKeyNotPredefined = 27,
        /// <summary>
        /// The custom key specified is not set in the upload.
        /// </summary>
        [pbr::OriginalName("CUSTOM_KEY_NOT_SET")] CustomKeyNotSet = 29,
        /// <summary>
        /// The customer has not accepted the customer data terms in the conversion
        /// settings page.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_ACCEPTED_CUSTOMER_DATA_TERMS")] CustomerNotAcceptedCustomerDataTerms = 30,
        /// <summary>
        /// User attributes cannot be uploaded into a user list.
        /// </summary>
        [pbr::OriginalName("ATTRIBUTES_NOT_APPLICABLE_FOR_CUSTOMER_MATCH_USER_LIST")] AttributesNotApplicableForCustomerMatchUserList = 34,
        /// <summary>
        /// Lifetime bucket value must be a number from 0 to 10; 0 is only accepted
        /// for remove operations
        /// </summary>
        [pbr::OriginalName("LIFETIME_VALUE_BUCKET_NOT_IN_RANGE")] LifetimeValueBucketNotInRange = 35,
        /// <summary>
        /// Identifiers not supported for Customer Match attributes. User attributes
        /// can only be provided with contact info (email, phone, address) user
        /// identifiers.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_USER_IDENTIFIER_FOR_ATTRIBUTES")] IncompatibleUserIdentifierForAttributes = 36,
        /// <summary>
        /// A time in the future is not allowed.
        /// </summary>
        [pbr::OriginalName("FUTURE_TIME_NOT_ALLOWED")] FutureTimeNotAllowed = 37,
        /// <summary>
        /// Last purchase date time cannot be less than acquisition date time.
        /// </summary>
        [pbr::OriginalName("LAST_PURCHASE_TIME_LESS_THAN_ACQUISITION_TIME")] LastPurchaseTimeLessThanAcquisitionTime = 38,
        /// <summary>
        /// Only emails are accepted as user identifiers for shopping loyalty match.
        /// {-- api.dev/not-precedent: The identifier is not limited to ids, but
        /// also include other user info eg. phone numbers.}
        /// </summary>
        [pbr::OriginalName("CUSTOMER_IDENTIFIER_NOT_ALLOWED")] CustomerIdentifierNotAllowed = 39,
        /// <summary>
        /// Provided item ID is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_ITEM_ID")] InvalidItemId = 40,
        /// <summary>
        /// First purchase date time cannot be greater than the last purchase date
        /// time.
        /// </summary>
        [pbr::OriginalName("FIRST_PURCHASE_TIME_GREATER_THAN_LAST_PURCHASE_TIME")] FirstPurchaseTimeGreaterThanLastPurchaseTime = 42,
        /// <summary>
        /// Provided lifecycle stage is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_LIFECYCLE_STAGE")] InvalidLifecycleStage = 43,
        /// <summary>
        /// The event value of the Customer Match user attribute is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_EVENT_VALUE")] InvalidEventValue = 44,
        /// <summary>
        /// All the fields are not present in the EventAttribute of the Customer
        /// Match.
        /// </summary>
        [pbr::OriginalName("EVENT_ATTRIBUTE_ALL_FIELDS_ARE_REQUIRED")] EventAttributeAllFieldsAreRequired = 45,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
