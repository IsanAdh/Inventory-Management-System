using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTMPos.Desktop.Utilities
{
    public static class DialogMessage
    {
        public static void ShowSuccessAlert(string message,string caption)
        {
            MessageBox.Show(message,caption,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowFailureAlert(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowFailureAlert(List<string> message, string caption)
        {
            string errorList=String.Join(Environment.NewLine, message);
            MessageBox.Show(errorList, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
