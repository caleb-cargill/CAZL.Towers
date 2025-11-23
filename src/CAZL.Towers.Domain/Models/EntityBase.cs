using System;
using System.Collections.Generic;
using System.Text;

namespace CAZL.Towers.Domain.Models;

public class EntityBase : IEntity
{
    public string Id { get; set; }

    public string CreatedBy { get; set; }

    public string ModifiedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime ModifiedAt { get; set; }
}
