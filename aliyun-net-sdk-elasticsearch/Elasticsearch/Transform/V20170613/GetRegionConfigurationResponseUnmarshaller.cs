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
    public class GetRegionConfigurationResponseUnmarshaller
    {
        public static GetRegionConfigurationResponse Unmarshall(UnmarshallerContext context)
        {
			GetRegionConfigurationResponse getRegionConfigurationResponse = new GetRegionConfigurationResponse();

			getRegionConfigurationResponse.HttpResponse = context.HttpResponse;
			getRegionConfigurationResponse.RequestId = context.StringValue("GetRegionConfiguration.RequestId");

			GetRegionConfigurationResponse.GetRegionConfiguration_Result result = new GetRegionConfigurationResponse.GetRegionConfiguration_Result();
			result.Env = context.StringValue("GetRegionConfiguration.Result.Env");
			result.RegionId = context.StringValue("GetRegionConfiguration.Result.RegionId");
			result.CreateUrl = context.StringValue("GetRegionConfiguration.Result.CreateUrl");

			List<string> result_zones = new List<string>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.Zones.Length"); i++) {
				result_zones.Add(context.StringValue("GetRegionConfiguration.Result.Zones["+ i +"]"));
			}
			result.Zones = result_zones;

			List<string> result_esVersions = new List<string>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.EsVersions.Length"); i++) {
				result_esVersions.Add(context.StringValue("GetRegionConfiguration.Result.EsVersions["+ i +"]"));
			}
			result.EsVersions = result_esVersions;

			List<string> result_masterSpec = new List<string>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.MasterSpec.Length"); i++) {
				result_masterSpec.Add(context.StringValue("GetRegionConfiguration.Result.MasterSpec["+ i +"]"));
			}
			result.MasterSpec = result_masterSpec;

			List<string> result_clientNodeSpec = new List<string>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.ClientNodeSpec.Length"); i++) {
				result_clientNodeSpec.Add(context.StringValue("GetRegionConfiguration.Result.ClientNodeSpec["+ i +"]"));
			}
			result.ClientNodeSpec = result_clientNodeSpec;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Node node = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Node();
			node.MinAmount = context.IntegerValue("GetRegionConfiguration.Result.Node.MinAmount");
			node.MaxAmount = context.IntegerValue("GetRegionConfiguration.Result.Node.MaxAmount");
			result.Node = node;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_JvmConfine jvmConfine = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_JvmConfine();
			jvmConfine.Memory = context.IntegerValue("GetRegionConfiguration.Result.JvmConfine.Memory");

			List<string> jvmConfine_supportGcs = new List<string>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.JvmConfine.SupportGcs.Length"); i++) {
				jvmConfine_supportGcs.Add(context.StringValue("GetRegionConfiguration.Result.JvmConfine.SupportGcs["+ i +"]"));
			}
			jvmConfine.SupportGcs = jvmConfine_supportGcs;

			List<string> jvmConfine_supportEsVersions = new List<string>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.JvmConfine.SupportEsVersions.Length"); i++) {
				jvmConfine_supportEsVersions.Add(context.StringValue("GetRegionConfiguration.Result.JvmConfine.SupportEsVersions["+ i +"]"));
			}
			jvmConfine.SupportEsVersions = jvmConfine_supportEsVersions;
			result.JvmConfine = jvmConfine;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ClientNodeAmountRange clientNodeAmountRange = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_ClientNodeAmountRange();
			clientNodeAmountRange.MinAmount = context.IntegerValue("GetRegionConfiguration.Result.ClientNodeAmountRange.MinAmount");
			clientNodeAmountRange.MaxAmount = context.IntegerValue("GetRegionConfiguration.Result.ClientNodeAmountRange.MaxAmount");
			result.ClientNodeAmountRange = clientNodeAmountRange;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties warmNodeProperties = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties();

			List<string> warmNodeProperties_spec = new List<string>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.WarmNodeProperties.Spec.Length"); i++) {
				warmNodeProperties_spec.Add(context.StringValue("GetRegionConfiguration.Result.WarmNodeProperties.Spec["+ i +"]"));
			}
			warmNodeProperties.Spec = warmNodeProperties_spec;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_AmountRange amountRange = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_AmountRange();
			amountRange.MinAmount = context.IntegerValue("GetRegionConfiguration.Result.WarmNodeProperties.AmountRange.MinAmount");
			amountRange.MaxAmount = context.IntegerValue("GetRegionConfiguration.Result.WarmNodeProperties.AmountRange.MaxAmount");
			warmNodeProperties.AmountRange = amountRange;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_Disk1> warmNodeProperties_diskList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_Disk1>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.WarmNodeProperties.DiskList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_Disk1 disk1 = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_WarmNodeProperties.GetRegionConfiguration_Disk1();
				disk1.DiskType = context.StringValue("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].DiskType");
				disk1.MinSize = context.IntegerValue("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].MinSize");
				disk1.MaxSize = context.IntegerValue("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].MaxSize");
				disk1.ScaleLimit = context.IntegerValue("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].ScaleLimit");

				List<string> disk1_valueLimitSet2 = new List<string>();
				for (int j = 0; j < context.Length("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].ValueLimitSet.Length"); j++) {
					disk1_valueLimitSet2.Add(context.StringValue("GetRegionConfiguration.Result.WarmNodeProperties.DiskList["+ i +"].ValueLimitSet["+ j +"]"));
				}
				disk1.ValueLimitSet2 = disk1_valueLimitSet2;

				warmNodeProperties_diskList.Add(disk1);
			}
			warmNodeProperties.DiskList = warmNodeProperties_diskList;
			result.WarmNodeProperties = warmNodeProperties;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_KibanaNodeProperties kibanaNodeProperties = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_KibanaNodeProperties();

			List<string> kibanaNodeProperties_spec3 = new List<string>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.KibanaNodeProperties.Spec.Length"); i++) {
				kibanaNodeProperties_spec3.Add(context.StringValue("GetRegionConfiguration.Result.KibanaNodeProperties.Spec["+ i +"]"));
			}
			kibanaNodeProperties.Spec3 = kibanaNodeProperties_spec3;

			GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_KibanaNodeProperties.GetRegionConfiguration_AmountRange4 amountRange4 = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_KibanaNodeProperties.GetRegionConfiguration_AmountRange4();
			amountRange4.MinAmount = context.IntegerValue("GetRegionConfiguration.Result.KibanaNodeProperties.AmountRange.MinAmount");
			amountRange4.MaxAmount = context.IntegerValue("GetRegionConfiguration.Result.KibanaNodeProperties.AmountRange.MaxAmount");
			kibanaNodeProperties.AmountRange4 = amountRange4;
			result.KibanaNodeProperties = kibanaNodeProperties;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_DataDiskListItem> result_dataDiskList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_DataDiskListItem>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.DataDiskList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_DataDiskListItem dataDiskListItem = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_DataDiskListItem();
				dataDiskListItem.DiskType = context.StringValue("GetRegionConfiguration.Result.DataDiskList["+ i +"].DiskType");
				dataDiskListItem.MinSize = context.IntegerValue("GetRegionConfiguration.Result.DataDiskList["+ i +"].MinSize");
				dataDiskListItem.MaxSize = context.IntegerValue("GetRegionConfiguration.Result.DataDiskList["+ i +"].MaxSize");
				dataDiskListItem.ScaleLimit = context.IntegerValue("GetRegionConfiguration.Result.DataDiskList["+ i +"].ScaleLimit");

				List<string> dataDiskListItem_valueLimitSet = new List<string>();
				for (int j = 0; j < context.Length("GetRegionConfiguration.Result.DataDiskList["+ i +"].ValueLimitSet.Length"); j++) {
					dataDiskListItem_valueLimitSet.Add(context.StringValue("GetRegionConfiguration.Result.DataDiskList["+ i +"].ValueLimitSet["+ j +"]"));
				}
				dataDiskListItem.ValueLimitSet = dataDiskListItem_valueLimitSet;

				result_dataDiskList.Add(dataDiskListItem);
			}
			result.DataDiskList = result_dataDiskList;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_EsVersionsLatestListItem> result_esVersionsLatestList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_EsVersionsLatestListItem>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.EsVersionsLatestList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_EsVersionsLatestListItem esVersionsLatestListItem = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_EsVersionsLatestListItem();
				esVersionsLatestListItem.Key = context.StringValue("GetRegionConfiguration.Result.EsVersionsLatestList["+ i +"].Key");
				esVersionsLatestListItem._Value = context.StringValue("GetRegionConfiguration.Result.EsVersionsLatestList["+ i +"]._Value");

				result_esVersionsLatestList.Add(esVersionsLatestListItem);
			}
			result.EsVersionsLatestList = result_esVersionsLatestList;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_NodeSpecListItem> result_nodeSpecList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_NodeSpecListItem>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.NodeSpecList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_NodeSpecListItem nodeSpecListItem = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_NodeSpecListItem();
				nodeSpecListItem.CpuCount = context.IntegerValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].CpuCount");
				nodeSpecListItem.MemorySize = context.IntegerValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].MemorySize");
				nodeSpecListItem.Enable = context.BooleanValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].Enable");
				nodeSpecListItem.Spec = context.StringValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].Spec");
				nodeSpecListItem.DiskType = context.StringValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].DiskType");
				nodeSpecListItem.Disk = context.IntegerValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].Disk");
				nodeSpecListItem.SpecGroupType = context.StringValue("GetRegionConfiguration.Result.NodeSpecList["+ i +"].SpecGroupType");

				result_nodeSpecList.Add(nodeSpecListItem);
			}
			result.NodeSpecList = result_nodeSpecList;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk> result_clientNodeDiskList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.ClientNodeDiskList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk disk = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk();
				disk.DiskType = context.StringValue("GetRegionConfiguration.Result.ClientNodeDiskList["+ i +"].DiskType");
				disk.MinSize = context.IntegerValue("GetRegionConfiguration.Result.ClientNodeDiskList["+ i +"].MinSize");
				disk.MaxSize = context.IntegerValue("GetRegionConfiguration.Result.ClientNodeDiskList["+ i +"].MaxSize");
				disk.ScaleLimit = context.IntegerValue("GetRegionConfiguration.Result.ClientNodeDiskList["+ i +"].ScaleLimit");

				result_clientNodeDiskList.Add(disk);
			}
			result.ClientNodeDiskList = result_clientNodeDiskList;

			List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk> result_masterDiskList = new List<GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk>();
			for (int i = 0; i < context.Length("GetRegionConfiguration.Result.MasterDiskList.Length"); i++) {
				GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk disk = new GetRegionConfigurationResponse.GetRegionConfiguration_Result.GetRegionConfiguration_Disk();
				disk.DiskType = context.StringValue("GetRegionConfiguration.Result.MasterDiskList["+ i +"].DiskType");
				disk.MinSize = context.IntegerValue("GetRegionConfiguration.Result.MasterDiskList["+ i +"].MinSize");
				disk.MaxSize = context.IntegerValue("GetRegionConfiguration.Result.MasterDiskList["+ i +"].MaxSize");
				disk.ScaleLimit = context.IntegerValue("GetRegionConfiguration.Result.MasterDiskList["+ i +"].ScaleLimit");

				result_masterDiskList.Add(disk);
			}
			result.MasterDiskList = result_masterDiskList;
			getRegionConfigurationResponse.Result = result;
        
			return getRegionConfigurationResponse;
        }
    }
}
