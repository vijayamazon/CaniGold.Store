// --------------------------------------------------------------------------------
// Copyright AspDotNetStorefront.com. All Rights Reserved.
// http://www.aspdotnetstorefront.com
// For details on this license please visit the product homepage at the URL above.
// THE ABOVE NOTICE MUST REMAIN INTACT. 
// --------------------------------------------------------------------------------
namespace AspDotNetStorefront.Models
{
	public class ProductViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string MetaTitle { get; set; }
		public string MetaDescription { get; set; }
		public string MetaKeywords { get; set; }
		public string PageTitle { get; set; }
		public string PageContent { get; set; }
		public bool LoginRequired { get; set; }
		public bool IsAKit { get; set; }
		public string XmlPackageName { get; set; }
		public int? CartRecordId { get; set; }
	}
}
