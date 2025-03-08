using KTMPos.DAL.Entities.Common;

namespace KTMPos.DAL.Entities
{
    public  class Category:BaseEntity
    {
        public string Name{ get; set; }
        public Login CreatedUser { get; set; }
        public Login ModifiedUser { get; set; } 
        
    }
}
