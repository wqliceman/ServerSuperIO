using System.ComponentModel;
using System.Windows.Forms;

namespace TestDeviceDriver
{
    public partial class ContextMenuComponent : Component
    {
        public ContextMenuComponent()
        {
            InitializeComponent();
        }

        public ContextMenuComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public ContextMenuStrip ContextMenuStrip
        {
            get { return this.contextMenuStrip1; }
        }
    }
}