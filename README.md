# Projeto de Teste UDP8

<p align="center">
  <img src="https://www.upd8.com.br/content/agency2/images/logo_upd8_stick2.png" alt="upd8 logo"/>
</p>
<p align="center">
<img src="https://miro.medium.com/max/720/1*7I6oONv2fGLQJcNEFA4QSw.png" alt="c# logo"/>
</p>

## Descrição do Projeto

Esse projeto é resultado do Teste Técnico fornecido pela UPD8. Atendendo os requisitos de criar um Cadastro de Cliente com as seguintes tecnologias:

1 - Aplicação Web com Asp.net MVC ( HTML,CSS,Java Script, JQuery, Ajax)

2 - Utilizar .NET e Linguagem C#

3 - Framework de Persistência:  Entity Framework

4 - Banco de Dados : Microsoft SQL SERVER

5 - Criar API Rest para o Cliente com as funcionalidades (inclusão, atualização e exclusão)

## Decisões Arquiteturais

No geral, segui toda a ideia de tecnologias passadas como parâmetro, com o passar do tempo, fui aplicando conceitos de CleanCode como padrão de design. Um ponto a se melhorar de fato, seria a aplicação do modelo de design DDD(Domain Driven Design), porém, devido ao pequeno escopo e prazo rápido de entrega, preferi aptar por seguir utilizando o modelo MVC clássico de design(algo que acaba poluindo um pouco o Controller da aplicação a longo prazo). Escolhi seguir o padrão de entidades, propriedades e métodos em **inglês**, pois acredito que agrega um certo valor organizacional ao projeto.

Outro ponto que é válido acrescentar como melhoria ao projeto, seria a melhoria do banco de dados, acrescentando as entidades Estado(State) e City(Cidade), criando uma dinâmica similar a essa(sem a tabela de país):
<p align="center">
  <img src="https://felipebbarbosa.files.wordpress.com/2013/04/combo_aninhado.png" alt="c# logo"/>
</p>
Dessa forma, seria possível iterar entre os estados dentro no <select> do formulário, e conforme a seleção, fornecer outro <select> com as cidades resultantes daquele Estado. 

## Preparando o ambiente

Nesse repositório contém o Script SQL para a construção do banco de dados com a entidade Cliente, também, no projeto, tem detalhes nas migrações que foram utilizadas a medida que o projeto se estendia para atualizar tabelas e suas propriedades.

O framework utilizado foi .Net 6, utilizando o Visual Studio como principal IDE de desenvolvimento de gerenciamento de projeto.

## Observações

- O código do ClientsController é o foco da parte REST, permitindo as funcionalidades de CRUD de forma simples e direta, utilizando o Entity Framework como orquestrador da persistência no banco.
- Existe um código javascript baseado em Regex, que foi consultado na internet com a intenção de permitir apenas a digitação de números no campo CPF, porém é possível "colar" letras e símbolos que não são validados pelo servidor(seria uma outra melhoria a ser trabalhada como validação de método de Cadastro e Edição).
- Utilizei uma biblioteca muito útil chamada [Datatable](https://datatables.net/) que facilitou bastante a ordenação, paginação e busca(em todos os campos) na view de Clientes. 

## Conclusões

O teste foi bem simples porém expandiu meus conhecimentos para o modelo ASP.NET MVC, o qual não tinha trabalhado(já tive eexperiência com MVC Laravel mas não com .NET), tomei algumas decisões de projeto que foram impulsionadas pelo tempo disponível para realização do teste e seu escopo, algumas delas desencadeiam uma série de melhorias com o objetivo de: Facilitar Escalabilidade, Código Limpo, Melhorar a Arquitetura de Dados. Algumas dessas melhoras já propostas aqui e outras podendo caber uma discussão e implementação.

No geral, estou bem feliz com o desempenho, acredito que fui bem sucedido na implementação do projeto e fico no aguardo de feedback sobre o código aqui escrito, bem como o avanço no processo seletivo :upd8.
