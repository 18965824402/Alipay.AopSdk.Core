using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiItemExtitemQueryResponse.
	/// </summary>
	public class KoubeiItemExtitemQueryResponse : AopResponse
	{
		/// <summary>
		///     商品信息
		/// </summary>
		[XmlElement("extitem")]
		public ExtItem Extitem { get; set; }
	}
}