using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Domain.SeedWork;

public abstract class Entity : object
{
	public Entity() : base()
	{
		Id = Guid.NewGuid();
	}

	[Key]
	[Browsable(browsable: false)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public Guid Id { get; protected set; }
}
