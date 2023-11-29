using Db.Domain.Entities.DayUse.CartaoConsumoPark;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Data.Mapping.DayUse
{
    public class CartaoConsumoClienteMap : IEntityTypeConfiguration<CartaoConsumoCliente>
    {
        public void Configure(EntityTypeBuilder<CartaoConsumoCliente> builder)
        {
            builder.ToTable("park_CartaoConsumoCliente");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CartaoConsumoId).HasColumnName("IdCartaoConsumo");
            builder.Property(c => c.PessoaId).HasColumnName("IdPessoa");
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
            builder.Property(c => c.ClientePagoId).HasColumnName("IdClientePago");
            builder.Property(c => c.PassaportePromocaoId).HasColumnName("IdPassaportePromocao");
            builder.Property(c => c.CaixaId).HasColumnName("IdCaixa");




        }
    }
}
