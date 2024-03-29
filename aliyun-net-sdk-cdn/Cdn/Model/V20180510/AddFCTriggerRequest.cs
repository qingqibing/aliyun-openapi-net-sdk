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
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20180510;

namespace Aliyun.Acs.Cdn.Model.V20180510
{
    public class AddFCTriggerRequest : RpcAcsRequest<AddFCTriggerResponse>
    {
        public AddFCTriggerRequest()
            : base("Cdn", "2018-05-10", "AddFCTrigger", "cdn", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string notes;

		private string eventMetaVersion;

		private string triggerARN;

		private string sourceARN;

		private long? ownerId;

		private string roleARN;

		private string eventMetaName;

		private string functionARN;

		public string Notes
		{
			get
			{
				return notes;
			}
			set	
			{
				notes = value;
				DictionaryUtil.Add(BodyParameters, "Notes", value);
			}
		}

		public string EventMetaVersion
		{
			get
			{
				return eventMetaVersion;
			}
			set	
			{
				eventMetaVersion = value;
				DictionaryUtil.Add(BodyParameters, "EventMetaVersion", value);
			}
		}

		public string TriggerARN
		{
			get
			{
				return triggerARN;
			}
			set	
			{
				triggerARN = value;
				DictionaryUtil.Add(QueryParameters, "TriggerARN", value);
			}
		}

		public string SourceARN
		{
			get
			{
				return sourceARN;
			}
			set	
			{
				sourceARN = value;
				DictionaryUtil.Add(BodyParameters, "SourceARN", value);
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

		public string RoleARN
		{
			get
			{
				return roleARN;
			}
			set	
			{
				roleARN = value;
				DictionaryUtil.Add(BodyParameters, "RoleARN", value);
			}
		}

		public string EventMetaName
		{
			get
			{
				return eventMetaName;
			}
			set	
			{
				eventMetaName = value;
				DictionaryUtil.Add(BodyParameters, "EventMetaName", value);
			}
		}

		public string FunctionARN
		{
			get
			{
				return functionARN;
			}
			set	
			{
				functionARN = value;
				DictionaryUtil.Add(BodyParameters, "FunctionARN", value);
			}
		}

        public override AddFCTriggerResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddFCTriggerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
