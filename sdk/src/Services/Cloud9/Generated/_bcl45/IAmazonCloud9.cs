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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Cloud9.Model;

namespace Amazon.Cloud9
{
    /// <summary>
    /// Interface for accessing Cloud9
    ///
    /// AWS Cloud9 
    /// <para>
    /// AWS Cloud9 is a collection of tools that you can use to code, build, run, test, debug,
    /// and release software in the cloud.
    /// </para>
    ///  
    /// <para>
    /// In the background, these tools are available through development environments running
    /// on Amazon Elastic Compute Cloud (Amazon EC2) instances (known as <i>Amazon EC2 environments</i>),
    /// your own servers (known as <i>SSH environments</i>), or a combination. This enables
    /// you to create and switch between multiple environments, with each environment set
    /// up for a specific development project.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS Cloud9, see the <i>AWS Cloud9 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// AWS Cloud9 supports these operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>CreateEnvironmentEC2</code>: Creates an AWS Cloud9 development environment,
    /// launches an Amazon EC2 instance, and then hosts the environment on the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateEnvironmentMembership</code>: Adds an environment member to an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteEnvironment</code>: Deletes an environment. If the environment is hosted
    /// on an Amazon EC2 instance, also terminates the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteEnvironmentMembership</code>: Deletes an environment member from an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeEnvironmentMemberships</code>: Gets information about environment members
    /// for an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeEnvironments</code>: Gets information about environments.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeEnvironmentStatus</code>: Gets status information for an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListEnvironments</code>: Gets a list of environment identifiers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateEnvironment</code>: Changes the settings of an existing environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateEnvironmentMembership</code>: Changes the settings of an existing environment
    /// member for an environment.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCloud9 : IAmazonService, IDisposable
    {

        
        #region  CreateEnvironmentEC2


        /// <summary>
        /// Creates an AWS Cloud9 development environment, launches an Amazon Elastic Compute
        /// Cloud (Amazon EC2) instance, and then hosts the environment on the instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentEC2 service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentEC2 service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentEC2">REST API Reference for CreateEnvironmentEC2 Operation</seealso>
        CreateEnvironmentEC2Response CreateEnvironmentEC2(CreateEnvironmentEC2Request request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironmentEC2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentEC2 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentEC2">REST API Reference for CreateEnvironmentEC2 Operation</seealso>
        Task<CreateEnvironmentEC2Response> CreateEnvironmentEC2Async(CreateEnvironmentEC2Request request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEnvironmentMembership


        /// <summary>
        /// Adds an environment member to an AWS Cloud9 development environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentMembership service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentMembership service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentMembership">REST API Reference for CreateEnvironmentMembership Operation</seealso>
        CreateEnvironmentMembershipResponse CreateEnvironmentMembership(CreateEnvironmentMembershipRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentMembership operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentMembership">REST API Reference for CreateEnvironmentMembership Operation</seealso>
        Task<CreateEnvironmentMembershipResponse> CreateEnvironmentMembershipAsync(CreateEnvironmentMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEnvironment


        /// <summary>
        /// Deletes an AWS Cloud9 development environment. If the environment is hosted on an
        /// Amazon Elastic Compute Cloud (Amazon EC2) instance, also terminates the instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEnvironmentMembership


        /// <summary>
        /// Deletes an environment member from an AWS Cloud9 development environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentMembership service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironmentMembership">REST API Reference for DeleteEnvironmentMembership Operation</seealso>
        DeleteEnvironmentMembershipResponse DeleteEnvironmentMembership(DeleteEnvironmentMembershipRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentMembership operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironmentMembership">REST API Reference for DeleteEnvironmentMembership Operation</seealso>
        Task<DeleteEnvironmentMembershipResponse> DeleteEnvironmentMembershipAsync(DeleteEnvironmentMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEnvironmentMemberships


        /// <summary>
        /// Gets information about environment members for an AWS Cloud9 development environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentMemberships service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentMemberships service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentMemberships">REST API Reference for DescribeEnvironmentMemberships Operation</seealso>
        DescribeEnvironmentMembershipsResponse DescribeEnvironmentMemberships(DescribeEnvironmentMembershipsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentMemberships operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentMemberships">REST API Reference for DescribeEnvironmentMemberships Operation</seealso>
        Task<DescribeEnvironmentMembershipsResponse> DescribeEnvironmentMembershipsAsync(DescribeEnvironmentMembershipsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEnvironments


        /// <summary>
        /// Gets information about AWS Cloud9 development environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(DescribeEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEnvironmentStatus


        /// <summary>
        /// Gets status information for an AWS Cloud9 development environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentStatus service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentStatus">REST API Reference for DescribeEnvironmentStatus Operation</seealso>
        DescribeEnvironmentStatusResponse DescribeEnvironmentStatus(DescribeEnvironmentStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentStatus">REST API Reference for DescribeEnvironmentStatus Operation</seealso>
        Task<DescribeEnvironmentStatusResponse> DescribeEnvironmentStatusAsync(DescribeEnvironmentStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEnvironments


        /// <summary>
        /// Gets a list of AWS Cloud9 development environment identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEnvironment


        /// <summary>
        /// Changes the settings of an existing AWS Cloud9 development environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEnvironmentMembership


        /// <summary>
        /// Changes the settings of an existing environment member for an AWS Cloud9 development
        /// environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentMembership service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironmentMembership service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironmentMembership">REST API Reference for UpdateEnvironmentMembership Operation</seealso>
        UpdateEnvironmentMembershipResponse UpdateEnvironmentMembership(UpdateEnvironmentMembershipRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentMembership operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironmentMembership">REST API Reference for UpdateEnvironmentMembership Operation</seealso>
        Task<UpdateEnvironmentMembershipResponse> UpdateEnvironmentMembershipAsync(UpdateEnvironmentMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}