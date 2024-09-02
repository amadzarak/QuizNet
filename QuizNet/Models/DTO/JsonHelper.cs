public class JsonHelper {
    public readonly static JsonHelper instance = new();

    public static void CheckIfEmptyJson(string json) {
        if (string.IsNullOrWhiteSpace(json)) {
            throw new ArgumentException("JSON string cannot be null or whitespace", nameof(json));
        }
    }
}
