using AutoMapper;
using WebApiPaulovnija.DTO;
using WebApiPaulovnija.Models;

namespace WebApiPaulovnija.Mapping
{
    /// <summary>
    /// Konfiguracija mapiranja između modela i DTO klasa.
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Inicijalizuje novu instancu <see cref="MappingProfile"/> klase.
        /// </summary>
        public MappingProfile()
        {
            // Mape za Radnika
            CreateMap<Radnik, RadnikDTO>().ReverseMap();
            CreateMap<KreirajRadnikaDTO, Radnik>();
            CreateMap<AzurirajRadnikaDTO, Radnik>();

            // Mape za Rasadnik
            CreateMap<Rasadnik, RasadnikDTO>().ReverseMap();
            CreateMap<KreirajRasadnikDTO, Rasadnik>();
            CreateMap<AzurirajRasadnikDTO, Rasadnik>();

            // Mape za Zadatak
            CreateMap<Zadatak, ZadatakDTO>().ReverseMap();
            CreateMap<KreirajZadatakDTO, Zadatak>();
            CreateMap<AzurirajZadatakDTO, Zadatak>();

            // Mape za Sadnicu
            CreateMap<Sadnica, SadnicaDTO>().ReverseMap();
            CreateMap<KreirajSadnicuDTO, Sadnica>();
            CreateMap<AzurirajSadnicuDTO, Sadnica>();

            // Mape za Stroj
            CreateMap<Stroj, StrojDTO>().ReverseMap();
            CreateMap<KreirajStrojDTO, Stroj>();
            CreateMap<AzurirajStrojDTO, Stroj>();
        }
    }
}
