<!-- Generated file — do not edit; regenerated with the SDK. -->

# GiftCard — operations

Accessor: `client.GiftCard` · Source: `Api/GiftCard.cs` · 6 operations

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
| `BuyABinanceCodeTradeRequest` | `Requests/GiftCard/BuyABinanceCodeTradeRequest.cs` |
| `SapiV1GiftcardBuyCodeResponse` | `Models/SapiV1GiftcardBuyCodeResponse.cs` |
| `BuyABinanceCodeTradeError` | `Errors/BuyABinanceCodeTradeError.cs` |
| `Error` | `Models/Error.cs` |

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
| `CreateABinanceCodeUserDataRequest` | `Requests/GiftCard/CreateABinanceCodeUserDataRequest.cs` |
| `SapiV1GiftcardCreateCodeResponse` | `Models/SapiV1GiftcardCreateCodeResponse.cs` |
| `CreateABinanceCodeUserDataError` | `Errors/CreateABinanceCodeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `FetchRsaPublicKeyUserDataRequest` | `Requests/GiftCard/FetchRsaPublicKeyUserDataRequest.cs` |
| `SapiV1GiftcardCryptographyRsaPublicKeyResponse` | `Models/SapiV1GiftcardCryptographyRsaPublicKeyResponse.cs` |
| `FetchRsaPublicKeyUserDataError` | `Errors/FetchRsaPublicKeyUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `FetchTokenLimitUserDataRequest` | `Requests/GiftCard/FetchTokenLimitUserDataRequest.cs` |
| `SapiV1GiftcardBuyCodeTokenLimitResponse` | `Models/SapiV1GiftcardBuyCodeTokenLimitResponse.cs` |
| `FetchTokenLimitUserDataError` | `Errors/FetchTokenLimitUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `RedeemABinanceCodeUserDataRequest` | `Requests/GiftCard/RedeemABinanceCodeUserDataRequest.cs` |
| `SapiV1GiftcardRedeemCodeResponse` | `Models/SapiV1GiftcardRedeemCodeResponse.cs` |
| `RedeemABinanceCodeUserDataError` | `Errors/RedeemABinanceCodeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

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
| `VerifyABinanceCodeUserDataRequest` | `Requests/GiftCard/VerifyABinanceCodeUserDataRequest.cs` |
| `SapiV1GiftcardVerifyResponse` | `Models/SapiV1GiftcardVerifyResponse.cs` |
| `VerifyABinanceCodeUserDataError` | `Errors/VerifyABinanceCodeUserDataError.cs` |
| `Error` | `Models/Error.cs` |

