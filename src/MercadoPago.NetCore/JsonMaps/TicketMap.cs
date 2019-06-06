using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;
using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moises.Toolkit.MercadoPago.NetCore.JsonMaps
{
    internal class TicketMap : IJsonTypeConfiguration<Ticket>
    {
        public void Configure(JsonTypeBuilder<Ticket> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.AccessToken)
                .HasFieldName("access_token");
            jsonTypeBuilder.Property(x => x.ExpiresIn)
                .HasFieldName("expires_in");
            jsonTypeBuilder.Property(x => x.LiveMode)
                .HasFieldName("live_mode");
            jsonTypeBuilder.Property(x => x.RefreshToken)
                .HasFieldName("refresh_token");
            jsonTypeBuilder.Property(x => x.Scope)
                .HasFieldName("scope");
            jsonTypeBuilder.Property(x => x.TokenType)
                .HasFieldName("token_type");
            jsonTypeBuilder.Property(x => x.UserId)
                .HasFieldName("user_id");
            jsonTypeBuilder.Property(x => x.IsExpired)
                .IsIgnored();
        }
    }
}
