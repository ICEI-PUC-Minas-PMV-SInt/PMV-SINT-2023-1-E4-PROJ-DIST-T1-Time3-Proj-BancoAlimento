
# Projeto de Interface

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

O projeto foi desenvolvido num tipo de aplicação Single Page Application (SPA), que consiste em carregar a página uma única vez dinamicamente sem a necessidade de carregar novamenete. Visando o funcionamento em desktops com foco na acessibilidade, agilidade e usabilidade.

Na página, há um Sidebar que permite ao usuário navegar por:

Sobre Nós: onde é apresentada um pouco sobre a proposta da aplicação.
Parceiros: onde é possível encontrar informações sobre os parceiros que contribuem com as doações para projetos sociais.
Portal do Funcionário/Administrador: onde somente os administradores, munidos de login e senha, podem cadastrar, excluir e alterar informações de beneficiários e funcionários, bem como registrar as doações de cestas.
Portal do Beneficiário: onde os beneficiários cadastrados podem realizar login com seu CPF para consultar o histórico de cestas retiradas por eles, bem como a data da próxima retirada de cestas.

## Diagrama de Fluxo

O diagrama de fluxo é uma ferramenta importante para modelar e representar processos de negócios e sistemas. Ele permite visualizar de forma clara as etapas de um processo, identificar possíveis problemas e otimizar a execução de tarefas.

O diagrama de fluxo apresentado representa o caminho para o cadastramento de beneficiários no sistema. O início do percurso é representado pelo box "começo", seguido pela ação de login do usuário, que pode resultar em "ok" ou "unauthorized". Após o processo de login, há outras ações necessárias para a conclusão da tarefa, como a validação dos dados do beneficiário e a inserção do cadastro no sistema. A imagem mostra que o processo é encerrado após a efetiva inserção do cadastro.

![Diagrama de Fluxo](https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/31f9f05d028e47a528d377f6a3fdca197436776d/docs/img/BancoAlimentos%20-%20P%C3%A1gina%201%20User%20Flow%20de%20Cadastro%20Benefici%C3%A1rio.jpeg)
<sub>Diagrama de fluxo para cadastramento de beneficiários, fonte: Autor</sub>

> **Links Úteis**:
> - [Fluxograma online: seis sites para fazer gráfico sem instalar nada | Produtividade | TechTudo](https://www.techtudo.com.br/listas/2019/03/fluxograma-online-seis-sites-para-fazer-grafico-sem-instalar-nada.ghtml)

## Arquitetura da Informação

A arquitetura da informação pensada para a aplicação baseia-se em criar uma experiência de uso intuitiva e coerente para os usuários, aprimorando a acessibilidade, navegabilidade e usabilidade de um produto digital.

O Sitemap da aplicação apresenta uma lista hierárquica de todas as páginas e conteúdos do site. A aplicação do Banco de Alimentos integra o sistema de cadastramento, bem como áreas específicas informativas para o usuário geral da aplicação.

![Sitemap](https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/31f9f05d028e47a528d377f6a3fdca197436776d/docs/img/sitemap.jpeg)
<sub>Sitemap da aplicação, fonte: Autor</sub>

## Protótipo de alta fidelidade

###### Página Inicial

![Prototipo alta fidelidade - Home](https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/31f9f05d028e47a528d377f6a3fdca197436776d/docs/img/home.png)

###### Login Funcionários

![Prototipo alta fidelidade - Login Funcionário](https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/31f9f05d028e47a528d377f6a3fdca197436776d/docs/img/login.png)

###### Portal dos Beneficiários

![Prototipo alta fidelidade - Portal Beneficiário](https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/31f9f05d028e47a528d377f6a3fdca197436776d/docs/img/portalBeneficiario.png)

###### Parceiros

![Prototipo alta fidelidade - Parceiros](https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/31f9f05d028e47a528d377f6a3fdca197436776d/docs/img/parceiros.png)

###### Sobre Nós

![Prototipo alta fidelidade - sobre Nós](https://github.com/ICEI-PUC-Minas-PMV-SInt/PMV-SINT-2023-1-E4-PROJ-DIST-T1-Time3-Proj-BancoAlimento/blob/31f9f05d028e47a528d377f6a3fdca197436776d/docs/img/sobreNos.png)

 
> **Links Úteis**:
> - [Protótipos vs Wireframes](https://www.nngroup.com/videos/prototypes-vs-wireframes-ux-projects/)
> - [Ferramentas de Wireframes](https://rockcontent.com/blog/wireframes/)
> - [MarvelApp](https://marvelapp.com/developers/documentation/tutorials/)
> - [Figma](https://www.figma.com/)
> - [Adobe XD](https://www.adobe.com/br/products/xd.html#scroll)
> - [Axure](https://www.axure.com/edu) (Licença Educacional)
> - [InvisionApp](https://www.invisionapp.com/) (Licença Educacional)
