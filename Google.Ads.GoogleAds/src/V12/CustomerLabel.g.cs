// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/resources/customer_label.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/resources/customer_label.proto</summary>
  public static partial class CustomerLabelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/resources/customer_label.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerLabelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvcmVzb3VyY2VzL2N1c3RvbWVy",
            "X2xhYmVsLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTIucmVzb3Vy",
            "Y2VzGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUv",
            "YXBpL3Jlc291cmNlLnByb3RvIssCCg1DdXN0b21lckxhYmVsEkUKDXJlc291",
            "cmNlX25hbWUYASABKAlCLuBBBfpBKAomZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0N1c3RvbWVyTGFiZWwSQAoIY3VzdG9tZXIYBCABKAlCKeBBA/pBIwoh",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1c3RvbWVySACIAQESOgoFbGFi",
            "ZWwYBSABKAlCJuBBA/pBIAoeZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0xh",
            "YmVsSAGIAQE6XupBWwomZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1c3Rv",
            "bWVyTGFiZWwSMWN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2N1c3RvbWVyTGFi",
            "ZWxzL3tsYWJlbF9pZH1CCwoJX2N1c3RvbWVyQggKBl9sYWJlbEKEAgomY29t",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMi5yZXNvdXJjZXNCEkN1c3RvbWVy",
            "TGFiZWxQcm90b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEyL3Jlc291cmNlcztyZXNvdXJjZXOi",
            "AgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFkcy5WMTIuUmVzb3VyY2VzygIi",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjEyXFJlc291cmNlc+oCJkdvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlYxMjo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Resources.CustomerLabel), global::Google.Ads.GoogleAds.V12.Resources.CustomerLabel.Parser, new[]{ "ResourceName", "Customer", "Label" }, new[]{ "Customer", "Label" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a relationship between a customer and a label. This customer may
  /// not have access to all the labels attached to it. Additional CustomerLabels
  /// may be returned by increasing permissions with login-customer-id.
  /// </summary>
  public sealed partial class CustomerLabel : pb::IMessage<CustomerLabel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerLabel> _parser = new pb::MessageParser<CustomerLabel>(() => new CustomerLabel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerLabel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Resources.CustomerLabelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerLabel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerLabel(CustomerLabel other) : this() {
      resourceName_ = other.resourceName_;
      customer_ = other.customer_;
      label_ = other.label_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerLabel Clone() {
      return new CustomerLabel(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// Customer label resource names have the form:
    /// `customers/{customer_id}/customerLabels/{label_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "customer" field.</summary>
    public const int CustomerFieldNumber = 4;
    private string customer_;
    /// <summary>
    /// Output only. The resource name of the customer to which the label is attached.
    /// Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Customer {
      get { return customer_ ?? ""; }
      set {
        customer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "customer" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCustomer {
      get { return customer_ != null; }
    }
    /// <summary>Clears the value of the "customer" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCustomer() {
      customer_ = null;
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 5;
    private string label_;
    /// <summary>
    /// Output only. The resource name of the label assigned to the customer.
    ///
    /// Note: the Customer ID portion of the label resource name is not
    /// validated when creating a new CustomerLabel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Label {
      get { return label_ ?? ""; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "label" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLabel {
      get { return label_ != null; }
    }
    /// <summary>Clears the value of the "label" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLabel() {
      label_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerLabel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerLabel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Customer != other.Customer) return false;
      if (Label != other.Label) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasCustomer) hash ^= Customer.GetHashCode();
      if (HasLabel) hash ^= Label.GetHashCode();
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
      if (HasCustomer) {
        output.WriteRawTag(34);
        output.WriteString(Customer);
      }
      if (HasLabel) {
        output.WriteRawTag(42);
        output.WriteString(Label);
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
      if (HasCustomer) {
        output.WriteRawTag(34);
        output.WriteString(Customer);
      }
      if (HasLabel) {
        output.WriteRawTag(42);
        output.WriteString(Label);
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
      if (HasCustomer) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Customer);
      }
      if (HasLabel) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerLabel other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasCustomer) {
        Customer = other.Customer;
      }
      if (other.HasLabel) {
        Label = other.Label;
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
            Customer = input.ReadString();
            break;
          }
          case 42: {
            Label = input.ReadString();
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
            Customer = input.ReadString();
            break;
          }
          case 42: {
            Label = input.ReadString();
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
