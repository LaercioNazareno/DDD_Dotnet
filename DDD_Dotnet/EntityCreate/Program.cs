using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace EntityCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            Create.createEntity();
            // Create(ENTITY_BASE_TYPE, PATH_ENTITY, "EntityBase");
            // Create(ENTITY_TYPE, PATH_ENTITY, NAME_ENTITY);
            // Create(CONTEXT_TYPE, PATH_CONTEXT, "Context");
            // Create(ENTITY_CONFIG_TYPE, PATH_ENTITY_CONFIG, $"{NAME_ENTITY}Configuration");
            // Create(I_REPOSITORY_TYPE, PATH_INTERFACE_REPOSITORY, $"I{NAME_ENTITY}Repository");
            // Create(REPOSITORY_TYPE, PATH_REPOSITORY, $"{NAME_ENTITY}Repository");
            // Create(REPOSITORY_BASE_TYPE, PATH_REPOSITORY, $"RepositoryBase");
            // Create(I_REPOSITORY_BASE_TYPE, PATH_INTERFACE_REPOSITORY, $"IRepositoryBase");
            // Create(DTO_TYPE, PATH_DTO, $"{NAME_ENTITY}DTO");
            // Create(MAPPER_TYPE, PATH_MAPPER, "ObjectMapper");
            // Create(CUSTOM_MAPPER_TYPE, PATH_MAPPER, "CustomDtoMapper");
            // Create(SERVICE_BASE_TYPE, PATH_SERVICE, $"ServiceBase");
            // Create(I_SERVICE_BASE_TYPE, PATH_INTERFACE_SERVICE, $"IServiceBase");
            // Create(APP_SERVICE_TYPE, PATH_APP_SERVICE, $"{NAME_ENTITY}AppService");
            // Create(I_APP_SERVICE_TYPE, PATH_INTERFACE_APP_SERVICE, $"I{NAME_ENTITY}AppService");
            // Create(I_SERVICE_TYPE, PATH_INTERFACE_SERVICE, $"I{NAME_ENTITY}Service");
            // Create(SERVICE_TYPE, PATH_SERVICE, $"{NAME_ENTITY}Service");
        }
        // private static void Create(string entityType, string path, string namefile)
        // {
        //     var dictionary = GetDictionary(entityType, namefile);
        //     var body = GetBody(dictionary, entityType);
        //     path = path + namefile + ".cs";

        //     CreateFile(path, body);
        // }
        // private static string GetBody(Dictionary<string, string> tags, string type)
        // {
        //     var body = File.ReadAllText(PATH_SAMPLES + type);
        //     foreach (var tag in tags)
        //     {
        //         body = ReplaceTagInBodyByText(body, tag.Key, tag.Value);
        //     }
        //     return body;
        // }
        // private static string ReplaceTagInBodyByText(string body, string tag, string text)
        // {
        //     return body.Replace(tag, text);
        // }
        // private static void CreateFile(string path, string body)
        // {
        //     using (StreamWriter outputFile = new StreamWriter(path))
        //         outputFile.WriteLine(body);
        // }
    }
}
