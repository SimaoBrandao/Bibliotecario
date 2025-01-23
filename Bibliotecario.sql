create database Bibliotecario
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

use Bibliotecario;

create table biblioteca (
    codigoBiblioteca int not null primary key auto_increment,
    nomeBiblioteca varchar(100),
    nifBiblioteca varchar(50) null, 
    enderecoBiblioteca varchar(100) null, 
    telemovelBiblioteca varchar(50) null, 
    emailBiblioteca varchar(50) null, 
    logotipoBiblioteca varchar(255),    
    dataHoraBiblioteca datetime not null default NOW(),
    estadoBiblioteca int not null default 1    
)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

create table perfil (
    codigoPerfil int not null primary key auto_increment,
    nomePerfil varchar(50) not null, 
    dataHoraPerfil datetime not null default NOW(),
    estadoPerfil int not null default 1    
)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

insert into perfil (nomePerfil) values ('Administrador');
insert into perfil (nomePerfil) values ('Bibliotecário');

create table utilizador (
    codigoUtilizador int not null primary key auto_increment,
    nomeUtilizador varchar(100) not null,
    emailUtilizador varchar(50) unique not null,
    senhaUtilizador varchar(255) not null,
	codigoPerfilUtilizador int not null, foreign key(codigoPerfilUtilizador) references perfil(codigoPerfil),
    alterarSenhaAposLogin bool not null default false,
    dataHoraUtilizador datetime not null default NOW(),
    estadoUtilizador ENUM('Ativo','Inativo','Bloqueado') not null default 'Ativo'
)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

create table categoria (
    codigoCategoria int not null primary key auto_increment,
    nomeCategoria varchar(100) not null,
	cddCategoria varchar(10) not null,
    codigoUtilizadorCategoria int not null, foreign key(codigoUtilizadorCategoria) references utilizador(codigoUtilizador),
    dataHoraCategoria datetime not null default NOW(),
    estadoCategoria int not null default 1    
)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

create table formato (
    codigoFormato int not null primary key auto_increment,
    nomeFormato varchar(100) not null,
	codigoUtilizadorFormato int not null, foreign key(codigoUtilizadorFormato) references utilizador(codigoUtilizador),
    dataHoraFormato datetime not null default NOW(),
    estadoFormato int not null default 1    
)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

create table acervo (
    codigoAcervo int not null primary key auto_increment,
    cddAcervo varchar(50) not null,
    tituloAcervo varchar(100) not null,
	codigoCategoriaAcervo int not null, foreign key(codigoCategoriaAcervo) references Categoria(codigoCategoria),
    codigoFormatoAcervo int not null, foreign key(codigoFormatoAcervo) references Formato(codigoFormato),
    idiomaAcervo varchar(50) not null,
    autorAcervo varchar(100) not null,
	editoraAcervo varchar(100) not null,
    anoPublicacaoAcervo int, 
	ISBNAcervo varchar(50),
    localizacaoAcervo varchar(100),   
    quantidadeAcervo int not null default 1, 
    codigoIdentificadorAcervo varchar(100) not null,
    codigoUtilizadorAcervo int not null, foreign key(codigoUtilizadorAcervo) references utilizador(codigoUtilizador),
    dataHoraAcervo datetime not null default NOW(),
    estadoAcervo int not null default 1
)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

create table modalidade (
    codigoModalidade int not null primary key auto_increment,
    nomeModalidade varchar(100) not null,
    dataHoraModalidade datetime not null default NOW(),
    estadoModalidade int not null default 1
)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

insert into modalidade (nomeModalidade) values ('Estudante');
insert into modalidade (nomeModalidade) values ('Professor');

create table cliente (
    codigoCliente int not null primary key auto_increment,
    nomeCliente varchar(100) not null,
	generoCliente ENUM('Masculino', 'Femenino') not null,
    codigoModalidadeCliente int not null, foreign key(codigoModalidadeCliente) references Modalidade(codigoModalidade),
    numeroBilheteIdentidadeCliente varchar(50),
    enderecoCliente varchar(100), 
    telemovelCliente varchar(13),
    emailCliente varchar(50),    
	codigoUtilizadorCliente int not null, foreign key(codigoUtilizadorCliente) references utilizador(codigoUtilizador),
    dataHoraCliente datetime not null default NOW(),
    estadoCliente int not null default 1
)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

create table emprestimo (
    codigoEmprestimo int not null primary key auto_increment,
    codigoClienteEmprestimo int not null, foreign key(codigoClienteEmprestimo) references Cliente(codigoCliente),
    codigoAcervoEmprestimo int not null, foreign key(codigoAcervoEmprestimo) references Acervo(codigoAcervo),
    dataEmprestimo datetime not null,
    dataPrevistaDevolucaoEmprestimo datetime not null,
    dataRealDevolucaoEmprestimo datetime null,   
    codigoUtilizadorEmprestimo int not null, foreign key(codigoUtilizadorEmprestimo) references utilizador(codigoUtilizador),
    dataHoraEmprestimo datetime not null default NOW(),
    estadoEmprestimo ENUM('Emprestado','Devolvido','Inativo') not null default 'Emprestado'
)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

create table reserva (
    codigoReserva int not null primary key auto_increment,    
    codigoClienteReserva int not null, foreign key(codigoClienteReserva) references Cliente(codigoCliente),
    codigoAcervoReserva int not null, foreign key(codigoAcervoReserva) references Acervo(codigoAcervo),
    dataInicioReserva datetime not null,
    dataFimReserva datetime not null,
    codigoUtilizadorReserva int not null, foreign key(codigoUtilizadorReserva) references utilizador(codigoUtilizador),
    dataHoraReserva datetime not null default NOW(),
    estadoReserva int not null default 1    
)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;