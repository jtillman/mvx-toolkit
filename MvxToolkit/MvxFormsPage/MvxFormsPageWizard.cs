using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MvxToolkit.MvxFormsPage
{
    public class MvxFormsPageWizard : BaseWizard
    {
        public override void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            var suffixes = new List<string> { "View", "Page" };
            try
            {
                string baseName = replacementsDictionary[TemplateVariables.SafeItemName];

                foreach (var suffix in suffixes)
                    if (baseName.EndsWith(suffix, StringComparison.InvariantCultureIgnoreCase))
                        baseName.Substring(0, baseName.Length - suffix.Length);

                baseName = string.IsNullOrEmpty(baseName) ? "New" : baseName;

                var dialog = new MvxFormsPageDialog($"{baseName}Page", $"{baseName}ViewModel");
                Canceled = !(dialog.ShowModal() ?? true);
                if (Canceled)
                    return;

                // Add custom parameters.
                replacementsDictionary["$mvxpagetype$"] = dialog.ViewModel.PageType.ViewType;
                replacementsDictionary["$viewattribute$"] = dialog.ViewModel.PageType.Attribute;
                replacementsDictionary["$viewname$"] = dialog.ViewModel.ViewName;
                replacementsDictionary["$viewmodelname$"] = dialog.ViewModel.ViewModelName;
            }
            catch (Exception ex)
            {
                Canceled = true;
                MessageBox.Show(ex.ToString());
            }
        }
    }
}