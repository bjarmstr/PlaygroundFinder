using PlaygroundFinder.Models.ViewModels.Playground;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Services.Interfaces
{
    public interface IPlaygroundService
    {
        Task<PlaygroundVM> Create(PlaygroundCreateVM src);
        Task<PlaygroundVM> Get(Guid id);


    }
}
