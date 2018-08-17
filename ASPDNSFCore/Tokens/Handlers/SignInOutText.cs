// --------------------------------------------------------------------------------
// Copyright AspDotNetStorefront.com. All Rights Reserved.
// http://www.aspdotnetstorefront.com
// For details on this license please visit the product homepage at the URL above.
// THE ABOVE NOTICE MUST REMAIN INTACT. 
// --------------------------------------------------------------------------------
using System;
using System.Linq;

namespace AspDotNetStorefrontCore.Tokens.Handlers
{
	public class SignInOutText : ITokenHandler
	{
		readonly string[] Tokens = { "signinout_text", "signinouttext" };

		public string RenderToken(TokenHandlerContext context)
		{
			if(!Tokens.Contains(context.Token, StringComparer.OrdinalIgnoreCase))
				return null;

			return context.Customer.IsRegistered
				? AppLogic.GetString("skinbase.cs.5", context.Customer.LocaleSetting)
				: AppLogic.GetString("skinbase.cs.4", context.Customer.LocaleSetting);
		}
	}
}
