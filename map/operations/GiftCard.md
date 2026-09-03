<!-- Generated file — do not edit; regenerated with the SDK. -->

# GiftCard — operations

Accessor: `client.GiftCard` · Source: `Api/GiftCard.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BuyABinanceCodeTrade

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `BuyABinanceCodeTrade(string baseToken, string faceToken, double baseTokenAmount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `baseToken` ← `baseToken`, `faceToken` ← `faceToken`, `baseTokenAmount` ← `baseTokenAmount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1GiftcardBuyCodeResponse`
- **Error**: `SdkException<BuyABinanceCodeTradeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1GiftcardBuyCodeResponse` | `Models/SapiV1GiftcardBuyCodeResponse.cs` |
| `BuyABinanceCodeTradeError` | `Errors/BuyABinanceCodeTradeError.cs` |
| `Error` | `Models/Error.cs` |

### CreateABinanceCodeUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `CreateABinanceCodeUserData(string token, double amount, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `amount` ← `amount`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1GiftcardCreateCodeResponse`
- **Error**: `SdkException<CreateABinanceCodeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1GiftcardCreateCodeResponse` | `Models/SapiV1GiftcardCreateCodeResponse.cs` |
| `CreateABinanceCodeUserDataError` | `Errors/CreateABinanceCodeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FetchRsaPublicKeyUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FetchRsaPublicKeyUserData(long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1GiftcardCryptographyRsaPublicKeyResponse`
- **Error**: `SdkException<FetchRsaPublicKeyUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1GiftcardCryptographyRsaPublicKeyResponse` | `Models/SapiV1GiftcardCryptographyRsaPublicKeyResponse.cs` |
| `FetchRsaPublicKeyUserDataError` | `Errors/FetchRsaPublicKeyUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### FetchTokenLimitUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FetchTokenLimitUserData(string baseToken, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `baseToken` ← `baseToken`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1GiftcardBuyCodeTokenLimitResponse`
- **Error**: `SdkException<FetchTokenLimitUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1GiftcardBuyCodeTokenLimitResponse` | `Models/SapiV1GiftcardBuyCodeTokenLimitResponse.cs` |
| `FetchTokenLimitUserDataError` | `Errors/FetchTokenLimitUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### RedeemABinanceCodeUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `RedeemABinanceCodeUserData(string code, long timestamp, string signature, string? externalUid, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `externalUid` — nullable, no default → **must pass explicitly**
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `code` ← `code`, `timestamp` ← `timestamp`, `signature` ← `signature`, `externalUid` ← `externalUid`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1GiftcardRedeemCodeResponse`
- **Error**: `SdkException<RedeemABinanceCodeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1GiftcardRedeemCodeResponse` | `Models/SapiV1GiftcardRedeemCodeResponse.cs` |
| `RedeemABinanceCodeUserDataError` | `Errors/RedeemABinanceCodeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

### VerifyABinanceCodeUserData

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `VerifyABinanceCodeUserData(string referenceNo, long timestamp, string signature, long? recvWindow, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `recvWindow` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `referenceNo` ← `referenceNo`, `timestamp` ← `timestamp`, `signature` ← `signature`, `recvWindow` ← `recvWindow`
- **Returns**: `SapiV1GiftcardVerifyResponse`
- **Error**: `SdkException<VerifyABinanceCodeUserDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SapiV1GiftcardVerifyResponse` | `Models/SapiV1GiftcardVerifyResponse.cs` |
| `VerifyABinanceCodeUserDataError` | `Errors/VerifyABinanceCodeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

