namespace KTMPos.DAL.Entities
{
    public class Login
    {   
        public int Id { get; set; }
        public string UserName { get; set; }    
        public string Password { get; set; }
        public ICollection<Category> CreatedCategories { get; set; }
        public ICollection<Category> ModifiedCategories { get; set; }


        
    }
}
