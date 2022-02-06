using System;
using SonarMULTI.Supreme_Classes;
using SonarSNKRS;

namespace SonarSUPREME.Supreme_Classes
{
    public partial class SetTimeFrm : TemplateForm
    {
        public SupremeMain form;
        public SetTimeFrm(SupremeMain frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void SetTimeFrm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            form.StartTime = dateTimePicker1.Value;
            form.autoStart = true;
            form.StartTimer();
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            form.autoStart = false;
            form.StartTimer();
            Close();
        }
    }
}
