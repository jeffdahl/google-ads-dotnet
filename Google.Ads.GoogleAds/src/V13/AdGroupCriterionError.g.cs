// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/errors/ad_group_criterion_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/errors/ad_group_criterion_error.proto</summary>
  public static partial class AdGroupCriterionErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/errors/ad_group_criterion_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupCriterionErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZXJyb3JzL2FkX2dyb3VwX2Ny",
            "aXRlcmlvbl9lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEz",
            "LmVycm9ycyLgCQoZQWRHcm91cENyaXRlcmlvbkVycm9yRW51bSLCCQoVQWRH",
            "cm91cENyaXRlcmlvbkVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9X",
            "ThABEisKJ0FEX0dST1VQX0NSSVRFUklPTl9MQUJFTF9ET0VTX05PVF9FWElT",
            "VBACEisKJ0FEX0dST1VQX0NSSVRFUklPTl9MQUJFTF9BTFJFQURZX0VYSVNU",
            "UxADEioKJkNBTk5PVF9BRERfTEFCRUxfVE9fTkVHQVRJVkVfQ1JJVEVSSU9O",
            "EAQSFwoTVE9PX01BTllfT1BFUkFUSU9OUxAFEhgKFENBTlRfVVBEQVRFX05F",
            "R0FUSVZFEAYSGgoWQ09OQ1JFVEVfVFlQRV9SRVFVSVJFRBAHEiEKHUJJRF9J",
            "TkNPTVBBVElCTEVfV0lUSF9BREdST1VQEAgSHQoZQ0FOTk9UX1RBUkdFVF9B",
            "TkRfRVhDTFVERRAJEg8KC0lMTEVHQUxfVVJMEAoSGAoUSU5WQUxJRF9LRVlX",
            "T1JEX1RFWFQQCxIbChdJTlZBTElEX0RFU1RJTkFUSU9OX1VSTBAMEh8KG01J",
            "U1NJTkdfREVTVElOQVRJT05fVVJMX1RBRxANEjEKLUtFWVdPUkRfTEVWRUxf",
            "QklEX05PVF9TVVBQT1JURURfRk9SX01BTlVBTENQTRAOEhcKE0lOVkFMSURf",
            "VVNFUl9TVEFUVVMQDxIcChhDQU5OT1RfQUREX0NSSVRFUklBX1RZUEUQEBIg",
            "ChxDQU5OT1RfRVhDTFVERV9DUklURVJJQV9UWVBFEBESNQoxQ0FNUEFJR05f",
            "VFlQRV9OT1RfQ09NUEFUSUJMRV9XSVRIX1BBUlRJQUxfRkFJTFVSRRAbEi0K",
            "KU9QRVJBVElPTlNfRk9SX1RPT19NQU5ZX1NIT1BQSU5HX0FER1JPVVBTEBwS",
            "NAowQ0FOTk9UX01PRElGWV9VUkxfRklFTERTX1dJVEhfRFVQTElDQVRFX0VM",
            "RU1FTlRTEB0SIQodQ0FOTk9UX1NFVF9XSVRIT1VUX0ZJTkFMX1VSTFMQHhI2",
            "CjJDQU5OT1RfQ0xFQVJfRklOQUxfVVJMU19JRl9GSU5BTF9NT0JJTEVfVVJM",
            "U19FWElTVBAfEjMKL0NBTk5PVF9DTEVBUl9GSU5BTF9VUkxTX0lGX0ZJTkFM",
            "X0FQUF9VUkxTX0VYSVNUECASOwo3Q0FOTk9UX0NMRUFSX0ZJTkFMX1VSTFNf",
            "SUZfVFJBQ0tJTkdfVVJMX1RFTVBMQVRFX0VYSVNUUxAhEjoKNkNBTk5PVF9D",
            "TEVBUl9GSU5BTF9VUkxTX0lGX1VSTF9DVVNUT01fUEFSQU1FVEVSU19FWElT",
            "VBAiEjIKLkNBTk5PVF9TRVRfQk9USF9ERVNUSU5BVElPTl9VUkxfQU5EX0ZJ",
            "TkFMX1VSTFMQIxI9CjlDQU5OT1RfU0VUX0JPVEhfREVTVElOQVRJT05fVVJM",
            "X0FORF9UUkFDS0lOR19VUkxfVEVNUExBVEUQJBIvCitGSU5BTF9VUkxTX05P",
            "VF9TVVBQT1JURURfRk9SX0NSSVRFUklPTl9UWVBFECUSNgoyRklOQUxfTU9C",
            "SUxFX1VSTFNfTk9UX1NVUFBPUlRFRF9GT1JfQ1JJVEVSSU9OX1RZUEUQJkL6",
            "AQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMy5lcnJvcnNCGkFkR3Jv",
            "dXBDcml0ZXJpb25FcnJvclByb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTMvZXJyb3JzO2Vy",
            "cm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMy5FcnJvcnPK",
            "Ah9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTNcRXJyb3Jz6gIjR29vZ2xlOjpB",
            "ZHM6Okdvb2dsZUFkczo6VjEzOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Errors.AdGroupCriterionErrorEnum), global::Google.Ads.GoogleAds.V13.Errors.AdGroupCriterionErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Errors.AdGroupCriterionErrorEnum.Types.AdGroupCriterionError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad group criterion errors.
  /// </summary>
  public sealed partial class AdGroupCriterionErrorEnum : pb::IMessage<AdGroupCriterionErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupCriterionErrorEnum> _parser = new pb::MessageParser<AdGroupCriterionErrorEnum>(() => new AdGroupCriterionErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupCriterionErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Errors.AdGroupCriterionErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCriterionErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCriterionErrorEnum(AdGroupCriterionErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCriterionErrorEnum Clone() {
      return new AdGroupCriterionErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupCriterionErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupCriterionErrorEnum other) {
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
    public void MergeFrom(AdGroupCriterionErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupCriterionErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible ad group criterion errors.
      /// </summary>
      public enum AdGroupCriterionError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// No link found between the AdGroupCriterion and the label.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_CRITERION_LABEL_DOES_NOT_EXIST")] AdGroupCriterionLabelDoesNotExist = 2,
        /// <summary>
        /// The label has already been attached to the AdGroupCriterion.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_CRITERION_LABEL_ALREADY_EXISTS")] AdGroupCriterionLabelAlreadyExists = 3,
        /// <summary>
        /// Negative AdGroupCriterion cannot have labels.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_LABEL_TO_NEGATIVE_CRITERION")] CannotAddLabelToNegativeCriterion = 4,
        /// <summary>
        /// Too many operations for a single call.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_OPERATIONS")] TooManyOperations = 5,
        /// <summary>
        /// Negative ad group criteria are not updateable.
        /// </summary>
        [pbr::OriginalName("CANT_UPDATE_NEGATIVE")] CantUpdateNegative = 6,
        /// <summary>
        /// Concrete type of criterion (keyword v.s. placement) is required for ADD
        /// and SET operations.
        /// </summary>
        [pbr::OriginalName("CONCRETE_TYPE_REQUIRED")] ConcreteTypeRequired = 7,
        /// <summary>
        /// Bid is incompatible with ad group's bidding settings.
        /// </summary>
        [pbr::OriginalName("BID_INCOMPATIBLE_WITH_ADGROUP")] BidIncompatibleWithAdgroup = 8,
        /// <summary>
        /// Cannot target and exclude the same criterion at once.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_AND_EXCLUDE")] CannotTargetAndExclude = 9,
        /// <summary>
        /// The URL of a placement is invalid.
        /// </summary>
        [pbr::OriginalName("ILLEGAL_URL")] IllegalUrl = 10,
        /// <summary>
        /// Keyword text was invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_KEYWORD_TEXT")] InvalidKeywordText = 11,
        /// <summary>
        /// Destination URL was invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_DESTINATION_URL")] InvalidDestinationUrl = 12,
        /// <summary>
        /// The destination url must contain at least one tag (for example, {lpurl})
        /// </summary>
        [pbr::OriginalName("MISSING_DESTINATION_URL_TAG")] MissingDestinationUrlTag = 13,
        /// <summary>
        /// Keyword-level cpm bid is not supported
        /// </summary>
        [pbr::OriginalName("KEYWORD_LEVEL_BID_NOT_SUPPORTED_FOR_MANUALCPM")] KeywordLevelBidNotSupportedForManualcpm = 14,
        /// <summary>
        /// For example, cannot add a biddable ad group criterion that had been
        /// removed.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_STATUS")] InvalidUserStatus = 15,
        /// <summary>
        /// Criteria type cannot be targeted for the ad group. Either the account is
        /// restricted to keywords only, the criteria type is incompatible with the
        /// campaign's bidding strategy, or the criteria type can only be applied to
        /// campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_CRITERIA_TYPE")] CannotAddCriteriaType = 16,
        /// <summary>
        /// Criteria type cannot be excluded for the ad group. Refer to the
        /// documentation for a specific criterion to check if it is excludable.
        /// </summary>
        [pbr::OriginalName("CANNOT_EXCLUDE_CRITERIA_TYPE")] CannotExcludeCriteriaType = 17,
        /// <summary>
        /// Partial failure is not supported for shopping campaign mutate operations.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_TYPE_NOT_COMPATIBLE_WITH_PARTIAL_FAILURE")] CampaignTypeNotCompatibleWithPartialFailure = 27,
        /// <summary>
        /// Operations in the mutate request changes too many shopping ad groups.
        /// Split requests for multiple shopping ad groups across multiple
        /// requests.
        /// </summary>
        [pbr::OriginalName("OPERATIONS_FOR_TOO_MANY_SHOPPING_ADGROUPS")] OperationsForTooManyShoppingAdgroups = 28,
        /// <summary>
        /// Not allowed to modify url fields of an ad group criterion if there are
        /// duplicate elements for that ad group criterion in the request.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_URL_FIELDS_WITH_DUPLICATE_ELEMENTS")] CannotModifyUrlFieldsWithDuplicateElements = 29,
        /// <summary>
        /// Cannot set url fields without also setting final urls.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_WITHOUT_FINAL_URLS")] CannotSetWithoutFinalUrls = 30,
        /// <summary>
        /// Cannot clear final urls if final mobile urls exist.
        /// </summary>
        [pbr::OriginalName("CANNOT_CLEAR_FINAL_URLS_IF_FINAL_MOBILE_URLS_EXIST")] CannotClearFinalUrlsIfFinalMobileUrlsExist = 31,
        /// <summary>
        /// Cannot clear final urls if final app urls exist.
        /// </summary>
        [pbr::OriginalName("CANNOT_CLEAR_FINAL_URLS_IF_FINAL_APP_URLS_EXIST")] CannotClearFinalUrlsIfFinalAppUrlsExist = 32,
        /// <summary>
        /// Cannot clear final urls if tracking url template exists.
        /// </summary>
        [pbr::OriginalName("CANNOT_CLEAR_FINAL_URLS_IF_TRACKING_URL_TEMPLATE_EXISTS")] CannotClearFinalUrlsIfTrackingUrlTemplateExists = 33,
        /// <summary>
        /// Cannot clear final urls if url custom parameters exist.
        /// </summary>
        [pbr::OriginalName("CANNOT_CLEAR_FINAL_URLS_IF_URL_CUSTOM_PARAMETERS_EXIST")] CannotClearFinalUrlsIfUrlCustomParametersExist = 34,
        /// <summary>
        /// Cannot set both destination url and final urls.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_BOTH_DESTINATION_URL_AND_FINAL_URLS")] CannotSetBothDestinationUrlAndFinalUrls = 35,
        /// <summary>
        /// Cannot set both destination url and tracking url template.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_BOTH_DESTINATION_URL_AND_TRACKING_URL_TEMPLATE")] CannotSetBothDestinationUrlAndTrackingUrlTemplate = 36,
        /// <summary>
        /// Final urls are not supported for this criterion type.
        /// </summary>
        [pbr::OriginalName("FINAL_URLS_NOT_SUPPORTED_FOR_CRITERION_TYPE")] FinalUrlsNotSupportedForCriterionType = 37,
        /// <summary>
        /// Final mobile urls are not supported for this criterion type.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URLS_NOT_SUPPORTED_FOR_CRITERION_TYPE")] FinalMobileUrlsNotSupportedForCriterionType = 38,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
