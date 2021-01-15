using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotusei {
    public class GameApp {
        [JsonProperty("@appid")]
        public string Appid { get; set; }

        [JsonProperty("@name")]
        public string Name { get; set; }

    }
    public class UserInformation {
        [JsonProperty("@steamid")]
        public string Steamid { get; set; }

        [JsonProperty("@communityvisibilitystate")]
        public string Communityvisibilitystate { get; set; }

        [JsonProperty("@profilestate")]
        public string Profilestate { get; set; }

        [JsonProperty("@personaname")]
        public string Personaname { get; set; }

        [JsonProperty("@profileurl")]
        public string Profileurl { get; set; }

        [JsonProperty("@avatar")]
        public string Avatar { get; set; }

        [JsonProperty("@avatarmedium")]
        public string Avatarmedium { get; set; }

        [JsonProperty("@avatarfull")]
        public string Avatarfull { get; set; }

        [JsonProperty("@avatarhash")]
        public string Avatarhash { get; set; }

        [JsonProperty("@lastlogoff")]
        public string Lastlogoff { get; set; }

        [JsonProperty("@personastate")]
        public string Personastate { get; set; }

        [JsonProperty("@primaryclanid")]
        public string Primaryclanid { get; set; }

        [JsonProperty("@timecreated")]
        public string Timecreated { get; set; }

        [JsonProperty("@personastateflags")]
        public string Personastateflags { get; set; }
    }
    
}
