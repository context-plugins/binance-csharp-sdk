using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SourceType>))]
public sealed record SourceType : OpenStringEnum<SourceType>
{
    private SourceType(string value) : base(value)
    {
    }

    public static readonly SourceType MainSite = new("MAIN_SITE");

    public static readonly SourceType Tr = new("TR");

    public TResult Match<TResult>(Func<TResult> onMainSite, Func<TResult> onTr, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MainSite => onMainSite(),
            _ when this == Tr => onTr(),
            _ => otherwise(Value)
        };

    public void Match(Action onMainSite, Action onTr, Action<string> otherwise)
    {
        if (this == MainSite) onMainSite();
        else if (this == Tr) onTr();
        else otherwise(Value);
    }
}
