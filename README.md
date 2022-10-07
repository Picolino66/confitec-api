# Confitec-api
Back-End da aplicação Confitec.

## Requisitos
Esse projeto foi construído com as seguitnes versões:

DotNetCore: 3.1.4

EntityFramework: 3.1.3

AutoFac 5.1.4

Cors 2.2.0

Swagger 5.4.1

SqlServer 2019

## Instalação
Abra o projeto com Visual Studio, os packages serão instalados automaticamente.

Caso não seja instalado automaticamente, siga esse passo a passo -> https://learn.microsoft.com/pt-br/nuget/consume-packages/package-restore-troubleshooting

Instale o SqlServer 2019 e Management Studio

## Configuração
No arquivo appsettings.json configure sua string de conexão.

Server = servidor do banco de dados;

Database= banco de dados ;

User Id= usuario;

Password= senha;

Execute o script criar_tabela.sql no Sql Server para criar a tabela Usuarios