using System;
using TreinamentoProgramacaoOrientadoAObjeto.Herança.Interface;

namespace TreinamentoProgramacaoOrientadoAObjeto.Herança
{
    public class ContaCorrenteRepository
    {
        //Primeira Opção seria
        private readonly IContaCorrenteRepository _contaCorrenteRepository;

        public ContaCorrenteRepository(IContaCorrenteRepository contaCorrenteRepository)
        {
            _contaCorrenteRepository = contaCorrenteRepository;
        }

        public void Salvar(ContaCorrente contaCorrente)
        {
            _contaCorrenteRepository.Save(contaCorrente);
        }
    }
} 