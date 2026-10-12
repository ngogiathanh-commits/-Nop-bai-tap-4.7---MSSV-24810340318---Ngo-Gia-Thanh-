namespace Bai47_MDI.Services;

public interface IStatusMessenger
{
    void ShowStatus(string message);
}

public interface IRefreshableChild
{
    void RefreshData();
}
