namespace Restaurant.Domain.Entities;

internal class Restaurant
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Category { get; set; } = default!;
    public bool HasDeliverty { get; set; }

    public string? ContactEmail { get; set; }
    public string? ContactNumber { get; set; }

    public Address? Address { get; set; } = default!;
    public List<Dish> Dishes { get; set; } = new List<Dish>();
}
