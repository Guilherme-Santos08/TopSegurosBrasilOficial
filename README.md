
![Logo](https://i.imgur.com/CHByCHt.png)


# TopSegurosBrasil

Aplicação completa para gerenciamento de Seguros de automóvel. Aplicação desenvolvida com conceitos de MVC, hospeda nos maiores servidores Azure.

Para o Banco de Dados decidimos usar o SQl Server, também hospedados no Azure.


## Requisitos

**Quadro 1** – Planos

|  | Item #1 |
| --- | --- |
| Nome: | Cadastro e Consulta de Planos. |
| Descrição: | O sistema deve ser capaz de criar um novo tipo de plano para ser disponibilizado para a escolha do cliente. |
| Prioridade: | Alta |
| Entradas e pré-condições: | Caso a empresa decida criar um novo plano, modificar um existente o exclui-lo. |
| Saídas e pós-condições: | Novo Plano disponível e disponível para consulta. |
| 
Fluxo de eventos |  |
| Fluxo principal: | 1 - Selecionar a aba “Planos”.
2 - Inserção dos dados de cadastro.
3 - Cadastramento no banco de dados. |
| Fluxo secundário: | O sistema deverá exibir os detalhes do plano para consulta ao clicar em “detalhes” e também de editar o registro. |

**Fonte**: Própria Autoria

**Quadro 2** – Clientes

|  | Item #2 |
| --- | --- |
| Nome: | Cadastro e Consulta de Planos. |
| Descrição: | O sistema deve ser capaz de criar o registro de um novo cliente e armazenar seus dados no banco de dados. |
| Prioridade: | Alta |
| Entradas e pré-condições: | Dados do Cliente (Caso ainda não registrado). |
| Saídas e pós-condições: | Cliente cadastrado no banco de dados e disponível para consulta. |
| 
Fluxo de eventos |  |
| Fluxo principal: | 1 - Selecionar a aba “Clientes”.
2 - Inserção dos dados de cadastro.
3 - Cadastramento no banco de dados. |
| Fluxo secundário: | O sistema deverá exibir os detalhes do cliente para consulta ao clicar em “detalhes” e também de editar o registro. |

**Fonte**: Própria Autoria

**Quadro 3** – Veículos

|  | Item #3 |
| --- | --- |
| Nome: | Cadastro de Consulta de Veículos. |
| Descrição: | O sistema deve ser capaz de criar o registro de um novo veículo e armazenar seus dados no banco de dados. |
| Prioridade: | Alta |
| Entradas e pré-condições: | Dados do veículo (Caso ainda não registrado). Registrar veículo logo após registrar um cliente novo. |
| Saídas e pós-condições: | Veículo cadastrado no banco de dados e disponível para consulta. |
| 
Fluxo de eventos |  |
| Fluxo principal: | 1 - Selecionar a aba “Veículos”. Ou confirmar o registro de um novo cliente.
2 - Inserção dos dados de cadastro.
3 - Cadastramento no banco de dados. |
| Fluxo secundário: | O sistema deverá exibir os detalhes do cliente para consulta ao clicar em “detalhes” e também de editar o registro. |

**Fonte**: Própria Autoria

**Quadro 4** – Apólice

|  | Item #4 |
| --- | --- |
| Nome: | Cadastro de nova apólice. |
| Descrição: | O sistema deve ser capaz de criar o registro de uma nova apólice referente à um novo cliente. |
| Prioridade: | Alta |
| Entradas e pré-condições: | Vigência do contrato, início e ID do veículo segurado. Deve ser realizado ao fechar contrato com um novo cliente. |
| Saídas e pós-condições: | Apólice cadastrado no banco de dados e disponível para consulta. |
| 
Fluxo de eventos |  |
| Fluxo principal: | 1 - Selecionar a aba “Seguros(Apólice)”. Ou confirmar o registro de um novo veículo.
2 - Inserção dos dados de cadastro.
3 - Cadastramento no banco de dados. |
| Fluxo secundário: | O sistema deverá exibir os detalhes do cliente para consulta ao clicar em “detalhes” e também de editar o registro. |

**Fonte**: Própria Autoria

**Quadro 5** – Prestadores

|  | Item #5 |
| --- | --- |
| Nome: | Cadastro de Prestadores de Serviço. |
| Descrição: | O sistema deve ser capaz de criar o registro de um novo parceiro prestador de serviços. |
| Prioridade: | Alta |
| Entradas e pré-condições: | Ao receber novos parceiros, deverá ser realizado seu cadastro no sistema, contenho seus dados como pessoa jurídica. |
| Saídas e pós-condições: | Prestador cadastrado no banco de dados e disponível para consulta. |
| 
Fluxo de eventos |  |
| Fluxo principal: | 1 - Selecionar a aba “Prestadores”. Ou confirmar o registro de um novo seguro.
2 - Inserção dos dados de cadastro.
3 - Cadastramento no banco de dados. |
| Fluxo secundário: | O sistema deverá exibir os detalhes do prestador para consulta ao clicar em “detalhes” e também de editar o registro. |

**Fonte**: Própria Autoria

**Quadro 6** – Sinistro

|  | Item #6 |
| --- | --- |
| Nome: | Cadastro de novo sinistro. |
| Descrição: | O sistema deve ser capaz de criar o registro de uma nova ocorrência com um veículo assegurado (sinistro). |
| Prioridade: | Alta |
| Entradas e pré-condições: | Ao receber uma nova ocorrência, deve-se realizar o registro da mesma no sistema. |
| Saídas e pós-condições: | Sinistro cadastrado no banco de dados e disponível para consulta. |
| 
Fluxo de eventos |  |
| Fluxo principal: | 1 - Selecionar a aba “Sinistros”. Ou confirmar o registro de um novo prestador.
2 - Inserção dos dados de cadastro.
3 - Cadastramento no banco de dados. |
| Fluxo secundário: | O sistema deverá exibir os detalhes do sinistro para consulta ao clicar em “detalhes” e também de editar o registro. |

**Fonte**: Própria Autoria

**Quadro 7** – Fabricante

|  | Item #7 |
| --- | --- |
| Nome: | Cadastro de novo Fabricante. |
| Descrição: | O sistema deve ser capaz de criar o registro de um novo fabricante. |
| Prioridade: | Alta |
| Entradas e pré-condições: | Caso falte um fabricantes no banco de dados do sistema, deverá ser inserido neste campo com apenas o nome do fabricante. |
| Saídas e pós-condições: | Fabricante cadastrado no banco de dados e disponível para consulta. |
| 
Fluxo de eventos |  |
| Fluxo principal: | 1 - Selecionar a aba “Fabricante”.
2 - Inserção do nome do fabricante.
3 - Cadastramento no banco de dados. |
| Fluxo secundário: | O sistema deverá exibir o fabricante para consulta ao clicar em “detalhes” e também de editar o registro. |

**Fonte**: Própria Autoria

**Quadro 8** – Ano Modelo

|  | Item #8 |
| --- | --- |
| Nome: | Cadastro de ano de veículo |
| Descrição: | A seguradora aceita apenas veículos de ano de lançamento entre 2010 e 2022, nos seguintes anos deve ser cadastrado um novo ano de modelo. |
| Prioridade: | Baixa |
| Entradas e pré-condições: | Ao virar o ano, deve ser registrado um novo. |
| Saídas e pós-condições: | Ano disponível para seleção. |
| 
Fluxo de eventos |  |
| Fluxo principal: | 1 - Selecionar a aba “Ano dos Modelos”.
2 - Inserção do ano desejado.
3 - Cadastramento no banco de dados. |
| Fluxo secundário: | O sistema deverá disponibilizar o ano do veículo para seleção. |

**Fonte**: Própria Autoria

## Instalação modo desenvolvimento

Para instalar o projeto você vai precisar de algumas ferramentas:
- [VisualStudio](https://visualstudio.microsoft.com/pt-br/downloads/)
- [Node](https://nodejs.org/en/download/)

Agora baixe o repositório do arquivo:
```bash
  git clone https://github.com/Guilherme-Santos08/TopSegurosBrasilOficial
```
Entre dentro da pasta que você acabou de clonar e clique na solução.
Após entrar na solução, execulte o programa com F5 caso você queira debugar, caso você apenas queria execultar a aplicação normalmente, execulte CRT+F5. 
## Tecnologias

**Client:** Aspnet, JavaScript, C#, TailwindCSS

**Server:** SQL Server + SQL Azure

