using System;
using System.Text.Json.Serialization;
using Binance.Core.Enum;

namespace Binance.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Transfers>))]
public sealed record Transfers : OpenStringEnum<Transfers>
{
    private Transfers(string value) : base(value)
    {
    }

    public static readonly Transfers From = new("FROM");

    public static readonly Transfers To = new("TO");

    public TResult Match<TResult>(Func<TResult> onFrom, Func<TResult> onTo, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == From => onFrom(),
            _ when this == To => onTo(),
            _ => otherwise(Value)
        };

    public void Match(Action onFrom, Action onTo, Action<string> otherwise)
    {
        if (this == From) onFrom();
        else if (this == To) onTo();
        else otherwise(Value);
    }
}
