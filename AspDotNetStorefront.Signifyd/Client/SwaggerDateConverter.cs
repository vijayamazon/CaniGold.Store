// --------------------------------------------------------------------------------
// Copyright AspDotNetStorefront.com. All Rights Reserved.
// http://www.aspdotnetstorefront.com
// For details on this license please visit the product homepage at the URL above.
// THE ABOVE NOTICE MUST REMAIN INTACT. 
// --------------------------------------------------------------------------------
/* 
 * Signifyd API
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json.Converters;

namespace AspDotNetStorefront.Signifyd.Client
{
	/// <summary>
	/// Formatter for 'date' swagger formats ss defined by full-date - RFC3339
	/// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types
	/// </summary>
	public class SwaggerDateConverter : IsoDateTimeConverter
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SwaggerDateConverter" /> class.
		/// </summary>
		public SwaggerDateConverter()
		{
			// full-date   = date-fullyear "-" date-month "-" date-mday
			DateTimeFormat = "yyyy-MM-dd";
		}
	}
}
