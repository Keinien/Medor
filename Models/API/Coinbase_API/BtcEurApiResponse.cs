using System.Text.Json.Serialization;

namespace Medor.Models.API.Coinbase_API;

public class BTCEUR
{
    [JsonPropertyName("TYPE")]
    public string TYPE { get; set; }

    [JsonPropertyName("MARKET")]
    public string MARKET { get; set; }

    [JsonPropertyName("INSTRUMENT")]
    public string INSTRUMENT { get; set; }

    [JsonPropertyName("MAPPED_INSTRUMENT")]
    public string MAPPED_INSTRUMENT { get; set; }

    [JsonPropertyName("BASE")]
    public string BASE { get; set; }

    [JsonPropertyName("QUOTE")]
    public string QUOTE { get; set; }

    [JsonPropertyName("BASE_ID")]
    public int BASE_ID { get; set; }

    [JsonPropertyName("QUOTE_ID")]
    public int QUOTE_ID { get; set; }

    [JsonPropertyName("TRANSFORM_FUNCTION")]
    public string TRANSFORM_FUNCTION { get; set; }

    [JsonPropertyName("CCSEQ")]
    public decimal CCSEQ { get; set; }

    [JsonPropertyName("PRICE")]
    public decimal PRICE { get; set; }

    [JsonPropertyName("PRICE_FLAG")]
    public string PRICE_FLAG { get; set; }

    [JsonPropertyName("PRICE_LAST_UPDATE_TS")]
    public decimal PRICE_LAST_UPDATE_TS { get; set; }

    [JsonPropertyName("PRICE_LAST_UPDATE_TS_NS")]
    public decimal PRICE_LAST_UPDATE_TS_NS { get; set; }

    [JsonPropertyName("LAST_TRADE_QUANTITY")]
    public decimal LAST_TRADE_QUANTITY { get; set; }

    [JsonPropertyName("LAST_TRADE_QUOTE_QUANTITY")]
    public decimal LAST_TRADE_QUOTE_QUANTITY { get; set; }

    [JsonPropertyName("LAST_TRADE_ID")]
    public string LAST_TRADE_ID { get; set; }

    [JsonPropertyName("LAST_TRADE_CCSEQ")]
    public decimal LAST_TRADE_CCSEQ { get; set; }

    [JsonPropertyName("LAST_TRADE_SIDE")]
    public string LAST_TRADE_SIDE { get; set; }

    [JsonPropertyName("LAST_PROCESSED_TRADE_TS")]
    public decimal LAST_PROCESSED_TRADE_TS { get; set; }

    [JsonPropertyName("LAST_PROCESSED_TRADE_TS_NS")]
    public decimal LAST_PROCESSED_TRADE_TS_NS { get; set; }

    [JsonPropertyName("LAST_PROCESSED_TRADE_PRICE")]
    public decimal LAST_PROCESSED_TRADE_PRICE { get; set; }

    [JsonPropertyName("LAST_PROCESSED_TRADE_QUANTITY")]
    public decimal LAST_PROCESSED_TRADE_QUANTITY { get; set; }

    [JsonPropertyName("LAST_PROCESSED_TRADE_QUOTE_QUANTITY")]
    public decimal LAST_PROCESSED_TRADE_QUOTE_QUANTITY { get; set; }

    [JsonPropertyName("LAST_PROCESSED_TRADE_SIDE")]
    public string LAST_PROCESSED_TRADE_SIDE { get; set; }

    [JsonPropertyName("LAST_PROCESSED_TRADE_CCSEQ")]
    public decimal LAST_PROCESSED_TRADE_CCSEQ { get; set; }

    [JsonPropertyName("CURRENT_HOUR_VOLUME")]
    public decimal CURRENT_HOUR_VOLUME { get; set; }

    [JsonPropertyName("CURRENT_HOUR_VOLUME_BUY")]
    public decimal CURRENT_HOUR_VOLUME_BUY { get; set; }

    [JsonPropertyName("CURRENT_HOUR_VOLUME_SELL")]
    public decimal CURRENT_HOUR_VOLUME_SELL { get; set; }

    [JsonPropertyName("CURRENT_HOUR_VOLUME_UNKNOWN")]
    public decimal CURRENT_HOUR_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_HOUR_QUOTE_VOLUME")]
    public decimal CURRENT_HOUR_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("CURRENT_HOUR_QUOTE_VOLUME_BUY")]
    public decimal CURRENT_HOUR_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("CURRENT_HOUR_QUOTE_VOLUME_SELL")]
    public decimal CURRENT_HOUR_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("CURRENT_HOUR_QUOTE_VOLUME_UNKNOWN")]
    public decimal CURRENT_HOUR_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_HOUR_OPEN")]
    public decimal CURRENT_HOUR_OPEN { get; set; }

    [JsonPropertyName("CURRENT_HOUR_HIGH")]
    public decimal CURRENT_HOUR_HIGH { get; set; }

    [JsonPropertyName("CURRENT_HOUR_LOW")]
    public decimal CURRENT_HOUR_LOW { get; set; }

    [JsonPropertyName("CURRENT_HOUR_TOTAL_TRADES")]
    public decimal CURRENT_HOUR_TOTAL_TRADES { get; set; }

    [JsonPropertyName("CURRENT_HOUR_TOTAL_TRADES_BUY")]
    public decimal CURRENT_HOUR_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("CURRENT_HOUR_TOTAL_TRADES_SELL")]
    public decimal CURRENT_HOUR_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("CURRENT_HOUR_TOTAL_TRADES_UNKNOWN")]
    public decimal CURRENT_HOUR_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_HOUR_CHANGE")]
    public decimal CURRENT_HOUR_CHANGE { get; set; }

    [JsonPropertyName("CURRENT_HOUR_CHANGE_PERCENTAGE")]
    public decimal CURRENT_HOUR_CHANGE_PERCENTAGE { get; set; }

    [JsonPropertyName("CURRENT_DAY_VOLUME")]
    public decimal CURRENT_DAY_VOLUME { get; set; }

    [JsonPropertyName("CURRENT_DAY_VOLUME_BUY")]
    public decimal CURRENT_DAY_VOLUME_BUY { get; set; }

    [JsonPropertyName("CURRENT_DAY_VOLUME_SELL")]
    public decimal CURRENT_DAY_VOLUME_SELL { get; set; }

    [JsonPropertyName("CURRENT_DAY_VOLUME_UNKNOWN")]
    public decimal CURRENT_DAY_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_DAY_QUOTE_VOLUME")]
    public decimal CURRENT_DAY_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("CURRENT_DAY_QUOTE_VOLUME_BUY")]
    public decimal CURRENT_DAY_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("CURRENT_DAY_QUOTE_VOLUME_SELL")]
    public decimal CURRENT_DAY_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("CURRENT_DAY_QUOTE_VOLUME_UNKNOWN")]
    public decimal CURRENT_DAY_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_DAY_OPEN")]
    public decimal CURRENT_DAY_OPEN { get; set; }

    [JsonPropertyName("CURRENT_DAY_HIGH")]
    public decimal CURRENT_DAY_HIGH { get; set; }

    [JsonPropertyName("CURRENT_DAY_LOW")]
    public decimal CURRENT_DAY_LOW { get; set; }

    [JsonPropertyName("CURRENT_DAY_TOTAL_TRADES")]
    public decimal CURRENT_DAY_TOTAL_TRADES { get; set; }

    [JsonPropertyName("CURRENT_DAY_TOTAL_TRADES_BUY")]
    public decimal CURRENT_DAY_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("CURRENT_DAY_TOTAL_TRADES_SELL")]
    public decimal CURRENT_DAY_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("CURRENT_DAY_TOTAL_TRADES_UNKNOWN")]
    public decimal CURRENT_DAY_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_DAY_CHANGE")]
    public decimal CURRENT_DAY_CHANGE { get; set; }

    [JsonPropertyName("CURRENT_DAY_CHANGE_PERCENTAGE")]
    public decimal CURRENT_DAY_CHANGE_PERCENTAGE { get; set; }

    [JsonPropertyName("CURRENT_WEEK_VOLUME")]
    public decimal CURRENT_WEEK_VOLUME { get; set; }

    [JsonPropertyName("CURRENT_WEEK_VOLUME_BUY")]
    public decimal CURRENT_WEEK_VOLUME_BUY { get; set; }

    [JsonPropertyName("CURRENT_WEEK_VOLUME_SELL")]
    public decimal CURRENT_WEEK_VOLUME_SELL { get; set; }

    [JsonPropertyName("CURRENT_WEEK_VOLUME_UNKNOWN")]
    public decimal CURRENT_WEEK_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_WEEK_QUOTE_VOLUME")]
    public decimal CURRENT_WEEK_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("CURRENT_WEEK_QUOTE_VOLUME_BUY")]
    public decimal CURRENT_WEEK_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("CURRENT_WEEK_QUOTE_VOLUME_SELL")]
    public decimal CURRENT_WEEK_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("CURRENT_WEEK_QUOTE_VOLUME_UNKNOWN")]
    public decimal CURRENT_WEEK_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_WEEK_OPEN")]
    public decimal CURRENT_WEEK_OPEN { get; set; }

    [JsonPropertyName("CURRENT_WEEK_HIGH")]
    public decimal CURRENT_WEEK_HIGH { get; set; }

    [JsonPropertyName("CURRENT_WEEK_LOW")]
    public decimal CURRENT_WEEK_LOW { get; set; }

    [JsonPropertyName("CURRENT_WEEK_TOTAL_TRADES")]
    public decimal CURRENT_WEEK_TOTAL_TRADES { get; set; }

    [JsonPropertyName("CURRENT_WEEK_TOTAL_TRADES_BUY")]
    public decimal CURRENT_WEEK_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("CURRENT_WEEK_TOTAL_TRADES_SELL")]
    public decimal CURRENT_WEEK_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("CURRENT_WEEK_TOTAL_TRADES_UNKNOWN")]
    public decimal CURRENT_WEEK_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_WEEK_CHANGE")]
    public decimal CURRENT_WEEK_CHANGE { get; set; }

    [JsonPropertyName("CURRENT_WEEK_CHANGE_PERCENTAGE")]
    public decimal CURRENT_WEEK_CHANGE_PERCENTAGE { get; set; }

    [JsonPropertyName("CURRENT_MONTH_VOLUME")]
    public decimal CURRENT_MONTH_VOLUME { get; set; }

    [JsonPropertyName("CURRENT_MONTH_VOLUME_BUY")]
    public decimal CURRENT_MONTH_VOLUME_BUY { get; set; }

    [JsonPropertyName("CURRENT_MONTH_VOLUME_SELL")]
    public decimal CURRENT_MONTH_VOLUME_SELL { get; set; }

    [JsonPropertyName("CURRENT_MONTH_VOLUME_UNKNOWN")]
    public decimal CURRENT_MONTH_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_MONTH_QUOTE_VOLUME")]
    public decimal CURRENT_MONTH_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("CURRENT_MONTH_QUOTE_VOLUME_BUY")]
    public decimal CURRENT_MONTH_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("CURRENT_MONTH_QUOTE_VOLUME_SELL")]
    public decimal CURRENT_MONTH_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("CURRENT_MONTH_QUOTE_VOLUME_UNKNOWN")]
    public decimal CURRENT_MONTH_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_MONTH_OPEN")]
    public decimal CURRENT_MONTH_OPEN { get; set; }

    [JsonPropertyName("CURRENT_MONTH_HIGH")]
    public decimal CURRENT_MONTH_HIGH { get; set; }

    [JsonPropertyName("CURRENT_MONTH_LOW")]
    public decimal CURRENT_MONTH_LOW { get; set; }

    [JsonPropertyName("CURRENT_MONTH_TOTAL_TRADES")]
    public decimal CURRENT_MONTH_TOTAL_TRADES { get; set; }

    [JsonPropertyName("CURRENT_MONTH_TOTAL_TRADES_BUY")]
    public decimal CURRENT_MONTH_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("CURRENT_MONTH_TOTAL_TRADES_SELL")]
    public decimal CURRENT_MONTH_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("CURRENT_MONTH_TOTAL_TRADES_UNKNOWN")]
    public decimal CURRENT_MONTH_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_MONTH_CHANGE")]
    public decimal CURRENT_MONTH_CHANGE { get; set; }

    [JsonPropertyName("CURRENT_MONTH_CHANGE_PERCENTAGE")]
    public decimal CURRENT_MONTH_CHANGE_PERCENTAGE { get; set; }

    [JsonPropertyName("CURRENT_YEAR_VOLUME")]
    public decimal CURRENT_YEAR_VOLUME { get; set; }

    [JsonPropertyName("CURRENT_YEAR_VOLUME_BUY")]
    public decimal CURRENT_YEAR_VOLUME_BUY { get; set; }

    [JsonPropertyName("CURRENT_YEAR_VOLUME_SELL")]
    public decimal CURRENT_YEAR_VOLUME_SELL { get; set; }

    [JsonPropertyName("CURRENT_YEAR_VOLUME_UNKNOWN")]
    public decimal CURRENT_YEAR_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_YEAR_QUOTE_VOLUME")]
    public decimal CURRENT_YEAR_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("CURRENT_YEAR_QUOTE_VOLUME_BUY")]
    public decimal CURRENT_YEAR_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("CURRENT_YEAR_QUOTE_VOLUME_SELL")]
    public decimal CURRENT_YEAR_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("CURRENT_YEAR_QUOTE_VOLUME_UNKNOWN")]
    public decimal CURRENT_YEAR_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_YEAR_OPEN")]
    public decimal CURRENT_YEAR_OPEN { get; set; }

    [JsonPropertyName("CURRENT_YEAR_HIGH")]
    public decimal CURRENT_YEAR_HIGH { get; set; }

    [JsonPropertyName("CURRENT_YEAR_LOW")]
    public decimal CURRENT_YEAR_LOW { get; set; }

    [JsonPropertyName("CURRENT_YEAR_TOTAL_TRADES")]
    public decimal CURRENT_YEAR_TOTAL_TRADES { get; set; }

    [JsonPropertyName("CURRENT_YEAR_TOTAL_TRADES_BUY")]
    public decimal CURRENT_YEAR_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("CURRENT_YEAR_TOTAL_TRADES_SELL")]
    public decimal CURRENT_YEAR_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("CURRENT_YEAR_TOTAL_TRADES_UNKNOWN")]
    public decimal CURRENT_YEAR_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("CURRENT_YEAR_CHANGE")]
    public decimal CURRENT_YEAR_CHANGE { get; set; }

    [JsonPropertyName("CURRENT_YEAR_CHANGE_PERCENTAGE")]
    public decimal CURRENT_YEAR_CHANGE_PERCENTAGE { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_VOLUME")]
    public decimal MOVING_24_HOUR_VOLUME { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_VOLUME_BUY")]
    public decimal MOVING_24_HOUR_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_VOLUME_SELL")]
    public decimal MOVING_24_HOUR_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_VOLUME_UNKNOWN")]
    public decimal MOVING_24_HOUR_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_QUOTE_VOLUME")]
    public decimal MOVING_24_HOUR_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_QUOTE_VOLUME_BUY")]
    public decimal MOVING_24_HOUR_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_QUOTE_VOLUME_SELL")]
    public decimal MOVING_24_HOUR_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_QUOTE_VOLUME_UNKNOWN")]
    public decimal MOVING_24_HOUR_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_OPEN")]
    public decimal MOVING_24_HOUR_OPEN { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_HIGH")]
    public decimal MOVING_24_HOUR_HIGH { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_LOW")]
    public decimal MOVING_24_HOUR_LOW { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_TOTAL_TRADES")]
    public decimal MOVING_24_HOUR_TOTAL_TRADES { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_TOTAL_TRADES_BUY")]
    public decimal MOVING_24_HOUR_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_TOTAL_TRADES_SELL")]
    public decimal MOVING_24_HOUR_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_TOTAL_TRADES_UNKNOWN")]
    public decimal MOVING_24_HOUR_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_CHANGE")]
    public decimal MOVING_24_HOUR_CHANGE { get; set; }

    [JsonPropertyName("MOVING_24_HOUR_CHANGE_PERCENTAGE")]
    public decimal MOVING_24_HOUR_CHANGE_PERCENTAGE { get; set; }

    [JsonPropertyName("MOVING_7_DAY_VOLUME")]
    public decimal MOVING_7_DAY_VOLUME { get; set; }

    [JsonPropertyName("MOVING_7_DAY_VOLUME_BUY")]
    public decimal MOVING_7_DAY_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_7_DAY_VOLUME_SELL")]
    public decimal MOVING_7_DAY_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_7_DAY_VOLUME_UNKNOWN")]
    public decimal MOVING_7_DAY_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_7_DAY_QUOTE_VOLUME")]
    public decimal MOVING_7_DAY_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("MOVING_7_DAY_QUOTE_VOLUME_BUY")]
    public decimal MOVING_7_DAY_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_7_DAY_QUOTE_VOLUME_SELL")]
    public decimal MOVING_7_DAY_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_7_DAY_QUOTE_VOLUME_UNKNOWN")]
    public decimal MOVING_7_DAY_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_7_DAY_OPEN")]
    public decimal MOVING_7_DAY_OPEN { get; set; }

    [JsonPropertyName("MOVING_7_DAY_HIGH")]
    public decimal MOVING_7_DAY_HIGH { get; set; }

    [JsonPropertyName("MOVING_7_DAY_LOW")]
    public decimal MOVING_7_DAY_LOW { get; set; }

    [JsonPropertyName("MOVING_7_DAY_TOTAL_TRADES")]
    public decimal MOVING_7_DAY_TOTAL_TRADES { get; set; }

    [JsonPropertyName("MOVING_7_DAY_TOTAL_TRADES_BUY")]
    public decimal MOVING_7_DAY_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("MOVING_7_DAY_TOTAL_TRADES_SELL")]
    public decimal MOVING_7_DAY_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("MOVING_7_DAY_TOTAL_TRADES_UNKNOWN")]
    public decimal MOVING_7_DAY_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_7_DAY_CHANGE")]
    public decimal MOVING_7_DAY_CHANGE { get; set; }

    [JsonPropertyName("MOVING_7_DAY_CHANGE_PERCENTAGE")]
    public decimal MOVING_7_DAY_CHANGE_PERCENTAGE { get; set; }

    [JsonPropertyName("MOVING_30_DAY_VOLUME")]
    public decimal MOVING_30_DAY_VOLUME { get; set; }

    [JsonPropertyName("MOVING_30_DAY_VOLUME_BUY")]
    public decimal MOVING_30_DAY_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_30_DAY_VOLUME_SELL")]
    public decimal MOVING_30_DAY_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_30_DAY_VOLUME_UNKNOWN")]
    public decimal MOVING_30_DAY_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_30_DAY_QUOTE_VOLUME")]
    public decimal MOVING_30_DAY_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("MOVING_30_DAY_QUOTE_VOLUME_BUY")]
    public decimal MOVING_30_DAY_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_30_DAY_QUOTE_VOLUME_SELL")]
    public decimal MOVING_30_DAY_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_30_DAY_QUOTE_VOLUME_UNKNOWN")]
    public decimal MOVING_30_DAY_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_30_DAY_OPEN")]
    public decimal MOVING_30_DAY_OPEN { get; set; }

    [JsonPropertyName("MOVING_30_DAY_HIGH")]
    public decimal MOVING_30_DAY_HIGH { get; set; }

    [JsonPropertyName("MOVING_30_DAY_LOW")]
    public decimal MOVING_30_DAY_LOW { get; set; }

    [JsonPropertyName("MOVING_30_DAY_TOTAL_TRADES")]
    public decimal MOVING_30_DAY_TOTAL_TRADES { get; set; }

    [JsonPropertyName("MOVING_30_DAY_TOTAL_TRADES_BUY")]
    public decimal MOVING_30_DAY_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("MOVING_30_DAY_TOTAL_TRADES_SELL")]
    public decimal MOVING_30_DAY_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("MOVING_30_DAY_TOTAL_TRADES_UNKNOWN")]
    public decimal MOVING_30_DAY_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_30_DAY_CHANGE")]
    public decimal MOVING_30_DAY_CHANGE { get; set; }

    [JsonPropertyName("MOVING_30_DAY_CHANGE_PERCENTAGE")]
    public decimal MOVING_30_DAY_CHANGE_PERCENTAGE { get; set; }

    [JsonPropertyName("MOVING_90_DAY_VOLUME")]
    public decimal MOVING_90_DAY_VOLUME { get; set; }

    [JsonPropertyName("MOVING_90_DAY_VOLUME_BUY")]
    public decimal MOVING_90_DAY_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_90_DAY_VOLUME_SELL")]
    public decimal MOVING_90_DAY_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_90_DAY_VOLUME_UNKNOWN")]
    public decimal MOVING_90_DAY_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_90_DAY_QUOTE_VOLUME")]
    public decimal MOVING_90_DAY_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("MOVING_90_DAY_QUOTE_VOLUME_BUY")]
    public decimal MOVING_90_DAY_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_90_DAY_QUOTE_VOLUME_SELL")]
    public decimal MOVING_90_DAY_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_90_DAY_QUOTE_VOLUME_UNKNOWN")]
    public decimal MOVING_90_DAY_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_90_DAY_OPEN")]
    public decimal MOVING_90_DAY_OPEN { get; set; }

    [JsonPropertyName("MOVING_90_DAY_HIGH")]
    public decimal MOVING_90_DAY_HIGH { get; set; }

    [JsonPropertyName("MOVING_90_DAY_LOW")]
    public decimal MOVING_90_DAY_LOW { get; set; }

    [JsonPropertyName("MOVING_90_DAY_TOTAL_TRADES")]
    public decimal MOVING_90_DAY_TOTAL_TRADES { get; set; }

    [JsonPropertyName("MOVING_90_DAY_TOTAL_TRADES_BUY")]
    public decimal MOVING_90_DAY_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("MOVING_90_DAY_TOTAL_TRADES_SELL")]
    public decimal MOVING_90_DAY_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("MOVING_90_DAY_TOTAL_TRADES_UNKNOWN")]
    public decimal MOVING_90_DAY_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_90_DAY_CHANGE")]
    public decimal MOVING_90_DAY_CHANGE { get; set; }

    [JsonPropertyName("MOVING_90_DAY_CHANGE_PERCENTAGE")]
    public decimal MOVING_90_DAY_CHANGE_PERCENTAGE { get; set; }

    [JsonPropertyName("MOVING_180_DAY_VOLUME")]
    public decimal MOVING_180_DAY_VOLUME { get; set; }

    [JsonPropertyName("MOVING_180_DAY_VOLUME_BUY")]
    public decimal MOVING_180_DAY_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_180_DAY_VOLUME_SELL")]
    public decimal MOVING_180_DAY_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_180_DAY_VOLUME_UNKNOWN")]
    public decimal MOVING_180_DAY_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_180_DAY_QUOTE_VOLUME")]
    public decimal MOVING_180_DAY_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("MOVING_180_DAY_QUOTE_VOLUME_BUY")]
    public decimal MOVING_180_DAY_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_180_DAY_QUOTE_VOLUME_SELL")]
    public decimal MOVING_180_DAY_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_180_DAY_QUOTE_VOLUME_UNKNOWN")]
    public decimal MOVING_180_DAY_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_180_DAY_OPEN")]
    public decimal MOVING_180_DAY_OPEN { get; set; }

    [JsonPropertyName("MOVING_180_DAY_HIGH")]
    public decimal MOVING_180_DAY_HIGH { get; set; }

    [JsonPropertyName("MOVING_180_DAY_LOW")]
    public decimal MOVING_180_DAY_LOW { get; set; }

    [JsonPropertyName("MOVING_180_DAY_TOTAL_TRADES")]
    public decimal MOVING_180_DAY_TOTAL_TRADES { get; set; }

    [JsonPropertyName("MOVING_180_DAY_TOTAL_TRADES_BUY")]
    public decimal MOVING_180_DAY_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("MOVING_180_DAY_TOTAL_TRADES_SELL")]
    public decimal MOVING_180_DAY_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("MOVING_180_DAY_TOTAL_TRADES_UNKNOWN")]
    public decimal MOVING_180_DAY_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_180_DAY_CHANGE")]
    public decimal MOVING_180_DAY_CHANGE { get; set; }

    [JsonPropertyName("MOVING_180_DAY_CHANGE_PERCENTAGE")]
    public decimal MOVING_180_DAY_CHANGE_PERCENTAGE { get; set; }

    [JsonPropertyName("MOVING_365_DAY_VOLUME")]
    public decimal MOVING_365_DAY_VOLUME { get; set; }

    [JsonPropertyName("MOVING_365_DAY_VOLUME_BUY")]
    public decimal MOVING_365_DAY_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_365_DAY_VOLUME_SELL")]
    public decimal MOVING_365_DAY_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_365_DAY_VOLUME_UNKNOWN")]
    public decimal MOVING_365_DAY_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_365_DAY_QUOTE_VOLUME")]
    public decimal MOVING_365_DAY_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("MOVING_365_DAY_QUOTE_VOLUME_BUY")]
    public decimal MOVING_365_DAY_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("MOVING_365_DAY_QUOTE_VOLUME_SELL")]
    public decimal MOVING_365_DAY_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("MOVING_365_DAY_QUOTE_VOLUME_UNKNOWN")]
    public decimal MOVING_365_DAY_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_365_DAY_OPEN")]
    public decimal MOVING_365_DAY_OPEN { get; set; }

    [JsonPropertyName("MOVING_365_DAY_HIGH")]
    public decimal MOVING_365_DAY_HIGH { get; set; }

    [JsonPropertyName("MOVING_365_DAY_LOW")]
    public decimal MOVING_365_DAY_LOW { get; set; }

    [JsonPropertyName("MOVING_365_DAY_TOTAL_TRADES")]
    public decimal MOVING_365_DAY_TOTAL_TRADES { get; set; }

    [JsonPropertyName("MOVING_365_DAY_TOTAL_TRADES_BUY")]
    public decimal MOVING_365_DAY_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("MOVING_365_DAY_TOTAL_TRADES_SELL")]
    public decimal MOVING_365_DAY_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("MOVING_365_DAY_TOTAL_TRADES_UNKNOWN")]
    public decimal MOVING_365_DAY_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("MOVING_365_DAY_CHANGE")]
    public decimal MOVING_365_DAY_CHANGE { get; set; }

    [JsonPropertyName("MOVING_365_DAY_CHANGE_PERCENTAGE")]
    public decimal MOVING_365_DAY_CHANGE_PERCENTAGE { get; set; }

    [JsonPropertyName("LIFETIME_FIRST_TRADE_TS")]
    public decimal LIFETIME_FIRST_TRADE_TS { get; set; }

    [JsonPropertyName("LIFETIME_VOLUME")]
    public decimal LIFETIME_VOLUME { get; set; }

    [JsonPropertyName("LIFETIME_VOLUME_BUY")]
    public decimal LIFETIME_VOLUME_BUY { get; set; }

    [JsonPropertyName("LIFETIME_VOLUME_SELL")]
    public decimal LIFETIME_VOLUME_SELL { get; set; }

    [JsonPropertyName("LIFETIME_VOLUME_UNKNOWN")]
    public decimal LIFETIME_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("LIFETIME_QUOTE_VOLUME")]
    public decimal LIFETIME_QUOTE_VOLUME { get; set; }

    [JsonPropertyName("LIFETIME_QUOTE_VOLUME_BUY")]
    public decimal LIFETIME_QUOTE_VOLUME_BUY { get; set; }

    [JsonPropertyName("LIFETIME_QUOTE_VOLUME_SELL")]
    public decimal LIFETIME_QUOTE_VOLUME_SELL { get; set; }

    [JsonPropertyName("LIFETIME_QUOTE_VOLUME_UNKNOWN")]
    public decimal LIFETIME_QUOTE_VOLUME_UNKNOWN { get; set; }

    [JsonPropertyName("LIFETIME_OPEN")]
    public decimal LIFETIME_OPEN { get; set; }

    [JsonPropertyName("LIFETIME_HIGH")]
    public decimal LIFETIME_HIGH { get; set; }

    [JsonPropertyName("LIFETIME_HIGH_TS")]
    public decimal LIFETIME_HIGH_TS { get; set; }

    [JsonPropertyName("LIFETIME_LOW")]
    public decimal LIFETIME_LOW { get; set; }

    [JsonPropertyName("LIFETIME_LOW_TS")]
    public decimal LIFETIME_LOW_TS { get; set; }

    [JsonPropertyName("LIFETIME_TOTAL_TRADES")]
    public decimal LIFETIME_TOTAL_TRADES { get; set; }

    [JsonPropertyName("LIFETIME_TOTAL_TRADES_BUY")]
    public decimal LIFETIME_TOTAL_TRADES_BUY { get; set; }

    [JsonPropertyName("LIFETIME_TOTAL_TRADES_SELL")]
    public decimal LIFETIME_TOTAL_TRADES_SELL { get; set; }

    [JsonPropertyName("LIFETIME_TOTAL_TRADES_UNKNOWN")]
    public decimal LIFETIME_TOTAL_TRADES_UNKNOWN { get; set; }

    [JsonPropertyName("LIFETIME_CHANGE")]
    public decimal LIFETIME_CHANGE { get; set; }

    [JsonPropertyName("LIFETIME_CHANGE_PERCENTAGE")]
    public decimal LIFETIME_CHANGE_PERCENTAGE { get; set; }
}

public class Data
{
    [JsonPropertyName("BTC-EUR")]
    public BTCEUR BTCEUR { get; set; }
}

public class Err
{
}

public class Root
{
    [JsonPropertyName("Data")]
    public Data Data { get; set; }

    [JsonPropertyName("Err")]
    public Err Err { get; set; }

    [JsonPropertyName("EURCZE")]
    public decimal EURCZE { get; set; }
}