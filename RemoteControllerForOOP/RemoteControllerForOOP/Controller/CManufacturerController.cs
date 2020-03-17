using System;
using System.Windows.Forms;

namespace RemoteControllerForOOP
{
    /// <summary>
    /// C社コントローラー
    /// </summary>
    public class CManufacturerController : IRemoteController
    {
        /// <summary>
        /// メーカー名
        /// </summary>
        private const string MANUFACTURER_NAME = "C社";

        /// <summary>
        /// 送信内容テキストボックス
        /// </summary>
        private TextBox _txtSendingContent = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="textBox">送信内容テキストボックス</param>
        public CManufacturerController(TextBox textBox)
        {
            _txtSendingContent = textBox;
        }

        public void PushPowerOnOff()
        {
            _txtSendingContent.Text = String.Format("{0}-{1}", MANUFACTURER_NAME, "電源ボタンON");
        }

        public void PushOne()
        {
            _txtSendingContent.Text = String.Format("{0}-{1}", MANUFACTURER_NAME, "「1」ボタンON");
        }

        public void PushTwo()
        {
            _txtSendingContent.Text = String.Format("{0}-{1}", MANUFACTURER_NAME, "「2」ボタンON");
        }

        public void PushThree()
        {
            _txtSendingContent.Text = String.Format("{0}-{1}", MANUFACTURER_NAME, "「3」ボタンON");
        }
    }
}
