# IO.Swagger.Api.PrevisaoDeSaidaApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountByQuery**](PrevisaoDeSaidaApi.md#countbyquery) | **GET** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/count | 
[**CreatePrevisaoSaida**](PrevisaoDeSaidaApi.md#createprevisaosaida) | **POST** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Adiciona uma nova previsão de saida
[**DivergenciaAtendimento**](PrevisaoDeSaidaApi.md#divergenciaatendimento) | **GET** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/divergencia-atendimento/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Retorna a divergência de atendimento da previsão de saída. Considera as reservas realizadas e também o saldo baixado para atendimento das solicitações.
[**FindAll**](PrevisaoDeSaidaApi.md#findall) | **GET** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante} | 
[**FindPrevisaoSaidaByID**](PrevisaoDeSaidaApi.md#findprevisaosaidabyid) | **GET** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Retorna previsão de saída por Empresa/Tipo/Série/Número
[**Remove**](PrevisaoDeSaidaApi.md#remove) | **DELETE** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida}/{sequenciaPrevisaoSaida} | 
[**RemovePrevisaoSaida**](PrevisaoDeSaidaApi.md#removeprevisaosaida) | **DELETE** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Exclui uma previsão de saída
[**UpdatePrevisaoSaida**](PrevisaoDeSaidaApi.md#updateprevisaosaida) | **PUT** /v1/previsao-saida/{codigoEstabelecimento}/{codigoDepositante}/{codigoEmpresa}/{tipoDocumento}/{serieDocumento}/{previsaoSaida} | Altera uma previsão de saída


<a name="countbyquery"></a>
# **CountByQuery**
> void CountByQuery (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa)



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
            var apiInstance = new PrevisaoDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 

            try
            {
                apiInstance.CountByQuery(codigoEstabelecimento, codigoDepositante, codigoEmpresa);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaApi.CountByQuery: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprevisaosaida"></a>
# **CreatePrevisaoSaida**
> void CreatePrevisaoSaida (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoSaida, PrevisaoSaidaDTO previsaoSaida2)

Adiciona uma nova previsão de saida

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
    public class CreatePrevisaoSaidaExample
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoSaida = previsaoSaida_example;  // string | 
            var previsaoSaida2 = new PrevisaoSaidaDTO(); // PrevisaoSaidaDTO | previsaoSaida

            try
            {
                // Adiciona uma nova previsão de saida
                apiInstance.CreatePrevisaoSaida(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoSaida, previsaoSaida2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaApi.CreatePrevisaoSaida: " + e.Message );
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
 **previsaoSaida2** | [**PrevisaoSaidaDTO**](PrevisaoSaidaDTO.md)| previsaoSaida | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="divergenciaatendimento"></a>
# **DivergenciaAtendimento**
> void DivergenciaAtendimento (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoSaida)

Retorna a divergência de atendimento da previsão de saída. Considera as reservas realizadas e também o saldo baixado para atendimento das solicitações.

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
            var apiInstance = new PrevisaoDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoSaida = previsaoSaida_example;  // string | 

            try
            {
                // Retorna a divergência de atendimento da previsão de saída. Considera as reservas realizadas e também o saldo baixado para atendimento das solicitações.
                apiInstance.DivergenciaAtendimento(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoSaida);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaApi.DivergenciaAtendimento: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findall"></a>
# **FindAll**
> void FindAll (long? codigoEstabelecimento, string codigoDepositante)



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
            var apiInstance = new PrevisaoDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 

            try
            {
                apiInstance.FindAll(codigoEstabelecimento, codigoDepositante);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaApi.FindAll: " + e.Message );
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

<a name="findprevisaosaidabyid"></a>
# **FindPrevisaoSaidaByID**
> PrevisaoSaidaDTO FindPrevisaoSaidaByID (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoSaida)

Retorna previsão de saída por Empresa/Tipo/Série/Número

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
    public class FindPrevisaoSaidaByIDExample
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoSaida = previsaoSaida_example;  // string | 

            try
            {
                // Retorna previsão de saída por Empresa/Tipo/Série/Número
                PrevisaoSaidaDTO result = apiInstance.FindPrevisaoSaidaByID(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoSaida);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaApi.FindPrevisaoSaidaByID: " + e.Message );
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

### Return type

[**PrevisaoSaidaDTO**](PrevisaoSaidaDTO.md)

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
            var apiInstance = new PrevisaoDeSaidaApi();
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
                Debug.Print("Exception when calling PrevisaoDeSaidaApi.Remove: " + e.Message );
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

<a name="removeprevisaosaida"></a>
# **RemovePrevisaoSaida**
> void RemovePrevisaoSaida (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoSaida)

Exclui uma previsão de saída

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
    public class RemovePrevisaoSaidaExample
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoSaida = previsaoSaida_example;  // string | 

            try
            {
                // Exclui uma previsão de saída
                apiInstance.RemovePrevisaoSaida(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoSaida);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaApi.RemovePrevisaoSaida: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprevisaosaida"></a>
# **UpdatePrevisaoSaida**
> void UpdatePrevisaoSaida (long? codigoEstabelecimento, string codigoDepositante, string codigoEmpresa, string tipoDocumento, string serieDocumento, string previsaoSaida, PrevisaoSaidaDTO previsaoSaida2)

Altera uma previsão de saída

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
    public class UpdatePrevisaoSaidaExample
    {
        public void main()
        {
            var apiInstance = new PrevisaoDeSaidaApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var tipoDocumento = tipoDocumento_example;  // string | 
            var serieDocumento = serieDocumento_example;  // string | 
            var previsaoSaida = previsaoSaida_example;  // string | 
            var previsaoSaida2 = new PrevisaoSaidaDTO(); // PrevisaoSaidaDTO | previsaoSaida

            try
            {
                // Altera uma previsão de saída
                apiInstance.UpdatePrevisaoSaida(codigoEstabelecimento, codigoDepositante, codigoEmpresa, tipoDocumento, serieDocumento, previsaoSaida, previsaoSaida2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrevisaoDeSaidaApi.UpdatePrevisaoSaida: " + e.Message );
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
 **previsaoSaida2** | [**PrevisaoSaidaDTO**](PrevisaoSaidaDTO.md)| previsaoSaida | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

