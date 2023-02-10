# IO.Swagger.Api.ProdutosApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountByQuery**](ProdutosApi.md#countbyquery) | **GET** /v1/produtos/{codigoDepositante}/count | Retorna quantidade de depositantes cadastradas
[**Create**](ProdutosApi.md#create) | **POST** /v1/produtos/{codigoDepositante} | Adiciona um novo produto
[**FindByDepositante**](ProdutosApi.md#findbydepositante) | **GET** /v1/produtos/{codigoDepositante} | Retorna todos os produtos cadastrados de um Depositante
[**FindById**](ProdutosApi.md#findbyid) | **GET** /v1/produtos/{codigoDepositante}/{codigoProduto} | Retorna produto de um Depositante
[**Remove**](ProdutosApi.md#remove) | **DELETE** /v1/produtos/{codigoDepositante}/{codigoProduto} | Exclui um produto
[**Update**](ProdutosApi.md#update) | **PUT** /v1/produtos/{codigoDepositante}/{codigoProduto} | Altera um produto


<a name="countbyquery"></a>
# **CountByQuery**
> ProdutoDTO CountByQuery (string codigoDepositante)

Retorna quantidade de depositantes cadastradas

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
            var apiInstance = new ProdutosApi();
            var codigoDepositante = codigoDepositante_example;  // string | 

            try
            {
                // Retorna quantidade de depositantes cadastradas
                ProdutoDTO result = apiInstance.CountByQuery(codigoDepositante);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosApi.CountByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoDepositante** | **string**|  | 

### Return type

[**ProdutoDTO**](ProdutoDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> void Create (string codigoDepositante, ProdutoDTO produto)

Adiciona um novo produto

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
            var apiInstance = new ProdutosApi();
            var codigoDepositante = codigoDepositante_example;  // string | 
            var produto = new ProdutoDTO(); // ProdutoDTO | produto

            try
            {
                // Adiciona um novo produto
                apiInstance.Create(codigoDepositante, produto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoDepositante** | **string**|  | 
 **produto** | [**ProdutoDTO**](ProdutoDTO.md)| produto | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbydepositante"></a>
# **FindByDepositante**
> List<ProdutoDTO> FindByDepositante (string codigoDepositante)

Retorna todos os produtos cadastrados de um Depositante

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
    public class FindByDepositanteExample
    {
        public void main()
        {
            var apiInstance = new ProdutosApi();
            var codigoDepositante = codigoDepositante_example;  // string | 

            try
            {
                // Retorna todos os produtos cadastrados de um Depositante
                List&lt;ProdutoDTO&gt; result = apiInstance.FindByDepositante(codigoDepositante);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosApi.FindByDepositante: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoDepositante** | **string**|  | 

### Return type

[**List<ProdutoDTO>**](ProdutoDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyid"></a>
# **FindById**
> ProdutoDTO FindById (string codigoDepositante, string codigoProduto)

Retorna produto de um Depositante

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
            var apiInstance = new ProdutosApi();
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoProduto = codigoProduto_example;  // string | 

            try
            {
                // Retorna produto de um Depositante
                ProdutoDTO result = apiInstance.FindById(codigoDepositante, codigoProduto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosApi.FindById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoDepositante** | **string**|  | 
 **codigoProduto** | **string**|  | 

### Return type

[**ProdutoDTO**](ProdutoDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="remove"></a>
# **Remove**
> void Remove (string codigoDepositante, string codigoProduto)

Exclui um produto

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
            var apiInstance = new ProdutosApi();
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoProduto = codigoProduto_example;  // string | 

            try
            {
                // Exclui um produto
                apiInstance.Remove(codigoDepositante, codigoProduto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosApi.Remove: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoDepositante** | **string**|  | 
 **codigoProduto** | **string**|  | 

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
> void Update (string codigoDepositante, string codigoProduto, ProdutoDTO produto)

Altera um produto

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
            var apiInstance = new ProdutosApi();
            var codigoDepositante = codigoDepositante_example;  // string | 
            var codigoProduto = codigoProduto_example;  // string | 
            var produto = new ProdutoDTO(); // ProdutoDTO | produto

            try
            {
                // Altera um produto
                apiInstance.Update(codigoDepositante, codigoProduto, produto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoDepositante** | **string**|  | 
 **codigoProduto** | **string**|  | 
 **produto** | [**ProdutoDTO**](ProdutoDTO.md)| produto | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

