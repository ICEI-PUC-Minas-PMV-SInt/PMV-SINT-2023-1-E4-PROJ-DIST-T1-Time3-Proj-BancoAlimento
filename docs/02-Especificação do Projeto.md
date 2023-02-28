# Especificações do Projeto

## Estado da Arte

Nas pesquisas realizadas, foi possível notar uma expressiva quantidade de bancos de alimentos, sendo observado que grande parte deles, incluindo bancos de grandes cidades como Rio de Janeiro e São Paulo, não apresentam sistemas públicos e acessíveis via internet, específicos para o controle de doações de cestas básicas.

É importante frisar que existem iniciativas públicas e privadas para doação de alimentos, como o site Clique Alimentos,  vinculado ao Banco de Alimentos do Rio Grande do Sul, a plataforma Comida Invisível e o aplicativo VivaVida, vinculado à prefeitura de Campinas. Embora existam iniciativas vinculadas ao propósito de doação de alimentos, poucas propostas se adequam à necessidade específica do projeto em questão.

<table>
 <thead>
  <tr>
   <th>Imagens da Pesquisa</th>
   <th>Descrição</th>
  </tr>
 </thead>

 <tbody>
  <tr>
   <td><img src="https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2021-2-e1-proj-web-t1-grupo-7/blob/4b3d3255616e25d5082f4b3cf9297065c32b1cd1/docs/img/estadoarte1.png" width=500px></td>
   <td width=500px>O Clique Alimentos é uma iniciativa ligada à região do Rio Grande do Sul, onde o internauta escolhe uma "cidade" para destinar a doação de 1 kg de alimento para o Banco de Alimentos escolhido.

Fonte: https://www.cliquealimentos.com.br/Inicial.</td>
  </tr>

  <tr>
   <td><img src="https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2021-2-e1-proj-web-t1-grupo-7/blob/4b3d3255616e25d5082f4b3cf9297065c32b1cd1/docs/img/estadoarte2.png" width=500px></td>
   <td width=500px>A imagem refere-se a página inicial do site e app Comida Invisível, uma plataforma que tem como objetivo conectar pessoas para causar impacto social e ambiental, além de trazer conteúdos com objetivo de mudar o hábito de consumo de alimentos para que cada um possa fazer a sua parte.

Fonte: https://www.comidainvisivel.com.br/.</td>
  </tr>

  <tr>
   <td><img src="https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2021-2-e1-proj-web-t1-grupo-7/blob/bdd6ab740bb018ccd593ee55078450ccd1270a7f/docs/img/estadoarte3.png" width=500px></td>
   <td width=500px>A imagem em questão refere-se ao app VivaVida, da Prefeitura de Campinas, que tem como objetivo a captação de recursos para conversão e distribuição de cestas básicas através de sistema de Vouchers virtuais. 

Fonte: https://play.google.com/store/apps/details?id=br.com.vonbraunlabs.vivavida&hl=pt_BR&gl=US.</td>
  </tr>
 </tbody>

</table>

## Histórias de Usuários

No projeto são considerados dois principais tipos de usuários: funcionários vinculados ao BMA e ao CRAS que estejam envolvidos com o processo de distribuição de cestas básicas; e os beneficiários do programa de assistência social de doação de alimentos. 

No caso dos funcionários, é necessário que tais usuários tenham um perfil administrativo, pesquisador e estejam dispostos a promover o maior controle possível na distribuição de cestas básicas. São necessidades desses usuários: 

- Verificar o número de cestas básicas disponíveis para distribuição;
- Consultar o CPF dos beneficiários do programa de doação de alimentos a fim de verificar o registro da distribuição;
- Cadastrar um beneficiário do programa de doação de alimentos;
- Visualizar que tipo de cesta o beneficiário recebe, se ainda não recebeu no mês e saber a data do próximo recebimento.

No caso dos beneficiários as necessidades são: 

- Consultar a data do próximo recebimento de cesta básica/verde;;
- Consultar o local de retirada de cesta básica/verde;
- Consultar histórico de últimos recebimentos;

## Personas

<table>
  <tr>
    <th>Foto</th>
    <th>Nome</th>
    <th>Descrição</th>
    <th>Aplicativos</th>
    <th>Motivações</th>
    <th>Frustrações</th>
    <th>Hobbies, História</th>
  </tr
        <tr>
    <td><img title="Maria Aparecida" src="https://images.unsplash.com/photo-1626668011687-8a114cf5a34c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80"/></td>
    <td>Maria Aparecida</td>
    <td>
      <ul>
        <li>68 anos</li>
        <li>Aposentada</li>
        <li>Mora de aluguel em Poços de Caldas com a filha e dois netos</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Não usa redes sociais</li>
         </ul>
    </td>
    <td>
      <ul>
        <li>Cuidar da família</li>
        <li>Participar da missa</li>
        <li>Dançar forró</li>
      </ul>
    </td>
    <td>
      <li>Não terminou o ensino fundamental</li>
      <li>Não tem casa própria</li>
      <li>Nunca viu o mar</li>
    </td>
    <td>
      <li>Ver novelas</li>
      <li>Costurar</li>
       <li>Sua filha está desempregada desde meados de 2020 e, por isso, tornou-se a principal provedora do sustento da filha e dos dois netos</li>
          </td>
  </tr>
  <tr>
    <td><img title="Aline" src="https://images.unsplash.com/photo-1602184572201-89c7deeddf3c?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=387&q=80"/></td>
    <td>Aline</td>
    <td>
      <ul>
        <li>36 anos</li>
        <li>Auditora da CGU</li>
        <li>Mora no Rio de Janeiro</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Twitter</li>
        <li>Instagram</li>
        <li>Youtube</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Emicida</li>
        <li>Angela Merkel</li>
        <li>Emmanuel Macron</li>
      </ul>
    </td>
    <td>
      <li>Não consegue executar a auditoria com facilidade por falta de disponibilidade da informação nos órgãos públicos</li>
      <li>Está sobrecarrega com as demandas de trabalho</li>
     </td>
    <td>
      <li>Música</li>
      <li>Cozinhar com o filho</li>
         <li>Foi nomeada presidente da comissão de acompanhamento da implementação da transparência ativa dos órgão públicos</li>
    </td>
  </tr>
    <tr>
    <td><img title="Jose Augusto" src="https://images.unsplash.com/photo-1545167622-3a6ac756afa4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=412&q=80"/></td>
    <td>José Augusto</td>
    <td>
      <ul>
        <li>50 anos</li>
        <li>Padre</li>
        <li>Mora em Poços de Caldas</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Facebook</li>
        <li>Instagram</li>
        <li>Youtube</li>
        </ul>
    </td>
    <td>
      <ul>
        <li>Jornal O Globo</li>
        <li> Padre Júlio Lancellotti</li>
        <li>Papa Francisco</li>
      </ul>
    </td>
    <td>
      <li>Deseja que a sociedade se torne mais caridosa</li>
      <li>Não consegue ajudar a todos que estão em insegurança alimentar</li>
         </td>
    <td>
      <li>Ver jornal</li>
      <li>Ler a Bíblia</li>
      <li>No último ano, percebeu que os projetos sociais da igreja não tem conseguido contemplar todas as pessoas em situação de vulnerabilidade social</li>
    </td>
  </tr>
  <tr>
    <td><img title="Paulo" src="https://images.unsplash.com/photo-1552058544-f2b08422138a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=399&q=80"/></td>
    <td>Paulo</td>
    <td>
      <ul>
        <li>31 anos</li>
        <li>Assistente Social</li>
        <li>Mora em Poços de Caldas</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Twitter</li>
        <li>Instagram</li>
        <li>Youtube</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Carl Gustav Jung</li>
        <li>Josephina Albano</li>
        <li>Chico Buarque</li>
      </ul>
    </td>
    <td>
      <li>Acha o trabalho que executa extremamente burocrático</li>
        </td>
    <td>
      <li>Jogar Futebol</li>
      <li>Música</li>
      <li>Percebeu o aumento de demanda de benefícios sociais na pandemia, entretanto o processo de concessão é demorado uma vez que envolve dois equipamentos públicos diferentes</li>
    </td>
  </tr>
  <tr>
    <td><img title="Renato Luís" src="https://images.unsplash.com/photo-1599256621730-535171e28e50?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=371&q=80" /></td>
    <td>Renato Luís</td>
    <td>
      <ul>
        <li>28 anos</li>
        <li>Servidor Público</li>
        <li>Mora em Poços de Caldas</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Youtube</li>
        <li>Facebook</li>
        <li>Instagram</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Jão</li>
        <li>Mc Tha</li>
      </ul>
    </td>
    <td>
      <li>Não consegue fornecer os dados solicitados pela diretora do seu trabalho dentro dos prazos</li>
      <li>Tem dificuldade em consolidar dados</li>
    </td>
    <td>
      <li>Música</li>
      <li>Barzinho com os amigos</li>
           <li>Ele deseja ter mais facilidade em obter os dados do banco de alimentos com seus colegas de trabalho e elaborar relatórios com mais facilidade </li>
    </td>
  </tr>
  <tr>
    <td><img title="Roberta"
        src="https://images.unsplash.com/photo-1597223557154-721c1cecc4b0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=580&q=80"/></td>
    <td>Roberta</td>
    <td>
      <ul>
        <li>38 anos</li>
        <li>Servidora Pública (Diretora)</li>
        <li>Mora Poços de Caldas</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Facebook</li>
        <li>G1</li>
        <li>Instagram</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Jornais</li>
         <li>Josué de Castro</li>
         <li>Nina Simone</li>
       </ul>
    </td>
    <td>
      <li>Quer tornar o trabalho executado pelo Banco de Alimentos mais eficiente</li>
      <li>Quer aprender mais coisas</li>
    </td>
    <td>
      <li>Ler jornais</li>
      <li>Passar tempo com o marido</li>
      <li>Assistir séries</li>
      <li>Recebeu denúncias sobre beneficiários do Banco de Alimentos que teriam recebido o benefício em locais diferentes</li>
    </td>
  </tr>
</table>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Administrador       | Alterar permissões e cadastrar novos usuários do BMA e CRAS | Permitir a administração de contas e o controle de usuários |
|Usuário BMA/CRAS | Cadastrar beneficiários |Inserir no sistema pessoas aptas ao recebimento do benefício  |
|Usuário BMA/CRAS | Alterar cadastro de beneficiários| Permitir a atualização/correção de dados do beneficiário |
|Usuário BMA/CRAS | Registrar cestas básicas/verdes e pontos para os quais as cestas foram enviadas | Registrar nº de cestas básicas e local de distribuição para prestação de contas |
|Usuário BMA/CRAS | Consultar se beneficiário já recebeu auxílio durante o período de referência | Evitar concessão de cesta básica em duplicidade |
|Usuário BMA/CRAS | Registrar o benefício entregue ao beneficiário | Deduzir saldo e deixar registrado que o beneficiário já recebeu o benefício |
|Beneficiário | Consultar data de recebimento do próximo benefício | Evitar deslocamento desnecessário para recebimento de benefício |
|Beneficiário | Consultar locais com cestas disponíveis | Localizar o endereço mais próximo com cestas em estoque |
|Cidadão| Quantidade de cestas doadas e quantidade de família atendidas| 	Dar transparência ao trabalho do BMA| 
|Cidadão|	Quantidade de alimentos doados por fonte|	Dar transparência ao trabalho do BMA |

O quadro abaixo apresenta uma breve definição de cada perfil: 

|Perfil| Descrição
|--------------------|------------------------------------|
|Administrador|	Servidor do BMA/CRAS com grau máximo de visualização e controle do sistema|
|Usuário BMA/CRAS |	Servidor/colaborador vinculado ao BMA/CRAS que recebe, separa e prepara as cestas básicas e cestas verdes, cadastra beneficiários|
|Beneficiário| 	Pessoa que recebe a cesta básica ou a cesta verde|
|Cidadão |	Qualquer pessoa que acesse o site para buscar infomações sobre o Banco de Alimentos|


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário faça login de entrada| ALTA | 
|RF-002| Permitir que o usuário faça logoff do sistema| ALTA |
|RF-003| Permitir que o administrador cadastre os usuários do sistema| ALTA |
|RF-004| Permitir que o administrador consulte, altere e exclua o cadastro dos usuários do sistema| ALTA |
|RF-005| Permitir que o usuário logado consulte o CEP e obtenha o endereço disponibilizado pelo API consulta CEP durante o cadastro dos beneficiários.| ALTA |
|RF-006| Permitir que o usuário cadastre os beneficiários| ALTA |
|RF-007| Permitir que o usuário consulte, altere e exclua o cadastro dos beneficiários| ALTA |
|RF-008| Permitir que o usuário registre as retiradas de cestas pelo beneficiário| ALTA |
|RF-008| Restringir a retirada de cesta, conforme periodicidade estabelecida pelo município| ALTA |
|RF-009| Permitir que o usuário visualize histórico de retirada dos beneficiários| MÉDIA |
|RF-010| Permitir que o usuário realize a redefinição de senha| MÉDIA |
|RF-011| Consultar data de recebimento de cesta| BAIXA |
|RF-012| Consultar local de retirada de cesta| ALTA |
|RF-013| Consultar recebimento de cesta | ALTA |
|RF-014| Permitir que após o usário gravar os dados de retirada de cesta, mensagens assíncronas sejam enviadas para o histórico de consulta de retiradas do portal do Beneficiário.| ALTA |
|RF-015| Permitir que mensagem de erro seja enviada ao usuário quando a mensagem não for enviada para o histórico de consulta do portal do Beneficiário| ALTA |
|RF-016| Fornecer a outros sistemas parceiros informações de famílias beneficiadas através da consulta pelo CPF| ALTA |



### Requisitos não Funcionais

- Usabilidade

|RNF-00| O sistema deve ser pensado para o usuário|
|--|-------------------------------------------------------|
|Estímulo| O Usuário realiza ações específicas e objetivas no sistema.|
|Fonte do estímulo| Usuário.|
|Ambiente| Sistema com carga normal.|
|Artefato| Sistema como um todo.|
|Resposta| Fluxo do usuário sem interrupções e com fácil navegabiliade.|
|Medida de resposta| O usuário consegue finalizar as tarefas específicas, do início ao fim, no sistema.|

- Disponibilidade

|RNF-00| O sistema deve estar disponível em horário integral, durante 24h por dia e sete dias por semana|
|--|-------------------------------------------------------|
|Estímulo| Usuário acessa sistema no domingo no periódo da madrugada.|
|Fonte do estímulo| Usuário.|
|Ambiente| Sistema como carga normal.|
|Artefato| Sistema como um todo.|
|Resposta| O sistema deve permitir o acesso ao usuário em qualquer hora, seja do dia ou noite.|
|Medida de resposta| Todas tentativas de acesso e requisição de informações ao sistema devem ser respondidas.|

- Desempenho

|RNF-00| A latência total do sistema não deve ultrapassar 10 segundos|
|--|-------------------------------------------------------|
|Estímulo| Usuário autenticado acessa uma funcionallidade na interface gráfica do sistema.|
|Fonte do estímulo| Usuário autenticado.|
|Ambiente| Sistema com carga normal.|
|Artefato| Módulos de informações cadastrais.|
|Resposta| O sistema processa a solicitação e retorna informação em até 10 segundos para o usuário.|
|Medida de resposta|Resposta dos sistema com até 10 segundos de duração.|

- Modificabilidade

|RNF-003| O sistema deve ser modular e componentizado, utilizando orientação a objetos e ser construído com arquitetura distribuída|
|--|-------------------------------------------------------|
|Estímulo| Construção e integração de um novo módulo com ouros módulos da arquitetura distribuída.|
|Fonte do estímulo| Desenvolvedor de software.|
|Ambiente| Ambiente de desenvolvimento.|
|Artefato| Módulos de informações cadastrais.|
|Resposta| Módulos pré-existentes do sistema se comunicando com o novo módulo com baixo acoplamento.|
|Medida de resposta|Qualquer intervenção de um ou mais módulos não gera reflexos generalizados no ambiente como um todo e a disponobilização de um novo módulo não interrompe os outros em funcionamento.|

- Portabilidade

|RNF-004| O sistema deve ser executado nos principais navegadores (Chrome, mozila e Edge)|
|--|-------------------------------------------------------|
|Estímulo| Usuário acessando o sistema.|
|Fonte do estímulo| Usuário.|
|Ambiente| Sistema com carga baixa, normal ou além do normal.|
|Artefato| Módulos de informações cadastrais.|
|Resposta| A interface gráfica do projeto apresenta navegabilidade nas ações disponíveis ao usuário.|
|Medida de resposta|O usuário consegue ter acesso a interface gráfica do sistema.|

- Portabilidade

|RNF-00| O sistema deve ser responsivo para adaptação em dispositivos móveis| 
|--|-------------------------------------------------------|
|Estímulo| Usuário logado utilizazndo a interface gráfica do sistema.|
|Fonte do estímulo| Usuário logado.|
|Ambiente| Sistema com carga baixa, normal ou além do normal.|
|Artefato| Módulos de informações cadastrais.|
|Resposta| A interface gráfica do projeto apresenta navegabilidade e objetividade nas ações disponíveis ao usuário.|
|Medida de resposta|O usuário realiza suas ações rapidamente e sem desvios indesejados para outras funcionalidades.|

- Segurança

|RNF-00| O sistema deve exigir autenticação prévia de usuários|
|--|-------------------------------------------------------|
|Estímulo| Usuário realiza ação de carregamento de uma página potregida ao qual necessita de login e senha para ser viasualizada.|
|Fonte do estímulo| Usuário autenticado.|
|Ambiente| Sistema com carga normal.|
|Artefato| Módulo de autenticação.|
|Resposta| Entrada de usuário no sistema e acesso as páginas do sistema.|
|Medida de resposta|Todas as requisisções com usuários e senhas corretos devem dar acesso ao usuário a área protegida do sistema.|

- Segurança

|RFN-00| O sistema deve possuir controle de caesso baseado em role|
|--|-------------------------------------------------------|
|Estímulo| Usuário com perfil de administrador realiza cadatro de um novo usuário do sistema.|
|Fonte do estímulo| Usuário administrador.|
|Ambiente| Sistema com carga baixa, normal ou além do normal.|
|Artefato| Módulo de autenticação.|
|Resposta| Cadastro de usuário no sistema.|
|Medida de resposta| Ao verificar o banco de dados, o novo usuário deverá ter o perfil de acordo com o que foi cadastrado.|

- Interoperabilidade

|RFN-00| O sistema deverá interoperar com aplicações legadas com baixo acoplamento utilizando APIs ou outros recursos para consumo de serviços|
|--|-------------------------------------------------------|
|Estímulo| O sistema para completar uma operação precisa recuperar uma informação que está localizada no domínio de uma aplicação legada.|
|Fonte do estímulo|O sistema como um todo.|
|Ambiente| Sistema com carga normal.|
|Artefato| Módulo de informações cadastrais.|
|Resposta| Troca de informações com os sistemas legados.|
|Medida de resposta| Conexão, envio de mensagens e/ou requisições e/ou respostas provenienetes de aplicações legadas.|



## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre. |
|02| O front end deve ser desenvolvido com a linguagem de programação Javascript e para isso deve ser utilizado o framework React na versão mais recente. |
|03| Deve ser utilizado o framework Bootstrap para padronização de interface do usuário. |
|04| Como linguagem de folha de estilos deverá ser utilizado o CSS. |
|05| O sistema deve fazer uso de Media Queries e do sistema de Grid do Bootstrap para ajustar de forma responsiva em aparelhos de diferentes resoluções. |
|06| O sistema deverá expor funcionalidades e interoperar com  outras aplicação legadas através do protocolo HTTP por meio de APIs RESTful. |
|07| O transporte de informações se dará por meio do formato JSON. |
|08| O mecanismo de autorização entre as APIs deverá ser feiro por meio do JWT. |
|09| O sistema deve ser construido de forma modular para faciliatr a implantação. |
|10| Os módulos que compõem os microsserviços no back end devem ser desenvolvidos na linguagem de programação C# utilizando .NET como ambiente de execução do lado do servidor. |
|11| Deve ser utilizado como ferramenta de versionamento o GIT e cada módulo deve possuir repositório distinto para melhor controle das modificações do código. |
|12| O sistema deve possuir características de aplização distribuída: abertura, portabiliadde, uso de recursos de rede. |
|13| Os módulos do sistema devem faser uso do banco de dados relacional SQLServer.|
|14| O sistema deve ser desenvolvido utilizando recursos de gestão de configuração, com interação contínua, para isso deve ser utillizada a plataforma como serviço (PAAS) denominada Heroku.|


## Mecanismos Arquiteturais

|Ambiente | Design  | Implementação |
|------|-----------------------------------------|----|
|Persistência| Framework ORM | Entity Framework | 
|Persistência| Banco de dados relacional | SQLServer |
|Front end| Framework de desenvolvimento | React |
|Front end| Linguagem de programação | JavaScript |
|Front end| Framework de folhas de estilos | Bootstrap |
|Folhas de estilo| Linguagem de folha de estilos | CSS |
|Deploy| Plataforma de automatização de deploy | Heroku |
|Back end| Linguagem de programação | C# |
|Back end| Framework de desenvolvimento | ASP.NET Core |
|Back end| Ambiente de execução | .NET |
|Back end| Serviço de execução de código | - |
|Back end| Gerenciador de tráfego | - |
|Autenticação| Padrão de formato para autenticação | JWT |
|Autenticação| Serviço de autenticação | - |
|Integração| Formato de transporte de informações | JSON |
|Integração| Protocolo de comunicação | HTTP |
|Integração| Estilo de arquitetura | REST |
|Versionamento| Controle e armazenamento de código fonte | GitHub |
|Versionamento| Versionamento de código fonte | Git |
|Automação| Ferramenta de workflow | - |
|Build| Ferramenta de build de componenetes do software | NPM |




## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
