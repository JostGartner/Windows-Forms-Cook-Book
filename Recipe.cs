namespace E_Cookbook;

public class Recipe
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImagePath { get; set; }
    public List<string>? Ingredients { get; set; }
    public List<string>? Instructions { get; set; }
    public Recipe() { }
    public Recipe(string name, string description, string imagePath, List<string> ingredients, List<string> instructions)
    {
        Name = name;
        Description = description;
        ImagePath = imagePath;
        Ingredients = ingredients;
        Instructions = instructions;
    }
}
