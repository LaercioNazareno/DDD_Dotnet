using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace EntityCreate
{
    public class Create
    {
        public static void createEntity()
        {
            var fileCreateList = GetFilesCreateEntity();
            CreateFiles(fileCreateList);
        }
        // public static FileCreate createStruct()
        // {
        //     Create(ENTITY_BASE_TYPE, PATH_ENTITY, "EntityBase");
        //     Create(CONTEXT_TYPE, PATH_CONTEXT, "Context");
        //     Create(REPOSITORY_BASE_TYPE, PATH_REPOSITORY, $"RepositoryBase");
        //     Create(I_REPOSITORY_BASE_TYPE, PATH_INTERFACE_REPOSITORY, $"IRepositoryBase");
        //     Create(MAPPER_TYPE, PATH_MAPPER, "ObjectMapper");
        //     Create(CUSTOM_MAPPER_TYPE, PATH_MAPPER, "CustomDtoMapper");
        //     Create(SERVICE_BASE_TYPE, PATH_SERVICE, $"ServiceBase");
        //     Create(I_SERVICE_BASE_TYPE, PATH_INTERFACE_SERVICE, $"IServiceBase");
        // }
        private static void CreateFiles(List<FileCreate> fileCreateList)
        {
            foreach (var fileCreate in fileCreateList)
            {
                create(fileCreate);
            }
        }
        private static List<FileCreate> GetFilesCreateEntity()
        {
            var fileCreateList = new List<FileCreate>();

            var fileCreateEntity = new FileCreate()
            {
                path = Constantes.PATH_ENTITY,
                type = Constantes.ENTITY_TYPE,
                nameFile = Constantes.NAME_ENTITY,
            };
            fileCreateEntity.EntityDictionary();
            fileCreateList.Add(fileCreateEntity);

            var fileCreateEntityConfig = new FileCreate()
            {
                path = Constantes.PATH_ENTITY_CONFIG,
                type = Constantes.ENTITY_CONFIG_TYPE,
                nameFile = $"{Constantes.NAME_ENTITY}Configuration",
            };
            fileCreateEntityConfig.EntityConfigDictionary();
            fileCreateList.Add(fileCreateEntityConfig);

            var fileCreateIRepository = new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_REPOSITORY,
                type = Constantes.I_REPOSITORY_TYPE,
                nameFile = $"I{Constantes.NAME_ENTITY}Repository",
            };
            fileCreateIRepository.IRepositoryDictionary();
            fileCreateList.Add(fileCreateIRepository);

            var fileCreateRepository = new FileCreate()
            {
                path = Constantes.PATH_REPOSITORY,
                type = Constantes.REPOSITORY_TYPE,
                nameFile = $"{Constantes.NAME_ENTITY}Repository",
            };
            fileCreateRepository.RepositoryDictionary();
            fileCreateList.Add(fileCreateRepository);

            var fileCreateDto = new FileCreate()
            {
                path = Constantes.PATH_DTO,
                type = Constantes.DTO_TYPE,
                nameFile = $"{Constantes.NAME_ENTITY}DTO",
            };
            fileCreateDto.DtoDictionary();
            fileCreateList.Add(fileCreateDto);

            var fileCreateAppService = new FileCreate()
            {
                path = Constantes.PATH_APP_SERVICE,
                type = Constantes.APP_SERVICE_TYPE,
                nameFile = $"{Constantes.NAME_ENTITY}AppService",
            };
            fileCreateAppService.AppServiceDictionary();
            fileCreateList.Add(fileCreateAppService);

            var fileCreateIAppService = new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_APP_SERVICE,
                type = Constantes.I_APP_SERVICE_TYPE,
                nameFile = $"I{Constantes.NAME_ENTITY}AppService",
            };
            fileCreateIAppService.IAppServiceDictionary();
            fileCreateList.Add(fileCreateIAppService);

            var fileCreateIService = new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_SERVICE,
                type = Constantes.I_SERVICE_TYPE,
                nameFile = $"I{Constantes.NAME_ENTITY}Service",
            };
            fileCreateIService.IServiceDictionary();
            fileCreateList.Add(fileCreateIService);

            var fileCreateService = new FileCreate()
            {
                path = Constantes.PATH_SERVICE,
                type = Constantes.SERVICE_TYPE,
                nameFile = $"{Constantes.NAME_ENTITY}Service",
            };
            fileCreateService.IServiceDictionary();
            fileCreateList.Add(fileCreateService);

            return fileCreateList;
        }
        private static void create(FileCreate file)
        {
            var body = GetBody(file.dictionary, file.type);
            file.path = file.path + file.nameFile + ".cs";

            CreateFile(file.path, body);
        }
        private static string GetBody(Dictionary<string, string> tags, string type)
        {
            var body = File.ReadAllText(Constantes.PATH_SAMPLES + type);
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