using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using Hangfire.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xpand.XAF.Modules.JobScheduler.Hangfire;

namespace XAF_Hangfire_Test.Module.BusinessObjects
{
    [DefaultClassOptions]
    [JobProvider]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Company : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Company(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        public int Age { get; set; }

        private System.DateTime _validUntill;
        /// <summary>
        /// ValidUntil
        /// </summary>
        [ModelDefault("DisplayFormat", "{0:g}")]
        [ModelDefault("EditMask", "g")]
        public System.DateTime ValidUntill
        {
            get { return _validUntill; }
            set { SetPropertyValue("ValidUntill", ref _validUntill, value); }
        }
        public string Nomezinho { get; set; }

        public Job NewJob { get; set; }
    }
}