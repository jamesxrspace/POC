// <auto-generated />
//
// To parse this JSON data, add NuGet 'System.Text.Json' then do:
//
//    using TPFive.Ugc.GetCurrentEnvironment.Generated;
//
//    var getEnvironmentContent = GetEnvironmentContent.FromJson(jsonString);
#nullable enable
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603

namespace TPFive.Ugc.GetCurrentEnvironment.Generated
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;

    public partial class GetEnvironmentContent
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("projectId")]
        public string ProjectId { get; set; }

        [JsonPropertyName("isDefault")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("archivedAt")]
        public DateTimeOffset ArchivedAt { get; set; }

        [JsonPropertyName("deletedAt")]
        public DateTimeOffset DeletedAt { get; set; }

        [JsonPropertyName("statistics")]
        public Statistics Statistics { get; set; }
    }

    public partial class Statistics
    {
        [JsonPropertyName("allTime")]
        public AllTime AllTime { get; set; }

        [JsonPropertyName("past365Days")]
        public AllTime Past365Days { get; set; }

        [JsonPropertyName("past180Days")]
        public AllTime Past180Days { get; set; }

        [JsonPropertyName("past90Days")]
        public AllTime Past90Days { get; set; }

        [JsonPropertyName("past60Days")]
        public AllTime Past60Days { get; set; }

        [JsonPropertyName("past30Days")]
        public AllTime Past30Days { get; set; }

        [JsonPropertyName("past14Days")]
        public AllTime Past14Days { get; set; }

        [JsonPropertyName("past7Days")]
        public AllTime Past7Days { get; set; }

        [JsonPropertyName("pastDay")]
        public AllTime PastDay { get; set; }

        [JsonPropertyName("contentCount")]
        public Dictionary<string, long> ContentCount { get; set; }

        [JsonPropertyName("downloadCount")]
        public Dictionary<string, long> DownloadCount { get; set; }

        [JsonPropertyName("subscriptionCount")]
        public Dictionary<string, long> SubscriptionCount { get; set; }

        [JsonPropertyName("reportCount")]
        public Dictionary<string, long> ReportCount { get; set; }
    }

    public partial class AllTime
    {
        [JsonPropertyName("contentCount")]
        public long ContentCount { get; set; }

        [JsonPropertyName("downloadedContentCount")]
        public long DownloadedContentCount { get; set; }

        [JsonPropertyName("subscriptionCount")]
        public long SubscriptionCount { get; set; }

        [JsonPropertyName("reportsCount")]
        public long ReportsCount { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class GetEnvironmentContent
    {
        public static List<GetEnvironmentContent> FromJson(string json) => JsonSerializer.Deserialize<List<GetEnvironmentContent>>(json, TPFive.Ugc.GetCurrentEnvironment.Generated.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<GetEnvironmentContent> self) => JsonSerializer.Serialize(self, TPFive.Ugc.GetCurrentEnvironment.Generated.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }

    public class DateOnlyConverter : JsonConverter<DateOnly>
    {
        private readonly string serializationFormat;
        public DateOnlyConverter() : this(null) { }

        public DateOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "yyyy-MM-dd";
        }

        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return DateOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    public class TimeOnlyConverter : JsonConverter<TimeOnly>
    {
        private readonly string serializationFormat;

        public TimeOnlyConverter() : this(null) { }

        public TimeOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "HH:mm:ss.fff";
        }

        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return TimeOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    internal class IsoDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        public override bool CanConvert(Type t) => t == typeof(DateTimeOffset);

        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;
        private string? _dateTimeFormat;
        private CultureInfo? _culture;

        public DateTimeStyles DateTimeStyles
        {
            get => _dateTimeStyles;
            set => _dateTimeStyles = value;
        }

        public string? DateTimeFormat
        {
            get => _dateTimeFormat ?? string.Empty;
            set => _dateTimeFormat = (string.IsNullOrEmpty(value)) ? null : value;
        }

        public CultureInfo Culture
        {
            get => _culture ?? CultureInfo.CurrentCulture;
            set => _culture = value;
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            string text;


            if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
            {
                value = value.ToUniversalTime();
            }

            text = value.ToString(_dateTimeFormat ?? DefaultDateTimeFormat, Culture);

            writer.WriteStringValue(text);
        }

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? dateText = reader.GetString();

            if (string.IsNullOrEmpty(dateText) == false)
            {
                if (!string.IsNullOrEmpty(_dateTimeFormat))
                {
                    return DateTimeOffset.ParseExact(dateText, _dateTimeFormat, Culture, _dateTimeStyles);
                }
                else
                {
                    return DateTimeOffset.Parse(dateText, Culture, _dateTimeStyles);
                }
            }
            else
            {
                return default(DateTimeOffset);
            }
        }


        public static readonly IsoDateTimeOffsetConverter Singleton = new IsoDateTimeOffsetConverter();
    }
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603
