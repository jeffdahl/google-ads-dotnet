// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/enums/local_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/enums/local_placeholder_field.proto</summary>
  public static partial class LocalPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/enums/local_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocalPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZW51bXMvbG9jYWxfcGxhY2Vo",
            "b2xkZXJfZmllbGQucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMy5l",
            "bnVtcyKoAwoZTG9jYWxQbGFjZWhvbGRlckZpZWxkRW51bSKKAwoVTG9jYWxQ",
            "bGFjZWhvbGRlckZpZWxkEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThAB",
            "EgsKB0RFQUxfSUQQAhINCglERUFMX05BTUUQAxIMCghTVUJUSVRMRRAEEg8K",
            "C0RFU0NSSVBUSU9OEAUSCQoFUFJJQ0UQBhITCg9GT1JNQVRURURfUFJJQ0UQ",
            "BxIOCgpTQUxFX1BSSUNFEAgSGAoURk9STUFUVEVEX1NBTEVfUFJJQ0UQCRIN",
            "CglJTUFHRV9VUkwQChILCgdBRERSRVNTEAsSDAoIQ0FURUdPUlkQDBIXChND",
            "T05URVhUVUFMX0tFWVdPUkRTEA0SDgoKRklOQUxfVVJMUxAOEhUKEUZJTkFM",
            "X01PQklMRV9VUkxTEA8SEAoMVFJBQ0tJTkdfVVJMEBASFAoQQU5EUk9JRF9B",
            "UFBfTElOSxAREhQKEFNJTUlMQVJfREVBTF9JRFMQEhIQCgxJT1NfQVBQX0xJ",
            "TksQExIUChBJT1NfQVBQX1NUT1JFX0lEEBRC9AEKImNvbS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MTMuZW51bXNCGkxvY2FsUGxhY2Vob2xkZXJGaWVsZFBy",
            "b3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92MTMvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WMTMuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFk",
            "c1xWMTNcRW51bXPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTM6OkVu",
            "dW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Enums.LocalPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V13.Enums.LocalPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Enums.LocalPlaceholderFieldEnum.Types.LocalPlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Local placeholder fields.
  /// For more information about dynamic remarketing feeds, see
  /// https://support.google.com/google-ads/answer/6053288.
  /// </summary>
  public sealed partial class LocalPlaceholderFieldEnum : pb::IMessage<LocalPlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LocalPlaceholderFieldEnum> _parser = new pb::MessageParser<LocalPlaceholderFieldEnum>(() => new LocalPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LocalPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Enums.LocalPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalPlaceholderFieldEnum(LocalPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalPlaceholderFieldEnum Clone() {
      return new LocalPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LocalPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LocalPlaceholderFieldEnum other) {
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
    public void MergeFrom(LocalPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the LocalPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible values for Local placeholder fields.
      /// </summary>
      public enum LocalPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. Required. Unique ID.
        /// </summary>
        [pbr::OriginalName("DEAL_ID")] DealId = 2,
        /// <summary>
        /// Data Type: STRING. Required. Main headline with local deal title to be
        /// shown in dynamic ad.
        /// </summary>
        [pbr::OriginalName("DEAL_NAME")] DealName = 3,
        /// <summary>
        /// Data Type: STRING. Local deal subtitle to be shown in dynamic ad.
        /// </summary>
        [pbr::OriginalName("SUBTITLE")] Subtitle = 4,
        /// <summary>
        /// Data Type: STRING. Description of local deal to be shown in dynamic ad.
        /// </summary>
        [pbr::OriginalName("DESCRIPTION")] Description = 5,
        /// <summary>
        /// Data Type: STRING. Price to be shown in the ad. Highly recommended for
        /// dynamic ads. Example: "100.00 USD"
        /// </summary>
        [pbr::OriginalName("PRICE")] Price = 6,
        /// <summary>
        /// Data Type: STRING. Formatted price to be shown in the ad.
        /// Example: "Starting at $100.00 USD", "$80 - $100"
        /// </summary>
        [pbr::OriginalName("FORMATTED_PRICE")] FormattedPrice = 7,
        /// <summary>
        /// Data Type: STRING. Sale price to be shown in the ad.
        /// Example: "80.00 USD"
        /// </summary>
        [pbr::OriginalName("SALE_PRICE")] SalePrice = 8,
        /// <summary>
        /// Data Type: STRING. Formatted sale price to be shown in the ad.
        /// Example: "On sale for $80.00", "$60 - $80"
        /// </summary>
        [pbr::OriginalName("FORMATTED_SALE_PRICE")] FormattedSalePrice = 9,
        /// <summary>
        /// Data Type: URL. Image to be displayed in the ad.
        /// </summary>
        [pbr::OriginalName("IMAGE_URL")] ImageUrl = 10,
        /// <summary>
        /// Data Type: STRING. Complete property address, including postal code.
        /// </summary>
        [pbr::OriginalName("ADDRESS")] Address = 11,
        /// <summary>
        /// Data Type: STRING. Category of local deal used to group like items
        /// together for recommendation engine.
        /// </summary>
        [pbr::OriginalName("CATEGORY")] Category = 12,
        /// <summary>
        /// Data Type: STRING_LIST. Keywords used for product retrieval.
        /// </summary>
        [pbr::OriginalName("CONTEXTUAL_KEYWORDS")] ContextualKeywords = 13,
        /// <summary>
        /// Data Type: URL_LIST. Required. Final URLs to be used in ad when using
        /// Upgraded URLs; the more specific the better (for example, the individual
        /// URL of a specific local deal and its location).
        /// </summary>
        [pbr::OriginalName("FINAL_URLS")] FinalUrls = 14,
        /// <summary>
        /// Data Type: URL_LIST. Final mobile URLs for the ad when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URLS")] FinalMobileUrls = 15,
        /// <summary>
        /// Data Type: URL. Tracking template for the ad when using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 16,
        /// <summary>
        /// Data Type: STRING. Android app link. Must be formatted as:
        /// android-app://{package_id}/{scheme}/{host_path}.
        /// The components are defined as follows:
        /// package_id: app ID as specified in Google Play.
        /// scheme: the scheme to pass to the application. Can be HTTP, or a custom
        ///   scheme.
        /// host_path: identifies the specific content within your application.
        /// </summary>
        [pbr::OriginalName("ANDROID_APP_LINK")] AndroidAppLink = 17,
        /// <summary>
        /// Data Type: STRING_LIST. List of recommended local deal IDs to show
        /// together with this item.
        /// </summary>
        [pbr::OriginalName("SIMILAR_DEAL_IDS")] SimilarDealIds = 18,
        /// <summary>
        /// Data Type: STRING. iOS app link.
        /// </summary>
        [pbr::OriginalName("IOS_APP_LINK")] IosAppLink = 19,
        /// <summary>
        /// Data Type: INT64. iOS app store ID.
        /// </summary>
        [pbr::OriginalName("IOS_APP_STORE_ID")] IosAppStoreId = 20,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
