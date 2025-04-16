using KTVPro.Shared.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTVPro.Shared.Pages
{
    public partial class Rooms
    {
        private PopupModal? modal;

        private void OnShowModal()
        {
            if (modal is not null)
            {
                modal.ShowModal();
            }
        }
    }
}
