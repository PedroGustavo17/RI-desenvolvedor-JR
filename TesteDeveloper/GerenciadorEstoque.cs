﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteDeveloper
{
    /// <summary>
    /// Implementação da administração de estoque
    /// </summary>
    public class GerenciadorEstoque
    {
        //Saldos de estoque por referência
        private readonly IList<EstoqueProduto> _estoques;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="estoques">Saldos de estoquee por referência</param>
        public GerenciadorEstoque(IList<EstoqueProduto> estoques)
        {
            _estoques = estoques ?? throw new ArgumentNullException(nameof(estoques));
        }

        /// <summary>
        /// Verifica se a quantidade requerida existe no estoque da referência
        /// </summary>
        /// <param name="referencia">Identificador da referência/produto</param>
        /// <param name="quantidadeRequerida">Quantidade requerida</param>
        /// <returns>Indica se a quantidade requerida existe ou não no estoque</returns>
        public bool EstoqueDisponivel(string referencia, int quantidadeRequerida)
        {
            //TODO - Implemente sua lógica para validar o estoque da referência contra a quantidade requerida
            //Dica: Os estoques estão na lista _estoques inicializada no construtor
            var produto = _estoques.FirstOrDefault(e => e.Referencia == referencia);
            return produto != null && produto.SaldoEstoque >= quantidadeRequerida;
        }

        /// <summary>
        /// Buscar saldo de estoque da referência
        /// </summary>
        /// <param name="referencia">Identificador da referência/produto</param>
        /// <returns>Saldo de estoque</returns>
        public int GetSaldo(string referencia)
        {
            //TODO - Implemente sua lógica para buscar e retornar o estoque da referência
            //Dica: Os estoques estão na lista _estoques inicializada no construtor
            var produto = _estoques.FirstOrDefault(e => e.Referencia == referencia);
            return produto?.SaldoEstoque ?? 0;
        }


        /// <summary>
        /// Gera string com os estoques no formato [Referência: {Referencia} Saldo: {SaldoEstoque}] com uma linha para cada referência
        /// Ex: 
        /// Referência: A345 Saldo: 98 
        /// Referência: B456 Saldo: 15
        /// 
        /// </summary>
        /// <returns>String formatada</returns>
        public override string ToString()
        {
            //TODO - Implemente sua lógica para formatar uma string no formato esperado
            //Dica: Os estoques estão na lista _estoques inicializada no construtor
            return string.Join("\n", _estoques.Select(e => $"Referência: {e.Referencia} Saldo: {e.SaldoEstoque}"));
        }


    }
}
