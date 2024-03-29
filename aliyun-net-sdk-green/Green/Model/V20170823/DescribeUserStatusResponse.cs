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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeUserStatusResponse : AcsResponse
	{

		private string requestId;

		private bool? buyed;

		private bool? inDept;

		private bool? openApiUsed;

		private string openApiBeginTime;

		private string ossCheckStatus;

		private int? ossVideoSizeLimit;

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

		public bool? Buyed
		{
			get
			{
				return buyed;
			}
			set	
			{
				buyed = value;
			}
		}

		public bool? InDept
		{
			get
			{
				return inDept;
			}
			set	
			{
				inDept = value;
			}
		}

		public bool? OpenApiUsed
		{
			get
			{
				return openApiUsed;
			}
			set	
			{
				openApiUsed = value;
			}
		}

		public string OpenApiBeginTime
		{
			get
			{
				return openApiBeginTime;
			}
			set	
			{
				openApiBeginTime = value;
			}
		}

		public string OssCheckStatus
		{
			get
			{
				return ossCheckStatus;
			}
			set	
			{
				ossCheckStatus = value;
			}
		}

		public int? OssVideoSizeLimit
		{
			get
			{
				return ossVideoSizeLimit;
			}
			set	
			{
				ossVideoSizeLimit = value;
			}
		}
	}
}
