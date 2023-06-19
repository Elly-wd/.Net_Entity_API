using ApiFilmesDois.Data.Dtos;
using ApiFilmesDois.Models;
using AutoMapper;

namespace ApiFilmesDois.Profiles;

public class CinemaProfile : Profile
{
	public CinemaProfile()
	{
		CreateMap<CreateCinemaDto, Cinema>();
		CreateMap<Cinema, ReadCinemaDto>();
		CreateMap<UpdateCinemaDto, Cinema>();
	}
}
