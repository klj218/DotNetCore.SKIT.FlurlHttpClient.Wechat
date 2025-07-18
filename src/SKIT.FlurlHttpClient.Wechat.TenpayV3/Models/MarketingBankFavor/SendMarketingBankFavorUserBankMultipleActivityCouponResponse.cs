namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/bank-favor/users/{openid}/bank-multi-activity 接口的响应。</para>
    /// </summary>
    public class SendMarketingBankFavorUserBankMultipleActivityCouponResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置代金券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
        public string CouponId { get; set; } = default!;
    }
}
