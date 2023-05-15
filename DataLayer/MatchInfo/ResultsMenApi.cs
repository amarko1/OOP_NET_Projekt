using DataLayer.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.MatchInfo
{
    public class ResultsMenApi
    {
        private const string apiUrl = "https://worldcup-vua.nullbit.hr/men/matches";

        public static Task<RestResponse<Result>> GetData()
        {
            var apiClient = new RestClient(apiUrl);
            return apiClient.ExecuteAsync<Result>(new RestRequest());
        }

        private static IList<T> DeserializeData<T>(RestResponse<T> responseData)
        {
            return JsonConvert.DeserializeObject<List<T>>(responseData.Content);
        }
    }
}
