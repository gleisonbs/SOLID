using System;

namespace ISPLibrary
{
    public interface IAudioBook : ILibraryItem
    {
        int RunTimeInMinutes { get; set; }
    }
}
