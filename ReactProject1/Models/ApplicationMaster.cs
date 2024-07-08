using System;
using System.Collections.Generic;

namespace ReactProject1.Models;

public partial class ApplicationMaster
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public int? PicklistId { get; set; }

    public int? Value { get; set; }

    public string? ShortCode { get; set; }

    public string? Description { get; set; }

    public bool? IsEnabled { get; set; }

    public int? ProductId { get; set; }

    public int? PartnerId { get; set; }

    public string? InstanceId { get; set; }
}
