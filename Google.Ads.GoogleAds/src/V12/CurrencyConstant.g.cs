// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/resources/currency_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/resources/currency_constant.proto</summary>
  public static partial class CurrencyConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/resources/currency_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CurrencyConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvcmVzb3VyY2VzL2N1cnJlbmN5",
            "X2NvbnN0YW50LnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTIucmVz",
            "b3VyY2VzGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29n",
            "bGUvYXBpL3Jlc291cmNlLnByb3RvIs4CChBDdXJyZW5jeUNvbnN0YW50EkgK",
            "DXJlc291cmNlX25hbWUYASABKAlCMeBBA/pBKwopZ29vZ2xlYWRzLmdvb2ds",
            "ZWFwaXMuY29tL0N1cnJlbmN5Q29uc3RhbnQSFgoEY29kZRgGIAEoCUID4EED",
            "SACIAQESFgoEbmFtZRgHIAEoCUID4EEDSAGIAQESGAoGc3ltYm9sGAggASgJ",
            "QgPgQQNIAogBARImChRiaWxsYWJsZV91bml0X21pY3JvcxgJIAEoA0ID4EED",
            "SAOIAQE6SOpBRQopZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1cnJlbmN5",
            "Q29uc3RhbnQSGGN1cnJlbmN5Q29uc3RhbnRzL3tjb2RlfUIHCgVfY29kZUIH",
            "CgVfbmFtZUIJCgdfc3ltYm9sQhcKFV9iaWxsYWJsZV91bml0X21pY3Jvc0KH",
            "AgomY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMi5yZXNvdXJjZXNCFUN1",
            "cnJlbmN5Q29uc3RhbnRQcm90b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEyL3Jlc291cmNlczty",
            "ZXNvdXJjZXOiAgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFkcy5WMTIuUmVz",
            "b3VyY2VzygIiR29vZ2xlXEFkc1xHb29nbGVBZHNcVjEyXFJlc291cmNlc+oC",
            "Jkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMjo6UmVzb3VyY2VzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Resources.CurrencyConstant), global::Google.Ads.GoogleAds.V12.Resources.CurrencyConstant.Parser, new[]{ "ResourceName", "Code", "Name", "Symbol", "BillableUnitMicros" }, new[]{ "Code", "Name", "Symbol", "BillableUnitMicros" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A currency constant.
  /// </summary>
  public sealed partial class CurrencyConstant : pb::IMessage<CurrencyConstant>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CurrencyConstant> _parser = new pb::MessageParser<CurrencyConstant>(() => new CurrencyConstant());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CurrencyConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Resources.CurrencyConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CurrencyConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CurrencyConstant(CurrencyConstant other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      code_ = other.code_;
      name_ = other.name_;
      symbol_ = other.symbol_;
      billableUnitMicros_ = other.billableUnitMicros_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CurrencyConstant Clone() {
      return new CurrencyConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the currency constant.
    /// Currency constant resource names have the form:
    ///
    /// `currencyConstants/{code}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 6;
    private string code_;
    /// <summary>
    /// Output only. ISO 4217 three-letter currency code, for example, "USD"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Code {
      get { return code_ ?? ""; }
      set {
        code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "code" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCode {
      get { return code_ != null; }
    }
    /// <summary>Clears the value of the "code" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCode() {
      code_ = null;
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 7;
    private string name_;
    /// <summary>
    /// Output only. Full English name of the currency.
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

    /// <summary>Field number for the "symbol" field.</summary>
    public const int SymbolFieldNumber = 8;
    private string symbol_;
    /// <summary>
    /// Output only. Standard symbol for describing this currency, for example, '$' for US
    /// Dollars.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Symbol {
      get { return symbol_ ?? ""; }
      set {
        symbol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "symbol" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSymbol {
      get { return symbol_ != null; }
    }
    /// <summary>Clears the value of the "symbol" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSymbol() {
      symbol_ = null;
    }

    /// <summary>Field number for the "billable_unit_micros" field.</summary>
    public const int BillableUnitMicrosFieldNumber = 9;
    private long billableUnitMicros_;
    /// <summary>
    /// Output only. The billable unit for this currency. Billed amounts should be multiples of
    /// this value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long BillableUnitMicros {
      get { if ((_hasBits0 & 1) != 0) { return billableUnitMicros_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        billableUnitMicros_ = value;
      }
    }
    /// <summary>Gets whether the "billable_unit_micros" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasBillableUnitMicros {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "billable_unit_micros" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBillableUnitMicros() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CurrencyConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CurrencyConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Code != other.Code) return false;
      if (Name != other.Name) return false;
      if (Symbol != other.Symbol) return false;
      if (BillableUnitMicros != other.BillableUnitMicros) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasCode) hash ^= Code.GetHashCode();
      if (HasName) hash ^= Name.GetHashCode();
      if (HasSymbol) hash ^= Symbol.GetHashCode();
      if (HasBillableUnitMicros) hash ^= BillableUnitMicros.GetHashCode();
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
      if (HasCode) {
        output.WriteRawTag(50);
        output.WriteString(Code);
      }
      if (HasName) {
        output.WriteRawTag(58);
        output.WriteString(Name);
      }
      if (HasSymbol) {
        output.WriteRawTag(66);
        output.WriteString(Symbol);
      }
      if (HasBillableUnitMicros) {
        output.WriteRawTag(72);
        output.WriteInt64(BillableUnitMicros);
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
      if (HasCode) {
        output.WriteRawTag(50);
        output.WriteString(Code);
      }
      if (HasName) {
        output.WriteRawTag(58);
        output.WriteString(Name);
      }
      if (HasSymbol) {
        output.WriteRawTag(66);
        output.WriteString(Symbol);
      }
      if (HasBillableUnitMicros) {
        output.WriteRawTag(72);
        output.WriteInt64(BillableUnitMicros);
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
      if (HasCode) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
      }
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (HasSymbol) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Symbol);
      }
      if (HasBillableUnitMicros) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BillableUnitMicros);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CurrencyConstant other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasCode) {
        Code = other.Code;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      if (other.HasSymbol) {
        Symbol = other.Symbol;
      }
      if (other.HasBillableUnitMicros) {
        BillableUnitMicros = other.BillableUnitMicros;
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
          case 50: {
            Code = input.ReadString();
            break;
          }
          case 58: {
            Name = input.ReadString();
            break;
          }
          case 66: {
            Symbol = input.ReadString();
            break;
          }
          case 72: {
            BillableUnitMicros = input.ReadInt64();
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
          case 50: {
            Code = input.ReadString();
            break;
          }
          case 58: {
            Name = input.ReadString();
            break;
          }
          case 66: {
            Symbol = input.ReadString();
            break;
          }
          case 72: {
            BillableUnitMicros = input.ReadInt64();
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
