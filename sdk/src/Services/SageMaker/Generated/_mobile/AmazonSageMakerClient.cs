/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.SageMaker.Model;
using Amazon.SageMaker.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SageMaker
{
    /// <summary>
    /// Implementation for accessing SageMaker
    ///
    /// Definition of the public APIs exposed by SageMaker
    /// </summary>
    public partial class AmazonSageMakerClient : AmazonServiceClient, IAmazonSageMaker
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSageMakerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerConfig()) { }

        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(AmazonSageMakerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerClient(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials and an
        /// AmazonSageMakerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(AWSCredentials credentials, AmazonSageMakerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsRequest,AddTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsRequest,AddTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEndpoint

        internal virtual CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request)
        {
            var marshaller = new CreateEndpointRequestMarshaller();
            var unmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointRequest,CreateEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateEndpointRequestMarshaller();
            var unmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEndpointRequest,CreateEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEndpointConfig

        internal virtual CreateEndpointConfigResponse CreateEndpointConfig(CreateEndpointConfigRequest request)
        {
            var marshaller = new CreateEndpointConfigRequestMarshaller();
            var unmarshaller = CreateEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointConfigRequest,CreateEndpointConfigResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        public virtual Task<CreateEndpointConfigResponse> CreateEndpointConfigAsync(CreateEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateEndpointConfigRequestMarshaller();
            var unmarshaller = CreateEndpointConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEndpointConfigRequest,CreateEndpointConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateModel

        internal virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var marshaller = new CreateModelRequestMarshaller();
            var unmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelRequest,CreateModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateModelRequestMarshaller();
            var unmarshaller = CreateModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelRequest,CreateModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNotebookInstance

        internal virtual CreateNotebookInstanceResponse CreateNotebookInstance(CreateNotebookInstanceRequest request)
        {
            var marshaller = new CreateNotebookInstanceRequestMarshaller();
            var unmarshaller = CreateNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateNotebookInstanceRequest,CreateNotebookInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        public virtual Task<CreateNotebookInstanceResponse> CreateNotebookInstanceAsync(CreateNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNotebookInstanceRequestMarshaller();
            var unmarshaller = CreateNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNotebookInstanceRequest,CreateNotebookInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePresignedNotebookInstanceUrl

        internal virtual CreatePresignedNotebookInstanceUrlResponse CreatePresignedNotebookInstanceUrl(CreatePresignedNotebookInstanceUrlRequest request)
        {
            var marshaller = new CreatePresignedNotebookInstanceUrlRequestMarshaller();
            var unmarshaller = CreatePresignedNotebookInstanceUrlResponseUnmarshaller.Instance;

            return Invoke<CreatePresignedNotebookInstanceUrlRequest,CreatePresignedNotebookInstanceUrlResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePresignedNotebookInstanceUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookInstanceUrl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        public virtual Task<CreatePresignedNotebookInstanceUrlResponse> CreatePresignedNotebookInstanceUrlAsync(CreatePresignedNotebookInstanceUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePresignedNotebookInstanceUrlRequestMarshaller();
            var unmarshaller = CreatePresignedNotebookInstanceUrlResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePresignedNotebookInstanceUrlRequest,CreatePresignedNotebookInstanceUrlResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrainingJob

        internal virtual CreateTrainingJobResponse CreateTrainingJob(CreateTrainingJobRequest request)
        {
            var marshaller = new CreateTrainingJobRequestMarshaller();
            var unmarshaller = CreateTrainingJobResponseUnmarshaller.Instance;

            return Invoke<CreateTrainingJobRequest,CreateTrainingJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        public virtual Task<CreateTrainingJobResponse> CreateTrainingJobAsync(CreateTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrainingJobRequestMarshaller();
            var unmarshaller = CreateTrainingJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrainingJobRequest,CreateTrainingJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpoint

        internal virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var marshaller = new DeleteEndpointRequestMarshaller();
            var unmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointRequest,DeleteEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEndpointRequestMarshaller();
            var unmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointRequest,DeleteEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpointConfig

        internal virtual DeleteEndpointConfigResponse DeleteEndpointConfig(DeleteEndpointConfigRequest request)
        {
            var marshaller = new DeleteEndpointConfigRequestMarshaller();
            var unmarshaller = DeleteEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointConfigRequest,DeleteEndpointConfigResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        public virtual Task<DeleteEndpointConfigResponse> DeleteEndpointConfigAsync(DeleteEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEndpointConfigRequestMarshaller();
            var unmarshaller = DeleteEndpointConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointConfigRequest,DeleteEndpointConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteModel

        internal virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var marshaller = new DeleteModelRequestMarshaller();
            var unmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelRequest,DeleteModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteModelRequestMarshaller();
            var unmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelRequest,DeleteModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotebookInstance

        internal virtual DeleteNotebookInstanceResponse DeleteNotebookInstance(DeleteNotebookInstanceRequest request)
        {
            var marshaller = new DeleteNotebookInstanceRequestMarshaller();
            var unmarshaller = DeleteNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteNotebookInstanceRequest,DeleteNotebookInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        public virtual Task<DeleteNotebookInstanceResponse> DeleteNotebookInstanceAsync(DeleteNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNotebookInstanceRequestMarshaller();
            var unmarshaller = DeleteNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotebookInstanceRequest,DeleteNotebookInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoint

        internal virtual DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request)
        {
            var marshaller = new DescribeEndpointRequestMarshaller();
            var unmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointRequest,DescribeEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEndpointRequestMarshaller();
            var unmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointRequest,DescribeEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpointConfig

        internal virtual DescribeEndpointConfigResponse DescribeEndpointConfig(DescribeEndpointConfigRequest request)
        {
            var marshaller = new DescribeEndpointConfigRequestMarshaller();
            var unmarshaller = DescribeEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointConfigRequest,DescribeEndpointConfigResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        public virtual Task<DescribeEndpointConfigResponse> DescribeEndpointConfigAsync(DescribeEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEndpointConfigRequestMarshaller();
            var unmarshaller = DescribeEndpointConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointConfigRequest,DescribeEndpointConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeModel

        internal virtual DescribeModelResponse DescribeModel(DescribeModelRequest request)
        {
            var marshaller = new DescribeModelRequestMarshaller();
            var unmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return Invoke<DescribeModelRequest,DescribeModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        public virtual Task<DescribeModelResponse> DescribeModelAsync(DescribeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeModelRequestMarshaller();
            var unmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelRequest,DescribeModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotebookInstance

        internal virtual DescribeNotebookInstanceResponse DescribeNotebookInstance(DescribeNotebookInstanceRequest request)
        {
            var marshaller = new DescribeNotebookInstanceRequestMarshaller();
            var unmarshaller = DescribeNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeNotebookInstanceRequest,DescribeNotebookInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        public virtual Task<DescribeNotebookInstanceResponse> DescribeNotebookInstanceAsync(DescribeNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNotebookInstanceRequestMarshaller();
            var unmarshaller = DescribeNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotebookInstanceRequest,DescribeNotebookInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrainingJob

        internal virtual DescribeTrainingJobResponse DescribeTrainingJob(DescribeTrainingJobRequest request)
        {
            var marshaller = new DescribeTrainingJobRequestMarshaller();
            var unmarshaller = DescribeTrainingJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTrainingJobRequest,DescribeTrainingJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        public virtual Task<DescribeTrainingJobResponse> DescribeTrainingJobAsync(DescribeTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTrainingJobRequestMarshaller();
            var unmarshaller = DescribeTrainingJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrainingJobRequest,DescribeTrainingJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListEndpointConfigs

        internal virtual ListEndpointConfigsResponse ListEndpointConfigs(ListEndpointConfigsRequest request)
        {
            var marshaller = new ListEndpointConfigsRequestMarshaller();
            var unmarshaller = ListEndpointConfigsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointConfigsRequest,ListEndpointConfigsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        public virtual Task<ListEndpointConfigsResponse> ListEndpointConfigsAsync(ListEndpointConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListEndpointConfigsRequestMarshaller();
            var unmarshaller = ListEndpointConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEndpointConfigsRequest,ListEndpointConfigsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListEndpoints

        internal virtual ListEndpointsResponse ListEndpoints(ListEndpointsRequest request)
        {
            var marshaller = new ListEndpointsRequestMarshaller();
            var unmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointsRequest,ListEndpointsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        public virtual Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListEndpointsRequestMarshaller();
            var unmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEndpointsRequest,ListEndpointsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListModels

        internal virtual ListModelsResponse ListModels(ListModelsRequest request)
        {
            var marshaller = new ListModelsRequestMarshaller();
            var unmarshaller = ListModelsResponseUnmarshaller.Instance;

            return Invoke<ListModelsRequest,ListModelsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListModelsRequestMarshaller();
            var unmarshaller = ListModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelsRequest,ListModelsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListNotebookInstances

        internal virtual ListNotebookInstancesResponse ListNotebookInstances(ListNotebookInstancesRequest request)
        {
            var marshaller = new ListNotebookInstancesRequestMarshaller();
            var unmarshaller = ListNotebookInstancesResponseUnmarshaller.Instance;

            return Invoke<ListNotebookInstancesRequest,ListNotebookInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListNotebookInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        public virtual Task<ListNotebookInstancesResponse> ListNotebookInstancesAsync(ListNotebookInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListNotebookInstancesRequestMarshaller();
            var unmarshaller = ListNotebookInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNotebookInstancesRequest,ListNotebookInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var marshaller = new ListTagsRequestMarshaller();
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsRequest,ListTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsRequestMarshaller();
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsRequest,ListTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrainingJobs

        internal virtual ListTrainingJobsResponse ListTrainingJobs(ListTrainingJobsRequest request)
        {
            var marshaller = new ListTrainingJobsRequestMarshaller();
            var unmarshaller = ListTrainingJobsResponseUnmarshaller.Instance;

            return Invoke<ListTrainingJobsRequest,ListTrainingJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        public virtual Task<ListTrainingJobsResponse> ListTrainingJobsAsync(ListTrainingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrainingJobsRequestMarshaller();
            var unmarshaller = ListTrainingJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrainingJobsRequest,ListTrainingJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartNotebookInstance

        internal virtual StartNotebookInstanceResponse StartNotebookInstance(StartNotebookInstanceRequest request)
        {
            var marshaller = new StartNotebookInstanceRequestMarshaller();
            var unmarshaller = StartNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<StartNotebookInstanceRequest,StartNotebookInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        public virtual Task<StartNotebookInstanceResponse> StartNotebookInstanceAsync(StartNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartNotebookInstanceRequestMarshaller();
            var unmarshaller = StartNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartNotebookInstanceRequest,StartNotebookInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopNotebookInstance

        internal virtual StopNotebookInstanceResponse StopNotebookInstance(StopNotebookInstanceRequest request)
        {
            var marshaller = new StopNotebookInstanceRequestMarshaller();
            var unmarshaller = StopNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<StopNotebookInstanceRequest,StopNotebookInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        public virtual Task<StopNotebookInstanceResponse> StopNotebookInstanceAsync(StopNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopNotebookInstanceRequestMarshaller();
            var unmarshaller = StopNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StopNotebookInstanceRequest,StopNotebookInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopTrainingJob

        internal virtual StopTrainingJobResponse StopTrainingJob(StopTrainingJobRequest request)
        {
            var marshaller = new StopTrainingJobRequestMarshaller();
            var unmarshaller = StopTrainingJobResponseUnmarshaller.Instance;

            return Invoke<StopTrainingJobRequest,StopTrainingJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        public virtual Task<StopTrainingJobResponse> StopTrainingJobAsync(StopTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopTrainingJobRequestMarshaller();
            var unmarshaller = StopTrainingJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopTrainingJobRequest,StopTrainingJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpoint

        internal virtual UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request)
        {
            var marshaller = new UpdateEndpointRequestMarshaller();
            var unmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointRequest,UpdateEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        public virtual Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateEndpointRequestMarshaller();
            var unmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointRequest,UpdateEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpointWeightsAndCapacities

        internal virtual UpdateEndpointWeightsAndCapacitiesResponse UpdateEndpointWeightsAndCapacities(UpdateEndpointWeightsAndCapacitiesRequest request)
        {
            var marshaller = new UpdateEndpointWeightsAndCapacitiesRequestMarshaller();
            var unmarshaller = UpdateEndpointWeightsAndCapacitiesResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointWeightsAndCapacitiesRequest,UpdateEndpointWeightsAndCapacitiesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointWeightsAndCapacities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        public virtual Task<UpdateEndpointWeightsAndCapacitiesResponse> UpdateEndpointWeightsAndCapacitiesAsync(UpdateEndpointWeightsAndCapacitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateEndpointWeightsAndCapacitiesRequestMarshaller();
            var unmarshaller = UpdateEndpointWeightsAndCapacitiesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointWeightsAndCapacitiesRequest,UpdateEndpointWeightsAndCapacitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotebookInstance

        internal virtual UpdateNotebookInstanceResponse UpdateNotebookInstance(UpdateNotebookInstanceRequest request)
        {
            var marshaller = new UpdateNotebookInstanceRequestMarshaller();
            var unmarshaller = UpdateNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateNotebookInstanceRequest,UpdateNotebookInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        public virtual Task<UpdateNotebookInstanceResponse> UpdateNotebookInstanceAsync(UpdateNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateNotebookInstanceRequestMarshaller();
            var unmarshaller = UpdateNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNotebookInstanceRequest,UpdateNotebookInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}