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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.AlexaForBusiness.Model;
using Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AlexaForBusiness
{
    /// <summary>
    /// Implementation for accessing AlexaForBusiness
    ///
    /// Alexa for Business makes it easy for you to use Alexa in your organization. Alexa
    /// for Business gives you the tools you need to manage Alexa devices, enroll your users,
    /// and assign skills, at scale. You can build your own context-aware voice skills using
    /// the Alexa Skills Kit, and the Alexa for Business APIs, and you can make these available
    /// as private skills for your organization. Alexa for Business also makes it easy to
    /// voice-enable your products and services, providing context-aware voice experiences
    /// for your customers.
    /// </summary>
    public partial class AmazonAlexaForBusinessClient : AmazonServiceClient, IAmazonAlexaForBusiness
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with the credentials loaded from the application's
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
        public AmazonAlexaForBusinessClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAlexaForBusinessConfig()) { }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with the credentials loaded from the application's
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
        public AmazonAlexaForBusinessClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAlexaForBusinessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAlexaForBusinessClient Configuration Object</param>
        public AmazonAlexaForBusinessClient(AmazonAlexaForBusinessConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAlexaForBusinessClient(AWSCredentials credentials)
            : this(credentials, new AmazonAlexaForBusinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAlexaForBusinessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAlexaForBusinessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Credentials and an
        /// AmazonAlexaForBusinessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAlexaForBusinessClient Configuration Object</param>
        public AmazonAlexaForBusinessClient(AWSCredentials credentials, AmazonAlexaForBusinessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAlexaForBusinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAlexaForBusinessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAlexaForBusinessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAlexaForBusinessClient Configuration Object</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAlexaForBusinessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAlexaForBusinessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAlexaForBusinessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAlexaForBusinessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAlexaForBusinessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAlexaForBusinessClient Configuration Object</param>
        public AmazonAlexaForBusinessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAlexaForBusinessConfig clientConfig)
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

        
        #region  AssociateDeviceWithRoom

        /// <summary>
        /// Associates a device to a given room. This applies all the settings from the room profile
        /// to the device, and all the skills in any skill groups added to that room. This operation
        /// requires the device to be online, or a manual sync is required.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDeviceWithRoom service method.</param>
        /// 
        /// <returns>The response from the AssociateDeviceWithRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits. HTTP
        /// Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateDeviceWithRoom">REST API Reference for AssociateDeviceWithRoom Operation</seealso>
        public virtual AssociateDeviceWithRoomResponse AssociateDeviceWithRoom(AssociateDeviceWithRoomRequest request)
        {
            var marshaller = new AssociateDeviceWithRoomRequestMarshaller();
            var unmarshaller = AssociateDeviceWithRoomResponseUnmarshaller.Instance;

            return Invoke<AssociateDeviceWithRoomRequest,AssociateDeviceWithRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDeviceWithRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDeviceWithRoom operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDeviceWithRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateDeviceWithRoom">REST API Reference for AssociateDeviceWithRoom Operation</seealso>
        public virtual IAsyncResult BeginAssociateDeviceWithRoom(AssociateDeviceWithRoomRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateDeviceWithRoomRequestMarshaller();
            var unmarshaller = AssociateDeviceWithRoomResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateDeviceWithRoomRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDeviceWithRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDeviceWithRoom.</param>
        /// 
        /// <returns>Returns a  AssociateDeviceWithRoomResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateDeviceWithRoom">REST API Reference for AssociateDeviceWithRoom Operation</seealso>
        public virtual AssociateDeviceWithRoomResponse EndAssociateDeviceWithRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDeviceWithRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateSkillGroupWithRoom

        /// <summary>
        /// Associates a skill group to a given room. This enables all skills in the associated
        /// skill group on all devices in the room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSkillGroupWithRoom service method.</param>
        /// 
        /// <returns>The response from the AssociateSkillGroupWithRoom service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillGroupWithRoom">REST API Reference for AssociateSkillGroupWithRoom Operation</seealso>
        public virtual AssociateSkillGroupWithRoomResponse AssociateSkillGroupWithRoom(AssociateSkillGroupWithRoomRequest request)
        {
            var marshaller = new AssociateSkillGroupWithRoomRequestMarshaller();
            var unmarshaller = AssociateSkillGroupWithRoomResponseUnmarshaller.Instance;

            return Invoke<AssociateSkillGroupWithRoomRequest,AssociateSkillGroupWithRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSkillGroupWithRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSkillGroupWithRoom operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSkillGroupWithRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillGroupWithRoom">REST API Reference for AssociateSkillGroupWithRoom Operation</seealso>
        public virtual IAsyncResult BeginAssociateSkillGroupWithRoom(AssociateSkillGroupWithRoomRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateSkillGroupWithRoomRequestMarshaller();
            var unmarshaller = AssociateSkillGroupWithRoomResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateSkillGroupWithRoomRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSkillGroupWithRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSkillGroupWithRoom.</param>
        /// 
        /// <returns>Returns a  AssociateSkillGroupWithRoomResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/AssociateSkillGroupWithRoom">REST API Reference for AssociateSkillGroupWithRoom Operation</seealso>
        public virtual AssociateSkillGroupWithRoomResponse EndAssociateSkillGroupWithRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateSkillGroupWithRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProfile

        /// <summary>
        /// Creates a new room profile with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists. HTTP Status Code: 400
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits. HTTP
        /// Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual CreateProfileResponse CreateProfile(CreateProfileRequest request)
        {
            var marshaller = new CreateProfileRequestMarshaller();
            var unmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProfileRequest,CreateProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateProfile(CreateProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateProfileRequestMarshaller();
            var unmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return BeginInvoke<CreateProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProfile.</param>
        /// 
        /// <returns>Returns a  CreateProfileResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual CreateProfileResponse EndCreateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRoom

        /// <summary>
        /// Creates a room with the specified details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom service method.</param>
        /// 
        /// <returns>The response from the CreateRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists. HTTP Status Code: 400
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits. HTTP
        /// Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        public virtual CreateRoomResponse CreateRoom(CreateRoomRequest request)
        {
            var marshaller = new CreateRoomRequestMarshaller();
            var unmarshaller = CreateRoomResponseUnmarshaller.Instance;

            return Invoke<CreateRoomRequest,CreateRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        public virtual IAsyncResult BeginCreateRoom(CreateRoomRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateRoomRequestMarshaller();
            var unmarshaller = CreateRoomResponseUnmarshaller.Instance;

            return BeginInvoke<CreateRoomRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoom.</param>
        /// 
        /// <returns>Returns a  CreateRoomResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        public virtual CreateRoomResponse EndCreateRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSkillGroup

        /// <summary>
        /// Creates a skill group with a specified name and description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSkillGroup service method.</param>
        /// 
        /// <returns>The response from the CreateSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.AlreadyExistsException">
        /// The resource being created already exists. HTTP Status Code: 400
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits. HTTP
        /// Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateSkillGroup">REST API Reference for CreateSkillGroup Operation</seealso>
        public virtual CreateSkillGroupResponse CreateSkillGroup(CreateSkillGroupRequest request)
        {
            var marshaller = new CreateSkillGroupRequestMarshaller();
            var unmarshaller = CreateSkillGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSkillGroupRequest,CreateSkillGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSkillGroup operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSkillGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateSkillGroup">REST API Reference for CreateSkillGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateSkillGroup(CreateSkillGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateSkillGroupRequestMarshaller();
            var unmarshaller = CreateSkillGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSkillGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSkillGroup.</param>
        /// 
        /// <returns>Returns a  CreateSkillGroupResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateSkillGroup">REST API Reference for CreateSkillGroup Operation</seealso>
        public virtual CreateSkillGroupResponse EndCreateSkillGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSkillGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUser

        /// <summary>
        /// Creates a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.LimitExceededException">
        /// You are performing an action that would put you beyond your account's limits. HTTP
        /// Status Code: 400
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.ResourceInUseException">
        /// The resource in the request is already in use. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var marshaller = new CreateUserRequestMarshaller();
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserRequest,CreateUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateUserRequestMarshaller();
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return BeginInvoke<CreateUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProfile

        /// <summary>
        /// Deletes a room profile by the profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
        {
            var marshaller = new DeleteProfileRequestMarshaller();
            var unmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileRequest,DeleteProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteProfile(DeleteProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteProfileRequestMarshaller();
            var unmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfile.</param>
        /// 
        /// <returns>Returns a  DeleteProfileResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual DeleteProfileResponse EndDeleteProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRoom

        /// <summary>
        /// Deletes a room by the room ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom service method.</param>
        /// 
        /// <returns>The response from the DeleteRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        public virtual DeleteRoomResponse DeleteRoom(DeleteRoomRequest request)
        {
            var marshaller = new DeleteRoomRequestMarshaller();
            var unmarshaller = DeleteRoomResponseUnmarshaller.Instance;

            return Invoke<DeleteRoomRequest,DeleteRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        public virtual IAsyncResult BeginDeleteRoom(DeleteRoomRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteRoomRequestMarshaller();
            var unmarshaller = DeleteRoomResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRoomRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoom.</param>
        /// 
        /// <returns>Returns a  DeleteRoomResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        public virtual DeleteRoomResponse EndDeleteRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRoomSkillParameter

        /// <summary>
        /// Deletes room skill parameter details by room, skill, and parameter key ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoomSkillParameter service method.</param>
        /// 
        /// <returns>The response from the DeleteRoomSkillParameter service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoomSkillParameter">REST API Reference for DeleteRoomSkillParameter Operation</seealso>
        public virtual DeleteRoomSkillParameterResponse DeleteRoomSkillParameter(DeleteRoomSkillParameterRequest request)
        {
            var marshaller = new DeleteRoomSkillParameterRequestMarshaller();
            var unmarshaller = DeleteRoomSkillParameterResponseUnmarshaller.Instance;

            return Invoke<DeleteRoomSkillParameterRequest,DeleteRoomSkillParameterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoomSkillParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoomSkillParameter operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoomSkillParameter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoomSkillParameter">REST API Reference for DeleteRoomSkillParameter Operation</seealso>
        public virtual IAsyncResult BeginDeleteRoomSkillParameter(DeleteRoomSkillParameterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteRoomSkillParameterRequestMarshaller();
            var unmarshaller = DeleteRoomSkillParameterResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRoomSkillParameterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoomSkillParameter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoomSkillParameter.</param>
        /// 
        /// <returns>Returns a  DeleteRoomSkillParameterResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteRoomSkillParameter">REST API Reference for DeleteRoomSkillParameter Operation</seealso>
        public virtual DeleteRoomSkillParameterResponse EndDeleteRoomSkillParameter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRoomSkillParameterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSkillGroup

        /// <summary>
        /// Deletes a skill group by skill group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSkillGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteSkillGroup">REST API Reference for DeleteSkillGroup Operation</seealso>
        public virtual DeleteSkillGroupResponse DeleteSkillGroup(DeleteSkillGroupRequest request)
        {
            var marshaller = new DeleteSkillGroupRequestMarshaller();
            var unmarshaller = DeleteSkillGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSkillGroupRequest,DeleteSkillGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSkillGroup operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSkillGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteSkillGroup">REST API Reference for DeleteSkillGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteSkillGroup(DeleteSkillGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteSkillGroupRequestMarshaller();
            var unmarshaller = DeleteSkillGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSkillGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSkillGroup.</param>
        /// 
        /// <returns>Returns a  DeleteSkillGroupResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteSkillGroup">REST API Reference for DeleteSkillGroup Operation</seealso>
        public virtual DeleteSkillGroupResponse EndDeleteSkillGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSkillGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUser

        /// <summary>
        /// Deletes a specified user by user ARN and enrollment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var marshaller = new DeleteUserRequestMarshaller();
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserRequest,DeleteUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteUserRequestMarshaller();
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateDeviceFromRoom

        /// <summary>
        /// Disassociates a device from its current room. The device continues to be connected
        /// to the Wi-Fi network and is still registered to the account. The device settings and
        /// skills are removed from the room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDeviceFromRoom service method.</param>
        /// 
        /// <returns>The response from the DisassociateDeviceFromRoom service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateDeviceFromRoom">REST API Reference for DisassociateDeviceFromRoom Operation</seealso>
        public virtual DisassociateDeviceFromRoomResponse DisassociateDeviceFromRoom(DisassociateDeviceFromRoomRequest request)
        {
            var marshaller = new DisassociateDeviceFromRoomRequestMarshaller();
            var unmarshaller = DisassociateDeviceFromRoomResponseUnmarshaller.Instance;

            return Invoke<DisassociateDeviceFromRoomRequest,DisassociateDeviceFromRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDeviceFromRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDeviceFromRoom operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDeviceFromRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateDeviceFromRoom">REST API Reference for DisassociateDeviceFromRoom Operation</seealso>
        public virtual IAsyncResult BeginDisassociateDeviceFromRoom(DisassociateDeviceFromRoomRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateDeviceFromRoomRequestMarshaller();
            var unmarshaller = DisassociateDeviceFromRoomResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateDeviceFromRoomRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDeviceFromRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDeviceFromRoom.</param>
        /// 
        /// <returns>Returns a  DisassociateDeviceFromRoomResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateDeviceFromRoom">REST API Reference for DisassociateDeviceFromRoom Operation</seealso>
        public virtual DisassociateDeviceFromRoomResponse EndDisassociateDeviceFromRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateDeviceFromRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateSkillGroupFromRoom

        /// <summary>
        /// Disassociates a skill group from a specified room. This disables all skills in the
        /// skill group on all devices in the room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSkillGroupFromRoom service method.</param>
        /// 
        /// <returns>The response from the DisassociateSkillGroupFromRoom service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillGroupFromRoom">REST API Reference for DisassociateSkillGroupFromRoom Operation</seealso>
        public virtual DisassociateSkillGroupFromRoomResponse DisassociateSkillGroupFromRoom(DisassociateSkillGroupFromRoomRequest request)
        {
            var marshaller = new DisassociateSkillGroupFromRoomRequestMarshaller();
            var unmarshaller = DisassociateSkillGroupFromRoomResponseUnmarshaller.Instance;

            return Invoke<DisassociateSkillGroupFromRoomRequest,DisassociateSkillGroupFromRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSkillGroupFromRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSkillGroupFromRoom operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSkillGroupFromRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillGroupFromRoom">REST API Reference for DisassociateSkillGroupFromRoom Operation</seealso>
        public virtual IAsyncResult BeginDisassociateSkillGroupFromRoom(DisassociateSkillGroupFromRoomRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateSkillGroupFromRoomRequestMarshaller();
            var unmarshaller = DisassociateSkillGroupFromRoomResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateSkillGroupFromRoomRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSkillGroupFromRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSkillGroupFromRoom.</param>
        /// 
        /// <returns>Returns a  DisassociateSkillGroupFromRoomResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/DisassociateSkillGroupFromRoom">REST API Reference for DisassociateSkillGroupFromRoom Operation</seealso>
        public virtual DisassociateSkillGroupFromRoomResponse EndDisassociateSkillGroupFromRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateSkillGroupFromRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevice

        /// <summary>
        /// Gets the details of a device by device ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var marshaller = new GetDeviceRequestMarshaller();
            var unmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceRequest,GetDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual IAsyncResult BeginGetDevice(GetDeviceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDeviceRequestMarshaller();
            var unmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeviceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevice.</param>
        /// 
        /// <returns>Returns a  GetDeviceResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual GetDeviceResponse EndGetDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProfile

        /// <summary>
        /// Gets the details of a room profile by profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual GetProfileResponse GetProfile(GetProfileRequest request)
        {
            var marshaller = new GetProfileRequestMarshaller();
            var unmarshaller = GetProfileResponseUnmarshaller.Instance;

            return Invoke<GetProfileRequest,GetProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfile operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual IAsyncResult BeginGetProfile(GetProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetProfileRequestMarshaller();
            var unmarshaller = GetProfileResponseUnmarshaller.Instance;

            return BeginInvoke<GetProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfile.</param>
        /// 
        /// <returns>Returns a  GetProfileResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual GetProfileResponse EndGetProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRoom

        /// <summary>
        /// Gets room details by room ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoom service method.</param>
        /// 
        /// <returns>The response from the GetRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoom">REST API Reference for GetRoom Operation</seealso>
        public virtual GetRoomResponse GetRoom(GetRoomRequest request)
        {
            var marshaller = new GetRoomRequestMarshaller();
            var unmarshaller = GetRoomResponseUnmarshaller.Instance;

            return Invoke<GetRoomRequest,GetRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoom operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoom">REST API Reference for GetRoom Operation</seealso>
        public virtual IAsyncResult BeginGetRoom(GetRoomRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetRoomRequestMarshaller();
            var unmarshaller = GetRoomResponseUnmarshaller.Instance;

            return BeginInvoke<GetRoomRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoom.</param>
        /// 
        /// <returns>Returns a  GetRoomResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoom">REST API Reference for GetRoom Operation</seealso>
        public virtual GetRoomResponse EndGetRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRoomSkillParameter

        /// <summary>
        /// Gets room skill parameter details by room, skill, and parameter key ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoomSkillParameter service method.</param>
        /// 
        /// <returns>The response from the GetRoomSkillParameter service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoomSkillParameter">REST API Reference for GetRoomSkillParameter Operation</seealso>
        public virtual GetRoomSkillParameterResponse GetRoomSkillParameter(GetRoomSkillParameterRequest request)
        {
            var marshaller = new GetRoomSkillParameterRequestMarshaller();
            var unmarshaller = GetRoomSkillParameterResponseUnmarshaller.Instance;

            return Invoke<GetRoomSkillParameterRequest,GetRoomSkillParameterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoomSkillParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoomSkillParameter operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoomSkillParameter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoomSkillParameter">REST API Reference for GetRoomSkillParameter Operation</seealso>
        public virtual IAsyncResult BeginGetRoomSkillParameter(GetRoomSkillParameterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetRoomSkillParameterRequestMarshaller();
            var unmarshaller = GetRoomSkillParameterResponseUnmarshaller.Instance;

            return BeginInvoke<GetRoomSkillParameterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoomSkillParameter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoomSkillParameter.</param>
        /// 
        /// <returns>Returns a  GetRoomSkillParameterResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetRoomSkillParameter">REST API Reference for GetRoomSkillParameter Operation</seealso>
        public virtual GetRoomSkillParameterResponse EndGetRoomSkillParameter(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRoomSkillParameterResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSkillGroup

        /// <summary>
        /// Gets skill group details by skill group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSkillGroup service method.</param>
        /// 
        /// <returns>The response from the GetSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetSkillGroup">REST API Reference for GetSkillGroup Operation</seealso>
        public virtual GetSkillGroupResponse GetSkillGroup(GetSkillGroupRequest request)
        {
            var marshaller = new GetSkillGroupRequestMarshaller();
            var unmarshaller = GetSkillGroupResponseUnmarshaller.Instance;

            return Invoke<GetSkillGroupRequest,GetSkillGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSkillGroup operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSkillGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetSkillGroup">REST API Reference for GetSkillGroup Operation</seealso>
        public virtual IAsyncResult BeginGetSkillGroup(GetSkillGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetSkillGroupRequestMarshaller();
            var unmarshaller = GetSkillGroupResponseUnmarshaller.Instance;

            return BeginInvoke<GetSkillGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSkillGroup.</param>
        /// 
        /// <returns>Returns a  GetSkillGroupResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/GetSkillGroup">REST API Reference for GetSkillGroup Operation</seealso>
        public virtual GetSkillGroupResponse EndGetSkillGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSkillGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSkills

        /// <summary>
        /// Lists all enabled skills in a specific skill group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSkills service method.</param>
        /// 
        /// <returns>The response from the ListSkills service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkills">REST API Reference for ListSkills Operation</seealso>
        public virtual ListSkillsResponse ListSkills(ListSkillsRequest request)
        {
            var marshaller = new ListSkillsRequestMarshaller();
            var unmarshaller = ListSkillsResponseUnmarshaller.Instance;

            return Invoke<ListSkillsRequest,ListSkillsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSkills operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSkills operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSkills
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkills">REST API Reference for ListSkills Operation</seealso>
        public virtual IAsyncResult BeginListSkills(ListSkillsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListSkillsRequestMarshaller();
            var unmarshaller = ListSkillsResponseUnmarshaller.Instance;

            return BeginInvoke<ListSkillsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSkills operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSkills.</param>
        /// 
        /// <returns>Returns a  ListSkillsResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListSkills">REST API Reference for ListSkills Operation</seealso>
        public virtual ListSkillsResponse EndListSkills(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSkillsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTags

        /// <summary>
        /// Lists all tags for a specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var marshaller = new ListTagsRequestMarshaller();
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsRequest,ListTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTagsRequestMarshaller();
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse EndListTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRoomSkillParameter

        /// <summary>
        /// Updates room skill parameter details by room, skill, and parameter key ID. Not all
        /// skills have a room skill parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRoomSkillParameter service method.</param>
        /// 
        /// <returns>The response from the PutRoomSkillParameter service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutRoomSkillParameter">REST API Reference for PutRoomSkillParameter Operation</seealso>
        public virtual PutRoomSkillParameterResponse PutRoomSkillParameter(PutRoomSkillParameterRequest request)
        {
            var marshaller = new PutRoomSkillParameterRequestMarshaller();
            var unmarshaller = PutRoomSkillParameterResponseUnmarshaller.Instance;

            return Invoke<PutRoomSkillParameterRequest,PutRoomSkillParameterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRoomSkillParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRoomSkillParameter operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRoomSkillParameter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutRoomSkillParameter">REST API Reference for PutRoomSkillParameter Operation</seealso>
        public virtual IAsyncResult BeginPutRoomSkillParameter(PutRoomSkillParameterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutRoomSkillParameterRequestMarshaller();
            var unmarshaller = PutRoomSkillParameterResponseUnmarshaller.Instance;

            return BeginInvoke<PutRoomSkillParameterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRoomSkillParameter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRoomSkillParameter.</param>
        /// 
        /// <returns>Returns a  PutRoomSkillParameterResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/PutRoomSkillParameter">REST API Reference for PutRoomSkillParameter Operation</seealso>
        public virtual PutRoomSkillParameterResponse EndPutRoomSkillParameter(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRoomSkillParameterResponse>(asyncResult);
        }

        #endregion
        
        #region  ResolveRoom

        /// <summary>
        /// Determines the details for the room from which a skill request was invoked. This operation
        /// is used by skill developers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveRoom service method.</param>
        /// 
        /// <returns>The response from the ResolveRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ResolveRoom">REST API Reference for ResolveRoom Operation</seealso>
        public virtual ResolveRoomResponse ResolveRoom(ResolveRoomRequest request)
        {
            var marshaller = new ResolveRoomRequestMarshaller();
            var unmarshaller = ResolveRoomResponseUnmarshaller.Instance;

            return Invoke<ResolveRoomRequest,ResolveRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveRoom operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResolveRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ResolveRoom">REST API Reference for ResolveRoom Operation</seealso>
        public virtual IAsyncResult BeginResolveRoom(ResolveRoomRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ResolveRoomRequestMarshaller();
            var unmarshaller = ResolveRoomResponseUnmarshaller.Instance;

            return BeginInvoke<ResolveRoomRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResolveRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResolveRoom.</param>
        /// 
        /// <returns>Returns a  ResolveRoomResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/ResolveRoom">REST API Reference for ResolveRoom Operation</seealso>
        public virtual ResolveRoomResponse EndResolveRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<ResolveRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeInvitation

        /// <summary>
        /// Revokes an invitation and invalidates the enrollment URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeInvitation service method.</param>
        /// 
        /// <returns>The response from the RevokeInvitation service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RevokeInvitation">REST API Reference for RevokeInvitation Operation</seealso>
        public virtual RevokeInvitationResponse RevokeInvitation(RevokeInvitationRequest request)
        {
            var marshaller = new RevokeInvitationRequestMarshaller();
            var unmarshaller = RevokeInvitationResponseUnmarshaller.Instance;

            return Invoke<RevokeInvitationRequest,RevokeInvitationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeInvitation operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RevokeInvitation">REST API Reference for RevokeInvitation Operation</seealso>
        public virtual IAsyncResult BeginRevokeInvitation(RevokeInvitationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RevokeInvitationRequestMarshaller();
            var unmarshaller = RevokeInvitationResponseUnmarshaller.Instance;

            return BeginInvoke<RevokeInvitationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeInvitation.</param>
        /// 
        /// <returns>Returns a  RevokeInvitationResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/RevokeInvitation">REST API Reference for RevokeInvitation Operation</seealso>
        public virtual RevokeInvitationResponse EndRevokeInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchDevices

        /// <summary>
        /// Searches devices and lists the ones that meet a set of filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDevices service method.</param>
        /// 
        /// <returns>The response from the SearchDevices service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchDevices">REST API Reference for SearchDevices Operation</seealso>
        public virtual SearchDevicesResponse SearchDevices(SearchDevicesRequest request)
        {
            var marshaller = new SearchDevicesRequestMarshaller();
            var unmarshaller = SearchDevicesResponseUnmarshaller.Instance;

            return Invoke<SearchDevicesRequest,SearchDevicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchDevices operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchDevices">REST API Reference for SearchDevices Operation</seealso>
        public virtual IAsyncResult BeginSearchDevices(SearchDevicesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SearchDevicesRequestMarshaller();
            var unmarshaller = SearchDevicesResponseUnmarshaller.Instance;

            return BeginInvoke<SearchDevicesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchDevices.</param>
        /// 
        /// <returns>Returns a  SearchDevicesResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchDevices">REST API Reference for SearchDevices Operation</seealso>
        public virtual SearchDevicesResponse EndSearchDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchProfiles

        /// <summary>
        /// Searches room profiles and lists the ones that meet a set of filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProfiles service method.</param>
        /// 
        /// <returns>The response from the SearchProfiles service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchProfiles">REST API Reference for SearchProfiles Operation</seealso>
        public virtual SearchProfilesResponse SearchProfiles(SearchProfilesRequest request)
        {
            var marshaller = new SearchProfilesRequestMarshaller();
            var unmarshaller = SearchProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchProfilesRequest,SearchProfilesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProfiles operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchProfiles">REST API Reference for SearchProfiles Operation</seealso>
        public virtual IAsyncResult BeginSearchProfiles(SearchProfilesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SearchProfilesRequestMarshaller();
            var unmarshaller = SearchProfilesResponseUnmarshaller.Instance;

            return BeginInvoke<SearchProfilesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchProfiles.</param>
        /// 
        /// <returns>Returns a  SearchProfilesResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchProfiles">REST API Reference for SearchProfiles Operation</seealso>
        public virtual SearchProfilesResponse EndSearchProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchRooms

        /// <summary>
        /// Searches rooms and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRooms service method.</param>
        /// 
        /// <returns>The response from the SearchRooms service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchRooms">REST API Reference for SearchRooms Operation</seealso>
        public virtual SearchRoomsResponse SearchRooms(SearchRoomsRequest request)
        {
            var marshaller = new SearchRoomsRequestMarshaller();
            var unmarshaller = SearchRoomsResponseUnmarshaller.Instance;

            return Invoke<SearchRoomsRequest,SearchRoomsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchRooms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchRooms operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchRooms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchRooms">REST API Reference for SearchRooms Operation</seealso>
        public virtual IAsyncResult BeginSearchRooms(SearchRoomsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SearchRoomsRequestMarshaller();
            var unmarshaller = SearchRoomsResponseUnmarshaller.Instance;

            return BeginInvoke<SearchRoomsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchRooms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchRooms.</param>
        /// 
        /// <returns>Returns a  SearchRoomsResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchRooms">REST API Reference for SearchRooms Operation</seealso>
        public virtual SearchRoomsResponse EndSearchRooms(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchRoomsResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchSkillGroups

        /// <summary>
        /// Searches skill groups and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSkillGroups service method.</param>
        /// 
        /// <returns>The response from the SearchSkillGroups service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchSkillGroups">REST API Reference for SearchSkillGroups Operation</seealso>
        public virtual SearchSkillGroupsResponse SearchSkillGroups(SearchSkillGroupsRequest request)
        {
            var marshaller = new SearchSkillGroupsRequestMarshaller();
            var unmarshaller = SearchSkillGroupsResponseUnmarshaller.Instance;

            return Invoke<SearchSkillGroupsRequest,SearchSkillGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchSkillGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSkillGroups operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchSkillGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchSkillGroups">REST API Reference for SearchSkillGroups Operation</seealso>
        public virtual IAsyncResult BeginSearchSkillGroups(SearchSkillGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SearchSkillGroupsRequestMarshaller();
            var unmarshaller = SearchSkillGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<SearchSkillGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchSkillGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchSkillGroups.</param>
        /// 
        /// <returns>Returns a  SearchSkillGroupsResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchSkillGroups">REST API Reference for SearchSkillGroups Operation</seealso>
        public virtual SearchSkillGroupsResponse EndSearchSkillGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchSkillGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchUsers

        /// <summary>
        /// Searches users and lists the ones that meet a set of filter and sort criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers service method.</param>
        /// 
        /// <returns>The response from the SearchUsers service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual SearchUsersResponse SearchUsers(SearchUsersRequest request)
        {
            var marshaller = new SearchUsersRequestMarshaller();
            var unmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return Invoke<SearchUsersRequest,SearchUsersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual IAsyncResult BeginSearchUsers(SearchUsersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SearchUsersRequestMarshaller();
            var unmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return BeginInvoke<SearchUsersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchUsers.</param>
        /// 
        /// <returns>Returns a  SearchUsersResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual SearchUsersResponse EndSearchUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  SendInvitation

        /// <summary>
        /// Sends an enrollment invitation email with a URL to a user. The URL is valid for 72
        /// hours or until you call this operation again, whichever comes first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendInvitation service method.</param>
        /// 
        /// <returns>The response from the SendInvitation service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.InvalidUserStatusException">
        /// The attempt to update a user is invalid due to the user's current status. HTTP Status
        /// Code: 400
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SendInvitation">REST API Reference for SendInvitation Operation</seealso>
        public virtual SendInvitationResponse SendInvitation(SendInvitationRequest request)
        {
            var marshaller = new SendInvitationRequestMarshaller();
            var unmarshaller = SendInvitationResponseUnmarshaller.Instance;

            return Invoke<SendInvitationRequest,SendInvitationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendInvitation operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SendInvitation">REST API Reference for SendInvitation Operation</seealso>
        public virtual IAsyncResult BeginSendInvitation(SendInvitationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SendInvitationRequestMarshaller();
            var unmarshaller = SendInvitationResponseUnmarshaller.Instance;

            return BeginInvoke<SendInvitationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendInvitation.</param>
        /// 
        /// <returns>Returns a  SendInvitationResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/SendInvitation">REST API Reference for SendInvitation Operation</seealso>
        public virtual SendInvitationResponse EndSendInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<SendInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDeviceSync

        /// <summary>
        /// Resets a device and its account to the known default settings by clearing all information
        /// and settings set by previous users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeviceSync service method.</param>
        /// 
        /// <returns>The response from the StartDeviceSync service method, as returned by AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/StartDeviceSync">REST API Reference for StartDeviceSync Operation</seealso>
        public virtual StartDeviceSyncResponse StartDeviceSync(StartDeviceSyncRequest request)
        {
            var marshaller = new StartDeviceSyncRequestMarshaller();
            var unmarshaller = StartDeviceSyncResponseUnmarshaller.Instance;

            return Invoke<StartDeviceSyncRequest,StartDeviceSyncResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDeviceSync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDeviceSync operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDeviceSync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/StartDeviceSync">REST API Reference for StartDeviceSync Operation</seealso>
        public virtual IAsyncResult BeginStartDeviceSync(StartDeviceSyncRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartDeviceSyncRequestMarshaller();
            var unmarshaller = StartDeviceSyncResponseUnmarshaller.Instance;

            return BeginInvoke<StartDeviceSyncRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDeviceSync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDeviceSync.</param>
        /// 
        /// <returns>Returns a  StartDeviceSyncResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/StartDeviceSync">REST API Reference for StartDeviceSync Operation</seealso>
        public virtual StartDeviceSyncResponse EndStartDeviceSync(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDeviceSyncResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds metadata tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new TagResourceRequestMarshaller();
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke<TagResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes metadata tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UntagResourceRequestMarshaller();
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke<UntagResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDevice

        /// <summary>
        /// Updates the device name by device ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice service method.</param>
        /// 
        /// <returns>The response from the UpdateDevice service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        public virtual UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest request)
        {
            var marshaller = new UpdateDeviceRequestMarshaller();
            var unmarshaller = UpdateDeviceResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceRequest,UpdateDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        public virtual IAsyncResult BeginUpdateDevice(UpdateDeviceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateDeviceRequestMarshaller();
            var unmarshaller = UpdateDeviceResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDeviceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevice.</param>
        /// 
        /// <returns>Returns a  UpdateDeviceResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        public virtual UpdateDeviceResponse EndUpdateDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProfile

        /// <summary>
        /// Updates an existing room profile by room profile ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use. HTTP Status Code: 400
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual UpdateProfileResponse UpdateProfile(UpdateProfileRequest request)
        {
            var marshaller = new UpdateProfileRequestMarshaller();
            var unmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateProfileRequest,UpdateProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateProfile(UpdateProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateProfileRequestMarshaller();
            var unmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProfile.</param>
        /// 
        /// <returns>Returns a  UpdateProfileResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual UpdateProfileResponse EndUpdateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoom

        /// <summary>
        /// Updates room details by room ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom service method.</param>
        /// 
        /// <returns>The response from the UpdateRoom service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use. HTTP Status Code: 400
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        public virtual UpdateRoomResponse UpdateRoom(UpdateRoomRequest request)
        {
            var marshaller = new UpdateRoomRequestMarshaller();
            var unmarshaller = UpdateRoomResponseUnmarshaller.Instance;

            return Invoke<UpdateRoomRequest,UpdateRoomResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoom(UpdateRoomRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateRoomRequestMarshaller();
            var unmarshaller = UpdateRoomResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateRoomRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoom.</param>
        /// 
        /// <returns>Returns a  UpdateRoomResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        public virtual UpdateRoomResponse EndUpdateRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSkillGroup

        /// <summary>
        /// Updates skill group details by skill group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSkillGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateSkillGroup service method, as returned by AlexaForBusiness.</returns>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NameInUseException">
        /// The name sent in the request is already in use. HTTP Status Code: 400
        /// </exception>
        /// <exception cref="Amazon.AlexaForBusiness.Model.NotFoundException">
        /// The resource is not found. HTTP Status Code: 400
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateSkillGroup">REST API Reference for UpdateSkillGroup Operation</seealso>
        public virtual UpdateSkillGroupResponse UpdateSkillGroup(UpdateSkillGroupRequest request)
        {
            var marshaller = new UpdateSkillGroupRequestMarshaller();
            var unmarshaller = UpdateSkillGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateSkillGroupRequest,UpdateSkillGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSkillGroup operation on AmazonAlexaForBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSkillGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateSkillGroup">REST API Reference for UpdateSkillGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateSkillGroup(UpdateSkillGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateSkillGroupRequestMarshaller();
            var unmarshaller = UpdateSkillGroupResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSkillGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSkillGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSkillGroup.</param>
        /// 
        /// <returns>Returns a  UpdateSkillGroupResult from AlexaForBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/alexaforbusiness-2017-11-09/UpdateSkillGroup">REST API Reference for UpdateSkillGroup Operation</seealso>
        public virtual UpdateSkillGroupResponse EndUpdateSkillGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSkillGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}