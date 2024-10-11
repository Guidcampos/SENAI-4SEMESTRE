--criação do banco

create database dev_db_tarde
go

use dev_db_tarde
go

--criação das tabelas
create table Professor(
ProfessorId int primary key identity,
Nome varchar(255), 
Email varchar(255) unique, 
Senha varchar(255)
)
go

create table Turma(
TurmaId int primary key identity,
Nome varchar(255), 
ProfessorId int foreign key references Professor(ProfessorId) 
)
go

create table Atividade(
AtividadeId int primary key identity,
Descricao varchar(255), 
TurmaId int foreign key references Turma(TurmaId) 
)
go

--inserção de dados na tabela

insert into Professor(Nome,Email,Senha) values 
('Rebeca', 'rebeca@email.com','admin123'),
('Gabriel', 'gabriel@email.com','admin123'),
('Campos', 'campos@email.com','admin123')
go

insert into Turma(Nome,ProfessorId) values 
('Dev 2025', 1),
('Redes', 2),
('Cyber', 3)
go

insert into Atividade(Descricao,TurmaId) values 
('Lógica de programação', 1),
('Infraestrutura de redes', 2),
('Pentest', 3)
go