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
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public BinancePublicSpotApiClient(HttpClient httpClient, BinancePublicSpotApiClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
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
        _rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        _auth = new AuthSchemes(options);
    }

    /// <summary>
    /// Auto-Invest Endpoints
    /// </summary>
    public AutoInvest AutoInvest => field ??= new AutoInvest(_rawClient, _server, _auth);

    /// <summary>
    /// Binance Leveraged Tokens Endpoints
    /// </summary>
    public Blvt Blvt => field ??= new Blvt(_rawClient, _server, _auth);

    /// <summary>
    /// Consumer-To-Consumer Endpoints
    /// </summary>
    public C2C C2C => field ??= new C2C(_rawClient, _server, _auth);

    /// <summary>
    /// Convert Endpoints
    /// </summary>
    public ConvertApi ConvertApi => field ??= new ConvertApi(_rawClient, _server, _auth);

    /// <summary>
    /// Copy Trading Endpoints
    /// </summary>
    public CopyTrading CopyTrading => field ??= new CopyTrading(_rawClient, _server, _auth);

    /// <summary>
    /// Crypto Loans Endpoints
    /// </summary>
    public CryptoLoans CryptoLoans => field ??= new CryptoLoans(_rawClient, _server, _auth);

    public DualInvestment DualInvestment => field ??= new DualInvestment(_rawClient, _server, _auth);

    /// <summary>
    /// Fiat Endpoints
    /// </summary>
    public Fiat Fiat => field ??= new Fiat(_rawClient, _server, _auth);

    /// <summary>
    /// Futures Endpoints
    /// </summary>
    public Futures Futures => field ??= new Futures(_rawClient, _server, _auth);

    /// <summary>
    /// Futures Algo Endpoints
    /// </summary>
    public FuturesAlgo FuturesAlgo => field ??= new FuturesAlgo(_rawClient, _server, _auth);

    /// <summary>
    /// Gift Card Endpoints
    /// </summary>
    public GiftCard GiftCard => field ??= new GiftCard(_rawClient, _server, _auth);

    /// <summary>
    /// Isolated User Data Stream
    /// </summary>
    public IsolatedMarginStream IsolatedMarginStream =>
        field ??= new IsolatedMarginStream(_rawClient, _server, _auth);

    /// <summary>
    /// Margin Account/Trade
    /// </summary>
    public Margin Margin => field ??= new Margin(_rawClient, _server, _auth);

    /// <summary>
    /// Margin User Data Stream
    /// </summary>
    public MarginStream MarginStream => field ??= new MarginStream(_rawClient, _server, _auth);

    /// <summary>
    /// Market Data
    /// </summary>
    public Market Market => field ??= new Market(_rawClient, _server);

    /// <summary>
    /// Mining Endpoints
    /// </summary>
    public Mining Mining => field ??= new Mining(_rawClient, _server, _auth);

    /// <summary>
    /// NFT Endpoints
    /// </summary>
    public Nft Nft => field ??= new Nft(_rawClient, _server, _auth);

    /// <summary>
    /// Pay Endpoints
    /// </summary>
    public Pay Pay => field ??= new Pay(_rawClient, _server, _auth);

    /// <summary>
    /// Portfolio Margin Endpoints
    /// </summary>
    public PortfolioMargin PortfolioMargin => field ??= new PortfolioMargin(_rawClient, _server, _auth);

    /// <summary>
    /// Rebate Endpoints
    /// </summary>
    public Rebate Rebate => field ??= new Rebate(_rawClient, _server, _auth);

    /// <summary>
    /// Savings Endpoints
    /// </summary>
    public Savings Savings => field ??= new Savings(_rawClient, _server, _auth);

    /// <summary>
    /// Simple Earn Endpoints
    /// </summary>
    public SimpleEarn SimpleEarn => field ??= new SimpleEarn(_rawClient, _server, _auth);

    /// <summary>
    /// Spot Algo Endpoints
    /// </summary>
    public SpotAlgo SpotAlgo => field ??= new SpotAlgo(_rawClient, _server, _auth);

    public Staking Staking => field ??= new Staking(_rawClient, _server, _auth);

    /// <summary>
    /// User Data Stream
    /// </summary>
    public StreamApi StreamApi => field ??= new StreamApi(_rawClient, _server, _auth);

    /// <summary>
    /// Sub-account Endpoints
    /// </summary>
    public SubAccountApi SubAccountApi => field ??= new SubAccountApi(_rawClient, _server, _auth);

    /// <summary>
    /// Account/Trade
    /// </summary>
    public TradeApi TradeApi => field ??= new TradeApi(_rawClient, _server, _auth);

    /// <summary>
    /// VIP Loans Endpoints
    /// </summary>
    public VipLoans VipLoans => field ??= new VipLoans(_rawClient, _server, _auth);

    /// <summary>
    /// Wallet Endpoints
    /// </summary>
    public Wallet Wallet => field ??= new Wallet(_rawClient, _server, _auth);
}
