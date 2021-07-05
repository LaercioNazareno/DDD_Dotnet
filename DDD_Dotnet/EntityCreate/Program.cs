using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace EntityCreate
{
    class Program
    {
        const string NAME_ENTITY = "Cliente";
        private const string PROJECT_NAME = "DDD_Dotnet";

        #region PATHS
        const string PATH_ENTITY = "/home/laercio/Projetos/DDD/DDD_Dotnet/DDD_Dotnet/3-Domain/DDD_Dotnet.Domain/Entities/";
        const string PATH_SAMPLES = "/home/laercio/Projetos/DDD/DDD_Dotnet/DDD_Dotnet/EntityCreate/classSamples/";
        const string PATH_CONTEXT = "/home/laercio/Projetos/DDD/DDD_Dotnet/DDD_Dotnet/4-Infra/4.1-Data/DDD_Dotnet.Infra.Data/Contexto/";
        const string PATH_ENTITY_CONFIG = "/home/laercio/Projetos/DDD/DDD_Dotnet/DDD_Dotnet/4-Infra/4.1-Data/DDD_Dotnet.Infra.Data/EntityConfig/";
        const string PATH_REPOSITORY = "/home/laercio/Projetos/DDD/DDD_Dotnet/DDD_Dotnet/4-Infra/4.1-Data/DDD_Dotnet.Infra.Data/Repositories/";
        const string PATH_INTERFACE_REPOSITORY = "/home/laercio/Projetos/DDD/DDD_Dotnet/DDD_Dotnet/3-Domain/DDD_Dotnet.Domain/Interfaces/";
        const string PATH_DTO = "/home/laercio/Projetos/DDD/DDD_Dotnet/DDD_Dotnet/2-Application/DDD_Dotnet.Application/DTO/";
        const string PATH_MAPPER = "/home/laercio/Projetos/DDD/DDD_Dotnet/DDD_Dotnet/2-Application/DDD_Dotnet.Application/AutoMapper/";
        #endregion

        #region NAMESPACES
        static readonly string NAMESPACE_ENTITY = $"{PROJECT_NAME}.Domain.Entities";
        static readonly string NAMESPACE_CONTEXT = $"{PROJECT_NAME}.Infra.Data.Contexto";
        static readonly string NAMESPACE_ENTITY_CONFIG = $"{PROJECT_NAME}.Infra.Data.EntityConfig";
        static readonly string NAMESPACE_REPOSITORY = $"{PROJECT_NAME}.Infra.Data.Repositories";
        static readonly string NAMESPACE_INTERFACE_REPOSITORY = $"{PROJECT_NAME}.Domain.Interfaces";
        static readonly string NAMESPACE_DTO = $"{PROJECT_NAME}.Application.DTO";
        static readonly string NAMESPACE_MAPPER = $"{PROJECT_NAME}.Application.DTO";

        #endregion

        #region TAGS
        const string TAG_CLASS_NAME = "CLASSNAME";
        const string TAG_NAME_SPACE = "NAMESPACE";
        const string TAG_IMPORT_MODELS = "IMPORT_MODELS";
        const string TAG_IMPORT_REPOSITORY = "IMPORT_REPOSITORY";
        const string TAG_IMPORT_INTERCE_REPOSITORY = "IMPORT_INTERFACE_REPOSITORY";
        const string TAG_ENTITY_TYPE = "ENTITY_TYPE";
        const string TAG_IMPORT_CONTXT = "IMPORT_CONTXT";
        #endregion

        #region TYPES
        const string ENTITY_TYPE = "Entity.txt";
        const string ENTITY_BASE_TYPE = "EntityBase.txt";
        const string CONTEXT_TYPE = "Context.txt";
        const string ENTITY_CONFIG_TYPE = "EntityConfig.txt";
        const string REPOSITORY_TYPE = "Repository.txt";
        const string I_REPOSITORY_TYPE = "IRepository.txt";
        const string REPOSITORY_BASE_TYPE = "RepositoryBase.txt";
        const string I_REPOSITORY_BASE_TYPE = "IRepositoryBase.txt";
        const string DTO_TYPE = "DTO.txt";
        const string MAPPER_TYPE = "Mapper.txt";
        #endregion
        static void Main(string[] args)
        {
            Create(ENTITY_BASE_TYPE, PATH_ENTITY, "EntityBase");
            Create(ENTITY_TYPE, PATH_ENTITY, NAME_ENTITY);
            Create(CONTEXT_TYPE, PATH_CONTEXT, "Context");
            Create(ENTITY_CONFIG_TYPE, PATH_ENTITY_CONFIG, $"{NAME_ENTITY}Configuration");
            Create(I_REPOSITORY_TYPE, PATH_INTERFACE_REPOSITORY, $"I{NAME_ENTITY}Repository");
            Create(REPOSITORY_TYPE, PATH_REPOSITORY, $"{NAME_ENTITY}Repository");
            Create(REPOSITORY_BASE_TYPE, PATH_REPOSITORY, $"RepositoryBase");
            Create(I_REPOSITORY_BASE_TYPE, PATH_INTERFACE_REPOSITORY, $"IRepositoryBase");
            Create(DTO_TYPE, PATH_DTO, $"{NAME_ENTITY}DTO");
            Create(MAPPER_TYPE, PATH_MAPPER, "MappingProfile");
        }
        private static void Create(string entityType, string path, string namefile)
        {
            var dictionary = GetDictionary(entityType, namefile);
            var body = GetBody(dictionary, entityType);
            path = path + namefile + ".cs";

            CreateFile(path, body);
        }
        private static Dictionary<string, string> GetDictionary(string type, string nameFile)
        {
            Dictionary<string, string> dictionary;
            switch (type)
            {
                case ENTITY_BASE_TYPE:
                    dictionary = new Dictionary<string, string>(){
                        {TAG_CLASS_NAME, NAME_ENTITY},
                        {TAG_NAME_SPACE, NAMESPACE_ENTITY}
                    };
                    break;
                case CONTEXT_TYPE:
                    dictionary = new Dictionary<string, string>(){
                        {TAG_NAME_SPACE, NAMESPACE_CONTEXT}
                    };
                    break;
                case ENTITY_CONFIG_TYPE:
                    dictionary = new Dictionary<string, string>(){
                        {TAG_IMPORT_MODELS, NAMESPACE_ENTITY},
                        {TAG_NAME_SPACE, NAMESPACE_ENTITY_CONFIG},
                        {TAG_CLASS_NAME, nameFile},
                        {TAG_ENTITY_TYPE, NAME_ENTITY}
                    };
                    break;
                case REPOSITORY_TYPE:
                    dictionary = new Dictionary<string, string>(){
                        {TAG_IMPORT_MODELS, NAMESPACE_ENTITY},
                        {TAG_CLASS_NAME, nameFile},
                        {TAG_ENTITY_TYPE, NAME_ENTITY},
                        {TAG_NAME_SPACE, NAMESPACE_REPOSITORY},
                        {TAG_IMPORT_INTERCE_REPOSITORY, NAMESPACE_INTERFACE_REPOSITORY},
                        {TAG_IMPORT_CONTXT, NAMESPACE_CONTEXT}
                    };
                    break;
                case REPOSITORY_BASE_TYPE:
                    dictionary = new Dictionary<string, string>(){
                        {TAG_IMPORT_MODELS, NAMESPACE_ENTITY},
                        {TAG_NAME_SPACE, NAMESPACE_REPOSITORY},
                        {TAG_IMPORT_REPOSITORY, NAMESPACE_INTERFACE_REPOSITORY},
                        {TAG_IMPORT_CONTXT, NAMESPACE_CONTEXT},
                        {TAG_IMPORT_INTERCE_REPOSITORY, NAMESPACE_INTERFACE_REPOSITORY}
                    };
                    break;
                case I_REPOSITORY_TYPE:
                    dictionary = new Dictionary<string, string>()
                    {
                        {TAG_IMPORT_MODELS, NAMESPACE_ENTITY},
                        {TAG_IMPORT_REPOSITORY, NAMESPACE_INTERFACE_REPOSITORY},
                        {TAG_ENTITY_TYPE, NAME_ENTITY},
                        {TAG_NAME_SPACE, NAMESPACE_INTERFACE_REPOSITORY}
                    };
                    break;
                case I_REPOSITORY_BASE_TYPE:
                    dictionary = new Dictionary<string, string>()
                    {
                        {TAG_NAME_SPACE, NAMESPACE_INTERFACE_REPOSITORY}
                    };
                    break;
                case DTO_TYPE:
                    dictionary = new Dictionary<string, string>()
                    {
                        {TAG_CLASS_NAME, NAME_ENTITY},
                        {TAG_NAME_SPACE, NAMESPACE_DTO}
                    };
                    break;
                case MAPPER_TYPE:
                    dictionary = new Dictionary<string, string>()
                    {
                        {TAG_NAME_SPACE, NAMESPACE_MAPPER}
                    };
                    break;
                default:
                    dictionary = new Dictionary<string, string>()
                    {
                        {TAG_CLASS_NAME, NAME_ENTITY},
                        {TAG_NAME_SPACE, NAMESPACE_ENTITY}
                    };
                    break;
            }
            return dictionary;
        }
        private static string GetBody(Dictionary<string, string> tags, string type)
        {
            var body = File.ReadAllText(PATH_SAMPLES + type);
            foreach (var tag in tags)
            {
                body = ReplaceTagInBodyByText(body, tag.Key, tag.Value);
            }
            return body;
        }
        private static string ReplaceTagInBodyByText(string body, string tag, string text)
        {
            return body.Replace(tag, text);
        }
        private static void CreateFile(string path, string body)
        {
            using (StreamWriter outputFile = new StreamWriter(path))
                outputFile.WriteLine(body);
        }
    }
}
