using Gamgaroo.View.Runtime.Abstractions;
using UnityEngine.UI;

namespace Gamgaroo.View.Runtime.Views.Primitives
{
    public sealed class TextView : Text, IView<string>, IView<float>, IView<int>
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