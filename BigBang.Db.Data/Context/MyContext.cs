using Db.Data.Mapping;
using Db.Data.Mapping.Base;
using Db.Data.Mapping.DayUse;
using Db.Data.Mapping.DayUse.AutoAtendimento;
using Db.Data.Mapping.DayUse.Passaportes;
using Db.Data.Mapping.DayUse.Quadra;
using Db.Data.Mapping.DayUse.Socio;
using Db.Data.Mapping.DayUse.Voucher;
using Db.Data.Mapping.Hotel.Hospede;
using Db.Data.Mapping.Hotel.Pacotes;
using Db.Data.Mapping.Hotel.Quartos;
using Db.Data.Mapping.Hotel.Refeicao;
using Db.Data.Mapping.Hotel.Reservas;
using Db.Data.Mapping.Itens;
using Db.Domain.Entities.Base.Caixa;
using Db.Domain.Entities.Base.EmpresaSenha;
using Db.Domain.Entities.Base.Estacionamento;
using Db.Domain.Entities.Base.Item;
using Db.Domain.Entities.Base.Logs;
using Db.Domain.Entities.Base.Mesa;
using Db.Domain.Entities.Base.NotaFiscal;
using Db.Domain.Entities.Base.PessoaJuridicaFisica;
using Db.Domain.Entities.Base.Quadra;
using Db.Domain.Entities.Base.UsuarioEmpresa;
using Db.Domain.Entities.Base.UsuarioModulo;
using Db.Domain.Entities.Cadastros;
using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Entities.Cadastros.Base.Configuracao;
using Db.Domain.Entities.Cadastros.Base.Metas;
using Db.Domain.Entities.Cadastros.DayUse;
using Db.Domain.Entities.Cadastros.DayUse.Cartao;
using Db.Domain.Entities.Cadastros.DayUse.Estacionamento;
using Db.Domain.Entities.Cadastros.DayUse.PassaportePacote;
using Db.Domain.Entities.Cadastros.DayUse.Passaportes;
using Db.Domain.Entities.Cadastros.Socio.CategoriaSocio;
using Db.Domain.Entities.DayUse;
using Db.Domain.Entities.DayUse.AutoAtendimento;
using Db.Domain.Entities.DayUse.CartaoConsumoPark;
using Db.Domain.Entities.DayUse.Log;
using Db.Domain.Entities.DayUse.PagamentoTerceirizados;
using Db.Domain.Entities.DayUse.Passaportes;
using Db.Domain.Entities.DayUse.VendaBar;
using Db.Domain.Entities.DayUse.VendingMachine;
using Db.Domain.Entities.DayUse.Voucher;
using Db.Domain.Entities.Financeiro.Bandeira;
using Db.Domain.Entities.Financeiro.Boleto;
using Db.Domain.Entities.Financeiro.CategoriaContas;
using Db.Domain.Entities.Financeiro.Cheques;
using Db.Domain.Entities.Financeiro.Conta;
using Db.Domain.Entities.Hotel.Hospede;
using Db.Domain.Entities.Hotel.Pacotes;
using Db.Domain.Entities.Hotel.Quartos;
using Db.Domain.Entities.Hotel.Refeicao;
using Db.Domain.Entities.Hotel.Reservas;
using Db.Domain.Entities.Socio.SocioCobranca;
using Db.Domain.Entities.Socio.Titulos;
using Db.Domain.Enum.Base.NotaFiscal;
using Db.Domain.Enum.DayUse;
using Domain.Entities;
using Domain.Entities.Cadastros;
using Domain.Entities.Cadastros.Empresa;
using Domain.Entities.Cadastros.EmpresaNFs;
using Domain.Entities.Cadastros.Modulos;
using Domain.Entities.Cadastros.PapelUsuario;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using Domain.Entities.Cadastros.Produto;
using Domain.Entities.Cadastros.Setor;
using Domain.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Db.Data.Context
{

    

    public class MyContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        
        #region Dbset Entidades Base
        public DbSet<AgendaTelefonica> AgendaTelefonica { get; set; }
        public DbSet<ApplicationUser> Usuario { get; set; }
        public DbSet<Empresas> Empresa { get; set; }
        public DbSet<Impressora> Impressora { get; set; }
        public DbSet<EmpresaNF> EmpresaNfce { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Setor> Setor { get; set; }
        public DbSet<Funcao> Funcao { get; set; }
        public DbSet<Acao> Acao { get; set; }
        public DbSet<FuncaoAcoes> FuncaoAcoes { get; set; }
        public DbSet<FuncaoAcaoPerfil> FuncaoAcoesPerfil { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<PassaporteLog> PassaporteLog { get; set; }
        public DbSet<produto> Item { get; set; }
        public DbSet<ItemEntradaSaida> ItemEntradaSaida { get; set; }
        public DbSet<MovimentoEstoque> MovimentoEstoque { get; set; }
        public DbSet<GrupoItem> GrupoItem { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedida { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Modulos> Modulos { get; set; }
        public DbSet<ItemEmpresa> ItemEmpresa { get; set; }
        public DbSet<MetaMensal> MetaMensal { get; set; }
        public DbSet<MetaPorcentagem> MetaPorcentagem { get; set; }
        public DbSet<PontosMeta> PontosMeta { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<MovimentacaoCaixa> MovimentacaoCaixa { get; set; }
        public DbSet<AgenciasPessoas> AgenciasPessoas { get; set; }
        public DbSet<NotaFiscalNfce> NotaFiscalNfce { get; set; }
        public DbSet<ParametrosNotaFiscal> ParametrosNotaFiscal { get; set; }
        public DbSet<UsuarioEmpresa> UsuarioEmpresa { get; set; }
        public DbSet<UsuarioModulos> UsuarioModulos { get; set; }
        public DbSet<EstacionamentoBaixa> EstacionamentoBaixa { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<VendaBar> VendaBar { get; set; }
        #endregion

        #region Dbset Entidades Hotel
        
        public DbSet<QuartoStandby> QuartoStandby { get; set; }
        public DbSet<ManutencaoQuarto> ManutencaoQuarto { get; set; }
        public DbSet<CartaoHospede> CartaoHospede { get; set; }
        public DbSet<HospedeCredito> HospedeCredito { get; set; }
        public DbSet<Pacote> Pacote { get; set; }
        public DbSet<PacoteMensal> PacoteMensal { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<ConsumoQuarto> ConsumoQuarto { get; set; }
        public DbSet<Quarto> Quarto { get; set; }
        public DbSet<RefeicaoCartao> RefeicaoCartao { get; set; }
        public DbSet<RefeicaoConsumo> RefeicaoConsumo { get; set; }
        public DbSet<RefeicaoPreco> RefeicaoPreco { get; set; }
        public DbSet<RefeicaoReserva> RefeicaoReserva { get; set; }
        public DbSet<RefeicaoUsuario> RefeicaoUsuario { get; set; }
        public DbSet<RefeicaoUsuarioMovimento> RefeicaoUsuarioMovimento { get; set; }
        public DbSet<Diaria> Diaria { get; set; }
        public DbSet<GerenciamentoDeQuarto> GerenciamentoDeQuarto { get; set; }
        public DbSet<GerenciamentoDeReserva> GerenciamentoDeReserva { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<ReservaLog> ReservaLog { get; set; }
        public DbSet<ReservaPacote> ReservaPacote { get; set; }
        public DbSet<ReservaReembolso> ReservaReembolso { get; set; }
        public DbSet<WaitList> WaitList { get; set; }        

        #endregion
        #region Dbset Entidades Financeiro
        public DbSet<CategoriaContas> CategoriaConta { get; set; }
        public DbSet<DemonstrativoResultadoExercicio> DemonstrativoResultadoExercicio { get; set; }
        public DbSet<ContaBancaria> Conta { get; set; }
        public DbSet<CentroCusto> CentroCusto { get; set; }
        public DbSet<Bancos> Banco { get; set; }
        public DbSet<Bandeira> Bandeira { get; set; }
        public DbSet<ContasLancamentos> ContasPagar { get; set; }
        public DbSet<TransferenciaBancaria> TransferenciaBancaria { get; set; }
        public DbSet<ControleCheque> ControleCheque { get; set; }
        public DbSet<Boletos> Boleto { get; set; }
        #endregion
        #region Dbset Entidades DayUse
        public DbSet<MovimentoQuadra> MovimentoQuadra { get; set; }
        public DbSet<ValorQuadra> ValorQuadra { get; set; }
        public DbSet<HorarioQuadra> HorarioQuadra { get; set; }
        public DbSet<PassaportePacote> PassaportePacote { get; set; }
        public DbSet<PassaportePromocao> PassaportePromocao { get; set; }
        public DbSet<Catraca> Catraca { get; set; }
        public DbSet<Espaco> Espaco { get; set; }
        public DbSet<TamanhoEspaco> TamanhoEspaco { get; set; }
        public DbSet<EspacoLocacao> EspacoLocacao { get; set; }
        public DbSet<Armario> Armario { get; set; }
        //public DbSet<Bloco> Bloco { get; set; }
        public DbSet<EstacionamentoSocio> EstacionamentoSocio { get; set; }
        public DbSet<Feriado> Feriado { get; set; }
        public DbSet<Passaporte> Passaporte { get; set; }
        public DbSet<CartaoConsumo> CartaoConsumo { get; set; }
        public DbSet<CartaoConsumoCliente> CartaoConsumoCliente { get; set; }
        public DbSet<CartaoConsumoClientePago> CartaoConsumoClientePago { get; set; }
        public DbSet<MovimentacaoCartaoConsumo> MovimentacaoCartaoConsumo { get; set; }
        public DbSet<ConfiguracaoDayUse> ConfiguracaoDayUse { get; set; }
        public DbSet<MovimentacaoCartaoProdutos> MovimentacaoCartaoProdutos { get; set; }        
        public DbSet<Excursao> Excursao { get; set; }
        public DbSet<ExcursaoPassaporte> ExcursaoPassaporte { get; set; }
        public DbSet<ExcursaoProdutos> ExcursaoProdutos { get; set; }
        public DbSet<PagamentoTerceiro> PagamentoTerceiro { get; set; }
        public DbSet<PagamentoTerceirosVoucher> PagamentoTerceirosVoucher { get; set; }
        public DbSet<VendingMachine> VendingMachine { get; set; }
        public DbSet<VendingMachineProduto> VendingMachineProduto { get; set; }
        public DbSet<SocioCobranca> SocioCobranca { get; set; }
        public DbSet<TituloSocios> TituloSocios { get; set; }
        public DbSet<SerieTitulo> SerieTitulo { get; set; }
        public DbSet<AutomacaoLocalizacao> AutomacaoLocalizacao { get; set; }
        public DbSet<AutomacaoConfiguracao> AutomacaoConfiguracao { get; set; }
        public DbSet<AutomacaoMovimento> AutomacaoMovimento { get; set; }
        

        public DbSet<AutomacaoLog> AutomacaoLog { get; set; }
        

        public DbSet<VoucherPassaporte> VoucherPassaporte { get; set; }
        #endregion
        #region Dbset Entidades Socio
        public DbSet<Cobradores> Cobradores { get; set; }
        public DbSet<CategoriaSocio> CategoriaSocio { get; set; }
        public DbSet<EmpresaSenha> EmpresaSenha { get; set; }

        public DbSet<LogDayUser> LogDayUser { get; set; }

        public DbSet<PagamentoTerceirosItem> PagamentoTerceiroItem { get; set; }
        public DbSet<MesaBar> MesaBar { get; set; }




        #endregion

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Query<LogDayUser>();


            //var query = builder.Query<LogDayUser>().FromSqlRaw("EXECUTE dbo.ListUserClaims @userId=@UserVal, @clientId=@ClientVal, @consultationId=@ConsultationVal");

            //var teste = builder. ("EXECUTE dbo.ListUserClaims @userId=@UserVal, @clientId=@ClientVal, @consultationId=@ConsultationVal");

            ////var query = Context.Set<ClaimDataView>().FromSql(...);

            #region Configuracao Entidades Base
            builder.Entity<AgendaTelefonica>(new AgendaTelefonicaMap().Configure);
            builder.Entity<Empresas>(new EmpresaMap().Configure);
            builder.Entity<Impressora>(new ImpressoraMap().Configure);
            builder.Entity<Funcao>(new FuncaoMap().Configure);
            builder.Entity<Acao>(new AcaoMap().Configure);
            builder.Entity<FuncaoAcoes>(new FuncaoAcoesMap().Configure);
            builder.Entity<FuncaoAcaoPerfil>(new FuncaoAcaoPerfilMap().Configure);
            builder.Entity<produto>(new ItemMap().Configure);
            builder.Entity<GrupoItem>(new GrupoItemMap().Configure);
            builder.Entity<UnidadeMedida>(new UnidadeMedidaMap().Configure);
            builder.Entity<PassaporteLog>(new PassaporteLogMap().Configure);
            builder.Entity<Setor>(new SetorMap().Configure);
            builder.Entity<Pessoa>(new PessoaMap().Configure);
            builder.Entity<PessoaCreditoDebito>(new PessoaCreditoDebitoMap().Configure);
            builder.Entity<Perfil>(new PerfilMap().Configure);
            builder.Entity<Endereco>(new EnderecoMap().Configure);
            builder.Entity<PontoVenda>(new PontoVendaMap().Configure);
            builder.Entity<Telefone>(new TelefoneMap().Configure);
            builder.Entity<Departamento>(new DepartamentoMap().Configure);
            builder.Entity<Modulos>(new ModulosMap().Configure);
            builder.Entity<EmpresaNF>(new EmpresaNfMap().Configure);
            builder.Entity<ItemEmpresa>(new ItemEmpresaMap().Configure);
            builder.Entity<ItemEntradaSaida>(new ItemEntradaSaidaMap().Configure);
            builder.Entity<MovimentoEstoque>(new MovimentoEstoqueMap().Configure);
            builder.Entity<MetaMensal>(new MetaMensalMap().Configure);
            builder.Entity<MetaPorcentagem>(new MetaPorcentagemMap().Configure);
            builder.Entity<PontosMeta>(new PontosMetaMap().Configure);
            builder.Entity<Caixa>(new CaixaMap().Configure);
            builder.Entity<MovimentacaoCaixa>(new MovimentacaoCaixaMap().Configure);
            builder.Entity<AgenciasPessoas>(new AgenciasPessoasMap().Configure);
            builder.Entity<NotaFiscalNfce>(new NotaFiscalNfceMap().Configure);
            builder.Entity<ParametrosNotaFiscal>(new ParametrosNotaFiscalMap().Configure);
            builder.Entity<UsuarioEmpresa>(new UsuarioEmpresaMap().Configure);
            builder.Entity<UsuarioModulos>(new UsuarioModuloMap().Configure);
            builder.Entity<MesaBar>(new MesaBarMap().Configure);
            builder.Entity<EmpresaSenha>(new EmpresaSenhaMap().Configure);
            builder.Entity<Log>(new LogMap().Configure);
            #endregion
            #region Configuracao Entidades Hotel
            //Hotel
            builder.Entity<CartaoHospede>(new CartaoHospedeMap().Configure);
            builder.Entity<HospedeCredito>(new HospedeCreditoMap().Configure);
            builder.Entity<PacoteMensal>(new PacoteMensalMap().Configure);
            builder.Entity<Pacote>(new PacoteMap().Configure);
            builder.Entity<Categoria>(new CategoriaQuartoMap().Configure);
            builder.Entity<ConsumoQuarto>(new ConsumoQuartoMap().Configure);
            builder.Entity<Quarto>(new QuartoMap().Configure);
            builder.Entity<RefeicaoCartao>(new RefeicaoCartaoMap().Configure);
            builder.Entity<RefeicaoConsumo>(new RefeicaoConsumoMap().Configure);
            builder.Entity<RefeicaoPreco>(new RefeicaoPrecoMap().Configure);
            builder.Entity<RefeicaoReserva>(new RefeicaoReservaMap().Configure);
            builder.Entity<RefeicaoUsuario>(new RefeicaoUsuarioMap().Configure);
            builder.Entity<RefeicaoUsuarioMovimento>(new RefeicaoUsuarioMovimentoMap().Configure);
            builder.Entity<Diaria>(new DiariaMap().Configure);
            builder.Entity<GerenciamentoDeQuarto>(new GerenciamentoDeQuartoMap().Configure);
            builder.Entity<GerenciamentoDeReserva>(new GerenciamentoDeReservaMap().Configure);
            builder.Entity<Reserva>(new ReservaMap().Configure);
            builder.Entity<ReservaLog>(new ReservaLogMap().Configure);
            builder.Entity<ReservaPacote>(new ReservaPacoteMap().Configure);
            builder.Entity<ReservaReembolso>(new ReservaReembolsoMap().Configure);
            builder.Entity<WaitList>(new WaitListMap().Configure);
            builder.Entity<QuartoStandby>(new QuartoStandbyMap().Configure);
            builder.Entity<ManutencaoQuarto>(new ManutencaoQuartoMap().Configure);

            #endregion
            #region Configuracao Entidades Financeiro
            //Financeiro
            builder.Entity<CategoriaContas>(new CategoriaContasMap().Configure);
            builder.Entity<DemonstrativoResultadoExercicio>(new DemonstrativoResultadoExercicioMap().Configure);
            builder.Entity<ContaBancaria>(new ContaMap().Configure);
            builder.Entity<CentroCusto>(new CentroCustoMap().Configure);
            builder.Entity<Bancos>(new BancosMap().Configure);
            builder.Entity<Bandeira>(new BandeiraMap().Configure);
            builder.Entity<ContasLancamentos>(new ContasLancamentosMap().Configure);
            builder.Entity<TransferenciaBancaria>(new TransferenciaBancariaMap().Configure);
            builder.Entity<ControleCheque>(new ControleChequeMap().Configure);
            builder.Entity<Boletos>(new BoletoMap().Configure);
            builder.Entity<PagamentoTerceirosItem>(new PagamentoTerceirosItemMap().Configure);
            #endregion
            #region Configuracao Entidades DayUse
            //DayUse
            builder.Entity<MovimentoQuadra>(new MovimentoQuadraMap().Configure);
            builder.Entity<ValorQuadra>(new ValorQuadraMap().Configure);
            builder.Entity<HorarioQuadra>(new HorarioQuadraMap().Configure);
            builder.Entity<VoucherPassaporte>(new VoucherPassaporteMap().Configure);
            builder.Entity<PassaportePacote>(new PassaportePacoteMap().Configure);
            builder.Entity<VoucherPassaporte>(new VoucherPassaporteMap().Configure);
            builder.Entity<PassaportePromocao>(new PassaportePromocaoMap().Configure);
            builder.Entity<Catraca>(new CatracaMap().Configure);
            builder.Entity<Armario>(new ArmarioMap().Configure);

            //builder.Entity<Bloco>(new BlocoMap().Configure);
            builder.Entity<EstacionamentoSocio>(new EstacionamentoSocioMap().Configure);
            builder.Entity<Feriado>(new FeriadoMap().Configure);
            builder.Entity<Espaco>(new EspacoMap().Configure);
            builder.Entity<TamanhoEspaco>(new TamanhoEspacoMap().Configure);
            builder.Entity<Passaporte>(new PassaporteMap().Configure);
            builder.Entity<CartaoConsumo>(new CartaoConsumoMap().Configure);
            builder.Entity<CartaoConsumoCliente>(new CartaoConsumoClienteMap().Configure);
            builder.Entity<CartaoConsumoClientePago>(new CartaoConsumoClientePagoMap().Configure);
            builder.Entity<MovimentacaoCartaoConsumo>(new MovimentacaoCartaoConsumoMap().Configure);
            builder.Entity<ConfiguracaoDayUse>(new ConfiguracaoDayUseMap().Configure);
            builder.Entity<MovimentacaoCartaoProdutos>(new MovimentacaoCartaoProdutosMap().Configure);          
            builder.Entity<EspacoEspera>(new EspacoEsperaMap().Configure);
            builder.Entity<EspacoLocacao>(new EspacoLocacaoMap().Configure);
            builder.Entity<EspacoPreReserva>(new EspacoPreReservaMap().Configure);
            builder.Entity<Excursao>(new ExcursaoMap().Configure);
            builder.Entity<ExcursaoPassaporte>(new ExcursaoPassaporteMap().Configure);
            builder.Entity<ExcursaoProdutos>(new ExcursaoProdutosMap().Configure);
            builder.Entity<PagamentoTerceiro>(new PagamentoTerceirosMap().Configure);
            builder.Entity<PagamentoTerceirosVoucher>(new PagamentoTerceirosVoucherMap().Configure);
            builder.Entity<VendingMachine>(new VendingMachineMap().Configure);
            builder.Entity<VendingMachineProduto>(new VendingMachineProdutoMap().Configure);
            builder.Entity<AutomacaoLocalizacao>(new AutomacaoLocalizacaoMap().Configure);
            builder.Entity<AutomacaoMovimento>(new AutomacaoMovimentoMap().Configure);
            builder.Entity<AutomacaoConfiguracao>(new AutomacaoConfiguracaoMap().Configure);
            builder.Entity<AutomacaoLog>(new AutomacaoLogMap().Configure);
            builder.Entity<LogDayUser>(new LogDayUserMap().Configure);
            builder.Entity<VendaBar>(new VendaBarMap().Configure);

            #endregion
            #region Configuracao Entidades Socio

            builder.Entity<Cobradores>(new CobradoresMap().Configure);
            builder.Entity<CategoriaSocio>(new CategoriaSocioMap().Configure);
            builder.Entity<SocioCobranca>(new SocioCobrancaMap().Configure);
            builder.Entity<TituloSocios>(new TituloSociosMap().Configure);
            builder.Entity<SerieTitulo>(new SerieTituloMap().Configure);
            #endregion
            #region Configuracao Comentario Enum     
            #region Base     
            //builder.Entity<Empresas>().Property(c => c.TipoEmpresa)
            //.HasComment("Hotel = 1 - Restaurante = 2 - Bar = 3 - Agencia = 4 - " +
            //"Lanchonete = 5 - Diversao = 6 - Conveniencia = 7 - Outros = 8");
            //builder.Entity<Empresas>().Property(c => c.TipoEstoque).HasComment("FIFO = 1 - LIFO = 2 - FEFO = 3");
            //builder.Entity<Empresas>().Property(c => c.TipoRegimeTributario)
            //.HasComment("Mei = 1 - SimplesNacional = 2 - LucroReal = 3 - LucroPresumido = 4");
            //builder.Entity<Item>().Property(c => c.TipoItem)
            //   .HasComment("Produto = 1 - Servico = 2");
            //builder.Entity<Telefone>().Property(c => c.TipoTelefone)
            //  .HasComment("Celular = 1 - Fixo = 2 - Comercial = 3");
            //builder.Entity<Telefone>().Property(c => c.Operadora)
            //  .HasComment("CLARO = 1 - CTBC = 2 - NEXTEL = 3 - SERCOMTEL = 4 - TIM = 5 - VIVO = 6 - OI = 7 - OUTRAS = 8");
            //builder.Entity<Telefone>().Property(c => c.TipoTelefone)
            //  .HasComment("Celular = 1 - Fixo = 2 - Comercial = 3");
            //builder.Entity<Endereco>().Property(c => c.TipoEndereco)
            //    .HasComment("Principal = 1,Cobrança = 2,Responsavel = 3");
            //builder.Entity<Pessoa>().Property(c => c.TipoPessoa)
            //    .HasComment("Cliente = 1 - Hospede = 2 - Fornecedor = 3 Empresa = 4, Agencia = 5, Escola = 6, Socio = 7");
            //builder.Entity<Pessoa>().Property(c => c.Sexo)
            //   .HasComment("Feminino = 1 - Masculino = 2 - Outros = 3");
            //builder.Entity<Empresas>().Property(c => c.TipoEmpresa)
            //    .HasComment("Hotel = 1 - Restaurante = 2, Bar = 3, Agencia = 4, Lanchonete = 5, Diversao = 6, Conveniencia = 7, Outros = 8, Adiministracao = 9 ");
            //builder.Entity<Empresas>().Property(c => c.TipoRegimeTributario)
            //    .HasComment("MEI = 1, SIMPLES NACIONAL = 2, LUCRO REAL = 3, LUCRO PRESUMIDO = 4 ");
            //builder.Entity<Pessoa>().Property(c => c.Parentesco)
            //  .HasComment("Filho = 1, Mae = 2, Pai = 3, Cunhado = 4, Esposo = 5, Enteado = 6, Irmao = 7, Neto = 8, Sobrinho = 9, Padastro = 10, Madastra = 11," +
            //  "Namorado = 12, Primo = 13, Sogro = 14, Tio = 15, Avo = 16, Genro = 17, Nora = 18");
            //Coloca descrição nos campos das tabelas conforme exemplo abaixo
            //builder.Entity<AgendaTelefonica>().Property(c => c.Descricao)
            //.HasComment("Odcleverson");
            //fim colocar descrição nos campos das tabelas
            #endregion
            #region atm
            //builder.Entity<AutomacaoLocalizacao>().Property(c => c.TipoAutomacao)
            //.HasComment("Armario = 1 - Catraca = 2 - Recarga = 3 - Jogos = 4 - Estacionamento_Recarga = 5");
            //#endregion
            //#region Hotel     
            //builder.Entity<Quarto>().Property(c => c.Status)
            //  .HasComment("Livre = 0 -  Limpeza = 1 - Manutenção = 2 - Bloqueado_para_reserva = 3 - " +
            //  "Parcialmente_confirmado = 4 - CheckIn = 5 - No_Show = 6 - Reservado = 10 -  " +
            //  "Reserva_confirmada = 11 - Ocupado = 12 -  Vencido = 13 - Finalizado = 14 - Cancelado = 15 - " +
            //  "Credito = 16 - Reserva_confirmada_gerente = 17 - Finalizado_Credito = 18 - Baixa_nao_confirmado = 19 ");
            //#endregion
            //#region Financeiro 
            //builder.Entity<CategoriaContas>().Property(c => c.Natureza)
            //     .HasComment("Receita = 1 - Despesa = 2");
            //builder.Entity<ContaBancaria>().Property(c => c.TipoCartao)
            //    .HasComment("Visa = 1 - Master = 2 - Diners = 3 - AmericanExpress = 4 - Elo = 5 - Hipercard = 6 - " +
            //                "Outro = 7");
            //builder.Entity<ContaBancaria>().Property(c => c.TipoConta)
            //   .HasComment("Corrente = 1 - Poupanca = 2 - Caixinha = 3 - CartaoCredito = 4 - Investimento = 5 - " +
            //                "AplicacaoAutomatica = 6");
            //builder.Entity<ContaBancaria>().Property(c => c.TipoPessoa)
            //  .HasComment("Fisica = 1 - Juridica = 2 - Extrangeiro = 3");
            //builder.Entity<MovimentacaoCaixa>().Property(c => c.TipoMovimento)
            //   .HasComment("Hospedagem = 1 - AdiantamentoReserva = 2 - Retirada = 3 - Devolucao = 4 - Quiosque = 5 - Excursao = 6" +
            //   "Passaporte = 7 - Carga = 8 - Recarga = 9 - Mesas = 10 - TrocoAdicional = 11 - AdiantamentoHospedagem = 12");
            //builder.Entity<MovimentacaoCaixa>().Property(c => c.TipoPagamento)
            //   .HasComment("Dinheiro = 1 - Credito = 2 - Debito = 3 - Deposito = 4 - Faturado = 5");
            //builder.Entity<Caixa>().Property(c => c.Situacao)
            //    .HasComment("Fechado = 0 - Aberto = 1 - FechadoDataCorrente = 2 - AbertoDiaAnterior = 3");

            #endregion
            #region DayUse     
            //builder.Entity<LogDayUser>().Property(c => c.TipoMovimentoLog)
            //    .HasComment("Erro Venda Bar = 1 - VendaSemComissao = 2");
            //builder.Entity<PassaportePacote>().Property(c => c.TipoPessoa)
            //    .HasComment("Adulto = 1 - Criacao = 2 - Senior = 3");
            //builder.Entity<PassaportePacote>().Property(c => c.TipoReserva)
            //    .HasComment("Excursao = 1 - Passaporte = 2 - Chale = 3 - Quiosque = 4 - SalaoFesta = 5 - Hospedagem = 6");
            //builder.Entity<PassaportePacote>().Property(c => c.TipoVenda)
            //    .HasComment("Park = 1 - Externo = 2 - Site = 3");
            //builder.Entity<Armario>().Property(c => c.SituacaoArmario)
            //    .HasComment("Livre = 1 - Externo = 2 - Site = 3");
            //builder.Entity<CartaoConsumo>().Property(c => c.Situacao)
            //    .HasComment("Livre = 1 - Perdido = 2 - Ocupado = 3 - Retido = 4 -Devolvido = 5 - Mestre = 6");
            //builder.Entity<CartaoConsumo>().Property(c => c.TipoCartaoConsumo)
            //    .HasComment("Parque = 1 - Hotel = 2");
            //builder.Entity<MovimentacaoCartaoConsumo>().Property(c => c.TipoMovimentoCartao)
            //    .HasComment("Carga = 1 - Recarga = 2 - Bar = 3 - Devolucao = 4 - Armario = 5 - Zera Cartao = 6 - Perda = 7 - " +
            //    "Devolucao Valor Armario = 8 - Transferencia Recebimento = 9 - ransferencia Negativacao = 10 Estacionamento = 11 Estorno Armario = 12" +
            //    "Envio Nota = 13");
            //builder.Entity<EspacoLocacao>().Property(c => c.SituacaoLocacao)
            //    .HasComment("Reservado = 1 - Alugado = 2 - Compareceu = 3 - Cancelado = 4 - Livre = 5 - Pre-reservado = 6");
            //builder.Entity<EspacoEspera>().Property(c => c.TipoReserva)
            //    .HasComment("Excursão = 1 - Passaporte = 2 - Chalé = 3 - Quiosque = 4 - Salão de Festa = 5 - Hospedagem = 6");
            //builder.Entity<Passaporte>().Property(c => c.TipoPassaporte)
            //    .HasComment("Adulto = 1 - Criança = 2 - Senior = 3 - Cortesia Adicional = 4 - Cortesia = 5 - Vendas Internet = 6");
            //builder.Entity<Passaporte>().Property(c => c.Situacao)
            //    .HasComment("Confirmado = 1 - Cancelado = 2 - Usado = 3");
            #endregion
            #region Socio
            #region Cobradores
           // builder.Entity<Cobradores>().Property(c => c.TipoDesconto)
           // .HasComment("Porcentagem = 1 - Dinheiro = 2");
           // builder.Entity<Cobradores>().Property(c => c.TipoEspecie)
           //   .HasComment("Real = 1 - Guarani = 2 - Dolar = 3");
           // builder.Entity<Cobradores>().Property(c => c.TipoJuros)
           //   .HasComment("Porcentagem = 1 - Dinheiro = 2");
           // builder.Entity<Cobradores>().Property(c => c.TipoMulta)
           //   .HasComment("Porcentagem = 1 - Dinheiro = 2");
           // builder.Entity<Cobradores>().Property(c => c.FormatoArquivoRemessa)
           //.HasComment("Cnab400 = 1 - Cnab240 = 2");
           // builder.Entity<Cobradores>().Property(c => c.TituloDocEspecie)
           //  .HasComment("Não Informado = 00, Cheque = 01," + "Duplicata Mercantil = 02," + " Duplicata Mercantil p/ Indicação = 03," + " Duplicata de Serviço = 04,"
           //             + " Duplicata de Serviço p/ Indicação = 05," + " Duplicata Rural = 06," + " Letra de Câmbio = 07," + " Nota de Crédito Comercial = 08," +
           //             " Nota de Crédito a Exportação = 09," + " Nota de Crédito Industrial = 10," + " Nota de Crédito Rural = 11," + " Nota Promissória = 12," +
           //             " Nota Promissória Rural = 13," + " Triplicata Mercantil = 14," + " Triplicata de Serviço = 15," + " Nota de Seguro = 16," +
           //             " Recibo = 17," + "Fatura = 18," + " Nota de Débito = 19," + " Apólice de Seguro = 20," + " Mensalidade Escolar = 21," +
           //             " Parcela de Consórcio = 22," + " Nota Fiscal = 23," + " Documento de Dívida = 24," + " Cédula de Produto Rural = 25," +
           //             " Warrant = 26," + " Dívida Ativa Estado = 27," + " Dívida Ativa Município = 28," +
           //             " Dívida Ativa União = 29," + " Encargos Condominiais = 30," + " Cartão de Crédito = 31," + " Boleto Proposta = 32," + " Outros = 99");
            #endregion            
            #endregion
            #endregion
            #region Configuracao Identity 
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "base_Usuarios");
                entity.Property(c => c.SetorId).HasColumnName("IdSetor");
                entity.Property(c => c.PerfilId).HasColumnName("IdPerfil");
                entity.Property(c => c.AccessFailedCount).HasColumnName("AcessoFalhas");
                entity.Property(c => c.ConcurrencyStamp).HasColumnName("Concorrencia");
                entity.Property(c => c.EmailConfirmed).HasColumnName("EmailConfirmado");
                entity.Property(c => c.LockoutEnabled).HasColumnName("BloqueioAtivo");
                entity.Property(c => c.LockoutEnd).HasColumnName("FimBloqueio");
                entity.Property(c => c.NormalizedEmail).HasColumnName("EmailNormalizado");
                entity.Property(c => c.NormalizedUserName).HasColumnName("LoginNormalizado");
                entity.Property(c => c.PasswordHash).HasColumnName("SenhaHash");
                entity.Property(c => c.PhoneNumber).HasColumnName("TelefoneNumero");
                entity.Property(c => c.PhoneNumberConfirmed).HasColumnName("TelefoneConfirmado");
                entity.Property(c => c.SecurityStamp).HasColumnName("Seguranca");
                entity.Property(c => c.TwoFactorEnabled).HasColumnName("VerificaDoisPassos");
                entity.Property(c => c.UserName).HasColumnName("Login");
                entity.Property(c => c.Id).HasColumnType("int");
                
            });

            builder.Entity<IdentityRole<int>>(entity =>
            {
                entity.ToTable(name: "base_Politicas");
                entity.Property(c => c.Name).HasColumnName("Nome");
                entity.Property(c => c.NormalizedName).HasColumnName("NomeNormalizado");
                entity.Property(c => c.ConcurrencyStamp).HasColumnName("Concorrencia");
            });
            builder.Entity<IdentityUserRole<int>>(entity =>
            {
                entity.ToTable("base_UsuariosPoliticas");
                entity.Property(c => c.UserId).HasColumnName("IdUsuario");
                entity.Property(c => c.RoleId).HasColumnName("IdPolitica");
            });

            builder.Entity<IdentityUserClaim<int>>(entity =>
            {
                entity.ToTable("base_UsuariosPapeis");
                entity.Property(c => c.ClaimType).HasColumnName("Tipo");
                entity.Property(c => c.ClaimValue).HasColumnName("Valor");
                entity.Property(c => c.UserId).HasColumnName("IdUsuario");
            });

            builder.Entity<IdentityUserLogin<int>>(entity =>
            {
                entity.ToTable("base_UsuariosLogins");
                entity.Property(c => c.LoginProvider).HasColumnName("LoginProvavel");
                entity.Property(c => c.ProviderDisplayName).HasColumnName("NomeProvavel");
                entity.Property(c => c.ProviderKey).HasColumnName("ChaveProvavel");
                entity.Property(c => c.UserId).HasColumnName("IdUsuario");
            });

            builder.Entity<IdentityRoleClaim<int>>(entity =>
            {
                entity.ToTable("base_PoliticasClaims");
                entity.Property(c => c.ClaimType).HasColumnName("Tipo");
                entity.Property(c => c.ClaimValue).HasColumnName("Valor");
                entity.Property(c => c.RoleId).HasColumnName("IdPolitica");
            });

            builder.Entity<IdentityUserToken<int>>(entity =>
            {
                entity.ToTable("base_UsuariosTokens");
                entity.Property(c => c.LoginProvider).HasColumnName("LoginProvavel");
                entity.Property(c => c.Name).HasColumnName("Nome");
                entity.Property(c => c.UserId).HasColumnName("IdUsuario");
                entity.Property(c => c.Value).HasColumnName("Valor");
            });

            builder.Entity<IdentityUserClaim<int>>(entity =>
            {
                entity.ToTable("base_UsuariosPapeis");
                entity.Property(c => c.ClaimType).HasColumnName("Tipo");
                entity.Property(c => c.ClaimValue).HasColumnName("Valor");
                entity.Property(c => c.UserId).HasColumnName("IdUsuario");
            });


            #endregion
            #region Sequencias
            //builder.HasSequence<int>("NumeroComprovanteCartaoConsumo").StartsAt(1000).IncrementsBy(1);
            //builder.HasSequence<int>("NumeroPassaporteImpresso").StartsAt(2020197213).IncrementsBy(1);
            //builder.HasSequence<int>("NumeroIdentificadorEspaco").StartsAt(2020709201).IncrementsBy(1);
            //builder.HasSequence<int>("NumeroRecibo").StartsAt(0000000001).IncrementsBy(1);
            //builder.HasSequence<int>("NumeroVoucherAlimentacao").StartsAt(2020161452).IncrementsBy(1);
            //builder.HasSequence<int>("NumeroVoucherPassaporte").StartsAt(2020855150).IncrementsBy(1);
            //builder.HasSequence<int>("RIBEIRO_2_Homologacao").StartsAt(0000000001).IncrementsBy(1);
            #endregion
            #region Seed Data Tabelas


            #endregion


        }

        //private void DadosParametrosNFCe(ModelBuilder builder)
        //{
        //    builder.Entity<ParametrosNotaFiscal>().HasData(
        //        new ParametrosNotaFiscal
        //        {
        //            Id = 1,
        //            WebServiceUf = "PR",
        //            FusoHorario = "-03:00",
        //            ArquivoHomologacao = "C:\\NFCE\\nfceServidoresHom.ini",
        //            ArquivoProducao = "C:\\NFCE\\nfceServidoresProd.ini",
        //            DiretorioEsquemas = "C:\\NFCE\\Esquemas\\",
        //            DiretorioTemplate = "C:\\NFCE\\Templates\\",
        //            DiretorioLog = "C:\\NFCE\\Log\\",
        //            DiretorioLogErro = "C:\\NFCE\\LogErro\\",
        //            DiretorioTemporario = "C:\\bigbang\\dayuse\\WebApiNFCe",
        //            DiretorioNotasRaiz = "C:\\NFCE\\NFCENOTAS\\",
        //            DiretorioNotasZipe = "C:\\NFCE\\NFCENOTAS_ZIP\\",
        //            DiretorioNotasAutorizado = "\\NFCE_AUTORIZADO\\",
        //            DiretorioNotasCancelados = "\\NFCE_CANCELADOS\\",
        //            DiretorioNotasInutilizada = "\\NFCE_INUTILIZADOS\\",
        //            DiretorioNotasContigencia = "\\NFCE_CONTIGENCIA\\",
        //        }
        //        );
        //}

        //private static void DadosEmpresa(ModelBuilder builder)
        //{
        //    builder.Entity<Empresas>().HasData(
        //                    new Empresas { Id = 1, RazaoSocial = "Razao social", Fantasia = "Fantasia", Ativo = true, Bloqueio = false, Cnpj = "99999999999999", InscricaoEstadual = "9999999999", Responsavel = "master", TipoEmpresa = TipoEmpresa.Administracao, TipoRegimeTributario = TipoRegimeTributario.Mei, TipoEstoque = TipoEstoque.FIFO, NFe = false, NFSe = false, NFCe = false, Porcentagem = 70, IdPacoteCpf = "2", TokenCpfCnpj = "269da865b56877ab310503d56b8888c5", DataInicio = DateTime.Now }
        //                    );
        //}

        //private static void DadosEmpresaTelefone(ModelBuilder builder)
        //{
        //    builder.Entity<Telefone>().HasData(
        //                    new Telefone { Id = 1, DDD = "44", EmpresaId = 1, Ativo = true, Numero = "999999999", Operadora = OperadoraTelefonia.CLARO, TipoTelefone = TipoTelefone.Celular }
        //                    );
        //}



        //private static void DadosPapeis(ModelBuilder builder)
        //{
        //    builder.Entity<Perfil>().HasData(
        //        new Perfil { Id = 1, Ativo = true, Nome = "Master", Descricao = "Administra todo o sistema", TempoExpiracao = "5000" },
        //        new Perfil { Id = 2, Ativo = true, Nome = "Bar", Descricao = "Somente Bar", TempoExpiracao = "5000" }
        //   );
        //}

        //private static void DadosSetor(ModelBuilder builder)
        //{
        //    builder.Entity<Setor>().HasData(
        //    new Setor { Id = 1, Ativo = true, Descricao = "Master" },
        //    new Setor { Id = 2, Ativo = true, Descricao = "Diretor" },
        //    new Setor { Id = 3, Ativo = true, Descricao = "Gerente Geral" },
        //    new Setor { Id = 4, Ativo = true, Descricao = "Financeiro" },
        //    new Setor { Id = 5, Ativo = true, Descricao = "RH" },
        //    new Setor { Id = 6, Ativo = true, Descricao = "Gerente Park" },
        //    new Setor { Id = 7, Ativo = true, Descricao = "Gerente Hotel" },
        //    new Setor { Id = 8, Ativo = true, Descricao = "Portaria" },
        //    new Setor { Id = 9, Ativo = true, Descricao = "Tikets,Carga,Recarga e Devolucao" },
        //    new Setor { Id = 10, Ativo = true, Descricao = "Bares" },
        //    new Setor { Id = 11, Ativo = true, Descricao = "Armarios" },
        //    new Setor { Id = 12, Ativo = true, Descricao = "Titulos" },
        //    new Setor { Id = 13, Ativo = true, Descricao = "Recepcionista Hotel" },
        //    new Setor { Id = 14, Ativo = true, Descricao = "Supervisor Park" },
        //    new Setor { Id = 15, Ativo = true, Descricao = "Supervisor Hotel" }
        //       );
        //}

        //private static void DadosUsuarioEmpresa(ModelBuilder builder)
        //{
        //    builder.Entity<UsuarioEmpresa>().HasData(
        //        new UsuarioEmpresa { Id = 1, EmpresaId = 1, UsuarioId = 1, Ativo = true }
        //     );
        //}

        //private static void DadosUsuarioPadrao(ModelBuilder builder)
        //{
        //    builder.Entity<ApplicationUser>().HasData(
        //                new ApplicationUser
        //                {
        //                    Id = 1,
        //                    Ativo = true,
        //                    NormalizedUserName = "master",
        //                    UserName = "master",
        //                    Nome = "master",
        //                    Telefone = "(99)9999-9999",
        //                    Sobrenome = "master",
        //                    NormalizedEmail = "user@example.com",
        //                    PasswordHash = "AQAAAAEAACcQAAAAEMocWRx9c9FvBkFLXUqdiGGsWeNlXhGc+ZKQRtgy+KhPOHTJJxxIReZGoniOTORGsQ==",
        //                    SecurityStamp = "ZNCCOJG4FOXESTEYTWJI2CX2SZSL3ER2",
        //                    ConcurrencyStamp = "e225fbb2-ec39-4604-bcae-f9853da423b7",
        //                    PhoneNumberConfirmed = false,
        //                    TwoFactorEnabled = false,
        //                    LockoutEnabled = true,
        //                    AccessFailedCount = 0,
        //                    PhoneNumber = "(99)99999-9999",
        //                    SetorId = 1,
        //                    PerfilId = 1,
        //                    Email = "master@master.com.br",
                            
        //                });
        //}
        //private static void DadosItem(ModelBuilder builder)
        //{
        //    builder.Entity<Item>().HasData(
        //    new Item { Id = 1, Ativo = true, Descricao = "GUARANA ANTARCTICA LATA 350 ML", DepartamentoId = 1, DescricaoPainel = "Guarana", GTIN = "7891991000826", CodigoBarras = "7891991000826", ValorUnitario = Convert.ToDecimal("7"), NCM = "22021000", Iss = 0, Cest = "0300700", CFOP = "5405", CST = "500", TributacaoFederal = Convert.ToDecimal("9,45"), TributacaoEstadual = Convert.ToDecimal("2,76"), SituacaoTributaria = "0" },
        //    new Item { Id = 2, Ativo = true, Descricao = "COCA-COLA ZERO 350 ML", DepartamentoId = 1, DescricaoPainel = "COCA-COLA ZERO", GTIN = "7894900700015", CodigoBarras = "7894900700015", ValorUnitario = Convert.ToDecimal("7"), NCM = "22021000", Iss = 0, Cest = "0300700", CFOP = "5405", CST = "500", TributacaoFederal = Convert.ToDecimal("9,45"), TributacaoEstadual = Convert.ToDecimal("2,76"), SituacaoTributaria = "0" },
        //    new Item { Id = 3, Ativo = true, Descricao = "FANTA LARANJA LATA 350 ML", DepartamentoId = 1, DescricaoPainel = "FANTA LARANJA", GTIN = "7894900030013", CodigoBarras = "7894900030013", ValorUnitario = Convert.ToDecimal("7"), NCM = "22021000", Iss = 0, Cest = "0300700", CFOP = "5405", CST = "500", TributacaoFederal = Convert.ToDecimal("9,45"), TributacaoEstadual = Convert.ToDecimal("2,76"), SituacaoTributaria = "0" },
        //    new Item { Id = 4, Ativo = true, Descricao = "ESTACIONAMENTO", DepartamentoId = 10, DescricaoPainel = "ESTACIONAMENTO", GTIN = "", CodigoBarras = "", ValorUnitario = (decimal)20, NCM = "", Iss = 0, Cest = "", CFOP = "0", CST = "0", TributacaoFederal = (decimal)9.45, TributacaoEstadual = (decimal)2.76, SituacaoTributaria = "0" },
        //    new Item { Id = 5, Ativo = true, Descricao = "ALMOCO ADULTO", DepartamentoId = 11, DescricaoPainel = "ALMOCO ADULTO", GTIN = "", CodigoBarras = "", ValorUnitario = (decimal)20, NCM = "", Iss = 0, Cest = "", CFOP = "0", CST = "0", TributacaoFederal = (decimal)9.45, TributacaoEstadual = (decimal)2.76, SituacaoTributaria = "0" },
        //    new Item { Id = 6, Ativo = true, Descricao = "ALMOCO CRIANCA", DepartamentoId = 11, DescricaoPainel = "ALMOCO CRIANCA", GTIN = "", CodigoBarras = "", ValorUnitario = (decimal)20, NCM = "", Iss = 0, Cest = "", CFOP = "0", CST = "0", TributacaoFederal = (decimal)9.45, TributacaoEstadual = (decimal)2.76, SituacaoTributaria = "0" },
        //    new Item { Id = 7, Ativo = true, Descricao = "ALMOCO SENIOR", DepartamentoId = 11, DescricaoPainel = "ALMOCO SENIOR", GTIN = "", CodigoBarras = "", ValorUnitario = (decimal)20, NCM = "", Iss = 0, Cest = "", CFOP = "0", CST = "0", TributacaoFederal = (decimal)9.45, TributacaoEstadual = (decimal)2.76, SituacaoTributaria = "0" },
        //    new Item { Id = 8, Ativo = true, Descricao = "CORTESIA ADICIONAL", DepartamentoId = 11, DescricaoPainel = "CORTESIA ADICIONAL", GTIN = "", CodigoBarras = "", ValorUnitario = (decimal)0, NCM = "", Iss = 0, Cest = "", CFOP = "0", CST = "0", TributacaoFederal = (decimal)9.45, TributacaoEstadual = (decimal)2.76, SituacaoTributaria = "0" },
        //    new Item { Id = 9, Ativo = true, Descricao = "CORTESIA", DepartamentoId = 11, DescricaoPainel = "CORTESIA", GTIN = "", CodigoBarras = "", ValorUnitario = (decimal)0, NCM = "", Iss = 0, Cest = "", CFOP = "0", CST = "0", TributacaoFederal = (decimal)9.45, TributacaoEstadual = (decimal)2.76, SituacaoTributaria = "0" }
        //    );
        //}
        //private static void DadosItemEmpresa(ModelBuilder builder)
        //{
        //    builder.Entity<ItemEmpresa>().HasData(
        //    new ItemEmpresa { Id = 1, Ativo = true, EmpresaId = 1, ItemId = 1, ImprimeCozinha = false },
        //    new ItemEmpresa { Id = 2, Ativo = true, EmpresaId = 1, ItemId = 2, ImprimeCozinha = false },
        //    new ItemEmpresa { Id = 3, Ativo = true, EmpresaId = 1, ItemId = 3, ImprimeCozinha = false }
        //    );
        //}
        ////private static void DadosPacoteHospedagemMensal(ModelBuilder builder)
        ////{
        ////    builder.Entity<PacoteMensal>().HasData(
        ////    new PacoteMensal { Id = 1, Ativo = true, MesVigente = DateTime.Now, Dias = "segunda|terca|quarta|quinta|domingo", ValorDiaria = 300, ValorAdicional = 100, ValorGrupo = 0 },
        ////    new PacoteMensal { Id = 1, Ativo = true, MesVigente = DateTime.Now, Dias = "sexta|sabado", ValorDiaria = 300, ValorAdicional = 100, ValorGrupo = 0 }
        ////    );
        ////}

        ////private static void DadosPacoteHospedagem(ModelBuilder builder)
        ////{
        ////    builder.Entity<Pacote>().HasData(
        ////                new Pacote { Id = 1, Ativo = true, Descricao = "Pacote Dia das Crianças", DataInicial = DateTime.Now, DataFinal = DateTime.Now QuantidadeDeAdultos = 2, QuantidadeDeCriancas = 2, EstadiaMinima = 2, ValorAdicional = 100, Observacao = "" }
        ////                );
        ////}



        ////private static void DadosCategoriaQuartos(ModelBuilder builder)
        ////{
        ////    builder.Entity<TipoQuarto>().HasData(
        ////    new TipoQuarto { Id = 1, Ativo = true, Descricao = "Apartamento Duplo", },
        ////    new TipoQuarto { Id = 2, Ativo = true, Descricao = "Apartamento Triplo", },
        ////    new TipoQuarto { Id = 3, Ativo = true, Descricao = "Apartamento Quadruplo", },
        ////    new TipoQuarto { Id = 4, Ativo = true, Descricao = "Apartamento Quintuplo", }
        ////     );
        ////}


        //private static void DadosUnidadeMedida(ModelBuilder builder)
        //{
        //    builder.Entity<UnidadeMedida>().HasData(
        //    new UnidadeMedida { Id = 1, Ativo = true, Descricao = "Unidades", DescricaoReduzida = "un", BaseConversao = "1" },
        //    new UnidadeMedida { Id = 2, Ativo = true, Descricao = "Metros", DescricaoReduzida = "m", BaseConversao = "1" },
        //    new UnidadeMedida { Id = 3, Ativo = true, Descricao = "Litros", DescricaoReduzida = "L", BaseConversao = "1" },
        //    new UnidadeMedida { Id = 4, Ativo = true, Descricao = "Gramas", DescricaoReduzida = "G", BaseConversao = "1" }
        //       );
        //}

        //private static void DadosPontosMetas(ModelBuilder builder)
        //{
        //    builder.Entity<PontosMeta>().HasData(
        //      new PontosMeta { Id = 1, Ano = "2021", ValorPonto = Convert.ToDecimal("2500,00"), EmpresaId = 1 },
        //      new PontosMeta { Id = 2, Ano = "2022", ValorPonto = Convert.ToDecimal("2500,00"), EmpresaId = 1 },
        //      new PontosMeta { Id = 3, Ano = "2023", ValorPonto = Convert.ToDecimal("3000,00"), EmpresaId = 1 },
        //      new PontosMeta { Id = 4, Ano = "2024", ValorPonto = Convert.ToDecimal("3000,00"), EmpresaId = 1 }
        //      );
        //}

        //private static void DadosMetasPorcentagem(ModelBuilder builder)
        //{
        //    builder.Entity<MetaPorcentagem>().HasData(
        //                    new MetaPorcentagem { Id = 1, Descricao = "Meta 01", Porcentagem = Convert.ToDecimal("00,3"), NumeroMeta = 1, EmpresaId = 1 },
        //                    new MetaPorcentagem { Id = 2, Descricao = "Meta 02", Porcentagem = Convert.ToDecimal("00,5"), NumeroMeta = 2, EmpresaId = 1 },
        //                    new MetaPorcentagem { Id = 3, Descricao = "Meta 03", Porcentagem = Convert.ToDecimal("1,0"), NumeroMeta = 3, EmpresaId = 1 },
        //                    new MetaPorcentagem { Id = 4, Descricao = "Meta 04", Porcentagem = Convert.ToDecimal("01,5"), NumeroMeta = 4, EmpresaId = 1 }
        //                    );
        //}

        //private static void DadosValorExcursao(ModelBuilder builder)
        //{
        //    //builder.Entity<PassaportePacote>().HasData(
        //    //                new PassaportePacote { Id = 1, Dias = "|1|2|3", Descricao = "MARCO 2021 MEIO SEMANA", DataInicio = Convert.ToDateTime("2021-06-01"), DataFim = Convert.ToDateTime("2021-06-30"), TipoPessoa = TipoPessoaPark.Adulto, TipoReserva = TipoReserva.Excursao, TipoVenda = TipoVendaPark.Park,  ValorExterno = 25, ValorInterno = 30, ValorPos = 40, ValorSite = 45 },
        //    //                new PassaportePacote { Id = 2, Dias = "|1|2|3", Descricao = "MARCO 2021 MEIO SEMANA", DataInicio = Convert.ToDateTime("2021-06-01"), DataFim = Convert.ToDateTime("2021-06-30"), TipoPessoa = TipoPessoaPark.Crianca, TipoReserva = TipoReserva.Excursao, TipoVenda = TipoVendaPark.Park,  ValorExterno = 20, ValorInterno = 25, ValorPos = 35, ValorSite = 40 },
        //    //                new PassaportePacote { Id = 3, Dias = "|1|2|3", Descricao = "MARCO 2021 MEIO SEMANA", DataInicio = Convert.ToDateTime("2021-06-01"), DataFim = Convert.ToDateTime("2021-06-30"), TipoPessoa = TipoPessoaPark.Senior, TipoReserva = TipoReserva.Excursao, TipoVenda = TipoVendaPark.Park,  ValorExterno = 15, ValorInterno = 20, ValorPos = 30, ValorSite = 10 },
        //    //                new PassaportePacote { Id = 4, Dias = "4|5", Descricao = "MARCO 2021 MEIO SEMANA", DataInicio = Convert.ToDateTime("2021-06-01"), DataFim = Convert.ToDateTime("2021-06-30"), TipoPessoa = TipoPessoaPark.Adulto, TipoReserva = TipoReserva.Excursao, TipoVenda = TipoVendaPark.Park,  ValorExterno = 25, ValorInterno = 30, ValorPos = 40, ValorSite = 45 },
        //    //                new PassaportePacote { Id = 5, Dias = "4|5", Descricao = "MARCO 2021 MEIO SEMANA", DataInicio = Convert.ToDateTime("2021-06-01"), DataFim = Convert.ToDateTime("2021-06-30"), TipoPessoa = TipoPessoaPark.Crianca, TipoReserva = TipoReserva.Excursao, TipoVenda = TipoVendaPark.Park,  ValorExterno = 20, ValorInterno = 25, ValorPos = 35, ValorSite = 40 },
        //    //                new PassaportePacote { Id = 6, Dias = "4|5", Descricao = "MARCO 2021 MEIO SEMANA", DataInicio = Convert.ToDateTime("2021-06-01"), DataFim = Convert.ToDateTime("2021-06-30"), TipoPessoa = TipoPessoaPark.Senior, TipoReserva = TipoReserva.Excursao, TipoVenda = TipoVendaPark.Park,  ValorExterno = 15, ValorInterno = 20, ValorPos = 30, ValorSite = 10 },
        //    //                new PassaportePacote { Id = 7, Dias = "0|6|7", Descricao = "MARCO 2021 FIM SEMANA", DataInicio = Convert.ToDateTime("2021-06-01"), DataFim = Convert.ToDateTime("2021-06-30"), TipoPessoa = TipoPessoaPark.Adulto, TipoReserva = TipoReserva.Excursao, TipoVenda = TipoVendaPark.Park,  ValorExterno = 25, ValorInterno = 30, ValorPos = 40, ValorSite = 45 },
        //    //                new PassaportePacote { Id = 8, Dias = "0|6|7", Descricao = "MARCO 2021 FIM SEMANA", DataInicio = Convert.ToDateTime("2021-06-01"), DataFim = Convert.ToDateTime("2021-06-30"), TipoPessoa = TipoPessoaPark.Crianca, TipoReserva = TipoReserva.Excursao, TipoVenda = TipoVendaPark.Park,  ValorExterno = 20, ValorInterno = 25, ValorPos = 35, ValorSite = 40 },
        //    //                new PassaportePacote { Id = 9, Dias = "0|6|7", Descricao = "MARCO 2021 FIM SEMANA", DataInicio = Convert.ToDateTime("2021-06-01"), DataFim = Convert.ToDateTime("2021-06-30"), TipoPessoa = TipoPessoaPark.Senior, TipoReserva = TipoReserva.Excursao, TipoVenda = TipoVendaPark.Park,  ValorExterno = 15, ValorInterno = 20, ValorPos = 30, ValorSite = 10 },
        //    //                new PassaportePacote { Id = 10, Dias = "0|1|2|3|4|5|6|7", Descricao = "CORTESIA ADICIONAL", DataInicio = Convert.ToDateTime("2021-06-01"), DataFim = Convert.ToDateTime("3000-01-01"), TipoPessoa = TipoPessoaPark.CortesiaAdicional, TipoReserva = TipoReserva.Excursao, TipoVenda = TipoVendaPark.Park,  ValorExterno = 0, ValorInterno = 0, ValorPos = 0, ValorSite = 0 },
        //    //                new PassaportePacote { Id = 11, Dias = "0|1|2|3|4|5|6|7", Descricao = "CORTESIA", DataInicio = Convert.ToDateTime("2021-06-01"), DataFim = Convert.ToDateTime("3000-01-01"), TipoPessoa = TipoPessoaPark.Cortesia, TipoReserva = TipoReserva.Excursao, TipoVenda = TipoVendaPark.Park,  ValorExterno = 0, ValorInterno = 0, ValorPos = 0, ValorSite = 0 }
        //    //                );
        //}

        ////private static void DadosAutomacao(ModelBuilder builder)
        ////{
        ////    builder.Entity<AutomacaoLocalizacao>().HasData(
        ////        new AutomacaoLocalizacao { Id = 1, Descricao = "1-60", ArmarioIni = 1, ArmarioFim = 60, IP = "192.168.8.8", IpServidor = "192.168.8.8", Bloco = "A1", TipoAutomacao = TipoAutomacao.Armario, Ativo = true }
        ////        );
        ////}





        ////private static void DadosArmario(ModelBuilder builder)
        ////{
        ////    builder.Entity<Armario>().HasData(
        ////         new Armario { Id = 1, Ativo = true, Numero = 1, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 2, Ativo = true, Numero = 2, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 3, Ativo = true, Numero = 3, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 4, Ativo = true, Numero = 4, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 5, Ativo = true, Numero = 5, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 6, Ativo = true, Numero = 6, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 7, Ativo = true, Numero = 7, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 8, Ativo = true, Numero = 8, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 9, Ativo = true, Numero = 9, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 10, Ativo = true, Numero = 10, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 11, Ativo = true, Numero = 11, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 12, Ativo = true, Numero = 12, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 13, Ativo = true, Numero = 13, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 14, Ativo = true, Numero = 14, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 15, Ativo = true, Numero = 15, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 16, Ativo = true, Numero = 16, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 17, Ativo = true, Numero = 17, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 18, Ativo = true, Numero = 18, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 19, Ativo = true, Numero = 19, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 20, Ativo = true, Numero = 20, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 21, Ativo = true, Numero = 21, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 22, Ativo = true, Numero = 22, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 23, Ativo = true, Numero = 23, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 24, Ativo = true, Numero = 24, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 25, Ativo = true, Numero = 25, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 26, Ativo = true, Numero = 26, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 27, Ativo = true, Numero = 27, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 28, Ativo = true, Numero = 28, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 29, Ativo = true, Numero = 29, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 30, Ativo = true, Numero = 30, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 31, Ativo = true, Numero = 31, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 32, Ativo = true, Numero = 32, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 33, Ativo = true, Numero = 33, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 34, Ativo = true, Numero = 34, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 35, Ativo = true, Numero = 35, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 36, Ativo = true, Numero = 36, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 37, Ativo = true, Numero = 37, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 38, Ativo = true, Numero = 38, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 39, Ativo = true, Numero = 39, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 40, Ativo = true, Numero = 40, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 41, Ativo = true, Numero = 41, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 42, Ativo = true, Numero = 42, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 43, Ativo = true, Numero = 43, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 44, Ativo = true, Numero = 44, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 45, Ativo = true, Numero = 45, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 46, Ativo = true, Numero = 46, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 47, Ativo = true, Numero = 47, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 48, Ativo = true, Numero = 48, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 49, Ativo = true, Numero = 49, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 50, Ativo = true, Numero = 50, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 51, Ativo = true, Numero = 51, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 52, Ativo = true, Numero = 52, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 53, Ativo = true, Numero = 53, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 54, Ativo = true, Numero = 54, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 55, Ativo = true, Numero = 55, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 56, Ativo = true, Numero = 56, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 57, Ativo = true, Numero = 57, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 58, Ativo = true, Numero = 58, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 59, Ativo = true, Numero = 59, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre },
        ////         new Armario { Id = 60, Ativo = true, Numero = 60, BlocoId = 1, Chave = true, CartaoConsumoId = null, SituacaoArmario = SituacaoArmario.Livre }
        ////       );
        ////}

        ////private static void DadosBlocoArmario(ModelBuilder builder)
        ////{
        ////    builder.Entity<Bloco>().HasData(
        ////                   new Bloco { Id = 1, Ativo = true, ArmarioInicio = 1, ArmarioFim = 60, Descricao = "Bloco 1", Valor = 10, Ip = "", Localizacao = "", Nome = "" }
        ////                   );
        ////}

        //private static void DadosEspacos(ModelBuilder builder)
        //{
        //    builder.Entity<Espaco>().HasData(
        //    new Espaco { Id = 1, Ativo = true, Numero = 1, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 2, Ativo = true, Numero = 2, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 3, Ativo = true, Numero = 3, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 4, Ativo = true, Numero = 4, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 5, Ativo = true, Numero = 5, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 6, Ativo = true, Numero = 6, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 7, Ativo = true, Numero = 7, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 8, Ativo = true, Numero = 8, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 9, Ativo = true, Numero = 9, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 10, Ativo = true, Numero = 10, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 11, Ativo = true, Numero = 11, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 12, Ativo = true, Numero = 12, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 13, Ativo = true, Numero = 13, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 14, Ativo = true, Numero = 14, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 15, Ativo = true, Numero = 15, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 16, Ativo = true, Numero = 16, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 17, Ativo = true, Numero = 17, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 18, Ativo = true, Numero = 18, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 19, Ativo = true, Numero = 19, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 20, Ativo = true, Numero = 20, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 21, Ativo = true, Numero = 21, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 22, Ativo = true, Numero = 22, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 23, Ativo = true, Numero = 23, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 24, Ativo = true, Numero = 24, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 25, Ativo = true, Numero = 25, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 26, Ativo = true, Numero = 26, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 27, Ativo = true, Numero = 27, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 28, Ativo = true, Numero = 28, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 29, Ativo = true, Numero = 29, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 30, Ativo = true, Numero = 30, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 31, Ativo = true, Numero = 31, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 32, Ativo = true, Numero = 32, TamanhoEspacoId = 3, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque },
        //    new Espaco { Id = 33, Ativo = true, Numero = 33, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 34, Ativo = true, Numero = 34, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 35, Ativo = true, Numero = 35, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 36, Ativo = true, Numero = 36, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 37, Ativo = true, Numero = 37, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 38, Ativo = true, Numero = 38, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 39, Ativo = true, Numero = 39, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 40, Ativo = true, Numero = 40, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 41, Ativo = true, Numero = 41, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 42, Ativo = true, Numero = 42, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 43, Ativo = true, Numero = 43, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 44, Ativo = true, Numero = 44, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 45, Ativo = true, Numero = 45, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 46, Ativo = true, Numero = 46, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 47, Ativo = true, Numero = 47, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 48, Ativo = true, Numero = 48, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 49, Ativo = true, Numero = 49, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 50, Ativo = true, Numero = 50, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 51, Ativo = true, Numero = 51, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 52, Ativo = true, Numero = 52, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 53, Ativo = true, Numero = 53, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 54, Ativo = true, Numero = 54, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 55, Ativo = true, Numero = 55, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 56, Ativo = true, Numero = 56, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 57, Ativo = true, Numero = 57, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 58, Ativo = true, Numero = 58, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 59, Ativo = true, Numero = 59, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, },
        //    new Espaco { Id = 60, Ativo = true, Numero = 60, TamanhoEspacoId = 1, Descricao = "Quioske", TipoEspaco = TipoEspaco.Quiosque, }

        //    );
        //}

        //private static void DadosTamanhoEspaco(ModelBuilder builder)
        //{
        //    builder.Entity<TamanhoEspaco>().HasData(
        //        new TamanhoEspaco { Id = 1, Ativo = true, Descricao = "Quiosque Pequeno", Preco = 100, PrecoFeriado = 100, PrecoFeriadoTitular = 100, PrecoTitular = 100 },
        //        new TamanhoEspaco { Id = 2, Ativo = true, Descricao = "Quiosque Grande", Preco = 100, PrecoFeriado = 100, PrecoFeriadoTitular = 100, PrecoTitular = 100 },
        //        new TamanhoEspaco { Id = 3, Ativo = true, Descricao = "Quiosque Eski", Preco = 100, PrecoFeriado = 100, PrecoFeriadoTitular = 100, PrecoTitular = 100 },
        //        new TamanhoEspaco { Id = 4, Ativo = true, Descricao = "Salão de Festa", Preco = 100, PrecoFeriado = 100, PrecoFeriadoTitular = 100, PrecoTitular = 100 }
        //        );
        //}

        //private static void DadosAgendaTelefonica(ModelBuilder builder)
        //{
        //    builder.Entity<AgendaTelefonica>().HasData(
        //                    new AgendaTelefonica { Id = 1, Nome = "Mysoftware", Telefone01 = "4430292727", Telefone02 = "4432675040", Celular = "44999736588", Obs = "" }
        //                    );
        //}

        //private static void DadosDepartamento(ModelBuilder builder)
        //{
        //    builder.Entity<Departamento>().HasData(
        //    new Departamento { Id = 1, Descricao = "Bebidas", Ativo = true, UtilizaHotel = true },
        //    new Departamento { Id = 2, Descricao = "Doces", Ativo = true, UtilizaHotel = false },
        //    new Departamento { Id = 3, Descricao = "Salgados", Ativo = true, UtilizaHotel = false },
        //    new Departamento { Id = 4, Descricao = "Sorvetes", Ativo = true, UtilizaHotel = false },
        //    new Departamento { Id = 5, Descricao = "Souvenir", Ativo = true, UtilizaHotel = false },
        //    new Departamento { Id = 6, Descricao = "Drinks", Ativo = true, UtilizaHotel = false },
        //    new Departamento { Id = 7, Descricao = "Massagem", Ativo = true, UtilizaHotel = false },
        //    new Departamento { Id = 8, Descricao = "Refeicao", Ativo = true, UtilizaHotel = false },
        //    new Departamento { Id = 9, Descricao = "Servicos", Ativo = true, UtilizaHotel = true },
        //    new Departamento { Id = 10, Descricao = "Estacionamento", Ativo = true, UtilizaHotel = false },
        //    new Departamento { Id = 11, Descricao = "Excursao", Ativo = true, UtilizaHotel = false }
        //    );
        //}

        //private static void DadosClaimsUsuariosPadroes(ModelBuilder builder)
        //{
        //    builder.Entity<IdentityUserClaim<int>>()
        //    .HasData(
        //    new IdentityUserClaim<int> { Id = 1, UserId = 1, ClaimType = "Empresa", ClaimValue = "Incluir, Editar, Excluir," },
        //    new IdentityUserClaim<int> { Id = 2, UserId = 1, ClaimType = "Usuario", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 3, UserId = 1, ClaimType = "Papeis", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 4, UserId = 1, ClaimType = "PessoaFisica", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 5, UserId = 1, ClaimType = "PessoaJuridica", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 6, UserId = 1, ClaimType = "Setor", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 7, UserId = 1, ClaimType = "Unidade", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 8, UserId = 1, ClaimType = "Departamento", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 9, UserId = 1, ClaimType = "Item", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 10, UserId = 1, ClaimType = "ContaCorrente", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 11, UserId = 1, ClaimType = "Meta", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 12, UserId = 1, ClaimType = "ContaPoupanca", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 13, UserId = 1, ClaimType = "ConInvestimento", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 14, UserId = 1, ClaimType = "Caixinha", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 15, UserId = 1, ClaimType = "CartaCredito", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 16, UserId = 1, ClaimType = "CategoriaContas", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 17, UserId = 1, ClaimType = "CentroCusto", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 18, UserId = 1, ClaimType = "Banco", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int> { Id = 19, UserId = 1, ClaimType = "TamanhoEspaco", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int>
        //    {
        //        Id = 20,
        //        UserId = 1,
        //        ClaimType = "Armario",
        //        ClaimValue = "Incluir, Editar, Excluir,AlugarArmario," +
        //        "ColocarArmarioManutencao,LiberarUnicoArmario,LiberarTodosArmarios," +
        //        "LiberarTodosArmariosOcupado,TrocarArmario,DevolucaoArmario," +
        //        "EstornoArmario,EstornoArmarioLimiteExcedido"
        //    },

        //    new IdentityUserClaim<int> { Id = 21, UserId = 1, ClaimType = "ExcursaoValor", ClaimValue = "Incluir, Editar, Excluir" },
        //    new IdentityUserClaim<int>
        //    {
        //        Id = 22,
        //        UserId = 1,
        //        ClaimType = "Excursao",
        //        ClaimValue = "Incluir,Editar,Excluir,PagamentoExcursao," +
        //                     "ImprimirVoucher,BuscaVoucher,AdicionarExcursaoDiaAtual, EstornarPagamentoExcursao, " +
        //                     "EditarExcursaoVendedor, TrocarPassaporteExcursao,DescontoValorPassaporteExcursao,DescontoValorProdutoExcursao"
        //    },
        //    new IdentityUserClaim<int>
        //    {
        //        Id = 23,
        //        UserId = 1,
        //        ClaimType = "CargaRecarga",
        //        ClaimValue = "RealizarCargaRecarga, ReterCartao, TrocarCartao, DevolucaoCartaoPerdido, " +
        //                     "TrocarCartaoPerdido, DevolucaoCartaoConsumo, ConsultaExtrato, DevolucaoTotalCreditoCartaoConsumo"
        //    },
        //    new IdentityUserClaim<int>
        //    {
        //        Id = 24,
        //        UserId = 1,
        //        ClaimType = "Estacionamento",
        //        ClaimValue = "EstacionamentoCartaoConsumo, EstacionamentoSocio, EstacionamentoTef, EstacionamentoDinheiro, GerarTicketEstacionamento"
        //    },
        //    new IdentityUserClaim<int> { Id = 25, UserId = 1, ClaimType = "Passaporte", ClaimValue = "VendaPassaporte, VendaVoucherPassaporte, ImprimirPassaporte, DescontoValorPassaport,TrocarPassaporte" },
        //    new IdentityUserClaim<int> { Id = 26, UserId = 1, ClaimType = "Caixa", ClaimValue = "FecharCaixaDivergencia, RetiradaCaixa " },

        //    new IdentityUserClaim<int>
        //    {
        //        Id = 28,
        //        UserId = 1,
        //        ClaimType = "Bares",
        //        ClaimValue = "BuscaVoucherAlimentacao, BaixaVoucherAlimentacao, TransferirValorCartaoConsumo, " +
        //                     "EstonarProdutoCartaoConsumo, EstonarProdutoTef, VenderProdutos, " +
        //                     "ImprimirVendasDiarias, ImprimirProdutoEmpresas"
        //    },
        //    new IdentityUserClaim<int>
        //    {
        //        Id = 29,
        //        UserId = 1,
        //        ClaimType = "Espaco",
        //        ClaimValue = "PreReservarEspaco, ReservarEspaco, AlugarEspaco, TrocarEspaco," +
        //                     "TrocarTitularidadeEspaco, GerarPoliticaEspaco, GerarRecibo, GerarRequisicao," +
        //                     "AlterarValorEspaco, VisualizarEspacoCancelado, GerenciarCreditoDebitoEspaco, " +
        //                     "CancelaEspacoReservado, MostrarTodosEspacoCancelado, EstornarPagamentoEspaco," +
        //                     "AlterarTaxaTrocaEspaco, CancelaPropriaReserva"
        //    },
        //    new IdentityUserClaim<int>
        //    {
        //        Id = 30,
        //        UserId = 1,
        //        ClaimType = "NFCe",
        //        ClaimValue = "GerenciaNotaFiscal"
        //    },
        //    new IdentityUserClaim<int>
        //    {
        //        Id = 31,
        //        UserId = 1,
        //        ClaimType = "Portaria",
        //        ClaimValue = "GerenciaPortaria"
        //    },
        //    new IdentityUserClaim<int>
        //    {
        //        Id = 32,
        //        UserId = 1,
        //        ClaimType = "CadastroEspaco",
        //        ClaimValue = "Incluir, Editar, Excluir",                
        //    },
        //    new IdentityUserClaim<int>
        //    {
        //        Id = 33,
        //        UserId = 1,
        //        ClaimType = "Feriado",
        //        ClaimValue = "Incluir, Editar, Excluir"                
        //    },
        //    new IdentityUserClaim<int>
        //    {
        //        Id = 34,
        //        UserId = 1,
        //        ClaimType = "CadastroValorEspaco",
        //        ClaimValue = "Incluir, Editar, Excluir"                
        //    }

        //);
        //}


        //private static void DadosFuncao(ModelBuilder builder)
        //{
        //    builder.Entity<Funcao>().HasData(
        //           new Funcao { Id = 1, Nome = "Crud", Descricao = "Empresa", ModulosId = 1 },
        //           new Funcao { Id = 2, Nome = "Crud", Descricao = "Usuario", ModulosId = 1 },
        //           new Funcao { Id = 3, Nome = "Crud", Descricao = "Papeis", ModulosId = 1 },
        //           new Funcao { Id = 4, Nome = "Crud", Descricao = "PessoaFisica", ModulosId = 1 },
        //           new Funcao { Id = 5, Nome = "Crud", Descricao = "PessoaJuridica", ModulosId = 1 },
        //           new Funcao { Id = 6, Nome = "Crud", Descricao = "Setor", ModulosId = 1 },
        //           new Funcao { Id = 7, Nome = "Crud", Descricao = "Unidade", ModulosId = 1 },
        //           new Funcao { Id = 8, Nome = "Crud", Descricao = "Departamento", ModulosId = 1 },
        //           new Funcao { Id = 9, Nome = "Crud", Descricao = "Item", ModulosId = 1 },
        //           new Funcao { Id = 10, Nome = "Crud", Descricao = "ContaCorrente", ModulosId = 2 },
        //           new Funcao { Id = 11, Nome = "Crud", Descricao = "Meta", ModulosId = 1 },
        //           new Funcao { Id = 12, Nome = "Crud", Descricao = "ContaPoupanca", ModulosId = 2 },
        //           new Funcao { Id = 13, Nome = "Crud", Descricao = "ConInvestimento", ModulosId = 2 },
        //           new Funcao { Id = 14, Nome = "Crud", Descricao = "Caixinha", ModulosId = 2 },
        //           new Funcao { Id = 15, Nome = "Crud", Descricao = "CartaCredito", ModulosId = 2 },
        //           new Funcao { Id = 16, Nome = "Crud", Descricao = "CategoriaContas", ModulosId = 2 },
        //           new Funcao { Id = 17, Nome = "Crud", Descricao = "CentroCusto", ModulosId = 2 },
        //           new Funcao { Id = 18, Nome = "Crud", Descricao = "Banco", ModulosId = 2 },
        //           new Funcao { Id = 19, Nome = "Excursao", Descricao = "Excursao", ModulosId = 3 },
        //           new Funcao { Id = 20, Nome = "ExcursaoValor", Descricao = "ExcursaoValor", ModulosId = 3 },
        //           new Funcao { Id = 21, Nome = "Passaporte", Descricao = "Passaporte", ModulosId = 3 },
        //           new Funcao { Id = 22, Nome = "Armario", Descricao = "Armario", ModulosId = 3 },
        //           new Funcao { Id = 23, Nome = "CargaRecarga", Descricao = "CargaRecarga", ModulosId = 3 },
        //           new Funcao { Id = 24, Nome = "Estacionamento", Descricao = "Estacionamento", ModulosId = 3 },
        //           new Funcao { Id = 25, Nome = "Espaco", Descricao = "Espaco", ModulosId = 3 },
        //           new Funcao { Id = 26, Nome = "TamanhoEspaco", Descricao = "TamanhoEspaco", ModulosId = 3 },
        //           new Funcao { Id = 27, Nome = "Bares", Descricao = "Bares", ModulosId = 6 },
        //           new Funcao { Id = 28, Nome = "Caixa", Descricao = "Caixa", ModulosId = 3 },
        //           new Funcao { Id = 29, Nome = "NFCe", Descricao = "GerenciaNotaFiscal", ModulosId = 2 },
        //           new Funcao { Id = 30, Nome = "Portaria", Descricao = "GerenciaPortaria", ModulosId = 3 },
        //           new Funcao { Id = 31, Nome = "Espaco", Descricao = "Espaco", ModulosId = 3 },
        //           new Funcao { Id = 32, Nome = "CadastroEspaco", Descricao = "CadastroEspaco", ModulosId = 1 },
        //           new Funcao { Id = 33, Nome = "Feriado", Descricao = "Feriado", ModulosId = 1 },
        //           new Funcao { Id = 34, Nome = "CadastroValorEspaco", Descricao = "CadastroValorEspaco", ModulosId = 1 }
        //           );
        //}


        //private static void DadosFuncaoAcoes(ModelBuilder builder)
        //{
        //    builder.Entity<FuncaoAcoes>().HasData(
        //        new FuncaoAcoes { Id = 1, FuncaoId = 1, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Empresa" },
        //        new FuncaoAcoes { Id = 2, FuncaoId = 1, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Empresa" },
        //        new FuncaoAcoes { Id = 3, FuncaoId = 1, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Empresa" },
        //        new FuncaoAcoes { Id = 4, FuncaoId = 2, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Usuario" },
        //        new FuncaoAcoes { Id = 5, FuncaoId = 2, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Usuario" },
        //        new FuncaoAcoes { Id = 6, FuncaoId = 2, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Usuario" },
        //        new FuncaoAcoes { Id = 7, FuncaoId = 3, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Papeis" },
        //        new FuncaoAcoes { Id = 8, FuncaoId = 3, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Papeis" },
        //        new FuncaoAcoes { Id = 9, FuncaoId = 3, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Papeis" },
        //        new FuncaoAcoes { Id = 10, FuncaoId = 4, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "PessoaFisica" },
        //        new FuncaoAcoes { Id = 11, FuncaoId = 4, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "PessoaFisica" },
        //        new FuncaoAcoes { Id = 12, FuncaoId = 4, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "PessoaFisica" },
        //        new FuncaoAcoes { Id = 13, FuncaoId = 5, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "PessoaJuridica" },
        //        new FuncaoAcoes { Id = 14, FuncaoId = 5, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "PessoaJuridica" },
        //        new FuncaoAcoes { Id = 15, FuncaoId = 5, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "PessoaJuridica" },
        //        new FuncaoAcoes { Id = 16, FuncaoId = 6, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Setor" },
        //        new FuncaoAcoes { Id = 17, FuncaoId = 6, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Setor" },
        //        new FuncaoAcoes { Id = 18, FuncaoId = 6, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Setor" },
        //        new FuncaoAcoes { Id = 19, FuncaoId = 7, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Unidade" },
        //        new FuncaoAcoes { Id = 20, FuncaoId = 7, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Unidade" },
        //        new FuncaoAcoes { Id = 21, FuncaoId = 7, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Unidade" },
        //        new FuncaoAcoes { Id = 22, FuncaoId = 8, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Departamento" },
        //        new FuncaoAcoes { Id = 23, FuncaoId = 8, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Departamento" },
        //        new FuncaoAcoes { Id = 24, FuncaoId = 8, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Departamento" },
        //        new FuncaoAcoes { Id = 25, FuncaoId = 9, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Item" },
        //        new FuncaoAcoes { Id = 26, FuncaoId = 9, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Item" },
        //        new FuncaoAcoes { Id = 27, FuncaoId = 9, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Item" },
        //        new FuncaoAcoes { Id = 28, FuncaoId = 10, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "ContaCorrente" },
        //        new FuncaoAcoes { Id = 29, FuncaoId = 10, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "ContaCorrente" },
        //        new FuncaoAcoes { Id = 30, FuncaoId = 10, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "ContaCorrente" },
        //        new FuncaoAcoes { Id = 31, FuncaoId = 11, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Meta" },
        //        new FuncaoAcoes { Id = 32, FuncaoId = 11, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Meta" },
        //        new FuncaoAcoes { Id = 33, FuncaoId = 11, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Meta" },
        //        new FuncaoAcoes { Id = 34, FuncaoId = 12, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "ContaPoupanca" },
        //        new FuncaoAcoes { Id = 35, FuncaoId = 12, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "ContaPoupanca" },
        //        new FuncaoAcoes { Id = 36, FuncaoId = 12, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "ContaPoupanca" },
        //        new FuncaoAcoes { Id = 37, FuncaoId = 13, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "ConInvestimento" },
        //        new FuncaoAcoes { Id = 38, FuncaoId = 13, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "ConInvestimento" },
        //        new FuncaoAcoes { Id = 39, FuncaoId = 13, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "ConInvestimento" },
        //        new FuncaoAcoes { Id = 40, FuncaoId = 14, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Caixinha" },
        //        new FuncaoAcoes { Id = 41, FuncaoId = 14, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Caixinha" },
        //        new FuncaoAcoes { Id = 42, FuncaoId = 14, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Caixinha" },
        //        new FuncaoAcoes { Id = 43, FuncaoId = 15, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "CartaCredito" },
        //        new FuncaoAcoes { Id = 44, FuncaoId = 15, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "CartaCredito" },
        //        new FuncaoAcoes { Id = 45, FuncaoId = 15, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "CartaCredito" },
        //        new FuncaoAcoes { Id = 46, FuncaoId = 16, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "CategoriaContas" },
        //        new FuncaoAcoes { Id = 47, FuncaoId = 16, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "CategoriaContas" },
        //        new FuncaoAcoes { Id = 48, FuncaoId = 16, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "CategoriaContas" },
        //        new FuncaoAcoes { Id = 49, FuncaoId = 17, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "CentroCusto" },
        //        new FuncaoAcoes { Id = 50, FuncaoId = 17, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "CentroCusto" },
        //        new FuncaoAcoes { Id = 51, FuncaoId = 17, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "CentroCusto" },
        //        new FuncaoAcoes { Id = 52, FuncaoId = 18, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Banco" },
        //        new FuncaoAcoes { Id = 53, FuncaoId = 18, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Banco" },
        //        new FuncaoAcoes { Id = 54, FuncaoId = 18, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Banco" },
        //        new FuncaoAcoes { Id = 55, FuncaoId = 19, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 56, FuncaoId = 19, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 57, FuncaoId = 19, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 58, FuncaoId = 19, AcaoId = 5, AcaoNome = "PagamentoExcursao", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 59, FuncaoId = 19, AcaoId = 6, AcaoNome = "ImprimirVoucher", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 60, FuncaoId = 19, AcaoId = 7, AcaoNome = "BuscarVoucher", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 61, FuncaoId = 20, AcaoId = 1, AcaoNome = "Inserir", FuncaoNome = "ExcursaoValores" },
        //        new FuncaoAcoes { Id = 62, FuncaoId = 20, AcaoId = 2, AcaoNome = "Alterar", FuncaoNome = "ExcursaoValores" },
        //        new FuncaoAcoes { Id = 63, FuncaoId = 20, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "ExcursaoValores" },
        //        new FuncaoAcoes { Id = 64, FuncaoId = 21, AcaoId = 8, AcaoNome = "VendaPassaporte", FuncaoNome = "Passaporte" },
        //        new FuncaoAcoes { Id = 65, FuncaoId = 21, AcaoId = 9, AcaoNome = "ImprimirPassaporte", FuncaoNome = "Passaporte" },
        //        new FuncaoAcoes { Id = 66, FuncaoId = 22, AcaoId = 10, AcaoNome = "AlugarArmario", FuncaoNome = "Armario" },
        //        new FuncaoAcoes { Id = 67, FuncaoId = 22, AcaoId = 11, AcaoNome = "ColocarArmarioManutencao", FuncaoNome = "Armario" },
        //        new FuncaoAcoes { Id = 68, FuncaoId = 22, AcaoId = 12, AcaoNome = "LiberarUnicoArmario", FuncaoNome = "Armario" },
        //        new FuncaoAcoes { Id = 69, FuncaoId = 22, AcaoId = 13, AcaoNome = "LiberarTodosArmarios", FuncaoNome = "Armario" },
        //        new FuncaoAcoes { Id = 70, FuncaoId = 22, AcaoId = 14, AcaoNome = "LiberarTodosArmariosOcupado", FuncaoNome = "Armario" },
        //        new FuncaoAcoes { Id = 71, FuncaoId = 22, AcaoId = 15, AcaoNome = "TrocaArmario", FuncaoNome = "Armario" },
        //        new FuncaoAcoes { Id = 72, FuncaoId = 22, AcaoId = 16, AcaoNome = "DevolucaoArmario", FuncaoNome = "Armario" },
        //        new FuncaoAcoes { Id = 73, FuncaoId = 22, AcaoId = 17, AcaoNome = "EstornoArmario", FuncaoNome = "Armario" },
        //        new FuncaoAcoes { Id = 74, FuncaoId = 22, AcaoId = 18, AcaoNome = "EstornoArmarioLimiteExcedido", FuncaoNome = "Armario" },
        //        new FuncaoAcoes { Id = 75, FuncaoId = 23, AcaoId = 19, AcaoNome = "RealizarCargaRecarga", FuncaoNome = "CargaRecarga" },
        //        new FuncaoAcoes { Id = 76, FuncaoId = 23, AcaoId = 20, AcaoNome = "ReterCartao", FuncaoNome = "CargaRecarga" },
        //        new FuncaoAcoes { Id = 77, FuncaoId = 23, AcaoId = 21, AcaoNome = "TrocarCartao", FuncaoNome = "CargaRecarga" },
        //        new FuncaoAcoes { Id = 78, FuncaoId = 23, AcaoId = 22, AcaoNome = "DevolucaoCartaoPerdido", FuncaoNome = "CargaRecarga" },
        //        new FuncaoAcoes { Id = 79, FuncaoId = 23, AcaoId = 23, AcaoNome = "TrocaCartaoPerdido", FuncaoNome = "CargaRecarga" },
        //        new FuncaoAcoes { Id = 80, FuncaoId = 23, AcaoId = 24, AcaoNome = "DevolucaoCartaoConsumo", FuncaoNome = "CargaRecarga" },
        //        new FuncaoAcoes { Id = 81, FuncaoId = 23, AcaoId = 25, AcaoNome = "ConsultaExtrato", FuncaoNome = "CargaRecarga" },
        //        new FuncaoAcoes { Id = 82, FuncaoId = 24, AcaoId = 26, AcaoNome = "EstacionamentoCartaoConsumo", FuncaoNome = "Estacionamento" },
        //        new FuncaoAcoes { Id = 83, FuncaoId = 24, AcaoId = 27, AcaoNome = "EstacionamentoSocio", FuncaoNome = "Estacionamento" },
        //        new FuncaoAcoes { Id = 84, FuncaoId = 24, AcaoId = 28, AcaoNome = "EstacionamentoTef", FuncaoNome = "Estacionamento" },
        //        new FuncaoAcoes { Id = 85, FuncaoId = 24, AcaoId = 29, AcaoNome = "EstacionamentoDinheiro", FuncaoNome = "Estacionamento" },
        //        new FuncaoAcoes { Id = 86, FuncaoId = 24, AcaoId = 30, AcaoNome = "GerarTicketEstacionamento", FuncaoNome = "Estacionamento" },
        //        new FuncaoAcoes { Id = 87, FuncaoId = 25, AcaoId = 31, AcaoNome = "PreReservar", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 88, FuncaoId = 25, AcaoId = 32, AcaoNome = "ReservarEspaco", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 89, FuncaoId = 25, AcaoId = 33, AcaoNome = "AlugarEspaco", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 90, FuncaoId = 25, AcaoId = 34, AcaoNome = "TrocarEspaco", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 91, FuncaoId = 25, AcaoId = 35, AcaoNome = "TrocaTitularidadeEspaco", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 92, FuncaoId = 25, AcaoId = 36, AcaoNome = "GerarPoliticaEspaco", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 93, FuncaoId = 25, AcaoId = 37, AcaoNome = "GerarRecibo", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 94, FuncaoId = 25, AcaoId = 38, AcaoNome = "GerarRequisicaoEspaco", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 95, FuncaoId = 26, AcaoId = 1, AcaoNome = "Inserir", FuncaoNome = "TamanhoEspaco" },
        //        new FuncaoAcoes { Id = 96, FuncaoId = 26, AcaoId = 2, AcaoNome = "Alterar", FuncaoNome = "TamanhoEspaco" },
        //        new FuncaoAcoes { Id = 97, FuncaoId = 26, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "TamanhoEspaco" },
        //        new FuncaoAcoes { Id = 98, FuncaoId = 27, AcaoId = 39, AcaoNome = "BuscarVoucherAlimentacao", FuncaoNome = "Bares" },
        //        new FuncaoAcoes { Id = 99, FuncaoId = 27, AcaoId = 40, AcaoNome = "BaixarVoucherAlimentacao", FuncaoNome = "Bares" },
        //        new FuncaoAcoes { Id = 100, FuncaoId = 27, AcaoId = 41, AcaoNome = "TransferirValorCartaoConsumo", FuncaoNome = "Bares" },
        //        new FuncaoAcoes { Id = 101, FuncaoId = 27, AcaoId = 42, AcaoNome = "EstornarProdutoCartaoConsumo", FuncaoNome = "Bares" },
        //        new FuncaoAcoes { Id = 102, FuncaoId = 27, AcaoId = 43, AcaoNome = "EstornarProdutoTef", FuncaoNome = "Bares" },
        //        new FuncaoAcoes { Id = 103, FuncaoId = 27, AcaoId = 44, AcaoNome = "VenderProduto", FuncaoNome = "Bares" },
        //        new FuncaoAcoes { Id = 104, FuncaoId = 27, AcaoId = 45, AcaoNome = "ImprimirVendasDiariasEmpresa", FuncaoNome = "Bares" },
        //        new FuncaoAcoes { Id = 105, FuncaoId = 27, AcaoId = 46, AcaoNome = "ImprimirProdutoEmpresa", FuncaoNome = "Bares" },
        //        new FuncaoAcoes { Id = 106, FuncaoId = 28, AcaoId = 47, AcaoNome = "FecharCaixaDivergencia", FuncaoNome = "Caixa" },
        //        new FuncaoAcoes { Id = 107, FuncaoId = 21, AcaoId = 48, AcaoNome = "DescontoValorPassaporte", FuncaoNome = "Passaporte" },
        //        new FuncaoAcoes { Id = 108, FuncaoId = 25, AcaoId = 49, AcaoNome = "AlterarValorEspaco", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 109, FuncaoId = 25, AcaoId = 50, AcaoNome = "VisualizarEspacoCancelado", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 110, FuncaoId = 25, AcaoId = 51, AcaoNome = "GerenciarCreditoDebitoEspaco", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 111, FuncaoId = 25, AcaoId = 52, AcaoNome = "CancelaEspacoReservado", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 112, FuncaoId = 19, AcaoId = 53, AcaoNome = "AdicionarExcursaoDiaAtual", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 113, FuncaoId = 25, AcaoId = 54, AcaoNome = "MostrarTodosEspacoCancelado", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 114, FuncaoId = 19, AcaoId = 55, AcaoNome = "EstornarPagamentoExcursao", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 115, FuncaoId = 25, AcaoId = 56, AcaoNome = "EstornarPagamentoEspaco", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 116, FuncaoId = 19, AcaoId = 57, AcaoNome = "EditarExcursaoVendedor", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 117, FuncaoId = 29, AcaoId = 58, AcaoNome = "GerenciaNotaFiscal", FuncaoNome = "NFCe" },
        //        new FuncaoAcoes { Id = 118, FuncaoId = 30, AcaoId = 59, AcaoNome = "GerenciaPortaria", FuncaoNome = "Portaria" },
        //        new FuncaoAcoes { Id = 119, FuncaoId = 21, AcaoId = 60, AcaoNome = "TrocarPassaporte", FuncaoNome = "Passaporte" },
        //        new FuncaoAcoes { Id = 120, FuncaoId = 19, AcaoId = 61, AcaoNome = "TrocarPassaporteExcursao", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 121, FuncaoId = 28, AcaoId = 62, AcaoNome = "RetiradaCaixa", FuncaoNome = "Caixa" },
        //        new FuncaoAcoes { Id = 122, FuncaoId = 19, AcaoId = 63, AcaoNome = "DescontoValorPassaporteExcursao", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 123, FuncaoId = 19, AcaoId = 64, AcaoNome = "DescontoValorProdutoExcursao", FuncaoNome = "Excursao" },
        //        new FuncaoAcoes { Id = 124, FuncaoId = 21, AcaoId = 65, AcaoNome = "VendaVoucherPassaporte", FuncaoNome = "Passaporte" },
        //        new FuncaoAcoes { Id = 125, FuncaoId = 25, AcaoId = 66, AcaoNome = "AlterarTaxaTrocaEspaco", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 126, FuncaoId = 23, AcaoId = 67, AcaoNome = "DevolucaoTotalCreditoCartaoConsumo", FuncaoNome = "CargaRecarga" },
        //        new FuncaoAcoes { Id = 127, FuncaoId = 25, AcaoId = 69, AcaoNome = "CancelaPropriaReserva", FuncaoNome = "Espaco" },
        //        new FuncaoAcoes { Id = 128, FuncaoId = 32, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "CadastroEspaco" },
        //        new FuncaoAcoes { Id = 129, FuncaoId = 32, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "CadastroEspaco" },
        //        new FuncaoAcoes { Id = 130, FuncaoId = 32, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "CadastroEspaco" },

        //        new FuncaoAcoes { Id = 131, FuncaoId = 33, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Feriado" },
        //        new FuncaoAcoes { Id = 132, FuncaoId = 33, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Feriado" },
        //        new FuncaoAcoes { Id = 133, FuncaoId = 33, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Feriado" },

        //        new FuncaoAcoes { Id = 134, FuncaoId = 34, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "CadastroValorEspaco" },
        //        new FuncaoAcoes { Id = 135, FuncaoId = 34, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "CadastroValorEspaco" },
        //        new FuncaoAcoes { Id = 136, FuncaoId = 34, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "CadastroValorEspaco" }


        //     );
        //}

        //private static void DadosFuncaoAcoesPerfil(ModelBuilder builder)
        //{
        //    builder.Entity<FuncaoAcaoPerfil>().HasData(
        //           new FuncaoAcaoPerfil { Id = 1, PerfilId = 1, FuncaoId = 1, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Empresa" },
        //            new FuncaoAcaoPerfil { Id = 2, PerfilId = 1, FuncaoId = 1, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Empresa" },
        //            new FuncaoAcaoPerfil { Id = 3, PerfilId = 1, FuncaoId = 1, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Empresa" },
        //            new FuncaoAcaoPerfil { Id = 4, PerfilId = 1, FuncaoId = 2, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Usuario" },
        //            new FuncaoAcaoPerfil { Id = 5, PerfilId = 1, FuncaoId = 2, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Usuario" },
        //            new FuncaoAcaoPerfil { Id = 6, PerfilId = 1, FuncaoId = 2, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Usuario" },
        //            new FuncaoAcaoPerfil { Id = 7, PerfilId = 1, FuncaoId = 3, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Papeis" },
        //            new FuncaoAcaoPerfil { Id = 8, PerfilId = 1, FuncaoId = 3, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Papeis" },
        //            new FuncaoAcaoPerfil { Id = 9, PerfilId = 1, FuncaoId = 3, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Papeis" },
        //            new FuncaoAcaoPerfil { Id = 10, PerfilId = 1, FuncaoId = 4, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "PessoaFisica" },
        //            new FuncaoAcaoPerfil { Id = 11, PerfilId = 1, FuncaoId = 4, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "PessoaFisica" },
        //            new FuncaoAcaoPerfil { Id = 12, PerfilId = 1, FuncaoId = 4, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "PessoaFisica" },
        //            new FuncaoAcaoPerfil { Id = 13, PerfilId = 1, FuncaoId = 5, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "PessoaJuridica" },
        //            new FuncaoAcaoPerfil { Id = 14, PerfilId = 1, FuncaoId = 5, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "PessoaJuridica" },
        //            new FuncaoAcaoPerfil { Id = 15, PerfilId = 1, FuncaoId = 5, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "PessoaJuridica" },
        //            new FuncaoAcaoPerfil { Id = 16, PerfilId = 1, FuncaoId = 6, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Setor" },
        //            new FuncaoAcaoPerfil { Id = 17, PerfilId = 1, FuncaoId = 6, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Setor" },
        //            new FuncaoAcaoPerfil { Id = 18, PerfilId = 1, FuncaoId = 6, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Setor" },
        //            new FuncaoAcaoPerfil { Id = 19, PerfilId = 1, FuncaoId = 7, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Unidade" },
        //            new FuncaoAcaoPerfil { Id = 20, PerfilId = 1, FuncaoId = 7, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Unidade" },
        //            new FuncaoAcaoPerfil { Id = 21, PerfilId = 1, FuncaoId = 7, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Unidade" },
        //            new FuncaoAcaoPerfil { Id = 22, PerfilId = 1, FuncaoId = 8, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Departamento" },
        //            new FuncaoAcaoPerfil { Id = 23, PerfilId = 1, FuncaoId = 8, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Departamento" },
        //            new FuncaoAcaoPerfil { Id = 24, PerfilId = 1, FuncaoId = 8, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Departamento" },
        //            new FuncaoAcaoPerfil { Id = 25, PerfilId = 1, FuncaoId = 9, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Item" },
        //            new FuncaoAcaoPerfil { Id = 26, PerfilId = 1, FuncaoId = 9, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Item" },
        //            new FuncaoAcaoPerfil { Id = 27, PerfilId = 1, FuncaoId = 9, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Item" },
        //            new FuncaoAcaoPerfil { Id = 28, PerfilId = 1, FuncaoId = 10, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "ContaCorrente" },
        //            new FuncaoAcaoPerfil { Id = 29, PerfilId = 1, FuncaoId = 10, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "ContaCorrente" },
        //            new FuncaoAcaoPerfil { Id = 30, PerfilId = 1, FuncaoId = 10, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "ContaCorrente" },
        //            new FuncaoAcaoPerfil { Id = 31, PerfilId = 1, FuncaoId = 11, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Meta" },
        //            new FuncaoAcaoPerfil { Id = 32, PerfilId = 1, FuncaoId = 11, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Meta" },
        //            new FuncaoAcaoPerfil { Id = 33, PerfilId = 1, FuncaoId = 11, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Meta" },
        //            new FuncaoAcaoPerfil { Id = 34, PerfilId = 1, FuncaoId = 12, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "ContaPoupanca" },
        //            new FuncaoAcaoPerfil { Id = 35, PerfilId = 1, FuncaoId = 12, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "ContaPoupanca" },
        //            new FuncaoAcaoPerfil { Id = 36, PerfilId = 1, FuncaoId = 12, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "ContaPoupanca" },
        //            new FuncaoAcaoPerfil { Id = 37, PerfilId = 1, FuncaoId = 13, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "ConInvestimento" },
        //            new FuncaoAcaoPerfil { Id = 38, PerfilId = 1, FuncaoId = 13, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "ConInvestimento" },
        //            new FuncaoAcaoPerfil { Id = 39, PerfilId = 1, FuncaoId = 13, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "ConInvestimento" },
        //            new FuncaoAcaoPerfil { Id = 40, PerfilId = 1, FuncaoId = 14, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Caixinha" },
        //            new FuncaoAcaoPerfil { Id = 41, PerfilId = 1, FuncaoId = 14, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Caixinha" },
        //            new FuncaoAcaoPerfil { Id = 42, PerfilId = 1, FuncaoId = 14, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Caixinha" },
        //            new FuncaoAcaoPerfil { Id = 43, PerfilId = 1, FuncaoId = 15, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "CartaCredito" },
        //            new FuncaoAcaoPerfil { Id = 44, PerfilId = 1, FuncaoId = 15, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "CartaCredito" },
        //            new FuncaoAcaoPerfil { Id = 45, PerfilId = 1, FuncaoId = 15, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "CartaCredito" },
        //            new FuncaoAcaoPerfil { Id = 46, PerfilId = 1, FuncaoId = 16, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "CategoriaContas" },
        //            new FuncaoAcaoPerfil { Id = 47, PerfilId = 1, FuncaoId = 16, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "CategoriaContas" },
        //            new FuncaoAcaoPerfil { Id = 48, PerfilId = 1, FuncaoId = 16, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "CategoriaContas" },
        //            new FuncaoAcaoPerfil { Id = 49, PerfilId = 1, FuncaoId = 17, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "CentroCusto" },
        //            new FuncaoAcaoPerfil { Id = 50, PerfilId = 1, FuncaoId = 17, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "CentroCusto" },
        //            new FuncaoAcaoPerfil { Id = 51, PerfilId = 1, FuncaoId = 17, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "CentroCusto" },
        //            new FuncaoAcaoPerfil { Id = 52, PerfilId = 1, FuncaoId = 18, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Banco" },
        //            new FuncaoAcaoPerfil { Id = 53, PerfilId = 1, FuncaoId = 18, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Banco" },
        //            new FuncaoAcaoPerfil { Id = 54, PerfilId = 1, FuncaoId = 18, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Banco" },
        //            new FuncaoAcaoPerfil { Id = 55, PerfilId = 1, FuncaoId = 19, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 56, PerfilId = 1, FuncaoId = 19, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 57, PerfilId = 1, FuncaoId = 19, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 58, PerfilId = 1, FuncaoId = 19, AcaoId = 5, AcaoNome = "PagamentoExcursao", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 59, PerfilId = 1, FuncaoId = 19, AcaoId = 6, AcaoNome = "ImprimirVoucher", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 60, PerfilId = 1, FuncaoId = 19, AcaoId = 7, AcaoNome = "BuscarVoucher", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 61, PerfilId = 1, FuncaoId = 20, AcaoId = 1, AcaoNome = "Inserir", FuncaoNome = "ExcursaoValores" },
        //            new FuncaoAcaoPerfil { Id = 62, PerfilId = 1, FuncaoId = 20, AcaoId = 2, AcaoNome = "Alterar", FuncaoNome = "ExcursaoValores" },
        //            new FuncaoAcaoPerfil { Id = 63, PerfilId = 1, FuncaoId = 20, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "ExcursaoValores" },
        //            new FuncaoAcaoPerfil { Id = 64, PerfilId = 1, FuncaoId = 21, AcaoId = 8, AcaoNome = "VendaPassaporte", FuncaoNome = "Passaporte" },
        //            new FuncaoAcaoPerfil { Id = 65, PerfilId = 1, FuncaoId = 21, AcaoId = 9, AcaoNome = "ImprimirPassaporte", FuncaoNome = "Passaporte" },
        //            new FuncaoAcaoPerfil { Id = 66, PerfilId = 1, FuncaoId = 22, AcaoId = 10, AcaoNome = "AlugarArmario", FuncaoNome = "Armario" },
        //            new FuncaoAcaoPerfil { Id = 67, PerfilId = 1, FuncaoId = 22, AcaoId = 11, AcaoNome = "ColocarArmarioManutencao", FuncaoNome = "Armario" },
        //            new FuncaoAcaoPerfil { Id = 68, PerfilId = 1, FuncaoId = 22, AcaoId = 12, AcaoNome = "LiberarUnicoArmario", FuncaoNome = "Armario" },
        //            new FuncaoAcaoPerfil { Id = 69, PerfilId = 1, FuncaoId = 22, AcaoId = 13, AcaoNome = "LiberarTodosArmarios", FuncaoNome = "Armario" },
        //            new FuncaoAcaoPerfil { Id = 70, PerfilId = 1, FuncaoId = 22, AcaoId = 14, AcaoNome = "LiberarTodosArmariosOcupado", FuncaoNome = "Armario" },
        //            new FuncaoAcaoPerfil { Id = 71, PerfilId = 1, FuncaoId = 22, AcaoId = 15, AcaoNome = "TrocaArmario", FuncaoNome = "Armario" },
        //            new FuncaoAcaoPerfil { Id = 72, PerfilId = 1, FuncaoId = 22, AcaoId = 16, AcaoNome = "DevolucaoArmario", FuncaoNome = "Armario" },
        //            new FuncaoAcaoPerfil { Id = 73, PerfilId = 1, FuncaoId = 22, AcaoId = 17, AcaoNome = "EstornoArmario", FuncaoNome = "Armario" },
        //            new FuncaoAcaoPerfil { Id = 74, PerfilId = 1, FuncaoId = 22, AcaoId = 18, AcaoNome = "EstornoArmarioLimiteExcedido", FuncaoNome = "Armario" },
        //            new FuncaoAcaoPerfil { Id = 75, PerfilId = 1, FuncaoId = 23, AcaoId = 19, AcaoNome = "RealizarCargaRecarga", FuncaoNome = "CargaRecarga" },
        //            new FuncaoAcaoPerfil { Id = 76, PerfilId = 1, FuncaoId = 23, AcaoId = 20, AcaoNome = "ReterCartao", FuncaoNome = "CargaRecarga" },
        //            new FuncaoAcaoPerfil { Id = 77, PerfilId = 1, FuncaoId = 23, AcaoId = 21, AcaoNome = "TrocarCartao", FuncaoNome = "CargaRecarga" },
        //            new FuncaoAcaoPerfil { Id = 78, PerfilId = 1, FuncaoId = 23, AcaoId = 22, AcaoNome = "DevolucaoCartaoPerdido", FuncaoNome = "CargaRecarga" },
        //            new FuncaoAcaoPerfil { Id = 79, PerfilId = 1, FuncaoId = 23, AcaoId = 23, AcaoNome = "TrocaCartaoPerdido", FuncaoNome = "CargaRecarga" },
        //            new FuncaoAcaoPerfil { Id = 80, PerfilId = 1, FuncaoId = 23, AcaoId = 24, AcaoNome = "DevolucaoCartaoConsumo", FuncaoNome = "CargaRecarga" },
        //            new FuncaoAcaoPerfil { Id = 81, PerfilId = 1, FuncaoId = 23, AcaoId = 25, AcaoNome = "ConsultaExtrato", FuncaoNome = "CargaRecarga" },
        //            new FuncaoAcaoPerfil { Id = 82, PerfilId = 1, FuncaoId = 24, AcaoId = 26, AcaoNome = "EstacionamentoCartaoConsumo", FuncaoNome = "Estacionamento" },
        //            new FuncaoAcaoPerfil { Id = 83, PerfilId = 1, FuncaoId = 24, AcaoId = 27, AcaoNome = "EstacionamentoSocio", FuncaoNome = "Estacionamento" },
        //            new FuncaoAcaoPerfil { Id = 84, PerfilId = 1, FuncaoId = 24, AcaoId = 28, AcaoNome = "EstacionamentoTef", FuncaoNome = "Estacionamento" },
        //            new FuncaoAcaoPerfil { Id = 85, PerfilId = 1, FuncaoId = 24, AcaoId = 29, AcaoNome = "EstacionamentoDinheiro", FuncaoNome = "Estacionamento" },
        //            new FuncaoAcaoPerfil { Id = 86, PerfilId = 1, FuncaoId = 24, AcaoId = 30, AcaoNome = "GerarTicketEstacionamento", FuncaoNome = "Estacionamento" },
        //            new FuncaoAcaoPerfil { Id = 87, PerfilId = 1, FuncaoId = 25, AcaoId = 31, AcaoNome = "PreReservar", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 88, PerfilId = 1, FuncaoId = 25, AcaoId = 32, AcaoNome = "ReservarEspaco", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 89, PerfilId = 1, FuncaoId = 25, AcaoId = 33, AcaoNome = "AlugarEspaco", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 90, PerfilId = 1, FuncaoId = 25, AcaoId = 34, AcaoNome = "TrocarEspaco", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 91, PerfilId = 1, FuncaoId = 25, AcaoId = 35, AcaoNome = "TrocaTitularidadeEspaco", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 92, PerfilId = 1, FuncaoId = 25, AcaoId = 36, AcaoNome = "GerarPoliticaEspaco", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 93, PerfilId = 1, FuncaoId = 25, AcaoId = 37, AcaoNome = "GerarRecibo", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 94, PerfilId = 1, FuncaoId = 25, AcaoId = 38, AcaoNome = "GerarRequisicaoEspaco", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 95, PerfilId = 1, FuncaoId = 26, AcaoId = 1, AcaoNome = "Inserir", FuncaoNome = "TamanhoEspaco" },
        //            new FuncaoAcaoPerfil { Id = 96, PerfilId = 1, FuncaoId = 26, AcaoId = 2, AcaoNome = "Alterar", FuncaoNome = "TamanhoEspaco" },
        //            new FuncaoAcaoPerfil { Id = 97, PerfilId = 1, FuncaoId = 26, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "TamanhoEspaco" },
        //            new FuncaoAcaoPerfil { Id = 98, PerfilId = 1, FuncaoId = 27, AcaoId = 39, AcaoNome = "BuscarVoucherAlimentacao", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 99, PerfilId = 1, FuncaoId = 27, AcaoId = 40, AcaoNome = "BaixarVoucherAlimentacao", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 100, PerfilId = 1, FuncaoId = 27, AcaoId = 41, AcaoNome = "TransferirValorCartaoConsumo", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 101, PerfilId = 1, FuncaoId = 27, AcaoId = 42, AcaoNome = "EstornarProdutoCartaoConsumo", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 102, PerfilId = 1, FuncaoId = 27, AcaoId = 43, AcaoNome = "EstornarProdutoTef", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 103, PerfilId = 1, FuncaoId = 27, AcaoId = 44, AcaoNome = "VenderProduto", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 104, PerfilId = 1, FuncaoId = 27, AcaoId = 45, AcaoNome = "ImprimirVendasDiariasEmpresa", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 105, PerfilId = 1, FuncaoId = 27, AcaoId = 46, AcaoNome = "ImprimirProdutoEmpresa", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 106, PerfilId = 1, FuncaoId = 28, AcaoId = 47, AcaoNome = "FecharCaixaDivergencia", FuncaoNome = "Caixa" },
        //            new FuncaoAcaoPerfil { Id = 107, PerfilId = 1, FuncaoId = 25, AcaoId = 49, AcaoNome = "AlterarValorEspaco", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 108, PerfilId = 1, FuncaoId = 25, AcaoId = 50, AcaoNome = "VisualizarEspacoCancelado", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 109, PerfilId = 1, FuncaoId = 25, AcaoId = 51, AcaoNome = "GerenciarCreditoDebitoEspaco", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 110, PerfilId = 1, FuncaoId = 25, AcaoId = 52, AcaoNome = "CancelaEspacoReservado", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 111, PerfilId = 1, FuncaoId = 19, AcaoId = 53, AcaoNome = "AdicionarExcursaoDiaAtual", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 112, PerfilId = 1, FuncaoId = 25, AcaoId = 54, AcaoNome = "MostrarTodosEspacoCancelado", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 98, PerfilId = 2, FuncaoId = 27, AcaoId = 39, AcaoNome = "BuscarVoucherAlimentacao", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 99, PerfilId = 2, FuncaoId = 27, AcaoId = 40, AcaoNome = "BaixarVoucherAlimentacao", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 100, PerfilId = 2, FuncaoId = 27, AcaoId = 41, AcaoNome = "TransferirValorCartaoConsumo", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 101, PerfilId = 2, FuncaoId = 27, AcaoId = 42, AcaoNome = "EstornarProdutoCartaoConsumo", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 102, PerfilId = 2, FuncaoId = 27, AcaoId = 43, AcaoNome = "EstornarProdutoTef", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 103, PerfilId = 2, FuncaoId = 27, AcaoId = 44, AcaoNome = "VenderProduto", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 104, PerfilId = 2, FuncaoId = 27, AcaoId = 45, AcaoNome = "ImprimirVendasDiariasEmpresa", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 105, PerfilId = 2, FuncaoId = 27, AcaoId = 46, AcaoNome = "ImprimirProdutoEmpresa", FuncaoNome = "Bares" },
        //            new FuncaoAcaoPerfil { Id = 106, PerfilId = 1, FuncaoId = 19, AcaoId = 55, AcaoNome = "EstornarPagamentoExcursao", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 107, PerfilId = 1, FuncaoId = 25, AcaoId = 56, AcaoNome = "EstornarPagamentoEspaco", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 108, PerfilId = 1, FuncaoId = 19, AcaoId = 57, AcaoNome = "EditarExcursaoVendedor", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 109, PerfilId = 1, FuncaoId = 29, AcaoId = 58, AcaoNome = "GerenciaNotaFiscal", FuncaoNome = "NFCe" },
        //            new FuncaoAcaoPerfil { Id = 110, PerfilId = 1, FuncaoId = 30, AcaoId = 59, AcaoNome = "GerenciaPortaria", FuncaoNome = "Portaria" },
        //            new FuncaoAcaoPerfil { Id = 111, PerfilId = 1, FuncaoId = 21, AcaoId = 60, AcaoNome = "TrocarPassaporte", FuncaoNome = "Passaporte" },
        //            new FuncaoAcaoPerfil { Id = 112, PerfilId = 1, FuncaoId = 19, AcaoId = 61, AcaoNome = "TrocarPassaporteExcursao", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 113, PerfilId = 1, FuncaoId = 28, AcaoId = 62, AcaoNome = "RetiradaCaixa", FuncaoNome = "Caixa" },
        //            new FuncaoAcaoPerfil { Id = 114, PerfilId = 1, FuncaoId = 19, AcaoId = 63, AcaoNome = "DescontoValorPassaporteExcursao", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 115, PerfilId = 1, FuncaoId = 19, AcaoId = 64, AcaoNome = "DescontoValorProdutoExcursao", FuncaoNome = "Excursao" },
        //            new FuncaoAcaoPerfil { Id = 116, PerfilId = 1, FuncaoId = 21, AcaoId = 65, AcaoNome = "VendaVoucherPassaporte", FuncaoNome = "Passaporte" },
        //            new FuncaoAcaoPerfil { Id = 117, PerfilId = 1, FuncaoId = 25, AcaoId = 66, AcaoNome = "AlterarTaxaTrocaEspaco", FuncaoNome = "Espaco" },
        //            new FuncaoAcaoPerfil { Id = 118, PerfilId = 1, FuncaoId = 23, AcaoId = 67, AcaoNome = "DevolucaoTotalCreditoCartaoConsumo", FuncaoNome = "CargaRecarga" },
        //            new FuncaoAcaoPerfil { Id = 119, PerfilId = 1, FuncaoId = 25, AcaoId = 69, AcaoNome = "CancelaPropriaReserva", FuncaoNome = "Espaco" },


        //            new FuncaoAcaoPerfil { Id = 120, PerfilId = 1, FuncaoId = 32, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "CadastroEspaco" },
        //            new FuncaoAcaoPerfil { Id = 121, PerfilId = 1, FuncaoId = 32, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "CadastroEspaco" },
        //            new FuncaoAcaoPerfil { Id = 122, PerfilId = 1, FuncaoId = 32, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "CadastroEspaco" },

        //            new FuncaoAcaoPerfil { Id = 123, PerfilId = 1, FuncaoId = 33, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "Feriado" },
        //            new FuncaoAcaoPerfil { Id = 124, PerfilId = 1, FuncaoId = 33, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "Feriado" },
        //            new FuncaoAcaoPerfil { Id = 125, PerfilId = 1, FuncaoId = 33, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "Feriado" },

        //            new FuncaoAcaoPerfil { Id = 126, PerfilId = 1, FuncaoId = 34, AcaoId = 1, AcaoNome = "Incluir", FuncaoNome = "CadastroValorEspaco" },
        //            new FuncaoAcaoPerfil { Id = 127, PerfilId = 1, FuncaoId = 34, AcaoId = 2, AcaoNome = "Editar", FuncaoNome = "CadastroValorEspaco" },
        //            new FuncaoAcaoPerfil { Id = 128, PerfilId = 1, FuncaoId = 34, AcaoId = 3, AcaoNome = "Excluir", FuncaoNome = "CadastroValorEspaco" }
        //    );
        //}
        //private static void DadosAcoes(ModelBuilder builder)
        //{
        //    builder.Entity<Acao>().HasData(
        //       new Acao { Id = 1, Nome = "Incluir", Descricao = "Incluir" },
        //       new Acao { Id = 2, Nome = "Editar", Descricao = "Editar" },
        //       new Acao { Id = 3, Nome = "Excluir", Descricao = "Excluir" },
        //       new Acao { Id = 4, Nome = "Conceder", Descricao = "Conceder" },
        //       new Acao { Id = 5, Nome = "PagamentoExcursao", Descricao = "PagamentoExcursao" },
        //       new Acao { Id = 6, Nome = "ImprimirVoucher", Descricao = "ImprimirVoucher" },
        //       new Acao { Id = 7, Nome = "BuscaVoucher", Descricao = "BuscaVoucher" },
        //       new Acao { Id = 8, Nome = "VendaPassaporte", Descricao = "VendaPassaporte" },
        //       new Acao { Id = 9, Nome = "ImprimirPassaporte", Descricao = "ImprimirPassaporte" },
        //       new Acao { Id = 10, Nome = "AlugarArmario", Descricao = "AlugarArmario" },
        //       new Acao { Id = 11, Nome = "ColocarArmarioManutencao", Descricao = "ColocarArmarioManutencao" },
        //       new Acao { Id = 12, Nome = "LiberarUnicoArmario", Descricao = "LiberarUnicoArmario" },
        //       new Acao { Id = 13, Nome = "LiberarTodosArmarios", Descricao = "LiberarTodosArmarios" },
        //       new Acao { Id = 14, Nome = "LiberarTodosArmariosOcupado", Descricao = "LiberarTodosArmariosOcupado" },
        //       new Acao { Id = 15, Nome = "TrocarArmario", Descricao = "TrocarArmario" },
        //       new Acao { Id = 16, Nome = "DevolucaoArmario", Descricao = "DevolucaoArmario" },
        //       new Acao { Id = 17, Nome = "EstornoArmario", Descricao = "EstornoArmario" },
        //       new Acao { Id = 18, Nome = "EstornoArmarioLimiteExcedido", Descricao = "EstornoArmarioLimiteExcedido" },
        //       new Acao { Id = 19, Nome = "RealizarCargaRecarga", Descricao = "RealizarCargaRecarga" },
        //       new Acao { Id = 20, Nome = "ReterCartao", Descricao = "ReterCartao" },
        //       new Acao { Id = 21, Nome = "TrocarCartao", Descricao = "TrocarCartao" },
        //       new Acao { Id = 22, Nome = "DevolucaoCartaoPerdido", Descricao = "DevolucaoCartaoPerdido" },
        //       new Acao { Id = 23, Nome = "TrocarCartaoPerdido", Descricao = "TrocarCartaoPerdido" },
        //       new Acao { Id = 24, Nome = "DevolucaoCartao", Descricao = "DevolucaoCartao" },
        //       new Acao { Id = 25, Nome = "ConsultaExtrato", Descricao = "ConsultaExtrato" },
        //       new Acao { Id = 26, Nome = "EstacionamentoCartaoConsumo", Descricao = "EstacionamentoCartaoConsumo" },
        //       new Acao { Id = 27, Nome = "EstacionamentoSocio", Descricao = "EstacionamentoSocio" },
        //       new Acao { Id = 28, Nome = "EstacionamentoTef", Descricao = "EstacionamentoTef" },
        //       new Acao { Id = 29, Nome = "EstacionamentoDinheiro", Descricao = "EstacionamentoDinheiro" },
        //       new Acao { Id = 30, Nome = "GerarTicketEstacionamento", Descricao = "GerarTicketEstacionamento" },
        //       new Acao { Id = 31, Nome = "PreReservarEspaco", Descricao = "PreReservarEspaco" },
        //       new Acao { Id = 32, Nome = "ReservarEspaco", Descricao = "ReservarEspaco" },
        //       new Acao { Id = 33, Nome = "AlugarEspaco", Descricao = "AlugarEspaco" },
        //       new Acao { Id = 34, Nome = "TrocarEspaco", Descricao = "TrocarEspaco" },
        //       new Acao { Id = 35, Nome = "TrocarTitularidadeEspaco", Descricao = "TrocarTitularidadeEspaco" },
        //       new Acao { Id = 36, Nome = "GerarPoliticaEspaco", Descricao = "GerarPoliticaEspaco" },
        //       new Acao { Id = 37, Nome = "GerarRecibo", Descricao = "GerarRecibo" },
        //       new Acao { Id = 38, Nome = "GerarRequisicao", Descricao = "GerarRequisicao" },
        //       new Acao { Id = 39, Nome = "BuscarVoucherAlimentacao", Descricao = "BuscarVoucherAlimentacao" },
        //       new Acao { Id = 40, Nome = "BaixaVoucherAlimentacao", Descricao = "BaixaVoucherAlimentacao" },
        //       new Acao { Id = 41, Nome = "TransferirValorCartaoConsumo", Descricao = "TransferirValorCartaoConsumo" },
        //       new Acao { Id = 42, Nome = "EstornarProdutoCartaoConsumo", Descricao = "EstornarProdutoCartaoConsumo" },
        //       new Acao { Id = 43, Nome = "EstornarProdutoTef", Descricao = "EstornarProdutoTef" },
        //       new Acao { Id = 44, Nome = "VenderProduto", Descricao = "VenderProduto" },
        //       new Acao { Id = 45, Nome = "ImprimirVendasDiariasEmpresa", Descricao = "ImprimirVendasDiariasEmpresa" },
        //       new Acao { Id = 46, Nome = "ImprimirProdutoEmpresa", Descricao = "ImprimirProdutoEmpresa" },
        //       new Acao { Id = 47, Nome = "FecharCaixaDivergencia", Descricao = "FecharCaixaDivergencia" },
        //       new Acao { Id = 48, Nome = "DescontoValorPassaporte", Descricao = "DescontoValorPassaporte" },
        //       new Acao { Id = 49, Nome = "AlterarValorEspaco", Descricao = "AlterarValorEspaco" },
        //       new Acao { Id = 50, Nome = "VisualizarEspacoCancelado", Descricao = "VisualizarEspacoCancelado" },
        //       new Acao { Id = 51, Nome = "GerenciarCreditoDebitoEspaco", Descricao = "GerenciarCreditoDebitoEspaco" },
        //       new Acao { Id = 52, Nome = "CancelaEspacoReservado", Descricao = "CancelaEspacoReservado" },
        //       new Acao { Id = 53, Nome = "AdicionarExcursaoDiaAtual", Descricao = "AdicionarExcursaoDiaAtual" },
        //       new Acao { Id = 54, Nome = "MostrarTodosEspacoCancelado", Descricao = "MostrarTodosEspacoCancelado" },
        //       new Acao { Id = 55, Nome = "EstornarPagamentoExcursao", Descricao = "EstornarPagamentoExcursao" },
        //       new Acao { Id = 56, Nome = "EstornarPagamentoEspaco", Descricao = "EstornarPagamentoEspaco" },
        //       new Acao { Id = 57, Nome = "EditarExcursaoVendedor", Descricao = "EditarExcursaoVendedor" },
        //       new Acao { Id = 58, Nome = "GerenciaNotaFiscal", Descricao = "GerenciaNotaFiscal" },
        //       new Acao { Id = 59, Nome = "GerenciaPortaria", Descricao = "GerenciaPortaria" },
        //       new Acao { Id = 60, Nome = "TrocarPassaporte", Descricao = "TrocarPassaporte" },
        //       new Acao { Id = 61, Nome = "TrocarPassaporteExcursao", Descricao = "TrocarPassaporteExcursao" },
        //       new Acao { Id = 62, Nome = "RetiradaCaixa", Descricao = "RetiradaCaixa" },
        //       new Acao { Id = 63, Nome = "DescontoValorPassaporteExcursao", Descricao = "DescontoValorPassaporteExcursao" },
        //       new Acao { Id = 64, Nome = "DescontoValorProdutoExcursao", Descricao = "DescontoValorProdutoExcursao" },
        //       new Acao { Id = 65, Nome = "VendaVoucherPassaporte", Descricao = "VendaVoucherPassaporte" },
        //       new Acao { Id = 66, Nome = "AlterarTaxaTrocaEspaco", Descricao = "AlterarTaxaTrocaEspaco" },
        //       new Acao { Id = 67, Nome = "DevolucaoTotalCreditoCartaoConsumo", Descricao = "DevolucaoTotalCreditoCartaoConsumo" },
        //       new Acao { Id = 69, Nome = "CancelaPropriaReserva", Descricao = "CancelaPropriaReserva" });
        //}
        //private static void DadosUsuarioModulos(ModelBuilder builder)
        //{
        //    builder.Entity<UsuarioModulos>().HasData(
        //        new UsuarioModulos { Id = 1, UsuarioId = 1, ModuloId = 1, Ativo = true },
        //        new UsuarioModulos { Id = 2, UsuarioId = 1, ModuloId = 2, Ativo = true },
        //        new UsuarioModulos { Id = 3, UsuarioId = 1, ModuloId = 3, Ativo = true },
        //        new UsuarioModulos { Id = 4, UsuarioId = 1, ModuloId = 4, Ativo = true },
        //        new UsuarioModulos { Id = 5, UsuarioId = 1, ModuloId = 5, Ativo = true },
        //        new UsuarioModulos { Id = 6, UsuarioId = 1, ModuloId = 6, Ativo = true }
        //     );
        //}

        //private static void DadosModulos(ModelBuilder builder)
        //{

        //    List<string> modulosCaminho = new List<string> {
        //    "base",
        //    "financeiro",
        //    "dayuser",
        //    "titulos",
        //    "hotel",
        //    "vendas"
        //    };

        //    string diretorioPrincipal = Directory.GetCurrentDirectory();
        //    byte[] buscar;
        //    byte[] img;
        //    int chave = 0;

        //    foreach (var item in modulosCaminho)
        //    {
        //        using (FileStream fs = new FileStream(diretorioPrincipal + @"\img\modulos\" + item + ".png", FileMode.Open, FileAccess.Read))
        //        {
        //            // cria um array de byte do arquivo
        //            byte[] bytes = System.IO.File.ReadAllBytes(diretorioPrincipal + @"\img\modulos\" + item + ".png");
        //            //le o bloco de bytes do stream
        //            fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
        //            buscar = bytes;
        //            using (MemoryStream mStream = new MemoryStream(buscar))
        //            {
        //                Image.FromStream(mStream);
        //                img = mStream.ToArray();
        //                chave += 1;
        //            }

        //            builder.Entity<Modulos>().HasData(
        //                new Modulos { Id = chave, Descricao = item, Image = img, Nome = item, Rota = "/" + item }
        //             );
        //        }
        //    }
        //}

        //private static void DadosCartao(ModelBuilder builder)
        //{

        //    List<string> cartaoCaminho = new List<string> {
        //    "american_express",
        //    "cooper",
        //    "diners_club",
        //    "elo",
        //    "maestro",
        //    "mastercard",
        //    "redeshop",
        //    "visa",
        //    "visa_electron"
        //    };


        //    string diretorioPrincipal = Directory.GetCurrentDirectory();
        //    byte[] buscar;
        //    byte[] img;
        //    int chave = 0;

        //    foreach (var item in cartaoCaminho)
        //    {
        //        using (FileStream fs = new FileStream(diretorioPrincipal + @"\img\cartao\" + item + ".png", FileMode.Open, FileAccess.Read))
        //        {
        //            // cria um array de byte do arquivo
        //            byte[] bytes = System.IO.File.ReadAllBytes(diretorioPrincipal + @"\img\cartao\" + item + ".png");
        //            //le o bloco de bytes do stream
        //            fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
        //            buscar = bytes;
        //            using (MemoryStream mStream = new MemoryStream(buscar))
        //            {
        //                Image.FromStream(mStream);
        //                img = mStream.ToArray();
        //                chave += 1;
        //            }

        //            builder.Entity<Bandeira>().HasData(
        //                new Bandeira { Id = chave, Descricao = item, Imagem = img, Ativo = true }
        //             );
        //        }
        //    }
        //}

        //private static void DadosConfiguracaoPark(ModelBuilder builder)
        //{


            
            





        //    builder.Entity<ConfiguracaoDayUse>().HasData(
        //                    new ConfiguracaoDayUse { Id = 1, Nome = "POS_PAGO", Descricao = "POS_PAGO", Valor = "AMBOS" },
        //                    new ConfiguracaoDayUse { Id = 2, Nome = "VENDA_PASSAPORTE_RFID", Descricao = "VENDA_PASSAPORTE_RFID", Valor = "SIM" },
        //                    new ConfiguracaoDayUse { Id = 3, Nome = "UTLIZA_PASSAPORTE", Descricao = "UTLIZA_PASSAPORTE", Valor = "SIM" },
        //                    new ConfiguracaoDayUse { Id = 4, Nome = "ARMARIO_AUTOMATIZADO", Descricao = "ARMARIO_AUTOMATIZADO", Valor = "SIM" },
        //                    new ConfiguracaoDayUse { Id = 5, Nome = "UTILIZA_ESTACIONAMENTO", Descricao = "UTILIZA_ESTACIONAMENTO", Valor = "SIM" },
        //                    new ConfiguracaoDayUse { Id = 6, Nome = "UTILIZA_IMPRESSAO_LOCAL", Descricao = "UTILIZA_IMPRESSAO_LOCAL", Valor = "SIM" },
        //                    new ConfiguracaoDayUse { Id = 7, Nome = "UTILIZA_ESPACO", Descricao = "UTILIZA_ESPACO", Valor = "NAO" },
        //                    new ConfiguracaoDayUse { Id = 8, Nome = "RECARGA_FEITA_QUALQUER_FORMAPAGAMENTO", Descricao = "RECARGA_FEITA_QUALQUER_FORMAPAGAMENTO", Valor = "SIM" },
        //                    new ConfiguracaoDayUse { Id = 9, Nome = "LISTAR_TODOS_PRODUTOS_ESTORNO", Descricao = "LISTAR_TODOS_PRODUTOS_ESTORNO", Valor = "SIM" },
        //                    new ConfiguracaoDayUse { Id = 10, Nome = "UTILIZA_MESA_BAR", Descricao = "UTILIZA_MESA_BAR", Valor = "SIM" },
        //                    new ConfiguracaoDayUse { Id = 11, Nome = "IMPRIMIR_CAIXA_DETALHADO", Descricao = "IMPRIMIR_CAIXA_DETALHADO", Valor = "SIM" },
        //                    new ConfiguracaoDayUse { Id = 12, Nome = "MOSTRAR_NUMERO_CARTAO_CONSUMO", Descricao = "MOSTRAR_NUMERO_CARTAO_CONSUMO", Valor = "SIM" },
        //                    new ConfiguracaoDayUse { Id = 13, Nome = "VALOR_PASSAPORTE_ADULTO", Descricao = "VALOR_PASSAPORTE_ADULTO", Valor = "85" },
        //                    new ConfiguracaoDayUse { Id = 14, Nome = "VALOR_PASSAPORTE_CRIANCA", Descricao = "VALOR_PASSAPORTE_CRIANCA", Valor = "70" },
        //                    new ConfiguracaoDayUse { Id = 15, Nome = "VALOR_MAXIMO_CARGA_RECARGA", Descricao = "VALOR_MAXIMO_CARGA_RECARGA", Valor = "100" },
        //                    new ConfiguracaoDayUse { Id = 16, Nome = "VALOR_CAUCAO", Descricao = "VALOR_CAUCAO", Valor = "5" },
        //                    new ConfiguracaoDayUse { Id = 17, Nome = "VALOR_ARMARIO", Descricao = "VALOR_ARMARIO", Valor = "20" },
        //                    new ConfiguracaoDayUse { Id = 18, Nome = "VALOR_CAUCAO_ARMARIO", Descricao = "VALOR_CAUCAO_ARMARIO", Valor = "10" },
        //                    new ConfiguracaoDayUse { Id = 19, Nome = "PORCENTAGEM_ACRESCIMO", Descricao = "PORCENTAGEM_ACRESCIMO", Valor = "10" },
        //                    new ConfiguracaoDayUse { Id = 20, Nome = "QUANTIDADE_EXCURSAO", Descricao = "QUANTIDADE_EXCURSAO", Valor = "15" },
        //                    new ConfiguracaoDayUse { Id = 21, Nome = "QUANTIDADE_CORTESIA_PASSAPORTE_EXCURSAO", Descricao = "QUANTIDADE_CORTESIA_PASSAPORTE_EXCURSAO", Valor = "20" },
        //                    new ConfiguracaoDayUse { Id = 22, Nome = "QUANTIDADE_CORTESIA_PRODUTO_EXCURSAO", Descricao = "QUANTIDADE_CORTESIA_PRODUTO_EXCURSAO", Valor = "20" },
        //                    new ConfiguracaoDayUse { Id = 23, Nome = "QUANTIDADE_PARCELAS_PAGAMENTO_EXCURSAO", Descricao = "QUANTIDADE_PARCELAS_PAGAMENTO_EXCURSAO", Valor = "4" },
        //                    new ConfiguracaoDayUse { Id = 24, Nome = "VALOR_DEVOLUCAO_PAG_CARTAO", Descricao = "VALOR_DEVOLUCAO_PAG_CARTAO", Valor = "100" },
        //                    new ConfiguracaoDayUse { Id = 25, Nome = "IMPRESSORA_PASSAPORTE", Descricao = "IMPRESSORA_PASSAPORTE", Valor = "TAG" },
        //                    new ConfiguracaoDayUse { Id = 26, Nome = "SITE_EMPRESA", Descricao = "SITE_EMPRESA", Valor = "www.odypark.com.br" },
        //                    new ConfiguracaoDayUse { Id = 27, Nome = "IMPRIMIR_VALE_REFEICAO", Descricao = "IMPRIMIR_VALE_REFEICAO", Valor = "SIM" },

        //                    new ConfiguracaoDayUse { Id = 28, Nome = "LOCAL_XML_NFCE_AUTORIZADO", Descricao = "LOCAL_XML_NFCE_AUTORIZADO", Valor = "\\NFCE_AUTORIZADO\\" },
        //                    new ConfiguracaoDayUse { Id = 29, Nome = "LOCAL_XML_NFCE_CONTINGENCIA", Descricao = "LOCAL_XML_NFCE_CONTINGENCIA", Valor = "\\NFCE_CONTINGENCIA\\" },
        //                    new ConfiguracaoDayUse { Id = 30, Nome = "LOCAL_XML_NFCE_INUTILIZADOS", Descricao = "LOCAL_XML_NFCE_INUTILIZADOS", Valor = "\\NFCE_INUTILIZADOS\\" },
        //                    new ConfiguracaoDayUse { Id = 31, Nome = "LOCAL_XML_NFCE_CANCELADOS", Descricao = "LOCAL_XML_NFCE_CANCELADOS", Valor = "\\NFCE_CANCELADOS\\" },
        //                    new ConfiguracaoDayUse { Id = 32, Nome = "LOCAL_ZIP_NOTAS", Descricao = "LOCAL_ZIP_NOTAS", Valor = "C:\\MySoftware\\NFCE_ZIP\\" },
        //                    new ConfiguracaoDayUse { Id = 33, Nome = "LOCAL_RAIZ_NOTAS", Descricao = "LOCAL_RAIZ_NOTAS", Valor = "C:\\MySoftware\\NFCE\\" },
        //                    new ConfiguracaoDayUse { Id = 34, Nome = "ESTACIONAMENTO_ITEM_ID", Descricao = "ESTACIONAMENTO_ITEM_ID", Valor = "177" },
        //                    new ConfiguracaoDayUse { Id = 35, Nome = "EMPRESA_ESTACIONAMENTO_ID", Descricao = "EMPRESA_ESTACIONAMENTO_ID", Valor = "21" },
        //                    new ConfiguracaoDayUse { Id = 36, Nome = "PORCENTAGEM_TROCA_ESPACO", Descricao = "PORCENTAGEM_TROCA_ESPACO", Valor = "30" },
        //                    new ConfiguracaoDayUse { Id = 37, Nome = "DESCONTO_PORCENTAGEM_CARTAO_TERCEIROS", Descricao = "DESCONTO_PORCENTAGEM_CARTAO_TERCEIROS", Valor = "3" },
        //                    new ConfiguracaoDayUse { Id = 38, Nome = "PORCENTAGEM_AGENCIA_EXCURSAO", Descricao = "PORCENTAGEM_AGENCIA_EXCURSAO", Valor = "10" },
        //                    new ConfiguracaoDayUse { Id = 39, Nome = "QUANTIDADE_DIAS_VALIDADE_PASSAPORTE", Descricao = "QUANTIDADE_DIAS_VALIDADE_PASSAPORTE", Valor = "90" },
        //                    new ConfiguracaoDayUse { Id = 40, Nome = "MOSTRAR_PRODUTO_VENDIDO_CARGA", Descricao = "MOSTRAR_PRODUTO_VENDIDO_CARGA", Valor = "NAO" }





        //                 );
        //}
    }
}