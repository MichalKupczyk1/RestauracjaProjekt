using AutoMapper;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() {
            CreateMap<Zamowienie, zamowienieTest>().ForMember(dest => dest.idKelner, opt => opt.MapFrom(src => src.id_kelner))
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.id));
        }
    }
}
            /* 
             * stworzyłem profil dla Zamowienia ktory aktualnie bierze z Zamowienie id kelnera i wrzuca do zamowienieTest oraz bierze Id z zamowienia i wrzuca do Zamowienie
             * mapper dziala cos jak inteligentne rzutowanie, bardzo przydatne przy bazach danych
             *
             */