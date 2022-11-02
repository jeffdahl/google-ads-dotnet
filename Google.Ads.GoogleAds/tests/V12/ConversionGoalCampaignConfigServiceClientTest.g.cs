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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V12.Services;

namespace Google.Ads.GoogleAds.Tests.V12.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedConversionGoalCampaignConfigServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateConversionGoalCampaignConfigsRequestObject()
        {
            moq::Mock<ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient> mockGrpcClient = new moq::Mock<ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient>(moq::MockBehavior.Strict);
            MutateConversionGoalCampaignConfigsRequest request = new MutateConversionGoalCampaignConfigsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionGoalCampaignConfigOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateConversionGoalCampaignConfigsResponse expectedResponse = new MutateConversionGoalCampaignConfigsResponse
            {
                Results =
                {
                    new MutateConversionGoalCampaignConfigResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateConversionGoalCampaignConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionGoalCampaignConfigServiceClient client = new ConversionGoalCampaignConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionGoalCampaignConfigsResponse response = client.MutateConversionGoalCampaignConfigs(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateConversionGoalCampaignConfigsRequestObjectAsync()
        {
            moq::Mock<ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient> mockGrpcClient = new moq::Mock<ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient>(moq::MockBehavior.Strict);
            MutateConversionGoalCampaignConfigsRequest request = new MutateConversionGoalCampaignConfigsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionGoalCampaignConfigOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateConversionGoalCampaignConfigsResponse expectedResponse = new MutateConversionGoalCampaignConfigsResponse
            {
                Results =
                {
                    new MutateConversionGoalCampaignConfigResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateConversionGoalCampaignConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionGoalCampaignConfigsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionGoalCampaignConfigServiceClient client = new ConversionGoalCampaignConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionGoalCampaignConfigsResponse responseCallSettings = await client.MutateConversionGoalCampaignConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateConversionGoalCampaignConfigsResponse responseCancellationToken = await client.MutateConversionGoalCampaignConfigsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateConversionGoalCampaignConfigs()
        {
            moq::Mock<ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient> mockGrpcClient = new moq::Mock<ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient>(moq::MockBehavior.Strict);
            MutateConversionGoalCampaignConfigsRequest request = new MutateConversionGoalCampaignConfigsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionGoalCampaignConfigOperation(),
                },
            };
            MutateConversionGoalCampaignConfigsResponse expectedResponse = new MutateConversionGoalCampaignConfigsResponse
            {
                Results =
                {
                    new MutateConversionGoalCampaignConfigResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateConversionGoalCampaignConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionGoalCampaignConfigServiceClient client = new ConversionGoalCampaignConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionGoalCampaignConfigsResponse response = client.MutateConversionGoalCampaignConfigs(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateConversionGoalCampaignConfigsAsync()
        {
            moq::Mock<ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient> mockGrpcClient = new moq::Mock<ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient>(moq::MockBehavior.Strict);
            MutateConversionGoalCampaignConfigsRequest request = new MutateConversionGoalCampaignConfigsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionGoalCampaignConfigOperation(),
                },
            };
            MutateConversionGoalCampaignConfigsResponse expectedResponse = new MutateConversionGoalCampaignConfigsResponse
            {
                Results =
                {
                    new MutateConversionGoalCampaignConfigResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateConversionGoalCampaignConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionGoalCampaignConfigsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionGoalCampaignConfigServiceClient client = new ConversionGoalCampaignConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateConversionGoalCampaignConfigsResponse responseCallSettings = await client.MutateConversionGoalCampaignConfigsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateConversionGoalCampaignConfigsResponse responseCancellationToken = await client.MutateConversionGoalCampaignConfigsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
