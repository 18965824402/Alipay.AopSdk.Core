using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiAdvertCommissionMissionQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiAdvertCommissionMissionQueryModel : AopObject
	{
		/// <summary>
		///     主键ID
		/// </summary>
		[XmlArray("identify_list")]
		[XmlArrayItem("string")]
		public List<string> IdentifyList { get; set; }

		/// <summary>
		///     主键类型  activity_id：运营活动ID  voucher：商品ID  mission：分佣任务ID
		/// </summary>
		[XmlElement("identify_type")]
		public string IdentifyType { get; set; }
	}
}