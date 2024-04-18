using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace modul8_1302220048
{
     class BankTransferConfig
    {
        public string lang {  get; set; } 
        public int threshold { get; set; }
        public int low_fee {  get; set; } 
        public int high_fee { get; set; }

        public string methods { get; set; } 
        public string en {  get; set; }
        public string id { get; set; }



     }

    class MainBankTransferConfig
    {
        public BankTransferConfig dataConfig;

        private string filePath = "C:\\semester 4\\konstruksi perangkat lunak\\bank_transfer_config.json";

        public void ReadJSON()
        {
            string configJsonData = File.ReadAllText(filePath);
            this.dataConfig = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
        }

        public void WriteJSON()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(dataConfig, options);
            File.WriteAllText(filePath, jsonString);
        }

        public void setDefault()
        {
            dataConfig = new BankTransferConfig();
            dataConfig.lang = "en";
            dataConfig.threshold = 25000000;
            dataConfig.low_fee = 6500;
            dataConfig.high_fee = 15000;
            dataConfig.methods = "“RTO", "(real-time)”", "“SKN”", "“RTGS”", "“BI", "FAST”";
            dataConfig.en = "yes";
            dataConfig.id = "ya";
        }

    }
}



 