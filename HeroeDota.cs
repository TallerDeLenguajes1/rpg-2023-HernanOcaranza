using System.Text.Json;
namespace RPG
{
    public class HeroeDota
    {
        public int id { get; set; }
        public string name { get; set; }
        public string localized_name { get; set; }
        public string primary_attr { get; set; }
        public string attack_type { get; set; }
        public List<string> roles { get; set; }
        public string img { get; set; }
        public string icon { get; set; }
        public int base_health { get; set; }
        public double base_health_regen { get; set; }
        public int base_mana { get; set; }
        public double base_mana_regen { get; set; }
        public double base_armor { get; set; }
        public int base_mr { get; set; }
        public int base_attack_min { get; set; }
        public int base_attack_max { get; set; }
        public int base_str { get; set; }
        public int base_agi { get; set; }
        public int base_int { get; set; }
        public double str_gain { get; set; }
        public double agi_gain { get; set; }
        public double int_gain { get; set; }
        public int attack_range { get; set; }
        public int projectile_speed { get; set; }
        public double attack_rate { get; set; }
        public int base_attack_time { get; set; }
        public double attack_point { get; set; }
        public int move_speed { get; set; }
        public double? turn_rate { get; set; }
        public bool cm_enabled { get; set; }
        public int legs { get; set; }
        public int day_vision { get; set; }
        public int night_vision { get; set; }
        public int hero_id { get; set; }
        public int turbo_picks { get; set; }
        public int turbo_wins { get; set; }
        public int pro_ban { get; set; }
        public int pro_win { get; set; }
        public int pro_pick { get; set; }

        //[JsonProperty("1_pick")]
        public int _1_pick { get; set; }

        //[JsonProperty("1_win")]
        public int _1_win { get; set; }

        //[JsonProperty("2_pick")]
        public int _2_pick { get; set; }

        //[JsonProperty("2_win")]
        public int _2_win { get; set; }

        //[JsonProperty("3_pick")]
        public int _3_pick { get; set; }

        //[JsonProperty("3_win")]
        public int _3_win { get; set; }

        //[JsonProperty("4_pick")]
        public int _4_pick { get; set; }

        //[JsonProperty("4_win")]
        public int _4_win { get; set; }

        //[JsonProperty("5_pick")]
        public int _5_pick { get; set; }

        //[JsonProperty("5_win")]
        public int _5_win { get; set; }

        //[JsonProperty("6_pick")]
        public int _6_pick { get; set; }

        //[JsonProperty("6_win")]
        public int _6_win { get; set; }

        //[JsonProperty("7_pick")]
        public int _7_pick { get; set; }

        //[JsonProperty("7_win")]
        public int _7_win { get; set; }

        //[JsonProperty("8_pick")]
        public int _8_pick { get; set; }

        //[JsonProperty("8_win")]
        public int _8_win { get; set; }
        public int null_pick { get; set; }
        public int null_win { get; set; }
    }  
}