using System;
using Newtonsoft.Json;

namespace CloudBank.RetailBank
{
    /// <summary>
    /// A wrapper for the response from the function
    /// </summary>
    public class FunctionResponse
    {

        /// <summary>
        /// The text message returned from the command
        /// </summary>
        [JsonProperty()]
        public string Message { get; set; }

        /// <summary>
        /// If set the command was not executed because of an error
        /// </summary>
        [JsonProperty()]
        public bool InError { get; set; }



        /// <summary>
        /// The amount of time it took for the command to execute
        /// </summary>
        [JsonProperty()]
        public TimeSpan ExecutionTime { get; set; }

        /// <summary>
        /// Empty constructor for serialising
        /// </summary>
        public FunctionResponse() { }


    }

    public class ProjectionFunctionResponse
        : FunctionResponse
    {
        /// <summary>
        /// The sequence number as of which the response was sent 
        /// </summary>
        [JsonProperty()]
        public int SequenceNumber { get; set; }


        /// <summary>
        /// Empty constructor for serialising
        /// </summary>
        public ProjectionFunctionResponse() { }



    }
}
