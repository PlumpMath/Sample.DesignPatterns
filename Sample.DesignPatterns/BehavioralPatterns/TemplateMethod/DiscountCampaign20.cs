using CuttingEdge.Conditions;

namespace Sample.DesignPatterns.BehavioralPatterns.TemplateMethod
{
    public class DiscountCampaign20 : ACampaign
    {
        protected override void Validation(CampaignInput input)
        {
            Condition.Requires(input.OrderTotal).IsGreaterThan(50);
        }

        protected override decimal GetDiscount()
        {
            return 20;
        }
    }
}