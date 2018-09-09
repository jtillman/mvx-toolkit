using Microsoft.VisualStudio.TemplateWizard;
using System.Collections.Generic;

namespace MvxToolkit.MvxViewModel
{
    public class MvxViewModelWizard : BaseWizard
    {
        public override void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            var safeName = replacementsDictionary[TemplateVariables.SafeItemName];
            if (!safeName.EndsWith("ViewModel"))
                replacementsDictionary[TemplateVariables.SafeItemName] = $"{safeName}ViewModel";
        }
    }
}
