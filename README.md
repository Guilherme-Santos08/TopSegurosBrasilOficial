
![Logo](https://i.imgur.com/CHByCHt.png)


# TopSegurosBrasil

Aplicação completa para gerenciamento de Seguros de automóvel. Aplicação desenvolvida com conceitos de MVC, hospeda nos maiores servidores Azure.

Para o Banco de Dados decidimos usar o SQl Server, também hospedados no Azure.


## Requisitos

<article id="5b2c7498-36bc-4e68-8f7d-43c3f8a8139e" class="page sans">
      <header><h1 class="page-title">Requisitos 2</h1></header>
      <div class="page-body">
        <p id="bc8b6e23-6d1b-4034-a2b8-0d5b2956f814" class="">
          <strong>Quadro 1</strong> – Planos
        </p>
        <table id="1a786fc0-6e90-48f1-8d30-c1ffc41e54fe" class="simple-table">
          <tbody>
            <tr id="9ec29dba-3224-40ac-99fe-d754f061d6e7">
              <td id="xmlR" class=""></td>
              <td id="xk?~" class="">Item #1</td>
            </tr>
            <tr id="490cc062-f80f-4bb3-91e5-d291fe5feeaf">
              <td id="xmlR" class="">Nome:</td>
              <td id="xk?~" class="">Cadastro e Consulta de Planos.</td>
            </tr>
            <tr id="89aa137b-9bd2-457b-a6eb-73a7e81e533a">
              <td id="xmlR" class="">Descrição:</td>
              <td id="xk?~" class="">
                O sistema deve ser capaz de criar um novo tipo de plano para ser
                disponibilizado para a escolha do cliente.
              </td>
            </tr>
            <tr id="dad5c185-e969-461c-8593-6ea5dc9b31ca">
              <td id="xmlR" class="">Prioridade:</td>
              <td id="xk?~" class="">Alta</td>
            </tr>
            <tr id="bd10426a-4337-4148-9f9f-6ac9e2c5e53f">
              <td id="xmlR" class="">Entradas e pré-condições:</td>
              <td id="xk?~" class="">
                Caso a empresa decida criar um novo plano, modificar um
                existente o exclui-lo.
              </td>
            </tr>
            <tr id="7669fbad-1ec7-4ab5-9e13-57e21891c22f">
              <td id="xmlR" class="">Saídas e pós-condições:</td>
              <td id="xk?~" class="">
                Novo Plano disponível e disponível para consulta.
              </td>
            </tr>
            <tr id="3d187ce5-b401-4147-9457-3fa30db56e6e">
              <td id="xmlR" class="">Fluxo de eventos</td>
              <td id="xk?~" class=""></td>
            </tr>
            <tr id="6444673b-afb3-4462-a9e9-0981464ebabd">
              <td id="xmlR" class="">Fluxo principal:</td>
              <td id="xk?~" class="">
                1 - Selecionar a aba “Planos”. 2 - Inserção dos dados de
                cadastro. 3 - Cadastramento no banco de dados.
              </td>
            </tr>
            <tr id="88ab2754-610e-4f8d-ae25-dbf51139e3ea">
              <td id="xmlR" class="">Fluxo secundário:</td>
              <td id="xk?~" class="">
                O sistema deverá exibir os detalhes do plano para consulta ao
                clicar em “detalhes” e também de editar o registro.
              </td>
            </tr>
          </tbody>
        </table>
        <p id="ebab23bb-9eb4-44e9-8dab-d3aed0c6dc5b" class="">
          <strong>Fonte</strong>: Própria Autoria
        </p>
        <p id="3a0189de-387f-4965-bc0f-3e94af52eee8" class=""></p>
        <p id="efd364fc-0645-4142-8a26-c705618ac6dd" class="">
          <strong>Quadro 2</strong> – Clientes
        </p>
        <table id="2160b930-7e7e-4589-ac11-341dd171084e" class="simple-table">
          <tbody>
            <tr id="b03e74b2-b7fa-4656-8664-49227b1b4560">
              <td id="eqz^" class=""></td>
              <td id="g;XM" class="">Item #2</td>
            </tr>
            <tr id="a030d236-2fe0-40a9-88f5-6c43570197b0">
              <td id="eqz^" class="">Nome:</td>
              <td id="g;XM" class="">Cadastro e Consulta de Planos.</td>
            </tr>
            <tr id="fbda2844-ac0b-4a55-a95f-0815014c462f">
              <td id="eqz^" class="">Descrição:</td>
              <td id="g;XM" class="">
                O sistema deve ser capaz de criar o registro de um novo cliente
                e armazenar seus dados no banco de dados.
              </td>
            </tr>
            <tr id="28423938-760e-4862-b748-3b820ba51e10">
              <td id="eqz^" class="">Prioridade:</td>
              <td id="g;XM" class="">Alta</td>
            </tr>
            <tr id="eeb1c261-d852-4d32-9114-abc800ef7c89">
              <td id="eqz^" class="">Entradas e pré-condições:</td>
              <td id="g;XM" class="">
                Dados do Cliente (Caso ainda não registrado).
              </td>
            </tr>
            <tr id="b44ce74a-116a-45bc-8e6b-ffaefeb08f11">
              <td id="eqz^" class="">Saídas e pós-condições:</td>
              <td id="g;XM" class="">
                Cliente cadastrado no banco de dados e disponível para consulta.
              </td>
            </tr>
            <tr id="0ada2c19-5842-4e7b-9340-35b3048982b2">
              <td id="eqz^" class="">Fluxo de eventos</td>
              <td id="g;XM" class=""></td>
            </tr>
            <tr id="2eedf284-b260-4f4e-9ec4-0e0291f8f5ac">
              <td id="eqz^" class="">Fluxo principal:</td>
              <td id="g;XM" class="">
                1 - Selecionar a aba “Clientes”. 2 - Inserção dos dados de
                cadastro. 3 - Cadastramento no banco de dados.
              </td>
            </tr>
            <tr id="90dcc4a3-95a7-44d6-8e27-0c556dde72f9">
              <td id="eqz^" class="">Fluxo secundário:</td>
              <td id="g;XM" class="">
                O sistema deverá exibir os detalhes do cliente para consulta ao
                clicar em “detalhes” e também de editar o registro.
              </td>
            </tr>
          </tbody>
        </table>
        <p id="35bf11e9-5cc5-4a50-b7c5-34ae92547aa5" class="">
          <strong>Fonte</strong>: Própria Autoria
        </p>
        <p id="fcefe94f-d93f-4bcc-925b-1264739f5295" class=""></p>
        <p id="dc19fc5c-21e3-4098-b934-5ac1eb2208f3" class="">
          <strong>Quadro 3</strong> – Veículos
        </p>
        <table id="8f1f4b23-a4b2-4704-aebf-92256bde0138" class="simple-table">
          <tbody>
            <tr id="8a4908ef-8e15-43f2-a7c6-46d6617e28ec">
              <td id="O&gt;@m" class=""></td>
              <td id="ZonT" class="">Item #3</td>
            </tr>
            <tr id="59849323-dbce-40ee-bfdd-b5aa05cf583c">
              <td id="O&gt;@m" class="">Nome:</td>
              <td id="ZonT" class="">Cadastro de Consulta de Veículos.</td>
            </tr>
            <tr id="ba3061a1-64ca-4e0d-bde4-b909ece129bc">
              <td id="O&gt;@m" class="">Descrição:</td>
              <td id="ZonT" class="">
                O sistema deve ser capaz de criar o registro de um novo veículo
                e armazenar seus dados no banco de dados.
              </td>
            </tr>
            <tr id="69719aa8-ec34-4eab-9a93-34cd98edc591">
              <td id="O&gt;@m" class="">Prioridade:</td>
              <td id="ZonT" class="">Alta</td>
            </tr>
            <tr id="fbe6dce5-cb5a-4660-a446-421fd78c24c5">
              <td id="O&gt;@m" class="">Entradas e pré-condições:</td>
              <td id="ZonT" class="">
                Dados do veículo (Caso ainda não registrado). Registrar veículo
                logo após registrar um cliente novo.
              </td>
            </tr>
            <tr id="b58fafa4-943c-47f8-89b3-2ad168076f2e">
              <td id="O&gt;@m" class="">Saídas e pós-condições:</td>
              <td id="ZonT" class="">
                Veículo cadastrado no banco de dados e disponível para consulta.
              </td>
            </tr>
            <tr id="27ddfa8e-d54c-44e3-bbf2-8a6d1889a752">
              <td id="O&gt;@m" class="">Fluxo de eventos</td>
              <td id="ZonT" class=""></td>
            </tr>
            <tr id="2915ffbf-0149-4c23-8095-f3597757980e">
              <td id="O&gt;@m" class="">Fluxo principal:</td>
              <td id="ZonT" class="">
                1 - Selecionar a aba “Veículos”. Ou confirmar o registro de um
                novo cliente. 2 - Inserção dos dados de cadastro. 3 -
                Cadastramento no banco de dados.
              </td>
            </tr>
            <tr id="92622486-4be2-40ec-b10a-181f176b6937">
              <td id="O&gt;@m" class="">Fluxo secundário:</td>
              <td id="ZonT" class="">
                O sistema deverá exibir os detalhes do cliente para consulta ao
                clicar em “detalhes” e também de editar o registro.
              </td>
            </tr>
          </tbody>
        </table>
        <p id="2d259d2e-48dd-41e6-9591-035de04aa357" class="">
          <strong>Fonte</strong>: Própria Autoria
        </p>
        <p id="f15bb34e-11a4-4373-8c6c-398d1d073bf2" class=""></p>
        <p id="49f3c518-3178-4d90-86e6-edb8327d3a19" class="">
          <strong>Quadro 4</strong> – Apólice
        </p>
        <table id="4c49ada9-7144-4c07-add0-8ac64568b72b" class="simple-table">
          <tbody>
            <tr id="60e36eb3-9021-4860-a852-b66710d36f65">
              <td id="aocg" class=""></td>
              <td id="VEP}" class="">Item #4</td>
            </tr>
            <tr id="5c614161-8c21-4174-a229-96a3903a0b59">
              <td id="aocg" class="">Nome:</td>
              <td id="VEP}" class="">Cadastro de nova apólice.</td>
            </tr>
            <tr id="5ac78ea4-fd52-4a62-8697-b1ab8a40199c">
              <td id="aocg" class="">Descrição:</td>
              <td id="VEP}" class="">
                O sistema deve ser capaz de criar o registro de uma nova apólice
                referente à um novo cliente.
              </td>
            </tr>
            <tr id="897fd5e8-1cd0-4dcf-9d40-74e30af568ff">
              <td id="aocg" class="">Prioridade:</td>
              <td id="VEP}" class="">Alta</td>
            </tr>
            <tr id="2628dd1b-4e94-417e-bfcb-4f8eace43604">
              <td id="aocg" class="">Entradas e pré-condições:</td>
              <td id="VEP}" class="">
                Vigência do contrato, início e ID do veículo segurado. Deve ser
                realizado ao fechar contrato com um novo cliente.
              </td>
            </tr>
            <tr id="18d116ad-a484-4082-ae1a-da91a020b9a0">
              <td id="aocg" class="">Saídas e pós-condições:</td>
              <td id="VEP}" class="">
                Apólice cadastrado no banco de dados e disponível para consulta.
              </td>
            </tr>
            <tr id="a4f9c6e0-5688-43fe-8031-cafc1858e50b">
              <td id="aocg" class="">Fluxo de eventos</td>
              <td id="VEP}" class=""></td>
            </tr>
            <tr id="8cb59802-ed62-48bd-9cb5-980084db546c">
              <td id="aocg" class="">Fluxo principal:</td>
              <td id="VEP}" class="">
                1 - Selecionar a aba “Seguros(Apólice)”. Ou confirmar o registro
                de um novo veículo. 2 - Inserção dos dados de cadastro. 3 -
                Cadastramento no banco de dados.
              </td>
            </tr>
            <tr id="d5a375d4-43d5-4b10-8e4a-f3a81a05f0a5">
              <td id="aocg" class="">Fluxo secundário:</td>
              <td id="VEP}" class="">
                O sistema deverá exibir os detalhes do cliente para consulta ao
                clicar em “detalhes” e também de editar o registro.
              </td>
            </tr>
          </tbody>
        </table>
        <p id="b49a1334-60ae-404a-8e11-825e9ee70d97" class="">
          <strong>Fonte</strong>: Própria Autoria
        </p>
        <p id="458964ef-4885-497a-86cb-00c38d8e4c35" class=""></p>
        <p id="e415db70-199d-4e51-88d7-43d1594f45bf" class="">
          <strong>Quadro 5</strong> – Prestadores
        </p>
        <table id="d407fb9d-4f73-428c-9c10-c4de8eff3f02" class="simple-table">
          <tbody>
            <tr id="4d084e23-c908-479b-a10d-67c9c2237817">
              <td id="@U[g" class=""></td>
              <td id="xlFS" class="">Item #5</td>
            </tr>
            <tr id="04b010c2-29d9-4149-8137-85b2fe12e6ea">
              <td id="@U[g" class="">Nome:</td>
              <td id="xlFS" class="">Cadastro de Prestadores de Serviço.</td>
            </tr>
            <tr id="c79b147a-f0d5-41cc-a876-7aa5619f0981">
              <td id="@U[g" class="">Descrição:</td>
              <td id="xlFS" class="">
                O sistema deve ser capaz de criar o registro de um novo parceiro
                prestador de serviços.
              </td>
            </tr>
            <tr id="e8846ac7-5f86-46b3-a837-4dff88b3f33a">
              <td id="@U[g" class="">Prioridade:</td>
              <td id="xlFS" class="">Alta</td>
            </tr>
            <tr id="d765d2e5-4d05-42be-9931-2b06e8f9deed">
              <td id="@U[g" class="">Entradas e pré-condições:</td>
              <td id="xlFS" class="">
                Ao receber novos parceiros, deverá ser realizado seu cadastro no
                sistema, contenho seus dados como pessoa jurídica.
              </td>
            </tr>
            <tr id="50f67136-51c7-41c6-91ff-e39200621a59">
              <td id="@U[g" class="">Saídas e pós-condições:</td>
              <td id="xlFS" class="">
                Prestador cadastrado no banco de dados e disponível para
                consulta.
              </td>
            </tr>
            <tr id="46e1261d-95eb-41a7-8c86-06f493899252">
              <td id="@U[g" class="">Fluxo de eventos</td>
              <td id="xlFS" class=""></td>
            </tr>
            <tr id="975161c5-5a1f-4a82-b574-84dc3390bbac">
              <td id="@U[g" class="">Fluxo principal:</td>
              <td id="xlFS" class="">
                1 - Selecionar a aba “Prestadores”. Ou confirmar o registro de
                um novo seguro. 2 - Inserção dos dados de cadastro. 3 -
                Cadastramento no banco de dados.
              </td>
            </tr>
            <tr id="79f5f409-6a9b-4aa3-89e7-982bf5dc3898">
              <td id="@U[g" class="">Fluxo secundário:</td>
              <td id="xlFS" class="">
                O sistema deverá exibir os detalhes do prestador para consulta
                ao clicar em “detalhes” e também de editar o registro.
              </td>
            </tr>
          </tbody>
        </table>
        <p id="780f3768-fe55-412e-b260-071a5527b513" class="">
          <strong>Fonte</strong>: Própria Autoria
        </p>
        <p id="0ad3894e-7488-4455-abd8-559fb0fc73c9" class=""></p>
        <p id="5c616fb2-89b5-47ab-839d-4029a216753d" class="">
          <strong>Quadro 6</strong> – Sinistro
        </p>
        <table id="984321ee-1591-40be-a13b-3e65be80ddc2" class="simple-table">
          <tbody>
            <tr id="871f8a9d-e4a1-41a9-95b4-a8302b10ba1d">
              <td id="]IsZ" class=""></td>
              <td id="iQdv" class="">Item #6</td>
            </tr>
            <tr id="840a57d4-80bc-44f4-87e1-8e20e3c45664">
              <td id="]IsZ" class="">Nome:</td>
              <td id="iQdv" class="">Cadastro de novo sinistro.</td>
            </tr>
            <tr id="8466bf0b-5655-4613-bd43-ff67efb18037">
              <td id="]IsZ" class="">Descrição:</td>
              <td id="iQdv" class="">
                O sistema deve ser capaz de criar o registro de uma nova
                ocorrência com um veículo assegurado (sinistro).
              </td>
            </tr>
            <tr id="daf495de-2cb7-4052-820e-d32acbf968c1">
              <td id="]IsZ" class="">Prioridade:</td>
              <td id="iQdv" class="">Alta</td>
            </tr>
            <tr id="60f4c5be-dc06-49f2-bdf1-3109ee855925">
              <td id="]IsZ" class="">Entradas e pré-condições:</td>
              <td id="iQdv" class="">
                Ao receber uma nova ocorrência, deve-se realizar o registro da
                mesma no sistema.
              </td>
            </tr>
            <tr id="9e3277aa-62d4-4f77-8c37-4c20b19385e5">
              <td id="]IsZ" class="">Saídas e pós-condições:</td>
              <td id="iQdv" class="">
                Sinistro cadastrado no banco de dados e disponível para
                consulta.
              </td>
            </tr>
            <tr id="0c394c13-5a93-4b03-bf82-971f36889012">
              <td id="]IsZ" class="">Fluxo de eventos</td>
              <td id="iQdv" class=""></td>
            </tr>
            <tr id="d9594654-f614-4e3a-ba94-730d1ddc5a95">
              <td id="]IsZ" class="">Fluxo principal:</td>
              <td id="iQdv" class="">
                1 - Selecionar a aba “Sinistros”. Ou confirmar o registro de um
                novo prestador. 2 - Inserção dos dados de cadastro. 3 -
                Cadastramento no banco de dados.
              </td>
            </tr>
            <tr id="9af12b43-d3c2-4671-81f0-77acb967b04e">
              <td id="]IsZ" class="">Fluxo secundário:</td>
              <td id="iQdv" class="">
                O sistema deverá exibir os detalhes do sinistro para consulta ao
                clicar em “detalhes” e também de editar o registro.
              </td>
            </tr>
          </tbody>
        </table>
        <p id="11fbcb8e-ac19-46b9-b008-5ed37522c4b1" class="">
          <strong>Fonte</strong>: Própria Autoria
        </p>
        <p id="67900800-26b6-436d-b26e-1cb7818074bc" class=""></p>
        <p id="f4198cc9-cff1-4348-82be-002ac2955898" class="">
          <strong>Quadro 7</strong> – Fabricante
        </p>
        <table id="31de4079-d644-47e2-abad-5244445eb576" class="simple-table">
          <tbody>
            <tr id="dd30b6a1-97b6-4245-9477-06ce84805888">
              <td id="`gYe" class=""></td>
              <td id="INiA" class="">Item #7</td>
            </tr>
            <tr id="be30033c-ad05-454f-9b0a-2dc12be0f4a5">
              <td id="`gYe" class="">Nome:</td>
              <td id="INiA" class="">Cadastro de novo Fabricante.</td>
            </tr>
            <tr id="32b79e7d-69c4-4622-b551-1d35350c346a">
              <td id="`gYe" class="">Descrição:</td>
              <td id="INiA" class="">
                O sistema deve ser capaz de criar o registro de um novo
                fabricante.
              </td>
            </tr>
            <tr id="37d9ff95-afbc-4930-8c38-ceea0d026df7">
              <td id="`gYe" class="">Prioridade:</td>
              <td id="INiA" class="">Alta</td>
            </tr>
            <tr id="e156c98f-f9b0-4fb5-a8f2-a6379f872eac">
              <td id="`gYe" class="">Entradas e pré-condições:</td>
              <td id="INiA" class="">
                Caso falte um fabricantes no banco de dados do sistema, deverá
                ser inserido neste campo com apenas o nome do fabricante.
              </td>
            </tr>
            <tr id="e4bb00ad-2e6c-46f8-92c4-d9f79c2532b7">
              <td id="`gYe" class="">Saídas e pós-condições:</td>
              <td id="INiA" class="">
                Fabricante cadastrado no banco de dados e disponível para
                consulta.
              </td>
            </tr>
            <tr id="a508f088-62d1-4581-b133-88b34a225071">
              <td id="`gYe" class="">Fluxo de eventos</td>
              <td id="INiA" class=""></td>
            </tr>
            <tr id="3cf202cf-bdb5-48a2-98a1-663e0be64d84">
              <td id="`gYe" class="">Fluxo principal:</td>
              <td id="INiA" class="">
                1 - Selecionar a aba “Fabricante”. 2 - Inserção do nome do
                fabricante. 3 - Cadastramento no banco de dados.
              </td>
            </tr>
            <tr id="3f6a3ebe-3017-44ed-a2cc-7ff44dbf7c0a">
              <td id="`gYe" class="">Fluxo secundário:</td>
              <td id="INiA" class="">
                O sistema deverá exibir o fabricante para consulta ao clicar em
                “detalhes” e também de editar o registro.
              </td>
            </tr>
          </tbody>
        </table>
        <p id="69ffc9bf-3a94-4007-a7b0-22bc9ac12cd1" class="">
          <strong>Fonte</strong>: Própria Autoria
        </p>
        <p id="03b746ec-98a5-40db-9afa-b1d7d6a12b5c" class=""></p>
        <p id="ae1e7575-e30d-4d22-a376-363a478fa5be" class="">
          <strong>Quadro 8</strong> – Ano Modelo
        </p>
        <table id="5c669042-c5d7-49ec-bbd5-81c2aa42da0c" class="simple-table">
          <tbody>
            <tr id="82bc936a-be6a-439d-82f0-20800d700c7d">
              <td id="yKZi" class=""></td>
              <td id="oW_n" class="">Item #8</td>
            </tr>
            <tr id="71091123-9c2a-4791-b7d6-dbf05af03627">
              <td id="yKZi" class="">Nome:</td>
              <td id="oW_n" class="">Cadastro de ano de veículo</td>
            </tr>
            <tr id="02a47e42-72e2-495f-b1f4-513ec7da5247">
              <td id="yKZi" class="">Descrição:</td>
              <td id="oW_n" class="">
                A seguradora aceita apenas veículos de ano de lançamento entre
                2010 e 2022, nos seguintes anos deve ser cadastrado um novo ano
                de modelo.
              </td>
            </tr>
            <tr id="a2c2d0c6-0713-46a2-bd8f-4b452e4c5197">
              <td id="yKZi" class="">Prioridade:</td>
              <td id="oW_n" class="">Baixa</td>
            </tr>
            <tr id="ba744d36-ec72-4c2b-ac66-db75d4b00e56">
              <td id="yKZi" class="">Entradas e pré-condições:</td>
              <td id="oW_n" class="">
                Ao virar o ano, deve ser registrado um novo.
              </td>
            </tr>
            <tr id="b3819756-b1e0-4ae1-81c8-4b17db6fcfc6">
              <td id="yKZi" class="">Saídas e pós-condições:</td>
              <td id="oW_n" class="">Ano disponível para seleção.</td>
            </tr>
            <tr id="58f24945-8224-4988-9024-b844da5c1579">
              <td id="yKZi" class="">Fluxo de eventos</td>
              <td id="oW_n" class=""></td>
            </tr>
            <tr id="870392b8-c78c-4e6b-a4c4-d1c1b6134a29">
              <td id="yKZi" class="">Fluxo principal:</td>
              <td id="oW_n" class="">
                1 - Selecionar a aba “Ano dos Modelos”. 2 - Inserção do ano
                desejado. 3 - Cadastramento no banco de dados.
              </td>
            </tr>
            <tr id="78761199-2aae-44b1-bc66-df9756e64d8e">
              <td id="yKZi" class="">Fluxo secundário:</td>
              <td id="oW_n" class="">
                O sistema deverá disponibilizar o ano do veículo para seleção.
              </td>
            </tr>
          </tbody>
        </table>
        <p id="429c550d-a0db-4f54-ad43-36a51150a9c4" class="">
          <strong>Fonte</strong>: Própria Autoria
        </p>
        <p id="484e49c2-a751-4717-bca5-60a842dc1cda" class=""></p>
      </div>
    </article>

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

