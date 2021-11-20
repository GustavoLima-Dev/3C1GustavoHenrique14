create database chillibeans;
use chillibeans;

create table oculos(
id int unsigned auto_increment not null,
modelo varchar(130) not null,
preco double(9,2) not null,
primary key(id)
)engine = innodb;


create table usuario(
id int unsigned auto_increment not null,
nome varchar(100) not null,
endereco varchar (100) not null,
primary key(id)
)engine = innodb;