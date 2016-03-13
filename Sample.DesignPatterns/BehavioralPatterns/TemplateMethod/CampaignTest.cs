using System;
using NUnit.Framework;
using Shouldly;

namespace Sample.DesignPatterns.BehavioralPatterns.TemplateMethod
{
    [TestFixture]
    public class CampaignTest
    {
        [Test]
        public void discount_campaign_test()
        {
            var discountCampaign20 = new DiscountCampaign20();

            var result = discountCampaign20.Apply(new CampaignInput() { OrderTotal = 10 });
            result.IsSuccess.ShouldBe(false);
            result.Discount.ShouldBe(0);

            result = discountCampaign20.Apply(new CampaignInput() { OrderTotal = 60 });
            result.IsSuccess.ShouldBe(true);
            result.Discount.ShouldBe(20);

            var discountCampaign30 = new DiscountCampaign30();
            result = discountCampaign30.Apply(new CampaignInput() { OrderTotal = 10 });
            result.IsSuccess.ShouldBe(false);

            result = discountCampaign30.Apply(new CampaignInput() { OrderTotal = 100 });
            result.IsSuccess.ShouldBe(true);
            result.Discount.ShouldBe(30);
        }

    }
}