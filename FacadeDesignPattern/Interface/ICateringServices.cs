namespace Sinomtech;
public interface ICateringServices
{
    bool SetCateringService(string service);
    string GetCateringService();
    void SetMenuPlanning(string menuPlanning);
    void CountGuestMenu(int guest);
    void CalculateTotalPrice(decimal pricePerItem);
    void OpenMenu();
}