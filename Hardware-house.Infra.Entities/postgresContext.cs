using Microsoft.EntityFrameworkCore;

namespace Hardware_house.Infra.Entities
{
    public partial class postgresContext : DbContext
    {
        public postgresContext()
        {
        }

        public postgresContext(DbContextOptions<postgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carrinho> Carrinhos { get; set; }
        public virtual DbSet<Categoriaproduto> Categoriaprodutos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Fornecedore> Fornecedores { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Funcionariopossui> Funcionariopossuis { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Movimento> Movimentos { get; set; }
        public virtual DbSet<Pagamento> Pagamentos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Servico> Servicos { get; set; }
        public virtual DbSet<Tipofuncionario> Tipofuncionarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioTelefone> UsuarioTelefones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=database-rueslei.ccwg9x4j76qa.us-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User Id=professor;Password=professor;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Carrinho>(entity =>
            {
                entity.ToTable("carrinho", "mydb");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ClienteUsuarioCpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("cliente_usuario_cpf");

                entity.Property(e => e.Idmovimento).HasColumnName("idmovimento");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("status");

                entity.HasOne(d => d.ClienteUsuarioCpfNavigation)
                    .WithMany(p => p.Carrinhos)
                    .HasForeignKey(d => d.ClienteUsuarioCpf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_carrinho_cliente1");

                entity.HasOne(d => d.IdmovimentoNavigation)
                    .WithMany(p => p.Carrinhos)
                    .HasForeignKey(d => d.Idmovimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_carrinho_movimento1");
            });

            modelBuilder.Entity<Categoriaproduto>(entity =>
            {
                entity.ToTable("categoriaprodutos", "mydb");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DescricaoCategoria)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("descricao_categoria");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.UsuarioCpf)
                    .HasName("cliente_pkey");

                entity.ToTable("cliente", "mydb");

                entity.Property(e => e.UsuarioCpf)
                    .HasMaxLength(11)
                    .HasColumnName("usuario_cpf");

                entity.HasOne(d => d.UsuarioCpfNavigation)
                    .WithOne(p => p.Cliente)
                    .HasForeignKey<Cliente>(d => d.UsuarioCpf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cliente_usuario1");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.UsuarioCpf)
                    .HasName("endereco_pkey");

                entity.ToTable("endereco", "mydb");

                entity.Property(e => e.UsuarioCpf)
                    .HasMaxLength(11)
                    .HasColumnName("usuario_cpf");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("bairro");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("cep")
                    .IsFixedLength(true);

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("logradouro");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("municipio");

                entity.Property(e => e.Numero)
                    .HasMaxLength(5)
                    .HasColumnName("numero");

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("uf");

                entity.HasOne(d => d.UsuarioCpfNavigation)
                    .WithOne(p => p.Endereco)
                    .HasForeignKey<Endereco>(d => d.UsuarioCpf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_endereco_usuario1");
            });

            modelBuilder.Entity<Fornecedore>(entity =>
            {
                entity.ToTable("fornecedores", "mydb");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("cidade");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("cnpj")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("email");

                entity.Property(e => e.Nomeempresa)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("nomeempresa");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("telefone");

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("uf")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.Matricula)
                    .HasName("funcionario_pkey");

                entity.ToTable("funcionario", "mydb");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(8)
                    .HasColumnName("matricula");

                entity.Property(e => e.DataAdmissao)
                    .HasColumnType("date")
                    .HasColumnName("data_admissao");

                entity.Property(e => e.DataDemissao)
                    .HasColumnType("date")
                    .HasColumnName("data_demissao");

                entity.Property(e => e.Idtipo).HasColumnName("idtipo");

                entity.Property(e => e.Idtipofuncionario).HasColumnName("idtipofuncionario");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");

                entity.Property(e => e.UsuarioCpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("usuario_cpf");

                entity.HasOne(d => d.IdtipofuncionarioNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.Idtipofuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_funcionario_tipofuncionario1");

                entity.HasOne(d => d.UsuarioCpfNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.UsuarioCpf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_funcionario_usuario1");
            });

            modelBuilder.Entity<Funcionariopossui>(entity =>
            {
                entity.HasKey(e => e.FuncionarioMatricula)
                    .HasName("funcionariopossui_pkey");

                entity.ToTable("funcionariopossui", "mydb");

                entity.Property(e => e.FuncionarioMatricula)
                    .HasMaxLength(8)
                    .HasColumnName("funcionario_matricula");

                entity.Property(e => e.ItemProdutosId).HasColumnName("item_produtos_id");

                entity.HasOne(d => d.FuncionarioMatriculaNavigation)
                    .WithOne(p => p.Funcionariopossui)
                    .HasForeignKey<Funcionariopossui>(d => d.FuncionarioMatricula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_funcionariopossui_funcionario1");

                entity.HasOne(d => d.ItemProdutos)
                    .WithMany(p => p.Funcionariopossuis)
                    .HasForeignKey(d => d.ItemProdutosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_funcionariopossui_item1");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.ProdutosId)
                    .HasName("item_pkey");

                entity.ToTable("item", "mydb");

                entity.Property(e => e.ProdutosId)
                    .ValueGeneratedNever()
                    .HasColumnName("produtos_id");

                entity.Property(e => e.CarrinhoId).HasColumnName("carrinho_id");

                entity.Property(e => e.IdServicos).HasColumnName("id_servicos");

                entity.HasOne(d => d.Carrinho)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.CarrinhoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_item_carrinho1");

                entity.HasOne(d => d.IdServicosNavigation)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.IdServicos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_item_servicos1");

                entity.HasOne(d => d.Produtos)
                    .WithOne(p => p.Item)
                    .HasForeignKey<Item>(d => d.ProdutosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_item_produtos1");
            });

            modelBuilder.Entity<Movimento>(entity =>
            {
                entity.ToTable("movimento", "mydb");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("data");

                entity.Property(e => e.Idcarrinho).HasColumnName("idcarrinho");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.Property(e => e.StatusMovimento)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("status_movimento");
            });

            modelBuilder.Entity<Pagamento>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdCarrinho })
                    .HasName("pagamento_pkey");

                entity.ToTable("pagamento", "mydb");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCarrinho).HasColumnName("id_carrinho");

                entity.Property(e => e.DataPagamento)
                    .HasColumnType("date")
                    .HasColumnName("data_pagamento");

                entity.Property(e => e.TipoPagamento)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("tipo_pagamento");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.IdCarrinhoNavigation)
                    .WithMany(p => p.Pagamentos)
                    .HasForeignKey(d => d.IdCarrinho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pagamento_carrinho1");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("produtos", "mydb");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdFornecedores).HasColumnName("id_fornecedores");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("nome");

                entity.Property(e => e.Preco)
                    .HasPrecision(6, 2)
                    .HasColumnName("preco");

                entity.Property(e => e.QtdProduto).HasColumnName("qtd_produto");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_produtos_categoriaprodutos1");

                entity.HasOne(d => d.IdFornecedoresNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdFornecedores)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_produtos_fornecedores1");
            });

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.ToTable("servicos", "mydb");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("nome");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<Tipofuncionario>(entity =>
            {
                entity.HasKey(e => e.Idtipofuncionario)
                    .HasName("tipofuncionario_pkey");

                entity.ToTable("tipofuncionario", "mydb");

                entity.Property(e => e.Idtipofuncionario)
                    .ValueGeneratedNever()
                    .HasColumnName("idtipofuncionario");

                entity.Property(e => e.DescricaoTipoFuncionario)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("descricao_tipo_funcionario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Cpf)
                    .HasName("usuario_pkey");

                entity.ToTable("usuario", "mydb");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("cpf");

                entity.Property(e => e.DataNasc)
                    .HasColumnType("date")
                    .HasColumnName("data_nasc");

                entity.Property(e => e.PrimeiroNome)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("primeiro_nome");

                entity.Property(e => e.Sobrenome)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("sobrenome");
            });

            modelBuilder.Entity<UsuarioTelefone>(entity =>
            {
                entity.HasKey(e => new { e.Email, e.UsuarioCpf })
                    .HasName("usuario_telefone_pkey");

                entity.ToTable("usuario_telefone", "mydb");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .HasColumnName("email");

                entity.Property(e => e.UsuarioCpf)
                    .HasMaxLength(11)
                    .HasColumnName("usuario_cpf");

                entity.HasOne(d => d.UsuarioCpfNavigation)
                    .WithMany(p => p.UsuarioTelefones)
                    .HasForeignKey(d => d.UsuarioCpf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_telefone_usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
