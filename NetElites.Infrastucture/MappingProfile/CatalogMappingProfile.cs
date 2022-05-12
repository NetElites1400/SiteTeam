using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NetElites.Domain.Model.Articles;
using NetElitres.Application.Dto.Article;

namespace NetElites.Infrastucture.MappingProfile
{
    public class CatalogMappingProfile: Profile
    {
        public CatalogMappingProfile()
        {
            CreateMap<Article, ArticlesDto>().ReverseMap();
        }
    }
}
