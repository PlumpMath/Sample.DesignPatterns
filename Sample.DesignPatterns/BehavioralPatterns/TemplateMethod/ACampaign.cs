using System;

namespace Sample.DesignPatterns.BehavioralPatterns.TemplateMethod
{
    public abstract class ACampaign
    {
        protected abstract void Validation(CampaignInput input);
        protected abstract decimal GetDiscount();

        public CampaignResult Apply(CampaignInput input)
        {
            var result = new CampaignResult() { IsSuccess = true };
            try
            {
                Validation(input);
                result.Discount = GetDiscount();
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ExMessage = ex.Message;
            }

            return result;
        }
    }

    public class CampaignInput
    {
        public decimal OrderTotal { get; set; }
    }

    public class CampaignResult
    {
        public bool IsSuccess { get; set; }
        public string ExMessage { get; set; }
        public decimal Discount { get; set; }
    }
}