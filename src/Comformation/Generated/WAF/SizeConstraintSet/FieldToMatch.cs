using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.SizeConstraintSet
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sizeconstraintset-sizeconstraint-fieldtomatch.html
    /// </summary>
    public class FieldToMatch
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sizeconstraintset-sizeconstraint-fieldtomatch.html#cfn-waf-sizeconstraintset-sizeconstraint-fieldtomatch-data
        /// </summary>
        [JsonProperty("Data")]
        public Union<string, IntrinsicFunction> Data { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sizeconstraintset-sizeconstraint-fieldtomatch.html#cfn-waf-sizeconstraintset-sizeconstraint-fieldtomatch-type
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
