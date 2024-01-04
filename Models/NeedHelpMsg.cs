
namespace PowerBearWebsite_Assembly.Models {
    public class NeedHelpMsg {
        public NeedHelpMsg() { }
        public NeedHelpMsg(string username, string body, bool mine) {
            Username = username;
            Body = body;
            Mine = mine;
        }

        public int ID { get; set; }
        public string Username { get; set; } = "";
        public string Body { get; set; } = "";
        public bool Mine { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public bool IsNotice => Body.StartsWith("[Notice]");
    }
}
