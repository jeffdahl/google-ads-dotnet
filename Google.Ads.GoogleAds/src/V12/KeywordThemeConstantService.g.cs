// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/services/keyword_theme_constant_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/services/keyword_theme_constant_service.proto</summary>
  public static partial class KeywordThemeConstantServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/services/keyword_theme_constant_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordThemeConstantServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvc2VydmljZXMva2V5d29yZF90",
            "aGVtZV9jb25zdGFudF9zZXJ2aWNlLnByb3RvEiFnb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTIuc2VydmljZXMaP2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxMi9y",
            "ZXNvdXJjZXMva2V5d29yZF90aGVtZV9jb25zdGFudC5wcm90bxocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJv",
            "dG8iZgojU3VnZ2VzdEtleXdvcmRUaGVtZUNvbnN0YW50c1JlcXVlc3QSEgoK",
            "cXVlcnlfdGV4dBgBIAEoCRIUCgxjb3VudHJ5X2NvZGUYAiABKAkSFQoNbGFu",
            "Z3VhZ2VfY29kZRgDIAEoCSKBAQokU3VnZ2VzdEtleXdvcmRUaGVtZUNvbnN0",
            "YW50c1Jlc3BvbnNlElkKF2tleXdvcmRfdGhlbWVfY29uc3RhbnRzGAEgAygL",
            "MjguZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEyLnJlc291cmNlcy5LZXl3b3Jk",
            "VGhlbWVDb25zdGFudDLFAgobS2V5d29yZFRoZW1lQ29uc3RhbnRTZXJ2aWNl",
            "Et4BChxTdWdnZXN0S2V5d29yZFRoZW1lQ29uc3RhbnRzEkYuZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjEyLnNlcnZpY2VzLlN1Z2dlc3RLZXl3b3JkVGhlbWVD",
            "b25zdGFudHNSZXF1ZXN0GkcuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEyLnNl",
            "cnZpY2VzLlN1Z2dlc3RLZXl3b3JkVGhlbWVDb25zdGFudHNSZXNwb25zZSIt",
            "gtPkkwInIiIvdjEyL2tleXdvcmRUaGVtZUNvbnN0YW50czpzdWdnZXN0OgEq",
            "GkXKQRhnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb23SQSdodHRwczovL3d3dy5n",
            "b29nbGVhcGlzLmNvbS9hdXRoL2Fkd29yZHNCjAIKJWNvbS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MTIuc2VydmljZXNCIEtleXdvcmRUaGVtZUNvbnN0YW50",
            "U2VydmljZVByb3RvUAFaSWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTIvc2VydmljZXM7c2VydmljZXOi",
            "AgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WMTIuU2VydmljZXPKAiFH",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWMTJcU2VydmljZXPqAiVHb29nbGU6OkFk",
            "czo6R29vZ2xlQWRzOjpWMTI6OlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V12.Resources.KeywordThemeConstantReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Services.SuggestKeywordThemeConstantsRequest), global::Google.Ads.GoogleAds.V12.Services.SuggestKeywordThemeConstantsRequest.Parser, new[]{ "QueryText", "CountryCode", "LanguageCode" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Services.SuggestKeywordThemeConstantsResponse), global::Google.Ads.GoogleAds.V12.Services.SuggestKeywordThemeConstantsResponse.Parser, new[]{ "KeywordThemeConstants" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [KeywordThemeConstantService.SuggestKeywordThemeConstants][google.ads.googleads.v12.services.KeywordThemeConstantService.SuggestKeywordThemeConstants].
  /// </summary>
  public sealed partial class SuggestKeywordThemeConstantsRequest : pb::IMessage<SuggestKeywordThemeConstantsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SuggestKeywordThemeConstantsRequest> _parser = new pb::MessageParser<SuggestKeywordThemeConstantsRequest>(() => new SuggestKeywordThemeConstantsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SuggestKeywordThemeConstantsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Services.KeywordThemeConstantServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsRequest(SuggestKeywordThemeConstantsRequest other) : this() {
      queryText_ = other.queryText_;
      countryCode_ = other.countryCode_;
      languageCode_ = other.languageCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsRequest Clone() {
      return new SuggestKeywordThemeConstantsRequest(this);
    }

    /// <summary>Field number for the "query_text" field.</summary>
    public const int QueryTextFieldNumber = 1;
    private string queryText_ = "";
    /// <summary>
    /// The query text of a keyword theme that will be used to map to similar
    /// keyword themes. For example, "plumber" or "roofer".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string QueryText {
      get { return queryText_; }
      set {
        queryText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "country_code" field.</summary>
    public const int CountryCodeFieldNumber = 2;
    private string countryCode_ = "";
    /// <summary>
    /// Upper-case, two-letter country code as defined by ISO-3166. This for
    /// refining the scope of the query, default to 'US' if not set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CountryCode {
      get { return countryCode_; }
      set {
        countryCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "language_code" field.</summary>
    public const int LanguageCodeFieldNumber = 3;
    private string languageCode_ = "";
    /// <summary>
    /// The two letter language code for get corresponding keyword theme for
    /// refining the scope of the query, default to 'en' if not set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LanguageCode {
      get { return languageCode_; }
      set {
        languageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SuggestKeywordThemeConstantsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SuggestKeywordThemeConstantsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QueryText != other.QueryText) return false;
      if (CountryCode != other.CountryCode) return false;
      if (LanguageCode != other.LanguageCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (QueryText.Length != 0) hash ^= QueryText.GetHashCode();
      if (CountryCode.Length != 0) hash ^= CountryCode.GetHashCode();
      if (LanguageCode.Length != 0) hash ^= LanguageCode.GetHashCode();
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
      if (QueryText.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(QueryText);
      }
      if (CountryCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CountryCode);
      }
      if (LanguageCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LanguageCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (QueryText.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(QueryText);
      }
      if (CountryCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CountryCode);
      }
      if (LanguageCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LanguageCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (QueryText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(QueryText);
      }
      if (CountryCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CountryCode);
      }
      if (LanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SuggestKeywordThemeConstantsRequest other) {
      if (other == null) {
        return;
      }
      if (other.QueryText.Length != 0) {
        QueryText = other.QueryText;
      }
      if (other.CountryCode.Length != 0) {
        CountryCode = other.CountryCode;
      }
      if (other.LanguageCode.Length != 0) {
        LanguageCode = other.LanguageCode;
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
          case 10: {
            QueryText = input.ReadString();
            break;
          }
          case 18: {
            CountryCode = input.ReadString();
            break;
          }
          case 26: {
            LanguageCode = input.ReadString();
            break;
          }
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
          case 10: {
            QueryText = input.ReadString();
            break;
          }
          case 18: {
            CountryCode = input.ReadString();
            break;
          }
          case 26: {
            LanguageCode = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response message for
  /// [KeywordThemeConstantService.SuggestKeywordThemeConstants][google.ads.googleads.v12.services.KeywordThemeConstantService.SuggestKeywordThemeConstants].
  /// </summary>
  public sealed partial class SuggestKeywordThemeConstantsResponse : pb::IMessage<SuggestKeywordThemeConstantsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SuggestKeywordThemeConstantsResponse> _parser = new pb::MessageParser<SuggestKeywordThemeConstantsResponse>(() => new SuggestKeywordThemeConstantsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SuggestKeywordThemeConstantsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Services.KeywordThemeConstantServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsResponse(SuggestKeywordThemeConstantsResponse other) : this() {
      keywordThemeConstants_ = other.keywordThemeConstants_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestKeywordThemeConstantsResponse Clone() {
      return new SuggestKeywordThemeConstantsResponse(this);
    }

    /// <summary>Field number for the "keyword_theme_constants" field.</summary>
    public const int KeywordThemeConstantsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V12.Resources.KeywordThemeConstant> _repeated_keywordThemeConstants_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V12.Resources.KeywordThemeConstant.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V12.Resources.KeywordThemeConstant> keywordThemeConstants_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V12.Resources.KeywordThemeConstant>();
    /// <summary>
    /// Smart Campaign keyword theme suggestions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V12.Resources.KeywordThemeConstant> KeywordThemeConstants {
      get { return keywordThemeConstants_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SuggestKeywordThemeConstantsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SuggestKeywordThemeConstantsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!keywordThemeConstants_.Equals(other.keywordThemeConstants_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= keywordThemeConstants_.GetHashCode();
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
      keywordThemeConstants_.WriteTo(output, _repeated_keywordThemeConstants_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      keywordThemeConstants_.WriteTo(ref output, _repeated_keywordThemeConstants_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += keywordThemeConstants_.CalculateSize(_repeated_keywordThemeConstants_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SuggestKeywordThemeConstantsResponse other) {
      if (other == null) {
        return;
      }
      keywordThemeConstants_.Add(other.keywordThemeConstants_);
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
          case 10: {
            keywordThemeConstants_.AddEntriesFrom(input, _repeated_keywordThemeConstants_codec);
            break;
          }
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
          case 10: {
            keywordThemeConstants_.AddEntriesFrom(ref input, _repeated_keywordThemeConstants_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
