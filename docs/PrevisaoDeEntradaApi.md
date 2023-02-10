# IO.Swagger.Api.PrevisaoDeEntradaApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePrevisaoEntrada**](PrevisaoDeEntradaApi.md#createprevisaoentrada) | **POST** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada} | Adiciona uma nova previsão de entrada
[**FindAll**](PrevisaoDeEntradaApi.md#findall) | **GET** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante} | Retorna as Previsões de Entrada do Depositante
[**FindPrevisaoEntradaByID**](PrevisaoDeEntradaApi.md#findprevisaoentradabyid) | **GET** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada} | Retorna Previsão de Entrada e itens por Empresa/Tipo/Série/Número
[**RemovePrevisaoEntrada**](PrevisaoDeEntradaApi.md#removeprevisaoentrada) | **DELETE** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada} | Exclui uma previsão de entrada
[**RemoverItem**](PrevisaoDeEntradaApi.md#removeritem) | **DELETE** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada}/itens | Exclui uma previsão de entrada e seus itens
[**UpdatePrevisaoEntrada**](PrevisaoDeEntradaApi.md#updateprevisaoentrada) | **PUT** /v1/previsao-entrada/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoEntrada} | Altera uma previsão de entrada


<a name="createprevisaoentrada"></a>
# **CreatePrevisaoEntrada**
> void CreatePrevisaoEntrada (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoEntrada, PrevisaoEntradaDTO previsaoEntrada2)

Adiciona uma nova previsão de entrada

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
    public class CreatePrevisaoEntradaExample
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoEntrada = previsaoEntrada_example;  // string | 
            var previsaoEntrada2 = new PrevisaoEntradaDTO(); // PrevisaoEntradaDTO | previsaoEntrada

            try
            {
                // Adiciona uma nova previsão de entrada
                apiInstance.CreatePrevisaoEntrada(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoEntrada, previsaoEntrada2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaApi.CreatePrevisaoEntrada: " + e.Message );
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
 **previsaoEntrada2** | [**PrevisaoEntradaDTO**](PrevisaoEntradaDTO.md)| previsaoEntrada | 

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
> PrevisaoEntradaDTO FindAll (long? codigoEstabelecimento, string codigoDepositante)

Retorna as Previsões de Entrada do Depositante

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
            var apiInstance = new PrevisaoDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 

            try
            {
                // Retorna as Previsões de Entrada do Depositante
                PrevisaoEntradaDTO result = apiInstance.FindAll(codigoEstabelecimento, codigoDepositante);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaApi.FindAll: " + e.Message );
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

[**PrevisaoEntradaDTO**](PrevisaoEntradaDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findprevisaoentradabyid"></a>
# **FindPrevisaoEntradaByID**
> PrevisaoEntradaDTO FindPrevisaoEntradaByID (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoEntrada)

Retorna Previsão de Entrada e itens por Empresa/Tipo/Série/Número

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
    public class FindPrevisaoEntradaByIDExample
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoEntrada = previsaoEntrada_example;  // string | 

            try
            {
                // Retorna Previsão de Entrada e itens por Empresa/Tipo/Série/Número
                PrevisaoEntradaDTO result = apiInstance.FindPrevisaoEntradaByID(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoEntrada);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaApi.FindPrevisaoEntradaByID: " + e.Message );
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

[**PrevisaoEntradaDTO**](PrevisaoEntradaDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeprevisaoentrada"></a>
# **RemovePrevisaoEntrada**
> void RemovePrevisaoEntrada (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoEntrada)

Exclui uma previsão de entrada

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
    public class RemovePrevisaoEntradaExample
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoEntrada = previsaoEntrada_example;  // string | 

            try
            {
                // Exclui uma previsão de entrada
                apiInstance.RemovePrevisaoEntrada(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoEntrada);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaApi.RemovePrevisaoEntrada: " + e.Message );
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
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeritem"></a>
# **RemoverItem**
> void RemoverItem (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoEntrada)

Exclui uma previsão de entrada e seus itens

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
    public class RemoverItemExample
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoEntrada = previsaoEntrada_example;  // string | 

            try
            {
                // Exclui uma previsão de entrada e seus itens
                apiInstance.RemoverItem(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoEntrada);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaApi.RemoverItem: " + e.Message );
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
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprevisaoentrada"></a>
# **UpdatePrevisaoEntrada**
> void UpdatePrevisaoEntrada (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoEntrada, PrevisaoEntradaDTO previsaoEntrada2)

Altera uma previsão de entrada

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
    public class UpdatePrevisaoEntradaExample
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeEntradaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoEntrada = previsaoEntrada_example;  // string | 
            var previsaoEntrada2 = new PrevisaoEntradaDTO(); // PrevisaoEntradaDTO | previsaoEntrada

            try
            {
                // Altera uma previsão de entrada
                apiInstance.UpdatePrevisaoEntrada(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoEntrada, previsaoEntrada2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeEntradaApi.UpdatePrevisaoEntrada: " + e.Message );
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
 **previsaoEntrada2** | [**PrevisaoEntradaDTO**](PrevisaoEntradaDTO.md)| previsaoEntrada | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

