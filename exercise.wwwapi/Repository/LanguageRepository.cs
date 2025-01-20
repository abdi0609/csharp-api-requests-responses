using exercise.wwwapi.Data;
using exercise.wwwapi.Models;


namespace exercise.wwwapi.Repository
{
    public class LanguageRepository
    {
        private LanguageCollection _languageCollection;

        public LanguageRepository(LanguageCollection LanguageCollection)
        {
            _languageCollection = LanguageCollection;
        }

        public Language AddEntity(Language entity)
        {
            _languageCollection.Add(entity);
            return entity;
        }

        public Language DeleteEntity(string name)
        {
            return _languageCollection.Delete(name);
        }

        public List<Language> GetCollection()
        {

            return _languageCollection.getAll();


        }

        public Language GetEntity(string name)
        {
            return _languageCollection.GetLanguage(name);
        }

        public Language UpdateEntity(string name, string newname)
        {
            return _languageCollection.UpdateLanguage(name, newname);
        }

 
    }
}
