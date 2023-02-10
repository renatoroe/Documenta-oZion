# IO.Swagger.Api.PrevisaoDeSaidaItemApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountByQuery**](PrevisaoDeSaidaItemApi.md#countbyquery) | **GET** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/count | 
[**CountByQuery_0**](PrevisaoDeSaidaItemApi.md#countbyquery_0) | **GET** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida}/count | 
[**Create**](PrevisaoDeSaidaItemApi.md#create) | **POST** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante} | 
[**FindAll**](PrevisaoDeSaidaItemApi.md#findall) | **GET** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Retorna todos os itens de uma previsão de saída
[**FindById**](PrevisaoDeSaidaItemApi.md#findbyid) | **GET** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida}/{sequenciaPrevisaoSaida} | 
[**FindByQuery**](PrevisaoDeSaidaItemApi.md#findbyquery) | **GET** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante} | 
[**Remove**](PrevisaoDeSaidaItemApi.md#remove) | **DELETE** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida}/{sequenciaPrevisaoSaida} | 
[**Update**](PrevisaoDeSaidaItemApi.md#update) | **PUT** /v1/previsao-saida-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida}/{sequenciaPrevisaoSaida} | 


<a name="countbyquery"></a>
# **CountByQuery**
> void CountByQuery (long? codigoEstabelecimento, string codigoDepositante)



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
            var apiInstance = new PrevisaoDeSaidaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 

            try
            {
                apiInstance.CountByQuery(codigoEstabelecimento, codigoDepositante);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaItemApi.CountByQuery: " + e.Message );
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

<a name="countbyquery_0"></a>
# **CountByQuery_0**
> void CountByQuery_0 (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string previsaoSaida, string tipoDocumento, string serieDocumento)



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
    public class CountByQuery_0Example
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeSaidaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var previsaoSaida = previsaoSaida_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 

            try
            {
                apiInstance.CountByQuery_0(codigoEstabelecimento, codigoDepositante, codigoEmpresa, previsaoSaida, tipoDocumento, serieDocumento);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaItemApi.CountByQuery_0: " + e.Message );
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
 **codigoEmpresa** | **string**|  | 
 **previsaoSaida** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> void Create (long? codigoEstabelecimento, string codigoDepositante, PrevisaoSaidaItemDTO previsaoSaidaItem)



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
    public class CreateExample
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeSaidaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var previsaoSaidaItem = new PrevisaoSaidaItemDTO(); // PrevisaoSaidaItemDTO | previsaoSaidaItem

            try
            {
                apiInstance.Create(codigoEstabelecimento, codigoDepositante, previsaoSaidaItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaItemApi.Create: " + e.Message );
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
 **previsaoSaidaItem** | [**PrevisaoSaidaItemDTO**](PrevisaoSaidaItemDTO.md)| previsaoSaidaItem | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findall"></a>
# **FindAll**
> List<PrevisaoSaidaItemDTO> FindAll (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string previsaoSaida, string tipoDocumento, string serieDocumento)

Retorna todos os itens de uma previsão de saída

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
    public class FindAllExample
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeSaidaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var previsaoSaida = previsaoSaida_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 

            try
            {
                // Retorna todos os itens de uma previsão de saída
                List&lt;PrevisaoSaidaItemDTO&gt; result = apiInstance.FindAll(codigoEstabelecimento, codigoDepositante, codigoEmpresa, previsaoSaida, tipoDocumento, serieDocumento);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaItemApi.FindAll: " + e.Message );
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
 **codigoEmpresa** | **string**|  | 
 **previsaoSaida** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 

### Return type

[**List<PrevisaoSaidaItemDTO>**](PrevisaoSaidaItemDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyid"></a>
# **FindById**
> void FindById (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string previsaoSaida, string tipoDocumento, string serieDocumento, long? sequenciaPrevisaoSaida)



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
            var apiInstance = new PrevisaoDeSaidaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var previsaoSaida = previsaoSaida_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var sequenciaPrevisaoSaida = 789;  // long? | 

            try
            {
                apiInstance.FindById(codigoEstabelecimento, codigoDepositante, codigoEmpresa, previsaoSaida, tipoDocumento, serieDocumento, sequenciaPrevisaoSaida);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaItemApi.FindById: " + e.Message );
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
 **codigoEmpresa** | **string**|  | 
 **previsaoSaida** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **sequenciaPrevisaoSaida** | **long?**|  | 

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
> void FindByQuery (long? codigoEstabelecimento, string codigoDepositante)



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
            var apiInstance = new PrevisaoDeSaidaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 

            try
            {
                apiInstance.FindByQuery(codigoEstabelecimento, codigoDepositante);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaItemApi.FindByQuery: " + e.Message );
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

<a name="remove"></a>
# **Remove**
> void Remove (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string previsaoSaida, string tipoDocumento, string serieDocumento, long? sequenciaPrevisaoSaida)



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
            var apiInstance = new PrevisaoDeSaidaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var previsaoSaida = previsaoSaida_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var sequenciaPrevisaoSaida = 789;  // long? | 

            try
            {
                apiInstance.Remove(codigoEstabelecimento, codigoDepositante, codigoEmpresa, previsaoSaida, tipoDocumento, serieDocumento, sequenciaPrevisaoSaida);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaItemApi.Remove: " + e.Message );
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
 **codigoEmpresa** | **string**|  | 
 **previsaoSaida** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **sequenciaPrevisaoSaida** | **long?**|  | 

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
> void Update (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoSaida, long? sequenciaPrevisaoSaida, PrevisaoSaidaItemDTO previsaoSaidaItem)



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
            var apiInstance = new PrevisaoDeSaidaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoSaida = previsaoSaida_example;  // string | 
            var sequenciaPrevisaoSaida = 789;  // long? | 
            var previsaoSaidaItem = new PrevisaoSaidaItemDTO(); // PrevisaoSaidaItemDTO | previsaoSaidaItem

            try
            {
                apiInstance.Update(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoSaida, sequenciaPrevisaoSaida, previsaoSaidaItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaItemApi.Update: " + e.Message );
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
 **codigoEmpresa** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **previsaoSaida** | **string**|  | 
 **sequenciaPrevisaoSaida** | **long?**|  | 
 **previsaoSaidaItem** | [**PrevisaoSaidaItemDTO**](PrevisaoSaidaItemDTO.md)| previsaoSaidaItem | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

