<img src="https://th.bing.com/th/id/AfWNR5nBrzKPq9A480x360?&amp;rs=1&amp;pid=ImgDet" heigth="22px">

# Integração Pier x Zion

Documentação de APIs da Zion WMS com classes Model e exemplos de chamadas utilizando c# 


<a name="documentation-for-api-endpoints"></a>
## Endpoints


Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AutenticacaoApi* | [**AtualizarToken**](docs/AutenticacaoApi.md#atualizartoken) | **PUT** /v1/autenticacao/{refreshToken} | Atualiza validade do token
*AutenticacaoApi* | [**Autenticar**](docs/AutenticacaoApi.md#autenticar) | **POST** /v1/autenticacao | Solicita token
*AutenticacaoApi* | [**IsAdministrator**](docs/AutenticacaoApi.md#isadministrator) | **GET** /v1/autenticacao/usuarios/{usuario}/senhas/{senha} | 
*AutenticacaoApi* | [**LiberarLicencaUsuario**](docs/AutenticacaoApi.md#liberarlicencausuario) | **GET** /v1/autenticacao/usuarios/{usuario}/sistemas/{sistema}/liberar | Liberação da licença por usuário
*AutenticacaoApi* | [**Logout**](docs/AutenticacaoApi.md#logout) | **DELETE** /v1/autenticacao/{accessToken} | Liberação da licença por token
*AutenticacaoApi* | [**TrocarLicencaByCnpj**](docs/AutenticacaoApi.md#trocarlicencabycnpj) | **PUT** /v1/autenticacao/{refreshToken}/CNPJ/{cnpj} | Troca a licença específica de um CNPJ
*AutenticacaoApi* | [**ValidarToken**](docs/AutenticacaoApi.md#validartoken) | **GET** /v1/autenticacao/{accessToken} | Valida informações do token
*AutenticacaoApi* | [**VerificarTokenUsuario**](docs/AutenticacaoApi.md#verificartokenusuario) | **GET** /v1/autenticacao/usuarios/{usuario}/sistemas/{sistema}/token | Valida token x usuário
*DocumentosDeEntradaApi* | [**CountByQuery**](docs/DocumentosDeEntradaApi.md#countbyquery) | **GET** /v1/documentos-entrada/count | Conta os documentos de entrada. Filtrados através de uma query string
*DocumentosDeEntradaApi* | [**CountEstadoProcessoByQuery**](docs/DocumentosDeEntradaApi.md#countestadoprocessobyquery) | **GET** /v1/documentos-entrada/count-estado | Conta os estados de processo. Filtrados através de uma query string
*DocumentosDeEntradaApi* | [**FindById**](docs/DocumentosDeEntradaApi.md#findbyid) | **GET** /v1/documentos-entrada/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Retorna um documento de entrada  atravéz dos atributos identificadores
*DocumentosDeEntradaApi* | [**FindByIdFethLoteEntrada**](docs/DocumentosDeEntradaApi.md#findbyidfethloteentrada) | **GET** /v1/documentos-entrada/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada}/loteEntrada | Retorna um documento de entrada  atravéz dos atributos identificadores com sua lista de loteEntrada
*DocumentosDeEntradaApi* | [**FindByQuery**](docs/DocumentosDeEntradaApi.md#findbyquery) | **GET** /v1/documentos-entrada | Retorna os documentos de entrada. Filtrados através de uma query string
*DocumentosDeEntradaApi* | [**FindByQueryUploadEntrada**](docs/DocumentosDeEntradaApi.md#findbyqueryuploadentrada) | **GET** /v1/documentos-entrada/uploadEntrada | Retorna os documentos de entrada. Filtrados através de uma query string
*DocumentosDeEntradaApi* | [**FindEstadoProcessoByQuery**](docs/DocumentosDeEntradaApi.md#findestadoprocessobyquery) | **GET** /v1/documentos-entrada/query-estado | Retorna os estados de processo. Filtrados através de uma query string
*DocumentosDeEntradaApi* | [**FindProdutoConferenciaByQuery**](docs/DocumentosDeEntradaApi.md#findprodutoconferenciabyquery) | **GET** /v1/documentos-entrada/produtos-conferencia/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Retorna os produtos conferidos para um documento de saída confirmado
*DocumentosDeEntradaApi* | [**FindProdutoSaldoInicialByQuery**](docs/DocumentosDeEntradaApi.md#findprodutosaldoinicialbyquery) | **GET** /v1/documentos-entrada/produtos-saldo-inicial/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Retorna o saldo inicial dos produtos do documento de entrada
*DocumentosDeEntradaApi* | [**FindProdutoSaldoProdutoSerieByQuery**](docs/DocumentosDeEntradaApi.md#findprodutosaldoprodutoseriebyquery) | **GET** /v1/documentos-entrada/produtos-saldo-produtoserie/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Retorna o saldo inicial dos produtos e suas series do documento de entrada que está confirmado
*DocumentosDeEntradaApi* | [**Remove**](docs/DocumentosDeEntradaApi.md#remove) | **DELETE** /v1/documentos-entrada/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Exclui um documento de entrada
*DocumentosDeEntradaApi* | [**RemoveDEupload**](docs/DocumentosDeEntradaApi.md#removedeupload) | **DELETE** /v1/documentos-entrada/uploadEntrada/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Exclui um documento de entrada vindo de upload de arquivos
*DocumentosDeEntradaApi* | [**Update**](docs/DocumentosDeEntradaApi.md#update) | **PUT** /v1/documentos-entrada/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Altera um documento de entrada 
*DocumentosDeSaidaApi* | [**AtualizarDocumentoRelacionado**](docs/DocumentosDeSaidaApi.md#atualizardocumentorelacionado) | **PUT** /v1/documentos-saida/atualizar-documento-relacionado/{codigoEstabelecimento}/{tipoDocumento}/{serieDocumento}/{documentoOficialSaida}/{documentoRelacionado} | Atualiza o documento relacionado do Documento de Saída vinculado ao Documento Oficial de Saída
*DocumentosDeSaidaApi* | [**AtualizarTransportador**](docs/DocumentosDeSaidaApi.md#atualizartransportador) | **PUT** /v1/documentos-saida/atualizar-transportador/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Atualiza o transportador do Documento de Saída 
*DocumentosDeSaidaApi* | [**CountByQuery**](docs/DocumentosDeSaidaApi.md#countbyquery) | **GET** /v1/documentos-saida/count | Conta os documentos de saida. Filtrados através de uma query string
*DocumentosDeSaidaApi* | [**CountEstadoProcessoByQuery**](docs/DocumentosDeSaidaApi.md#countestadoprocessobyquery) | **GET** /v1/documentos-saida/count-estado | Conta os estados de processo. Filtrados através de uma query string
*DocumentosDeSaidaApi* | [**DivergenciaAtendimento**](docs/DocumentosDeSaidaApi.md#divergenciaatendimento) | **GET** /v1/documentos-saida/divergencia-atendimento/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna a divergência de atendimento do documento de saída. Considera as reservas realizadas e também o saldo baixado para atendimento das solicitações.
*DocumentosDeSaidaApi* | [**ExistsRomaneio**](docs/DocumentosDeSaidaApi.md#existsromaneio) | **GET** /v1/documentos-saida/possui-romaneio/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna se um documento de saida possui romaneio relacionado
*DocumentosDeSaidaApi* | [**FindByIdFethLoteSaida**](docs/DocumentosDeSaidaApi.md#findbyidfethlotesaida) | **GET** /v1/documentos-saida/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida}/loteSaida | Retorna um documento de saída  atravéz dos atributos identificadores com sua lista de loteSaida
*DocumentosDeSaidaApi* | [**FindByQuery**](docs/DocumentosDeSaidaApi.md#findbyquery) | **GET** /v1/documentos-saida | Retorna os documentos de saida. Filtrados através de uma query string
*DocumentosDeSaidaApi* | [**FindByQueryUploadSaida**](docs/DocumentosDeSaidaApi.md#findbyqueryuploadsaida) | **GET** /v1/documentos-saida/uploadSaida | Retorna os documentos de saída. Filtrados através de uma query string
*DocumentosDeSaidaApi* | [**FindDocumentoByID**](docs/DocumentosDeSaidaApi.md#finddocumentobyid) | **GET** /v1/documentos-saida/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna um documento de saida  atravéz dos atributos identificadores
*DocumentosDeSaidaApi* | [**FindEstadoProcessoByQuery**](docs/DocumentosDeSaidaApi.md#findestadoprocessobyquery) | **GET** /v1/documentos-saida/query-estado | Retorna os estados de processo. Filtrados através de uma query string
*DocumentosDeSaidaApi* | [**FindProdutoConferenciaByQuery**](docs/DocumentosDeSaidaApi.md#findprodutoconferenciabyquery) | **GET** /v1/documentos-saida/produtos-conferencia/{codigoEstabelecimento}/{codigoDepositante}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna os produtos conferidos para um documento de saída confirmado
*DocumentosDeSaidaApi* | [**FindProdutoConferenciaRealizadaByQuery**](docs/DocumentosDeSaidaApi.md#findprodutoconferenciarealizadabyquery) | **GET** /v1/documentos-saida/produtos-conferencia-realizada/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna os produtos conferidos para um documento de saída em execução
*DocumentosDeSaidaApi* | [**FindProdutoSaldoInicialByQuery**](docs/DocumentosDeSaidaApi.md#findprodutosaldoinicialbyquery) | **GET** /v1/documentos-saida/produtos-baixa/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna os produtos baixados para um documento de saída
*DocumentosDeSaidaApi* | [**FindProdutoSaldoProdutoSerieByQuery**](docs/DocumentosDeSaidaApi.md#findprodutosaldoprodutoseriebyquery) | **GET** /v1/documentos-saida/produtos-saldo-produtoserie/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna os produtos e suas series do documento de saída que está confirmado
*DocumentosDeSaidaApi* | [**RemoveDocumento**](docs/DocumentosDeSaidaApi.md#removedocumento) | **DELETE** /v1/documentos-saida/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Exclui um documento de saida
*DocumentosDeSaidaApi* | [**UpdateDocumento**](docs/DocumentosDeSaidaApi.md#updatedocumento) | **PUT** /v1/documentos-saida/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Altera um documento de saida 
*EmpresasApi* | [**CountByQuery**](docs/EmpresasApi.md#countbyquery) | **GET** /v1/empresas/count | Retorna quantidade das empresas cadastradas
*EmpresasApi* | [**CountTransportadoraByQuery**](docs/EmpresasApi.md#counttransportadorabyquery) | **GET** /v1/empresas/transportadoras/count | Retorna quantidade das transportadoras cadastradas
*EmpresasApi* | [**Create**](docs/EmpresasApi.md#create) | **POST** /v1/empresas | Adiciona uma nova empresa
*EmpresasApi* | [**FindByCNPJ**](docs/EmpresasApi.md#findbycnpj) | **GET** /v1/empresas/cnpjCpf/{CGCCPFEmpresa} | Retorna empresa por CNPJ/CPF
*EmpresasApi* | [**FindById**](docs/EmpresasApi.md#findbyid) | **GET** /v1/empresas/{codigoEmpresa} | Retorna empresa por código
*EmpresasApi* | [**FindByQuery**](docs/EmpresasApi.md#findbyquery) | **GET** /v1/empresas | Retorna todos as empresas cadastradas
*EmpresasApi* | [**FindTransportadoraByQuery**](docs/EmpresasApi.md#findtransportadorabyquery) | **GET** /v1/empresas/transportadoras | Retorna todas as transportadoras cadastradas
*EmpresasApi* | [**Remove**](docs/EmpresasApi.md#remove) | **DELETE** /v1/empresas/{codigoEmpresa} | Exclui uma empresa
*EmpresasApi* | [**Update**](docs/EmpresasApi.md#update) | **PUT** /v1/empresas/{codigoEmpresa} | Altera uma empresa
*EstoqueApi* | [**FindConsultaSaldoResumo**](docs/EstoqueApi.md#findconsultasaldoresumo) | **GET** /v1/estoque/consulta/saldo/resumo/{codigoEstabelecimento}/{codigoDepositante} | 
*EstoqueApi* | [**FindDetailed**](docs/EstoqueApi.md#finddetailed) | **GET** /v1/estoque/detalhe/{codigoEstabelecimento}/{codigoDepositante} | 
*EstoqueApi* | [**FindGrouped**](docs/EstoqueApi.md#findgrouped) | **GET** /v1/estoque/{codigoEstabelecimento}/{codigoDepositante} | 
*InventrioAtravsDoBancoIntermedirioOraintApi* | [**FindByPendente**](docs/InventrioAtravsDoBancoIntermedirioOraintApi.md#findbypendente) | **GET** /v1/oraint/inventario/{codigoEstabelecimento}/{codigoDepositante} | Retorna lista de Inventários do Oraint pendentes de processamento.
*InventrioAtravsDoBancoIntermedirioOraintApi* | [**Update**](docs/InventrioAtravsDoBancoIntermedirioOraintApi.md#update) | **POST** /v1/oraint/inventario/{codigoEstabelecimento}/{codigoDepositante} | Atualiza o estado da integração de inventário.
*MovimentaoDeUAComTrocaDeClasseApi* | [**MovimentacaoComTrocaDeClasse**](docs/MovimentaoDeUAComTrocaDeClasseApi.md#movimentacaocomtrocadeclasse) | **POST** /v1/movimentacao/{codigoEstabelecimento}/{codigoDepositante}/movimenta-troca-classe | Realiza a movimentação de endereços de um endereço de origem para um de destino através de rotina de movimentçaão e faz a troca de classe através do banco intermediário.
*MovimentaoDeUAComTrocaDeClasseAtravsDoBancoIntermedirioOraintApi* | [**Create**](docs/MovimentaoDeUAComTrocaDeClasseAtravsDoBancoIntermedirioOraintApi.md#create) | **POST** /v2/oraint/movimentoEstoque/{codigoEstabelecimento}/{codigoDepositante} | Adiciona um novo Movimento Estoque no Store ORAINT que será executado pela integração 341 (Movimentação Total) ou 342 (Movimentação por quantidade informada)
*PrevisaoDeEntradaApi* | [**CreatePrevisaoEntrada**](docs/PrevisaoDeEntradaApi.md#createprevisaoentrada) | **POST** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada} | Adiciona uma nova previsão de entrada
*PrevisaoDeEntradaApi* | [**FindAll**](docs/PrevisaoDeEntradaApi.md#findall) | **GET** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante} | Retorna as Previsões de Entrada do Depositante
*PrevisaoDeEntradaApi* | [**FindPrevisaoEntradaByID**](docs/PrevisaoDeEntradaApi.md#findprevisaoentradabyid) | **GET** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada} | Retorna Previsão de Entrada e itens por Empresa/Tipo/Série/Número
*PrevisaoDeEntradaApi* | [**RemovePrevisaoEntrada**](docs/PrevisaoDeEntradaApi.md#removeprevisaoentrada) | **DELETE** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada} | Exclui uma previsão de entrada
*PrevisaoDeEntradaApi* | [**RemoverItem**](docs/PrevisaoDeEntradaApi.md#removeritem) | **DELETE** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada}/itens | Exclui uma previsão de entrada e seus itens
*PrevisaoDeEntradaApi* | [**UpdatePrevisaoEntrada**](docs/PrevisaoDeEntradaApi.md#updateprevisaoentrada) | **PUT** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada} | Altera uma previsão de entrada
*PrevisaoDeEntradaItemApi* | [**CountByQuery**](docs/PrevisaoDeEntradaItemApi.md#countbyquery) | **GET** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/count | 
*PrevisaoDeEntradaItemApi* | [**CountByQuery_0**](docs/PrevisaoDeEntradaItemApi.md#countbyquery_0) | **GET** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada}/count | 
*PrevisaoDeEntradaItemApi* | [**Create**](docs/PrevisaoDeEntradaItemApi.md#create) | **POST** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa} | 
*PrevisaoDeEntradaItemApi* | [**FindAll**](docs/PrevisaoDeEntradaItemApi.md#findall) | **GET** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada} | Retorna todos os itens de uma previsão de entrada
*PrevisaoDeEntradaItemApi* | [**FindById**](docs/PrevisaoDeEntradaItemApi.md#findbyid) | **GET** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada}/{sequenciaPrevisaoEntrada} | 
*PrevisaoDeEntradaItemApi* | [**FindByQuery**](docs/PrevisaoDeEntradaItemApi.md#findbyquery) | **GET** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante} | 
*PrevisaoDeEntradaItemApi* | [**Remove**](docs/PrevisaoDeEntradaItemApi.md#remove) | **DELETE** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada}/{sequenciaPrevisaoEntrada} | 
*PrevisaoDeEntradaItemApi* | [**Update**](docs/PrevisaoDeEntradaItemApi.md#update) | **PUT** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada}/{sequenciaPrevisaoEntrada} | 
*PrevisaoDeSaidaApi* | [**CountByQuery**](docs/PrevisaoDeSaidaApi.md#countbyquery) | **GET** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/count | 
*PrevisaoDeSaidaApi* | [**CreatePrevisaoSaida**](docs/PrevisaoDeSaidaApi.md#createprevisaosaida) | **POST** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Adiciona uma nova previsão de saida
*PrevisaoDeSaidaApi* | [**DivergenciaAtendimento**](docs/PrevisaoDeSaidaApi.md#divergenciaatendimento) | **GET** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/divergencia-atendimento/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Retorna a divergência de atendimento da previsão de saída. Considera as reservas realizadas e também o saldo baixado para atendimento das solicitações.
*PrevisaoDeSaidaApi* | [**FindAll**](docs/PrevisaoDeSaidaApi.md#findall) | **GET** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante} | 
*PrevisaoDeSaidaApi* | [**FindPrevisaoSaidaByID**](docs/PrevisaoDeSaidaApi.md#findprevisaosaidabyid) | **GET** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Retorna previsão de saída por Empresa/Tipo/Série/Número
*PrevisaoDeSaidaApi* | [**Remove**](docs/PrevisaoDeSaidaApi.md#remove) | **DELETE** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida}/{sequenciaPrevisaoSaida} | 
*PrevisaoDeSaidaApi* | [**RemovePrevisaoSaida**](docs/PrevisaoDeSaidaApi.md#removeprevisaosaida) | **DELETE** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Exclui uma previsão de saída
*PrevisaoDeSaidaApi* | [**UpdatePrevisaoSaida**](docs/PrevisaoDeSaidaApi.md#updateprevisaosaida) | **PUT** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Altera uma previsão de saída
*PrevisaoDeSaidaItemApi* | [**CountByQuery**](docs/PrevisaoDeSaidaItemApi.md#countbyquery) | **GET** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/count | 
*PrevisaoDeSaidaItemApi* | [**CountByQuery_0**](docs/PrevisaoDeSaidaItemApi.md#countbyquery_0) | **GET** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida}/count | 
*PrevisaoDeSaidaItemApi* | [**Create**](docs/PrevisaoDeSaidaItemApi.md#create) | **POST** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante} | 
*PrevisaoDeSaidaItemApi* | [**FindAll**](docs/PrevisaoDeSaidaItemApi.md#findall) | **GET** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Retorna todos os itens de uma previsão de saída
*PrevisaoDeSaidaItemApi* | [**FindById**](docs/PrevisaoDeSaidaItemApi.md#findbyid) | **GET** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida}/{sequenciaPrevisaoSaida} | 
*PrevisaoDeSaidaItemApi* | [**FindByQuery**](docs/PrevisaoDeSaidaItemApi.md#findbyquery) | **GET** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante} | 
*PrevisaoDeSaidaItemApi* | [**Remove**](docs/PrevisaoDeSaidaItemApi.md#remove) | **DELETE** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida}/{sequenciaPrevisaoSaida} | 
*PrevisaoDeSaidaItemApi* | [**Update**](docs/PrevisaoDeSaidaItemApi.md#update) | **PUT** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida}/{sequenciaPrevisaoSaida} | 
*ProdutosApi* | [**CountByQuery**](docs/ProdutosApi.md#countbyquery) | **GET** /v1/produtos/{codigoDepositante}/count | Retorna quantidade de depositantes cadastradas
*ProdutosApi* | [**Create**](docs/ProdutosApi.md#create) | **POST** /v1/produtos/{codigoDepositante} | Adiciona um novo produto
*ProdutosApi* | [**FindByDepositante**](docs/ProdutosApi.md#findbydepositante) | **GET** /v1/produtos/{codigoDepositante} | Retorna todos os produtos cadastrados de um Depositante
*ProdutosApi* | [**FindById**](docs/ProdutosApi.md#findbyid) | **GET** /v1/produtos/{codigoDepositante}/{codigoProduto} | Retorna produto de um Depositante
*ProdutosApi* | [**Remove**](docs/ProdutosApi.md#remove) | **DELETE** /v1/produtos/{codigoDepositante}/{codigoProduto} | Exclui um produto
*ProdutosApi* | [**Update**](docs/ProdutosApi.md#update) | **PUT** /v1/produtos/{codigoDepositante}/{codigoProduto} | Altera um produto
*ProdutosRelacionadosApi* | [**CountByQuery**](docs/ProdutosRelacionadosApi.md#countbyquery) | **GET** /v1/produtos-relacionados/count | Conta os produtos relacionados. Filtrados através de uma query string
*ProdutosRelacionadosApi* | [**Create**](docs/ProdutosRelacionadosApi.md#create) | **POST** /v1/produtos-relacionados | Relaciona um produto
*ProdutosRelacionadosApi* | [**FindById**](docs/ProdutosRelacionadosApi.md#findbyid) | **GET** /v1/produtos-relacionados/{codigoEmpresa}/{codigoProduto}/{tipoUc}/{codigoProdutoRelacionado} | Retorna o produto relacionado através dos atributos identificadores
*ProdutosRelacionadosApi* | [**FindByQuery**](docs/ProdutosRelacionadosApi.md#findbyquery) | **GET** /v1/produtos-relacionados | Retorna os produtos relacionados. Filtrados através de uma query string
*ProdutosRelacionadosApi* | [**Remove**](docs/ProdutosRelacionadosApi.md#remove) | **DELETE** /v1/produtos-relacionados/{codigoEmpresa}/{codigoProduto}/{tipoUc}/{codigoProdutoRelacionado} | Exclui uma relação de produto
*ProdutosRelacionadosApi* | [**Update**](docs/ProdutosRelacionadosApi.md#update) | **PUT** /v1/produtos-relacionados/{codigoEmpresa}/{codigoProduto}/{tipoUc}/{codigoProdutoRelacionado} | Altera o relacionamento de um produto
*RcqApi* | [**CountByQuery**](docs/RcqApi.md#countbyquery) | **GET** /v1/rcq/count | Retorna quantidade de RCQs cadastrados
*RcqApi* | [**FindByEstDep**](docs/RcqApi.md#findbyestdep) | **GET** /v1/rcq/data-emissao-atual/{codigoEstabelecimento}/{codigoDepositante} | Retorna uma lista de RCQs emitidos com Data Emissão no dia corrente
*RcqApi* | [**FindByNumeroMovimento**](docs/RcqApi.md#findbynumeromovimento) | **GET** /v1/rcq/{codigoEstabelecimento}/{codigoDepositante}/{numeroMovimento} | Retorna lista de RCQs pelo Número Movimento
*RcqApi* | [**FindByQuery**](docs/RcqApi.md#findbyquery) | **GET** /v1/rcq | Retorna os RCQs filtrados através de uma query string
*TipoCodigoBarraApi* | [**CountByQuery**](docs/TipoCodigoBarraApi.md#countbyquery) | **GET** /v1/tipoCodigoBarra/count | Retorna quantidade Tipo Código Barras cadastrados
*TipoCodigoBarraApi* | [**FindByQuery**](docs/TipoCodigoBarraApi.md#findbyquery) | **GET** /v1/tipoCodigoBarra | Retorna Tipo Codigo Barra relacionado. Filtrados através de uma query string
*TipoUCApi* | [**CountByQuery**](docs/TipoUCApi.md#countbyquery) | **GET** /v1/tipoUc/{codigoEmpresa}/{codigoProduto}/count | Retorna quantidade de TipoUcs cadastrados
*TipoUCApi* | [**Create**](docs/TipoUCApi.md#create) | **POST** /v1/tipoUc/{codigoEmpresa}/{codigoProduto} | Adiciona um novo Tipo UC
*TipoUCApi* | [**FindById**](docs/TipoUCApi.md#findbyid) | **GET** /v1/tipoUc/{codigoEmpresa}/{codigoProduto}/{tipoUc} | Retorna especificamente um Tipo UC
*TipoUCApi* | [**FindByProduto**](docs/TipoUCApi.md#findbyproduto) | **GET** /v1/tipoUc/{codigoEmpresa}/{codigoProduto} | Retorna lista de Tipo UC de um produto
*TipoUCApi* | [**Remove**](docs/TipoUCApi.md#remove) | **DELETE** /v1/tipoUc/{codigoEmpresa}/{codigoProduto}/{tipoUc} | Exclui um Tipo UC
*TipoUCApi* | [**Update**](docs/TipoUCApi.md#update) | **PUT** /v1/tipoUc/{codigoEmpresa}/{codigoProduto}/{tipoUc} | Altera um Tipo UC
*TrocaDeCabealhoOuTrocaDoPedidoPelaNotaFiscalNFeApi* | [**TrocaPedidoPorNotaFiscal**](docs/TrocaDeCabealhoOuTrocaDoPedidoPelaNotaFiscalNFeApi.md#trocapedidopornotafiscal) | **POST** /v1/troca-pedido-notafiscal/{codigoEstabelecimento}/{codigoDepositante} | Realiza a substituição do pedido origem pela nota fiscal. O pedido origem é cancelado passando todas suas dependencias para o documento NFe que será gerado através do xml enviado na requisição.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Autenticacao](docs/Autenticacao.md)
 - [Model.Categoria](docs/Categoria.md)
 - [Model.CategoriaDTO](docs/CategoriaDTO.md)
 - [Model.ClasseProduto](docs/ClasseProduto.md)
 - [Model.ClasseProdutoDTO](docs/ClasseProdutoDTO.md)
 - [Model.CnaeFiscal](docs/CnaeFiscal.md)
 - [Model.CnaeFiscalDTO](docs/CnaeFiscalDTO.md)
 - [Model.CodigoEnquadramentoIpi](docs/CodigoEnquadramentoIpi.md)
 - [Model.CodigoEnquadramentoIpiDTO](docs/CodigoEnquadramentoIpiDTO.md)
 - [Model.DocumentoEntrada](docs/DocumentoEntrada.md)
 - [Model.DocumentoEntradaDTO](docs/DocumentoEntradaDTO.md)
 - [Model.DocumentoOficialEntrada](docs/DocumentoOficialEntrada.md)
 - [Model.DocumentoOficialEntradaDTO](docs/DocumentoOficialEntradaDTO.md)
 - [Model.DocumentoOficialEntradaItem](docs/DocumentoOficialEntradaItem.md)
 - [Model.DocumentoOficialEntradaItemDTO](docs/DocumentoOficialEntradaItemDTO.md)
 - [Model.DocumentoOficialEntradaLoteEntDTO](docs/DocumentoOficialEntradaLoteEntDTO.md)
 - [Model.DocumentoProdutoSerieDTO](docs/DocumentoProdutoSerieDTO.md)
 - [Model.DocumentoSaida](docs/DocumentoSaida.md)
 - [Model.Empresa](docs/Empresa.md)
 - [Model.EmpresaDTO](docs/EmpresaDTO.md)
 - [Model.EnderecoEmpresa](docs/EnderecoEmpresa.md)
 - [Model.Estabelecimento](docs/Estabelecimento.md)
 - [Model.EstabelecimentoDTO](docs/EstabelecimentoDTO.md)
 - [Model.EstadoProcesso](docs/EstadoProcesso.md)
 - [Model.EstadoProcessoDTO](docs/EstadoProcessoDTO.md)
 - [Model.FinalidadeDocumento](docs/FinalidadeDocumento.md)
 - [Model.FinalidadeDocumentoDTO](docs/FinalidadeDocumentoDTO.md)
 - [Model.FinalidadeDocumentoPK](docs/FinalidadeDocumentoPK.md)
 - [Model.Grupo](docs/Grupo.md)
 - [Model.GrupoDTO](docs/GrupoDTO.md)
 - [Model.GrupoEmpresa](docs/GrupoEmpresa.md)
 - [Model.Iata](docs/Iata.md)
 - [Model.IndicadorIE](docs/IndicadorIE.md)
 - [Model.IndicadorIEDTO](docs/IndicadorIEDTO.md)
 - [Model.Linha](docs/Linha.md)
 - [Model.LinhaDTO](docs/LinhaDTO.md)
 - [Model.Localidade](docs/Localidade.md)
 - [Model.LoteEntrada](docs/LoteEntrada.md)
 - [Model.LoteEntradaDTO](docs/LoteEntradaDTO.md)
 - [Model.LoteProdutoSerieDTO](docs/LoteProdutoSerieDTO.md)
 - [Model.LoteSaida](docs/LoteSaida.md)
 - [Model.MovimentoEstoqueDTO](docs/MovimentoEstoqueDTO.md)
 - [Model.NaturezaOperacao](docs/NaturezaOperacao.md)
 - [Model.NaturezaOperacaoDTO](docs/NaturezaOperacaoDTO.md)
 - [Model.NfeAmbiente](docs/NfeAmbiente.md)
 - [Model.NfeAmbienteDTO](docs/NfeAmbienteDTO.md)
 - [Model.NfeTipoEmissao](docs/NfeTipoEmissao.md)
 - [Model.NfeTipoEmissaoDTO](docs/NfeTipoEmissaoDTO.md)
 - [Model.NfeTipoImpressao](docs/NfeTipoImpressao.md)
 - [Model.NfeTipoImpressaoDTO](docs/NfeTipoImpressaoDTO.md)
 - [Model.NotaFiscal](docs/NotaFiscal.md)
 - [Model.OrigemProduto](docs/OrigemProduto.md)
 - [Model.OrigemProdutoDTO](docs/OrigemProdutoDTO.md)
 - [Model.Pais](docs/Pais.md)
 - [Model.ParametroMovimentaTrocaClasseDTO](docs/ParametroMovimentaTrocaClasseDTO.md)
 - [Model.PrevisaoEntradaDTO](docs/PrevisaoEntradaDTO.md)
 - [Model.PrevisaoEntradaItemDTO](docs/PrevisaoEntradaItemDTO.md)
 - [Model.PrevisaoSaidaDTO](docs/PrevisaoSaidaDTO.md)
 - [Model.PrevisaoSaidaItemDTO](docs/PrevisaoSaidaItemDTO.md)
 - [Model.Produto](docs/Produto.md)
 - [Model.ProdutoBaixaDTO](docs/ProdutoBaixaDTO.md)
 - [Model.ProdutoDTO](docs/ProdutoDTO.md)
 - [Model.ProdutoNcm](docs/ProdutoNcm.md)
 - [Model.ProdutoNcmDTO](docs/ProdutoNcmDTO.md)
 - [Model.ProdutoRelacionado](docs/ProdutoRelacionado.md)
 - [Model.ProdutoRelacionadoDTO](docs/ProdutoRelacionadoDTO.md)
 - [Model.ProdutoRevisaoComponenteDTO](docs/ProdutoRevisaoComponenteDTO.md)
 - [Model.ProdutoRevisaoDTO](docs/ProdutoRevisaoDTO.md)
 - [Model.ProdutoSaldoInicialDTO](docs/ProdutoSaldoInicialDTO.md)
 - [Model.ProdutoSerieDTO](docs/ProdutoSerieDTO.md)
 - [Model.PublicoAlvo](docs/PublicoAlvo.md)
 - [Model.PublicoAlvoDTO](docs/PublicoAlvoDTO.md)
 - [Model.RegiaoContinente](docs/RegiaoContinente.md)
 - [Model.SitTributariaIcms](docs/SitTributariaIcms.md)
 - [Model.SitTributariaIcmsDTO](docs/SitTributariaIcmsDTO.md)
 - [Model.SitTributariaOrigem](docs/SitTributariaOrigem.md)
 - [Model.SitTributariaOrigemDTO](docs/SitTributariaOrigemDTO.md)
 - [Model.SituacaoTributariaIpi](docs/SituacaoTributariaIpi.md)
 - [Model.SituacaoTributariaIpiDTO](docs/SituacaoTributariaIpiDTO.md)
 - [Model.SubGrupo](docs/SubGrupo.md)
 - [Model.SubGrupoDTO](docs/SubGrupoDTO.md)
 - [Model.TabelaFiscal](docs/TabelaFiscal.md)
 - [Model.TabelaServico](docs/TabelaServico.md)
 - [Model.TabelaServicoDTO](docs/TabelaServicoDTO.md)
 - [Model.TipoBaixa](docs/TipoBaixa.md)
 - [Model.TipoCodigoBarra](docs/TipoCodigoBarra.md)
 - [Model.TipoCodigoBarraDTO](docs/TipoCodigoBarraDTO.md)
 - [Model.TipoDocumentoFiscal](docs/TipoDocumentoFiscal.md)
 - [Model.TipoEmpresa](docs/TipoEmpresa.md)
 - [Model.TipoEmpresaDTO](docs/TipoEmpresaDTO.md)
 - [Model.TipoLocalidade](docs/TipoLocalidade.md)
 - [Model.TipoPais](docs/TipoPais.md)
 - [Model.TipoUc](docs/TipoUc.md)
 - [Model.TipoUcDTO](docs/TipoUcDTO.md)
 - [Model.UnidadeFederativa](docs/UnidadeFederativa.md)
 - [Model.UnidadeFederativaDTO](docs/UnidadeFederativaDTO.md)
 - [Model.WmasMundialResult](docs/WmasMundialResult.md)
 - [Model.XInventarioDTO](docs/XInventarioDTO.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
