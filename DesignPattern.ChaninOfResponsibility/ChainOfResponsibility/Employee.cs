using DesignPattern.ChaninOfResponsibility.Models;

namespace DesignPattern.ChaninOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover (Employee SuperVisor)
        {
            this.NextApprover = SuperVisor;

        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);

    }
}
