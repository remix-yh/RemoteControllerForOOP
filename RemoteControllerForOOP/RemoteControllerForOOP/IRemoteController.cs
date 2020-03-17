namespace RemoteControllerForOOP
{
    /// <summary>
    /// リモコンインターフェース
    /// </summary>
    public interface IRemoteController
    {
        /// <summary>
        /// 電源ボタン押下処理
        /// </summary>
        void PushPowerOnOff();

        /// <summary>
        /// 「1」ボタン押下処理
        /// </summary>
        void PushOne();

        /// <summary>
        /// 「2」ボタン押下処理
        /// </summary>
        void PushTwo();

        /// <summary>
        /// 「3」ボタン押下処理
        /// </summary>
        void PushThree();
    }
}
