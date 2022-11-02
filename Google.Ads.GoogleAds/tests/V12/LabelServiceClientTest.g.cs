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
    public sealed class GeneratedLabelServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateLabelsRequestObject()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new LabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse
            {
                Results =
                {
                    new MutateLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateLabelsResponse response = client.MutateLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateLabelsRequestObjectAsync()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new LabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse
            {
                Results =
                {
                    new MutateLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateLabelsResponse responseCallSettings = await client.MutateLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateLabelsResponse responseCancellationToken = await client.MutateLabelsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateLabels()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new LabelOperation(),
                },
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse
            {
                Results =
                {
                    new MutateLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateLabelsResponse response = client.MutateLabels(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateLabelsAsync()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new LabelOperation(),
                },
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse
            {
                Results =
                {
                    new MutateLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateLabelsResponse responseCallSettings = await client.MutateLabelsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateLabelsResponse responseCancellationToken = await client.MutateLabelsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
