namespace MvcForum.Core.Data.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using Models.Entities;

    public class GlobalPermissionForRoleMapping : EntityTypeConfiguration<GlobalPermissionForRole>
    {
        public GlobalPermissionForRoleMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.IsTicked).IsRequired();
            HasRequired(x => x.Permission).WithMany(x => x.GlobalPermissionForRoles).Map(x => x.MapKey("Permission_Id")).WillCascadeOnDelete(false);
            HasRequired(x => x.MembershipRole).WithMany(x => x.GlobalPermissionForRole).Map(x => x.MapKey("MembershipRole_Id")).WillCascadeOnDelete(false);
        }
    }
}
