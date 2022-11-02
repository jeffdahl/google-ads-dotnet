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
    public sealed class GeneratedConversionActionServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateConversionActionsRequestObject()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionActionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse
            {
                Results =
                {
                    new MutateConversionActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionActions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionActionsResponse response = client.MutateConversionActions(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateConversionActionsRequestObjectAsync()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionActionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse
            {
                Results =
                {
                    new MutateConversionActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionActionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionActionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionActionsResponse responseCallSettings = await client.MutateConversionActionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateConversionActionsResponse responseCancellationToken = await client.MutateConversionActionsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateConversionActions()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionActionOperation(),
                },
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse
            {
                Results =
                {
                    new MutateConversionActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionActions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionActionsResponse response = client.MutateConversionActions(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateConversionActionsAsync()
        {
            moq::Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new moq::Mock<ConversionActionService.ConversionActionServiceClient>(moq::MockBehavior.Strict);
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionActionOperation(),
                },
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse
            {
                Results =
                {
                    new MutateConversionActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionActionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionActionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionActionsResponse responseCallSettings = await client.MutateConversionActionsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateConversionActionsResponse responseCancellationToken = await client.MutateConversionActionsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
