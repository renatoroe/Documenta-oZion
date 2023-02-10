# IO.Swagger.Api.DocumentosDeEntradaApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountByQuery**](DocumentosDeEntradaApi.md#countbyquery) | **GET** /v1/documentos-entrada/count | Conta os documentos de entrada. Filtrados através de uma query string
[**CountEstadoProcessoByQuery**](DocumentosDeEntradaApi.md#countestadoprocessobyquery) | **GET** /v1/documentos-entrada/count-estado | Conta os estados de processo. Filtrados através de uma query string
[**FindById**](DocumentosDeEntradaApi.md#findbyid) | **GET** /v1/documentos-entrada/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Retorna um documento de entrada  atravéz dos atributos identificadores
[**FindByIdFethLoteEntrada**](DocumentosDeEntradaApi.md#findbyidfethloteentrada) | **GET** /v1/documentos-entrada/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada}/loteEntrada | Retorna um documento de entrada  atravéz dos atributos identificadores com sua lista de loteEntrada
[**FindByQuery**](DocumentosDeEntradaApi.md#findbyquery) | **GET** /v1/documentos-entrada | Retorna os documentos de entrada. Filtrados através de uma query string
[**FindByQueryUploadEntrada**](DocumentosDeEntradaApi.md#findbyqueryuploadentrada) | **GET** /v1/documentos-entrada/uploadEntrada | Retorna os documentos de entrada. Filtrados através de uma query string
[**FindEstadoProcessoByQuery**](DocumentosDeEntradaApi.md#findestadoprocessobyquery) | **GET** /v1/documentos-entrada/query-estado | Retorna os estados de processo. Filtrados através de uma query string
[**FindProdutoConferenciaByQuery**](DocumentosDeEntradaApi.md#findprodutoconferenciabyquery) | **GET** /v1/documentos-entrada/produtos-conferencia/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Retorna os produtos conferidos para um documento de saída confirmado
[**FindProdutoSaldoInicialByQuery**](DocumentosDeEntradaApi.md#findprodutosaldoinicialbyquery) | **GET** /v1/documentos-entrada/produtos-saldo-inicial/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Retorna o saldo inicial dos produtos do documento de entrada
[**FindProdutoSaldoProdutoSerieByQuery**](DocumentosDeEntradaApi.md#findprodutosaldoprodutoseriebyquery) | **GET** /v1/documentos-entrada/produtos-saldo-produtoserie/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Retorna o saldo inicial dos produtos e suas series do documento de entrada que está confirmado
[**Remove**](DocumentosDeEntradaApi.md#remove) | **DELETE** /v1/documentos-entrada/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Exclui um documento de entrada
[**RemoveDEupload**](DocumentosDeEntradaApi.md#removedeupload) | **DELETE** /v1/documentos-entrada/uploadEntrada/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Exclui um documento de entrada vindo de upload de arquivos
[**Update**](DocumentosDeEntradaApi.md#update) | **PUT** /v1/documentos-entrada/{codigoEstabelecimento}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{documentoEntrada} | Altera um documento de entrada 


<a name="countbyquery"></a>
# **CountByQuery**
> long? CountByQuery ()

Conta os documentos de entrada. Filtrados através de uma query string

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
            var apiInstance = new DocumentosDeEntradaApi();

            try
            {
                // Conta os documentos de entrada. Filtrados através de uma query string
                long? result = apiInstance.CountByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.CountByQuery: " + e.Message );
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
            var apiInstance = new DocumentosDeEntradaApi();

            try
            {
                // Conta os estados de processo. Filtrados através de uma query string
                long? result = apiInstance.CountEstadoProcessoByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.CountEstadoProcessoByQuery: " + e.Message );
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

<a name="findbyid"></a>
# **FindById**
> DocumentoEntrada FindById (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoEntrada)

Retorna um documento de entrada  atravéz dos atributos identificadores

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
    public class FindByIdExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoEntrada = documentoEntrada_example;  // string | 

            try
            {
                // Retorna um documento de entrada  atravéz dos atributos identificadores
                DocumentoEntrada result = apiInstance.FindById(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoEntrada);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.FindById: " + e.Message );
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
 **documentoEntrada** | **string**|  | 

### Return type

[**DocumentoEntrada**](DocumentoEntrada.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyidfethloteentrada"></a>
# **FindByIdFethLoteEntrada**
> DocumentoEntrada FindByIdFethLoteEntrada (string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoEntrada)

Retorna um documento de entrada  atravéz dos atributos identificadores com sua lista de loteEntrada

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
    public class FindByIdFethLoteEntradaExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeEntradaApi();
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoEntrada = documentoEntrada_example;  // string | 

            try
            {
                // Retorna um documento de entrada  atravéz dos atributos identificadores com sua lista de loteEntrada
                DocumentoEntrada result = apiInstance.FindByIdFethLoteEntrada(codigoEmpresa, tipoDocumento, serieDocumento, documentoEntrada);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.FindByIdFethLoteEntrada: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **documentoEntrada** | **string**|  | 

### Return type

[**DocumentoEntrada**](DocumentoEntrada.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyquery"></a>
# **FindByQuery**
> List<DocumentoEntrada> FindByQuery ()

Retorna os documentos de entrada. Filtrados através de uma query string

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
            var apiInstance = new DocumentosDeEntradaApi();

            try
            {
                // Retorna os documentos de entrada. Filtrados através de uma query string
                List&lt;DocumentoEntrada&gt; result = apiInstance.FindByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.FindByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DocumentoEntrada>**](DocumentoEntrada.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyqueryuploadentrada"></a>
# **FindByQueryUploadEntrada**
> List<DocumentoEntrada> FindByQueryUploadEntrada ()

Retorna os documentos de entrada. Filtrados através de uma query string

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
    public class FindByQueryUploadEntradaExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeEntradaApi();

            try
            {
                // Retorna os documentos de entrada. Filtrados através de uma query string
                List&lt;DocumentoEntrada&gt; result = apiInstance.FindByQueryUploadEntrada();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.FindByQueryUploadEntrada: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DocumentoEntrada>**](DocumentoEntrada.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findestadoprocessobyquery"></a>
# **FindEstadoProcessoByQuery**
> List<DocumentoEntrada> FindEstadoProcessoByQuery ()

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
            var apiInstance = new DocumentosDeEntradaApi();

            try
            {
                // Retorna os estados de processo. Filtrados através de uma query string
                List&lt;DocumentoEntrada&gt; result = apiInstance.FindEstadoProcessoByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.FindEstadoProcessoByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DocumentoEntrada>**](DocumentoEntrada.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findprodutoconferenciabyquery"></a>
# **FindProdutoConferenciaByQuery**
> List<ProdutoBaixaDTO> FindProdutoConferenciaByQuery (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoEntrada)

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
            var apiInstance = new DocumentosDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoEntrada = documentoEntrada_example;  // string | 

            try
            {
                // Retorna os produtos conferidos para um documento de saída confirmado
                List&lt;ProdutoBaixaDTO&gt; result = apiInstance.FindProdutoConferenciaByQuery(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoEntrada);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.FindProdutoConferenciaByQuery: " + e.Message );
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
 **documentoEntrada** | **string**|  | 

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
> List<ProdutoSaldoInicialDTO> FindProdutoSaldoInicialByQuery (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoEntrada)

Retorna o saldo inicial dos produtos do documento de entrada

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
            var apiInstance = new DocumentosDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoEntrada = documentoEntrada_example;  // string | 

            try
            {
                // Retorna o saldo inicial dos produtos do documento de entrada
                List&lt;ProdutoSaldoInicialDTO&gt; result = apiInstance.FindProdutoSaldoInicialByQuery(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoEntrada);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.FindProdutoSaldoInicialByQuery: " + e.Message );
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
 **documentoEntrada** | **string**|  | 

### Return type

[**List<ProdutoSaldoInicialDTO>**](ProdutoSaldoInicialDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findprodutosaldoprodutoseriebyquery"></a>
# **FindProdutoSaldoProdutoSerieByQuery**
> List<DocumentoProdutoSerieDTO> FindProdutoSaldoProdutoSerieByQuery (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoEntrada)

Retorna o saldo inicial dos produtos e suas series do documento de entrada que está confirmado

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
            var apiInstance = new DocumentosDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoEntrada = documentoEntrada_example;  // string | 

            try
            {
                // Retorna o saldo inicial dos produtos e suas series do documento de entrada que está confirmado
                List&lt;DocumentoProdutoSerieDTO&gt; result = apiInstance.FindProdutoSaldoProdutoSerieByQuery(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoEntrada);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.FindProdutoSaldoProdutoSerieByQuery: " + e.Message );
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
 **documentoEntrada** | **string**|  | 

### Return type

[**List<DocumentoProdutoSerieDTO>**](DocumentoProdutoSerieDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="remove"></a>
# **Remove**
> void Remove (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoEntrada)

Exclui um documento de entrada

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
    public class RemoveExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoEntrada = documentoEntrada_example;  // string | 

            try
            {
                // Exclui um documento de entrada
                apiInstance.Remove(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoEntrada);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.Remove: " + e.Message );
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
 **documentoEntrada** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removedeupload"></a>
# **RemoveDEupload**
> void RemoveDEupload (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoEntrada)

Exclui um documento de entrada vindo de upload de arquivos

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
    public class RemoveDEuploadExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoEntrada = documentoEntrada_example;  // string | 

            try
            {
                // Exclui um documento de entrada vindo de upload de arquivos
                apiInstance.RemoveDEupload(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoEntrada);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.RemoveDEupload: " + e.Message );
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
 **documentoEntrada** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> void Update (long? codigoEstabelecimento, string codigoEmpresa, string tipoDocumento, string serieDocumento, string documentoEntrada, DocumentoEntradaDTO documentoEntrada2)

Altera um documento de entrada 

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
    public class UpdateExample
    {
        public void main()
        {
            var apiInstance = new DocumentosDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var documentoEntrada = documentoEntrada_example;  // string | 
            var documentoEntrada2 = new DocumentoEntradaDTO(); // DocumentoEntradaDTO | documentoEntrada

            try
            {
                // Altera um documento de entrada 
                apiInstance.Update(codigoEstabelecimento, codigoEmpresa, tipoDocumento, serieDocumento, documentoEntrada, documentoEntrada2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentosDeEntradaApi.Update: " + e.Message );
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
 **documentoEntrada** | **string**|  | 
 **documentoEntrada2** | [**DocumentoEntradaDTO**](DocumentoEntradaDTO.md)| documentoEntrada | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

