using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System.Collections.Generic;

namespace MvxToolkit
{
    public class BaseWizard : IWizard
    {
        public bool Canceled { get; set; } = false;

        public virtual void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public virtual void ProjectFinishedGenerating(Project project)
        {
        }

        public virtual void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public virtual void RunFinished()
        {
        }

        public virtual void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
        }

        public virtual bool ShouldAddProjectItem(string filePath)
        {
            return !Canceled;
        }
    }
}
