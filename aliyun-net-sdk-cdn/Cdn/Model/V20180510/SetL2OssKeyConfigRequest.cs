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
    public class SetL2OssKeyConfigRequest : RpcAcsRequest<SetL2OssKeyConfigResponse>
    {
        public SetL2OssKeyConfigRequest()
            : base("Cdn", "2018-05-10", "SetL2OssKeyConfig", "cdn", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string domainName;

		private long? ownerId;

		private long? configId;

		private string privateOssAuth;

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
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

		public long? ConfigId
		{
			get
			{
				return configId;
			}
			set	
			{
				configId = value;
				DictionaryUtil.Add(QueryParameters, "ConfigId", value.ToString());
			}
		}

		public string PrivateOssAuth
		{
			get
			{
				return privateOssAuth;
			}
			set	
			{
				privateOssAuth = value;
				DictionaryUtil.Add(QueryParameters, "PrivateOssAuth", value);
			}
		}

        public override SetL2OssKeyConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetL2OssKeyConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
