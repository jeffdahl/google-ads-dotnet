// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/resources/asset_group.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/resources/asset_group.proto</summary>
  public static partial class AssetGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/resources/asset_group.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvcmVzb3VyY2VzL2Fzc2V0X2dy",
            "b3VwLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTIucmVzb3VyY2Vz",
            "GjBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZW51bXMvYWRfc3RyZW5ndGgu",
            "cHJvdG8aN2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxMi9lbnVtcy9hc3NldF9n",
            "cm91cF9zdGF0dXMucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3Iu",
            "cHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8iigQKCkFzc2V0R3Jv",
            "dXASQgoNcmVzb3VyY2VfbmFtZRgBIAEoCUIr4EEF+kElCiNnb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vQXNzZXRHcm91cBIPCgJpZBgJIAEoA0ID4EEDEjsK",
            "CGNhbXBhaWduGAIgASgJQingQQX6QSMKIWdvb2dsZWFkcy5nb29nbGVhcGlz",
            "LmNvbS9DYW1wYWlnbhIRCgRuYW1lGAMgASgJQgPgQQISEgoKZmluYWxfdXJs",
            "cxgEIAMoCRIZChFmaW5hbF9tb2JpbGVfdXJscxgFIAMoCRJVCgZzdGF0dXMY",
            "BiABKA4yRS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTIuZW51bXMuQXNzZXRH",
            "cm91cFN0YXR1c0VudW0uQXNzZXRHcm91cFN0YXR1cxINCgVwYXRoMRgHIAEo",
            "CRINCgVwYXRoMhgIIAEoCRJTCgthZF9zdHJlbmd0aBgKIAEoDjI5Lmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYxMi5lbnVtcy5BZFN0cmVuZ3RoRW51bS5BZFN0",
            "cmVuZ3RoQgPgQQM6XupBWwojZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0Fz",
            "c2V0R3JvdXASNGN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2Fzc2V0R3JvdXBz",
            "L3thc3NldF9ncm91cF9pZH1CgQIKJmNvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTIucmVzb3VyY2VzQg9Bc3NldEdyb3VwUHJvdG9QAVpLZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yx",
            "Mi9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjEyLlJlc291cmNlc8oCIkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYx",
            "MlxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTI6OlJl",
            "c291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V12.Enums.AdStrengthReflection.Descriptor, global::Google.Ads.GoogleAds.V12.Enums.AssetGroupStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Resources.AssetGroup), global::Google.Ads.GoogleAds.V12.Resources.AssetGroup.Parser, new[]{ "ResourceName", "Id", "Campaign", "Name", "FinalUrls", "FinalMobileUrls", "Status", "Path1", "Path2", "AdStrength" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An asset group.
  /// AssetGroupAsset is used to link an asset to the asset group.
  /// AssetGroupSignal is used to associate a signal to an asset group.
  /// </summary>
  public sealed partial class AssetGroup : pb::IMessage<AssetGroup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetGroup> _parser = new pb::MessageParser<AssetGroup>(() => new AssetGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Resources.AssetGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroup(AssetGroup other) : this() {
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      campaign_ = other.campaign_;
      name_ = other.name_;
      finalUrls_ = other.finalUrls_.Clone();
      finalMobileUrls_ = other.finalMobileUrls_.Clone();
      status_ = other.status_;
      path1_ = other.path1_;
      path2_ = other.path2_;
      adStrength_ = other.adStrength_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroup Clone() {
      return new AssetGroup(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the asset group.
    /// Asset group resource names have the form:
    ///
    /// `customers/{customer_id}/assetGroups/{asset_group_id}`
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
    public const int IdFieldNumber = 9;
    private long id_;
    /// <summary>
    /// Output only. The ID of the asset group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 2;
    private string campaign_ = "";
    /// <summary>
    /// Immutable. The campaign with which this asset group is associated.
    /// The asset which is linked to the asset group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// Required. Name of the asset group. Required. It must have a minimum length of 1 and
    /// maximum length of 128. It must be unique under a campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "final_urls" field.</summary>
    public const int FinalUrlsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_finalUrls_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> finalUrls_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of final URLs after all cross domain redirects. In performance max,
    /// by default, the urls are eligible for expansion unless opted out.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> FinalUrls {
      get { return finalUrls_; }
    }

    /// <summary>Field number for the "final_mobile_urls" field.</summary>
    public const int FinalMobileUrlsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_finalMobileUrls_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> finalMobileUrls_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of final mobile URLs after all cross domain redirects. In
    /// performance max, by default, the urls are eligible for expansion
    /// unless opted out.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> FinalMobileUrls {
      get { return finalMobileUrls_; }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V12.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus status_ = global::Google.Ads.GoogleAds.V12.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified;
    /// <summary>
    /// The status of the asset group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "path1" field.</summary>
    public const int Path1FieldNumber = 7;
    private string path1_ = "";
    /// <summary>
    /// First part of text that may appear appended to the url displayed in
    /// the ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Path1 {
      get { return path1_; }
      set {
        path1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "path2" field.</summary>
    public const int Path2FieldNumber = 8;
    private string path2_ = "";
    /// <summary>
    /// Second part of text that may appear appended to the url displayed in
    /// the ad. This field can only be set when path1 is set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Path2 {
      get { return path2_; }
      set {
        path2_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_strength" field.</summary>
    public const int AdStrengthFieldNumber = 10;
    private global::Google.Ads.GoogleAds.V12.Enums.AdStrengthEnum.Types.AdStrength adStrength_ = global::Google.Ads.GoogleAds.V12.Enums.AdStrengthEnum.Types.AdStrength.Unspecified;
    /// <summary>
    /// Output only. Overall ad strength of this asset group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Enums.AdStrengthEnum.Types.AdStrength AdStrength {
      get { return adStrength_; }
      set {
        adStrength_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Campaign != other.Campaign) return false;
      if (Name != other.Name) return false;
      if(!finalUrls_.Equals(other.finalUrls_)) return false;
      if(!finalMobileUrls_.Equals(other.finalMobileUrls_)) return false;
      if (Status != other.Status) return false;
      if (Path1 != other.Path1) return false;
      if (Path2 != other.Path2) return false;
      if (AdStrength != other.AdStrength) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Campaign.Length != 0) hash ^= Campaign.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= finalUrls_.GetHashCode();
      hash ^= finalMobileUrls_.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified) hash ^= Status.GetHashCode();
      if (Path1.Length != 0) hash ^= Path1.GetHashCode();
      if (Path2.Length != 0) hash ^= Path2.GetHashCode();
      if (AdStrength != global::Google.Ads.GoogleAds.V12.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) hash ^= AdStrength.GetHashCode();
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
      if (Campaign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Campaign);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      finalUrls_.WriteTo(output, _repeated_finalUrls_codec);
      finalMobileUrls_.WriteTo(output, _repeated_finalMobileUrls_codec);
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (Path1.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Path1);
      }
      if (Path2.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Path2);
      }
      if (Id != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(Id);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V12.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        output.WriteRawTag(80);
        output.WriteEnum((int) AdStrength);
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
      if (Campaign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Campaign);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      finalUrls_.WriteTo(ref output, _repeated_finalUrls_codec);
      finalMobileUrls_.WriteTo(ref output, _repeated_finalMobileUrls_codec);
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (Path1.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Path1);
      }
      if (Path2.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Path2);
      }
      if (Id != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(Id);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V12.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        output.WriteRawTag(80);
        output.WriteEnum((int) AdStrength);
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
      if (Campaign.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += finalUrls_.CalculateSize(_repeated_finalUrls_codec);
      size += finalMobileUrls_.CalculateSize(_repeated_finalMobileUrls_codec);
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Path1.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path1);
      }
      if (Path2.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path2);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V12.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AdStrength);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetGroup other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Campaign.Length != 0) {
        Campaign = other.Campaign;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      finalUrls_.Add(other.finalUrls_);
      finalMobileUrls_.Add(other.finalMobileUrls_);
      if (other.Status != global::Google.Ads.GoogleAds.V12.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.Path1.Length != 0) {
        Path1 = other.Path1;
      }
      if (other.Path2.Length != 0) {
        Path2 = other.Path2;
      }
      if (other.AdStrength != global::Google.Ads.GoogleAds.V12.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        AdStrength = other.AdStrength;
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
            Campaign = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            finalUrls_.AddEntriesFrom(input, _repeated_finalUrls_codec);
            break;
          }
          case 42: {
            finalMobileUrls_.AddEntriesFrom(input, _repeated_finalMobileUrls_codec);
            break;
          }
          case 48: {
            Status = (global::Google.Ads.GoogleAds.V12.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus) input.ReadEnum();
            break;
          }
          case 58: {
            Path1 = input.ReadString();
            break;
          }
          case 66: {
            Path2 = input.ReadString();
            break;
          }
          case 72: {
            Id = input.ReadInt64();
            break;
          }
          case 80: {
            AdStrength = (global::Google.Ads.GoogleAds.V12.Enums.AdStrengthEnum.Types.AdStrength) input.ReadEnum();
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
            Campaign = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            finalUrls_.AddEntriesFrom(ref input, _repeated_finalUrls_codec);
            break;
          }
          case 42: {
            finalMobileUrls_.AddEntriesFrom(ref input, _repeated_finalMobileUrls_codec);
            break;
          }
          case 48: {
            Status = (global::Google.Ads.GoogleAds.V12.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus) input.ReadEnum();
            break;
          }
          case 58: {
            Path1 = input.ReadString();
            break;
          }
          case 66: {
            Path2 = input.ReadString();
            break;
          }
          case 72: {
            Id = input.ReadInt64();
            break;
          }
          case 80: {
            AdStrength = (global::Google.Ads.GoogleAds.V12.Enums.AdStrengthEnum.Types.AdStrength) input.ReadEnum();
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
