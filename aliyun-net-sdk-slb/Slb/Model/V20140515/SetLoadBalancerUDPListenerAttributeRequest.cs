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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Slb.Transform;
using Aliyun.Acs.Slb.Transform.V20140515;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class SetLoadBalancerUDPListenerAttributeRequest : RpcAcsRequest<SetLoadBalancerUDPListenerAttributeResponse>
    {
        public SetLoadBalancerUDPListenerAttributeRequest()
            : base("Slb", "2014-05-15", "SetLoadBalancerUDPListenerAttribute", "slb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private int? healthCheckConnectTimeout;

		private long? resourceOwnerId;

		private string description;

		private int? unhealthyThreshold;

		private int? healthyThreshold;

		private string aclStatus;

		private string scheduler;

		private string aclType;

		private string masterSlaveServerGroup;

		private string vServerGroupId;

		private string aclId;

		private int? listenerPort;

		private string resourceOwnerAccount;

		private int? bandwidth;

		private string ownerAccount;

		private long? ownerId;

		private string loadBalancerId;

		private string masterSlaveServerGroupId;

		private string healthCheckReq;

		private int? healthCheckInterval;

		private string healthCheckExp;

		private int? healthCheckConnectPort;

		private string vServerGroup;

		public int? HealthCheckConnectTimeout
		{
			get
			{
				return healthCheckConnectTimeout;
			}
			set	
			{
				healthCheckConnectTimeout = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckConnectTimeout", value.ToString());
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public int? UnhealthyThreshold
		{
			get
			{
				return unhealthyThreshold;
			}
			set	
			{
				unhealthyThreshold = value;
				DictionaryUtil.Add(QueryParameters, "UnhealthyThreshold", value.ToString());
			}
		}

		public int? HealthyThreshold
		{
			get
			{
				return healthyThreshold;
			}
			set	
			{
				healthyThreshold = value;
				DictionaryUtil.Add(QueryParameters, "HealthyThreshold", value.ToString());
			}
		}

		public string AclStatus
		{
			get
			{
				return aclStatus;
			}
			set	
			{
				aclStatus = value;
				DictionaryUtil.Add(QueryParameters, "AclStatus", value);
			}
		}

		public string Scheduler
		{
			get
			{
				return scheduler;
			}
			set	
			{
				scheduler = value;
				DictionaryUtil.Add(QueryParameters, "Scheduler", value);
			}
		}

		public string AclType
		{
			get
			{
				return aclType;
			}
			set	
			{
				aclType = value;
				DictionaryUtil.Add(QueryParameters, "AclType", value);
			}
		}

		public string MasterSlaveServerGroup
		{
			get
			{
				return masterSlaveServerGroup;
			}
			set	
			{
				masterSlaveServerGroup = value;
				DictionaryUtil.Add(QueryParameters, "MasterSlaveServerGroup", value);
			}
		}

		public string VServerGroupId
		{
			get
			{
				return vServerGroupId;
			}
			set	
			{
				vServerGroupId = value;
				DictionaryUtil.Add(QueryParameters, "VServerGroupId", value);
			}
		}

		public string AclId
		{
			get
			{
				return aclId;
			}
			set	
			{
				aclId = value;
				DictionaryUtil.Add(QueryParameters, "AclId", value);
			}
		}

		public int? ListenerPort
		{
			get
			{
				return listenerPort;
			}
			set	
			{
				listenerPort = value;
				DictionaryUtil.Add(QueryParameters, "ListenerPort", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public int? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string LoadBalancerId
		{
			get
			{
				return loadBalancerId;
			}
			set	
			{
				loadBalancerId = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerId", value);
			}
		}

		public string MasterSlaveServerGroupId
		{
			get
			{
				return masterSlaveServerGroupId;
			}
			set	
			{
				masterSlaveServerGroupId = value;
				DictionaryUtil.Add(QueryParameters, "MasterSlaveServerGroupId", value);
			}
		}

		public string HealthCheckReq
		{
			get
			{
				return healthCheckReq;
			}
			set	
			{
				healthCheckReq = value;
				DictionaryUtil.Add(QueryParameters, "healthCheckReq", value);
			}
		}

		public int? HealthCheckInterval
		{
			get
			{
				return healthCheckInterval;
			}
			set	
			{
				healthCheckInterval = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckInterval", value.ToString());
			}
		}

		public string HealthCheckExp
		{
			get
			{
				return healthCheckExp;
			}
			set	
			{
				healthCheckExp = value;
				DictionaryUtil.Add(QueryParameters, "healthCheckExp", value);
			}
		}

		public int? HealthCheckConnectPort
		{
			get
			{
				return healthCheckConnectPort;
			}
			set	
			{
				healthCheckConnectPort = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckConnectPort", value.ToString());
			}
		}

		public string VServerGroup
		{
			get
			{
				return vServerGroup;
			}
			set	
			{
				vServerGroup = value;
				DictionaryUtil.Add(QueryParameters, "VServerGroup", value);
			}
		}

        public override SetLoadBalancerUDPListenerAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetLoadBalancerUDPListenerAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
