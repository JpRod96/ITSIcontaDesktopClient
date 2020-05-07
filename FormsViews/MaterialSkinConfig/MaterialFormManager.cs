using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSIContaDesktopClient.FormsViews.MaterialSkinConfig
{
    public static class MaterialFormManager
    {
        private static MaterialSkinManager formManager = MaterialSkinManager.Instance;

        public static void FormConfig(MaterialForm form)
        {
            formManager.AddFormToManage(form);
            formManager.Theme = MaterialSkinManager.Themes.LIGHT;
            formManager.ColorScheme = new ColorScheme(Primary.Indigo400, Primary.Indigo900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
