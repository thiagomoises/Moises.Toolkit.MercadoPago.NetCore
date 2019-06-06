using MercadoPago.NetCore.Model.Resources;
using Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Moises.Toolkit.MercadoPago.NetCore.HubClients
{
    public class PlanHubClient : MercadoPagoHubClient, IPlanHubClient
    {
        public PlanHubClient(IHttpClientFactory httpClientFactory, MPOptions options, ITokenHubClient tokenHubClient) : base(httpClientFactory, options, tokenHubClient)
        {
        }

        public async System.Threading.Tasks.Task<Plan> FindAsync(string planId)
        {
            if (string.IsNullOrEmpty(planId))
            {
                this.AddNotification("planId", "planId is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/plans/{planId}");
            var response = await Client.GetAsync(url);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Plan>(stringResponse, MPUtil.JsonSerializerSettings);
        }


        public async System.Threading.Tasks.Task<Plan> SaveAsync(Plan plan)
        {
            if (plan is null)
            {
                this.AddNotification("plan", "plan is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/plans/");

            var content = new StringContent(JsonConvert.SerializeObject(plan, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Plan>(stringResponse, MPUtil.JsonSerializerSettings);
        }

        public async System.Threading.Tasks.Task<Plan> UpdateAsync(Plan plan)
        {
            if (plan is null)
            {
                this.AddNotification("plan", "plan is Required");
            }

            if (this.IsInvalid())
                return null;

            var url = await MPUrlBuildAsync($"/v1/plans/{plan.Id}/");
            var content = new StringContent(JsonConvert.SerializeObject(plan, MPUtil.JsonSerializerSettings), Encoding.UTF8, "application/json");
            var response = await Client.PutAsync(url, content);
            string stringResponse = await this.ExtractResponseAsync(response);
            if (this.IsInvalid())
                return null;
            return JsonConvert.DeserializeObject<Plan>(stringResponse, MPUtil.JsonSerializerSettings);
        }
    }
}
