// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/resources/customizer_attribute.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/resources/customizer_attribute.proto</summary>
  public static partial class CustomizerAttributeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/resources/customizer_attribute.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomizerAttributeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvcmVzb3VyY2VzL2N1c3RvbWl6",
            "ZXJfYXR0cmlidXRlLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTIu",
            "cmVzb3VyY2VzGkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZW51bXMvY3Vz",
            "dG9taXplcl9hdHRyaWJ1dGVfc3RhdHVzLnByb3RvGj5nb29nbGUvYWRzL2dv",
            "b2dsZWFkcy92MTIvZW51bXMvY3VzdG9taXplcl9hdHRyaWJ1dGVfdHlwZS5w",
            "cm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xl",
            "L2FwaS9yZXNvdXJjZS5wcm90byLaAwoTQ3VzdG9taXplckF0dHJpYnV0ZRJL",
            "Cg1yZXNvdXJjZV9uYW1lGAEgASgJQjTgQQX6QS4KLGdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9DdXN0b21pemVyQXR0cmlidXRlEg8KAmlkGAIgASgDQgPg",
            "QQMSFAoEbmFtZRgDIAEoCUIG4EEC4EEFEmYKBHR5cGUYBCABKA4yUy5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MTIuZW51bXMuQ3VzdG9taXplckF0dHJpYnV0",
            "ZVR5cGVFbnVtLkN1c3RvbWl6ZXJBdHRyaWJ1dGVUeXBlQgPgQQUSbAoGc3Rh",
            "dHVzGAUgASgOMlcuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEyLmVudW1zLkN1",
            "c3RvbWl6ZXJBdHRyaWJ1dGVTdGF0dXNFbnVtLkN1c3RvbWl6ZXJBdHRyaWJ1",
            "dGVTdGF0dXNCA+BBAzp56kF2Cixnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20v",
            "Q3VzdG9taXplckF0dHJpYnV0ZRJGY3VzdG9tZXJzL3tjdXN0b21lcl9pZH0v",
            "Y3VzdG9taXplckF0dHJpYnV0ZXMve2N1c3RvbWl6ZXJfYXR0cmlidXRlX2lk",
            "fUKKAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMi5yZXNvdXJjZXNC",
            "GEN1c3RvbWl6ZXJBdHRyaWJ1dGVQcm90b1ABWktnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEyL3Jlc291",
            "cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "MTIuUmVzb3VyY2VzygIiR29vZ2xlXEFkc1xHb29nbGVBZHNcVjEyXFJlc291",
            "cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMjo6UmVzb3VyY2Vz",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Resources.CustomizerAttribute), global::Google.Ads.GoogleAds.V12.Resources.CustomizerAttribute.Parser, new[]{ "ResourceName", "Id", "Name", "Type", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A customizer attribute.
  /// Use CustomerCustomizer, CampaignCustomizer, AdGroupCustomizer, or
  /// AdGroupCriterionCustomizer to associate a customizer attribute and
  /// set its value at the customer, campaign, ad group, or ad group criterion
  /// level, respectively.
  /// </summary>
  public sealed partial class CustomizerAttribute : pb::IMessage<CustomizerAttribute>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomizerAttribute> _parser = new pb::MessageParser<CustomizerAttribute>(() => new CustomizerAttribute());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomizerAttribute> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Resources.CustomizerAttributeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomizerAttribute() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomizerAttribute(CustomizerAttribute other) : this() {
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      name_ = other.name_;
      type_ = other.type_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomizerAttribute Clone() {
      return new CustomizerAttribute(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the customizer attribute.
    /// Customizer Attribute resource names have the form:
    ///
    /// `customers/{customer_id}/customizerAttributes/{customizer_attribute_id}`
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
    /// Output only. The ID of the customizer attribute.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// Required. Immutable. Name of the customizer attribute. Required. It must have a minimum length
    /// of 1 and maximum length of 40. Name of an enabled customizer attribute must
    /// be unique (case insensitive).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType type_ = global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified;
    /// <summary>
    /// Immutable. The type of the customizer attribute.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeStatusEnum.Types.CustomizerAttributeStatus status_ = global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeStatusEnum.Types.CustomizerAttributeStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the customizer attribute.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeStatusEnum.Types.CustomizerAttributeStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomizerAttribute);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomizerAttribute other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified) hash ^= Type.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeStatusEnum.Types.CustomizerAttributeStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Type != global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeStatusEnum.Types.CustomizerAttributeStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
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
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Type != global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeStatusEnum.Types.CustomizerAttributeStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Type != global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeStatusEnum.Types.CustomizerAttributeStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomizerAttribute other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType.Unspecified) {
        Type = other.Type;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeStatusEnum.Types.CustomizerAttributeStatus.Unspecified) {
        Status = other.Status;
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
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 32: {
            Type = (global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeStatusEnum.Types.CustomizerAttributeStatus) input.ReadEnum();
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
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 32: {
            Type = (global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeTypeEnum.Types.CustomizerAttributeType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V12.Enums.CustomizerAttributeStatusEnum.Types.CustomizerAttributeStatus) input.ReadEnum();
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
