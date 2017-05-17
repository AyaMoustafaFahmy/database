using Microsoft.EntityFrameworkCore;


namespace DrOffice.Models

{
   
 public class Insurance_company
   
 {
      
   public int    Insurance_company_ID { get; set; }
      
   public string Insurance_company_Name { get; set; }
     
   public string Insurance_company_category { get; set; }
  
   public int    Insurance_company_phone { get; set; }
 
   public string Insurance_company_City { get; set; }
   
   public int    Insurance_company_ZIP { get; set; }
   
   public string Insurance_company_address { get; set; }
   
  public UserType Type { get; set; }
  
  }


  
 public class Insurance_companyContext : DbContext
 
   {
      
  public DbSet<Insurance_company> Insurance_companys { get; set; }
       
 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    
    {
       
     optionsBuilder.UseSqlite("Data Source=Office.db");
     
    }
    
   } 
}