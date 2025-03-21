using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace sys_IATI
{
    public class conexaoIA
    {
        private readonly string _apiKey;
        private readonly string _apiUrl = "https://api.cohere.ai/v1/generate";

        public conexaoIA(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<string> GetAIResponse(string userMessage)
        {
            using (HttpClient client = new HttpClient())
            {
                // Adiciona a chave da API no cabeçalho
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");

                // Cria o corpo da requisição no formato JSON
                var requestBody = new
                {
                    prompt = userMessage, // O texto de entrada para a IA
                    max_tokens = 50, // Número máximo de tokens na resposta
                    temperature = 0.7, // Controla a criatividade da resposta
                    stop_sequences = new[] { "\n" } // Sequências que indicam o fim da resposta
                };

                var jsonContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

                // Faz a requisição POST para a API
                HttpResponseMessage response = await client.PostAsync(_apiUrl, jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    string responseJson = await response.Content.ReadAsStringAsync();
                    var responseObject = JsonConvert.DeserializeObject<dynamic>(responseJson);
                    return responseObject.generations[0].text; // A resposta da Cohere vem no campo "generations"
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro na API: {response.StatusCode}. Resposta: {errorResponse}");
                }
            }
        }
    }
}
    
