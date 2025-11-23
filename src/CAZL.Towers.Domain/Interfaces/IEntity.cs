using System;
using System.Collections.Generic;
using System.Text;

namespace CAZL.Towers.Domain.Interfaces;

public interface IEntity
{
    string Id { get; }
    string CreatedBy { get; }
    string ModifiedBy { get; }
    DateTime CreatedAt { get; }
    DateTime ModifiedAt { get; }
}
