# Controle de contato MVC
### ⚠️ESSE PROJETO NÃO É DE MINHA AUTORIA, ESTOU APENAS USANDO COMO MATERIAL DE ESTUDO⚠️
Projeto de controle de contatos com inturito de estudar o padrão MVC e os metodos CRUD em ASP.NET 
Projeto esta sendo feito com base na playlist <a href ="https://www.youtube.com/playlist?list=PLJ0IKu7KZpCQKdwRbU7HfXW3raImmghWZ">Criando um Sistema do Zero - ASP.NET MVC</a> do canal <a href="https://www.youtube.com/c/ProgramadorTech">Programador Tech</a>

### Tecnologias usadas
- ASP.NET CORE MVC
- Entity Framework
- SQL server
- Bootstrap 5

## O que é MVC?
   A sigla MVC significa Model-View-Control, e um padrão de arquitetura muito ultilizado em projetos WEB, o intuito do MVC é dividir o projeto em 3 partes Models, views e controlers para que fique mais facil serparar a interface das regras de negocio.<br>
<br><b>Model</b>: Responsavel pela consulta e manipulação dos dados na aplicação.
<br><b>View</b>: Responsavel pela interface apresentada para o usuario.
<br><b>Controler</b>: Responsavel por intermediar a Model e a view , administrando ambos.
<br>(para uma explicação mais detalhada consulte o video <a href="https://www.youtube.com/watch?v=jyTNhT67ZyY">MVC // Dicionário do Programador</a>)

## CRUD
   Crud são as 4 operaçoes bacias ultilizadas para tratar os dados quando ultilizamos um banco de dados de uma aplicação as operaçoes são
<br><b>C</b> => Create (criar)
<br><b>R</b> => Read   (Ler)
<br><b>U</b> => Update (Atualizar)
<br><b>D</b> => Delete (Deletar)
Uma aqui uma breve e mais detalhada explicação sobre <a href="https://www.youtube.com/watch?v=8jcawcG2veY">CRUD</a> 

# Como rodar o projeto?

- ### 1° Baixar e intalar o SQL Server Management Studio
O SQL Server Management Studio serve para adiministrarmos nosso banco de dados fazendo açoes diretamente no banco caso necessario , tambem serve para termos nosso mini servidor para que possa mos rodo nosso projeo , achei um breve tutorial que ensina <a href ="https://ajuda.hiper.com.br/hc/pt-br/articles/360055727811-Como-instalar-o-SSMS-SQL-Server-Management-Studio-">baixar e intalar o SSMS</a>

- ### 2° Editar a String de conexão:
Apos ter beixado,intalado e conectado seu SQL server, devemos alterar a string que diz qual banco de dados o programa deve mexer, para isso vá ao arquivo "appsettings.json"
<br>![image](https://user-images.githubusercontent.com/81272272/182740663-1d60ffb7-3661-444e-803e-f6023e12397d.png)
<br>abrindo a pasta você verá uma string com o nome "DataBase"
<br>![image](https://user-images.githubusercontent.com/81272272/182742550-0a458362-77a5-486e-b259-ec4f846aa5c4.png)
<br>existem algumas formas para alterar a string de conexão caso você use
- Autentificação do windows:
<br>![image](https://user-images.githubusercontent.com/81272272/182742719-3f393e41-4892-4df5-bd83-243b860a880b.png)
<br>troque o nome que estiver apos localhost pelo nome do seu servidor que você pode ver no seu SSMS
<br>![image](https://user-images.githubusercontent.com/81272272/182742848-725aaddd-7df6-4150-ac2b-ef15da8dcfbf.png)
<br>e por fim ficará assim :
<br>![image](https://user-images.githubusercontent.com/81272272/182743003-b7ba01ee-cc2a-4e10-847c-d6a7e8085f9b.png)
<br>string: ``` "Server=localhost\\[NOME_DO_SEU_SERVIDOR];Database=DB_SistemaContatos;Trusted_Connection=True;" ```
<br>

- Usuario e senha: 
<br>no caso de se ultilizar usuario e senha devesse trocar essa string por está 
<br>string: ``` "Server=localhost\\[NOME_DO_SEU_SERVIDOR];Database=DB_SistemaContatos;Trusted_Connection=True;" ```


- ### 3° Estabelecer a conexão com o banco de dados
Agora o ultimo temos que conectar nossa aplicação ao banco ultiliamos o comando
<br> ``` Update-Database -Context BancoContext ``` 
![image](https://user-images.githubusercontent.com/81272272/182747973-a7b78fef-8511-41c6-92ec-0b0b6e1106f1.png)
 
## ⚠️!LEMBRE-SE DE MUDAR A CONNECTIONSTRING NO APPSETTINGS.JSON!⚠️

