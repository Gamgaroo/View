using Gamgaroo.View.Runtime.Abstractions;
using UnityEngine;

namespace Gamgaroo.View.Runtime.Views
{
    public abstract class View<TViewModel> : MonoBehaviour, IView<TViewModel>
    {
        private TViewModel _current;

        public void Set(TViewModel viewModel)
        {
            if (_current != null)
                Unbind(_current);

            _current = viewModel;

            Bind(_current);
        }

        protected abstract void Bind(TViewModel viewModel);
        protected abstract void Unbind(TViewModel viewModel);
    }
}