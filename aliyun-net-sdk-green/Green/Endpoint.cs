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

namespace Aliyun.Acs.Green
{
    public class Endpoint
    {
        public static Dictionary<string, string> endpointMap = new Dictionary<string, string>() 
        {
            { "ap-south-1", "green.ap-southeast-1.aliyuncs.com" },
            { "eu-west-1", "green.ap-southeast-1.aliyuncs.com" },
            { "ap-northeast-1", "green.ap-southeast-1.aliyuncs.com" },
            { "me-east-1", "green.ap-southeast-1.aliyuncs.com" },
            { "cn-chengdu", "green.aliyuncs.com" },
            { "cn-qingdao", "green.aliyuncs.com" },
            { "cn-hongkong", "green.aliyuncs.com" },
            { "ap-southeast-2", "green.ap-southeast-1.aliyuncs.com" },
            { "ap-southeast-3", "green.ap-southeast-1.aliyuncs.com" },
            { "eu-central-1", "green.ap-southeast-1.aliyuncs.com" },
            { "cn-huhehaote", "green.aliyuncs.com" },
            { "ap-southeast-5", "green.ap-southeast-1.aliyuncs.com" },
            { "us-east-1", "green.ap-southeast-1.aliyuncs.com" },
            { "cn-zhangjiakou", "green.aliyuncs.com" },
        };

        public static string endpointRegionalType = "regional";
    }
}
