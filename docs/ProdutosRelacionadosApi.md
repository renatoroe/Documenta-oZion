# IO.Swagger.Api.ProdutosRelacionadosApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountByQuery**](ProdutosRelacionadosApi.md#countbyquery) | **GET** /v1/produtos-relacionados/count | Conta os produtos relacionados. Filtrados através de uma query string
[**Create**](ProdutosRelacionadosApi.md#create) | **POST** /v1/produtos-relacionados | Relaciona um produto
[**FindById**](ProdutosRelacionadosApi.md#findbyid) | **GET** /v1/produtos-relacionados/{codigoEmpresa}/{codigoProduto}/{tipoUc}/{codigoProdutoRelacionado} | Retorna o produto relacionado através dos atributos identificadores
[**FindByQuery**](ProdutosRelacionadosApi.md#findbyquery) | **GET** /v1/produtos-relacionados | Retorna os produtos relacionados. Filtrados através de uma query string
[**Remove**](ProdutosRelacionadosApi.md#remove) | **DELETE** /v1/produtos-relacionados/{codigoEmpresa}/{codigoProduto}/{tipoUc}/{codigoProdutoRelacionado} | Exclui uma relação de produto
[**Update**](ProdutosRelacionadosApi.md#update) | **PUT** /v1/produtos-relacionados/{codigoEmpresa}/{codigoProduto}/{tipoUc}/{codigoProdutoRelacionado} | Altera o relacionamento de um produto


<a name="countbyquery"></a>
# **CountByQuery**
> long? CountByQuery ()

Conta os produtos relacionados. Filtrados através de uma query string

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
            var apiInstance = new ProdutosRelacionadosApi();

            try
            {
                // Conta os produtos relacionados. Filtrados através de uma query string
                long? result = apiInstance.CountByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosRelacionadosApi.CountByQuery: " + e.Message );
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

<a name="create"></a>
# **Create**
> void Create (ProdutoRelacionado produtoRelacionado)

Relaciona um produto

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
            var apiInstance = new ProdutosRelacionadosApi();
            var produtoRelacionado = new ProdutoRelacionado(); // ProdutoRelacionado | produtoRelacionado

            try
            {
                // Relaciona um produto
                apiInstance.Create(produtoRelacionado);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosRelacionadosApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **produtoRelacionado** | [**ProdutoRelacionado**](ProdutoRelacionado.md)| produtoRelacionado | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyid"></a>
# **FindById**
> ProdutoRelacionado FindById (string codigoEmpresa, string codigoProduto, string tipoUc, string codigoProdutoRelacionado)

Retorna o produto relacionado através dos atributos identificadores

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
            var apiInstance = new ProdutosRelacionadosApi();
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var codigoProduto = codigoProduto_example;  // string | 
            var tipoUc = tipoUc_example;  // string | 
            var codigoProdutoRelacionado = codigoProdutoRelacionado_example;  // string | 

            try
            {
                // Retorna o produto relacionado através dos atributos identificadores
                ProdutoRelacionado result = apiInstance.FindById(codigoEmpresa, codigoProduto, tipoUc, codigoProdutoRelacionado);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosRelacionadosApi.FindById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEmpresa** | **string**|  | 
 **codigoProduto** | **string**|  | 
 **tipoUc** | **string**|  | 
 **codigoProdutoRelacionado** | **string**|  | 

### Return type

[**ProdutoRelacionado**](ProdutoRelacionado.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyquery"></a>
# **FindByQuery**
> List<ProdutoRelacionado> FindByQuery ()

Retorna os produtos relacionados. Filtrados através de uma query string

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
            var apiInstance = new ProdutosRelacionadosApi();

            try
            {
                // Retorna os produtos relacionados. Filtrados através de uma query string
                List&lt;ProdutoRelacionado&gt; result = apiInstance.FindByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosRelacionadosApi.FindByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ProdutoRelacionado>**](ProdutoRelacionado.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="remove"></a>
# **Remove**
> void Remove (string codigoEmpresa, string codigoProduto, string tipoUc, string codigoProdutoRelacionado)

Exclui uma relação de produto

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
            var apiInstance = new ProdutosRelacionadosApi();
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var codigoProduto = codigoProduto_example;  // string | 
            var tipoUc = tipoUc_example;  // string | 
            var codigoProdutoRelacionado = codigoProdutoRelacionado_example;  // string | 

            try
            {
                // Exclui uma relação de produto
                apiInstance.Remove(codigoEmpresa, codigoProduto, tipoUc, codigoProdutoRelacionado);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosRelacionadosApi.Remove: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEmpresa** | **string**|  | 
 **codigoProduto** | **string**|  | 
 **tipoUc** | **string**|  | 
 **codigoProdutoRelacionado** | **string**|  | 

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
> void Update (string codigoEmpresa, string codigoProduto, string tipoUc, string codigoProdutoRelacionado, ProdutoRelacionado produtoRelacionado)

Altera o relacionamento de um produto

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
            var apiInstance = new ProdutosRelacionadosApi();
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var codigoProduto = codigoProduto_example;  // string | 
            var tipoUc = tipoUc_example;  // string | 
            var codigoProdutoRelacionado = codigoProdutoRelacionado_example;  // string | 
            var produtoRelacionado = new ProdutoRelacionado(); // ProdutoRelacionado | produtoRelacionado

            try
            {
                // Altera o relacionamento de um produto
                apiInstance.Update(codigoEmpresa, codigoProduto, tipoUc, codigoProdutoRelacionado, produtoRelacionado);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdutosRelacionadosApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEmpresa** | **string**|  | 
 **codigoProduto** | **string**|  | 
 **tipoUc** | **string**|  | 
 **codigoProdutoRelacionado** | **string**|  | 
 **produtoRelacionado** | [**ProdutoRelacionado**](ProdutoRelacionado.md)| produtoRelacionado | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

