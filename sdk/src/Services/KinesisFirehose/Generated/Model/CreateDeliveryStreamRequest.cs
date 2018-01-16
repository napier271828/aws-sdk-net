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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeliveryStream operation.
    /// Creates a delivery stream.
    /// 
    ///  
    /// <para>
    /// By default, you can create up to 20 delivery streams per region.
    /// </para>
    ///  
    /// <para>
    /// This is an asynchronous operation that immediately returns. The initial status of
    /// the delivery stream is <code>CREATING</code>. After the delivery stream is created,
    /// its status is <code>ACTIVE</code> and it now accepts data. Attempts to send data to
    /// a delivery stream that is not in the <code>ACTIVE</code> state cause an exception.
    /// To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>.
    /// </para>
    ///  
    /// <para>
    /// A Kinesis Firehose delivery stream can be configured to receive records directly from
    /// providers using <a>PutRecord</a> or <a>PutRecordBatch</a>, or it can be configured
    /// to use an existing Kinesis stream as its source. To specify a Kinesis stream as input,
    /// set the <code>DeliveryStreamType</code> parameter to <code>KinesisStreamAsSource</code>,
    /// and provide the Kinesis stream ARN and role ARN in the <code>KinesisStreamSourceConfiguration</code>
    /// parameter.
    /// </para>
    ///  
    /// <para>
    /// A delivery stream is configured with a single destination: Amazon S3, Amazon ES, or
    /// Amazon Redshift. You must specify only one of the following destination configuration
    /// parameters: <b>ExtendedS3DestinationConfiguration</b>, <b>S3DestinationConfiguration</b>,
    /// <b>ElasticsearchDestinationConfiguration</b>, or <b>RedshiftDestinationConfiguration</b>.
    /// </para>
    ///  
    /// <para>
    /// When you specify <b>S3DestinationConfiguration</b>, you can also provide the following
    /// optional values: <b>BufferingHints</b>, <b>EncryptionConfiguration</b>, and <b>CompressionFormat</b>.
    /// By default, if no <b>BufferingHints</b> value is provided, Kinesis Firehose buffers
    /// data up to 5 MB or for 5 minutes, whichever condition is satisfied first. Note that
    /// <b>BufferingHints</b> is a hint, so there are some cases where the service cannot
    /// adhere to these conditions strictly; for example, record boundaries are such that
    /// the size is a little over or under the configured buffering size. By default, no encryption
    /// is performed. We strongly recommend that you enable encryption to ensure secure data
    /// storage in Amazon S3.
    /// </para>
    ///  
    /// <para>
    /// A few notes about Amazon Redshift as a destination:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An Amazon Redshift destination requires an S3 bucket as intermediate location, as
    /// Kinesis Firehose first delivers data to S3 and then uses <code>COPY</code> syntax
    /// to load data into an Amazon Redshift table. This is specified in the <b>RedshiftDestinationConfiguration.S3Configuration</b>
    /// parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The compression formats <code>SNAPPY</code> or <code>ZIP</code> cannot be specified
    /// in <b>RedshiftDestinationConfiguration.S3Configuration</b> because the Amazon Redshift
    /// <code>COPY</code> operation that reads from the S3 bucket doesn't support these compression
    /// formats.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// We strongly recommend that you use the user name and password you provide exclusively
    /// with Kinesis Firehose, and that the permissions for the account are restricted for
    /// Amazon Redshift <code>INSERT</code> permissions.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Kinesis Firehose assumes the IAM role that is configured as part of the destination.
    /// The role should allow the Kinesis Firehose principal to assume the role, and the role
    /// should have permissions that allow the service to deliver the data. For more information,
    /// see <a href="http://docs.aws.amazon.com/firehose/latest/dev/controlling-access.html#using-iam-s3">Amazon
    /// S3 Bucket Access</a> in the <i>Amazon Kinesis Firehose Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateDeliveryStreamRequest : AmazonKinesisFirehoseRequest
    {
        private string _deliveryStreamName;
        private DeliveryStreamType _deliveryStreamType;
        private ElasticsearchDestinationConfiguration _elasticsearchDestinationConfiguration;
        private ExtendedS3DestinationConfiguration _extendedS3DestinationConfiguration;
        private KinesisStreamSourceConfiguration _kinesisStreamSourceConfiguration;
        private RedshiftDestinationConfiguration _redshiftDestinationConfiguration;
        private S3DestinationConfiguration _s3DestinationConfiguration;
        private SplunkDestinationConfiguration _splunkDestinationConfiguration;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream. This name must be unique per AWS account in the same
        /// region. If the delivery streams are in different accounts or different regions, you
        /// can have multiple delivery streams with the same name.
        /// </para>
        /// </summary>
        public string DeliveryStreamName
        {
            get { return this._deliveryStreamName; }
            set { this._deliveryStreamName = value; }
        }

        // Check to see if DeliveryStreamName property is set
        internal bool IsSetDeliveryStreamName()
        {
            return this._deliveryStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamType. 
        /// <para>
        /// The delivery stream type. This parameter can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DirectPut</code>: Provider applications access the delivery stream directly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KinesisStreamAsSource</code>: The delivery stream uses a Kinesis stream as
        /// a source.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeliveryStreamType DeliveryStreamType
        {
            get { return this._deliveryStreamType; }
            set { this._deliveryStreamType = value; }
        }

        // Check to see if DeliveryStreamType property is set
        internal bool IsSetDeliveryStreamType()
        {
            return this._deliveryStreamType != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchDestinationConfiguration. 
        /// <para>
        /// The destination in Amazon ES. You can specify only one destination.
        /// </para>
        /// </summary>
        public ElasticsearchDestinationConfiguration ElasticsearchDestinationConfiguration
        {
            get { return this._elasticsearchDestinationConfiguration; }
            set { this._elasticsearchDestinationConfiguration = value; }
        }

        // Check to see if ElasticsearchDestinationConfiguration property is set
        internal bool IsSetElasticsearchDestinationConfiguration()
        {
            return this._elasticsearchDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExtendedS3DestinationConfiguration. 
        /// <para>
        /// The destination in Amazon S3. You can specify only one destination.
        /// </para>
        /// </summary>
        public ExtendedS3DestinationConfiguration ExtendedS3DestinationConfiguration
        {
            get { return this._extendedS3DestinationConfiguration; }
            set { this._extendedS3DestinationConfiguration = value; }
        }

        // Check to see if ExtendedS3DestinationConfiguration property is set
        internal bool IsSetExtendedS3DestinationConfiguration()
        {
            return this._extendedS3DestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamSourceConfiguration. 
        /// <para>
        /// When a Kinesis stream is used as the source for the delivery stream, a <a>KinesisStreamSourceConfiguration</a>
        /// containing the Kinesis stream ARN and the role ARN for the source stream.
        /// </para>
        /// </summary>
        public KinesisStreamSourceConfiguration KinesisStreamSourceConfiguration
        {
            get { return this._kinesisStreamSourceConfiguration; }
            set { this._kinesisStreamSourceConfiguration = value; }
        }

        // Check to see if KinesisStreamSourceConfiguration property is set
        internal bool IsSetKinesisStreamSourceConfiguration()
        {
            return this._kinesisStreamSourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftDestinationConfiguration. 
        /// <para>
        /// The destination in Amazon Redshift. You can specify only one destination.
        /// </para>
        /// </summary>
        public RedshiftDestinationConfiguration RedshiftDestinationConfiguration
        {
            get { return this._redshiftDestinationConfiguration; }
            set { this._redshiftDestinationConfiguration = value; }
        }

        // Check to see if RedshiftDestinationConfiguration property is set
        internal bool IsSetRedshiftDestinationConfiguration()
        {
            return this._redshiftDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationConfiguration. 
        /// <para>
        /// [Deprecated] The destination in Amazon S3. You can specify only one destination.
        /// </para>
        /// </summary>
        public S3DestinationConfiguration S3DestinationConfiguration
        {
            get { return this._s3DestinationConfiguration; }
            set { this._s3DestinationConfiguration = value; }
        }

        // Check to see if S3DestinationConfiguration property is set
        internal bool IsSetS3DestinationConfiguration()
        {
            return this._s3DestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SplunkDestinationConfiguration. 
        /// <para>
        /// The destination in Splunk. You can specify only one destination.
        /// </para>
        /// </summary>
        public SplunkDestinationConfiguration SplunkDestinationConfiguration
        {
            get { return this._splunkDestinationConfiguration; }
            set { this._splunkDestinationConfiguration = value; }
        }

        // Check to see if SplunkDestinationConfiguration property is set
        internal bool IsSetSplunkDestinationConfiguration()
        {
            return this._splunkDestinationConfiguration != null;
        }

    }
}