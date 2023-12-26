using System;
using Lyteshow;
using System.Text.Json;

namespace Lyteshow 
{
    public class LyteFile
    {
        public Metadata? metadata { get; set; }
        public ShowObject[]? objects { get; set; }
    }

    public static class Utils
    {
        public static LyteFile? DeserializeLyte(string json)
        {
            LyteFile? deserializedFile = JsonSerializer.Deserialize<LyteFile>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            if(deserializedFile == null) 
            {
                throw new Exception("Could not deserialize JSON file into a LyteFile!");
            }

            return deserializedFile;
        }
        public static string? SerializeLyte(LyteFile file)
        {
            string? serializedFile = JsonSerializer.Serialize<LyteFile>(file);
            
            if(serializedFile == null)
            {
                throw new Exception("Could not serialize LyteFile into a JSON file!");
            }

            return serializedFile;
        }
    }

    
}