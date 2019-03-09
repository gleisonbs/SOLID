using System;

namespace DemoLibrary
{
    public interface IManaged : IBaseEmployee
    {
        IBaseEmployee Manager { get; set; }

        void AssignManager(IBaseEmployee manager);
    }
}
