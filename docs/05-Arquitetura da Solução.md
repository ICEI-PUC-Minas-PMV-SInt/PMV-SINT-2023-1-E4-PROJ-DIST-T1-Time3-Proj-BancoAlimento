# Arquitetura da Solução

<img src=https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/main/docs/img/iconografia_api.png/>


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

- Desenho de protótipo: Adobe Xd
- Desenvolvimento Front-end: React Js; 
- Desenvolvimento Back-end:.NET 6.0;
- Servidor do banco de dados: SQL Server 
- Armazenamento de objetos: Google Cloud;
- Hospedagem em Nuvem: Azzure;



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

###### Front-end
<img src=https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/main/docs/img/deploy_front.png/>
<hr/>

###### Back-end
<img src=https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/main/docs/img/deploy_back.png/>
<hr/>

###### Banco de dados
<img src=https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/main/docs/img/googlecloud.png/>
<hr/>


