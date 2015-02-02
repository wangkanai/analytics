﻿using Analytics.Common;
using System.ComponentModel;

namespace Analytics
{
	public class ConfigObject : Field
	{
		[Description("Optional: Name of the tracker object")]
		public string Name { get; set; }
		[Description("Anonymously identifies a browser instance. By default, this value is stored as part of the first-party analytics tracking cookie with a two-year expiration.")]
		public string ClientId { get; set; }
		[Description("Optional: Specifies what percentage of users should be tracked. This defaults to 100 (no users are sampled out) but large sites may need to use a lower sample rate to stay within Google Analytics processing limits.")]
		public float SampleRate { get; set; }
		[Description("Optional: This setting determines how often site speed tracking beacons will be sent. By default, 1% of users will be automatically be tracked.Note: Analytics restricts Site Speed collection hits for a single property to the greater of 1% of users or 10K hits per day in order to ensure an equitable distribution of system resources for this feature.")]
		public int SiteSpeedSampleRate { get; set; }
		[Description("Optional: By default the HTTP referrer URL, which is used to attribute traffic sources, is only sent when the hostname of the referring site differs from the hostname of the current page. Enable this setting only if you want to process other pages from your current host as referrals.")]
		public bool AlwaysSendReferrer { get; set; }
		[Description("Optional: By default, analytics.js will search for custom campaign parameters such as utm_source, utm_medium, etc. in both the query string and anchor of the current page's URL. Setting this field to false will result in ignoring any custom campaign parameters that appear in the anchor.")]
		public bool AllowAnchor { get; set; }
		[Description("Optional: Name of the cookie used to store analytics data")]
		public string CookieName { get; set; }
		[Description("Optional: Specifies the domain used to store the analytics cookie. Setting this to 'none' sets the cookie without specifying a domain.")]
		public string CookieDomain { get; set; }
		[Description("Optional: Specifies the cookie expiration, in seconds.")]
		public int CookieExpires { get; set; }
		[Description("Optional: This field is used to configure how analytics.js searches for cookies generated by earlier Google Analytics tracking scripts such as ga.js and urchin.js.")]
		public string LegacyCookieDomain { get; set; }
		[Description("Optional: Setting this field to true will enables the parsing of cross-domain linker parmeters used to transfer state across domains.")]
		public bool AllowLinker { get; set; }
	}
}