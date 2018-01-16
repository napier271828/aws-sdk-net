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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudWatch.Model;
using Amazon.CloudWatch.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatch
{
    /// <summary>
    /// Implementation for accessing CloudWatch
    ///
    /// Amazon CloudWatch monitors your Amazon Web Services (AWS) resources and the applications
    /// you run on AWS in real time. You can use CloudWatch to collect and track metrics,
    /// which are the variables you want to measure for your resources and applications.
    /// 
    ///  
    /// <para>
    /// CloudWatch alarms send notifications or automatically change the resources you are
    /// monitoring based on rules that you define. For example, you can monitor the CPU usage
    /// and disk reads and writes of your Amazon EC2 instances. Then, use this data to determine
    /// whether you should launch additional instances to handle increased load. You can also
    /// use this data to stop under-used instances to save money.
    /// </para>
    ///  
    /// <para>
    /// In addition to monitoring the built-in metrics that come with AWS, you can monitor
    /// your own custom metrics. With CloudWatch, you gain system-wide visibility into resource
    /// utilization, application performance, and operational health.
    /// </para>
    /// </summary>
    public partial class AmazonCloudWatchClient : AmazonServiceClient, IAmazonCloudWatch
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
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
        public AmazonCloudWatchClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
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
        public AmazonCloudWatchClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(AmazonCloudWatchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudWatchClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudWatchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials and an
        /// AmazonCloudWatchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(AWSCredentials credentials, AmazonCloudWatchConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudWatchConfig clientConfig)
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

        
        #region  DeleteAlarms

        internal virtual DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest request)
        {
            var marshaller = new DeleteAlarmsRequestMarshaller();
            var unmarshaller = DeleteAlarmsResponseUnmarshaller.Instance;

            return Invoke<DeleteAlarmsRequest,DeleteAlarmsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteAlarms">REST API Reference for DeleteAlarms Operation</seealso>
        public virtual Task<DeleteAlarmsResponse> DeleteAlarmsAsync(DeleteAlarmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAlarmsRequestMarshaller();
            var unmarshaller = DeleteAlarmsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAlarmsRequest,DeleteAlarmsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDashboards

        internal virtual DeleteDashboardsResponse DeleteDashboards(DeleteDashboardsRequest request)
        {
            var marshaller = new DeleteDashboardsRequestMarshaller();
            var unmarshaller = DeleteDashboardsResponseUnmarshaller.Instance;

            return Invoke<DeleteDashboardsRequest,DeleteDashboardsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboards operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteDashboards">REST API Reference for DeleteDashboards Operation</seealso>
        public virtual Task<DeleteDashboardsResponse> DeleteDashboardsAsync(DeleteDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDashboardsRequestMarshaller();
            var unmarshaller = DeleteDashboardsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDashboardsRequest,DeleteDashboardsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlarmHistory

        internal virtual DescribeAlarmHistoryResponse DescribeAlarmHistory()
        {
            return DescribeAlarmHistory(new DescribeAlarmHistoryRequest());
        }
        internal virtual DescribeAlarmHistoryResponse DescribeAlarmHistory(DescribeAlarmHistoryRequest request)
        {
            var marshaller = new DescribeAlarmHistoryRequestMarshaller();
            var unmarshaller = DescribeAlarmHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeAlarmHistoryRequest,DescribeAlarmHistoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves the history for the specified alarm. You can filter the results by date
        /// range or item type. If an alarm name is not specified, the histories for all alarms
        /// are returned.
        /// 
        ///  
        /// <para>
        /// CloudWatch retains the history of an alarm even if you delete the alarm.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmHistory">REST API Reference for DescribeAlarmHistory Operation</seealso>
        public virtual Task<DescribeAlarmHistoryResponse> DescribeAlarmHistoryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAlarmHistoryAsync(new DescribeAlarmHistoryRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmHistory">REST API Reference for DescribeAlarmHistory Operation</seealso>
        public virtual Task<DescribeAlarmHistoryResponse> DescribeAlarmHistoryAsync(DescribeAlarmHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAlarmHistoryRequestMarshaller();
            var unmarshaller = DescribeAlarmHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAlarmHistoryRequest,DescribeAlarmHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlarms

        internal virtual DescribeAlarmsResponse DescribeAlarms()
        {
            return DescribeAlarms(new DescribeAlarmsRequest());
        }
        internal virtual DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest request)
        {
            var marshaller = new DescribeAlarmsRequestMarshaller();
            var unmarshaller = DescribeAlarmsResponseUnmarshaller.Instance;

            return Invoke<DescribeAlarmsRequest,DescribeAlarmsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves the specified alarms. If no alarms are specified, all alarms are returned.
        /// Alarms can be retrieved by using only a prefix for the alarm name, the alarm state,
        /// or a prefix for any action.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarms">REST API Reference for DescribeAlarms Operation</seealso>
        public virtual Task<DescribeAlarmsResponse> DescribeAlarmsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAlarmsAsync(new DescribeAlarmsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarms">REST API Reference for DescribeAlarms Operation</seealso>
        public virtual Task<DescribeAlarmsResponse> DescribeAlarmsAsync(DescribeAlarmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAlarmsRequestMarshaller();
            var unmarshaller = DescribeAlarmsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAlarmsRequest,DescribeAlarmsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlarmsForMetric

        internal virtual DescribeAlarmsForMetricResponse DescribeAlarmsForMetric(DescribeAlarmsForMetricRequest request)
        {
            var marshaller = new DescribeAlarmsForMetricRequestMarshaller();
            var unmarshaller = DescribeAlarmsForMetricResponseUnmarshaller.Instance;

            return Invoke<DescribeAlarmsForMetricRequest,DescribeAlarmsForMetricResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmsForMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmsForMetric">REST API Reference for DescribeAlarmsForMetric Operation</seealso>
        public virtual Task<DescribeAlarmsForMetricResponse> DescribeAlarmsForMetricAsync(DescribeAlarmsForMetricRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAlarmsForMetricRequestMarshaller();
            var unmarshaller = DescribeAlarmsForMetricResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAlarmsForMetricRequest,DescribeAlarmsForMetricResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableAlarmActions

        internal virtual DisableAlarmActionsResponse DisableAlarmActions(DisableAlarmActionsRequest request)
        {
            var marshaller = new DisableAlarmActionsRequestMarshaller();
            var unmarshaller = DisableAlarmActionsResponseUnmarshaller.Instance;

            return Invoke<DisableAlarmActionsRequest,DisableAlarmActionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DisableAlarmActions">REST API Reference for DisableAlarmActions Operation</seealso>
        public virtual Task<DisableAlarmActionsResponse> DisableAlarmActionsAsync(DisableAlarmActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableAlarmActionsRequestMarshaller();
            var unmarshaller = DisableAlarmActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DisableAlarmActionsRequest,DisableAlarmActionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableAlarmActions

        internal virtual EnableAlarmActionsResponse EnableAlarmActions(EnableAlarmActionsRequest request)
        {
            var marshaller = new EnableAlarmActionsRequestMarshaller();
            var unmarshaller = EnableAlarmActionsResponseUnmarshaller.Instance;

            return Invoke<EnableAlarmActionsRequest,EnableAlarmActionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/EnableAlarmActions">REST API Reference for EnableAlarmActions Operation</seealso>
        public virtual Task<EnableAlarmActionsResponse> EnableAlarmActionsAsync(EnableAlarmActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableAlarmActionsRequestMarshaller();
            var unmarshaller = EnableAlarmActionsResponseUnmarshaller.Instance;

            return InvokeAsync<EnableAlarmActionsRequest,EnableAlarmActionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDashboard

        internal virtual GetDashboardResponse GetDashboard(GetDashboardRequest request)
        {
            var marshaller = new GetDashboardRequestMarshaller();
            var unmarshaller = GetDashboardResponseUnmarshaller.Instance;

            return Invoke<GetDashboardRequest,GetDashboardResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        public virtual Task<GetDashboardResponse> GetDashboardAsync(GetDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDashboardRequestMarshaller();
            var unmarshaller = GetDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<GetDashboardRequest,GetDashboardResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMetricStatistics

        internal virtual GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest request)
        {
            var marshaller = new GetMetricStatisticsRequestMarshaller();
            var unmarshaller = GetMetricStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetMetricStatisticsRequest,GetMetricStatisticsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricStatistics">REST API Reference for GetMetricStatistics Operation</seealso>
        public virtual Task<GetMetricStatisticsResponse> GetMetricStatisticsAsync(GetMetricStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetMetricStatisticsRequestMarshaller();
            var unmarshaller = GetMetricStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<GetMetricStatisticsRequest,GetMetricStatisticsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDashboards

        internal virtual ListDashboardsResponse ListDashboards(ListDashboardsRequest request)
        {
            var marshaller = new ListDashboardsRequestMarshaller();
            var unmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return Invoke<ListDashboardsRequest,ListDashboardsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDashboardsRequestMarshaller();
            var unmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDashboardsRequest,ListDashboardsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListMetrics

        internal virtual ListMetricsResponse ListMetrics()
        {
            return ListMetrics(new ListMetricsRequest());
        }
        internal virtual ListMetricsResponse ListMetrics(ListMetricsRequest request)
        {
            var marshaller = new ListMetricsRequestMarshaller();
            var unmarshaller = ListMetricsResponseUnmarshaller.Instance;

            return Invoke<ListMetricsRequest,ListMetricsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// List the specified metrics. You can use the returned metrics with <a>GetMetricStatistics</a>
        /// to obtain statistical data.
        /// 
        ///  
        /// <para>
        /// Up to 500 results are returned for any one call. To retrieve additional results, use
        /// the returned token with subsequent calls.
        /// </para>
        ///  
        /// <para>
        /// After you create a metric, allow up to fifteen minutes before the metric appears.
        /// Statistics about the metric, however, are available sooner using <a>GetMetricStatistics</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetrics">REST API Reference for ListMetrics Operation</seealso>
        public virtual Task<ListMetricsResponse> ListMetricsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListMetricsAsync(new ListMetricsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetrics">REST API Reference for ListMetrics Operation</seealso>
        public virtual Task<ListMetricsResponse> ListMetricsAsync(ListMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListMetricsRequestMarshaller();
            var unmarshaller = ListMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMetricsRequest,ListMetricsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutDashboard

        internal virtual PutDashboardResponse PutDashboard(PutDashboardRequest request)
        {
            var marshaller = new PutDashboardRequestMarshaller();
            var unmarshaller = PutDashboardResponseUnmarshaller.Instance;

            return Invoke<PutDashboardRequest,PutDashboardResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDashboard operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutDashboard">REST API Reference for PutDashboard Operation</seealso>
        public virtual Task<PutDashboardResponse> PutDashboardAsync(PutDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutDashboardRequestMarshaller();
            var unmarshaller = PutDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<PutDashboardRequest,PutDashboardResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutMetricAlarm

        internal virtual PutMetricAlarmResponse PutMetricAlarm(PutMetricAlarmRequest request)
        {
            var marshaller = new PutMetricAlarmRequestMarshaller();
            var unmarshaller = PutMetricAlarmResponseUnmarshaller.Instance;

            return Invoke<PutMetricAlarmRequest,PutMetricAlarmResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricAlarm">REST API Reference for PutMetricAlarm Operation</seealso>
        public virtual Task<PutMetricAlarmResponse> PutMetricAlarmAsync(PutMetricAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutMetricAlarmRequestMarshaller();
            var unmarshaller = PutMetricAlarmResponseUnmarshaller.Instance;

            return InvokeAsync<PutMetricAlarmRequest,PutMetricAlarmResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutMetricData

        internal virtual PutMetricDataResponse PutMetricData(PutMetricDataRequest request)
        {
            var marshaller = new PutMetricDataRequestMarshaller();
            var unmarshaller = PutMetricDataResponseUnmarshaller.Instance;

            return Invoke<PutMetricDataRequest,PutMetricDataResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        public virtual Task<PutMetricDataResponse> PutMetricDataAsync(PutMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutMetricDataRequestMarshaller();
            var unmarshaller = PutMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<PutMetricDataRequest,PutMetricDataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetAlarmState

        internal virtual SetAlarmStateResponse SetAlarmState(SetAlarmStateRequest request)
        {
            var marshaller = new SetAlarmStateRequestMarshaller();
            var unmarshaller = SetAlarmStateResponseUnmarshaller.Instance;

            return Invoke<SetAlarmStateRequest,SetAlarmStateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetAlarmState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/SetAlarmState">REST API Reference for SetAlarmState Operation</seealso>
        public virtual Task<SetAlarmStateResponse> SetAlarmStateAsync(SetAlarmStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetAlarmStateRequestMarshaller();
            var unmarshaller = SetAlarmStateResponseUnmarshaller.Instance;

            return InvokeAsync<SetAlarmStateRequest,SetAlarmStateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}