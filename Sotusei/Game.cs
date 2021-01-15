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

        [JsonProperty("@name")]
        public string Name { get; set; }

        [JsonProperty("@personaname")]
        public string Personaname { get; set; }

        [JsonProperty("@avatarfull")]
        public string Avatarfull { get; set; }


    }
    
}
