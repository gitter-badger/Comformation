using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration.html
    /// </summary>
    public class EbsConfiguration
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfigs
        /// </summary>
        [JsonProperty("EbsBlockDeviceConfigs")]
        public Union<List<EbsBlockDeviceConfig>, IntrinsicFunction> EbsBlockDeviceConfigs { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration.html#cfn-emr-ebsconfiguration-ebsoptimized
        /// </summary>
        [JsonProperty("EbsOptimized")]
        public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

    }
}
