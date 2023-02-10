# IO.Swagger.Api.InventrioAtravsDoBancoIntermedirioOraintApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindByPendente**](InventrioAtravsDoBancoIntermedirioOraintApi.md#findbypendente) | **GET** /v1/oraint/inventario/{codigoEstabelecimento}/{codigoDepositante} | Retorna lista de Inventários do Oraint pendentes de processamento.
[**Update**](InventrioAtravsDoBancoIntermedirioOraintApi.md#update) | **POST** /v1/oraint/inventario/{codigoEstabelecimento}/{codigoDepositante} | Atualiza o estado da integração de inventário.


<a name="findbypendente"></a>
# **FindByPendente**
> List<XInventarioDTO> FindByPendente (long? codigoEstabelecimento, string codigoDepositante, string tipoIntegracao = null)

Retorna lista de Inventários do Oraint pendentes de processamento.

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
    public class FindByPendenteExample
    {
        public void main()
        {
            var apiInstance = new InventrioAtravsDoBancoIntermedirioOraintApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var tipoIntegracao = tipoIntegracao_example;  // string |  (optional) 

            try
            {
                // Retorna lista de Inventários do Oraint pendentes de processamento.
                List&lt;XInventarioDTO&gt; result = apiInstance.FindByPendente(codigoEstabelecimento, codigoDepositante, tipoIntegracao);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventrioAtravsDoBancoIntermedirioOraintApi.FindByPendente: " + e.Message );
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
 **tipoIntegracao** | **string**|  | [optional] 

### Return type

[**List<XInventarioDTO>**](XInventarioDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> void Update (long? codigoEstabelecimento, string codigoDepositante)

Atualiza o estado da integração de inventário.

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
            var apiInstance = new InventrioAtravsDoBancoIntermedirioOraintApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 

            try
            {
                // Atualiza o estado da integração de inventário.
                apiInstance.Update(codigoEstabelecimento, codigoDepositante);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventrioAtravsDoBancoIntermedirioOraintApi.Update: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

