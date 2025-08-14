﻿public class JwtSettings
{
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public bool ValidateAudience { get; set; }
    public bool ValidateIssuer { get; set; }
    public bool ValidateLifetime { get; set; }
    public bool ValidateIssuerSigningKey { get; set; }
    public int AccessTokenExpireDate { get; set; }
    public string SecretKey { get; set; }
}
