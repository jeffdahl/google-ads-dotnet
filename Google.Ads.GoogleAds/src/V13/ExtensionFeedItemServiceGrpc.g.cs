// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/services/extension_feed_item_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V13.Services {
  /// <summary>
  /// Service to manage extension feed items.
  /// </summary>
  public static partial class ExtensionFeedItemService
  {
    static readonly string __ServiceName = "google.ads.googleads.v13.services.ExtensionFeedItemService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsRequest> __Marshaller_google_ads_googleads_v13_services_MutateExtensionFeedItemsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsResponse> __Marshaller_google_ads_googleads_v13_services_MutateExtensionFeedItemsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsRequest, global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsResponse> __Method_MutateExtensionFeedItems = new grpc::Method<global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsRequest, global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateExtensionFeedItems",
        __Marshaller_google_ads_googleads_v13_services_MutateExtensionFeedItemsRequest,
        __Marshaller_google_ads_googleads_v13_services_MutateExtensionFeedItemsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V13.Services.ExtensionFeedItemServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ExtensionFeedItemService</summary>
    [grpc::BindServiceMethod(typeof(ExtensionFeedItemService), "BindService")]
    public abstract partial class ExtensionFeedItemServiceBase
    {
      /// <summary>
      /// Creates, updates, or removes extension feed items. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [CountryCodeError]()
      ///   [DatabaseError]()
      ///   [DateError]()
      ///   [DistinctError]()
      ///   [ExtensionFeedItemError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [ImageError]()
      ///   [InternalError]()
      ///   [LanguageCodeError]()
      ///   [MutateError]()
      ///   [NewResourceCreationError]()
      ///   [OperationAccessDeniedError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringLengthError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsResponse> MutateExtensionFeedItems(global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ExtensionFeedItemService</summary>
    public partial class ExtensionFeedItemServiceClient : grpc::ClientBase<ExtensionFeedItemServiceClient>
    {
      /// <summary>Creates a new client for ExtensionFeedItemService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ExtensionFeedItemServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ExtensionFeedItemService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ExtensionFeedItemServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ExtensionFeedItemServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ExtensionFeedItemServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates, updates, or removes extension feed items. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [CountryCodeError]()
      ///   [DatabaseError]()
      ///   [DateError]()
      ///   [DistinctError]()
      ///   [ExtensionFeedItemError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [ImageError]()
      ///   [InternalError]()
      ///   [LanguageCodeError]()
      ///   [MutateError]()
      ///   [NewResourceCreationError]()
      ///   [OperationAccessDeniedError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringLengthError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsResponse MutateExtensionFeedItems(global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateExtensionFeedItems(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes extension feed items. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [CountryCodeError]()
      ///   [DatabaseError]()
      ///   [DateError]()
      ///   [DistinctError]()
      ///   [ExtensionFeedItemError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [ImageError]()
      ///   [InternalError]()
      ///   [LanguageCodeError]()
      ///   [MutateError]()
      ///   [NewResourceCreationError]()
      ///   [OperationAccessDeniedError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringLengthError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsResponse MutateExtensionFeedItems(global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateExtensionFeedItems, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes extension feed items. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [CountryCodeError]()
      ///   [DatabaseError]()
      ///   [DateError]()
      ///   [DistinctError]()
      ///   [ExtensionFeedItemError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [ImageError]()
      ///   [InternalError]()
      ///   [LanguageCodeError]()
      ///   [MutateError]()
      ///   [NewResourceCreationError]()
      ///   [OperationAccessDeniedError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringLengthError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateExtensionFeedItemsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes extension feed items. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [CountryCodeError]()
      ///   [DatabaseError]()
      ///   [DateError]()
      ///   [DistinctError]()
      ///   [ExtensionFeedItemError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [ImageError]()
      ///   [InternalError]()
      ///   [LanguageCodeError]()
      ///   [MutateError]()
      ///   [NewResourceCreationError]()
      ///   [OperationAccessDeniedError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringLengthError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateExtensionFeedItems, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ExtensionFeedItemServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ExtensionFeedItemServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ExtensionFeedItemServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_MutateExtensionFeedItems, serviceImpl.MutateExtensionFeedItems).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ExtensionFeedItemServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_MutateExtensionFeedItems, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsRequest, global::Google.Ads.GoogleAds.V13.Services.MutateExtensionFeedItemsResponse>(serviceImpl.MutateExtensionFeedItems));
    }

  }
}
#endregion
