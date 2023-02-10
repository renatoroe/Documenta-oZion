# IO.Swagger.Api.DocumentosDeSaidaApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AtualizarDocumentoRelacionado**](DocumentosDeSaidaApi.md#atualizardocumentorelacionado) | **PUT** /v1/documentos-saida/atualizar-documento-relacionado/{codigoEstabelecimento}/{tipoDocumento}/{serieDocumento}/{documentoOficialSaida}/{documentoRelacionado} | Atualiza o documento relacionado do Documento de Saída vinculado ao Documento Oficial de Saída
[**AtualizarTransportador**](DocumentosDeSaidaApi.md#atualizartransportador) | **PUT** /v1/documentos-saida/atualizar-transportador/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Atualiza o transportador do Documento de Saída 
[**CountByQuery**](DocumentosDeSaidaApi.md#countbyquery) | **GET** /v1/documentos-saida/count | Conta os documentos de saida. Filtrados através de uma query string
[**CountEstadoProcessoByQuery**](DocumentosDeSaidaApi.md#countestadoprocessobyquery) | **GET** /v1/documentos-saida/count-estado | Conta os estados de processo. Filtrados através de uma query string
[**DivergenciaAtendimento**](DocumentosDeSaidaApi.md#divergenciaatendimento) | **GET** /v1/documentos-saida/divergencia-atendimento/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna a divergência de atendimento do documento de saída. Considera as reservas realizadas e também o saldo baixado para atendimento das solicitações.
[**ExistsRomaneio**](DocumentosDeSaidaApi.md#existsromaneio) | **GET** /v1/documentos-saida/possui-romaneio/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna se um documento de saida possui romaneio relacionado
[**FindByIdFethLoteSaida**](DocumentosDeSaidaApi.md#findbyidfethlotesaida) | **GET** /v1/documentos-saida/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida}/loteSaida | Retorna um documento de saída  atravéz dos atributos identificadores com sua lista de loteSaida
[**FindByQuery**](DocumentosDeSaidaApi.md#findbyquery) | **GET** /v1/documentos-saida | Retorna os documentos de saida. Filtrados através de uma query string
[**FindByQueryUploadSaida**](DocumentosDeSaidaApi.md#findbyqueryuploadsaida) | **GET** /v1/documentos-saida/uploadSaida | Retorna os documentos de saída. Filtrados através de uma query string
[**FindDocumentoByID**](DocumentosDeSaidaApi.md#finddocumentobyid) | **GET** /v1/documentos-saida/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna um documento de saida  atravéz dos atributos identificadores
[**FindEstadoProcessoByQuery**](DocumentosDeSaidaApi.md#findestadoprocessobyquery) | **GET** /v1/documentos-saida/query-estado | Retorna os estados de processo. Filtrados através de uma query string
[**FindProdutoConferenciaByQuery**](DocumentosDeSaidaApi.md#findprodutoconferenciabyquery) | **GET** /v1/documentos-saida/produtos-conferencia/{codigoEstabelecimento}/{codigoDepositante}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna os produtos conferidos para um documento de saída confirmado
[**FindProdutoConferenciaRealizadaByQuery**](DocumentosDeSaidaApi.md#findprodutoconferenciarealizadabyquery) | **GET** /v1/documentos-saida/produtos-conferencia-realizada/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna os produtos conferidos para um documento de saída em execução
[**FindProdutoSaldoInicialByQuery**](DocumentosDeSaidaApi.md#findprodutosaldoinicialbyquery) | **GET** /v1/documentos-saida/produtos-baixa/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna os produtos baixados para um documento de saída
[**FindProdutoSaldoProdutoSerieByQuery**](DocumentosDeSaidaApi.md#findprodutosaldoprodutoseriebyquery) | **GET** /v1/documentos-saida/produtos-saldo-produtoserie/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Retorna os produtos e suas series do documento de saída que está confirmado
[**RemoveDocumento**](DocumentosDeSaidaApi.md#removedocumento) | **DELETE** /v1/documentos-saida/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Exclui um documento de saida
[**UpdateDocumento**](DocumentosDeSaidaApi.md#updatedocumento) | **PUT** /v1/documentos-saida/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoSaida} | Altera um documento de saida 


<a name="atualizardocumentorelacionado"></a>
# **AtualizarDocumentoRelacionado**
> void AtualizarDocumentoRelacionado (long? codigoEstabelecimento, string tipoDocumento, string serieDocumento, string documentoOficialSaida, string documentoRelacionado)

Atualiza o documento relacionado do Documento de Saída vinculado ao Documento Oficial de Saída

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
    public class AtualizarDocumentoRelacionadoExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoOficialSaida = documentoOficialSaida_example;  // string | 
            var documentoRelacionado = documentoRelacionado_example;  // string | 

            try
            {
                // Atualiza o documento relacionado do Documento de Saída vinculado ao Documento Oficial de Saída
                apiInstance.AtualizarDocumentoRelacionado(codigoEstabelecimento, tipoDocumento, serieDocumento, documentoOficialSaida, documentoRelacionado);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.AtualizarDocumentoRelacionado: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoOficialSaida** | **string**|  | 
 **documentoRelacionado** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="atualizartransportador"></a>
# **AtualizarTransportador**
> void AtualizarTransportador (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoSaida, EmpresaDTO empresa)

Atualiza o transportador do Documento de Saída 

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
    public class AtualizarTransportadorExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoSaida = documentoSaida_example;  // string | 
            var empresa = new EmpresaDTO(); // EmpresaDTO | empresa

            try
            {
                // Atualiza o transportador do Documento de Saída 
                apiInstance.AtualizarTransportador(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoSaida, empresa);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.AtualizarTransportador: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoSaida** | **string**|  | 
 **empresa** | [**EmpresaDTO**](EmpresaDTO.md)| empresa | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="countbyquery"></a>
# **CountByQuery**
> long? CountByQuery ()

Conta os documentos de saida. Filtrados através de uma query string

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
    public class CountByQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();

            try
            {
                // Conta os documentos de saida. Filtrados através de uma query string
                long? result = apiInstance.CountByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.CountByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**long?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="countestadoprocessobyquery"></a>
# **CountEstadoProcessoByQuery**
> long? CountEstadoProcessoByQuery ()

Conta os estados de processo. Filtrados através de uma query string

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
    public class CountEstadoProcessoByQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();

            try
            {
                // Conta os estados de processo. Filtrados através de uma query string
                long? result = apiInstance.CountEstadoProcessoByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.CountEstadoProcessoByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**long?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="divergenciaatendimento"></a>
# **DivergenciaAtendimento**
> void DivergenciaAtendimento (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoSaida)

Retorna a divergência de atendimento do documento de saída. Considera as reservas realizadas e também o saldo baixado para atendimento das solicitações.

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
    public class DivergenciaAtendimentoExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoSaida = documentoSaida_example;  // string | 

            try
            {
                // Retorna a divergência de atendimento do documento de saída. Considera as reservas realizadas e também o saldo baixado para atendimento das solicitações.
                apiInstance.DivergenciaAtendimento(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoSaida);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.DivergenciaAtendimento: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoSaida** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="existsromaneio"></a>
# **ExistsRomaneio**
> bool? ExistsRomaneio (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoSaida)

Retorna se um documento de saida possui romaneio relacionado

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
    public class ExistsRomaneioExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoSaida = documentoSaida_example;  // string | 

            try
            {
                // Retorna se um documento de saida possui romaneio relacionado
                bool? result = apiInstance.ExistsRomaneio(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoSaida);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.ExistsRomaneio: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoSaida** | **string**|  | 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyidfethlotesaida"></a>
# **FindByIdFethLoteSaida**
> DocumentoSaida FindByIdFethLoteSaida (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoSaida)

Retorna um documento de saída  atravéz dos atributos identificadores com sua lista de loteSaida

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
    public class FindByIdFethLoteSaidaExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoSaida = documentoSaida_example;  // string | 

            try
            {
                // Retorna um documento de saída  atravéz dos atributos identificadores com sua lista de loteSaida
                DocumentoSaida result = apiInstance.FindByIdFethLoteSaida(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoSaida);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.FindByIdFethLoteSaida: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoSaida** | **string**|  | 

### Return type

[**DocumentoSaida**](DocumentoSaida.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyquery"></a>
# **FindByQuery**
> List<DocumentoSaida> FindByQuery ()

Retorna os documentos de saida. Filtrados através de uma query string

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
    public class FindByQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();

            try
            {
                // Retorna os documentos de saida. Filtrados através de uma query string
                List&lt;DocumentoSaida&gt; result = apiInstance.FindByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.FindByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DocumentoSaida>**](DocumentoSaida.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyqueryuploadsaida"></a>
# **FindByQueryUploadSaida**
> List<DocumentoSaida> FindByQueryUploadSaida ()

Retorna os documentos de saída. Filtrados através de uma query string

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
    public class FindByQueryUploadSaidaExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();

            try
            {
                // Retorna os documentos de saída. Filtrados através de uma query string
                List&lt;DocumentoSaida&gt; result = apiInstance.FindByQueryUploadSaida();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.FindByQueryUploadSaida: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DocumentoSaida>**](DocumentoSaida.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="finddocumentobyid"></a>
# **FindDocumentoByID**
> DocumentoSaida FindDocumentoByID (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoSaida)

Retorna um documento de saida  atravéz dos atributos identificadores

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
    public class FindDocumentoByIDExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoSaida = documentoSaida_example;  // string | 

            try
            {
                // Retorna um documento de saida  atravéz dos atributos identificadores
                DocumentoSaida result = apiInstance.FindDocumentoByID(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoSaida);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.FindDocumentoByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoSaida** | **string**|  | 

### Return type

[**DocumentoSaida**](DocumentoSaida.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findestadoprocessobyquery"></a>
# **FindEstadoProcessoByQuery**
> List<DocumentoSaida> FindEstadoProcessoByQuery ()

Retorna os estados de processo. Filtrados através de uma query string

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
    public class FindEstadoProcessoByQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();

            try
            {
                // Retorna os estados de processo. Filtrados através de uma query string
                List&lt;DocumentoSaida&gt; result = apiInstance.FindEstadoProcessoByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.FindEstadoProcessoByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DocumentoSaida>**](DocumentoSaida.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findprodutoconferenciabyquery"></a>
# **FindProdutoConferenciaByQuery**
> List<ProdutoBaixaDTO> FindProdutoConferenciaByQuery (long? codigoEstabelecimento, string codigoDepositante, string tipoDocumento, string serieDocumento, string documentoSaida)

Retorna os produtos conferidos para um documento de saída confirmado

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
    public class FindProdutoConferenciaByQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoSaida = documentoSaida_example;  // string | 

            try
            {
                // Retorna os produtos conferidos para um documento de saída confirmado
                List&lt;ProdutoBaixaDTO&gt; result = apiInstance.FindProdutoConferenciaByQuery(codigoEstabelecimento, codigoDepositante, tipoDocumento, serieDocumento, documentoSaida);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.FindProdutoConferenciaByQuery: " + e.Message );
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
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoSaida** | **string**|  | 

### Return type

[**List<ProdutoBaixaDTO>**](ProdutoBaixaDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findprodutoconferenciarealizadabyquery"></a>
# **FindProdutoConferenciaRealizadaByQuery**
> List<ProdutoBaixaDTO> FindProdutoConferenciaRealizadaByQuery (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoSaida)

Retorna os produtos conferidos para um documento de saída em execução

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
    public class FindProdutoConferenciaRealizadaByQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoSaida = documentoSaida_example;  // string | 

            try
            {
                // Retorna os produtos conferidos para um documento de saída em execução
                List&lt;ProdutoBaixaDTO&gt; result = apiInstance.FindProdutoConferenciaRealizadaByQuery(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoSaida);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.FindProdutoConferenciaRealizadaByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoSaida** | **string**|  | 

### Return type

[**List<ProdutoBaixaDTO>**](ProdutoBaixaDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findprodutosaldoinicialbyquery"></a>
# **FindProdutoSaldoInicialByQuery**
> List<ProdutoBaixaDTO> FindProdutoSaldoInicialByQuery (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoSaida)

Retorna os produtos baixados para um documento de saída

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
    public class FindProdutoSaldoInicialByQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoSaida = documentoSaida_example;  // string | 

            try
            {
                // Retorna os produtos baixados para um documento de saída
                List&lt;ProdutoBaixaDTO&gt; result = apiInstance.FindProdutoSaldoInicialByQuery(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoSaida);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.FindProdutoSaldoInicialByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoSaida** | **string**|  | 

### Return type

[**List<ProdutoBaixaDTO>**](ProdutoBaixaDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findprodutosaldoprodutoseriebyquery"></a>
# **FindProdutoSaldoProdutoSerieByQuery**
> List<DocumentoProdutoSerieDTO> FindProdutoSaldoProdutoSerieByQuery (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoSaida)

Retorna os produtos e suas series do documento de saída que está confirmado

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
    public class FindProdutoSaldoProdutoSerieByQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoSaida = documentoSaida_example;  // string | 

            try
            {
                // Retorna os produtos e suas series do documento de saída que está confirmado
                List&lt;DocumentoProdutoSerieDTO&gt; result = apiInstance.FindProdutoSaldoProdutoSerieByQuery(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoSaida);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.FindProdutoSaldoProdutoSerieByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoSaida** | **string**|  | 

### Return type

[**List<DocumentoProdutoSerieDTO>**](DocumentoProdutoSerieDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removedocumento"></a>
# **RemoveDocumento**
> void RemoveDocumento (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoSaida)

Exclui um documento de saida

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
    public class RemoveDocumentoExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoSaida = documentoSaida_example;  // string | 

            try
            {
                // Exclui um documento de saida
                apiInstance.RemoveDocumento(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoSaida);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.RemoveDocumento: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoSaida** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocumento"></a>
# **UpdateDocumento**
> void UpdateDocumento (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoSaida, DocumentoSaida documentoSaida2)

Altera um documento de saida 

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
    public class UpdateDocumentoExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoSaida = documentoSaida_example;  // string | 
            var documentoSaida2 = new DocumentoSaida(); // DocumentoSaida | documentoSaida

            try
            {
                // Altera um documento de saida 
                apiInstance.UpdateDocumento(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoSaida, documentoSaida2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeSaidaApi.UpdateDocumento: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEstabelecimento** | **long?**|  | 
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoSaida** | **string**|  | 
 **documentoSaida2** | [**DocumentoSaida**](DocumentoSaida.md)| documentoSaida | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

