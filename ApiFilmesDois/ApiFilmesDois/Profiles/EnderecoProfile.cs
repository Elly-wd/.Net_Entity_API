
using ApiFilmesDois.Data.Dtos;
using ApiFilmesDois.Models;
using AutoMapper;

namespace ApiFilmesDois.Profiles;
public class EnderecoProfile : Profile
{
	public EnderecoProfile()
	{
		CreateMap<CreateEnderecoDto, Endereco>();
		CreateMap<Endereco, ReadEnderecoDto > ();
		CreateMap<UpdateEnderecoDto, Endereco>();
	}
}
