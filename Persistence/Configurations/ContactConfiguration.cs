using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal class ContactConfiguration : object,

	IEntityTypeConfiguration<Domain.Contact>

{
	public ContactConfiguration() : base()
	{

	}

	public void Configure(EntityTypeBuilder<Domain.Contact> builder)
	{
	
		

        builder
            .HasIndex(current => new { current.Name })
            .IsUnique(unique: false)
            ;

        builder
			.HasIndex(current => new { current.LastName })
			.IsUnique(unique: false)
			;

		builder
			.HasIndex(current => new { current.Organization })
			.IsUnique(unique: false);

		builder
			.HasIndex(current => new { current.Position })
			.IsUnique(unique: false)
			;
       
        builder
			.HasIndex(current => new { current.OfficePhone })
			.IsUnique(unique: false)
			;

		builder
			.HasIndex(current => new { current.MobilePhone1 })
			.IsUnique(unique: false)
			;

        builder
            .HasIndex(current => new { current.MobilePhone2 })
            .IsUnique(unique: false)
            ;
        var user =
			new Domain.Contact();
			
		//builder.HasData(data: user);
	
	}
}
