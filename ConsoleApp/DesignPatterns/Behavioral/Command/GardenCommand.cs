using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Behavioral.Command
{
    public class GardenCommand : ICommand
    {
        private Garden garden;
        private GardenAction action;
        private string plant;

        public GardenCommand(Garden garden, GardenAction action, string plant)
        {
            this.garden = garden;
            this.action = action;
            this.plant = plant;
        }

        public bool Execute()
        {
            switch (action)
            {
                case GardenAction.Plant:
                    return garden.Plant(plant);
                case GardenAction.Remove:
                    return garden.Remove(plant);
            }
            return false;
        }

        public void Undo()
        {
            switch (action)
            {
                case GardenAction.Plant:
                    garden.Remove(plant);
                    break;
                case GardenAction.Remove:
                    garden.Plant(plant);
                    break;
            }
        }
    }
}
