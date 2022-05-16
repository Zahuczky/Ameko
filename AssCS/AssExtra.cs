namespace Ameko.AssCS;

/// <summary>
/// Optional extra data in the subtitles.
/// </summary>
/// <author>Zahuczky</author>
public class AssExtra
{
    public string Id { get; set; }
    public string? Key  { get; set; }
    public string Valuetype  { get; set; }
    public string Value  { get; set; }

    public static AssExtra Make(string data)
    {
        if (data.StartsWith("Data:"))
        {
            data = data["Data:".Length..];
        }
        else throw new AssException("Invalid extradata type.");

        var tokens = data.TrimStart().Split(',');


        return new AssExtra
        {
            Id = tokens[0],
            Key = tokens[1],
            Valuetype = tokens[2],
            Value = tokens[3]
        };
    }

}