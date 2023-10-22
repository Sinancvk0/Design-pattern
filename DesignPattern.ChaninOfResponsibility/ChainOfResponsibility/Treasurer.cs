using DesignPattern.ChaninOfResponsibility.DAL;
using DesignPattern.ChaninOfResponsibility.Models;

namespace DesignPattern.ChaninOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
           AppDbContext appDbContext = new AppDbContext();

            if (req.Amount<=10000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount=req.Amount.ToString();
                customerProcess.Name=req.Name;
                customerProcess.EmployeeName = req.EmployeeName = "Veznedar - Emre Çıvak";
                customerProcess.Description = req.Description = "Para Çekme İşlemi Onaylandı ";
                appDbContext.CustomerProcesses.Add(customerProcess);
                appDbContext.SaveChanges();

            }
            else
            {
                CustomerProcess customerProcess=new CustomerProcess();  
                customerProcess.Amount = req.Amount.ToString(); 
                customerProcess.Name=req.Name;
                customerProcess.EmployeeName= req.EmployeeName = "Veznedar - Emre Çıvak";
                customerProcess.Description = req.Description = "Para Tutarı Limiti AŞtığı için Şube Müdür yardımcısına  yönlendirildi";
                appDbContext.CustomerProcesses.Add(customerProcess) ;
                appDbContext.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
