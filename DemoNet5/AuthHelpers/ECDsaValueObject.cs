using Microsoft.IdentityModel.Tokens;
using System;
using System.Security.Cryptography;

namespace DemoNet5.AuthHelpers
{
    public static class ECDsaValueObject
    {
        private readonly static ECCurve DefaultCurve = ECCurve.NamedCurves.nistP256;
        private static ECDsaSecurityKey _ecdssaKey;
        public static ECDsaSecurityKey ObterECDsa()
        {
            if (_ecdssaKey != null) return _ecdssaKey;

            var ecdsa = new ECDsaSecurityKey(ECDsa.Create(DefaultCurve))
            {
                KeyId = Guid.NewGuid().ToString()
            };

            _ecdssaKey = ecdsa;
            return ecdsa;
        }
    }
}
