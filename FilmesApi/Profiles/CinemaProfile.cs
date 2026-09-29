using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>()
            .ForMember(cinemaDto => cinemaDto.Endereco, opt => opt.MapFrom(cinema => cinema.Endereco))
            .ForMember(cinemaDto => cinemaDto.sessoes, opt => opt.MapFrom(cinema => cinema.sessoes));
        CreateMap<UpdateCinemaDto, Cinema>();
    }
}