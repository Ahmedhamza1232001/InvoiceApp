﻿namespace Invoice.Core.Models;

public abstract class Addon : BaseEntity
{
    public AddonType AddonType { get; set; }
    public decimal Value { get; set; } 
    public bool IsAuto { get; set; }
    public bool IsPercent { get; set; }
}
