// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/errors/setting_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/errors/setting_error.proto</summary>
  public static partial class SettingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/errors/setting_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SettingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZXJyb3JzL3NldHRpbmdfZXJy",
            "b3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMy5lcnJvcnMitwYK",
            "EFNldHRpbmdFcnJvckVudW0iogYKDFNldHRpbmdFcnJvchIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARIhCh1TRVRUSU5HX1RZUEVfSVNfTk9UX0FW",
            "QUlMQUJMRRADEjAKLFNFVFRJTkdfVFlQRV9JU19OT1RfQ09NUEFUSUJMRV9X",
            "SVRIX0NBTVBBSUdOEAQSOwo3VEFSR0VUSU5HX1NFVFRJTkdfQ09OVEFJTlNf",
            "SU5WQUxJRF9DUklURVJJT05fVFlQRV9HUk9VUBAFElEKTVRBUkdFVElOR19T",
            "RVRUSU5HX0RFTU9HUkFQSElDX0NSSVRFUklPTl9UWVBFX0dST1VQU19NVVNU",
            "X0JFX1NFVF9UT19UQVJHRVRfQUxMEAYSXApYVEFSR0VUSU5HX1NFVFRJTkdf",
            "Q0FOTk9UX0NIQU5HRV9UQVJHRVRfQUxMX1RPX0ZBTFNFX0ZPUl9ERU1PR1JB",
            "UEhJQ19DUklURVJJT05fVFlQRV9HUk9VUBAHEkMKP0RZTkFNSUNfU0VBUkNI",
            "X0FEU19TRVRUSU5HX0FUX0xFQVNUX09ORV9GRUVEX0lEX01VU1RfQkVfUFJF",
            "U0VOVBAIEjsKN0RZTkFNSUNfU0VBUkNIX0FEU19TRVRUSU5HX0NPTlRBSU5T",
            "X0lOVkFMSURfRE9NQUlOX05BTUUQCRI2CjJEWU5BTUlDX1NFQVJDSF9BRFNf",
            "U0VUVElOR19DT05UQUlOU19TVUJET01BSU5fTkFNRRAKEj0KOURZTkFNSUNf",
            "U0VBUkNIX0FEU19TRVRUSU5HX0NPTlRBSU5TX0lOVkFMSURfTEFOR1VBR0Vf",
            "Q09ERRALEj4KOlRBUkdFVF9BTExfSVNfTk9UX0FMTE9XRURfRk9SX1BMQUNF",
            "TUVOVF9JTl9TRUFSQ0hfQ0FNUEFJR04QDBIuCipTRVRUSU5HX1ZBTFVFX05P",
            "VF9DT01QQVRJQkxFX1dJVEhfQ0FNUEFJR04QFBJICkRCSURfT05MWV9JU19O",
            "T1RfQUxMT1dFRF9UT19CRV9NT0RJRklFRF9XSVRIX0NVU1RPTUVSX01BVENI",
            "X1RBUkdFVElORxAVQvEBCiNjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEz",
            "LmVycm9yc0IRU2V0dGluZ0Vycm9yUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxMy9lcnJv",
            "cnM7ZXJyb3JzogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEzLkVy",
            "cm9yc8oCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxM1xFcnJvcnPqAiNHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWMTM6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Errors.SettingErrorEnum), global::Google.Ads.GoogleAds.V13.Errors.SettingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Errors.SettingErrorEnum.Types.SettingError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible setting errors.
  /// </summary>
  public sealed partial class SettingErrorEnum : pb::IMessage<SettingErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SettingErrorEnum> _parser = new pb::MessageParser<SettingErrorEnum>(() => new SettingErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SettingErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Errors.SettingErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SettingErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SettingErrorEnum(SettingErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SettingErrorEnum Clone() {
      return new SettingErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SettingErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SettingErrorEnum other) {
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
    public void MergeFrom(SettingErrorEnum other) {
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
    /// <summary>Container for nested types declared in the SettingErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible setting errors.
      /// </summary>
      public enum SettingError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The campaign setting is not available for this Google Ads account.
        /// </summary>
        [pbr::OriginalName("SETTING_TYPE_IS_NOT_AVAILABLE")] SettingTypeIsNotAvailable = 3,
        /// <summary>
        /// The setting is not compatible with the campaign.
        /// </summary>
        [pbr::OriginalName("SETTING_TYPE_IS_NOT_COMPATIBLE_WITH_CAMPAIGN")] SettingTypeIsNotCompatibleWithCampaign = 4,
        /// <summary>
        /// The supplied TargetingSetting contains an invalid CriterionTypeGroup. See
        /// CriterionTypeGroup documentation for CriterionTypeGroups allowed
        /// in Campaign or AdGroup TargetingSettings.
        /// </summary>
        [pbr::OriginalName("TARGETING_SETTING_CONTAINS_INVALID_CRITERION_TYPE_GROUP")] TargetingSettingContainsInvalidCriterionTypeGroup = 5,
        /// <summary>
        /// TargetingSetting must not explicitly
        /// set any of the Demographic CriterionTypeGroups (AGE_RANGE, GENDER,
        /// PARENT, INCOME_RANGE) to false (it's okay to not set them at all, in
        /// which case the system will set them to true automatically).
        /// </summary>
        [pbr::OriginalName("TARGETING_SETTING_DEMOGRAPHIC_CRITERION_TYPE_GROUPS_MUST_BE_SET_TO_TARGET_ALL")] TargetingSettingDemographicCriterionTypeGroupsMustBeSetToTargetAll = 6,
        /// <summary>
        /// TargetingSetting cannot change any of
        /// the Demographic CriterionTypeGroups (AGE_RANGE, GENDER, PARENT,
        /// INCOME_RANGE) from true to false.
        /// </summary>
        [pbr::OriginalName("TARGETING_SETTING_CANNOT_CHANGE_TARGET_ALL_TO_FALSE_FOR_DEMOGRAPHIC_CRITERION_TYPE_GROUP")] TargetingSettingCannotChangeTargetAllToFalseForDemographicCriterionTypeGroup = 7,
        /// <summary>
        /// At least one feed id should be present.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_SEARCH_ADS_SETTING_AT_LEAST_ONE_FEED_ID_MUST_BE_PRESENT")] DynamicSearchAdsSettingAtLeastOneFeedIdMustBePresent = 8,
        /// <summary>
        /// The supplied DynamicSearchAdsSetting contains an invalid domain name.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_INVALID_DOMAIN_NAME")] DynamicSearchAdsSettingContainsInvalidDomainName = 9,
        /// <summary>
        /// The supplied DynamicSearchAdsSetting contains a subdomain name.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_SUBDOMAIN_NAME")] DynamicSearchAdsSettingContainsSubdomainName = 10,
        /// <summary>
        /// The supplied DynamicSearchAdsSetting contains an invalid language code.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_INVALID_LANGUAGE_CODE")] DynamicSearchAdsSettingContainsInvalidLanguageCode = 11,
        /// <summary>
        /// TargetingSettings in search campaigns should not have
        /// CriterionTypeGroup.PLACEMENT set to targetAll.
        /// </summary>
        [pbr::OriginalName("TARGET_ALL_IS_NOT_ALLOWED_FOR_PLACEMENT_IN_SEARCH_CAMPAIGN")] TargetAllIsNotAllowedForPlacementInSearchCampaign = 12,
        /// <summary>
        /// The setting value is not compatible with the campaign type.
        /// </summary>
        [pbr::OriginalName("SETTING_VALUE_NOT_COMPATIBLE_WITH_CAMPAIGN")] SettingValueNotCompatibleWithCampaign = 20,
        /// <summary>
        /// Switching from observation setting to targeting setting is not allowed
        /// for Customer Match lists. See
        /// https://support.google.com/google-ads/answer/6299717.
        /// </summary>
        [pbr::OriginalName("BID_ONLY_IS_NOT_ALLOWED_TO_BE_MODIFIED_WITH_CUSTOMER_MATCH_TARGETING")] BidOnlyIsNotAllowedToBeModifiedWithCustomerMatchTargeting = 21,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
