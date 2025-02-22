// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/resources/asset_group_signal.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/resources/asset_group_signal.proto</summary>
  public static partial class AssetGroupSignalReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/resources/asset_group_signal.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetGroupSignalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvcmVzb3VyY2VzL2Fzc2V0X2dy",
            "b3VwX3NpZ25hbC5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEyLnJl",
            "c291cmNlcxouZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEyL2NvbW1vbi9jcml0",
            "ZXJpYS5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZ",
            "Z29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byLfAgoQQXNzZXRHcm91cFNpZ25h",
            "bBJICg1yZXNvdXJjZV9uYW1lGAEgASgJQjHgQQX6QSsKKWdvb2dsZWFkcy5n",
            "b29nbGVhcGlzLmNvbS9Bc3NldEdyb3VwU2lnbmFsEkAKC2Fzc2V0X2dyb3Vw",
            "GAIgASgJQivgQQX6QSUKI2dvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9Bc3Nl",
            "dEdyb3VwEkQKCGF1ZGllbmNlGAMgASgLMi0uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjEyLmNvbW1vbi5BdWRpZW5jZUluZm9CA+BBBTp56kF2Cilnb29nbGVh",
            "ZHMuZ29vZ2xlYXBpcy5jb20vQXNzZXRHcm91cFNpZ25hbBJJY3VzdG9tZXJz",
            "L3tjdXN0b21lcl9pZH0vYXNzZXRHcm91cFNpZ25hbHMve2Fzc2V0X2dyb3Vw",
            "X2lkfX57Y3JpdGVyaW9uX2lkfUKHAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxMi5yZXNvdXJjZXNCFUFzc2V0R3JvdXBTaWduYWxQcm90b1ABWktn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29n",
            "bGVhZHMvdjEyL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJHb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WMTIuUmVzb3VyY2VzygIiR29vZ2xlXEFkc1xHb29n",
            "bGVBZHNcVjEyXFJlc291cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYxMjo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V12.Common.CriteriaReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Resources.AssetGroupSignal), global::Google.Ads.GoogleAds.V12.Resources.AssetGroupSignal.Parser, new[]{ "ResourceName", "AssetGroup", "Audience" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// AssetGroupSignal represents a signal in an asset group. The existence of a
  /// signal tells the performance max campaign who's most likely to convert.
  /// Performance Max uses the signal to look for new people with similar or
  /// stronger intent to find conversions across Search, Display, Video, and more.
  /// </summary>
  public sealed partial class AssetGroupSignal : pb::IMessage<AssetGroupSignal>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetGroupSignal> _parser = new pb::MessageParser<AssetGroupSignal>(() => new AssetGroupSignal());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetGroupSignal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Resources.AssetGroupSignalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupSignal() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupSignal(AssetGroupSignal other) : this() {
      resourceName_ = other.resourceName_;
      assetGroup_ = other.assetGroup_;
      audience_ = other.audience_ != null ? other.audience_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupSignal Clone() {
      return new AssetGroupSignal(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the asset group signal.
    /// Asset group signal resource name have the form:
    ///
    /// `customers/{customer_id}/assetGroupSignals/{asset_group_id}~{signal_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset_group" field.</summary>
    public const int AssetGroupFieldNumber = 2;
    private string assetGroup_ = "";
    /// <summary>
    /// Immutable. The asset group which this asset group signal belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AssetGroup {
      get { return assetGroup_; }
      set {
        assetGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "audience" field.</summary>
    public const int AudienceFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V12.Common.AudienceInfo audience_;
    /// <summary>
    /// Immutable. The signal(audience criterion) to be used by the performance max campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Common.AudienceInfo Audience {
      get { return audience_; }
      set {
        audience_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetGroupSignal);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetGroupSignal other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AssetGroup != other.AssetGroup) return false;
      if (!object.Equals(Audience, other.Audience)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (AssetGroup.Length != 0) hash ^= AssetGroup.GetHashCode();
      if (audience_ != null) hash ^= Audience.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (AssetGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssetGroup);
      }
      if (audience_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Audience);
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (AssetGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssetGroup);
      }
      if (audience_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Audience);
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
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (AssetGroup.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetGroup);
      }
      if (audience_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Audience);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetGroupSignal other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.AssetGroup.Length != 0) {
        AssetGroup = other.AssetGroup;
      }
      if (other.audience_ != null) {
        if (audience_ == null) {
          Audience = new global::Google.Ads.GoogleAds.V12.Common.AudienceInfo();
        }
        Audience.MergeFrom(other.Audience);
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
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            AssetGroup = input.ReadString();
            break;
          }
          case 26: {
            if (audience_ == null) {
              Audience = new global::Google.Ads.GoogleAds.V12.Common.AudienceInfo();
            }
            input.ReadMessage(Audience);
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
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            AssetGroup = input.ReadString();
            break;
          }
          case 26: {
            if (audience_ == null) {
              Audience = new global::Google.Ads.GoogleAds.V12.Common.AudienceInfo();
            }
            input.ReadMessage(Audience);
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
