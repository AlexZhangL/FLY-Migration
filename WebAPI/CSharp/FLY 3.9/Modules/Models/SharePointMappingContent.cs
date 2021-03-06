// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AvePoint.Migration.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SharePointMappingContent
    {
        /// <summary>
        /// Initializes a new instance of the SharePointMappingContent class.
        /// </summary>
        public SharePointMappingContent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharePointMappingContent class.
        /// </summary>
        /// <param name="method">Possible values include: 'Combine',
        /// 'Promote'</param>
        public SharePointMappingContent(SharePointObject source, SharePointObject destination, string method)
        {
            Source = source;
            Destination = destination;
            Method = method;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public SharePointObject Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        public SharePointObject Destination { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Combine', 'Promote'
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (Destination == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Destination");
            }
            if (Method == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Method");
            }
            if (Source != null)
            {
                Source.Validate();
            }
            if (Destination != null)
            {
                Destination.Validate();
            }
        }
    }
}
