namespace WpfMrpSimulatorApp.Models
{
    // JSON 전송용 객체. MQTT용
    public class CheckResult
    {
        public string ClientId { get; set; }

        public string Timestamp { get; set; }

        public string Result { get; set; }
    }
}
