using AutoMapper;
using MercadoPago.NetCore.Model.Resources;
using MercadoPago.NetCore.Request;

namespace MercadoPago.NetCore.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Payment, PaymentRequest>();
            CreateMap<PaymentRequest, Payment>();
        }
    }
}
