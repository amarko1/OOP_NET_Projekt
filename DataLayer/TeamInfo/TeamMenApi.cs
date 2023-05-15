using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using Newtonsoft.Json;
using RestSharp;

namespace DataLayer.TeamInfo
{
    public class TeamMenApi
    {
        private const string apiUrl = "https://worldcup-vua.nullbit.hr/men/teams/results";

        public static Task<RestResponse<Team>> GetData()
        {
            var apiClient = new RestClient(apiUrl);
            return apiClient.ExecuteAsync<Team>(new RestRequest());
        }

        public static IList<T> DeserializeData<T>(RestResponse<T> responseData)
        {
            return JsonConvert.DeserializeObject<List<T>>(responseData.Content);
        }
    }
}
