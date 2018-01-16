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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ApplicationDiscoveryService.Model;

namespace Amazon.ApplicationDiscoveryService
{
    /// <summary>
    /// Interface for accessing ApplicationDiscoveryService
    ///
    /// AWS Application Discovery Service 
    /// <para>
    /// AWS Application Discovery Service helps you plan application migration projects by
    /// automatically identifying servers, virtual machines (VMs), software, and software
    /// dependencies running in your on-premises data centers. Application Discovery Service
    /// also collects application performance data, which can help you assess the outcome
    /// of your migration. The data collected by Application Discovery Service is securely
    /// retained in an Amazon-hosted and managed database in the cloud. You can export the
    /// data as a CSV or XML file into your preferred visualization tool or cloud-migration
    /// solution to plan your migration. For more information, see the Application Discovery
    /// Service <a href="http://aws.amazon.com/application-discovery/faqs/">FAQ</a>.
    /// </para>
    ///  
    /// <para>
    /// Application Discovery Service offers two modes of operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Agentless discovery</b> mode is recommended for environments that use VMware vCenter
    /// Server. This mode doesn't require you to install an agent on each host. Agentless
    /// discovery gathers server information regardless of the operating systems, which minimizes
    /// the time required for initial on-premises infrastructure assessment. Agentless discovery
    /// doesn't collect information about software and software dependencies. It also doesn't
    /// work in non-VMware environments. We recommend that you use agent-based discovery for
    /// non-VMware environments and if you want to collect information about software and
    /// software dependencies. You can also run agent-based and agentless discovery simultaneously.
    /// Use agentless discovery to quickly complete the initial infrastructure assessment
    /// and then install agents on select hosts to gather information about software and software
    /// dependencies.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Agent-based discovery</b> mode collects a richer set of data than agentless discovery
    /// by using Amazon software, the AWS Application Discovery Agent, which you install on
    /// one or more hosts in your data center. The agent captures infrastructure and application
    /// information, including an inventory of installed software applications, system and
    /// process performance, resource utilization, and network dependencies between workloads.
    /// The information collected by agents is secured at rest and in transit to the Application
    /// Discovery Service database in the cloud. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Application Discovery Service integrates with application discovery solutions from
    /// AWS Partner Network (APN) partners. Third-party application discovery tools can query
    /// Application Discovery Service and write to the Application Discovery Service database
    /// using a public API. You can then import the data into either a visualization tool
    /// or cloud-migration solution.
    /// </para>
    ///  <important> 
    /// <para>
    /// Application Discovery Service doesn't gather sensitive information. All data is handled
    /// according to the <a href="http://aws.amazon.com/privacy/">AWS Privacy Policy</a>.
    /// You can operate Application Discovery Service using offline mode to inspect collected
    /// data before it is shared with the service.
    /// </para>
    ///  </important> 
    /// <para>
    /// Your AWS account must be granted access to Application Discovery Service, a process
    /// called <i>whitelisting</i>. This is true for AWS partners and customers alike. To
    /// request access, <a href="http://aws.amazon.com/application-discovery/how-to-start/">
    /// sign up for AWS Application Discovery Service</a>.
    /// </para>
    ///  
    /// <para>
    /// This API reference provides descriptions, syntax, and usage examples for each of the
    /// actions and data types for Application Discovery Service. The topic for each action
    /// shows the API request parameters and the response. Alternatively, you can use one
    /// of the AWS SDKs to access an API that is tailored to the programming language or platform
    /// that you're using. For more information, see <a href="http://aws.amazon.com/tools/#SDKs">AWS
    /// SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// This guide is intended for use with the <a href="http://docs.aws.amazon.com/application-discovery/latest/userguide/">
    /// <i>AWS Application Discovery Service User Guide</i> </a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonApplicationDiscoveryService : IAmazonService, IDisposable
    {

        
        #region  AssociateConfigurationItemsToApplication


        /// <summary>
        /// Associates one or more configuration items with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateConfigurationItemsToApplication service method.</param>
        /// 
        /// <returns>The response from the AssociateConfigurationItemsToApplication service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/AssociateConfigurationItemsToApplication">REST API Reference for AssociateConfigurationItemsToApplication Operation</seealso>
        AssociateConfigurationItemsToApplicationResponse AssociateConfigurationItemsToApplication(AssociateConfigurationItemsToApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateConfigurationItemsToApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateConfigurationItemsToApplication operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateConfigurationItemsToApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/AssociateConfigurationItemsToApplication">REST API Reference for AssociateConfigurationItemsToApplication Operation</seealso>
        IAsyncResult BeginAssociateConfigurationItemsToApplication(AssociateConfigurationItemsToApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateConfigurationItemsToApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateConfigurationItemsToApplication.</param>
        /// 
        /// <returns>Returns a  AssociateConfigurationItemsToApplicationResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/AssociateConfigurationItemsToApplication">REST API Reference for AssociateConfigurationItemsToApplication Operation</seealso>
        AssociateConfigurationItemsToApplicationResponse EndAssociateConfigurationItemsToApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an application with the given name and description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// Creates one or more tags for configuration items. Tags are metadata that help you
        /// categorize IT assets. This API accepts a list of multiple configuration items.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        CreateTagsResponse CreateTags(CreateTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        IAsyncResult BeginCreateTags(CreateTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        /// 
        /// <returns>Returns a  CreateTagsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        CreateTagsResponse EndCreateTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplications


        /// <summary>
        /// Deletes a list of applications and their associations with configuration items.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplications service method.</param>
        /// 
        /// <returns>The response from the DeleteApplications service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DeleteApplications">REST API Reference for DeleteApplications Operation</seealso>
        DeleteApplicationsResponse DeleteApplications(DeleteApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplications operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DeleteApplications">REST API Reference for DeleteApplications Operation</seealso>
        IAsyncResult BeginDeleteApplications(DeleteApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplications.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DeleteApplications">REST API Reference for DeleteApplications Operation</seealso>
        DeleteApplicationsResponse EndDeleteApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes the association between configuration items and one or more tags. This API
        /// accepts a list of multiple configuration items.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAgents


        /// <summary>
        /// Lists agents or the Connector by ID or lists all agents/Connectors associated with
        /// your user account if you did not specify an ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgents service method.</param>
        /// 
        /// <returns>The response from the DescribeAgents service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeAgents">REST API Reference for DescribeAgents Operation</seealso>
        DescribeAgentsResponse DescribeAgents(DescribeAgentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgents operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAgents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeAgents">REST API Reference for DescribeAgents Operation</seealso>
        IAsyncResult BeginDescribeAgents(DescribeAgentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAgents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAgents.</param>
        /// 
        /// <returns>Returns a  DescribeAgentsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeAgents">REST API Reference for DescribeAgents Operation</seealso>
        DescribeAgentsResponse EndDescribeAgents(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConfigurations


        /// <summary>
        /// Retrieves attributes for a list of configuration item IDs. All of the supplied IDs
        /// must be for the same asset type (server, application, process, or connection). Output
        /// fields are specific to the asset type selected. For example, the output for a <i>server</i>
        /// configuration item includes a list of attributes about the server, such as host name,
        /// operating system, and number of network cards.
        /// 
        ///  
        /// <para>
        /// For a complete list of outputs for each asset type, see <a href="http://docs.aws.amazon.com/application-discovery/latest/APIReference/discovery-api-queries.html#DescribeConfigurations">Using
        /// the DescribeConfigurations Action</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeConfigurations">REST API Reference for DescribeConfigurations Operation</seealso>
        DescribeConfigurationsResponse DescribeConfigurations(DescribeConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurations operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeConfigurations">REST API Reference for DescribeConfigurations Operation</seealso>
        IAsyncResult BeginDescribeConfigurations(DescribeConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeConfigurations">REST API Reference for DescribeConfigurations Operation</seealso>
        DescribeConfigurationsResponse EndDescribeConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExportConfigurations


        /// <summary>
        /// Deprecated. Use <code>DescribeExportTasks</code> instead.
        /// 
        ///  
        /// <para>
        /// Retrieves the status of a given export process. You can retrieve status from a maximum
        /// of 100 processes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeExportConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeExportConfigurations">REST API Reference for DescribeExportConfigurations Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeExportTasks.")]
        DescribeExportConfigurationsResponse DescribeExportConfigurations(DescribeExportConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportConfigurations operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExportConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeExportConfigurations">REST API Reference for DescribeExportConfigurations Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeExportTasks.")]
        IAsyncResult BeginDescribeExportConfigurations(DescribeExportConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExportConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeExportConfigurationsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeExportConfigurations">REST API Reference for DescribeExportConfigurations Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeExportTasks.")]
        DescribeExportConfigurationsResponse EndDescribeExportConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExportTasks


        /// <summary>
        /// Retrieve status of one or more export tasks. You can retrieve the status of up to
        /// 100 export tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExportTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        IAsyncResult BeginDescribeExportTasks(DescribeExportTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExportTasks.</param>
        /// 
        /// <returns>Returns a  DescribeExportTasksResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        DescribeExportTasksResponse EndDescribeExportTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Retrieves a list of configuration items that are tagged with a specific tag. Or retrieves
        /// a list of all tags assigned to a specific configuration item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateConfigurationItemsFromApplication


        /// <summary>
        /// Disassociates one or more configuration items from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConfigurationItemsFromApplication service method.</param>
        /// 
        /// <returns>The response from the DisassociateConfigurationItemsFromApplication service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DisassociateConfigurationItemsFromApplication">REST API Reference for DisassociateConfigurationItemsFromApplication Operation</seealso>
        DisassociateConfigurationItemsFromApplicationResponse DisassociateConfigurationItemsFromApplication(DisassociateConfigurationItemsFromApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConfigurationItemsFromApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConfigurationItemsFromApplication operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateConfigurationItemsFromApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DisassociateConfigurationItemsFromApplication">REST API Reference for DisassociateConfigurationItemsFromApplication Operation</seealso>
        IAsyncResult BeginDisassociateConfigurationItemsFromApplication(DisassociateConfigurationItemsFromApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateConfigurationItemsFromApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateConfigurationItemsFromApplication.</param>
        /// 
        /// <returns>Returns a  DisassociateConfigurationItemsFromApplicationResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/DisassociateConfigurationItemsFromApplication">REST API Reference for DisassociateConfigurationItemsFromApplication Operation</seealso>
        DisassociateConfigurationItemsFromApplicationResponse EndDisassociateConfigurationItemsFromApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportConfigurations


        /// <summary>
        /// Deprecated. Use <code>StartExportTask</code> instead.
        /// 
        ///  
        /// <para>
        /// Exports all discovered configuration data to an Amazon S3 bucket or an application
        /// that enables you to view and evaluate the data. Data includes tags and tag associations,
        /// processes, connections, servers, and system performance. This API returns an export
        /// ID that you can query using the <i>DescribeExportConfigurations</i> API. The system
        /// imposes a limit of two configuration exports in six hours.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportConfigurations service method.</param>
        /// 
        /// <returns>The response from the ExportConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.OperationNotPermittedException">
        /// This operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ExportConfigurations">REST API Reference for ExportConfigurations Operation</seealso>
        [Obsolete("Deprecated in favor of StartExportTask.")]
        ExportConfigurationsResponse ExportConfigurations(ExportConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportConfigurations operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ExportConfigurations">REST API Reference for ExportConfigurations Operation</seealso>
        [Obsolete("Deprecated in favor of StartExportTask.")]
        IAsyncResult BeginExportConfigurations(ExportConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportConfigurations.</param>
        /// 
        /// <returns>Returns a  ExportConfigurationsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ExportConfigurations">REST API Reference for ExportConfigurations Operation</seealso>
        [Obsolete("Deprecated in favor of StartExportTask.")]
        ExportConfigurationsResponse EndExportConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDiscoverySummary


        /// <summary>
        /// Retrieves a short summary of discovered assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoverySummary service method.</param>
        /// 
        /// <returns>The response from the GetDiscoverySummary service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/GetDiscoverySummary">REST API Reference for GetDiscoverySummary Operation</seealso>
        GetDiscoverySummaryResponse GetDiscoverySummary(GetDiscoverySummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDiscoverySummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoverySummary operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDiscoverySummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/GetDiscoverySummary">REST API Reference for GetDiscoverySummary Operation</seealso>
        IAsyncResult BeginGetDiscoverySummary(GetDiscoverySummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDiscoverySummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDiscoverySummary.</param>
        /// 
        /// <returns>Returns a  GetDiscoverySummaryResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/GetDiscoverySummary">REST API Reference for GetDiscoverySummary Operation</seealso>
        GetDiscoverySummaryResponse EndGetDiscoverySummary(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfigurations


        /// <summary>
        /// Retrieves a list of configuration items according to criteria that you specify in
        /// a filter. The filter criteria identifies the relationship requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        IAsyncResult BeginListConfigurations(ListConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurations.</param>
        /// 
        /// <returns>Returns a  ListConfigurationsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        ListConfigurationsResponse EndListConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServerNeighbors


        /// <summary>
        /// Retrieves a list of servers that are one network hop away from a specified server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerNeighbors service method.</param>
        /// 
        /// <returns>The response from the ListServerNeighbors service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ListServerNeighbors">REST API Reference for ListServerNeighbors Operation</seealso>
        ListServerNeighborsResponse ListServerNeighbors(ListServerNeighborsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServerNeighbors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServerNeighbors operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServerNeighbors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ListServerNeighbors">REST API Reference for ListServerNeighbors Operation</seealso>
        IAsyncResult BeginListServerNeighbors(ListServerNeighborsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServerNeighbors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServerNeighbors.</param>
        /// 
        /// <returns>Returns a  ListServerNeighborsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/ListServerNeighbors">REST API Reference for ListServerNeighbors Operation</seealso>
        ListServerNeighborsResponse EndListServerNeighbors(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDataCollectionByAgentIds


        /// <summary>
        /// Instructs the specified agents or connectors to start collecting data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollectionByAgentIds service method.</param>
        /// 
        /// <returns>The response from the StartDataCollectionByAgentIds service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartDataCollectionByAgentIds">REST API Reference for StartDataCollectionByAgentIds Operation</seealso>
        StartDataCollectionByAgentIdsResponse StartDataCollectionByAgentIds(StartDataCollectionByAgentIdsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollectionByAgentIds operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataCollectionByAgentIds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartDataCollectionByAgentIds">REST API Reference for StartDataCollectionByAgentIds Operation</seealso>
        IAsyncResult BeginStartDataCollectionByAgentIds(StartDataCollectionByAgentIdsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataCollectionByAgentIds.</param>
        /// 
        /// <returns>Returns a  StartDataCollectionByAgentIdsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartDataCollectionByAgentIds">REST API Reference for StartDataCollectionByAgentIds Operation</seealso>
        StartDataCollectionByAgentIdsResponse EndStartDataCollectionByAgentIds(IAsyncResult asyncResult);

        #endregion
        
        #region  StartExportTask


        /// <summary>
        /// Begins the export of discovered data to an S3 bucket.
        /// 
        ///  
        /// <para>
        ///  If you specify <code>agentIds</code> in a filter, the task exports up to 72 hours
        /// of detailed data collected by the identified Application Discovery Agent, including
        /// network, process, and performance details. A time range for exported agent data may
        /// be set by using <code>startTime</code> and <code>endTime</code>. Export of detailed
        /// agent data is limited to five concurrently running exports. 
        /// </para>
        ///  
        /// <para>
        ///  If you do not include an <code>agentIds</code> filter, summary data is exported that
        /// includes both AWS Agentless Discovery Connector data and summary data from AWS Discovery
        /// Agents. Export of summary data is limited to two exports per day. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask service method.</param>
        /// 
        /// <returns>The response from the StartExportTask service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.OperationNotPermittedException">
        /// This operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        StartExportTaskResponse StartExportTask(StartExportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        IAsyncResult BeginStartExportTask(StartExportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExportTask.</param>
        /// 
        /// <returns>Returns a  StartExportTaskResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        StartExportTaskResponse EndStartExportTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StopDataCollectionByAgentIds


        /// <summary>
        /// Instructs the specified agents or connectors to stop collecting data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollectionByAgentIds service method.</param>
        /// 
        /// <returns>The response from the StopDataCollectionByAgentIds service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StopDataCollectionByAgentIds">REST API Reference for StopDataCollectionByAgentIds Operation</seealso>
        StopDataCollectionByAgentIdsResponse StopDataCollectionByAgentIds(StopDataCollectionByAgentIdsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollectionByAgentIds operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDataCollectionByAgentIds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StopDataCollectionByAgentIds">REST API Reference for StopDataCollectionByAgentIds Operation</seealso>
        IAsyncResult BeginStopDataCollectionByAgentIds(StopDataCollectionByAgentIdsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDataCollectionByAgentIds.</param>
        /// 
        /// <returns>Returns a  StopDataCollectionByAgentIdsResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/StopDataCollectionByAgentIds">REST API Reference for StopDataCollectionByAgentIds Operation</seealso>
        StopDataCollectionByAgentIdsResponse EndStopDataCollectionByAgentIds(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates metadata about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from ApplicationDiscoveryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/discovery-2015-11-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult);

        #endregion
        
    }
}