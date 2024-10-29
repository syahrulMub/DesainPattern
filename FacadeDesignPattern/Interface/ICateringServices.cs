namespace Sinomtech;
public interface ICateringServices
{
    void SetMenuPlanning(string menuPlanning);
    void CountGuestMenu(int guest);
    void CalculateTotalPrice(decimal pricePerItem);
    void OpenMenu();
}