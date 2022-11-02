// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/enums/conversion_action_category.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/enums/conversion_action_category.proto</summary>
  public static partial class ConversionActionCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/enums/conversion_action_category.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionActionCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZW51bXMvY29udmVyc2lvbl9h",
            "Y3Rpb25fY2F0ZWdvcnkucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "Mi5lbnVtcyLLAwocQ29udmVyc2lvbkFjdGlvbkNhdGVnb3J5RW51bSKqAwoY",
            "Q29udmVyc2lvbkFjdGlvbkNhdGVnb3J5Eg8KC1VOU1BFQ0lGSUVEEAASCwoH",
            "VU5LTk9XThABEgsKB0RFRkFVTFQQAhINCglQQUdFX1ZJRVcQAxIMCghQVVJD",
            "SEFTRRAEEgoKBlNJR05VUBAFEgwKCERPV05MT0FEEAcSDwoLQUREX1RPX0NB",
            "UlQQCBISCg5CRUdJTl9DSEVDS09VVBAJEhIKDlNVQlNDUklCRV9QQUlEEAoS",
            "EwoPUEhPTkVfQ0FMTF9MRUFEEAsSEQoNSU1QT1JURURfTEVBRBAMEhQKEFNV",
            "Qk1JVF9MRUFEX0ZPUk0QDRIUChBCT09LX0FQUE9JTlRNRU5UEA4SEQoNUkVR",
            "VUVTVF9RVU9URRAPEhIKDkdFVF9ESVJFQ1RJT05TEBASEgoOT1VUQk9VTkRf",
            "Q0xJQ0sQERILCgdDT05UQUNUEBISDgoKRU5HQUdFTUVOVBATEg8KC1NUT1JF",
            "X1ZJU0lUEBQSDgoKU1RPUkVfU0FMRRAVEhIKDlFVQUxJRklFRF9MRUFEEBYS",
            "EgoOQ09OVkVSVEVEX0xFQUQQF0L3AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxMi5lbnVtc0IdQ29udmVyc2lvbkFjdGlvbkNhdGVnb3J5UHJvdG9Q",
            "AVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YxMi9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlYxMi5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYx",
            "MlxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMjo6RW51bXNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Enums.ConversionActionCategoryEnum), global::Google.Ads.GoogleAds.V12.Enums.ConversionActionCategoryEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the category of conversions that are associated
  /// with a ConversionAction.
  /// </summary>
  public sealed partial class ConversionActionCategoryEnum : pb::IMessage<ConversionActionCategoryEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionActionCategoryEnum> _parser = new pb::MessageParser<ConversionActionCategoryEnum>(() => new ConversionActionCategoryEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionActionCategoryEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Enums.ConversionActionCategoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionActionCategoryEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionActionCategoryEnum(ConversionActionCategoryEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionActionCategoryEnum Clone() {
      return new ConversionActionCategoryEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionActionCategoryEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionActionCategoryEnum other) {
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
    public void MergeFrom(ConversionActionCategoryEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionActionCategoryEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The category of conversions that are associated with a ConversionAction.
      /// </summary>
      public enum ConversionActionCategory {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Default category.
        /// </summary>
        [pbr::OriginalName("DEFAULT")] Default = 2,
        /// <summary>
        /// User visiting a page.
        /// </summary>
        [pbr::OriginalName("PAGE_VIEW")] PageView = 3,
        /// <summary>
        /// Purchase, sales, or "order placed" event.
        /// </summary>
        [pbr::OriginalName("PURCHASE")] Purchase = 4,
        /// <summary>
        /// Signup user action.
        /// </summary>
        [pbr::OriginalName("SIGNUP")] Signup = 5,
        /// <summary>
        /// Software download action (as for an app).
        /// </summary>
        [pbr::OriginalName("DOWNLOAD")] Download = 7,
        /// <summary>
        /// The addition of items to a shopping cart or bag on an advertiser site.
        /// </summary>
        [pbr::OriginalName("ADD_TO_CART")] AddToCart = 8,
        /// <summary>
        /// When someone enters the checkout flow on an advertiser site.
        /// </summary>
        [pbr::OriginalName("BEGIN_CHECKOUT")] BeginCheckout = 9,
        /// <summary>
        /// The start of a paid subscription for a product or service.
        /// </summary>
        [pbr::OriginalName("SUBSCRIBE_PAID")] SubscribePaid = 10,
        /// <summary>
        /// A call to indicate interest in an advertiser's offering.
        /// </summary>
        [pbr::OriginalName("PHONE_CALL_LEAD")] PhoneCallLead = 11,
        /// <summary>
        /// A lead conversion imported from an external source into Google Ads.
        /// </summary>
        [pbr::OriginalName("IMPORTED_LEAD")] ImportedLead = 12,
        /// <summary>
        /// A submission of a form on an advertiser site indicating business
        /// interest.
        /// </summary>
        [pbr::OriginalName("SUBMIT_LEAD_FORM")] SubmitLeadForm = 13,
        /// <summary>
        /// A booking of an appointment with an advertiser's business.
        /// </summary>
        [pbr::OriginalName("BOOK_APPOINTMENT")] BookAppointment = 14,
        /// <summary>
        /// A quote or price estimate request.
        /// </summary>
        [pbr::OriginalName("REQUEST_QUOTE")] RequestQuote = 15,
        /// <summary>
        /// A search for an advertiser's business location with intention to visit.
        /// </summary>
        [pbr::OriginalName("GET_DIRECTIONS")] GetDirections = 16,
        /// <summary>
        /// A click to an advertiser's partner's site.
        /// </summary>
        [pbr::OriginalName("OUTBOUND_CLICK")] OutboundClick = 17,
        /// <summary>
        /// A call, SMS, email, chat or other type of contact to an advertiser.
        /// </summary>
        [pbr::OriginalName("CONTACT")] Contact = 18,
        /// <summary>
        /// A website engagement event such as long site time or a Google Analytics
        /// (GA) Smart Goal. Intended to be used for GA, Firebase, GA Gold goal
        /// imports.
        /// </summary>
        [pbr::OriginalName("ENGAGEMENT")] Engagement = 19,
        /// <summary>
        /// A visit to a physical store location.
        /// </summary>
        [pbr::OriginalName("STORE_VISIT")] StoreVisit = 20,
        /// <summary>
        /// A sale occurring in a physical store.
        /// </summary>
        [pbr::OriginalName("STORE_SALE")] StoreSale = 21,
        /// <summary>
        /// A lead conversion imported from an external source into Google Ads,
        /// that has been further qualified by the advertiser (marketing/sales team).
        /// In the lead-to-sale journey, advertisers get leads, then act on them
        /// by reaching out to the consumer. If the consumer is interested and
        /// may end up buying their product, the advertiser marks such leads as
        /// "qualified leads".
        /// </summary>
        [pbr::OriginalName("QUALIFIED_LEAD")] QualifiedLead = 22,
        /// <summary>
        /// A lead conversion imported from an external source into Google Ads, that
        /// has further completed a chosen stage as defined by the lead gen
        /// advertiser.
        /// </summary>
        [pbr::OriginalName("CONVERTED_LEAD")] ConvertedLead = 23,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
