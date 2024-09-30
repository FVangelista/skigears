using System;

namespace Core.Entities;

public class BaseEntity
{
    // [Key] -> If the property name is Id EF will auto use it as a primary key, otherwise use the [Key] to specify a primary key.
    public int Id { get; set; }
}
