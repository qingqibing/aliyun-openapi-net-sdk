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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeTagsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<DescribeTags_Tag> tags;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<DescribeTags_Tag> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public class DescribeTags_Tag
		{

			private string tagKey;

			private List<string> tagValues;

			public string TagKey
			{
				get
				{
					return tagKey;
				}
				set	
				{
					tagKey = value;
				}
			}

			public List<string> TagValues
			{
				get
				{
					return tagValues;
				}
				set	
				{
					tagValues = value;
				}
			}
		}
	}
}
