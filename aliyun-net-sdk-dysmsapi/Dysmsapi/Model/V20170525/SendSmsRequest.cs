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
using Aliyun.Acs.Dysmsapi;
using Aliyun.Acs.Dysmsapi.Transform;
using Aliyun.Acs.Dysmsapi.Transform.V20170525;

namespace Aliyun.Acs.Dysmsapi.Model.V20170525
{
    public class SendSmsRequest : RpcAcsRequest<SendSmsResponse>
    {
        public SendSmsRequest()
            : base("Dysmsapi", "2017-05-25", "SendSms")
        {
        }

		private string smsUpExtendCode;

		private long? resourceOwnerId;

		private string signName;

		private string resourceOwnerAccount;

		private string phoneNumbers;

		private string outId;

		private long? ownerId;

		private string templateCode;

		private string templateParam;

		public string SmsUpExtendCode
		{
			get
			{
				return smsUpExtendCode;
			}
			set	
			{
				smsUpExtendCode = value;
				DictionaryUtil.Add(QueryParameters, "SmsUpExtendCode", value);
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

		public string SignName
		{
			get
			{
				return signName;
			}
			set	
			{
				signName = value;
				DictionaryUtil.Add(QueryParameters, "SignName", value);
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

		public string PhoneNumbers
		{
			get
			{
				return phoneNumbers;
			}
			set	
			{
				phoneNumbers = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNumbers", value);
			}
		}

		public string OutId
		{
			get
			{
				return outId;
			}
			set	
			{
				outId = value;
				DictionaryUtil.Add(QueryParameters, "OutId", value);
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

		public string TemplateCode
		{
			get
			{
				return templateCode;
			}
			set	
			{
				templateCode = value;
				DictionaryUtil.Add(QueryParameters, "TemplateCode", value);
			}
		}

		public string TemplateParam
		{
			get
			{
				return templateParam;
			}
			set	
			{
				templateParam = value;
				DictionaryUtil.Add(QueryParameters, "TemplateParam", value);
			}
		}

        public override SendSmsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendSmsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
