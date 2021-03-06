namespace MvcForum.Plugins.Badges
{
    using System;
    using Core.Interfaces.Badges;
    using Core.Models.Attributes;
    using Core.Models.Entities;

    [Id("52284d2b-7ed6-4154-9ccc-3a7d99b18cca")]
    [Name("MemberForAYear")]
    [DisplayName("Badge.MemberForAYear.Name")]
    [Description("Badge.MemberForAYear.Desc")]
    [Image("MemberForAYearBadge.png")]
    [AwardsPoints(2)]
    public class MemberForAYearBadge : ITimeBadge
    {
        public bool Rule(MembershipUser user)
        {
            var anniversary = new DateTime(user.CreateDate.Year + 1, user.CreateDate.Month, user.CreateDate.Day);
            return DateTime.UtcNow >= anniversary;
        }
    }
}