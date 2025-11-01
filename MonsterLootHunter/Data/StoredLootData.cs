namespace MonsterLootHunter.Data;

[Serializable]
public class StoredLootData
{
    public string StoredDataVersion = "1.5.24.7";
    public Dictionary<string, LootData> StoredData = new();
    public Dictionary<uint, string> NormalizedNames = new();
    public bool HasAnyData => StoredData.Count != 0;
}
