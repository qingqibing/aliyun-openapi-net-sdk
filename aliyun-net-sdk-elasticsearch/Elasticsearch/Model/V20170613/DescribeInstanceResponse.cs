/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class DescribeInstanceResponse : AcsResponse
	{

		private string requestId;

		private DescribeInstance_Result result;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public DescribeInstance_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeInstance_Result
		{

			private string instanceId;

			private string domain;

			private string description;

			private int? nodeAmount;

			private string paymentType;

			private string status;

			private string esVersion;

			private string createdAt;

			private string updatedAt;

			private string kibanaDomain;

			private bool? enablePublic;

			private bool? dedicateMaster;

			private bool? advancedDedicateMaster;

			private int? publicPort;

			private int? kibanaPort;

			private string publicDomain;

			private string vpcInstanceId;

			private int? port;

			private string esConfig;

			private int? zoneCount;

			private bool? haveClientNode;

			private bool? warmNode;

			private string protocol;

			private bool? enableKibanaPublicNetwork;

			private bool? haveKibana;

			private List<DescribeInstance_DictListItem> dictList;

			private List<DescribeInstance_SynonymsDictsItem> synonymsDicts;

			private List<DescribeInstance_ZoneInfo> zoneInfos;

			private List<string> esIPWhitelist;

			private List<string> esIPBlacklist;

			private List<string> kibanaIPWhitelist;

			private List<string> publicIpWhitelist;

			private List<string> privateNetworkIpWhiteList;

			private DescribeInstance_NodeSpec nodeSpec;

			private DescribeInstance_NetworkConfig networkConfig;

			private DescribeInstance_KibanaConfiguration kibanaConfiguration;

			private DescribeInstance_MasterConfiguration masterConfiguration;

			private DescribeInstance_ClientNodeConfiguration clientNodeConfiguration;

			private DescribeInstance_WarmNodeConfiguration warmNodeConfiguration;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public int? NodeAmount
			{
				get
				{
					return nodeAmount;
				}
				set	
				{
					nodeAmount = value;
				}
			}

			public string PaymentType
			{
				get
				{
					return paymentType;
				}
				set	
				{
					paymentType = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string EsVersion
			{
				get
				{
					return esVersion;
				}
				set	
				{
					esVersion = value;
				}
			}

			public string CreatedAt
			{
				get
				{
					return createdAt;
				}
				set	
				{
					createdAt = value;
				}
			}

			public string UpdatedAt
			{
				get
				{
					return updatedAt;
				}
				set	
				{
					updatedAt = value;
				}
			}

			public string KibanaDomain
			{
				get
				{
					return kibanaDomain;
				}
				set	
				{
					kibanaDomain = value;
				}
			}

			public bool? EnablePublic
			{
				get
				{
					return enablePublic;
				}
				set	
				{
					enablePublic = value;
				}
			}

			public bool? DedicateMaster
			{
				get
				{
					return dedicateMaster;
				}
				set	
				{
					dedicateMaster = value;
				}
			}

			public bool? AdvancedDedicateMaster
			{
				get
				{
					return advancedDedicateMaster;
				}
				set	
				{
					advancedDedicateMaster = value;
				}
			}

			public int? PublicPort
			{
				get
				{
					return publicPort;
				}
				set	
				{
					publicPort = value;
				}
			}

			public int? KibanaPort
			{
				get
				{
					return kibanaPort;
				}
				set	
				{
					kibanaPort = value;
				}
			}

			public string PublicDomain
			{
				get
				{
					return publicDomain;
				}
				set	
				{
					publicDomain = value;
				}
			}

			public string VpcInstanceId
			{
				get
				{
					return vpcInstanceId;
				}
				set	
				{
					vpcInstanceId = value;
				}
			}

			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string EsConfig
			{
				get
				{
					return esConfig;
				}
				set	
				{
					esConfig = value;
				}
			}

			public int? ZoneCount
			{
				get
				{
					return zoneCount;
				}
				set	
				{
					zoneCount = value;
				}
			}

			public bool? HaveClientNode
			{
				get
				{
					return haveClientNode;
				}
				set	
				{
					haveClientNode = value;
				}
			}

			public bool? WarmNode
			{
				get
				{
					return warmNode;
				}
				set	
				{
					warmNode = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public bool? EnableKibanaPublicNetwork
			{
				get
				{
					return enableKibanaPublicNetwork;
				}
				set	
				{
					enableKibanaPublicNetwork = value;
				}
			}

			public bool? HaveKibana
			{
				get
				{
					return haveKibana;
				}
				set	
				{
					haveKibana = value;
				}
			}

			public List<DescribeInstance_DictListItem> DictList
			{
				get
				{
					return dictList;
				}
				set	
				{
					dictList = value;
				}
			}

			public List<DescribeInstance_SynonymsDictsItem> SynonymsDicts
			{
				get
				{
					return synonymsDicts;
				}
				set	
				{
					synonymsDicts = value;
				}
			}

			public List<DescribeInstance_ZoneInfo> ZoneInfos
			{
				get
				{
					return zoneInfos;
				}
				set	
				{
					zoneInfos = value;
				}
			}

			public List<string> EsIPWhitelist
			{
				get
				{
					return esIPWhitelist;
				}
				set	
				{
					esIPWhitelist = value;
				}
			}

			public List<string> EsIPBlacklist
			{
				get
				{
					return esIPBlacklist;
				}
				set	
				{
					esIPBlacklist = value;
				}
			}

			public List<string> KibanaIPWhitelist
			{
				get
				{
					return kibanaIPWhitelist;
				}
				set	
				{
					kibanaIPWhitelist = value;
				}
			}

			public List<string> PublicIpWhitelist
			{
				get
				{
					return publicIpWhitelist;
				}
				set	
				{
					publicIpWhitelist = value;
				}
			}

			public List<string> PrivateNetworkIpWhiteList
			{
				get
				{
					return privateNetworkIpWhiteList;
				}
				set	
				{
					privateNetworkIpWhiteList = value;
				}
			}

			public DescribeInstance_NodeSpec NodeSpec
			{
				get
				{
					return nodeSpec;
				}
				set	
				{
					nodeSpec = value;
				}
			}

			public DescribeInstance_NetworkConfig NetworkConfig
			{
				get
				{
					return networkConfig;
				}
				set	
				{
					networkConfig = value;
				}
			}

			public DescribeInstance_KibanaConfiguration KibanaConfiguration
			{
				get
				{
					return kibanaConfiguration;
				}
				set	
				{
					kibanaConfiguration = value;
				}
			}

			public DescribeInstance_MasterConfiguration MasterConfiguration
			{
				get
				{
					return masterConfiguration;
				}
				set	
				{
					masterConfiguration = value;
				}
			}

			public DescribeInstance_ClientNodeConfiguration ClientNodeConfiguration
			{
				get
				{
					return clientNodeConfiguration;
				}
				set	
				{
					clientNodeConfiguration = value;
				}
			}

			public DescribeInstance_WarmNodeConfiguration WarmNodeConfiguration
			{
				get
				{
					return warmNodeConfiguration;
				}
				set	
				{
					warmNodeConfiguration = value;
				}
			}

			public class DescribeInstance_DictListItem
			{

				private string name;

				private long? fileSize;

				private string type;

				private string sourceType;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public long? FileSize
				{
					get
					{
						return fileSize;
					}
					set	
					{
						fileSize = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string SourceType
				{
					get
					{
						return sourceType;
					}
					set	
					{
						sourceType = value;
					}
				}
			}

			public class DescribeInstance_SynonymsDictsItem
			{

				private string name;

				private long? fileSize;

				private string type;

				private string sourceType;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public long? FileSize
				{
					get
					{
						return fileSize;
					}
					set	
					{
						fileSize = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string SourceType
				{
					get
					{
						return sourceType;
					}
					set	
					{
						sourceType = value;
					}
				}
			}

			public class DescribeInstance_ZoneInfo
			{

				private string zoneId;

				private string status;

				public string ZoneId
				{
					get
					{
						return zoneId;
					}
					set	
					{
						zoneId = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeInstance_NodeSpec
			{

				private string spec;

				private int? disk;

				private string diskType;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}
			}

			public class DescribeInstance_NetworkConfig
			{

				private string type;

				private string vpcId;

				private string vswitchId;

				private string vsArea;

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string VpcId
				{
					get
					{
						return vpcId;
					}
					set	
					{
						vpcId = value;
					}
				}

				public string VswitchId
				{
					get
					{
						return vswitchId;
					}
					set	
					{
						vswitchId = value;
					}
				}

				public string VsArea
				{
					get
					{
						return vsArea;
					}
					set	
					{
						vsArea = value;
					}
				}
			}

			public class DescribeInstance_KibanaConfiguration
			{

				private string spec;

				private int? amount;

				private string diskType;

				private int? disk;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}
			}

			public class DescribeInstance_MasterConfiguration
			{

				private string spec;

				private int? amount;

				private string diskType;

				private int? disk;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}
			}

			public class DescribeInstance_ClientNodeConfiguration
			{

				private string spec;

				private int? amount;

				private string diskType;

				private int? disk;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}
			}

			public class DescribeInstance_WarmNodeConfiguration
			{

				private string spec;

				private int? amount;

				private string diskType;

				private int? disk;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}
			}
		}
	}
}
