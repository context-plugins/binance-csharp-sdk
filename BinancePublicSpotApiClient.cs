using System.Net.Http;
using BinancePublicSpotApi.Api;
using BinancePublicSpotApi.Core;
using BinancePublicSpotApi.Core.Logging;
using BinancePublicSpotApi.Core.Models;

namespace BinancePublicSpotApi;

/// <summary>
/// OpenAPI Specifications for the Binance Public Spot API
/// <para>
/// API documents:
///   - <see href="https://github.com/binance/binance-spot-api-docs">https://github.com/binance/binance-spot-api-docs</see>
///   - <see href="https://binance-docs.github.io/apidocs/spot/en">https://binance-docs.github.io/apidocs/spot/en</see>
/// </para>
/// </summary>
public sealed class BinancePublicSpotApiClient
{
    public BinancePublicSpotApiClient(HttpClient httpClient, BinancePublicSpotApiClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "BinancePublicSpotApiClient/1.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "1.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "BinancePublicSpotApiClient");
        var rawClient =
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory, httpLogger);
        var auth = new AuthSchemes(options);
        AutoInvest = new AutoInvest(rawClient, server, auth);
        Blvt = new Blvt(rawClient, server, auth);
        C2C = new C2C(rawClient, server, auth);
        ConvertApi = new ConvertApi(rawClient, server, auth);
        CopyTrading = new CopyTrading(rawClient, server, auth);
        CryptoLoans = new CryptoLoans(rawClient, server, auth);
        DualInvestment = new DualInvestment(rawClient, server, auth);
        Fiat = new Fiat(rawClient, server, auth);
        Futures = new Futures(rawClient, server, auth);
        FuturesAlgo = new FuturesAlgo(rawClient, server, auth);
        GiftCard = new GiftCard(rawClient, server, auth);
        IsolatedMarginStream = new IsolatedMarginStream(rawClient, server, auth);
        Margin = new Margin(rawClient, server, auth);
        MarginStream = new MarginStream(rawClient, server, auth);
        Market = new Market(rawClient, server);
        Mining = new Mining(rawClient, server, auth);
        Nft = new Nft(rawClient, server, auth);
        Pay = new Pay(rawClient, server, auth);
        PortfolioMargin = new PortfolioMargin(rawClient, server, auth);
        Rebate = new Rebate(rawClient, server, auth);
        Savings = new Savings(rawClient, server, auth);
        SimpleEarn = new SimpleEarn(rawClient, server, auth);
        SpotAlgo = new SpotAlgo(rawClient, server, auth);
        Staking = new Staking(rawClient, server, auth);
        StreamApi = new StreamApi(rawClient, server, auth);
        SubAccountApi = new SubAccountApi(rawClient, server, auth);
        TradeApi = new TradeApi(rawClient, server, auth);
        VipLoans = new VipLoans(rawClient, server, auth);
        Wallet = new Wallet(rawClient, server, auth);
    }

    /// <summary>
    /// Auto-Invest Endpoints
    /// </summary>
    public AutoInvest AutoInvest { get; }

    /// <summary>
    /// Binance Leveraged Tokens Endpoints
    /// </summary>
    public Blvt Blvt { get; }

    /// <summary>
    /// Consumer-To-Consumer Endpoints
    /// </summary>
    public C2C C2C { get; }

    /// <summary>
    /// Convert Endpoints
    /// </summary>
    public ConvertApi ConvertApi { get; }

    /// <summary>
    /// Copy Trading Endpoints
    /// </summary>
    public CopyTrading CopyTrading { get; }

    /// <summary>
    /// Crypto Loans Endpoints
    /// </summary>
    public CryptoLoans CryptoLoans { get; }

    public DualInvestment DualInvestment { get; }

    /// <summary>
    /// Fiat Endpoints
    /// </summary>
    public Fiat Fiat { get; }

    /// <summary>
    /// Futures Endpoints
    /// </summary>
    public Futures Futures { get; }

    /// <summary>
    /// Futures Algo Endpoints
    /// </summary>
    public FuturesAlgo FuturesAlgo { get; }

    /// <summary>
    /// Gift Card Endpoints
    /// </summary>
    public GiftCard GiftCard { get; }

    /// <summary>
    /// Isolated User Data Stream
    /// </summary>
    public IsolatedMarginStream IsolatedMarginStream { get; }

    /// <summary>
    /// Margin Account/Trade
    /// </summary>
    public Margin Margin { get; }

    /// <summary>
    /// Margin User Data Stream
    /// </summary>
    public MarginStream MarginStream { get; }

    /// <summary>
    /// Market Data
    /// </summary>
    public Market Market { get; }

    /// <summary>
    /// Mining Endpoints
    /// </summary>
    public Mining Mining { get; }

    /// <summary>
    /// NFT Endpoints
    /// </summary>
    public Nft Nft { get; }

    /// <summary>
    /// Pay Endpoints
    /// </summary>
    public Pay Pay { get; }

    /// <summary>
    /// Portfolio Margin Endpoints
    /// </summary>
    public PortfolioMargin PortfolioMargin { get; }

    /// <summary>
    /// Rebate Endpoints
    /// </summary>
    public Rebate Rebate { get; }

    /// <summary>
    /// Savings Endpoints
    /// </summary>
    public Savings Savings { get; }

    /// <summary>
    /// Simple Earn Endpoints
    /// </summary>
    public SimpleEarn SimpleEarn { get; }

    /// <summary>
    /// Spot Algo Endpoints
    /// </summary>
    public SpotAlgo SpotAlgo { get; }

    public Staking Staking { get; }

    /// <summary>
    /// User Data Stream
    /// </summary>
    public StreamApi StreamApi { get; }

    /// <summary>
    /// Sub-account Endpoints
    /// </summary>
    public SubAccountApi SubAccountApi { get; }

    /// <summary>
    /// Account/Trade
    /// </summary>
    public TradeApi TradeApi { get; }

    /// <summary>
    /// VIP Loans Endpoints
    /// </summary>
    public VipLoans VipLoans { get; }

    /// <summary>
    /// Wallet Endpoints
    /// </summary>
    public Wallet Wallet { get; }
}
