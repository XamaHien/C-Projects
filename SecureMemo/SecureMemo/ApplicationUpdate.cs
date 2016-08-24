﻿using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using SecureMemo.Properties;

namespace SecureMemo
{
    public partial class ApplicationUpdate : Form
    {
        public ApplicationUpdate()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplicationUpdate_Load(object sender, EventArgs e)
        {
            LoadFormData();
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            progressWaitControl1.Active = true;
        }

        private void LoadFormData()
        {
            lblBuildDate.Text = Settings.Default.BuildDate.ToShortDateString();
            lblLinkEmail.Text = Settings.Default.ContactEmail;
            lblAuthor.Text = AssemblyCopyright;
            this.Text = "Update";
            lblCurrentVersion.Text = AssemblyVersion;
            lblTrademark.Text = AssemblyProduct;

        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }

        public string AssemblyDescription
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        #endregion

        private void progressWaitControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
