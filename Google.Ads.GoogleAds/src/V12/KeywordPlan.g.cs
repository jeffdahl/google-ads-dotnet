// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/resources/keyword_plan.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/resources/keyword_plan.proto</summary>
  public static partial class KeywordPlanReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/resources/keyword_plan.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvcmVzb3VyY2VzL2tleXdvcmRf",
            "cGxhbi5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEyLnJlc291cmNl",
            "cxorZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEyL2NvbW1vbi9kYXRlcy5wcm90",
            "bxpDZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEyL2VudW1zL2tleXdvcmRfcGxh",
            "bl9mb3JlY2FzdF9pbnRlcnZhbC5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9i",
            "ZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byLGAgoL",
            "S2V5d29yZFBsYW4SQwoNcmVzb3VyY2VfbmFtZRgBIAEoCUIs4EEF+kEmCiRn",
            "b29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vS2V5d29yZFBsYW4SFAoCaWQYBSAB",
            "KANCA+BBA0gAiAEBEhEKBG5hbWUYBiABKAlIAYgBARJWCg9mb3JlY2FzdF9w",
            "ZXJpb2QYBCABKAsyPS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTIucmVzb3Vy",
            "Y2VzLktleXdvcmRQbGFuRm9yZWNhc3RQZXJpb2Q6YepBXgokZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tL0tleXdvcmRQbGFuEjZjdXN0b21lcnMve2N1c3Rv",
            "bWVyX2lkfS9rZXl3b3JkUGxhbnMve2tleXdvcmRfcGxhbl9pZH1CBQoDX2lk",
            "QgcKBV9uYW1lIt8BChlLZXl3b3JkUGxhbkZvcmVjYXN0UGVyaW9kEnQKDWRh",
            "dGVfaW50ZXJ2YWwYASABKA4yWy5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTIu",
            "ZW51bXMuS2V5d29yZFBsYW5Gb3JlY2FzdEludGVydmFsRW51bS5LZXl3b3Jk",
            "UGxhbkZvcmVjYXN0SW50ZXJ2YWxIABJACgpkYXRlX3JhbmdlGAIgASgLMiou",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjEyLmNvbW1vbi5EYXRlUmFuZ2VIAEIK",
            "CghpbnRlcnZhbEKCAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMi5y",
            "ZXNvdXJjZXNCEEtleXdvcmRQbGFuUHJvdG9QAVpLZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxMi9yZXNv",
            "dXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjEyLlJlc291cmNlc8oCIkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxMlxSZXNv",
            "dXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTI6OlJlc291cmNl",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V12.Common.DatesReflection.Descriptor, global::Google.Ads.GoogleAds.V12.Enums.KeywordPlanForecastIntervalReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Resources.KeywordPlan), global::Google.Ads.GoogleAds.V12.Resources.KeywordPlan.Parser, new[]{ "ResourceName", "Id", "Name", "ForecastPeriod" }, new[]{ "Id", "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Resources.KeywordPlanForecastPeriod), global::Google.Ads.GoogleAds.V12.Resources.KeywordPlanForecastPeriod.Parser, new[]{ "DateInterval", "DateRange" }, new[]{ "Interval" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Keyword Planner plan.
  /// Max number of saved keyword plans: 10000.
  /// It's possible to remove plans if limit is reached.
  /// </summary>
  public sealed partial class KeywordPlan : pb::IMessage<KeywordPlan>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KeywordPlan> _parser = new pb::MessageParser<KeywordPlan>(() => new KeywordPlan());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KeywordPlan> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Resources.KeywordPlanReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlan() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlan(KeywordPlan other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      name_ = other.name_;
      forecastPeriod_ = other.forecastPeriod_ != null ? other.forecastPeriod_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlan Clone() {
      return new KeywordPlan(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the Keyword Planner plan.
    /// KeywordPlan resource names have the form:
    ///
    /// `customers/{customer_id}/keywordPlans/{kp_plan_id}`
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
    public const int IdFieldNumber = 5;
    private long id_;
    /// <summary>
    /// Output only. The ID of the keyword plan.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 6;
    private string name_;
    /// <summary>
    /// The name of the keyword plan.
    ///
    /// This field is required and should not be empty when creating new keyword
    /// plans.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_ ?? ""; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "forecast_period" field.</summary>
    public const int ForecastPeriodFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V12.Resources.KeywordPlanForecastPeriod forecastPeriod_;
    /// <summary>
    /// The date period used for forecasting the plan.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Resources.KeywordPlanForecastPeriod ForecastPeriod {
      get { return forecastPeriod_; }
      set {
        forecastPeriod_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlan);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KeywordPlan other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(ForecastPeriod, other.ForecastPeriod)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasName) hash ^= Name.GetHashCode();
      if (forecastPeriod_ != null) hash ^= ForecastPeriod.GetHashCode();
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
      if (forecastPeriod_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ForecastPeriod);
      }
      if (HasId) {
        output.WriteRawTag(40);
        output.WriteInt64(Id);
      }
      if (HasName) {
        output.WriteRawTag(50);
        output.WriteString(Name);
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
      if (forecastPeriod_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ForecastPeriod);
      }
      if (HasId) {
        output.WriteRawTag(40);
        output.WriteInt64(Id);
      }
      if (HasName) {
        output.WriteRawTag(50);
        output.WriteString(Name);
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
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (forecastPeriod_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ForecastPeriod);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KeywordPlan other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      if (other.forecastPeriod_ != null) {
        if (forecastPeriod_ == null) {
          ForecastPeriod = new global::Google.Ads.GoogleAds.V12.Resources.KeywordPlanForecastPeriod();
        }
        ForecastPeriod.MergeFrom(other.ForecastPeriod);
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
          case 34: {
            if (forecastPeriod_ == null) {
              ForecastPeriod = new global::Google.Ads.GoogleAds.V12.Resources.KeywordPlanForecastPeriod();
            }
            input.ReadMessage(ForecastPeriod);
            break;
          }
          case 40: {
            Id = input.ReadInt64();
            break;
          }
          case 50: {
            Name = input.ReadString();
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
          case 34: {
            if (forecastPeriod_ == null) {
              ForecastPeriod = new global::Google.Ads.GoogleAds.V12.Resources.KeywordPlanForecastPeriod();
            }
            input.ReadMessage(ForecastPeriod);
            break;
          }
          case 40: {
            Id = input.ReadInt64();
            break;
          }
          case 50: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The forecasting period associated with the keyword plan.
  /// </summary>
  public sealed partial class KeywordPlanForecastPeriod : pb::IMessage<KeywordPlanForecastPeriod>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KeywordPlanForecastPeriod> _parser = new pb::MessageParser<KeywordPlanForecastPeriod>(() => new KeywordPlanForecastPeriod());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KeywordPlanForecastPeriod> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Resources.KeywordPlanReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanForecastPeriod() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanForecastPeriod(KeywordPlanForecastPeriod other) : this() {
      switch (other.IntervalCase) {
        case IntervalOneofCase.DateInterval:
          DateInterval = other.DateInterval;
          break;
        case IntervalOneofCase.DateRange:
          DateRange = other.DateRange.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanForecastPeriod Clone() {
      return new KeywordPlanForecastPeriod(this);
    }

    /// <summary>Field number for the "date_interval" field.</summary>
    public const int DateIntervalFieldNumber = 1;
    /// <summary>
    /// A future date range relative to the current date used for forecasting.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Enums.KeywordPlanForecastIntervalEnum.Types.KeywordPlanForecastInterval DateInterval {
      get { return intervalCase_ == IntervalOneofCase.DateInterval ? (global::Google.Ads.GoogleAds.V12.Enums.KeywordPlanForecastIntervalEnum.Types.KeywordPlanForecastInterval) interval_ : global::Google.Ads.GoogleAds.V12.Enums.KeywordPlanForecastIntervalEnum.Types.KeywordPlanForecastInterval.Unspecified; }
      set {
        interval_ = value;
        intervalCase_ = IntervalOneofCase.DateInterval;
      }
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 2;
    /// <summary>
    /// The custom date range used for forecasting. It cannot be greater than
    /// a year.
    /// The start and end dates must be in the future. Otherwise, an error will
    /// be returned when the forecasting action is performed.
    /// The start and end dates are inclusive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Common.DateRange DateRange {
      get { return intervalCase_ == IntervalOneofCase.DateRange ? (global::Google.Ads.GoogleAds.V12.Common.DateRange) interval_ : null; }
      set {
        interval_ = value;
        intervalCase_ = value == null ? IntervalOneofCase.None : IntervalOneofCase.DateRange;
      }
    }

    private object interval_;
    /// <summary>Enum of possible cases for the "interval" oneof.</summary>
    public enum IntervalOneofCase {
      None = 0,
      DateInterval = 1,
      DateRange = 2,
    }
    private IntervalOneofCase intervalCase_ = IntervalOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IntervalOneofCase IntervalCase {
      get { return intervalCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearInterval() {
      intervalCase_ = IntervalOneofCase.None;
      interval_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanForecastPeriod);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KeywordPlanForecastPeriod other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DateInterval != other.DateInterval) return false;
      if (!object.Equals(DateRange, other.DateRange)) return false;
      if (IntervalCase != other.IntervalCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (intervalCase_ == IntervalOneofCase.DateInterval) hash ^= DateInterval.GetHashCode();
      if (intervalCase_ == IntervalOneofCase.DateRange) hash ^= DateRange.GetHashCode();
      hash ^= (int) intervalCase_;
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
      if (intervalCase_ == IntervalOneofCase.DateInterval) {
        output.WriteRawTag(8);
        output.WriteEnum((int) DateInterval);
      }
      if (intervalCase_ == IntervalOneofCase.DateRange) {
        output.WriteRawTag(18);
        output.WriteMessage(DateRange);
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
      if (intervalCase_ == IntervalOneofCase.DateInterval) {
        output.WriteRawTag(8);
        output.WriteEnum((int) DateInterval);
      }
      if (intervalCase_ == IntervalOneofCase.DateRange) {
        output.WriteRawTag(18);
        output.WriteMessage(DateRange);
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
      if (intervalCase_ == IntervalOneofCase.DateInterval) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DateInterval);
      }
      if (intervalCase_ == IntervalOneofCase.DateRange) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KeywordPlanForecastPeriod other) {
      if (other == null) {
        return;
      }
      switch (other.IntervalCase) {
        case IntervalOneofCase.DateInterval:
          DateInterval = other.DateInterval;
          break;
        case IntervalOneofCase.DateRange:
          if (DateRange == null) {
            DateRange = new global::Google.Ads.GoogleAds.V12.Common.DateRange();
          }
          DateRange.MergeFrom(other.DateRange);
          break;
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
          case 8: {
            interval_ = input.ReadEnum();
            intervalCase_ = IntervalOneofCase.DateInterval;
            break;
          }
          case 18: {
            global::Google.Ads.GoogleAds.V12.Common.DateRange subBuilder = new global::Google.Ads.GoogleAds.V12.Common.DateRange();
            if (intervalCase_ == IntervalOneofCase.DateRange) {
              subBuilder.MergeFrom(DateRange);
            }
            input.ReadMessage(subBuilder);
            DateRange = subBuilder;
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
          case 8: {
            interval_ = input.ReadEnum();
            intervalCase_ = IntervalOneofCase.DateInterval;
            break;
          }
          case 18: {
            global::Google.Ads.GoogleAds.V12.Common.DateRange subBuilder = new global::Google.Ads.GoogleAds.V12.Common.DateRange();
            if (intervalCase_ == IntervalOneofCase.DateRange) {
              subBuilder.MergeFrom(DateRange);
            }
            input.ReadMessage(subBuilder);
            DateRange = subBuilder;
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
