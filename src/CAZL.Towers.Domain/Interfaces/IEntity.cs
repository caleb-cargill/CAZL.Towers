using System;
using System.Collections.Generic;
using System.Text;

namespace CAZL.Towers.Domain.Interfaces;

public interface IEntity
{
    string Id { get; }
    string CreatedBy { get; }
    string LastModifiedBy { get; }
    DateTime CreatedOn { get; }
    DateTime LastModifiedOn { get; }
}
