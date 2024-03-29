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
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class ImportKeywordsRequest : RpcAcsRequest<ImportKeywordsResponse>
    {
        public ImportKeywordsRequest()
            : base("Green", "2017-08-23", "ImportKeywords", "green", "openAPI")
        {
			Method = MethodType.POST;
        }

		private int? keywordLibId;

		private string keywordsObject;

		public int? KeywordLibId
		{
			get
			{
				return keywordLibId;
			}
			set	
			{
				keywordLibId = value;
				DictionaryUtil.Add(QueryParameters, "KeywordLibId", value.ToString());
			}
		}

		public string KeywordsObject
		{
			get
			{
				return keywordsObject;
			}
			set	
			{
				keywordsObject = value;
				DictionaryUtil.Add(QueryParameters, "KeywordsObject", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ImportKeywordsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportKeywordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
