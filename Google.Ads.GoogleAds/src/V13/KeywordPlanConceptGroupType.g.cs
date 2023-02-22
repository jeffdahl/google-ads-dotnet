// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/enums/keyword_plan_concept_group_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/enums/keyword_plan_concept_group_type.proto</summary>
  public static partial class KeywordPlanConceptGroupTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/enums/keyword_plan_concept_group_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanConceptGroupTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZW51bXMva2V5d29yZF9wbGFu",
            "X2NvbmNlcHRfZ3JvdXBfdHlwZS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjEzLmVudW1zIooBCh9LZXl3b3JkUGxhbkNvbmNlcHRHcm91cFR5cGVF",
            "bnVtImcKG0tleXdvcmRQbGFuQ29uY2VwdEdyb3VwVHlwZRIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARIJCgVCUkFORBACEhAKDE9USEVSX0JSQU5E",
            "UxADEg0KCU5PTl9CUkFORBAEQvoBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjEzLmVudW1zQiBLZXl3b3JkUGxhbkNvbmNlcHRHcm91cFR5cGVQcm90",
            "b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjEzL2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xlLkFk",
            "cy5Hb29nbGVBZHMuVjEzLkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjEzXEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEzOjpFbnVt",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Enums.KeywordPlanConceptGroupTypeEnum), global::Google.Ads.GoogleAds.V13.Enums.KeywordPlanConceptGroupTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Enums.KeywordPlanConceptGroupTypeEnum.Types.KeywordPlanConceptGroupType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of keyword plan concept group types.
  /// </summary>
  public sealed partial class KeywordPlanConceptGroupTypeEnum : pb::IMessage<KeywordPlanConceptGroupTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KeywordPlanConceptGroupTypeEnum> _parser = new pb::MessageParser<KeywordPlanConceptGroupTypeEnum>(() => new KeywordPlanConceptGroupTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KeywordPlanConceptGroupTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Enums.KeywordPlanConceptGroupTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanConceptGroupTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanConceptGroupTypeEnum(KeywordPlanConceptGroupTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanConceptGroupTypeEnum Clone() {
      return new KeywordPlanConceptGroupTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanConceptGroupTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KeywordPlanConceptGroupTypeEnum other) {
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
    public void MergeFrom(KeywordPlanConceptGroupTypeEnum other) {
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
    /// <summary>Container for nested types declared in the KeywordPlanConceptGroupTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enumerates keyword plan concept group types.
      /// </summary>
      public enum KeywordPlanConceptGroupType {
        /// <summary>
        /// The concept group classification different from brand/non-brand.
        /// This is a catch all bucket for all classifications that are none of the
        /// below.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The concept group classification is based on BRAND.
        /// </summary>
        [pbr::OriginalName("BRAND")] Brand = 2,
        /// <summary>
        /// The concept group classification based on BRAND, that didn't fit well
        /// with the BRAND classifications. These are generally outliers and can have
        /// very few keywords in this type of classification.
        /// </summary>
        [pbr::OriginalName("OTHER_BRANDS")] OtherBrands = 3,
        /// <summary>
        /// These concept group classification is not based on BRAND. This is
        /// returned for generic keywords that don't have a brand association.
        /// </summary>
        [pbr::OriginalName("NON_BRAND")] NonBrand = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
