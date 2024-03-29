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
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class AddGtmMonitorRequest : RpcAcsRequest<AddGtmMonitorResponse>
    {
        public AddGtmMonitorRequest()
            : base("Alidns", "2015-01-09", "AddGtmMonitor", "Alidns", "openAPI")
        {
        }

		private string monitorExtendInfo;

		private string addrPoolId;

		private string name;

		private int? evaluationCount;

		private string protocolType;

		private int? interval;

		private string lang;

		private int? timeout;

		private List<IspCityNode> ispCityNodes;

		public string MonitorExtendInfo
		{
			get
			{
				return monitorExtendInfo;
			}
			set	
			{
				monitorExtendInfo = value;
				DictionaryUtil.Add(QueryParameters, "MonitorExtendInfo", value);
			}
		}

		public string AddrPoolId
		{
			get
			{
				return addrPoolId;
			}
			set	
			{
				addrPoolId = value;
				DictionaryUtil.Add(QueryParameters, "AddrPoolId", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public int? EvaluationCount
		{
			get
			{
				return evaluationCount;
			}
			set	
			{
				evaluationCount = value;
				DictionaryUtil.Add(QueryParameters, "EvaluationCount", value.ToString());
			}
		}

		public string ProtocolType
		{
			get
			{
				return protocolType;
			}
			set	
			{
				protocolType = value;
				DictionaryUtil.Add(QueryParameters, "ProtocolType", value);
			}
		}

		public int? Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public int? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
				DictionaryUtil.Add(QueryParameters, "Timeout", value.ToString());
			}
		}

		public List<IspCityNode> IspCityNodes
		{
			get
			{
				return ispCityNodes;
			}

			set
			{
				ispCityNodes = value;
				for (int i = 0; i < ispCityNodes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"IspCityNode." + (i + 1) + ".CityCode", ispCityNodes[i].CityCode);
					DictionaryUtil.Add(QueryParameters,"IspCityNode." + (i + 1) + ".IspCode", ispCityNodes[i].IspCode);
				}
			}
		}

		public class IspCityNode
		{

			private string cityCode;

			private string ispCode;

			public string CityCode
			{
				get
				{
					return cityCode;
				}
				set	
				{
					cityCode = value;
				}
			}

			public string IspCode
			{
				get
				{
					return ispCode;
				}
				set	
				{
					ispCode = value;
				}
			}
		}

        public override AddGtmMonitorResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddGtmMonitorResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
