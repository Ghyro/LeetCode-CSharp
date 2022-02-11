using System.Collections.Generic;

namespace Medium
{
    // Issue: 1797

    // There is an authentication system that works with authentication tokens. For each session, the user will receive a new authentication token that will expire timeToLive seconds after the currentTime. If the token is renewed, the expiry time will be extended to expire timeToLive seconds after the (potentially different) currentTime.

    // Implement the AuthenticationManager class:

    // AuthenticationManager(int timeToLive) constructs the AuthenticationManager and sets the timeToLive.
    // generate(string tokenId, int currentTime) generates a new token with the given tokenId at the given currentTime in seconds.
    // renew(string tokenId, int currentTime) renews the unexpired token with the given tokenId at the given currentTime in seconds.If there are no unexpired tokens with the given tokenId, the request is ignored, and nothing happens.
    // countUnexpiredTokens(int currentTime) returns the number of unexpired tokens at the given currentTime.
    // Note that if a token expires at time t, and another action happens on time t(renew or countUnexpiredTokens), the expiration takes place before the other actions.

    public class AuthenticationManager
    {
        Dictionary<string, int> tokenTime;
        int _timeToLive;
        public AuthenticationManager(int timeToLive)
        {
            _timeToLive = timeToLive;
            tokenTime = new Dictionary<string, int>();
        }

        public void Generate(string tokenId, int currentTime)
        {
            if (!tokenTime.ContainsKey(tokenId))
            {
                tokenTime.Add(tokenId, currentTime);
            }
        }

        public void Renew(string tokenId, int currentTime)
        {
            if (tokenTime.ContainsKey(tokenId))
            {
                var expTime = tokenTime[tokenId] + _timeToLive;
                if (currentTime < expTime)
                {
                    tokenTime[tokenId] = currentTime;
                }
            }
        }

        public int CountUnexpiredTokens(int currentTime)
        {
            int count = 0;
            foreach (var token in tokenTime)
            {
                if ((token.Value + _timeToLive) > currentTime)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
