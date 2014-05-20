﻿using System;
using System.Windows.Forms;

namespace Flummery
{
    public partial class frmRename : Form
    {
        int parentBoneIndex;

        public frmRename()
        {
            InitializeComponent();
        }

        public void SetParentNode(int boneID)
        {
            parentBoneIndex = boneID;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var model = SceneManager.Current.Models[0];
            model.SetName(txtName.Text, parentBoneIndex);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
