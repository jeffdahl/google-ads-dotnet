// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gagve = Google.Ads.GoogleAds.V12.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V12.Services;

namespace Google.Ads.GoogleAds.Tests.V12.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedExtensionFeedItemServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateExtensionFeedItemsRequestObject()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExtensionFeedItemOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse
            {
                Results =
                {
                    new MutateExtensionFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItems(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateExtensionFeedItemsResponse response = client.MutateExtensionFeedItems(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateExtensionFeedItemsRequestObjectAsync()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExtensionFeedItemOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse
            {
                Results =
                {
                    new MutateExtensionFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItemsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateExtensionFeedItemsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateExtensionFeedItemsResponse responseCallSettings = await client.MutateExtensionFeedItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateExtensionFeedItemsResponse responseCancellationToken = await client.MutateExtensionFeedItemsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateExtensionFeedItems()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExtensionFeedItemOperation(),
                },
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse
            {
                Results =
                {
                    new MutateExtensionFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItems(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateExtensionFeedItemsResponse response = client.MutateExtensionFeedItems(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateExtensionFeedItemsAsync()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExtensionFeedItemOperation(),
                },
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse
            {
                Results =
                {
                    new MutateExtensionFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItemsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateExtensionFeedItemsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateExtensionFeedItemsResponse responseCallSettings = await client.MutateExtensionFeedItemsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateExtensionFeedItemsResponse responseCancellationToken = await client.MutateExtensionFeedItemsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
