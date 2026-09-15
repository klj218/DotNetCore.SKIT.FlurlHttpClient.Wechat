namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/headsupplierrelation/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierRelationUpdateRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierRelationUpdateRequest, ChannelsECLeagueHeadSupplierRelationUpdateResponse>
    {
        /// <summary>
        /// 获取或设置对象类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("object_type")]
        [System.Text.Json.Serialization.JsonPropertyName("object_type")]
        public int ObjectType { get; set; }

        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("to_shop_appid")]
        public string? ToShopAppId { get; set; }

        /// <summary>
        /// 获取或设置机构 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_head_supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("to_head_supplier_appid")]
        public string? ToHeadSupplierAppId { get; set; }

        /// <summary>
        /// 获取或设置小店合作关系更新类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_update_type")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_update_type")]
        public int? ShopUpdateType { get; set; }

        /// <summary>
        /// 获取或设置机构合作关系更新类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hs_update_type")]
        [System.Text.Json.Serialization.JsonPropertyName("hs_update_type")]
        public int? HeadSupplierUpdateType { get; set; }
    }
}
