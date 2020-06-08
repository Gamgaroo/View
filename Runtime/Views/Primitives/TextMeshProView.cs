using Gamgaroo.View.Runtime.Abstractions;
using TMPro;

namespace Gamgaroo.View.Runtime.Views.Primitives
{
    public class TextMeshProView : TextMeshProUGUI, IView<string>, IView<float>, IView<int>
    {
        public void Set(float viewModel)
        {
            text = viewModel.ToString();
        }

        public void Set(int viewModel)
        {
            text = viewModel.ToString();
        }

        public void Set(string viewModel)
        {
            text = viewModel;
        }
    }
}