using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul8_1302220018
{
    internal class ConfigCovid
    {

        public ConfigCovid loadData()
        {
            string data = File.ReadAllText("D:\\Tugas\\Tugas Kuliah\\Semester 4\\KPL\\tpmodul8_1302220018\\tpmodul8_1302220018\\covid_config.json");
            ConfigCovid json = JsonConvert.DeserializeObject<ConfigCovid>(data);
            return json;
        }

        public void UbahSatuan()
        {
            if(satuan_suhu == "celcius")
            {
                satuan_suhu = "fahrenheit";
            } else if (satuan_suhu == "fahrenheit")
            {
                satuan_suhu = "celcius";
            }
        }

        public string satuan_suhu { get; set; }
        public int batas_hari_demam { get; set; }

        public string pesan_ditolak {  get; set; }

        public string pesan_diterima {  get; set; }

        
    }
}
