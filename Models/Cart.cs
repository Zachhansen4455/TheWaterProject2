namespace TheWaterProject2.Models;

public class Cart
{
    public List<CartLine> Lines { get; set; } = new List<CartLine>();

    public void AddItem(Project proj, int quantity)
    {
        CartLine? Line = Lines
            .Where(x => x.Project.ProjectId == proj.ProjectId)
            .FirstOrDefault();
        
        // Has this item already been added to the cart
        if (Line == null)
        {
            Lines.Add(new CartLine
            {
                Project = proj,
                Quantity = quantity
            });
        }
        else
        {
            Line.Quantity += quantity;
        }
    }

    public void RemoveLine(Project proj) => Lines.RemoveAll(x => x.Project.ProjectId == proj.ProjectId);

    public void Clear() => Lines.Clear();

    public Decimal CalculateTotal() => Lines.Sum(x => 25 * x.Quantity);
        
    public class CartLine
    {
        public int CartLineId { get; set; }
        public Project Project { get; set; }
        public int Quantity { get; set; }
    }    
}