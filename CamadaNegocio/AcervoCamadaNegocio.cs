using System;
using System.Collections.Generic;
using CamadaDados;
using CamadaEntidade;

namespace CamadaNegocio
{
    public class AcervoCamadaNegocio : IAcervoCamadaNegocio
    {
        private readonly IAcervoCamadaDados acervoCamadaDados = new AcervoCamadaDados();
        private readonly ICategoriaCamadaNegocio categoriaCamadaNegocio = new CategoriaCamadaNegocio();
        private ValidacaoCamadaNegocio validacaoCamadaNegocio = new ValidacaoCamadaNegocio();
        public void AdicionarAcervo(Acervo acervo)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(acervo))
                {
                    acervo.CodigoIdentificadorAcervo = GerarCodigoIdentificadorAcervo();

                    for (int contador = acervo.QuantidadeAcervo; contador > 0; contador--)
                    {
                        acervo.CDDAcervo = GerarProximoCDD(acervo.Categoria.CodigoCategoria, acervo.CDDAcervo);
                        acervoCamadaDados.AdicionarAcervo(acervo);
                    }
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao adicionar o Acervo. " + ex.Message);
            }
        }

        public void AtualizarAcervo(Acervo acervo)
        {
            try
            {
                if (validacaoCamadaNegocio.IsValid(acervo))
                {
                    //se a quantidade digitada é maior que a anterior, atualiza o todos os campos do acervo incluido o campo quantidadeAcervo excepto o campo CDDAcervo e volta adicionar o mesmo acervo mas com CDDAcervo diferente de acordo a quantidade digitada.
                    if(acervo.QuantidadeAcervo > acervo.QuantidadeAnteriorAcervo)
                    {
                        acervoCamadaDados.AtualizarAcervo(acervo);
                        //pega a quantidade por adicionar
                        int Quantidade = acervo.QuantidadeAcervo - acervo.QuantidadeAnteriorAcervo;
                        //adiciona acervo.
                        for (int contador = Quantidade; contador > 0; contador--)
                        {
                            acervo.CDDAcervo = GerarProximoCDD(acervo.Categoria.CodigoCategoria, acervo.CDDAcervo);
                            acervoCamadaDados.AdicionarAcervo(acervo);
                        }
                    }
                    //se a quantidade digitada é igual que a anterior, atualiza apenas o acervo.
                    else if (acervo.QuantidadeAcervo == acervo.QuantidadeAnteriorAcervo)
                    {
                        
                        acervoCamadaDados.AtualizarAcervo(acervo);
                    }
                    else
                    {
                        throw new ArgumentException("Não podes registrar uma quantidade menor que a quantidade de acervos atuais. Caso queira diminuir a quantidade deste título, deverá excluir individualmente.");
                    }
                }
                else
                {
                    throw new ArgumentException(validacaoCamadaNegocio.ErrorMessages());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao atualizar o Acervo. " + ex.Message);
            }
        }

        public void ExcluirAcervo(int CodigoAcervo)
        {
            try
            {
                if (CodigoAcervo > 0)
                {
                    acervoCamadaDados.ExcluirAcervo(CodigoAcervo);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao excluir o Acervo. " + ex.Message);
            }
        }       

        public Acervo ObterAcervo(int CodigoAcervo)
        {
            try
            {
                Acervo acervo = new Acervo();

                if (CodigoAcervo > 0)
                {
                    acervo = acervoCamadaDados.ObterAcervoPorCodigo(CodigoAcervo);
                }

                return acervo;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o Acervo. " + ex.Message);
            }
        }
        public List<Acervo> ObterTodosAcervos()
        {
            try
            {
                return acervoCamadaDados.ObterTodosAcervos();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o Acervo. " + ex.Message);
            }
        }

        public List<Acervo> ObterAcervoPorCDD(string CodigoAcervo)
        {
            try
            {
                List<Acervo> ListaAcervoPorCDD = new List<Acervo>();

                if (!string.IsNullOrEmpty(CodigoAcervo))
                {
                    ListaAcervoPorCDD = acervoCamadaDados.ObterAcervoPorCDD(CodigoAcervo);
                }

                return ListaAcervoPorCDD;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o Acervo. " + ex.Message);
            }
        }

        public List<Acervo> ObterAcervoPorNomeCategoria(string NomeCategoria)
        {
            try
            {
                List<Acervo> ListaLivroPorCategoria = new List<Acervo>();

                if (!string.IsNullOrEmpty(NomeCategoria))
                {
                    ListaLivroPorCategoria = acervoCamadaDados.ObterAcervoPorNomeCategoria(NomeCategoria);
                }

                return ListaLivroPorCategoria;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o Acervo. " + ex.Message);
            }
        }

        public List<Acervo> ObterAcervoPorTitulo(string TituloAcervo)
        {
            try
            {
                List<Acervo> ListaAcervoPorTitulo = new List<Acervo>();

                if (!string.IsNullOrEmpty(TituloAcervo))
                {
                    ListaAcervoPorTitulo = acervoCamadaDados.ObterAcervoPorTitulo(TituloAcervo);
                }

                return ListaAcervoPorTitulo;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o Acervo. " + ex.Message);
            }
        }                

        public List<Acervo> ObterAcervoPorLocalizacao(string LocalizacaoAcervo)
        {
            try
            {
                List<Acervo> ListaAcervoPorLocalizacao = new List<Acervo>();

                if (!string.IsNullOrEmpty(LocalizacaoAcervo))
                {
                    ListaAcervoPorLocalizacao = acervoCamadaDados.ObterAcervoPorLocalizacao(LocalizacaoAcervo);
                }

                return ListaAcervoPorLocalizacao;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o Acervo. " + ex.Message);
            }
        }
        
        //Este método gera um guid que será usado como codigo para identificar um acervo.
        private string GerarCodigoIdentificadorAcervo()
        {
            return Guid.NewGuid().ToString("N"); // Gera um novo GUID
        }

        private string ObterUltimoCDDAcervo(int CodigoCategoriaAcervo)
        {
            try
            {
                string ultimoCDDAcervo = string.Empty;

                if (CodigoCategoriaAcervo > 0)
                {
                    ultimoCDDAcervo = acervoCamadaDados.ObterUltimoCDDAcervo(CodigoCategoriaAcervo);
                    
                    if(ultimoCDDAcervo == "000.000")
                    {
                        var categoria = categoriaCamadaNegocio.ObterCategoriaPorCodigo(CodigoCategoriaAcervo);
                        ultimoCDDAcervo = categoria.CDDCategoria + ".000";
                    }
                }

                return ultimoCDDAcervo;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao obter o último o CDD. " + ex.Message);
            }
        }

        // Método para Gerar o CDD
        private string IncrementarCDD(string ultimoCDDAcervo)
        {
            try
            {
                // Divide o CDD em partes inteiras e decimais
                string[] parts = ultimoCDDAcervo.Split('.');

                // Garantir que a parte inteira tenha três dígitos ao converter para int
                int integerPart = int.Parse(parts[0].PadLeft(3, '0')); // Parte inteira com três dígitos
                int decimalPart = parts.Length > 1 ? int.Parse(parts[1]) : 0; // Parte decimal, se existir

                // Incrementa a parte decimal
                decimalPart++;

                // Regras de incremento
                if (decimalPart > 999) // Se a parte decimal exceder 999, incrementa a parte inteira
                {
                    decimalPart = 0; // Reinicia a parte decimal
                    integerPart++;    // Incrementa a parte inteira
                }

                // Retorna o novo CDD formatado com três casas para ambas as partes
                return $"{integerPart:D3}.{decimalPart:D3}";
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao gerar o CDD. " + ex.Message);
            }
        }


        // Método para verificar se o CDD existe. Se existe, tenta gerar um novo CDD até 10 vezes. Se não conseguir gerar um CDD único após 10 tentativas, uma exceção é lançada.
        public string GerarProximoCDD(int CodigoCategoriaAcervo, string CDDAcervo)
        {
            try
            {
                if(CodigoCategoriaAcervo > 0)
                {
                    int tentativas = 0;
                    const int MAX_TENTATIVAS = 10; // Limite para tentativas de gerar CDDAcervo               

                    if (CDDAcervo == "")
                    {
                        string ultimoCDDAcervo = ObterUltimoCDDAcervo(CodigoCategoriaAcervo);
                        CDDAcervo = IncrementarCDD(ultimoCDDAcervo);
                    }

                    // Loop para garantir que o CDD gerado não exista
                    while (acervoCamadaDados.VerificarSeCDDExiste(CDDAcervo, CodigoCategoriaAcervo) && tentativas < MAX_TENTATIVAS)
                    {
                        CDDAcervo = IncrementarCDD(CDDAcervo);
                        tentativas++;
                    }

                    if (tentativas >= MAX_TENTATIVAS)
                    {
                        throw new Exception("Não foi possível gerar um CDD único. Tente novamente mais tarde.");
                    }
                }              

                // Retorna o novo CDD formatado com três casas decimais
                return CDDAcervo;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocorreu um erro ao incrementar o CDD. " + ex.Message);
            }
        }
        
    }
}
