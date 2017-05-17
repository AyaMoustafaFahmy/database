using Microsoft.EntityFrameworkCore;


namespace DrOffice.Models

{
   
 public class Bill
   
 {
      
   public int    Bill_Num { get; set; }
      
   public int    Bill_Amount { get; set; }
   
   public int    Bill_Date { get; set; }
   
   public int    Bill_DueDate { get; set; }

    
  public UserType Type { get; set; }
  
  }


  
 public class BillContext : DbContext
 
   {
      
  public DbSet<Bill> Bills { get; set; }
       
 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    
    {
       
     optionsBuilder.UseSqlite("Data Source=Office.db");
     
    }
    
   } 
}