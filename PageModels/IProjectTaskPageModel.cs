using CommunityToolkit.Mvvm.Input;
using expensebuddy.Models;

namespace expensebuddy.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}