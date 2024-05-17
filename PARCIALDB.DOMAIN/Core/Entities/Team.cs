using System;
using System.Collections.Generic;

namespace PARCIALDB.DOMAIN.Core.Entities;

public partial class Team
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Country { get; set; }

    public int? NumberChampions { get; set; }
}
