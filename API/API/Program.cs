using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

// Antes de criar a API, instalar no pacote de Nuget: Newtonsoft.Json
// httpClient : Usado para fazer requisições HTTP, como GET, POST, PUT, DELETE.

// GetAsync: Método assíncrono usado para fazer requisição GET.

// JsonConvert.DeserializeObject: Usado para converter o Json da resposta em um Objeto C#

// quando você marca um metodo como async, o compilador permite o uso de await dentro dele, 
//que é a palavra chave que indica onde o codigo deve esperar por uma operação assincrona

//Quando usa o VOID: Ele não retorna nenhum valor, ele apenas executa a ação de imprimir
//os dados, sempre depende de algum recursp ára eciber algo. Ex: Console.Write tem menu de contexto 


namespace API
{
    class Program
    {
        static async Task Main(string[] args)
        {
        //Criação da instância do HTTPCLIENT
        HttpClient Client = new HttpClient();

            //Defini a URL do API
            string apiUrl = "https://digimon-api.vercel.app/api/digimon";

            //try = enquanto se estiver o verdadeiro ele faz
            try
            {
                HttpResponseMessage response = await Client.GetAsync(apiUrl);
                
                //Verificar se a requisição foi bem-sucedida
                if (response.IsSuccessStatusCode)
                {
                    //Ler o contéudo da resposta como uma string 
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    
                    //converter p Json para um objeto c#
                    var jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonResult);

                    Console.WriteLine("Resposta da API:");

                    //Exibir o resultado
                    //Console.WriteLine(jsonResult);
                
                    foreach ( var produto in jsonObject)
                    {
                        Console.Write($"\n Nome: {produto.name}");
                    }
                    
                
                
                
                }

                else
                {
                    Console.WriteLine($"Erro na requisição: {response.StatusCode}");
                }          
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");  
            }
            finally
            {
                //fechar o httpClient
                Client.Dispose();
            }
        
        
        
        }
    }
}
