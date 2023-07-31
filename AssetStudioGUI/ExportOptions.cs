﻿using AssetStudio;
using System;
using System.Windows.Forms;

namespace AssetStudioGUI {
	public partial class ExportOptions : Form {

		private ImageFormat m_newFormat;

		public ExportOptions() {
			InitializeComponent();
			assetGroupOptions.SelectedIndex = Properties.Settings.Default.assetGroupOption;
			restoreExtensionName.Checked = Properties.Settings.Default.restoreExtensionName;
			converttexture.Checked = Properties.Settings.Default.convertTexture;
			convertAudio.Checked = Properties.Settings.Default.convertAudio;

			m_newFormat = Properties.Settings.Default.convertType;
			switch (m_newFormat) {
			case ImageFormat.Jpeg:
				tojpg.Checked = true;
				break;
			case ImageFormat.Png:
				topng.Checked = true;
				break;
			case ImageFormat.Bmp:
				tobmp.Checked = true;
				break;
			case ImageFormat.Tga:
				totga.Checked = true;
				break;
			}
			/*var str = Properties.Settings.Default.convertType.ToString();
			foreach (Control c in panel1.Controls) {
				if (c.Text == str) {
					((RadioButton)c).Checked = true;
					break;
				}
			}*/
			openAfterExport.Checked = Properties.Settings.Default.openAfterExport;
			eulerFilter.Checked = Properties.Settings.Default.eulerFilter;
			filterPrecision.Value = Properties.Settings.Default.filterPrecision;
			exportAllNodes.Checked = Properties.Settings.Default.exportAllNodes;
			exportSkins.Checked = Properties.Settings.Default.exportSkins;
			exportAnimations.Checked = Properties.Settings.Default.exportAnimations;
			exportBlendShape.Checked = Properties.Settings.Default.exportBlendShape;
			castToBone.Checked = Properties.Settings.Default.castToBone;
			exportAllUvsAsDiffuseMaps.Checked = Properties.Settings.Default.exportAllUvsAsDiffuseMaps;
			boneSize.Value = Properties.Settings.Default.boneSize;
			scaleFactor.Value = Properties.Settings.Default.scaleFactor;
			fbxVersion.SelectedIndex = Properties.Settings.Default.fbxVersion;
			fbxFormat.SelectedIndex = Properties.Settings.Default.fbxFormat;

			jsonStructureCheckBox.Checked = Properties.SettingsOHMS.Default.indentedJson;
		}

		private void OKbutton_Click(object sender, EventArgs e) {
			Properties.Settings.Default.assetGroupOption = assetGroupOptions.SelectedIndex;
			Properties.Settings.Default.restoreExtensionName = restoreExtensionName.Checked;
			Properties.Settings.Default.convertTexture = converttexture.Checked;
			Properties.Settings.Default.convertAudio = convertAudio.Checked;
			/*foreach (Control c in panel1.Controls) {
				if (((RadioButton)c).Checked) {
					Properties.Settings.Default.convertType = (ImageFormat)Enum.Parse(typeof(ImageFormat), c.Text);
					MessageBox.Show(Properties.Settings.Default.convertType.ToString());
					break;
				}
			}*/
			Properties.Settings.Default.convertType = m_newFormat;

			Properties.Settings.Default.openAfterExport = openAfterExport.Checked;
			Properties.Settings.Default.eulerFilter = eulerFilter.Checked;
			Properties.Settings.Default.filterPrecision = filterPrecision.Value;
			Properties.Settings.Default.exportAllNodes = exportAllNodes.Checked;
			Properties.Settings.Default.exportSkins = exportSkins.Checked;
			Properties.Settings.Default.exportAnimations = exportAnimations.Checked;
			Properties.Settings.Default.exportBlendShape = exportBlendShape.Checked;
			Properties.Settings.Default.castToBone = castToBone.Checked;
			Properties.Settings.Default.exportAllUvsAsDiffuseMaps = exportAllUvsAsDiffuseMaps.Checked;
			Properties.Settings.Default.boneSize = boneSize.Value;
			Properties.Settings.Default.scaleFactor = scaleFactor.Value;
			Properties.Settings.Default.fbxVersion = fbxVersion.SelectedIndex;
			Properties.Settings.Default.fbxFormat = fbxFormat.SelectedIndex;
			Properties.Settings.Default.Save();

			Properties.SettingsOHMS.Default.indentedJson = jsonStructureCheckBox.Checked;
			Properties.SettingsOHMS.Default.Save();

			DialogResult = DialogResult.OK;
			Close();
		}

		private void Cancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void tobmp_CheckedChanged(object sender, EventArgs e) {
			if (tobmp.Checked) {
				m_newFormat = ImageFormat.Bmp;
			}
		}

		private void topng_CheckedChanged(object sender, EventArgs e) {
			if (topng.Checked) {
				m_newFormat = ImageFormat.Png;
			}
		}

		private void tojpg_CheckedChanged(object sender, EventArgs e) {
			if (tojpg.Checked) {
				m_newFormat = ImageFormat.Jpeg;
			}
		}

		private void totga_CheckedChanged(object sender, EventArgs e) {
			if (totga.Checked) {
				m_newFormat = ImageFormat.Tga;
			}
		}
	}
}
