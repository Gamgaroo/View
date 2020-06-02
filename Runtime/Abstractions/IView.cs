namespace Gamgaroo.View.Runtime.Abstractions
{
    public interface IView<in TViewModel>
    {
        void Set(TViewModel viewModel);
    }
}