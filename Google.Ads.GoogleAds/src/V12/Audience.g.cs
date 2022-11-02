// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/resources/audience.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/resources/audience.proto</summary>
  public static partial class AudienceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/resources/audience.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AudienceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvcmVzb3VyY2VzL2F1ZGllbmNl",
            "LnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTIucmVzb3VyY2VzGi9n",
            "b29nbGUvYWRzL2dvb2dsZWFkcy92MTIvY29tbW9uL2F1ZGllbmNlcy5wcm90",
            "bxo0Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEyL2VudW1zL2F1ZGllbmNlX3N0",
            "YXR1cy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZ",
            "Z29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byLYAwoIQXVkaWVuY2USQAoNcmVz",
            "b3VyY2VfbmFtZRgBIAEoCUIp4EEF+kEjCiFnb29nbGVhZHMuZ29vZ2xlYXBp",
            "cy5jb20vQXVkaWVuY2USDwoCaWQYAiABKANCA+BBAxJWCgZzdGF0dXMYAyAB",
            "KA4yQS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTIuZW51bXMuQXVkaWVuY2VT",
            "dGF0dXNFbnVtLkF1ZGllbmNlU3RhdHVzQgPgQQMSEQoEbmFtZRgEIAEoCUID",
            "4EECEhMKC2Rlc2NyaXB0aW9uGAUgASgJEkYKCmRpbWVuc2lvbnMYBiADKAsy",
            "Mi5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTIuY29tbW9uLkF1ZGllbmNlRGlt",
            "ZW5zaW9uElgKE2V4Y2x1c2lvbl9kaW1lbnNpb24YByABKAsyOy5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52MTIuY29tbW9uLkF1ZGllbmNlRXhjbHVzaW9uRGlt",
            "ZW5zaW9uOlfqQVQKIWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9BdWRpZW5j",
            "ZRIvY3VzdG9tZXJzL3tjdXN0b21lcl9pZH0vYXVkaWVuY2VzL3thdWRpZW5j",
            "ZV9pZH1C/wEKJmNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTIucmVzb3Vy",
            "Y2VzQg1BdWRpZW5jZVByb3RvUAFaS2dvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTIvcmVzb3VyY2VzO3Jl",
            "c291cmNlc6ICA0dBQaoCIkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMi5SZXNv",
            "dXJjZXPKAiJHb29nbGVcQWRzXEdvb2dsZUFkc1xWMTJcUmVzb3VyY2Vz6gIm",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEyOjpSZXNvdXJjZXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V12.Common.AudiencesReflection.Descriptor, global::Google.Ads.GoogleAds.V12.Enums.AudienceStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Resources.Audience), global::Google.Ads.GoogleAds.V12.Resources.Audience.Parser, new[]{ "ResourceName", "Id", "Status", "Name", "Description", "Dimensions", "ExclusionDimension" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Audience is an effective targeting option that lets you
  /// intersect different segment attributes, such as detailed demographics and
  /// affinities, to create audiences that represent sections of your target
  /// segments.
  /// </summary>
  public sealed partial class Audience : pb::IMessage<Audience>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Audience> _parser = new pb::MessageParser<Audience>(() => new Audience());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Audience> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Resources.AudienceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Audience() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Audience(Audience other) : this() {
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      status_ = other.status_;
      name_ = other.name_;
      description_ = other.description_;
      dimensions_ = other.dimensions_.Clone();
      exclusionDimension_ = other.exclusionDimension_ != null ? other.exclusionDimension_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Audience Clone() {
      return new Audience(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the audience.
    /// Audience names have the form:
    ///
    /// `customers/{customer_id}/audiences/{audience_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private long id_;
    /// <summary>
    /// Output only. ID of the audience.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V12.Enums.AudienceStatusEnum.Types.AudienceStatus status_ = global::Google.Ads.GoogleAds.V12.Enums.AudienceStatusEnum.Types.AudienceStatus.Unspecified;
    /// <summary>
    /// Output only. Status of this audience. Indicates whether the audience
    /// is enabled or removed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Enums.AudienceStatusEnum.Types.AudienceStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    /// <summary>
    /// Required. Name of the audience. It should be unique across all
    /// audiences. It must have a minimum length of 1 and
    /// maximum length of 255.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 5;
    private string description_ = "";
    /// <summary>
    /// Description of this audience.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dimensions" field.</summary>
    public const int DimensionsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V12.Common.AudienceDimension> _repeated_dimensions_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Ads.GoogleAds.V12.Common.AudienceDimension.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V12.Common.AudienceDimension> dimensions_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V12.Common.AudienceDimension>();
    /// <summary>
    /// Positive dimensions specifying the audience composition.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V12.Common.AudienceDimension> Dimensions {
      get { return dimensions_; }
    }

    /// <summary>Field number for the "exclusion_dimension" field.</summary>
    public const int ExclusionDimensionFieldNumber = 7;
    private global::Google.Ads.GoogleAds.V12.Common.AudienceExclusionDimension exclusionDimension_;
    /// <summary>
    /// Negative dimension specifying the audience composition.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Common.AudienceExclusionDimension ExclusionDimension {
      get { return exclusionDimension_; }
      set {
        exclusionDimension_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Audience);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Audience other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Status != other.Status) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if(!dimensions_.Equals(other.dimensions_)) return false;
      if (!object.Equals(ExclusionDimension, other.ExclusionDimension)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AudienceStatusEnum.Types.AudienceStatus.Unspecified) hash ^= Status.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      hash ^= dimensions_.GetHashCode();
      if (exclusionDimension_ != null) hash ^= ExclusionDimension.GetHashCode();
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
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AudienceStatusEnum.Types.AudienceStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Description);
      }
      dimensions_.WriteTo(output, _repeated_dimensions_codec);
      if (exclusionDimension_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ExclusionDimension);
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
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AudienceStatusEnum.Types.AudienceStatus.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Description);
      }
      dimensions_.WriteTo(ref output, _repeated_dimensions_codec);
      if (exclusionDimension_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ExclusionDimension);
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
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AudienceStatusEnum.Types.AudienceStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      size += dimensions_.CalculateSize(_repeated_dimensions_codec);
      if (exclusionDimension_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExclusionDimension);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Audience other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V12.Enums.AudienceStatusEnum.Types.AudienceStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      dimensions_.Add(other.dimensions_);
      if (other.exclusionDimension_ != null) {
        if (exclusionDimension_ == null) {
          ExclusionDimension = new global::Google.Ads.GoogleAds.V12.Common.AudienceExclusionDimension();
        }
        ExclusionDimension.MergeFrom(other.ExclusionDimension);
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
          case 16: {
            Id = input.ReadInt64();
            break;
          }
          case 24: {
            Status = (global::Google.Ads.GoogleAds.V12.Enums.AudienceStatusEnum.Types.AudienceStatus) input.ReadEnum();
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
          case 42: {
            Description = input.ReadString();
            break;
          }
          case 50: {
            dimensions_.AddEntriesFrom(input, _repeated_dimensions_codec);
            break;
          }
          case 58: {
            if (exclusionDimension_ == null) {
              ExclusionDimension = new global::Google.Ads.GoogleAds.V12.Common.AudienceExclusionDimension();
            }
            input.ReadMessage(ExclusionDimension);
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
          case 16: {
            Id = input.ReadInt64();
            break;
          }
          case 24: {
            Status = (global::Google.Ads.GoogleAds.V12.Enums.AudienceStatusEnum.Types.AudienceStatus) input.ReadEnum();
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
          case 42: {
            Description = input.ReadString();
            break;
          }
          case 50: {
            dimensions_.AddEntriesFrom(ref input, _repeated_dimensions_codec);
            break;
          }
          case 58: {
            if (exclusionDimension_ == null) {
              ExclusionDimension = new global::Google.Ads.GoogleAds.V12.Common.AudienceExclusionDimension();
            }
            input.ReadMessage(ExclusionDimension);
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
