using GameStore.API.Interfaces;
using GameStore.API.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomizedServices(this IServiceCollection services)
        {
            services.AddTransient<IEstadoServices, EstadoServices>();
            //services.AddTransient<INewsService, NewsService>();
            //services.AddTransient<INewsCategoryService, NewsCategoryService>();
            //services.AddTransient<ICommunicationTypeService, CommunicationTypeService>();
            //services.AddTransient<IEmployeeService, EmployeeService>();
            //services.AddTransient<IUserRoleService, UserRoleService>();
            //services.AddTransient<IRoleGroupService, RoleGroupService>();
            //services.AddTransient<ICategoryService, CategoryService>();
            //services.AddTransient<IDocumentTypeService, DocumentTypeService>();
            //services.AddTransient<IHiringCompanyService, HiringCompanyService>();
            //services.AddTransient<ICategoryGroupService, CategoryGroupService>();
            //services.AddTransient<IRelCategoryGroup_CategoryServices, RelCategoryGroup_CategoryServices>();
            //services.AddTransient<IRelRoleGroup_UserRoleServices, RelRoleGroup_UserRoleServices>();
            //services.AddTransient<IQuestionTypeService, QuestionTypeService>();
            //services.AddTransient<ISurveyService, SurveyService>();
            //services.AddTransient<IQuestionService, QuestionService>();
            //services.AddTransient<IQuestionChoiseService, QuestionChoiseService>();
            //services.AddTransient<IBrandService, BrandService>();
            //services.AddTransient<IKeywordCategoryService, KeywordCategoryService>();
            //services.AddTransient<ISpeechCategoryService, SpeechCategoryService>();
            //services.AddTransient<ISpeechService, SpeechService>();
            //services.AddTransient<IProductService, ProductService>();
            //services.AddTransient<IProductSeriesService, ProductSerieService>();
            //services.AddTransient<IProductTypesService, ProductTypeService>();
            //services.AddTransient<ITechSpecCategoryService, TechSpecCategoryService>();
            //services.AddTransient<ITechSpecService, TechSpecService>();
            //services.AddTransient<IKeywordService, KeywordService>();
            //services.AddTransient<IKeywordFeaturesService, KeywordFeaturesService>();

            return services;
        }
    }
}
