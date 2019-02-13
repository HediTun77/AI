// <auto-generated>
// Code generated by LUISGen
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
namespace Luis
{
    public class EmailLU: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            AddFlag, 
            CheckMessages, 
            Delete, 
            Forward, 
            None, 
            QueryLastText, 
            ReadAloud, 
            Reply, 
            SearchMessages, 
            SelectItem, 
            SendEmail
        };
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] OrderReference;
            public string[] SenderName;
            public string[] ContactName;
            public string[] EmailPlatform;
            public string[] RelationshipName;
            public string[] Attachment;
            public string[] Message;
            public string[] EmailAddress;
            public string[] Time;
            public string[] Date;
            public string[] PositionReference;
            public string[] FromRelationshipName;
            public string[] Line;
            public string[] Category;
            public string[] SearchTexts;
            public string[] EmailSubject;

            // Built-in entities
            public DateTimeSpec[] datetime;
            public double[] number;
            public double[] ordinal;

            // Instance
            public class _Instance
            {
                public InstanceData[] OrderReference;
                public InstanceData[] SenderName;
                public InstanceData[] ContactName;
                public InstanceData[] EmailPlatform;
                public InstanceData[] RelationshipName;
                public InstanceData[] Attachment;
                public InstanceData[] Message;
                public InstanceData[] EmailAddress;
                public InstanceData[] Time;
                public InstanceData[] Date;
                public InstanceData[] PositionReference;
                public InstanceData[] FromRelationshipName;
                public InstanceData[] Line;
                public InstanceData[] Category;
                public InstanceData[] SearchTexts;
                public InstanceData[] EmailSubject;
                public InstanceData[] datetime;
                public InstanceData[] number;
                public InstanceData[] ordinal;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<EmailLU>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}
