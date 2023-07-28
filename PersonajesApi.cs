using System.Net;
using System.Text.Json;

namespace RPG
{
    public class PersonajesApi
    {        
        public static async Task<string[]> GetNombresPersonajesAsync()
        {
            var listaPersonajes = new List<string>();
            
            var apiUrl = "https://api.opendota.com/api/heroStats";
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {                    
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                    
                    if (response.IsSuccessStatusCode)
                    {                        
                        string jsonResult = await response.Content.ReadAsStringAsync();
                        
                        var personajes = JsonSerializer.Deserialize<List<HeroeDota>>(jsonResult);
                        
                        foreach (var personaje in personajes)
                        {                            
                            listaPersonajes.Add(personaje.localized_name);
                        }
                    }
                    else
                    {                        
                        Console.WriteLine($"Error en la solicitud: {response.StatusCode}");
                    }
                    return listaPersonajes.ToArray();
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine($"Error: {e.Message}");
                string[] NombresDePersonajes = { "Lifestealer", "Templar Assassin", "Mortis", "Gekko", "Bounty Hunter", "Drow Ranger", "Timbersaw", "Killjoy" };
                return NombresDePersonajes;
            }
            
        }    

        public static string[] GetTiposPersonajes()
        {
            string[] TiposDePersonajes = { "Orco", "Mago", "Elfo", "Cazador", "Druida", "Paladin", "Guerrero" };
            return TiposDePersonajes;
        }

        public static string[] GetApodosPersonajes()
        {
            string[] ApodosDePersonajes = { "Naix", "Lanyana", "Gondar", "Drow", "Pam", "Tim", "Jonh", "Oka" };
            return ApodosDePersonajes;
        }
    }    
}