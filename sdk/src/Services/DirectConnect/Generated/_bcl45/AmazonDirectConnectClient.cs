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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.DirectConnect.Model;
using Amazon.DirectConnect.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DirectConnect
{
    /// <summary>
    /// Implementation for accessing DirectConnect
    ///
    /// AWS Direct Connect links your internal network to an AWS Direct Connect location over
    /// a standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of the cable
    /// is connected to your router, the other to an AWS Direct Connect router. With this
    /// connection in place, you can create virtual interfaces directly to the AWS cloud (for
    /// example, to Amazon Elastic Compute Cloud (Amazon EC2) and Amazon Simple Storage Service
    /// (Amazon S3)) and to Amazon Virtual Private Cloud (Amazon VPC), bypassing Internet
    /// service providers in your network path. An AWS Direct Connect location provides access
    /// to AWS in the region it is associated with, as well as access to other US regions.
    /// For example, you can provision a single connection to any AWS Direct Connect location
    /// in the US and use it to access public AWS services in all US Regions and AWS GovCloud
    /// (US).
    /// </summary>
    public partial class AmazonDirectConnectClient : AmazonServiceClient, IAmazonDirectConnect
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonDirectConnectClient with the credentials loaded from the application's
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
        public AmazonDirectConnectClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectConnectConfig()) { }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with the credentials loaded from the application's
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
        public AmazonDirectConnectClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectConnectConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(AmazonDirectConnectConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDirectConnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDirectConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials and an
        /// AmazonDirectConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(AWSCredentials credentials, AmazonDirectConnectConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectConnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDirectConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDirectConnectConfig clientConfig)
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

        
        #region  AllocateConnectionOnInterconnect


        /// <summary>
        /// Deprecated in favor of <a>AllocateHostedConnection</a>.
        /// 
        ///  
        /// <para>
        /// Creates a hosted connection on an interconnect.
        /// </para>
        ///  
        /// <para>
        /// Allocates a VLAN number and a specified amount of bandwidth for use by a hosted connection
        /// on the given interconnect.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect service method.</param>
        /// 
        /// <returns>The response from the AllocateConnectionOnInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateConnectionOnInterconnect">REST API Reference for AllocateConnectionOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of AllocateHostedConnection.")]
        public virtual AllocateConnectionOnInterconnectResponse AllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest request)
        {
            var marshaller = new AllocateConnectionOnInterconnectRequestMarshaller();
            var unmarshaller = AllocateConnectionOnInterconnectResponseUnmarshaller.Instance;

            return Invoke<AllocateConnectionOnInterconnectRequest,AllocateConnectionOnInterconnectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateConnectionOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateConnectionOnInterconnect">REST API Reference for AllocateConnectionOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of AllocateHostedConnection.")]
        public virtual Task<AllocateConnectionOnInterconnectResponse> AllocateConnectionOnInterconnectAsync(AllocateConnectionOnInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AllocateConnectionOnInterconnectRequestMarshaller();
            var unmarshaller = AllocateConnectionOnInterconnectResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateConnectionOnInterconnectRequest,AllocateConnectionOnInterconnectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AllocateHostedConnection


        /// <summary>
        /// Creates a hosted connection on an interconnect or a link aggregation group (LAG).
        /// 
        ///  
        /// <para>
        /// Allocates a VLAN number and a specified amount of bandwidth for use by a hosted connection
        /// on the given interconnect or LAG.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateHostedConnection service method.</param>
        /// 
        /// <returns>The response from the AllocateHostedConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateHostedConnection">REST API Reference for AllocateHostedConnection Operation</seealso>
        public virtual AllocateHostedConnectionResponse AllocateHostedConnection(AllocateHostedConnectionRequest request)
        {
            var marshaller = new AllocateHostedConnectionRequestMarshaller();
            var unmarshaller = AllocateHostedConnectionResponseUnmarshaller.Instance;

            return Invoke<AllocateHostedConnectionRequest,AllocateHostedConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateHostedConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateHostedConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateHostedConnection">REST API Reference for AllocateHostedConnection Operation</seealso>
        public virtual Task<AllocateHostedConnectionResponse> AllocateHostedConnectionAsync(AllocateHostedConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AllocateHostedConnectionRequestMarshaller();
            var unmarshaller = AllocateHostedConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateHostedConnectionRequest,AllocateHostedConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AllocatePrivateVirtualInterface


        /// <summary>
        /// Provisions a private virtual interface to be owned by another AWS customer.
        /// 
        ///  
        /// <para>
        /// Virtual interfaces created using this action must be confirmed by the virtual interface
        /// owner by using the <a>ConfirmPrivateVirtualInterface</a> action. Until then, the virtual
        /// interface will be in 'Confirming' state, and will not be available for handling traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AllocatePrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePrivateVirtualInterface">REST API Reference for AllocatePrivateVirtualInterface Operation</seealso>
        public virtual AllocatePrivateVirtualInterfaceResponse AllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest request)
        {
            var marshaller = new AllocatePrivateVirtualInterfaceRequestMarshaller();
            var unmarshaller = AllocatePrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<AllocatePrivateVirtualInterfaceRequest,AllocatePrivateVirtualInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePrivateVirtualInterface">REST API Reference for AllocatePrivateVirtualInterface Operation</seealso>
        public virtual Task<AllocatePrivateVirtualInterfaceResponse> AllocatePrivateVirtualInterfaceAsync(AllocatePrivateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AllocatePrivateVirtualInterfaceRequestMarshaller();
            var unmarshaller = AllocatePrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AllocatePrivateVirtualInterfaceRequest,AllocatePrivateVirtualInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AllocatePublicVirtualInterface


        /// <summary>
        /// Provisions a public virtual interface to be owned by a different customer.
        /// 
        ///  
        /// <para>
        /// The owner of a connection calls this function to provision a public virtual interface
        /// which will be owned by another AWS customer.
        /// </para>
        ///  
        /// <para>
        /// Virtual interfaces created using this function must be confirmed by the virtual interface
        /// owner by calling ConfirmPublicVirtualInterface. Until this step has been completed,
        /// the virtual interface will be in 'Confirming' state, and will not be available for
        /// handling traffic.
        /// </para>
        ///  
        /// <para>
        /// When creating an IPv6 public virtual interface (addressFamily is 'ipv6'), the customer
        /// and amazon address fields should be left blank to use auto-assigned IPv6 space. Custom
        /// IPv6 Addresses are currently not supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AllocatePublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePublicVirtualInterface">REST API Reference for AllocatePublicVirtualInterface Operation</seealso>
        public virtual AllocatePublicVirtualInterfaceResponse AllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest request)
        {
            var marshaller = new AllocatePublicVirtualInterfaceRequestMarshaller();
            var unmarshaller = AllocatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<AllocatePublicVirtualInterfaceRequest,AllocatePublicVirtualInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePublicVirtualInterface">REST API Reference for AllocatePublicVirtualInterface Operation</seealso>
        public virtual Task<AllocatePublicVirtualInterfaceResponse> AllocatePublicVirtualInterfaceAsync(AllocatePublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AllocatePublicVirtualInterfaceRequestMarshaller();
            var unmarshaller = AllocatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AllocatePublicVirtualInterfaceRequest,AllocatePublicVirtualInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateConnectionWithLag


        /// <summary>
        /// Associates an existing connection with a link aggregation group (LAG). The connection
        /// is interrupted and re-established as a member of the LAG (connectivity to AWS will
        /// be interrupted). The connection must be hosted on the same AWS Direct Connect endpoint
        /// as the LAG, and its bandwidth must match the bandwidth for the LAG. You can reassociate
        /// a connection that's currently associated with a different LAG; however, if removing
        /// the connection will cause the original LAG to fall below its setting for minimum number
        /// of operational connections, the request fails.
        /// 
        ///  
        /// <para>
        /// Any virtual interfaces that are directly associated with the connection are automatically
        /// re-associated with the LAG. If the connection was originally associated with a different
        /// LAG, the virtual interfaces remain associated with the original LAG.
        /// </para>
        ///  
        /// <para>
        /// For interconnects, any hosted connections are automatically re-associated with the
        /// LAG. If the interconnect was originally associated with a different LAG, the hosted
        /// connections remain associated with the original LAG.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectionWithLag service method.</param>
        /// 
        /// <returns>The response from the AssociateConnectionWithLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateConnectionWithLag">REST API Reference for AssociateConnectionWithLag Operation</seealso>
        public virtual AssociateConnectionWithLagResponse AssociateConnectionWithLag(AssociateConnectionWithLagRequest request)
        {
            var marshaller = new AssociateConnectionWithLagRequestMarshaller();
            var unmarshaller = AssociateConnectionWithLagResponseUnmarshaller.Instance;

            return Invoke<AssociateConnectionWithLagRequest,AssociateConnectionWithLagResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateConnectionWithLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectionWithLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateConnectionWithLag">REST API Reference for AssociateConnectionWithLag Operation</seealso>
        public virtual Task<AssociateConnectionWithLagResponse> AssociateConnectionWithLagAsync(AssociateConnectionWithLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateConnectionWithLagRequestMarshaller();
            var unmarshaller = AssociateConnectionWithLagResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateConnectionWithLagRequest,AssociateConnectionWithLagResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateHostedConnection


        /// <summary>
        /// Associates a hosted connection and its virtual interfaces with a link aggregation
        /// group (LAG) or interconnect. If the target interconnect or LAG has an existing hosted
        /// connection with a conflicting VLAN number or IP address, the operation fails. This
        /// action temporarily interrupts the hosted connection's connectivity to AWS as it is
        /// being migrated.
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedConnection service method.</param>
        /// 
        /// <returns>The response from the AssociateHostedConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateHostedConnection">REST API Reference for AssociateHostedConnection Operation</seealso>
        public virtual AssociateHostedConnectionResponse AssociateHostedConnection(AssociateHostedConnectionRequest request)
        {
            var marshaller = new AssociateHostedConnectionRequestMarshaller();
            var unmarshaller = AssociateHostedConnectionResponseUnmarshaller.Instance;

            return Invoke<AssociateHostedConnectionRequest,AssociateHostedConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateHostedConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateHostedConnection">REST API Reference for AssociateHostedConnection Operation</seealso>
        public virtual Task<AssociateHostedConnectionResponse> AssociateHostedConnectionAsync(AssociateHostedConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateHostedConnectionRequestMarshaller();
            var unmarshaller = AssociateHostedConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateHostedConnectionRequest,AssociateHostedConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateVirtualInterface


        /// <summary>
        /// Associates a virtual interface with a specified link aggregation group (LAG) or connection.
        /// Connectivity to AWS is temporarily interrupted as the virtual interface is being migrated.
        /// If the target connection or LAG has an associated virtual interface with a conflicting
        /// VLAN number or a conflicting IP address, the operation fails. 
        /// 
        ///  
        /// <para>
        /// Virtual interfaces associated with a hosted connection cannot be associated with a
        /// LAG; hosted connections must be migrated along with their virtual interfaces using
        /// <a>AssociateHostedConnection</a>.
        /// </para>
        ///  
        /// <para>
        /// In order to reassociate a virtual interface to a new connection or LAG, the requester
        /// must own either the virtual interface itself or the connection to which the virtual
        /// interface is currently associated. Additionally, the requester must own the connection
        /// or LAG to which the virtual interface will be newly associated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AssociateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateVirtualInterface">REST API Reference for AssociateVirtualInterface Operation</seealso>
        public virtual AssociateVirtualInterfaceResponse AssociateVirtualInterface(AssociateVirtualInterfaceRequest request)
        {
            var marshaller = new AssociateVirtualInterfaceRequestMarshaller();
            var unmarshaller = AssociateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<AssociateVirtualInterfaceRequest,AssociateVirtualInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateVirtualInterface">REST API Reference for AssociateVirtualInterface Operation</seealso>
        public virtual Task<AssociateVirtualInterfaceResponse> AssociateVirtualInterfaceAsync(AssociateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateVirtualInterfaceRequestMarshaller();
            var unmarshaller = AssociateVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateVirtualInterfaceRequest,AssociateVirtualInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ConfirmConnection


        /// <summary>
        /// Confirm the creation of a hosted connection on an interconnect.
        /// 
        ///  
        /// <para>
        /// Upon creation, the hosted connection is initially in the 'Ordering' state, and will
        /// remain in this state until the owner calls ConfirmConnection to confirm creation of
        /// the hosted connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection service method.</param>
        /// 
        /// <returns>The response from the ConfirmConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmConnection">REST API Reference for ConfirmConnection Operation</seealso>
        public virtual ConfirmConnectionResponse ConfirmConnection(ConfirmConnectionRequest request)
        {
            var marshaller = new ConfirmConnectionRequestMarshaller();
            var unmarshaller = ConfirmConnectionResponseUnmarshaller.Instance;

            return Invoke<ConfirmConnectionRequest,ConfirmConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmConnection">REST API Reference for ConfirmConnection Operation</seealso>
        public virtual Task<ConfirmConnectionResponse> ConfirmConnectionAsync(ConfirmConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfirmConnectionRequestMarshaller();
            var unmarshaller = ConfirmConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmConnectionRequest,ConfirmConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ConfirmPrivateVirtualInterface


        /// <summary>
        /// Accept ownership of a private virtual interface created by another customer.
        /// 
        ///  
        /// <para>
        /// After the virtual interface owner calls this function, the virtual interface will
        /// be created and attached to the given virtual private gateway or direct connect gateway,
        /// and will be available for handling traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the ConfirmPrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPrivateVirtualInterface">REST API Reference for ConfirmPrivateVirtualInterface Operation</seealso>
        public virtual ConfirmPrivateVirtualInterfaceResponse ConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest request)
        {
            var marshaller = new ConfirmPrivateVirtualInterfaceRequestMarshaller();
            var unmarshaller = ConfirmPrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<ConfirmPrivateVirtualInterfaceRequest,ConfirmPrivateVirtualInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPrivateVirtualInterface">REST API Reference for ConfirmPrivateVirtualInterface Operation</seealso>
        public virtual Task<ConfirmPrivateVirtualInterfaceResponse> ConfirmPrivateVirtualInterfaceAsync(ConfirmPrivateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfirmPrivateVirtualInterfaceRequestMarshaller();
            var unmarshaller = ConfirmPrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmPrivateVirtualInterfaceRequest,ConfirmPrivateVirtualInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ConfirmPublicVirtualInterface


        /// <summary>
        /// Accept ownership of a public virtual interface created by another customer.
        /// 
        ///  
        /// <para>
        /// After the virtual interface owner calls this function, the specified virtual interface
        /// will be created and made available for handling traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the ConfirmPublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPublicVirtualInterface">REST API Reference for ConfirmPublicVirtualInterface Operation</seealso>
        public virtual ConfirmPublicVirtualInterfaceResponse ConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest request)
        {
            var marshaller = new ConfirmPublicVirtualInterfaceRequestMarshaller();
            var unmarshaller = ConfirmPublicVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<ConfirmPublicVirtualInterfaceRequest,ConfirmPublicVirtualInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPublicVirtualInterface">REST API Reference for ConfirmPublicVirtualInterface Operation</seealso>
        public virtual Task<ConfirmPublicVirtualInterfaceResponse> ConfirmPublicVirtualInterfaceAsync(ConfirmPublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfirmPublicVirtualInterfaceRequestMarshaller();
            var unmarshaller = ConfirmPublicVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmPublicVirtualInterfaceRequest,ConfirmPublicVirtualInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateBGPPeer


        /// <summary>
        /// Creates a new BGP peer on a specified virtual interface. The BGP peer cannot be in
        /// the same address family (IPv4/IPv6) of an existing BGP peer on the virtual interface.
        /// 
        ///  
        /// <para>
        /// You must create a BGP peer for the corresponding address family in order to access
        /// AWS resources that also use that address family.
        /// </para>
        ///  
        /// <para>
        /// When creating a IPv6 BGP peer, the Amazon address and customer address fields must
        /// be left blank. IPv6 addresses are automatically assigned from Amazon's pool of IPv6
        /// addresses; you cannot specify custom IPv6 addresses.
        /// </para>
        ///  
        /// <para>
        /// For a public virtual interface, the Autonomous System Number (ASN) must be private
        /// or already whitelisted for the virtual interface.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBGPPeer service method.</param>
        /// 
        /// <returns>The response from the CreateBGPPeer service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateBGPPeer">REST API Reference for CreateBGPPeer Operation</seealso>
        public virtual CreateBGPPeerResponse CreateBGPPeer(CreateBGPPeerRequest request)
        {
            var marshaller = new CreateBGPPeerRequestMarshaller();
            var unmarshaller = CreateBGPPeerResponseUnmarshaller.Instance;

            return Invoke<CreateBGPPeerRequest,CreateBGPPeerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBGPPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBGPPeer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateBGPPeer">REST API Reference for CreateBGPPeer Operation</seealso>
        public virtual Task<CreateBGPPeerResponse> CreateBGPPeerAsync(CreateBGPPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateBGPPeerRequestMarshaller();
            var unmarshaller = CreateBGPPeerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBGPPeerRequest,CreateBGPPeerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConnection


        /// <summary>
        /// Creates a new connection between the customer network and a specific AWS Direct Connect
        /// location.
        /// 
        ///  
        /// <para>
        /// A connection links your internal network to an AWS Direct Connect location over a
        /// standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of the cable
        /// is connected to your router, the other to an AWS Direct Connect router. An AWS Direct
        /// Connect location provides access to Amazon Web Services in the region it is associated
        /// with. You can establish connections with AWS Direct Connect locations in multiple
        /// regions, but a connection in one region does not provide connectivity to other regions.
        /// </para>
        ///  
        /// <para>
        /// To find the locations for your region, use <a>DescribeLocations</a>.
        /// </para>
        ///  
        /// <para>
        /// You can automatically add the new connection to a link aggregation group (LAG) by
        /// specifying a LAG ID in the request. This ensures that the new connection is allocated
        /// on the same AWS Direct Connect endpoint that hosts the specified LAG. If there are
        /// no available ports on the endpoint, the request fails and no connection will be created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var marshaller = new CreateConnectionRequestMarshaller();
            var unmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionRequest,CreateConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateConnectionRequestMarshaller();
            var unmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectionRequest,CreateConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectConnectGateway


        /// <summary>
        /// Creates a new direct connect gateway. A direct connect gateway is an intermediate
        /// object that enables you to connect a set of virtual interfaces and virtual private
        /// gateways. direct connect gateways are global and visible in any AWS region after they
        /// are created. The virtual interfaces and virtual private gateways that are connected
        /// through a direct connect gateway can be in different regions. This enables you to
        /// connect to a VPC in any region, regardless of the region in which the virtual interfaces
        /// are located, and pass traffic between them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGateway service method.</param>
        /// 
        /// <returns>The response from the CreateDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGateway">REST API Reference for CreateDirectConnectGateway Operation</seealso>
        public virtual CreateDirectConnectGatewayResponse CreateDirectConnectGateway(CreateDirectConnectGatewayRequest request)
        {
            var marshaller = new CreateDirectConnectGatewayRequestMarshaller();
            var unmarshaller = CreateDirectConnectGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateDirectConnectGatewayRequest,CreateDirectConnectGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGateway">REST API Reference for CreateDirectConnectGateway Operation</seealso>
        public virtual Task<CreateDirectConnectGatewayResponse> CreateDirectConnectGatewayAsync(CreateDirectConnectGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDirectConnectGatewayRequestMarshaller();
            var unmarshaller = CreateDirectConnectGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectConnectGatewayRequest,CreateDirectConnectGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectConnectGatewayAssociation


        /// <summary>
        /// Creates an association between a direct connect gateway and a virtual private gateway
        /// (VGW). The VGW must be attached to a VPC and must not be associated with another direct
        /// connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociation">REST API Reference for CreateDirectConnectGatewayAssociation Operation</seealso>
        public virtual CreateDirectConnectGatewayAssociationResponse CreateDirectConnectGatewayAssociation(CreateDirectConnectGatewayAssociationRequest request)
        {
            var marshaller = new CreateDirectConnectGatewayAssociationRequestMarshaller();
            var unmarshaller = CreateDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateDirectConnectGatewayAssociationRequest,CreateDirectConnectGatewayAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociation">REST API Reference for CreateDirectConnectGatewayAssociation Operation</seealso>
        public virtual Task<CreateDirectConnectGatewayAssociationResponse> CreateDirectConnectGatewayAssociationAsync(CreateDirectConnectGatewayAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDirectConnectGatewayAssociationRequestMarshaller();
            var unmarshaller = CreateDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectConnectGatewayAssociationRequest,CreateDirectConnectGatewayAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInterconnect


        /// <summary>
        /// Creates a new interconnect between a AWS Direct Connect partner's network and a specific
        /// AWS Direct Connect location.
        /// 
        ///  
        /// <para>
        /// An interconnect is a connection which is capable of hosting other connections. The
        /// AWS Direct Connect partner can use an interconnect to provide sub-1Gbps AWS Direct
        /// Connect service to tier 2 customers who do not have their own connections. Like a
        /// standard connection, an interconnect links the AWS Direct Connect partner's network
        /// to an AWS Direct Connect location over a standard 1 Gbps or 10 Gbps Ethernet fiber-optic
        /// cable. One end is connected to the partner's router, the other to an AWS Direct Connect
        /// router.
        /// </para>
        ///  
        /// <para>
        /// You can automatically add the new interconnect to a link aggregation group (LAG) by
        /// specifying a LAG ID in the request. This ensures that the new interconnect is allocated
        /// on the same AWS Direct Connect endpoint that hosts the specified LAG. If there are
        /// no available ports on the endpoint, the request fails and no interconnect will be
        /// created.
        /// </para>
        ///  
        /// <para>
        /// For each end customer, the AWS Direct Connect partner provisions a connection on their
        /// interconnect by calling AllocateConnectionOnInterconnect. The end customer can then
        /// connect to AWS resources by creating a virtual interface on their connection, using
        /// the VLAN assigned to them by the AWS Direct Connect partner.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect service method.</param>
        /// 
        /// <returns>The response from the CreateInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateInterconnect">REST API Reference for CreateInterconnect Operation</seealso>
        public virtual CreateInterconnectResponse CreateInterconnect(CreateInterconnectRequest request)
        {
            var marshaller = new CreateInterconnectRequestMarshaller();
            var unmarshaller = CreateInterconnectResponseUnmarshaller.Instance;

            return Invoke<CreateInterconnectRequest,CreateInterconnectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateInterconnect">REST API Reference for CreateInterconnect Operation</seealso>
        public virtual Task<CreateInterconnectResponse> CreateInterconnectAsync(CreateInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInterconnectRequestMarshaller();
            var unmarshaller = CreateInterconnectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInterconnectRequest,CreateInterconnectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLag


        /// <summary>
        /// Creates a new link aggregation group (LAG) with the specified number of bundled physical
        /// connections between the customer network and a specific AWS Direct Connect location.
        /// A LAG is a logical interface that uses the Link Aggregation Control Protocol (LACP)
        /// to aggregate multiple 1 gigabit or 10 gigabit interfaces, allowing you to treat them
        /// as a single interface.
        /// 
        ///  
        /// <para>
        /// All connections in a LAG must use the same bandwidth (for example, 10 Gbps), and must
        /// terminate at the same AWS Direct Connect endpoint.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 10 connections per LAG. Regardless of this limit, if you request
        /// more connections for the LAG than AWS Direct Connect can allocate on a single endpoint,
        /// no LAG is created.
        /// </para>
        ///  
        /// <para>
        /// You can specify an existing physical connection or interconnect to include in the
        /// LAG (which counts towards the total number of connections). Doing so interrupts the
        /// current physical connection or hosted connections, and re-establishes them as a member
        /// of the LAG. The LAG will be created on the same AWS Direct Connect endpoint to which
        /// the connection terminates. Any virtual interfaces associated with the connection are
        /// automatically disassociated and re-associated with the LAG. The connection ID does
        /// not change.
        /// </para>
        ///  
        /// <para>
        /// If the AWS account used to create a LAG is a registered AWS Direct Connect partner,
        /// the LAG is automatically enabled to host sub-connections. For a LAG owned by a partner,
        /// any associated virtual interfaces cannot be directly configured.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLag service method.</param>
        /// 
        /// <returns>The response from the CreateLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateLag">REST API Reference for CreateLag Operation</seealso>
        public virtual CreateLagResponse CreateLag(CreateLagRequest request)
        {
            var marshaller = new CreateLagRequestMarshaller();
            var unmarshaller = CreateLagResponseUnmarshaller.Instance;

            return Invoke<CreateLagRequest,CreateLagResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateLag">REST API Reference for CreateLag Operation</seealso>
        public virtual Task<CreateLagResponse> CreateLagAsync(CreateLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLagRequestMarshaller();
            var unmarshaller = CreateLagResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLagRequest,CreateLagResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePrivateVirtualInterface


        /// <summary>
        /// Creates a new private virtual interface. A virtual interface is the VLAN that transports
        /// AWS Direct Connect traffic. A private virtual interface supports sending traffic to
        /// a single virtual private cloud (VPC).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePrivateVirtualInterface">REST API Reference for CreatePrivateVirtualInterface Operation</seealso>
        public virtual CreatePrivateVirtualInterfaceResponse CreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest request)
        {
            var marshaller = new CreatePrivateVirtualInterfaceRequestMarshaller();
            var unmarshaller = CreatePrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreatePrivateVirtualInterfaceRequest,CreatePrivateVirtualInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePrivateVirtualInterface">REST API Reference for CreatePrivateVirtualInterface Operation</seealso>
        public virtual Task<CreatePrivateVirtualInterfaceResponse> CreatePrivateVirtualInterfaceAsync(CreatePrivateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePrivateVirtualInterfaceRequestMarshaller();
            var unmarshaller = CreatePrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePrivateVirtualInterfaceRequest,CreatePrivateVirtualInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePublicVirtualInterface


        /// <summary>
        /// Creates a new public virtual interface. A virtual interface is the VLAN that transports
        /// AWS Direct Connect traffic. A public virtual interface supports sending traffic to
        /// public services of AWS such as Amazon Simple Storage Service (Amazon S3).
        /// 
        ///  
        /// <para>
        /// When creating an IPv6 public virtual interface (addressFamily is 'ipv6'), the customer
        /// and amazon address fields should be left blank to use auto-assigned IPv6 space. Custom
        /// IPv6 Addresses are currently not supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePublicVirtualInterface">REST API Reference for CreatePublicVirtualInterface Operation</seealso>
        public virtual CreatePublicVirtualInterfaceResponse CreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest request)
        {
            var marshaller = new CreatePublicVirtualInterfaceRequestMarshaller();
            var unmarshaller = CreatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreatePublicVirtualInterfaceRequest,CreatePublicVirtualInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePublicVirtualInterface">REST API Reference for CreatePublicVirtualInterface Operation</seealso>
        public virtual Task<CreatePublicVirtualInterfaceResponse> CreatePublicVirtualInterfaceAsync(CreatePublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePublicVirtualInterfaceRequestMarshaller();
            var unmarshaller = CreatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePublicVirtualInterfaceRequest,CreatePublicVirtualInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBGPPeer


        /// <summary>
        /// Deletes a BGP peer on the specified virtual interface that matches the specified customer
        /// address and ASN. You cannot delete the last BGP peer from a virtual interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBGPPeer service method.</param>
        /// 
        /// <returns>The response from the DeleteBGPPeer service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteBGPPeer">REST API Reference for DeleteBGPPeer Operation</seealso>
        public virtual DeleteBGPPeerResponse DeleteBGPPeer(DeleteBGPPeerRequest request)
        {
            var marshaller = new DeleteBGPPeerRequestMarshaller();
            var unmarshaller = DeleteBGPPeerResponseUnmarshaller.Instance;

            return Invoke<DeleteBGPPeerRequest,DeleteBGPPeerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBGPPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBGPPeer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteBGPPeer">REST API Reference for DeleteBGPPeer Operation</seealso>
        public virtual Task<DeleteBGPPeerResponse> DeleteBGPPeerAsync(DeleteBGPPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBGPPeerRequestMarshaller();
            var unmarshaller = DeleteBGPPeerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBGPPeerRequest,DeleteBGPPeerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// Deletes the connection.
        /// 
        ///  
        /// <para>
        /// Deleting a connection only stops the AWS Direct Connect port hour and data transfer
        /// charges. You need to cancel separately with the providers any services or charges
        /// for cross-connects or network circuits that connect you to the AWS Direct Connect
        /// location.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var marshaller = new DeleteConnectionRequestMarshaller();
            var unmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionRequest,DeleteConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteConnectionRequestMarshaller();
            var unmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectionRequest,DeleteConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectConnectGateway


        /// <summary>
        /// Deletes a direct connect gateway. You must first delete all virtual interfaces that
        /// are attached to the direct connect gateway and disassociate all virtual private gateways
        /// that are associated with the direct connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGateway">REST API Reference for DeleteDirectConnectGateway Operation</seealso>
        public virtual DeleteDirectConnectGatewayResponse DeleteDirectConnectGateway(DeleteDirectConnectGatewayRequest request)
        {
            var marshaller = new DeleteDirectConnectGatewayRequestMarshaller();
            var unmarshaller = DeleteDirectConnectGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectConnectGatewayRequest,DeleteDirectConnectGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGateway">REST API Reference for DeleteDirectConnectGateway Operation</seealso>
        public virtual Task<DeleteDirectConnectGatewayResponse> DeleteDirectConnectGatewayAsync(DeleteDirectConnectGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDirectConnectGatewayRequestMarshaller();
            var unmarshaller = DeleteDirectConnectGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectConnectGatewayRequest,DeleteDirectConnectGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectConnectGatewayAssociation


        /// <summary>
        /// Deletes the association between a direct connect gateway and a virtual private gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociation">REST API Reference for DeleteDirectConnectGatewayAssociation Operation</seealso>
        public virtual DeleteDirectConnectGatewayAssociationResponse DeleteDirectConnectGatewayAssociation(DeleteDirectConnectGatewayAssociationRequest request)
        {
            var marshaller = new DeleteDirectConnectGatewayAssociationRequestMarshaller();
            var unmarshaller = DeleteDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectConnectGatewayAssociationRequest,DeleteDirectConnectGatewayAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociation">REST API Reference for DeleteDirectConnectGatewayAssociation Operation</seealso>
        public virtual Task<DeleteDirectConnectGatewayAssociationResponse> DeleteDirectConnectGatewayAssociationAsync(DeleteDirectConnectGatewayAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDirectConnectGatewayAssociationRequestMarshaller();
            var unmarshaller = DeleteDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectConnectGatewayAssociationRequest,DeleteDirectConnectGatewayAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteInterconnect


        /// <summary>
        /// Deletes the specified interconnect.
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect service method.</param>
        /// 
        /// <returns>The response from the DeleteInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteInterconnect">REST API Reference for DeleteInterconnect Operation</seealso>
        public virtual DeleteInterconnectResponse DeleteInterconnect(DeleteInterconnectRequest request)
        {
            var marshaller = new DeleteInterconnectRequestMarshaller();
            var unmarshaller = DeleteInterconnectResponseUnmarshaller.Instance;

            return Invoke<DeleteInterconnectRequest,DeleteInterconnectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteInterconnect">REST API Reference for DeleteInterconnect Operation</seealso>
        public virtual Task<DeleteInterconnectResponse> DeleteInterconnectAsync(DeleteInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteInterconnectRequestMarshaller();
            var unmarshaller = DeleteInterconnectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInterconnectRequest,DeleteInterconnectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLag


        /// <summary>
        /// Deletes a link aggregation group (LAG). You cannot delete a LAG if it has active virtual
        /// interfaces or hosted connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLag service method.</param>
        /// 
        /// <returns>The response from the DeleteLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteLag">REST API Reference for DeleteLag Operation</seealso>
        public virtual DeleteLagResponse DeleteLag(DeleteLagRequest request)
        {
            var marshaller = new DeleteLagRequestMarshaller();
            var unmarshaller = DeleteLagResponseUnmarshaller.Instance;

            return Invoke<DeleteLagRequest,DeleteLagResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteLag">REST API Reference for DeleteLag Operation</seealso>
        public virtual Task<DeleteLagResponse> DeleteLagAsync(DeleteLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLagRequestMarshaller();
            var unmarshaller = DeleteLagResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLagRequest,DeleteLagResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVirtualInterface


        /// <summary>
        /// Deletes a virtual interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteVirtualInterface">REST API Reference for DeleteVirtualInterface Operation</seealso>
        public virtual DeleteVirtualInterfaceResponse DeleteVirtualInterface(DeleteVirtualInterfaceRequest request)
        {
            var marshaller = new DeleteVirtualInterfaceRequestMarshaller();
            var unmarshaller = DeleteVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualInterfaceRequest,DeleteVirtualInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteVirtualInterface">REST API Reference for DeleteVirtualInterface Operation</seealso>
        public virtual Task<DeleteVirtualInterfaceResponse> DeleteVirtualInterfaceAsync(DeleteVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVirtualInterfaceRequestMarshaller();
            var unmarshaller = DeleteVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVirtualInterfaceRequest,DeleteVirtualInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectionLoa


        /// <summary>
        /// Deprecated in favor of <a>DescribeLoa</a>.
        /// 
        ///  
        /// <para>
        /// Returns the LOA-CFA for a Connection.
        /// </para>
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that your APN partner or service provider uses when establishing your cross connect
        /// to AWS at the colocation facility. For more information, see <a href="http://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at AWS Direct Connect Locations</a> in the AWS Direct Connect user
        /// guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionLoa service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectionLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionLoa">REST API Reference for DescribeConnectionLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        public virtual DescribeConnectionLoaResponse DescribeConnectionLoa(DescribeConnectionLoaRequest request)
        {
            var marshaller = new DescribeConnectionLoaRequestMarshaller();
            var unmarshaller = DescribeConnectionLoaResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionLoaRequest,DescribeConnectionLoaResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionLoa operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionLoa">REST API Reference for DescribeConnectionLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        public virtual Task<DescribeConnectionLoaResponse> DescribeConnectionLoaAsync(DescribeConnectionLoaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConnectionLoaRequestMarshaller();
            var unmarshaller = DescribeConnectionLoaResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConnectionLoaRequest,DescribeConnectionLoaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnections


        /// <summary>
        /// Displays all connections in this region.
        /// 
        ///  
        /// <para>
        /// If a connection ID is provided, the call returns only that particular connection.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual DescribeConnectionsResponse DescribeConnections()
        {
            return DescribeConnections(new DescribeConnectionsRequest());
        }


        /// <summary>
        /// Displays all connections in this region.
        /// 
        ///  
        /// <para>
        /// If a connection ID is provided, the call returns only that particular connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request)
        {
            var marshaller = new DescribeConnectionsRequestMarshaller();
            var unmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionsRequest,DescribeConnectionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Displays all connections in this region.
        /// 
        ///  
        /// <para>
        /// If a connection ID is provided, the call returns only that particular connection.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual Task<DescribeConnectionsResponse> DescribeConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeConnectionsAsync(new DescribeConnectionsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConnectionsRequestMarshaller();
            var unmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConnectionsRequest,DescribeConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectionsOnInterconnect


        /// <summary>
        /// Deprecated in favor of <a>DescribeHostedConnections</a>.
        /// 
        ///  
        /// <para>
        /// Returns a list of connections that have been provisioned on the given interconnect.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionsOnInterconnect service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectionsOnInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionsOnInterconnect">REST API Reference for DescribeConnectionsOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeHostedConnections.")]
        public virtual DescribeConnectionsOnInterconnectResponse DescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest request)
        {
            var marshaller = new DescribeConnectionsOnInterconnectRequestMarshaller();
            var unmarshaller = DescribeConnectionsOnInterconnectResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionsOnInterconnectRequest,DescribeConnectionsOnInterconnectResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionsOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionsOnInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionsOnInterconnect">REST API Reference for DescribeConnectionsOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeHostedConnections.")]
        public virtual Task<DescribeConnectionsOnInterconnectResponse> DescribeConnectionsOnInterconnectAsync(DescribeConnectionsOnInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConnectionsOnInterconnectRequestMarshaller();
            var unmarshaller = DescribeConnectionsOnInterconnectResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConnectionsOnInterconnectRequest,DescribeConnectionsOnInterconnectResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectConnectGatewayAssociations


        /// <summary>
        /// Returns a list of all direct connect gateway and virtual private gateway (VGW) associations.
        /// Either a direct connect gateway ID or a VGW ID must be provided in the request. If
        /// a direct connect gateway ID is provided, the response returns all VGWs associated
        /// with the direct connect gateway. If a VGW ID is provided, the response returns all
        /// direct connect gateways associated with the VGW. If both are provided, the response
        /// only returns the association that matches both the direct connect gateway and the
        /// VGW.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAssociations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociations">REST API Reference for DescribeDirectConnectGatewayAssociations Operation</seealso>
        public virtual DescribeDirectConnectGatewayAssociationsResponse DescribeDirectConnectGatewayAssociations(DescribeDirectConnectGatewayAssociationsRequest request)
        {
            var marshaller = new DescribeDirectConnectGatewayAssociationsRequestMarshaller();
            var unmarshaller = DescribeDirectConnectGatewayAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectConnectGatewayAssociationsRequest,DescribeDirectConnectGatewayAssociationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectConnectGatewayAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociations">REST API Reference for DescribeDirectConnectGatewayAssociations Operation</seealso>
        public virtual Task<DescribeDirectConnectGatewayAssociationsResponse> DescribeDirectConnectGatewayAssociationsAsync(DescribeDirectConnectGatewayAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDirectConnectGatewayAssociationsRequestMarshaller();
            var unmarshaller = DescribeDirectConnectGatewayAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectConnectGatewayAssociationsRequest,DescribeDirectConnectGatewayAssociationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectConnectGatewayAttachments


        /// <summary>
        /// Returns a list of all direct connect gateway and virtual interface (VIF) attachments.
        /// Either a direct connect gateway ID or a VIF ID must be provided in the request. If
        /// a direct connect gateway ID is provided, the response returns all VIFs attached to
        /// the direct connect gateway. If a VIF ID is provided, the response returns all direct
        /// connect gateways attached to the VIF. If both are provided, the response only returns
        /// the attachment that matches both the direct connect gateway and the VIF.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAttachments service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAttachments service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAttachments">REST API Reference for DescribeDirectConnectGatewayAttachments Operation</seealso>
        public virtual DescribeDirectConnectGatewayAttachmentsResponse DescribeDirectConnectGatewayAttachments(DescribeDirectConnectGatewayAttachmentsRequest request)
        {
            var marshaller = new DescribeDirectConnectGatewayAttachmentsRequestMarshaller();
            var unmarshaller = DescribeDirectConnectGatewayAttachmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectConnectGatewayAttachmentsRequest,DescribeDirectConnectGatewayAttachmentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectConnectGatewayAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAttachments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAttachments">REST API Reference for DescribeDirectConnectGatewayAttachments Operation</seealso>
        public virtual Task<DescribeDirectConnectGatewayAttachmentsResponse> DescribeDirectConnectGatewayAttachmentsAsync(DescribeDirectConnectGatewayAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDirectConnectGatewayAttachmentsRequestMarshaller();
            var unmarshaller = DescribeDirectConnectGatewayAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectConnectGatewayAttachmentsRequest,DescribeDirectConnectGatewayAttachmentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectConnectGateways


        /// <summary>
        /// Returns a list of direct connect gateways in your account. Deleted direct connect
        /// gateways are not returned. You can provide a direct connect gateway ID in the request
        /// to return information about the specific direct connect gateway only. Otherwise, if
        /// a direct connect gateway ID is not provided, information about all of your direct
        /// connect gateways is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGateways">REST API Reference for DescribeDirectConnectGateways Operation</seealso>
        public virtual DescribeDirectConnectGatewaysResponse DescribeDirectConnectGateways(DescribeDirectConnectGatewaysRequest request)
        {
            var marshaller = new DescribeDirectConnectGatewaysRequestMarshaller();
            var unmarshaller = DescribeDirectConnectGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectConnectGatewaysRequest,DescribeDirectConnectGatewaysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectConnectGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGateways">REST API Reference for DescribeDirectConnectGateways Operation</seealso>
        public virtual Task<DescribeDirectConnectGatewaysResponse> DescribeDirectConnectGatewaysAsync(DescribeDirectConnectGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDirectConnectGatewaysRequestMarshaller();
            var unmarshaller = DescribeDirectConnectGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectConnectGatewaysRequest,DescribeDirectConnectGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeHostedConnections


        /// <summary>
        /// Returns a list of hosted connections that have been provisioned on the given interconnect
        /// or link aggregation group (LAG).
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostedConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeHostedConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeHostedConnections">REST API Reference for DescribeHostedConnections Operation</seealso>
        public virtual DescribeHostedConnectionsResponse DescribeHostedConnections(DescribeHostedConnectionsRequest request)
        {
            var marshaller = new DescribeHostedConnectionsRequestMarshaller();
            var unmarshaller = DescribeHostedConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostedConnectionsRequest,DescribeHostedConnectionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostedConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostedConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeHostedConnections">REST API Reference for DescribeHostedConnections Operation</seealso>
        public virtual Task<DescribeHostedConnectionsResponse> DescribeHostedConnectionsAsync(DescribeHostedConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeHostedConnectionsRequestMarshaller();
            var unmarshaller = DescribeHostedConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHostedConnectionsRequest,DescribeHostedConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInterconnectLoa


        /// <summary>
        /// Deprecated in favor of <a>DescribeLoa</a>.
        /// 
        ///  
        /// <para>
        /// Returns the LOA-CFA for an Interconnect.
        /// </para>
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that is used when establishing your cross connect to AWS at the colocation facility.
        /// For more information, see <a href="http://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at AWS Direct Connect Locations</a> in the AWS Direct Connect user
        /// guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnectLoa service method.</param>
        /// 
        /// <returns>The response from the DescribeInterconnectLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnectLoa">REST API Reference for DescribeInterconnectLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        public virtual DescribeInterconnectLoaResponse DescribeInterconnectLoa(DescribeInterconnectLoaRequest request)
        {
            var marshaller = new DescribeInterconnectLoaRequestMarshaller();
            var unmarshaller = DescribeInterconnectLoaResponseUnmarshaller.Instance;

            return Invoke<DescribeInterconnectLoaRequest,DescribeInterconnectLoaResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInterconnectLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnectLoa operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnectLoa">REST API Reference for DescribeInterconnectLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        public virtual Task<DescribeInterconnectLoaResponse> DescribeInterconnectLoaAsync(DescribeInterconnectLoaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInterconnectLoaRequestMarshaller();
            var unmarshaller = DescribeInterconnectLoaResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInterconnectLoaRequest,DescribeInterconnectLoaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInterconnects


        /// <summary>
        /// Returns a list of interconnects owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// If an interconnect ID is provided, it will only return this particular interconnect.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        public virtual DescribeInterconnectsResponse DescribeInterconnects()
        {
            return DescribeInterconnects(new DescribeInterconnectsRequest());
        }


        /// <summary>
        /// Returns a list of interconnects owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// If an interconnect ID is provided, it will only return this particular interconnect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects service method.</param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        public virtual DescribeInterconnectsResponse DescribeInterconnects(DescribeInterconnectsRequest request)
        {
            var marshaller = new DescribeInterconnectsRequestMarshaller();
            var unmarshaller = DescribeInterconnectsResponseUnmarshaller.Instance;

            return Invoke<DescribeInterconnectsRequest,DescribeInterconnectsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a list of interconnects owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// If an interconnect ID is provided, it will only return this particular interconnect.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        public virtual Task<DescribeInterconnectsResponse> DescribeInterconnectsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInterconnectsAsync(new DescribeInterconnectsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInterconnects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        public virtual Task<DescribeInterconnectsResponse> DescribeInterconnectsAsync(DescribeInterconnectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInterconnectsRequestMarshaller();
            var unmarshaller = DescribeInterconnectsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInterconnectsRequest,DescribeInterconnectsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLags


        /// <summary>
        /// Describes the link aggregation groups (LAGs) in your account. 
        /// 
        ///  
        /// <para>
        /// If a LAG ID is provided, only information about the specified LAG is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLags service method.</param>
        /// 
        /// <returns>The response from the DescribeLags service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLags">REST API Reference for DescribeLags Operation</seealso>
        public virtual DescribeLagsResponse DescribeLags(DescribeLagsRequest request)
        {
            var marshaller = new DescribeLagsRequestMarshaller();
            var unmarshaller = DescribeLagsResponseUnmarshaller.Instance;

            return Invoke<DescribeLagsRequest,DescribeLagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLags">REST API Reference for DescribeLags Operation</seealso>
        public virtual Task<DescribeLagsResponse> DescribeLagsAsync(DescribeLagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLagsRequestMarshaller();
            var unmarshaller = DescribeLagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLagsRequest,DescribeLagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoa


        /// <summary>
        /// Returns the LOA-CFA for a connection, interconnect, or link aggregation group (LAG).
        /// 
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that is used when establishing your cross connect to AWS at the colocation facility.
        /// For more information, see <a href="http://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at AWS Direct Connect Locations</a> in the AWS Direct Connect user
        /// guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoa service method.</param>
        /// 
        /// <returns>The response from the DescribeLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLoa">REST API Reference for DescribeLoa Operation</seealso>
        public virtual DescribeLoaResponse DescribeLoa(DescribeLoaRequest request)
        {
            var marshaller = new DescribeLoaRequestMarshaller();
            var unmarshaller = DescribeLoaResponseUnmarshaller.Instance;

            return Invoke<DescribeLoaRequest,DescribeLoaResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoa operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLoa">REST API Reference for DescribeLoa Operation</seealso>
        public virtual Task<DescribeLoaResponse> DescribeLoaAsync(DescribeLoaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoaRequestMarshaller();
            var unmarshaller = DescribeLoaResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoaRequest,DescribeLoaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocations


        /// <summary>
        /// Returns the list of AWS Direct Connect locations in the current AWS region. These
        /// are the locations that may be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        public virtual DescribeLocationsResponse DescribeLocations()
        {
            return DescribeLocations(new DescribeLocationsRequest());
        }


        /// <summary>
        /// Returns the list of AWS Direct Connect locations in the current AWS region. These
        /// are the locations that may be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations service method.</param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        public virtual DescribeLocationsResponse DescribeLocations(DescribeLocationsRequest request)
        {
            var marshaller = new DescribeLocationsRequestMarshaller();
            var unmarshaller = DescribeLocationsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationsRequest,DescribeLocationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the list of AWS Direct Connect locations in the current AWS region. These
        /// are the locations that may be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        public virtual Task<DescribeLocationsResponse> DescribeLocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLocationsAsync(new DescribeLocationsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        public virtual Task<DescribeLocationsResponse> DescribeLocationsAsync(DescribeLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLocationsRequestMarshaller();
            var unmarshaller = DescribeLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationsRequest,DescribeLocationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes the tags associated with the specified Direct Connect resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVirtualGateways


        /// <summary>
        /// Returns a list of virtual private gateways owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// You can create one or more AWS Direct Connect private virtual interfaces linking to
        /// a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual
        /// Private Cloud (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html">EC2
        /// CreateVpnGateway</a> action.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        public virtual DescribeVirtualGatewaysResponse DescribeVirtualGateways()
        {
            return DescribeVirtualGateways(new DescribeVirtualGatewaysRequest());
        }


        /// <summary>
        /// Returns a list of virtual private gateways owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// You can create one or more AWS Direct Connect private virtual interfaces linking to
        /// a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual
        /// Private Cloud (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html">EC2
        /// CreateVpnGateway</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        public virtual DescribeVirtualGatewaysResponse DescribeVirtualGateways(DescribeVirtualGatewaysRequest request)
        {
            var marshaller = new DescribeVirtualGatewaysRequestMarshaller();
            var unmarshaller = DescribeVirtualGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualGatewaysRequest,DescribeVirtualGatewaysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a list of virtual private gateways owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// You can create one or more AWS Direct Connect private virtual interfaces linking to
        /// a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual
        /// Private Cloud (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html">EC2
        /// CreateVpnGateway</a> action.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        public virtual Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVirtualGatewaysAsync(new DescribeVirtualGatewaysRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        public virtual Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(DescribeVirtualGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVirtualGatewaysRequestMarshaller();
            var unmarshaller = DescribeVirtualGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVirtualGatewaysRequest,DescribeVirtualGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVirtualInterfaces


        /// <summary>
        /// Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer
        /// than 15 minutes before you make the request are also returned. If you specify a connection
        /// ID, only the virtual interfaces associated with the connection are returned. If you
        /// specify a virtual interface ID, then only a single virtual interface is returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the AWS Direct Connect location
        /// and the customer.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        public virtual DescribeVirtualInterfacesResponse DescribeVirtualInterfaces()
        {
            return DescribeVirtualInterfaces(new DescribeVirtualInterfacesRequest());
        }


        /// <summary>
        /// Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer
        /// than 15 minutes before you make the request are also returned. If you specify a connection
        /// ID, only the virtual interfaces associated with the connection are returned. If you
        /// specify a virtual interface ID, then only a single virtual interface is returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the AWS Direct Connect location
        /// and the customer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        public virtual DescribeVirtualInterfacesResponse DescribeVirtualInterfaces(DescribeVirtualInterfacesRequest request)
        {
            var marshaller = new DescribeVirtualInterfacesRequestMarshaller();
            var unmarshaller = DescribeVirtualInterfacesResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualInterfacesRequest,DescribeVirtualInterfacesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer
        /// than 15 minutes before you make the request are also returned. If you specify a connection
        /// ID, only the virtual interfaces associated with the connection are returned. If you
        /// specify a virtual interface ID, then only a single virtual interface is returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the AWS Direct Connect location
        /// and the customer.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        public virtual Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVirtualInterfacesAsync(new DescribeVirtualInterfacesRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        public virtual Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(DescribeVirtualInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVirtualInterfacesRequestMarshaller();
            var unmarshaller = DescribeVirtualInterfacesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVirtualInterfacesRequest,DescribeVirtualInterfacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateConnectionFromLag


        /// <summary>
        /// Disassociates a connection from a link aggregation group (LAG). The connection is
        /// interrupted and re-established as a standalone connection (the connection is not deleted;
        /// to delete the connection, use the <a>DeleteConnection</a> request). If the LAG has
        /// associated virtual interfaces or hosted connections, they remain associated with the
        /// LAG. A disassociated connection owned by an AWS Direct Connect partner is automatically
        /// converted to an interconnect.
        /// 
        ///  
        /// <para>
        /// If disassociating the connection will cause the LAG to fall below its setting for
        /// minimum number of operational connections, the request fails, except when it's the
        /// last member of the LAG. If all connections are disassociated, the LAG continues to
        /// exist as an empty LAG with no physical connections. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectionFromLag service method.</param>
        /// 
        /// <returns>The response from the DisassociateConnectionFromLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateConnectionFromLag">REST API Reference for DisassociateConnectionFromLag Operation</seealso>
        public virtual DisassociateConnectionFromLagResponse DisassociateConnectionFromLag(DisassociateConnectionFromLagRequest request)
        {
            var marshaller = new DisassociateConnectionFromLagRequestMarshaller();
            var unmarshaller = DisassociateConnectionFromLagResponseUnmarshaller.Instance;

            return Invoke<DisassociateConnectionFromLagRequest,DisassociateConnectionFromLagResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConnectionFromLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectionFromLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateConnectionFromLag">REST API Reference for DisassociateConnectionFromLag Operation</seealso>
        public virtual Task<DisassociateConnectionFromLagResponse> DisassociateConnectionFromLagAsync(DisassociateConnectionFromLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateConnectionFromLagRequestMarshaller();
            var unmarshaller = DisassociateConnectionFromLagResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateConnectionFromLagRequest,DisassociateConnectionFromLagResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified Direct Connect resource. Each Direct Connect
        /// resource can have a maximum of 50 tags.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a tag with the same key is already
        /// associated with the Direct Connect resource, this action updates its value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned to a Direct
        /// Connect resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = new TagResourceRequestMarshaller();
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TagResourceRequestMarshaller();
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified Direct Connect resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = new UntagResourceRequestMarshaller();
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UntagResourceRequestMarshaller();
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateLag


        /// <summary>
        /// Updates the attributes of a link aggregation group (LAG). 
        /// 
        ///  
        /// <para>
        /// You can update the following attributes: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The name of the LAG.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value for the minimum number of connections that must be operational for the LAG
        /// itself to be operational. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you create a LAG, the default value for the minimum number of operational connections
        /// is zero (0). If you update this value, and the number of operational connections falls
        /// below the specified value, the LAG will automatically go down to avoid overutilization
        /// of the remaining connections. Adjusting this value should be done with care as it
        /// could force the LAG down if the value is set higher than the current number of operational
        /// connections.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLag service method.</param>
        /// 
        /// <returns>The response from the UpdateLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// The API was called with invalid parameters. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred during the API call. The error message will contain additional
        /// details about the cause.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateLag">REST API Reference for UpdateLag Operation</seealso>
        public virtual UpdateLagResponse UpdateLag(UpdateLagRequest request)
        {
            var marshaller = new UpdateLagRequestMarshaller();
            var unmarshaller = UpdateLagResponseUnmarshaller.Instance;

            return Invoke<UpdateLagRequest,UpdateLagResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateLag">REST API Reference for UpdateLag Operation</seealso>
        public virtual Task<UpdateLagResponse> UpdateLagAsync(UpdateLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateLagRequestMarshaller();
            var unmarshaller = UpdateLagResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLagRequest,UpdateLagResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}