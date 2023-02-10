# IO.Swagger.Api.EstoqueApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindConsultaSaldoResumo**](EstoqueApi.md#findconsultasaldoresumo) | **GET** /v1/estoque/consulta/saldo/resumo/{codigoEstabelecimento}/{codigoDepositante} | 
[**FindDetailed**](EstoqueApi.md#finddetailed) | **GET** /v1/estoque/detalhe/{codigoEstabelecimento}/{codigoDepositante} | 
[**FindGrouped**](EstoqueApi.md#findgrouped) | **GET** /v1/estoque/{codigoEstabelecimento}/{codigoDepositante} | 


<a name="findconsultasaldoresumo"></a>
# **FindConsultaSaldoResumo**
> void FindConsultaSaldoResumo (long? codigoEstabelecimento, string codigoDepositante, long? endereco = null, string etiquetaEndereco = null, long? codigoUa = null, string codigoProduto = null, string classeProduto = null, string loteFabricacao = null, DateTime? dataFabricacao = null, DateTime? dataVencimento = null, string loteGeral = null, string codigoEmpresa = null, string tipoDocumento = null, string serieDocumento = null, string documentoEntrada = null, long? loteEntrada = null, DateTime? dataFabricacaoInicial = null, DateTime? dataFabricacaoFinal = null, DateTime? dataVencimentoInicial = null, DateTime? dataVencimentoFinal = null, long? loteEntradaSequencia = null, string descricaoProduto = null, bool? apenasEnderecoDisponivelSaida = null, bool? checkarNecessidadeOficialSaida = null, bool? apenasLoteEntradaConfirmado = null, bool? excluirTipoEnderecoIntermediario = null, bool? excluirClasseDivergenciaDepositante = null, List<string> groupBy = null, long? limit = null, long? offset = null)



Os tipos de dados string desse método devem ser informados em caixa alta (maiúsculo)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FindConsultaSaldoResumoExample
    {
        public void main()
        {
            var apiInstance = new EstoqueApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var endereco = 789;  // long? |  (optional) 
            var etiquetaEndereco = etiquetaEndereco_example;  // string |  (optional) 
            var codigoUa = 789;  // long? |  (optional) 
            var codigoProduto = codigoProduto_example;  // string |  (optional) 
            var classeProduto = classeProduto_example;  // string |  (optional) 
            var loteFabricacao = loteFabricacao_example;  // string |  (optional) 
            var dataFabricacao = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataVencimento = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var loteGeral = loteGeral_example;  // string |  (optional) 
            var codigoEmpresa = codigoEmpresa_example;  // string |  (optional) 
            var tipoDocumento = tipoDocumento_example;  // string |  (optional) 
            var serieDocumento = serieDocumento_example;  // string |  (optional) 
            var documentoEntrada = documentoEntrada_example;  // string |  (optional) 
            var loteEntrada = 789;  // long? |  (optional) 
            var dataFabricacaoInicial = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataFabricacaoFinal = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataVencimentoInicial = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataVencimentoFinal = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var loteEntradaSequencia = 789;  // long? |  (optional) 
            var descricaoProduto = descricaoProduto_example;  // string |  (optional) 
            var apenasEnderecoDisponivelSaida = true;  // bool? |  (optional) 
            var checkarNecessidadeOficialSaida = true;  // bool? |  (optional) 
            var apenasLoteEntradaConfirmado = true;  // bool? |  (optional) 
            var excluirTipoEnderecoIntermediario = true;  // bool? |  (optional) 
            var excluirClasseDivergenciaDepositante = true;  // bool? |  (optional) 
            var groupBy = groupBy_example;  // List<string> |  (optional) 
            var limit = 789;  // long? |  (optional)  (default to 50)
            var offset = 789;  // long? |  (optional)  (default to 0)

            try
            {
                apiInstance.FindConsultaSaldoResumo(codigoEstabelecimento, codigoDepositante, endereco, etiquetaEndereco, codigoUa, codigoProduto, classeProduto, loteFabricacao, dataFabricacao, dataVencimento, loteGeral, codigoEmpresa, tipoDocumento, serieDocumento, documentoEntrada, loteEntrada, dataFabricacaoInicial, dataFabricacaoFinal, dataVencimentoInicial, dataVencimentoFinal, loteEntradaSequencia, descricaoProduto, apenasEnderecoDisponivelSaida, checkarNecessidadeOficialSaida, apenasLoteEntradaConfirmado, excluirTipoEnderecoIntermediario, excluirClasseDivergenciaDepositante, groupBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EstoqueApi.FindConsultaSaldoResumo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoDepositante** | **string**|  | 
 **endereco** | **long?**|  | [optional] 
 **etiquetaEndereco** | **string**|  | [optional] 
 **codigoUa** | **long?**|  | [optional] 
 **codigoProduto** | **string**|  | [optional] 
 **classeProduto** | **string**|  | [optional] 
 **loteFabricacao** | **string**|  | [optional] 
 **dataFabricacao** | **DateTime?**|  | [optional] 
 **dataVencimento** | **DateTime?**|  | [optional] 
 **loteGeral** | **string**|  | [optional] 
 **codigoEmpresa** | **string**|  | [optional] 
 **tipoDocumento** | **string**|  | [optional] 
 **serieDocumento** | **string**|  | [optional] 
 **documentoEntrada** | **string**|  | [optional] 
 **loteEntrada** | **long?**|  | [optional] 
 **dataFabricacaoInicial** | **DateTime?**|  | [optional] 
 **dataFabricacaoFinal** | **DateTime?**|  | [optional] 
 **dataVencimentoInicial** | **DateTime?**|  | [optional] 
 **dataVencimentoFinal** | **DateTime?**|  | [optional] 
 **loteEntradaSequencia** | **long?**|  | [optional] 
 **descricaoProduto** | **string**|  | [optional] 
 **apenasEnderecoDisponivelSaida** | **bool?**|  | [optional] 
 **checkarNecessidadeOficialSaida** | **bool?**|  | [optional] 
 **apenasLoteEntradaConfirmado** | **bool?**|  | [optional] 
 **excluirTipoEnderecoIntermediario** | **bool?**|  | [optional] 
 **excluirClasseDivergenciaDepositante** | **bool?**|  | [optional] 
 **groupBy** | **List&lt;string&gt;**|  | [optional] 
 **limit** | **long?**|  | [optional] [default to 50]
 **offset** | **long?**|  | [optional] [default to 0]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="finddetailed"></a>
# **FindDetailed**
> void FindDetailed (long? codigoEstabelecimento, string codigoDepositante, long? endereco = null, string etiquetaEndereco = null, long? codigoUa = null, string codigoProduto = null, string classeProduto = null, string loteFabricacao = null, DateTime? dataFabricacao = null, DateTime? dataVencimento = null, string loteGeral = null, string codigoEmpresa = null, string tipoDocumento = null, string serieDocumento = null, string documentoEntrada = null, long? loteEntrada = null, DateTime? dataFabricacaoInicial = null, DateTime? dataFabricacaoFinal = null, DateTime? dataVencimentoInicial = null, DateTime? dataVencimentoFinal = null, long? loteEntradaSequencia = null, string descricaoProduto = null, bool? apenasEnderecoDisponivelSaida = null, bool? checkarNecessidadeOficialSaida = null, bool? apenasLoteEntradaConfirmado = null, bool? excluirTipoEnderecoIntermediario = null, bool? excluirClasseDivergenciaDepositante = null, int? tipoBaixaParaOrdenacao = null, int? tipoBaixaSecundarioParaOrdenacao = null, long? limit = null, long? offset = null)



Os tipos de dados string desse método devem ser informados em caixa alta (maiúsculo)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FindDetailedExample
    {
        public void main()
        {
            var apiInstance = new EstoqueApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var endereco = 789;  // long? |  (optional) 
            var etiquetaEndereco = etiquetaEndereco_example;  // string |  (optional) 
            var codigoUa = 789;  // long? |  (optional) 
            var codigoProduto = codigoProduto_example;  // string |  (optional) 
            var classeProduto = classeProduto_example;  // string |  (optional) 
            var loteFabricacao = loteFabricacao_example;  // string |  (optional) 
            var dataFabricacao = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataVencimento = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var loteGeral = loteGeral_example;  // string |  (optional) 
            var codigoEmpresa = codigoEmpresa_example;  // string |  (optional) 
            var tipoDocumento = tipoDocumento_example;  // string |  (optional) 
            var serieDocumento = serieDocumento_example;  // string |  (optional) 
            var documentoEntrada = documentoEntrada_example;  // string |  (optional) 
            var loteEntrada = 789;  // long? |  (optional) 
            var dataFabricacaoInicial = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataFabricacaoFinal = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataVencimentoInicial = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataVencimentoFinal = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var loteEntradaSequencia = 789;  // long? |  (optional) 
            var descricaoProduto = descricaoProduto_example;  // string |  (optional) 
            var apenasEnderecoDisponivelSaida = true;  // bool? |  (optional) 
            var checkarNecessidadeOficialSaida = true;  // bool? |  (optional) 
            var apenasLoteEntradaConfirmado = true;  // bool? |  (optional) 
            var excluirTipoEnderecoIntermediario = true;  // bool? |  (optional) 
            var excluirClasseDivergenciaDepositante = true;  // bool? |  (optional) 
            var tipoBaixaParaOrdenacao = 56;  // int? |  (optional) 
            var tipoBaixaSecundarioParaOrdenacao = 56;  // int? |  (optional) 
            var limit = 789;  // long? |  (optional)  (default to 50)
            var offset = 789;  // long? |  (optional)  (default to 0)

            try
            {
                apiInstance.FindDetailed(codigoEstabelecimento, codigoDepositante, endereco, etiquetaEndereco, codigoUa, codigoProduto, classeProduto, loteFabricacao, dataFabricacao, dataVencimento, loteGeral, codigoEmpresa, tipoDocumento, serieDocumento, documentoEntrada, loteEntrada, dataFabricacaoInicial, dataFabricacaoFinal, dataVencimentoInicial, dataVencimentoFinal, loteEntradaSequencia, descricaoProduto, apenasEnderecoDisponivelSaida, checkarNecessidadeOficialSaida, apenasLoteEntradaConfirmado, excluirTipoEnderecoIntermediario, excluirClasseDivergenciaDepositante, tipoBaixaParaOrdenacao, tipoBaixaSecundarioParaOrdenacao, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EstoqueApi.FindDetailed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoDepositante** | **string**|  | 
 **endereco** | **long?**|  | [optional] 
 **etiquetaEndereco** | **string**|  | [optional] 
 **codigoUa** | **long?**|  | [optional] 
 **codigoProduto** | **string**|  | [optional] 
 **classeProduto** | **string**|  | [optional] 
 **loteFabricacao** | **string**|  | [optional] 
 **dataFabricacao** | **DateTime?**|  | [optional] 
 **dataVencimento** | **DateTime?**|  | [optional] 
 **loteGeral** | **string**|  | [optional] 
 **codigoEmpresa** | **string**|  | [optional] 
 **tipoDocumento** | **string**|  | [optional] 
 **serieDocumento** | **string**|  | [optional] 
 **documentoEntrada** | **string**|  | [optional] 
 **loteEntrada** | **long?**|  | [optional] 
 **dataFabricacaoInicial** | **DateTime?**|  | [optional] 
 **dataFabricacaoFinal** | **DateTime?**|  | [optional] 
 **dataVencimentoInicial** | **DateTime?**|  | [optional] 
 **dataVencimentoFinal** | **DateTime?**|  | [optional] 
 **loteEntradaSequencia** | **long?**|  | [optional] 
 **descricaoProduto** | **string**|  | [optional] 
 **apenasEnderecoDisponivelSaida** | **bool?**|  | [optional] 
 **checkarNecessidadeOficialSaida** | **bool?**|  | [optional] 
 **apenasLoteEntradaConfirmado** | **bool?**|  | [optional] 
 **excluirTipoEnderecoIntermediario** | **bool?**|  | [optional] 
 **excluirClasseDivergenciaDepositante** | **bool?**|  | [optional] 
 **tipoBaixaParaOrdenacao** | **int?**|  | [optional] 
 **tipoBaixaSecundarioParaOrdenacao** | **int?**|  | [optional] 
 **limit** | **long?**|  | [optional] [default to 50]
 **offset** | **long?**|  | [optional] [default to 0]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findgrouped"></a>
# **FindGrouped**
> void FindGrouped (long? codigoEstabelecimento, string codigoDepositante, long? endereco = null, string etiquetaEndereco = null, long? codigoUa = null, string codigoProduto = null, string classeProduto = null, string loteFabricacao = null, DateTime? dataFabricacao = null, DateTime? dataVencimento = null, string loteGeral = null, string codigoEmpresa = null, string tipoDocumento = null, string serieDocumento = null, string documentoEntrada = null, long? loteEntrada = null, DateTime? dataFabricacaoInicial = null, DateTime? dataFabricacaoFinal = null, DateTime? dataVencimentoInicial = null, DateTime? dataVencimentoFinal = null, long? loteEntradaSequencia = null, string descricaoProduto = null, bool? apenasEnderecoDisponivelSaida = null, bool? checkarNecessidadeOficialSaida = null, bool? apenasLoteEntradaConfirmado = null, bool? excluirTipoEnderecoIntermediario = null, bool? excluirClasseDivergenciaDepositante = null, bool? exibirNumeroSerie = null, bool? exibirDocumentoEntrada = null, List<string> groupBy = null, long? limit = null, long? offset = null)



Os tipos de dados string desse método devem ser informados em caixa alta (maiúsculo)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FindGroupedExample
    {
        public void main()
        {
            var apiInstance = new EstoqueApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var endereco = 789;  // long? |  (optional) 
            var etiquetaEndereco = etiquetaEndereco_example;  // string |  (optional) 
            var codigoUa = 789;  // long? |  (optional) 
            var codigoProduto = codigoProduto_example;  // string |  (optional) 
            var classeProduto = classeProduto_example;  // string |  (optional) 
            var loteFabricacao = loteFabricacao_example;  // string |  (optional) 
            var dataFabricacao = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataVencimento = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var loteGeral = loteGeral_example;  // string |  (optional) 
            var codigoEmpresa = codigoEmpresa_example;  // string |  (optional) 
            var tipoDocumento = tipoDocumento_example;  // string |  (optional) 
            var serieDocumento = serieDocumento_example;  // string |  (optional) 
            var documentoEntrada = documentoEntrada_example;  // string |  (optional) 
            var loteEntrada = 789;  // long? |  (optional) 
            var dataFabricacaoInicial = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataFabricacaoFinal = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataVencimentoInicial = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dataVencimentoFinal = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var loteEntradaSequencia = 789;  // long? |  (optional) 
            var descricaoProduto = descricaoProduto_example;  // string |  (optional) 
            var apenasEnderecoDisponivelSaida = true;  // bool? |  (optional) 
            var checkarNecessidadeOficialSaida = true;  // bool? |  (optional) 
            var apenasLoteEntradaConfirmado = true;  // bool? |  (optional) 
            var excluirTipoEnderecoIntermediario = true;  // bool? |  (optional) 
            var excluirClasseDivergenciaDepositante = true;  // bool? |  (optional) 
            var exibirNumeroSerie = true;  // bool? |  (optional) 
            var exibirDocumentoEntrada = true;  // bool? |  (optional) 
            var groupBy = groupBy_example;  // List<string> |  (optional) 
            var limit = 789;  // long? |  (optional)  (default to 50)
            var offset = 789;  // long? |  (optional)  (default to 0)

            try
            {
                apiInstance.FindGrouped(codigoEstabelecimento, codigoDepositante, endereco, etiquetaEndereco, codigoUa, codigoProduto, classeProduto, loteFabricacao, dataFabricacao, dataVencimento, loteGeral, codigoEmpresa, tipoDocumento, serieDocumento, documentoEntrada, loteEntrada, dataFabricacaoInicial, dataFabricacaoFinal, dataVencimentoInicial, dataVencimentoFinal, loteEntradaSequencia, descricaoProduto, apenasEnderecoDisponivelSaida, checkarNecessidadeOficialSaida, apenasLoteEntradaConfirmado, excluirTipoEnderecoIntermediario, excluirClasseDivergenciaDepositante, exibirNumeroSerie, exibirDocumentoEntrada, groupBy, limit, offset);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EstoqueApi.FindGrouped: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoDepositante** | **string**|  | 
 **endereco** | **long?**|  | [optional] 
 **etiquetaEndereco** | **string**|  | [optional] 
 **codigoUa** | **long?**|  | [optional] 
 **codigoProduto** | **string**|  | [optional] 
 **classeProduto** | **string**|  | [optional] 
 **loteFabricacao** | **string**|  | [optional] 
 **dataFabricacao** | **DateTime?**|  | [optional] 
 **dataVencimento** | **DateTime?**|  | [optional] 
 **loteGeral** | **string**|  | [optional] 
 **codigoEmpresa** | **string**|  | [optional] 
 **tipoDocumento** | **string**|  | [optional] 
 **serieDocumento** | **string**|  | [optional] 
 **documentoEntrada** | **string**|  | [optional] 
 **loteEntrada** | **long?**|  | [optional] 
 **dataFabricacaoInicial** | **DateTime?**|  | [optional] 
 **dataFabricacaoFinal** | **DateTime?**|  | [optional] 
 **dataVencimentoInicial** | **DateTime?**|  | [optional] 
 **dataVencimentoFinal** | **DateTime?**|  | [optional] 
 **loteEntradaSequencia** | **long?**|  | [optional] 
 **descricaoProduto** | **string**|  | [optional] 
 **apenasEnderecoDisponivelSaida** | **bool?**|  | [optional] 
 **checkarNecessidadeOficialSaida** | **bool?**|  | [optional] 
 **apenasLoteEntradaConfirmado** | **bool?**|  | [optional] 
 **excluirTipoEnderecoIntermediario** | **bool?**|  | [optional] 
 **excluirClasseDivergenciaDepositante** | **bool?**|  | [optional] 
 **exibirNumeroSerie** | **bool?**|  | [optional] 
 **exibirDocumentoEntrada** | **bool?**|  | [optional] 
 **groupBy** | **List&lt;string&gt;**|  | [optional] 
 **limit** | **long?**|  | [optional] [default to 50]
 **offset** | **long?**|  | [optional] [default to 0]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

