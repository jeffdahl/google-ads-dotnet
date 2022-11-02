// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/enums/affiliate_location_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/enums/affiliate_location_placeholder_field.proto</summary>
  public static partial class AffiliateLocationPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/enums/affiliate_location_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AffiliateLocationPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZW51bXMvYWZmaWxpYXRlX2xv",
            "Y2F0aW9uX3BsYWNlaG9sZGVyX2ZpZWxkLnByb3RvEh5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTIuZW51bXMipAIKJUFmZmlsaWF0ZUxvY2F0aW9uUGxhY2Vo",
            "b2xkZXJGaWVsZEVudW0i+gEKIUFmZmlsaWF0ZUxvY2F0aW9uUGxhY2Vob2xk",
            "ZXJGaWVsZBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIRCg1CVVNJ",
            "TkVTU19OQU1FEAISEgoOQUREUkVTU19MSU5FXzEQAxISCg5BRERSRVNTX0xJ",
            "TkVfMhAEEggKBENJVFkQBRIMCghQUk9WSU5DRRAGEg8KC1BPU1RBTF9DT0RF",
            "EAcSEAoMQ09VTlRSWV9DT0RFEAgSEAoMUEhPTkVfTlVNQkVSEAkSEQoNTEFO",
            "R1VBR0VfQ09ERRAKEgwKCENIQUlOX0lEEAsSDgoKQ0hBSU5fTkFNRRAMQoAC",
            "CiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEyLmVudW1zQiZBZmZpbGlh",
            "dGVMb2NhdGlvblBsYWNlaG9sZGVyRmllbGRQcm90b1ABWkNnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEy",
            "L2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEy",
            "LkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjEyXEVudW1z6gIiR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6VjEyOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Enums.AffiliateLocationPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V12.Enums.AffiliateLocationPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Enums.AffiliateLocationPlaceholderFieldEnum.Types.AffiliateLocationPlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Affiliate Location placeholder fields.
  /// </summary>
  public sealed partial class AffiliateLocationPlaceholderFieldEnum : pb::IMessage<AffiliateLocationPlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AffiliateLocationPlaceholderFieldEnum> _parser = new pb::MessageParser<AffiliateLocationPlaceholderFieldEnum>(() => new AffiliateLocationPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AffiliateLocationPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Enums.AffiliateLocationPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AffiliateLocationPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AffiliateLocationPlaceholderFieldEnum(AffiliateLocationPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AffiliateLocationPlaceholderFieldEnum Clone() {
      return new AffiliateLocationPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AffiliateLocationPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AffiliateLocationPlaceholderFieldEnum other) {
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
    public void MergeFrom(AffiliateLocationPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the AffiliateLocationPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible values for Affiliate Location placeholder fields.
      /// </summary>
      public enum AffiliateLocationPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. The name of the business.
        /// </summary>
        [pbr::OriginalName("BUSINESS_NAME")] BusinessName = 2,
        /// <summary>
        /// Data Type: STRING. Line 1 of the business address.
        /// </summary>
        [pbr::OriginalName("ADDRESS_LINE_1")] AddressLine1 = 3,
        /// <summary>
        /// Data Type: STRING. Line 2 of the business address.
        /// </summary>
        [pbr::OriginalName("ADDRESS_LINE_2")] AddressLine2 = 4,
        /// <summary>
        /// Data Type: STRING. City of the business address.
        /// </summary>
        [pbr::OriginalName("CITY")] City = 5,
        /// <summary>
        /// Data Type: STRING. Province of the business address.
        /// </summary>
        [pbr::OriginalName("PROVINCE")] Province = 6,
        /// <summary>
        /// Data Type: STRING. Postal code of the business address.
        /// </summary>
        [pbr::OriginalName("POSTAL_CODE")] PostalCode = 7,
        /// <summary>
        /// Data Type: STRING. Country code of the business address.
        /// </summary>
        [pbr::OriginalName("COUNTRY_CODE")] CountryCode = 8,
        /// <summary>
        /// Data Type: STRING. Phone number of the business.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER")] PhoneNumber = 9,
        /// <summary>
        /// Data Type: STRING. Language code of the business.
        /// </summary>
        [pbr::OriginalName("LANGUAGE_CODE")] LanguageCode = 10,
        /// <summary>
        /// Data Type: INT64. ID of the chain.
        /// </summary>
        [pbr::OriginalName("CHAIN_ID")] ChainId = 11,
        /// <summary>
        /// Data Type: STRING. Name of the chain.
        /// </summary>
        [pbr::OriginalName("CHAIN_NAME")] ChainName = 12,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
