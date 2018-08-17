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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = AspDotNetStorefront.Signifyd.Client.SwaggerDateConverter;

namespace AspDotNetStorefront.Signifyd.Model
{
    /// <summary>
    /// Defines PaymentMethod
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentMethod
    {
        
        /// <summary>
        /// Enum ACH for "ACH"
        /// </summary>
        [EnumMember(Value = "ACH")]
        ACH,
        
        /// <summary>
        /// Enum APPLEPAY for "APPLE_PAY"
        /// </summary>
        [EnumMember(Value = "APPLE_PAY")]
        APPLEPAY,
        
        /// <summary>
        /// Enum AMAZONPAYMENTS for "AMAZON_PAYMENTS"
        /// </summary>
        [EnumMember(Value = "AMAZON_PAYMENTS")]
        AMAZONPAYMENTS,
        
        /// <summary>
        /// Enum ANDROIDPAY for "ANDROID_PAY"
        /// </summary>
        [EnumMember(Value = "ANDROID_PAY")]
        ANDROIDPAY,
        
        /// <summary>
        /// Enum BITCOIN for "BITCOIN"
        /// </summary>
        [EnumMember(Value = "BITCOIN")]
        BITCOIN,
        
        /// <summary>
        /// Enum CASH for "CASH"
        /// </summary>
        [EnumMember(Value = "CASH")]
        CASH,
        
        /// <summary>
        /// Enum CHECK for "CHECK"
        /// </summary>
        [EnumMember(Value = "CHECK")]
        CHECK,
        
        /// <summary>
        /// Enum CREDITCARD for "CREDIT_CARD"
        /// </summary>
        [EnumMember(Value = "CREDIT_CARD")]
        CREDITCARD,
        
        /// <summary>
        /// Enum FREE for "FREE"
        /// </summary>
        [EnumMember(Value = "FREE")]
        FREE,
        
        /// <summary>
        /// Enum GOOGLEWALLET for "GOOGLE_WALLET"
        /// </summary>
        [EnumMember(Value = "GOOGLE_WALLET")]
        GOOGLEWALLET,
        
        /// <summary>
        /// Enum LOAN for "LOAN"
        /// </summary>
        [EnumMember(Value = "LOAN")]
        LOAN,
        
        /// <summary>
        /// Enum PAYPALACCOUNT for "PAYPAL_ACCOUNT"
        /// </summary>
        [EnumMember(Value = "PAYPAL_ACCOUNT")]
        PAYPALACCOUNT
    }

}