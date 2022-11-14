using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XAF_Hangfire_Test.Module.BusinessObjects;

namespace XAF_Hangfire_Test.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class HangfireViewController : ViewController
    {
        private DevExpress.ExpressApp.Actions.SimpleAction UpdateVersionAdjustments;
        public HangfireViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            

            this.UpdateVersionAdjustments = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // UpdateVersionAdjustments
            // 
            this.UpdateVersionAdjustments.Caption = "Update Version Adjustments";
            
            this.UpdateVersionAdjustments.ConfirmationMessage = null;
            this.UpdateVersionAdjustments.Id = "UpdateVersionAdjustments";
            
            this.UpdateVersionAdjustments.TargetObjectType = typeof(Company);
            
            this.UpdateVersionAdjustments.ToolTip = null;
        
            this.UpdateVersionAdjustments.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.UpdateVersionAdjustments_Execute);
            // 
            // UpdateVersion
            // 
            this.Actions.Add(this.UpdateVersionAdjustments);
            this.TargetObjectType = typeof(Company);
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void UpdateVersionAdjustments_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

            Company newPerson = this.ObjectSpace.CreateObject<Company>();
            newPerson.Age = 2;
            newPerson.Nomezinho = "Teste";
            newPerson.ValidUntil = DateTime.Now;

            newPerson.Save();

            

            this.ObjectSpace.CommitChanges();

            this.View.RefreshDataSource();
            this.View.Refresh();
        }
    }
}
