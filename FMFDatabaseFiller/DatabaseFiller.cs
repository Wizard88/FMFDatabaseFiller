using DAL;
using DAL.ExternalDatabase;
using System;
using System.Data;
using System.Windows.Forms;

namespace FMFDatabaseFiller
{
    public partial class DatabaseFiller : Form
    {
        private IExternalDatabaseFileReader _reader;

        public DatabaseFiller()
        {
            InitializeComponent();

            _reader = DAL.ExternalDatabase.Scope.Factory.GetDatabaseFileReader();
        }

        private void DatabaseFiller_Load(object sender, System.EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbPath.Text = openFileDialog.FileName;
            }
        }

        private void btnExecute_Click(object sender, System.EventArgs e)
        {
            DataSet dataSet = _reader.GetDataSet(tbPath.Text);
            ICommand _subModulesCommand = GetSubmoduleFiller(dataSet);

            try
            {
                _subModulesCommand.Execute();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.StackTrace, "Error");
            }
        }

        private ICommand GetSubmoduleFiller(DataSet dataSet)
        {
            ICommand _subModulesCommand = null;

            SubModule subModuleEnum = (SubModule)Enum.Parse(typeof(SubModule), dataSet.DataSetName);

            switch (subModuleEnum)
            {
                case SubModule.OdlukeUstavnogSuda:
                    _subModulesCommand = DAL.Submodules.Scope.Factory.GetDecisionsOfTheConstitutionalCourt(dataSet, !cbRunAsTest.Checked); break;
                case SubModule.Povrati:
                    _subModulesCommand = DAL.Submodules.Scope.Factory.GetJudgmentsRefunds(dataSet, !cbRunAsTest.Checked); break;
                case SubModule.Resenja:
                    _subModulesCommand = DAL.Submodules.Scope.Factory.GetJudgmentAndExecutiveResult(dataSet, !cbRunAsTest.Checked); break;
                default:
                    break;
            }

            return _subModulesCommand;
        }
    }
}
