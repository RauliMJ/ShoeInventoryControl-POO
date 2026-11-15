
using ShoeInventoryControl_POO.Services;
using ShoeInventoryControl_POO.UI;

InventoryService inventoryService = new InventoryService();

ConsoleMenu menu = new ConsoleMenu(inventoryService);

menu.Run();
