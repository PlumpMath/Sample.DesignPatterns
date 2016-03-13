using CuttingEdge.Conditions;

namespace Sample.DesignPatterns.BehavioralPatterns.TemplateMethod
{
    public class DiscountCampaign30 : ACampaign
    {
        protected override void Validation(CampaignInput input)
        {
            Condition.Requires(input.OrderTotal).IsGreaterOrEqual(100);
        }

        protected override decimal GetDiscount()
        {
            return 30;
        }
    }
}