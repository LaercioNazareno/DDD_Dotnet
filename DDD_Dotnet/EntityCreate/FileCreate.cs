using System.Collections.Generic;

namespace EntityCreate
{
    public class FileCreate
    {
        public string path { get; set; }
        public string type { get; set; }
        public string nameFile { get; set; }
        public Dictionary<string, string> dictionary{ get; set; }

        public void EntityBaseDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_CLASS_NAME, Constantes.NAME_ENTITY},
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_ENTITY}
            };
        }
        public void ContextDictionary()
        {
            this.dictionary = new Dictionary<string, string>(){
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_CONTEXT}
            };
        }
        public void EntityConfigDictionary()
        {
            this.dictionary= new Dictionary<string, string>(){
                {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_ENTITY_CONFIG},
                {Constantes.TAG_CLASS_NAME, this.nameFile},
                {Constantes.TAG_ENTITY_TYPE, Constantes.NAME_ENTITY}
            };
        }
        public void RepositoryDictionary()
        {
            this.dictionary= new Dictionary<string, string>(){
                {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                {Constantes.TAG_CLASS_NAME, this.nameFile},
                {Constantes.TAG_ENTITY_TYPE, Constantes.NAME_ENTITY},
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_REPOSITORY},
                {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                {Constantes.TAG_IMPORT_CONTXT, Constantes.NAMESPACE_CONTEXT}
            };
        }
        public void RepoitoryBaseDictionary()
        {
            this.dictionary= new Dictionary<string, string>(){
                {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_REPOSITORY},
                {Constantes.TAG_IMPORT_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                {Constantes.TAG_IMPORT_CONTXT, Constantes.NAMESPACE_CONTEXT},
                {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY}
            };
        }
        public void IRepositoryDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                {Constantes.TAG_IMPORT_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                {Constantes.TAG_ENTITY_TYPE, Constantes.NAME_ENTITY},
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_REPOSITORY}
            };
        }
        public void IRepositoryBaseDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_REPOSITORY}
            };
        }
        public void DtoDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_CLASS_NAME, Constantes.NAME_ENTITY},
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_DTO}
            };
        }
        public void MapperDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_MAPPER}
            };
        }
        public void ServiceBaseDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                {Constantes.TAG_IMPORT_INTERFACE_SERVICE, Constantes.NAMESPACE_INTERFACE_SERVICE},
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_SERVICE}
            };
        }
        public void IAppServiceDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_APP_SERVICE},
                {Constantes.TAG_CLASS_NAME, this.nameFile}
            };
        }
        public void AppServiceDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_APP_SERVICE},
                {Constantes.TAG_CLASS_NAME, this.nameFile},
                {Constantes.TAG_IMPORT_INTERFACE_APP_SERVICE, Constantes.NAMESPACE_INTERFACE_APP_SERVICE}
            };
        }
        public void IServiceDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_SERVICE},
                {Constantes.TAG_CLASS_NAME, this.nameFile},
                {Constantes.TAG_ENTITY_TYPE, Constantes.NAME_ENTITY},
                {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY}
            };
        }
        public void ServiceDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                {Constantes.TAG_IMPORT_INTERFACE_SERVICE, Constantes.NAMESPACE_INTERFACE_SERVICE},
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_SERVICE},
                {Constantes.TAG_ENTITY_TYPE, Constantes.NAME_ENTITY},
                {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                {Constantes.TAG_CLASS_NAME, this.nameFile}
            };
        }
        public void CustomMapperDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                {Constantes.TAG_IMPORT_INTERFACE_SERVICE, Constantes.NAMESPACE_INTERFACE_SERVICE},
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_SERVICE},
                {Constantes.TAG_ENTITY_TYPE, Constantes.NAME_ENTITY},
                {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                {Constantes.TAG_CLASS_NAME, this.nameFile}
            };
        }
        public void EntityDictionary()
        {
            this.dictionary= new Dictionary<string, string>()
            {
                {Constantes.TAG_CLASS_NAME, Constantes.NAME_ENTITY},
                {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_ENTITY}
            };
        }
    }
}