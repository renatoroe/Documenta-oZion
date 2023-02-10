# IO.Swagger.Api.MovimentaoDeUAComTrocaDeClasseAtravsDoBancoIntermedirioOraintApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](MovimentaoDeUAComTrocaDeClasseAtravsDoBancoIntermedirioOraintApi.md#create) | **POST** /v2/oraint/movimentoEstoque/{codigoEstabelecimento}/{codigoDepositante} | Adiciona um novo Movimento Estoque no Store ORAINT que será executado pela integração 341 (Movimentação Total) ou 342 (Movimentação por quantidade informada)


<a name="create"></a>
# **Create**
> void Create (long? codigoEstabelecimento, string codigoDepositante, List<MovimentoEstoqueDTO> movimentoEstoque)

Adiciona um novo Movimento Estoque no Store ORAINT que será executado pela integração 341 (Movimentação Total) ou 342 (Movimentação por quantidade informada)

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
            var apiInstance = new MovimentaoDeUAComTrocaDeClasseAtravsDoBancoIntermedirioOraintApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var movimentoEstoque = new List<MovimentoEstoqueDTO>(); // List<MovimentoEstoqueDTO> | movimentoEstoque

            try
            {
                // Adiciona um novo Movimento Estoque no Store ORAINT que será executado pela integração 341 (Movimentação Total) ou 342 (Movimentação por quantidade informada)
                apiInstance.Create(codigoEstabelecimento, codigoDepositante, movimentoEstoque);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MovimentaoDeUAComTrocaDeClasseAtravsDoBancoIntermedirioOraintApi.Create: " + e.Message );
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
 **movimentoEstoque** | [**List&lt;MovimentoEstoqueDTO&gt;**](MovimentoEstoqueDTO.md)| movimentoEstoque | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

