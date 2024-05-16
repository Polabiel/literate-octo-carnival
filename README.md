## 🎪 literate-octo-carnival

### Consumindo uma API Simples

Na aula passada, aprendemos como acessar uma API utilizando o pacote `Microsoft.AspNet.WebApi.Client`. Caso esteja ausente em seu projeto, instale-o utilizando o NuGet Manager no Visual Studio.

### Preparação

1. Instale o pacote `Microsoft.AspNet.WebApi.Client` via NuGet se ainda não estiver presente no seu projeto.
2. Crie uma classe em C# para representar a estrutura do JSON retornado pela API, com cada campo como um atributo da classe. Esta classe será simples, contendo apenas os dados.
   
   Exemplo:
   ```csharp
   public class CEP
   {
       public string cep { get; set; }
       public string logradouro { get; set; }
       public string complemento { get; set; }
       public string bairro { get; set; }
       public string localidade { get; set; }
       public string uf { get; set; }
       public string ibge { get; set; }
   }
   ```

3. Crie um objeto `HttpClient` para se conectar à API:

   ```csharp
   HttpClient _client = new HttpClient();
   _client.BaseAddress = new Uri("<EndereçoDaAPI>");
   ```

### Solicitando e Manipulando os Dados

4. Faça a solicitação dos dados utilizando `GetAsync`:

   ```csharp
   HttpResponseMessage response = await _client.GetAsync("endPointDesejado");
   ```

5. Verifique se a solicitação foi bem-sucedida:

   ```csharp
   response.EnsureSuccessStatusCode();
   ```

6. Extraia e preencha os dados no objeto:

   ```csharp
   try
   {
       var endereco = await response.Content.ReadAsAsync<IEnumerable<CEP>>();
       // Utilize os dados conforme necessário
   }
   catch (Exception ex)
   {
       MessageBox.Show($"Erro ao obter dados da API: {ex.Message}");
   }
   ```

### Criando a Aplicação Cliente

1. Monte uma aplicação cliente capaz de acessar a API e exibir os dados recuperados em uma tela de forma formatada.
2. Se estiver utilizando um formulário, crie campos para cada informação contida no JSON de retorno.

### Exemplo de API

Para exemplificar, utilizaremos o acesso ao endereço `https://opencep.com/v1/13020060`, que retorna um JSON com os seguintes dados:

```json
{ 
 "cep": "13020-060", 
 "logradouro": "Rua Culto à Ciência", 
 "complemento": "até 430/431", 
 "bairro": "Botafogo", 
 "localidade": "Campinas", 
 "uf": "SP", 
 "ibge": "3509502" 
}
```

Agora é sua vez de criar uma aplicação cliente! 🚀
