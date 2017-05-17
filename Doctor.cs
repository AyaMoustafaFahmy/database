using Microsoft.EntityFrameworkCore;


namespace DrOffice.Models

{
   
 public class Doctor
   
 {
      
   public int    DC_ID { get; set; }
      
   public string DC_Name { get; set; }
     
   public string DC_Password { get; set; }
  
   public int    DC_phone { get; set; }
 
   public string DC_gender { get; set; }
   
   public int    DC_age { get; set; }
   
   public string DC_address { get; set; }
 
   public int    DC_SocialSecurityNO { get; set; }

   public string DC_office { get; set; }
    
   public string DC_Email { get; set; }
 
   public string DC_Department_Name { get; set; }
      
  public UserType Type { get; set; }
  
  }


  
 public class DoctorContext : DbContext
 
   {
      
  public DbSet<Doctor> Doctors { get; set; }
       
 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    
    {
       
     optionsBuilder.UseSqlite("Data Source=Office.db");
     
    }
    
   } 
}