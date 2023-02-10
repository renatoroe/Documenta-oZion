# IO.Swagger.Api.MovimentaoDeUAComTrocaDeClasseApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MovimentacaoComTrocaDeClasse**](MovimentaoDeUAComTrocaDeClasseApi.md#movimentacaocomtrocadeclasse) | **POST** /v1/movimentacao/{codigoEstabelecimento}/{codigoDepositante}/movimenta-troca-classe | Realiza a movimentação de endereços de um endereço de origem para um de destino através de rotina de movimentçaão e faz a troca de classe através do banco intermediário.


<a name="movimentacaocomtrocadeclasse"></a>
# **MovimentacaoComTrocaDeClasse**
> WmasMundialResult MovimentacaoComTrocaDeClasse (long? codigoEstabelecimento, string codigoDepositante, ParametroMovimentaTrocaClasseDTO parametroMovimentaTrocaClasse)

Realiza a movimentação de endereços de um endereço de origem para um de destino através de rotina de movimentçaão e faz a troca de classe através do banco intermediário.

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
    public class MovimentacaoComTrocaDeClasseExample
    {
        public void main()
        {
            var apiInstance = new MovimentaoDeUAComTrocaDeClasseApi();
            var codigoEstabelecimento = 789;  // long? | 
            var codigoDepositante = codigoDepositante_example;  // string | 
            var parametroMovimentaTrocaClasse = new ParametroMovimentaTrocaClasseDTO(); // ParametroMovimentaTrocaClasseDTO | parametroMovimentaTrocaClasse

            try
            {
                // Realiza a movimentação de endereços de um endereço de origem para um de destino através de rotina de movimentçaão e faz a troca de classe através do banco intermediário.
                WmasMundialResult result = apiInstance.MovimentacaoComTrocaDeClasse(codigoEstabelecimento, codigoDepositante, parametroMovimentaTrocaClasse);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MovimentaoDeUAComTrocaDeClasseApi.MovimentacaoComTrocaDeClasse: " + e.Message );
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
 **parametroMovimentaTrocaClasse** | [**ParametroMovimentaTrocaClasseDTO**](ParametroMovimentaTrocaClasseDTO.md)| parametroMovimentaTrocaClasse | 

### Return type

[**WmasMundialResult**](WmasMundialResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

