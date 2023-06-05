# Arquitetura da Solução

<img src=https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/main/docs/img/iconografia_api.png/>

O atual projeto do **Banco de Alimentos** foi otimizado em uma arquitetura distribuída, onde seus componentes e recursos estão distribuídos em diversos nós ou dispositivos físicos separados. Essa abordagem permite uma melhor escalabilidade, desempenho e disponibilidade do sistema. 

### Benefícios de uma aplicação distribuída 

- Um dos benefícios da aplicação distribuída é a **Escalabilidade**, pois cada nó no sistema distribuído possui seu próprio poder de processamento, memória e recursos locais e portanto é possível lidar com uma maior carga de trabalho. 
- Desta maneira, o **Desempenho** também é um ponto forte, pois como as tarefas são distribuídas em vários nós o processamento e o tempo de resposta são melhores e muitas dessas tarefas podem ser executas ao mesmo tempo. 
- A **Confiabilidade** é outro ponto favorável, pois caso um nó falhe outros nós podem manter o sistema ativo.
- O **Compartilhamento de Recursos** também é destacado como um ponto positivo, já que permite a otimização no uso dos recursos e redução de despesas, além de permitir o acesso remoto de recursos de diferentes locais.


### Desvantagens de uma aplicação distribuída 	 

- Em contraste com uma aplicação centralizada, em que todas as operações são executadas em um único local, a aplicação distribuída apresenta algumas desvantagens como a **Complexidade**, pois a comunicação entre os nós, a consistência dos dados, o gerenciamento de falhas e os testes podem ser mais complexos comparado a uma aplicação centralizada.
- A **Segurança** é uma outra desvantagem pois, como a comunicação da aplicação distribuída ocorre entre diversos nós, a aplicação fica mais suscetível a ataques de segurança.  
- A **Concorrência** também é uma desvantagem que pode ocorre, já que as tarefas podem ser executadas simultaneamente e os nós concorrerem para acessar os dados compartilhados, gerando conflitos de acesso e inconsistência de dados.
- O **Gerenciamento de Falhas** também pode ser um problema nos sistemas distribuídos já que nós individuais podem falhar, requerendo mecanismos de detecção de falhas para manter a estabilidade e a disponibilidade do sistema.


## Modelagem e projeto arquitetural

O modelo arquitetural adotado no projeto foi o C4 Model, que visa descrever a estrutura arquitetural do software em diferentes níveis de abstração. Composto pelos níveis de contexto, contêiner e componentes, essa abordagem facilita a documentação, manutenção e evolução do software.

### Diagrama de Contexto

O primeiro nível é composto por uma abordagem mais ampla, onde os detalhes não são tão relevantes, e mostra o contexto em que o software está inserido, incluindo interações entre sistemas e usuários.

<img src=https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/main/docs/img/diagramacontexto.png/>
<hr/>

### Diagrama de Contêiner

A camada container expõe a arquitetura de forma simplificada, exibindo as tecnologias usadas e como a comunicação acontece. 
O diagrama de container contém um nível maior de detalhes e é útil para a(s) equipe(s) de desenvolvimento, arquitetos e devOps.

<img src=https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/main/docs/img/diagramaconteiner1.png/>
<hr/>

### Diagrama de Componentes

Esssa camada tem foco nas funcionalidades, apresentando suas resposablidades e tecnologias.
Nesse nível um componenete pode ser uma classe num sistema desenvolvido em POO.

<img src=https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/main/docs/img/diagramaComponente.png/>
<hr/>

## Tecnologias Utilizadas

As tecnologias utilizadas no desenvolvimento do software foram:

- Desenho de protótipo: **Adobe Xd**
- Desenvolvimento Front-end: **React Js**; 
- Desenvolvimento Back-end:**.NET 6.0**;
- Servidor do banco de dados: **SQL Server**; 
- Armazenamento de objetos: **Google Cloud**;
- Hospedagem em Nuvem: **Azzure**;



### Mecanismos Arquiteturais

|Ambiente | Design  | Implementação |
|------|-----------------------------------------|----|
|Persistência| Framework ORM | Entity Framework | 
|Persistência| Banco de dados relacional | SQLServer |
|Front end| Framework de desenvolvimento | React |
|Front end| Linguagem de programação | JavaScript |
|Front end| Framework de folhas de estilos | Bootstrap |
|Folhas de estilo| Linguagem de folha de estilos | CSS |
|Deploy| Plataforma de automatização de deploy | GitHub Actions |
|Back end| Linguagem de programação | C# |
|Back end| Framework de desenvolvimento | ASP.NET Core |
|Back end| Ambiente de execução | .NET |
|Back end| Serviço de execução de código | - |
|Back end| Gerenciador de tráfego | - |
|Autenticação| Padrão de formato para autenticação | JWT |
|Autenticação| Serviço de autenticação | OAuth |
|Integração| Formato de transporte de informações | JSON |
|Integração| Protocolo de comunicação | HTTP |
|Integração| Estilo de arquitetura | REST |
|Versionamento| Controle e armazenamento de código fonte | GitHub |
|Versionamento| Versionamento de código fonte | Git |
|Automação| Ferramenta de workflow | GitHub Actions |
|Build| Ferramenta de build de componentes do software | MSBuild |

## Hospedagem

A hospedagem do front-end e back-end foi feita na plataforma Azure. O back-end foi implantado por meio do GitHub Actions, utilizando Integração Contínua (CI/CD), juntamente com um serviço de gerenciamento de APIs. O banco de dados foi provisionado no Google Cloud SQL. 

### Front-end
Para a implantação do front-end, desenvolvido com o IDE Visual Studio Code e utilizando o framework/lib React, foi criado um diretório contendo a build do projeto. Essa build foi utilizada pela extensão do Azure no IDE para a implantação do serviço já criado no ambiente do Azure, utilizando um serviço de aplicativos.

No processo de implantação, foi adotado o modelo de publicação por código, sendo a pilha de runtime escolhida como Node.js 16, com localização definida como South Brazil.

A integração com o back-end é feita utilizando a biblioteca *Axios* em JavaScript, que permite realizar solicitações HTTP para o servidor

<img src=https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/main/docs/img/deploy_front.png/>
<hr/>

### Back-end

O processo de implantação do back-end ocorreu através da criação de um serviço de aplicativos no Azure, utilizando o modelo de publicação por código e a pilha de runtime .NET 7.0. Para a implementação desse processo, foi configurado o GitHub Actions, permitindo que o aplicativo seja atualizado em uma nova build e deploy ao realizar push.

No ambiente de desenvolvimento integrado (IDE), foi estabelecida a conexão com o banco de dados provisionado no Google Cloud, onde também foi criado o serviço de Gerenciamento de APIs.

<img src=https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/main/docs/img/deploy_back.png/>
<hr/>

### Banco de dados

O banco de dados foi provisionado no Google Cloud. Nesse ambiente, foi criada uma instância chamada *beneficiariodb*, responsável por armazenar os dados dos beneficiários cadastrados através do front-end.

No processo de estruturação do banco, estabelecemos uma conexão com o SQL Management utilizando o endereço IP, nome de usuário e senha do banco de dados. No console do SQL Server Management Studio (SSMS), executamos os comandos necessários para criar e estruturar a tabela, que possui colunas e linhas para o armazenamento organizado dos dados no banco.

<img src=https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/main/docs/img/googlecloud.png/>
<hr/>


