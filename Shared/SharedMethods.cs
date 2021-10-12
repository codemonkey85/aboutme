namespace aboutme.Shared;

public static class SharedMethods
{
    public static async Task<string> ReadPageContentFromMd(this HttpClient HttpClient, string fileName) =>
        await HttpClient.GetStringAsync(fileName);
}
