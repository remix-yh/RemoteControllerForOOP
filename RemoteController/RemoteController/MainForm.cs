using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RemoteControllerForOOP
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// A社が選択状態であるかを表す
        /// </summary>
        private bool _isAManufacturerSelected = false;

        /// <summary>
        /// B社が選択状態であるかを表す
        /// </summary>
        private bool _isBManufacturerSelected = false;

        /// <summary>
        /// C社が選択状態であるかを表す
        /// </summary>
        private bool _isCManufacturerSelected = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード時イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //初回はA社を選択
            rdoAManufacturer.Checked = true;
        }

        /// <summary>
        /// //メーカー選択変更時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Manufacturer_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //ラジオボタンがONになった場合のみ処理する
            RadioButton radioButton = sender as RadioButton;
            if (!radioButton.Checked)
            {
                return;
            }

            //全てのメーカーの選択状態をいったんOFF
            _isAManufacturerSelected = false;
            _isBManufacturerSelected = false;
            _isCManufacturerSelected = false;

            //どのメーカーのラジオボタンがONになったか判定
            //そのメーカーのフラグをONにする
            if(radioButton.Text == "A社")
            {
                _isAManufacturerSelected = true;
            }
            else if(radioButton.Text == "B社")
            {
                _isBManufacturerSelected = true;
            }
            else if(radioButton.Text == "C社")
            {
                _isCManufacturerSelected = true;
            }
            else
            {
                Debug.Assert(false);
            }
        }

        /// <summary>
        /// 電源ボタン押下時イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPower_Click(object sender, EventArgs e)
        {
            if (_isAManufacturerSelected)
            {
                txtSendingContent.Text = "A社-電源ボタンON";
            }
            else if (_isBManufacturerSelected)
            {
                txtSendingContent.Text = "B社-電源ボタンON";
            }
            else if (_isCManufacturerSelected)
            {
                txtSendingContent.Text = "C社-電源ボタンON";
            }
            else
            {
                Debug.Assert(false);
            }
        }

        /// <summary>
        /// 「1」ボタン押下時イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (_isAManufacturerSelected)
            {
                txtSendingContent.Text = "A社-「1」ボタンON";
            }
            else if (_isBManufacturerSelected)
            {
                txtSendingContent.Text = "B社-「1」ボタンON";
            }
            else if (_isCManufacturerSelected)
            {
                txtSendingContent.Text = "C社-「1」ボタンON";
            }
            else
            {
                Debug.Assert(false);
            }
        }

        /// <summary>
        /// 「2」ボタン押下時イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (_isAManufacturerSelected)
            {
                txtSendingContent.Text = "A社-「2」ボタンON";
            }
            else if (_isBManufacturerSelected)
            {
                txtSendingContent.Text = "B社-「2」ボタンON";
            }
            else if (_isCManufacturerSelected)
            {
                txtSendingContent.Text = "C社-「2」ボタンON";
            }
            else
            {
                Debug.Assert(false);
            }
        }

        /// <summary>
        /// 「3」ボタン押下時イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThree_Click(object sender, EventArgs e)
        {
            if (_isAManufacturerSelected)
            {
                txtSendingContent.Text = "A社-「3」ボタンON";
            }
            else if (_isBManufacturerSelected)
            {
                txtSendingContent.Text = "B社-「3」ボタンON";
            }
            else if (_isCManufacturerSelected)
            {
                txtSendingContent.Text = "C社-「3」ボタンON";
            }
            else
            {
                Debug.Assert(false);
            }
        }


    }
}
