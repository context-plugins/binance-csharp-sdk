<!-- Generated file — do not edit; regenerated with the SDK. -->

# GiftCard — operations

Accessor: `client.GiftCard` · Source: `src/Binance/Api/GiftCard.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BuyABinanceCodeTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `BuyABinanceCodeTrade(BuyABinanceCodeTradeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BaseToken`, `FaceToken`, `BaseTokenAmount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `baseToken` ← `BaseToken`, `faceToken` ← `FaceToken`, `baseTokenAmount` ← `BaseTokenAmount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1GiftcardBuyCodeResponse`
- **Error**: `ApiException<BuyABinanceCodeTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BuyABinanceCodeTradeRequest` | `src/Binance/Requests/GiftCard/BuyABinanceCodeTradeRequest.cs` |
| `SapiV1GiftcardBuyCodeResponse` | `src/Binance/Models/SapiV1GiftcardBuyCodeResponse.cs` |
| `BuyABinanceCodeTradeError` | `src/Binance/Errors/BuyABinanceCodeTradeError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### CreateABinanceCodeUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CreateABinanceCodeUserData(CreateABinanceCodeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `Amount`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `token` ← `Token`, `amount` ← `Amount`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1GiftcardCreateCodeResponse`
- **Error**: `ApiException<CreateABinanceCodeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateABinanceCodeUserDataRequest` | `src/Binance/Requests/GiftCard/CreateABinanceCodeUserDataRequest.cs` |
| `SapiV1GiftcardCreateCodeResponse` | `src/Binance/Models/SapiV1GiftcardCreateCodeResponse.cs` |
| `CreateABinanceCodeUserDataError` | `src/Binance/Errors/CreateABinanceCodeUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### FetchRsaPublicKeyUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FetchRsaPublicKeyUserData(FetchRsaPublicKeyUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1GiftcardCryptographyRsaPublicKeyResponse`
- **Error**: `ApiException<FetchRsaPublicKeyUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FetchRsaPublicKeyUserDataRequest` | `src/Binance/Requests/GiftCard/FetchRsaPublicKeyUserDataRequest.cs` |
| `SapiV1GiftcardCryptographyRsaPublicKeyResponse` | `src/Binance/Models/SapiV1GiftcardCryptographyRsaPublicKeyResponse.cs` |
| `FetchRsaPublicKeyUserDataError` | `src/Binance/Errors/FetchRsaPublicKeyUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### FetchTokenLimitUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FetchTokenLimitUserData(FetchTokenLimitUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BaseToken`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `baseToken` ← `BaseToken`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1GiftcardBuyCodeTokenLimitResponse`
- **Error**: `ApiException<FetchTokenLimitUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FetchTokenLimitUserDataRequest` | `src/Binance/Requests/GiftCard/FetchTokenLimitUserDataRequest.cs` |
| `SapiV1GiftcardBuyCodeTokenLimitResponse` | `src/Binance/Models/SapiV1GiftcardBuyCodeTokenLimitResponse.cs` |
| `FetchTokenLimitUserDataError` | `src/Binance/Errors/FetchTokenLimitUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### RedeemABinanceCodeUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RedeemABinanceCodeUserData(RedeemABinanceCodeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Code`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `code` ← `Code`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `externalUid` ← `ExternalUid`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1GiftcardRedeemCodeResponse`
- **Error**: `ApiException<RedeemABinanceCodeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RedeemABinanceCodeUserDataRequest` | `src/Binance/Requests/GiftCard/RedeemABinanceCodeUserDataRequest.cs` |
| `SapiV1GiftcardRedeemCodeResponse` | `src/Binance/Models/SapiV1GiftcardRedeemCodeResponse.cs` |
| `RedeemABinanceCodeUserDataError` | `src/Binance/Errors/RedeemABinanceCodeUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

### VerifyABinanceCodeUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `VerifyABinanceCodeUserData(VerifyABinanceCodeUserDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ReferenceNo`, `Timestamp`, `Signature`
- **Query params (wire ← C#)**: `referenceNo` ← `ReferenceNo`, `timestamp` ← `Timestamp`, `signature` ← `Signature`, `recvWindow` ← `RecvWindow`
- **Returns**: `SapiV1GiftcardVerifyResponse`
- **Error**: `ApiException<VerifyABinanceCodeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VerifyABinanceCodeUserDataRequest` | `src/Binance/Requests/GiftCard/VerifyABinanceCodeUserDataRequest.cs` |
| `SapiV1GiftcardVerifyResponse` | `src/Binance/Models/SapiV1GiftcardVerifyResponse.cs` |
| `VerifyABinanceCodeUserDataError` | `src/Binance/Errors/VerifyABinanceCodeUserDataError.cs` |
| `Error` | `src/Binance/Models/Error.cs` |

