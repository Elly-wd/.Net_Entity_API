using ApiFilmesDois.Data.Dtos;
using ApiFilmesDois.Models;
using AutoMapper;

namespace ApiFilmesDois.Profiles;

public class FilmeProfile : Profile
{
	public FilmeProfile()
	{
		CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
    }
}
