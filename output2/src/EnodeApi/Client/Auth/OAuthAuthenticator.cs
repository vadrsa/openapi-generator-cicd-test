/*
 * Enode API
 *
 * The Enode API is designed to make smart charging applications easy to develop. We provide an abstraction layer that reduces the complexity when extracting vehicle data and sending commands to vehicles from a variety of manufacturers.  The API has a RESTful architecture and utilizes OAuth2 authorization. 
 *
 * The version of the OpenAPI document: 1.17.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace EnodeApi.Client.Auth
{
    /// <summary>
    /// An authenticator for OAuth2 authentication flows
    /// </summary>
    public class OAuthAuthenticator : AuthenticatorBase
    {
        readonly string _tokenUrl;
        readonly string _clientId;
        readonly string _clientSecret;
        readonly string _grantType;
        readonly JsonSerializerSettings _serializerSettings;
        readonly IReadableConfiguration _configuration;

        /// <summary>
        /// Initialize the OAuth2 Authenticator
        /// </summary>
        public OAuthAuthenticator(
            string tokenUrl,
            string clientId,
            string clientSecret,
            OAuthFlow? flow,
            JsonSerializerSettings serializerSettings,
            IReadableConfiguration configuration) : base("")
        {
            _tokenUrl = tokenUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
            _serializerSettings = serializerSettings;
            _configuration = configuration;

            switch (flow)
            {
                /*case OAuthFlow.ACCESS_CODE:
                    _grantType = "authorization_code";
                    break;
                case OAuthFlow.IMPLICIT:
                    _grantType = "implicit";
                    break;
                case OAuthFlow.PASSWORD:
                    _grantType = "password";
                    break;*/
                case OAuthFlow.APPLICATION:
                    _grantType = "client_credentials";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Creates an authentication parameter from an access token.
        /// </summary>
        /// <param name="accessToken">Access token to create a parameter from.</param>
        /// <returns>An authentication parameter.</returns>
        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            var token = string.IsNullOrEmpty(Token) ? await GetToken() : Token;
            return new HeaderParameter(KnownHeaders.Authorization, token);
        }

        /// <summary>
        /// Gets the token from the OAuth2 server.
        /// </summary>
        /// <returns>An authentication token.</returns>
        async Task<string> GetToken()
        {
            var client = new RestClient(_tokenUrl)
                .UseSerializer(() => new CustomJsonCodec(_serializerSettings, _configuration));

            var request = new RestRequest()
                .AddParameter("grant_type", _grantType)
                .AddParameter("client_id", _clientId)
                .AddParameter("client_secret", _clientSecret);
            var response = await client.PostAsync<TokenResponse>(request);
            return $"{response.TokenType} {response.AccessToken}";
        }
    }
}
