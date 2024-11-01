namespace Sinomtech;
public interface ICateringServices
{
    bool SetCateringServices(string service);
    string GetCateringServices();
    void SetMenuPlanning(string menuPlanning);
    void CountGuestMenu(int guest);
    void CalculateTotalPrice(decimal pricePerItem);
    void SetCateringStand();
    void OpenMenu();
}