namespace TheWaterProject2.Models
{
    //interface
    public interface IWaterRepository
    {
        public IQueryable<Project> Projects { get; }    
    }
}
