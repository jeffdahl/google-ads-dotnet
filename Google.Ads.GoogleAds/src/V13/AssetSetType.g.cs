// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/enums/asset_set_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/enums/asset_set_type.proto</summary>
  public static partial class AssetSetTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/enums/asset_set_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetSetTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZW51bXMvYXNzZXRfc2V0X3R5",
            "cGUucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMy5lbnVtcyKtAwoQ",
            "QXNzZXRTZXRUeXBlRW51bSKYAwoMQXNzZXRTZXRUeXBlEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEg0KCVBBR0VfRkVFRBACEhUKEURZTkFNSUNf",
            "RURVQ0FUSU9OEAMSGAoUTUVSQ0hBTlRfQ0VOVEVSX0ZFRUQQBBIXChNEWU5B",
            "TUlDX1JFQUxfRVNUQVRFEAUSEgoORFlOQU1JQ19DVVNUT00QBhIeChpEWU5B",
            "TUlDX0hPVEVMU19BTkRfUkVOVEFMUxAHEhMKD0RZTkFNSUNfRkxJR0hUUxAI",
            "EhIKDkRZTkFNSUNfVFJBVkVMEAkSEQoNRFlOQU1JQ19MT0NBTBAKEhAKDERZ",
            "TkFNSUNfSk9CUxALEhEKDUxPQ0FUSU9OX1NZTkMQDBIrCidCVVNJTkVTU19Q",
            "Uk9GSUxFX0RZTkFNSUNfTE9DQVRJT05fR1JPVVAQDRIgChxDSEFJTl9EWU5B",
            "TUlDX0xPQ0FUSU9OX0dST1VQEA4SGQoVU1RBVElDX0xPQ0FUSU9OX0dST1VQ",
            "EA8SEgoOSE9URUxfUFJPUEVSVFkQEELrAQoiY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxMy5lbnVtc0IRQXNzZXRTZXRUeXBlUHJvdG9QAVpDZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRz",
            "L3YxMy9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRz",
            "LlYxMy5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxM1xFbnVtc+oC",
            "Ikdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMzo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Enums.AssetSetTypeEnum), global::Google.Ads.GoogleAds.V13.Enums.AssetSetTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Enums.AssetSetTypeEnum.Types.AssetSetType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible types of an asset set.
  /// </summary>
  public sealed partial class AssetSetTypeEnum : pb::IMessage<AssetSetTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetSetTypeEnum> _parser = new pb::MessageParser<AssetSetTypeEnum>(() => new AssetSetTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetSetTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Enums.AssetSetTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetTypeEnum(AssetSetTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetTypeEnum Clone() {
      return new AssetSetTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetSetTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetSetTypeEnum other) {
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
    public void MergeFrom(AssetSetTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AssetSetTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible types of an asset set.
      /// </summary>
      public enum AssetSetType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Page asset set.
        /// </summary>
        [pbr::OriginalName("PAGE_FEED")] PageFeed = 2,
        /// <summary>
        /// Dynamic education asset set.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_EDUCATION")] DynamicEducation = 3,
        /// <summary>
        /// Google Merchant Center asset set.
        /// </summary>
        [pbr::OriginalName("MERCHANT_CENTER_FEED")] MerchantCenterFeed = 4,
        /// <summary>
        /// Dynamic real estate asset set.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_REAL_ESTATE")] DynamicRealEstate = 5,
        /// <summary>
        /// Dynamic custom asset set.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_CUSTOM")] DynamicCustom = 6,
        /// <summary>
        /// Dynamic hotels and rentals asset set.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_HOTELS_AND_RENTALS")] DynamicHotelsAndRentals = 7,
        /// <summary>
        /// Dynamic flights asset set.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_FLIGHTS")] DynamicFlights = 8,
        /// <summary>
        /// Dynamic travel asset set.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_TRAVEL")] DynamicTravel = 9,
        /// <summary>
        /// Dynamic local asset set.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_LOCAL")] DynamicLocal = 10,
        /// <summary>
        /// Dynamic jobs asset set.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_JOBS")] DynamicJobs = 11,
        /// <summary>
        /// Location sync level asset set.
        /// </summary>
        [pbr::OriginalName("LOCATION_SYNC")] LocationSync = 12,
        /// <summary>
        /// Business Profile location group asset set.
        /// </summary>
        [pbr::OriginalName("BUSINESS_PROFILE_DYNAMIC_LOCATION_GROUP")] BusinessProfileDynamicLocationGroup = 13,
        /// <summary>
        /// Chain location group asset set which can be used for both owned
        /// locations and affiliate locations.
        /// </summary>
        [pbr::OriginalName("CHAIN_DYNAMIC_LOCATION_GROUP")] ChainDynamicLocationGroup = 14,
        /// <summary>
        /// Static location group asset set which can be used for both owned
        /// locations and affiliate locations.
        /// </summary>
        [pbr::OriginalName("STATIC_LOCATION_GROUP")] StaticLocationGroup = 15,
        /// <summary>
        /// Hotel Property asset set which is used to link a hotel property feed to
        /// Performance Max for travel goals campaigns.
        /// </summary>
        [pbr::OriginalName("HOTEL_PROPERTY")] HotelProperty = 16,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
