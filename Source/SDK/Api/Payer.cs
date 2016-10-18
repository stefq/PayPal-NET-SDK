//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    /// Information about a PayPal account making a payment.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class Payer : PayPalSerializableObject
    {
        /// <summary>
        /// Payment method being used - PayPal Wallet payment, Bank Direct Debit  or Direct Credit card.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_method")]
        public string payment_method { get; set; }

        /// <summary>
        /// Status of payer's PayPal Account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status")]
        public string status { get; set; }

        /// <summary>
        /// Type of account relationship payer has with PayPal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_type")]
        public string account_type { get; set; }

        /// <summary>
        /// Duration since the payer established account relationship with PayPal in days.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_age")]
        public string account_age { get; set; }

        /// <summary>
        /// List of funding instruments to fund the payment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "funding_instruments")]
        public List<FundingInstrument> funding_instruments { get; set; }

        /// <summary>
        /// Id of user selected funding option for the payment. 'OneOf' funding_instruments or funding_option_id to be present 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "funding_option_id")]
        public string funding_option_id { get; set; }

        /// <summary>
        /// Default funding option available for the payment 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "funding_option")]
        public FundingOption funding_option { get; set; }

        /// <summary>
        /// Funding option related to default funding option.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "related_funding_option")]
        public FundingOption related_funding_option { get; set; }

        /// <summary>
        /// Information related to the Payer. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payer_info")]
        public PayerInfo payer_info { get; set; }
    }
}