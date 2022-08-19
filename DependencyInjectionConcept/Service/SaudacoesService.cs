using DependencyInjectionConcept.Interface;

namespace DependencyInjectionConcept.Service
{
    public class SaudacoesService : ISaudacoesService
    {
        public string Saudacao(string Nome)
        {
            return $"Olá, {Nome}";
        }
    }
}
