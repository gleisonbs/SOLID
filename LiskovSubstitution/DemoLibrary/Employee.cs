using System;

namespace DemoLibrary
{
    public class Employee : BaseEmployee, IManaged
    {
        public IBaseEmployee Manager { get; set; } = null;

        public virtual void AssignManager(IBaseEmployee manager)
        {
            Manager = manager;
        }
    }
}
