using System.Windows.Forms;

namespace chuyen_de_hoc_tap_doanh_nghiep_06
{
    internal static class FormsManager
    {
        public static void ChangeForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();
            newForm.Show();
        }
    }
}