using Newtonsoft.Json;
using Start.Net.Entities;

namespace Start.Net.RequestModels.Charges
{
    public class CreateTokenRequest: RequestBase
    { 
        public CreateTokenRequest()
        {
            base.Uri = "/tokens/";
            base.HttpMethod = System.Net.WebRequestMethods.Http.Post;
        }
        public CreateTokenRequest(Card card)
        {
            Number = card.Number;
            Exp_Month = card.ExpireMonth;
            Exp_Year = card.ExpireYear;
            Cvc = card.Cvc.ToString();
            Name = card.Name;


            base.Uri = "/tokens/";
            base.HttpMethod = System.Net.WebRequestMethods.Http.Post;
        }



        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("exp_month")]
        public int Exp_Month { get; set; }

        [JsonProperty("exp_year")]
        public int Exp_Year { get; set; }

        [JsonProperty("cvc")]
        public string Cvc { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
         
    }
}
