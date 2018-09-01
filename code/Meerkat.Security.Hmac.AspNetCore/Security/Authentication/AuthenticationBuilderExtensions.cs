﻿using System;

using Microsoft.AspNetCore.Authentication;

namespace Meerkat.Security.Authentication
{
    public static class AuthenticationBuilderExtensions
    {
        public static AuthenticationBuilder AddHmacAuthentication(this AuthenticationBuilder builder, Action<HmacAuthenticationOptions> configureOptions)
        {
            return builder.AddScheme<HmacAuthenticationOptions, HmacAuthenticationHandler>(HmacAuthenticationOptions.DefaultScheme, configureOptions);
        }
    }
}