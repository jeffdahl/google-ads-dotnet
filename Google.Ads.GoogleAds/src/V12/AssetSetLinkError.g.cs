// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/errors/asset_set_link_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/errors/asset_set_link_error.proto</summary>
  public static partial class AssetSetLinkErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/errors/asset_set_link_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetSetLinkErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZXJyb3JzL2Fzc2V0X3NldF9s",
            "aW5rX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTIuZXJy",
            "b3JzIocCChVBc3NldFNldExpbmtFcnJvckVudW0i7QEKEUFzc2V0U2V0TGlu",
            "a0Vycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEikKJUlOQ09N",
            "UEFUSUJMRV9BRFZFUlRJU0lOR19DSEFOTkVMX1RZUEUQAhIXChNEVVBMSUNB",
            "VEVfRkVFRF9MSU5LEAMSMgouSU5DT01QQVRJQkxFX0FTU0VUX1NFVF9UWVBF",
            "X1dJVEhfQ0FNUEFJR05fVFlQRRAEEhwKGERVUExJQ0FURV9BU1NFVF9TRVRf",
            "TElOSxAFEiQKIEFTU0VUX1NFVF9MSU5LX0NBTk5PVF9CRV9SRU1PVkVEEAZC",
            "9gEKI2NvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTIuZXJyb3JzQhZBc3Nl",
            "dFNldExpbmtFcnJvclByb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTIvZXJyb3JzO2Vycm9y",
            "c6ICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMi5FcnJvcnPKAh9H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWMTJcRXJyb3Jz6gIjR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjEyOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Errors.AssetSetLinkErrorEnum), global::Google.Ads.GoogleAds.V12.Errors.AssetSetLinkErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Errors.AssetSetLinkErrorEnum.Types.AssetSetLinkError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible asset set link errors.
  /// </summary>
  public sealed partial class AssetSetLinkErrorEnum : pb::IMessage<AssetSetLinkErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetSetLinkErrorEnum> _parser = new pb::MessageParser<AssetSetLinkErrorEnum>(() => new AssetSetLinkErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetSetLinkErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Errors.AssetSetLinkErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetLinkErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetLinkErrorEnum(AssetSetLinkErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetLinkErrorEnum Clone() {
      return new AssetSetLinkErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetSetLinkErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetSetLinkErrorEnum other) {
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
    public void MergeFrom(AssetSetLinkErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AssetSetLinkErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible asset set link errors.
      /// </summary>
      public enum AssetSetLinkError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Advertising channel type cannot be attached to the asset set due to
        /// channel-based restrictions.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_ADVERTISING_CHANNEL_TYPE")] IncompatibleAdvertisingChannelType = 2,
        /// <summary>
        /// For this asset set type, only one campaign to feed linkage is allowed.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_FEED_LINK")] DuplicateFeedLink = 3,
        /// <summary>
        /// The asset set type and campaign type are incompatible.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_ASSET_SET_TYPE_WITH_CAMPAIGN_TYPE")] IncompatibleAssetSetTypeWithCampaignType = 4,
        /// <summary>
        /// Cannot link duplicate asset sets to the same campaign.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_ASSET_SET_LINK")] DuplicateAssetSetLink = 5,
        /// <summary>
        /// Cannot remove the asset set link. If a campaign is linked with only one
        /// asset set and you attempt to unlink them, this error will be triggered.
        /// </summary>
        [pbr::OriginalName("ASSET_SET_LINK_CANNOT_BE_REMOVED")] AssetSetLinkCannotBeRemoved = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
