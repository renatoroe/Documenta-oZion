# IO.Swagger.Api.PrevisaoDeEntradaItemApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountByQuery**](PrevisaoDeEntradaItemApi.md#countbyquery) | **GET** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/count | 
[**CountByQuery_0**](PrevisaoDeEntradaItemApi.md#countbyquery_0) | **GET** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada}/count | 
[**Create**](PrevisaoDeEntradaItemApi.md#create) | **POST** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa} | 
[**FindAll**](PrevisaoDeEntradaItemApi.md#findall) | **GET** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada} | Retorna todos os itens de uma previsão de entrada
[**FindById**](PrevisaoDeEntradaItemApi.md#findbyid) | **GET** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada}/{sequenciaPrevisaoEntrada} | 
[**FindByQuery**](PrevisaoDeEntradaItemApi.md#findbyquery) | **GET** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante} | 
[**Remove**](PrevisaoDeEntradaItemApi.md#remove) | **DELETE** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada}/{sequenciaPrevisaoEntrada} | 
[**Update**](PrevisaoDeEntradaItemApi.md#update) | **PUT** /v1/previsao-entrada-item/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada}/{sequenciaPrevisaoEntrada} | 


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
            var apiInstance = new PrevisaoDeEntradaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 

            try
            {
                apiInstance.CountByQuery(codigoEstabelecimento, codigoDepositante);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaItemApi.CountByQuery: " + e.Message );
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
> void CountByQuery_0 (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoEntrada)



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
            var apiInstance = new PrevisaoDeEntradaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoEntrada = previsaoEntrada_example;  // string | 

            try
            {
                apiInstance.CountByQuery_0(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoEntrada);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaItemApi.CountByQuery_0: " + e.Message );
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
 **previsaoEntrada** | **string**|  | 

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
> void Create (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, PrevisaoEntradaItemDTO previsaoEntradaItem)



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
            var apiInstance = new PrevisaoDeEntradaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var previsaoEntradaItem = new PrevisaoEntradaItemDTO(); // PrevisaoEntradaItemDTO | previsaoEntradaItem

            try
            {
                apiInstance.Create(codigoEstabelecimento, codigoDepositante, codigoEmpresa, previsaoEntradaItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaItemApi.Create: " + e.Message );
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
 **previsaoEntradaItem** | [**PrevisaoEntradaItemDTO**](PrevisaoEntradaItemDTO.md)| previsaoEntradaItem | 

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
> List<PrevisaoEntradaItemDTO> FindAll (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoEntrada)

Retorna todos os itens de uma previsão de entrada

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
            var apiInstance = new PrevisaoDeEntradaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoEntrada = previsaoEntrada_example;  // string | 

            try
            {
                // Retorna todos os itens de uma previsão de entrada
                List&lt;PrevisaoEntradaItemDTO&gt; result = apiInstance.FindAll(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoEntrada);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaItemApi.FindAll: " + e.Message );
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
 **previsaoEntrada** | **string**|  | 

### Return type

[**List<PrevisaoEntradaItemDTO>**](PrevisaoEntradaItemDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyid"></a>
# **FindById**
> void FindById (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoEntrada, long? sequenciaPrevisaoEntrada)



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
            var apiInstance = new PrevisaoDeEntradaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoEntrada = previsaoEntrada_example;  // string | 
            var sequenciaPrevisaoEntrada = 789;  // long? | 

            try
            {
                apiInstance.FindById(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoEntrada, sequenciaPrevisaoEntrada);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaItemApi.FindById: " + e.Message );
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
 **previsaoEntrada** | **string**|  | 
 **sequenciaPrevisaoEntrada** | **long?**|  | 

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
            var apiInstance = new PrevisaoDeEntradaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 

            try
            {
                apiInstance.FindByQuery(codigoEstabelecimento, codigoDepositante);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaItemApi.FindByQuery: " + e.Message );
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
> void Remove (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string previsaoEntrada, string tipoDocumento, string serieDocumento, long? sequenciaPrevisaoEntrada)



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
            var apiInstance = new PrevisaoDeEntradaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var previsaoEntrada = previsaoEntrada_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var sequenciaPrevisaoEntrada = 789;  // long? | 

            try
            {
                apiInstance.Remove(codigoEstabelecimento, codigoDepositante, codigoEmpresa, previsaoEntrada, tipoDocumento, serieDocumento, sequenciaPrevisaoEntrada);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaItemApi.Remove: " + e.Message );
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
 **previsaoEntrada** | **string**|  | 
 **tipoDocumento** | **string**|  | 
 **serieDocumento** | **string**|  | 
 **sequenciaPrevisaoEntrada** | **long?**|  | 

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
> void Update (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoEntrada, long? sequenciaPrevisaoEntrada, PrevisaoEntradaItemDTO previsaoEntradaItem)



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
            var apiInstance = new PrevisaoDeEntradaItemApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoEntrada = previsaoEntrada_example;  // string | 
            var sequenciaPrevisaoEntrada = 789;  // long? | 
            var previsaoEntradaItem = new PrevisaoEntradaItemDTO(); // PrevisaoEntradaItemDTO | previsaoEntradaItem

            try
            {
                apiInstance.Update(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoEntrada, sequenciaPrevisaoEntrada, previsaoEntradaItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaItemApi.Update: " + e.Message );
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
 **previsaoEntrada** | **string**|  | 
 **sequenciaPrevisaoEntrada** | **long?**|  | 
 **previsaoEntradaItem** | [**PrevisaoEntradaItemDTO**](PrevisaoEntradaItemDTO.md)| previsaoEntradaItem | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

