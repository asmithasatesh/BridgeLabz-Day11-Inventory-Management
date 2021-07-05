using System.Collections.Generic;
using static InventoryManagement.InventoryUtility;

namespace InventoryManagement
{
    internal interface IMethodsManager
    {
        //Display methods
        void DisplayInventory(List<Rice> ricelist);
        void DisplayInventory(List<Wheat> wheatList);
        void DisplayInventory(List<Pulse> pulseList);
        //Add Methods
        void AddInventory(List<Wheat> wheatList);
        public void AddInventory(List<Pulse> pulseList);
        public void AddInventory(List<Rice> ricelist);
        //Delete Methods
        public void DeleteInventory(List<Rice> riceList);
        public void DeleteInventory(List<Pulse> pulseList);
        public void DeleteInventory(List<Wheat> wheatList);
    }
}