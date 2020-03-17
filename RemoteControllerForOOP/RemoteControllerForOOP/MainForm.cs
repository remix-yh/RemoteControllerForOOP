using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RemoteControllerForOOP
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// リモコンインターフェース
        /// </summary>
        private IRemoteController _remoteController = null;

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

            //メンバ変数に操作用インターフェースを格納
            _remoteController = this.CreateRemoteController(radioButton.Text, txtSendingContent);
        }

        /// <summary>
        /// メーカー名をもとに、コントローラインターフェースを返却
        /// </summary>
        /// <param name="manufacturerName"></param>
        /// <returns></returns>
        private IRemoteController CreateRemoteController(string manufacturerName, TextBox textBox)
        {
            //指定されたメーカーに対応したインスタンスを、インターフェースの形で返却
            if (manufacturerName == "A社")
            {
                return new AManufacturerController(textBox);
            }
            else if (manufacturerName == "B社")
            {
                return new BManufacturerController(textBox);
            }
            else if (manufacturerName == "C社")
            {
                return new CManufacturerController(textBox);
            }
            else
            {
                Debug.Assert(false);
                return null;
            }
        }

        /// <summary>
        /// 電源ボタン押下時イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPower_Click(object sender, EventArgs e)
        {
            _remoteController.PushPowerOnOff();
        }

        /// <summary>
        /// 「1」ボタン押下時イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOne_Click(object sender, EventArgs e)
        {
            _remoteController.PushOne();
        }

        /// <summary>
        /// 「2」ボタン押下時イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwo_Click(object sender, EventArgs e)
        {
            _remoteController.PushTwo();
        }

        /// <summary>
        /// 「3」ボタン押下時イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThree_Click(object sender, EventArgs e)
        {
            _remoteController.PushThree();
        }
    }
}
