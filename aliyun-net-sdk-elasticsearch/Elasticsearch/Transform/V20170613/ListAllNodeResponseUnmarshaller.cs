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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListAllNodeResponseUnmarshaller
    {
        public static ListAllNodeResponse Unmarshall(UnmarshallerContext context)
        {
			ListAllNodeResponse listAllNodeResponse = new ListAllNodeResponse();

			listAllNodeResponse.HttpResponse = context.HttpResponse;
			listAllNodeResponse.RequestId = context.StringValue("ListAllNode.RequestId");
			listAllNodeResponse.Code = context.StringValue("ListAllNode.Code");
			listAllNodeResponse.Message = context.StringValue("ListAllNode.Message");

			List<ListAllNodeResponse.ListAllNode_ResultItem> listAllNodeResponse_result = new List<ListAllNodeResponse.ListAllNode_ResultItem>();
			for (int i = 0; i < context.Length("ListAllNode.Result.Length"); i++) {
				ListAllNodeResponse.ListAllNode_ResultItem resultItem = new ListAllNodeResponse.ListAllNode_ResultItem();
				resultItem.Host = context.StringValue("ListAllNode.Result["+ i +"].Host");
				resultItem.Port = context.IntegerValue("ListAllNode.Result["+ i +"].Port");
				resultItem.ZoneId = context.StringValue("ListAllNode.Result["+ i +"].ZoneId");
				resultItem.NodeType = context.StringValue("ListAllNode.Result["+ i +"].NodeType");
				resultItem.CpuPercent = context.StringValue("ListAllNode.Result["+ i +"].CpuPercent");
				resultItem.LoadFiveM = context.StringValue("ListAllNode.Result["+ i +"].LoadFiveM");
				resultItem.HeapPercent = context.StringValue("ListAllNode.Result["+ i +"].HeapPercent");
				resultItem.Health = context.StringValue("ListAllNode.Result["+ i +"].Health");

				listAllNodeResponse_result.Add(resultItem);
			}
			listAllNodeResponse.Result = listAllNodeResponse_result;
        
			return listAllNodeResponse;
        }
    }
}
