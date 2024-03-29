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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainQpsDataResponseUnmarshaller
    {
        public static DescribeDomainQpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainQpsDataResponse describeDomainQpsDataResponse = new DescribeDomainQpsDataResponse();

			describeDomainQpsDataResponse.HttpResponse = context.HttpResponse;
			describeDomainQpsDataResponse.RequestId = context.StringValue("DescribeDomainQpsData.RequestId");
			describeDomainQpsDataResponse.DomainName = context.StringValue("DescribeDomainQpsData.DomainName");
			describeDomainQpsDataResponse.StartTime = context.StringValue("DescribeDomainQpsData.StartTime");
			describeDomainQpsDataResponse.EndTime = context.StringValue("DescribeDomainQpsData.EndTime");
			describeDomainQpsDataResponse.DataInterval = context.StringValue("DescribeDomainQpsData.DataInterval");

			List<DescribeDomainQpsDataResponse.DescribeDomainQpsData_DataModule> describeDomainQpsDataResponse_qpsDataInterval = new List<DescribeDomainQpsDataResponse.DescribeDomainQpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainQpsData.QpsDataInterval.Length"); i++) {
				DescribeDomainQpsDataResponse.DescribeDomainQpsData_DataModule dataModule = new DescribeDomainQpsDataResponse.DescribeDomainQpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"]._Value");
				dataModule.DomesticValue = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].DomesticValue");
				dataModule.OverseasValue = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].OverseasValue");
				dataModule.AccValue = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].AccValue");
				dataModule.AccDomesticValue = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].AccDomesticValue");
				dataModule.AccOverseasValue = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].AccOverseasValue");
				dataModule.HttpsValue = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].HttpsValue");
				dataModule.HttpsDomesticValue = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].HttpsDomesticValue");
				dataModule.HttpsOverseasValue = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].HttpsOverseasValue");
				dataModule.HttpsAccValue = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].HttpsAccValue");
				dataModule.HttpsAccDomesticValue = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].HttpsAccDomesticValue");
				dataModule.HttpsAccOverseasValue = context.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].HttpsAccOverseasValue");

				describeDomainQpsDataResponse_qpsDataInterval.Add(dataModule);
			}
			describeDomainQpsDataResponse.QpsDataInterval = describeDomainQpsDataResponse_qpsDataInterval;
        
			return describeDomainQpsDataResponse;
        }
    }
}
