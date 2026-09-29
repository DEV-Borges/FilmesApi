using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

public class SessaoProfile : Profile
{
    public SessaoProfile()
    {
        CreateMap<CreateSessaoDto, Sessao>();
        CreateMap<Sessao, ReadSessaoDto>();
    }
}