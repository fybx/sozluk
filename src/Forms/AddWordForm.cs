using System;
using System.Windows.Forms;

namespace sozluk
{
    public partial class AddWordForm : Form
    {
        public AddWordForm(string theme, string langCode)
        {
            InitializeComponent();
        }

        #region Methods
        private void ApplyTheme()
        {
            throw new NotImplementedException();
        }

        private void ApplyLanguage()
        {
            throw new NotImplementedException();
        }

        public new(DialogResult, Objects.Word) ShowDialog()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddDefinition_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveDefinition_Click(object sender, EventArgs e)
        {

        }

        private void ListDefinitions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
