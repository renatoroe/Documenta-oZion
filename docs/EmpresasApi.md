# IO.Swagger.Api.EmpresasApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CountByQuery**](EmpresasApi.md#countbyquery) | **GET** /v1/empresas/count | Retorna quantidade das empresas cadastradas
[**CountTransportadoraByQuery**](EmpresasApi.md#counttransportadorabyquery) | **GET** /v1/empresas/transportadoras/count | Retorna quantidade das transportadoras cadastradas
[**Create**](EmpresasApi.md#create) | **POST** /v1/empresas | Adiciona uma nova empresa
[**FindByCNPJ**](EmpresasApi.md#findbycnpj) | **GET** /v1/empresas/cnpjCpf/{CGCCPFEmpresa} | Retorna empresa por CNPJ/CPF
[**FindById**](EmpresasApi.md#findbyid) | **GET** /v1/empresas/{codigoEmpresa} | Retorna empresa por código
[**FindByQuery**](EmpresasApi.md#findbyquery) | **GET** /v1/empresas | Retorna todos as empresas cadastradas
[**FindTransportadoraByQuery**](EmpresasApi.md#findtransportadorabyquery) | **GET** /v1/empresas/transportadoras | Retorna todas as transportadoras cadastradas
[**Remove**](EmpresasApi.md#remove) | **DELETE** /v1/empresas/{codigoEmpresa} | Exclui uma empresa
[**Update**](EmpresasApi.md#update) | **PUT** /v1/empresas/{codigoEmpresa} | Altera uma empresa


<a name="countbyquery"></a>
# **CountByQuery**
> List<Empresa> CountByQuery (string codigoDepositante = null)

Retorna quantidade das empresas cadastradas

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
            var apiInstance = new EmpresasApi();
            var codigoDepositante = codigoDepositante_example;  // string |  (optional) 

            try
            {
                // Retorna quantidade das empresas cadastradas
                List&lt;Empresa&gt; result = apiInstance.CountByQuery(codigoDepositante);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmpresasApi.CountByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoDepositante** | **string**|  | [optional] 

### Return type

[**List<Empresa>**](Empresa.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="counttransportadorabyquery"></a>
# **CountTransportadoraByQuery**
> List<Empresa> CountTransportadoraByQuery ()

Retorna quantidade das transportadoras cadastradas

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
    public class CountTransportadoraByQueryExample
    {
        public void main()
        {
            var apiInstance = new EmpresasApi();

            try
            {
                // Retorna quantidade das transportadoras cadastradas
                List&lt;Empresa&gt; result = apiInstance.CountTransportadoraByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmpresasApi.CountTransportadoraByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Empresa>**](Empresa.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> void Create (EmpresaDTO empresa, string codigoDepositante = null)

Adiciona uma nova empresa

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
            var apiInstance = new EmpresasApi();
            var empresa = new EmpresaDTO(); // EmpresaDTO | empresa
            var codigoDepositante = codigoDepositante_example;  // string |  (optional) 

            try
            {
                // Adiciona uma nova empresa
                apiInstance.Create(empresa, codigoDepositante);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmpresasApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **empresa** | [**EmpresaDTO**](EmpresaDTO.md)| empresa | 
 **codigoDepositante** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbycnpj"></a>
# **FindByCNPJ**
> Empresa FindByCNPJ (string cGCCPFEmpresa)

Retorna empresa por CNPJ/CPF

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
    public class FindByCNPJExample
    {
        public void main()
        {
            var apiInstance = new EmpresasApi();
            var cGCCPFEmpresa = cGCCPFEmpresa_example;  // string | 

            try
            {
                // Retorna empresa por CNPJ/CPF
                Empresa result = apiInstance.FindByCNPJ(cGCCPFEmpresa);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmpresasApi.FindByCNPJ: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cGCCPFEmpresa** | **string**|  | 

### Return type

[**Empresa**](Empresa.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyid"></a>
# **FindById**
> Empresa FindById (string codigoEmpresa)

Retorna empresa por código

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
            var apiInstance = new EmpresasApi();
            var codigoEmpresa = codigoEmpresa_example;  // string | 

            try
            {
                // Retorna empresa por código
                Empresa result = apiInstance.FindById(codigoEmpresa);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmpresasApi.FindById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEmpresa** | **string**|  | 

### Return type

[**Empresa**](Empresa.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findbyquery"></a>
# **FindByQuery**
> List<EmpresaDTO> FindByQuery (string codigoDepositante = null)

Retorna todos as empresas cadastradas

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
            var apiInstance = new EmpresasApi();
            var codigoDepositante = codigoDepositante_example;  // string |  (optional) 

            try
            {
                // Retorna todos as empresas cadastradas
                List&lt;EmpresaDTO&gt; result = apiInstance.FindByQuery(codigoDepositante);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmpresasApi.FindByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoDepositante** | **string**|  | [optional] 

### Return type

[**List<EmpresaDTO>**](EmpresaDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtransportadorabyquery"></a>
# **FindTransportadoraByQuery**
> List<Empresa> FindTransportadoraByQuery ()

Retorna todas as transportadoras cadastradas

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
    public class FindTransportadoraByQueryExample
    {
        public void main()
        {
            var apiInstance = new EmpresasApi();

            try
            {
                // Retorna todas as transportadoras cadastradas
                List&lt;Empresa&gt; result = apiInstance.FindTransportadoraByQuery();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmpresasApi.FindTransportadoraByQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Empresa>**](Empresa.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="remove"></a>
# **Remove**
> void Remove (string codigoEmpresa)

Exclui uma empresa

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
            var apiInstance = new EmpresasApi();
            var codigoEmpresa = codigoEmpresa_example;  // string | 

            try
            {
                // Exclui uma empresa
                apiInstance.Remove(codigoEmpresa);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmpresasApi.Remove: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEmpresa** | **string**|  | 

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
> void Update (string codigoEmpresa, EmpresaDTO empresa)

Altera uma empresa

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
            var apiInstance = new EmpresasApi();
            var codigoEmpresa = codigoEmpresa_example;  // string | 
            var empresa = new EmpresaDTO(); // EmpresaDTO | empresa

            try
            {
                // Altera uma empresa
                apiInstance.Update(codigoEmpresa, empresa);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmpresasApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoEmpresa** | **string**|  | 
 **empresa** | [**EmpresaDTO**](EmpresaDTO.md)| empresa | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

