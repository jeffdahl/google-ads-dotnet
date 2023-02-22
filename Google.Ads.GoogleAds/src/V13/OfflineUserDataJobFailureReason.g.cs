// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/enums/offline_user_data_job_failure_reason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/enums/offline_user_data_job_failure_reason.proto</summary>
  public static partial class OfflineUserDataJobFailureReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/enums/offline_user_data_job_failure_reason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OfflineUserDataJobFailureReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZW51bXMvb2ZmbGluZV91c2Vy",
            "X2RhdGFfam9iX2ZhaWx1cmVfcmVhc29uLnByb3RvEh5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTMuZW51bXMilgIKI09mZmxpbmVVc2VyRGF0YUpvYkZhaWx1",
            "cmVSZWFzb25FbnVtIu4BCh9PZmZsaW5lVXNlckRhdGFKb2JGYWlsdXJlUmVh",
            "c29uEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEiUKIUlOU1VGRklD",
            "SUVOVF9NQVRDSEVEX1RSQU5TQUNUSU9OUxACEh0KGUlOU1VGRklDSUVOVF9U",
            "UkFOU0FDVElPTlMQAxIiCh5ISUdIX0FWRVJBR0VfVFJBTlNBQ1RJT05fVkFM",
            "VUUQBBIhCh1MT1dfQVZFUkFHRV9UUkFOU0FDVElPTl9WQUxVRRAFEiAKHE5F",
            "V0xZX09CU0VSVkVEX0NVUlJFTkNZX0NPREUQBkL+AQoiY29tLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYxMy5lbnVtc0IkT2ZmbGluZVVzZXJEYXRhSm9iRmFp",
            "bHVyZVJlYXNvblByb3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTMvZW51bXM7ZW51bXOiAgNH",
            "QUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTMuRW51bXPKAh5Hb29nbGVc",
            "QWRzXEdvb2dsZUFkc1xWMTNcRW51bXPqAiJHb29nbGU6OkFkczo6R29vZ2xl",
            "QWRzOjpWMTM6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Enums.OfflineUserDataJobFailureReasonEnum), global::Google.Ads.GoogleAds.V13.Enums.OfflineUserDataJobFailureReasonEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing reasons why an offline user data job
  /// failed to be processed.
  /// </summary>
  public sealed partial class OfflineUserDataJobFailureReasonEnum : pb::IMessage<OfflineUserDataJobFailureReasonEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OfflineUserDataJobFailureReasonEnum> _parser = new pb::MessageParser<OfflineUserDataJobFailureReasonEnum>(() => new OfflineUserDataJobFailureReasonEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OfflineUserDataJobFailureReasonEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Enums.OfflineUserDataJobFailureReasonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobFailureReasonEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobFailureReasonEnum(OfflineUserDataJobFailureReasonEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobFailureReasonEnum Clone() {
      return new OfflineUserDataJobFailureReasonEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OfflineUserDataJobFailureReasonEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OfflineUserDataJobFailureReasonEnum other) {
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
    public void MergeFrom(OfflineUserDataJobFailureReasonEnum other) {
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
    /// <summary>Container for nested types declared in the OfflineUserDataJobFailureReasonEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The failure reason of an offline user data job.
      /// </summary>
      public enum OfflineUserDataJobFailureReason {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The matched transactions are insufficient.
        /// </summary>
        [pbr::OriginalName("INSUFFICIENT_MATCHED_TRANSACTIONS")] InsufficientMatchedTransactions = 2,
        /// <summary>
        /// The uploaded transactions are insufficient.
        /// </summary>
        [pbr::OriginalName("INSUFFICIENT_TRANSACTIONS")] InsufficientTransactions = 3,
        /// <summary>
        /// The average transaction value is unusually high for your account. If this
        ///  is intended, contact support to request an exception. Learn more at
        ///  https://support.google.com/google-ads/answer/10018944#transaction_value
        /// </summary>
        [pbr::OriginalName("HIGH_AVERAGE_TRANSACTION_VALUE")] HighAverageTransactionValue = 4,
        /// <summary>
        /// The average transaction value is unusually low for your account. If this
        /// is intended, contact support to request an exception. Learn more at
        /// https://support.google.com/google-ads/answer/10018944#transaction_value
        /// </summary>
        [pbr::OriginalName("LOW_AVERAGE_TRANSACTION_VALUE")] LowAverageTransactionValue = 5,
        /// <summary>
        /// There's a currency code that you haven't used before in your uploads. If
        /// this is intended, contact support to request an exception. Learn more at
        /// https://support.google.com/google-ads/answer/10018944#Unrecognized_currency
        /// </summary>
        [pbr::OriginalName("NEWLY_OBSERVED_CURRENCY_CODE")] NewlyObservedCurrencyCode = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
