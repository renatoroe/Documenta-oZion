# IO.Swagger.Api.RcqApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountByQuery**](RcqApi.md#countbyquery) | **GET** /v1/rcq/count | Retorna quantidade de RCQs cadastrados
[**FindByEstDep**](RcqApi.md#findbyestdep) | **GET** /v1/rcq/data-emissao-atual/{codigoEstabelecimento}/{codigoDepositante} | Retorna uma lista de RCQs emitidos com Data Emissão no dia corrente
[**FindByNumeroMovimento**](RcqApi.md#findbynumeromovimento) | **GET** /v1/rcq/{codigoEstabelecimento}/{codigoDepositante}/{numeroMovimento} | Retorna lista de RCQs pelo Número Movimento
[**FindByQuery**](RcqApi.md#findbyquery) | **GET** /v1/rcq | Retorna os RCQs filtrados através de uma query string


<a name="countbyquery"></a>
# **CountByQuery**
> void CountByQuery ()

Retorna quantidade de RCQs cadastrados

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
            var apiInstance = new RcqApi();

            try
            {
                // Retorna quantidade de RCQs cadastrados
                apiInstance.CountByQuery();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RcqApi.CountByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyestdep"></a>
# **FindByEstDep**
> void FindByEstDep (long? codigoEstabelecimento, string codigoDepositante)

Retorna uma lista de RCQs emitidos com Data Emissão no dia corrente

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
    public class FindByEstDepExample
    {
        public void main()
        {
            var apiInstance = new RcqApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 

            try
            {
                // Retorna uma lista de RCQs emitidos com Data Emissão no dia corrente
                apiInstance.FindByEstDep(codigoEstabelecimento, codigoDepositante);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RcqApi.FindByEstDep: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbynumeromovimento"></a>
# **FindByNumeroMovimento**
> void FindByNumeroMovimento (long? codigoEstabelecimento, string codigoDepositante, string numeroMovimento)

Retorna lista de RCQs pelo Número Movimento

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
    public class FindByNumeroMovimentoExample
    {
        public void main()
        {
            var apiInstance = new RcqApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var numeroMovimento = numeroMovimento_example;  // string | 

            try
            {
                // Retorna lista de RCQs pelo Número Movimento
                apiInstance.FindByNumeroMovimento(codigoEstabelecimento, codigoDepositante, numeroMovimento);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RcqApi.FindByNumeroMovimento: " + e.Message );
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
 **numeroMovimento** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyquery"></a>
# **FindByQuery**
> void FindByQuery ()

Retorna os RCQs filtrados através de uma query string

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
            var apiInstance = new RcqApi();

            try
            {
                // Retorna os RCQs filtrados através de uma query string
                apiInstance.FindByQuery();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RcqApi.FindByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

