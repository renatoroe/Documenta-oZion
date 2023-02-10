# IO.Swagger.Api.AutenticacaoApi

All URIs are relative to *http://localhost/wms-api/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AtualizarToken**](AutenticacaoApi.md#atualizartoken) | **PUT** /v1/autenticacao/{refreshToken} | Atualiza validade do token
[**Autenticar**](AutenticacaoApi.md#autenticar) | **POST** /v1/autenticacao | Solicita token
[**IsAdministrator**](AutenticacaoApi.md#isadministrator) | **GET** /v1/autenticacao/usuarios/{usuario}/senhas/{senha} | 
[**LiberarLicencaUsuario**](AutenticacaoApi.md#liberarlicencausuario) | **GET** /v1/autenticacao/usuarios/{usuario}/sistemas/{sistema}/liberar | Liberação da licença por usuário
[**Logout**](AutenticacaoApi.md#logout) | **DELETE** /v1/autenticacao/{accessToken} | Liberação da licença por token
[**TrocarLicencaByCnpj**](AutenticacaoApi.md#trocarlicencabycnpj) | **PUT** /v1/autenticacao/{refreshToken}/CNPJ/{cnpj} | Troca a licença específica de um CNPJ
[**ValidarToken**](AutenticacaoApi.md#validartoken) | **GET** /v1/autenticacao/{accessToken} | Valida informações do token
[**VerificarTokenUsuario**](AutenticacaoApi.md#verificartokenusuario) | **GET** /v1/autenticacao/usuarios/{usuario}/sistemas/{sistema}/token | Valida token x usuário


<a name="atualizartoken"></a>
# **AtualizarToken**
> void AtualizarToken (string refreshToken)

Atualiza validade do token

Atualiza a validade do token informado retornando novo token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AtualizarTokenExample
    {
        public void main()
        {
            var apiInstance = new AutenticacaoApi();
            var refreshToken = refreshToken_example;  // string | 

            try
            {
                // Atualiza validade do token
                apiInstance.AtualizarToken(refreshToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutenticacaoApi.AtualizarToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refreshToken** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autenticar"></a>
# **Autenticar**
> void Autenticar (Autenticacao autenticacao)

Solicita token

Retorna token de autorização para ser utilizado na chamadas das API.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutenticarExample
    {
        public void main()
        {
            var apiInstance = new AutenticacaoApi();
            var autenticacao = new Autenticacao(); // Autenticacao | autenticacao

            try
            {
                // Solicita token
                apiInstance.Autenticar(autenticacao);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutenticacaoApi.Autenticar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **autenticacao** | [**Autenticacao**](Autenticacao.md)| autenticacao | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="isadministrator"></a>
# **IsAdministrator**
> void IsAdministrator (string usuario, string senha)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IsAdministratorExample
    {
        public void main()
        {
            var apiInstance = new AutenticacaoApi();
            var usuario = usuario_example;  // string | 
            var senha = senha_example;  // string | 

            try
            {
                apiInstance.IsAdministrator(usuario, senha);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutenticacaoApi.IsAdministrator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usuario** | **string**|  | 
 **senha** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liberarlicencausuario"></a>
# **LiberarLicencaUsuario**
> void LiberarLicencaUsuario (string usuario, long? sistema)

Liberação da licença por usuário

Recurso responsável por fazer o logout do usuario liberando sua licença.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LiberarLicencaUsuarioExample
    {
        public void main()
        {
            var apiInstance = new AutenticacaoApi();
            var usuario = usuario_example;  // string | 
            var sistema = 789;  // long? | 

            try
            {
                // Liberação da licença por usuário
                apiInstance.LiberarLicencaUsuario(usuario, sistema);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutenticacaoApi.LiberarLicencaUsuario: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usuario** | **string**|  | 
 **sistema** | **long?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> void Logout (string accessToken)

Liberação da licença por token

Recurso responsável por fazer o logout do usuario liberando sua licença.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {
            var apiInstance = new AutenticacaoApi();
            var accessToken = accessToken_example;  // string | 

            try
            {
                // Liberação da licença por token
                apiInstance.Logout(accessToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutenticacaoApi.Logout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trocarlicencabycnpj"></a>
# **TrocarLicencaByCnpj**
> void TrocarLicencaByCnpj (string refreshToken, string cnpj)

Troca a licença específica de um CNPJ

Na autenticação não é informado o CNPJ do estabelecimento, API deverá ser chamada quando houver a necessidade de troca de licença para o CNPJ fixado no sistema .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TrocarLicencaByCnpjExample
    {
        public void main()
        {
            var apiInstance = new AutenticacaoApi();
            var refreshToken = refreshToken_example;  // string | 
            var cnpj = cnpj_example;  // string | 

            try
            {
                // Troca a licença específica de um CNPJ
                apiInstance.TrocarLicencaByCnpj(refreshToken, cnpj);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutenticacaoApi.TrocarLicencaByCnpj: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refreshToken** | **string**|  | 
 **cnpj** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validartoken"></a>
# **ValidarToken**
> void ValidarToken (string accessToken)

Valida informações do token

Valida a validade do token e retorna as informações contidas no mesmo.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidarTokenExample
    {
        public void main()
        {
            var apiInstance = new AutenticacaoApi();
            var accessToken = accessToken_example;  // string | 

            try
            {
                // Valida informações do token
                apiInstance.ValidarToken(accessToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutenticacaoApi.ValidarToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verificartokenusuario"></a>
# **VerificarTokenUsuario**
> void VerificarTokenUsuario (string usuario, long? sistema)

Valida token x usuário

Validar se o token pertence ao usuário e retorna informações do token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VerificarTokenUsuarioExample
    {
        public void main()
        {
            var apiInstance = new AutenticacaoApi();
            var usuario = usuario_example;  // string | 
            var sistema = 789;  // long? | 

            try
            {
                // Valida token x usuário
                apiInstance.VerificarTokenUsuario(usuario, sistema);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutenticacaoApi.VerificarTokenUsuario: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usuario** | **string**|  | 
 **sistema** | **long?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

